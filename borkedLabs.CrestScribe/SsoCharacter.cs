using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eZet.EveLib.DynamicCrest;
using MySql.Data.MySqlClient;
using Dapper;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using NLog;
using borkedLabs.CrestScribe.Database;

namespace borkedLabs.CrestScribe
{
    public enum SsoCharacterState
    {
        Init,
        NoActiveSessionWait,
        WaitingToPoll,
        ErrorSlowdown
    }

    public class SsoCharacter
    {
        private UserSsoCharacter UserSsoCharacter;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Current system id after succesful processing of location, 
        /// otherwise null until it can get a location
        /// </summary>
        private UInt64? currentSystemId;

        private DynamicCrest _crest;
        private Expando _characterCrest;

        /// <summary>
        /// Last time we attempted a location query, successful or not
        /// </summary>
        public DateTime LastLocationQueryAt { get; set; }

        /// <summary>
        /// Last time we got a succesful location result. 
        /// Because it can fail either due to CCP, client logging off, or us.
        /// </summary>
        public DateTime LastSuccessfulLocationQueryAt { get; set; }


        public UInt64 CurrentShipId { get; set; } = 0;

        /// <summary>
        /// Thread-pool timer that fires to add us back onto the query queue
        /// </summary>
        private Timer _pollTimer;

        private object _pollTimerLock = new object();
        /// <summary>
        /// Reference to query queue that we keep adding ourselves to upon the polltimer firing
        /// </summary>
        public BlockingCollection<SsoCharacter> QueryQueue { get;set; }

        public SsoCharacterState State { get; private set; } = SsoCharacterState.Init;

        public SsoCharacter(UserSsoCharacter character)
        {
            UserSsoCharacter = character;
            _crest = new DynamicCrest(UserSsoCharacter.AccessToken);
            _crest.EncodedKey = ScribeSettings.Settings.Sso.EncodedKey;
            _crest.RefreshToken = UserSsoCharacter.RefreshToken;
            _crest.EnableAutomaticTokenRefresh = false;
            LastLocationQueryAt = DateTime.MinValue;
            LastSuccessfulLocationQueryAt = DateTime.MinValue;

            _pollTimer = null;
        }
        
        private void _pollTimerCallback(object state)
        {
            lock(_pollTimerLock)
            {
                _pollTimer.Dispose();

                QueryQueue.Add(this);
            }
        }


        /// <summary>
        /// Attempts to refresh the tokens. Failure of token refresh (bad tokens) may set the valid flag to false.
        /// </summary>
        /// <returns>Whether or not a database update is possible. Valid flag may change instead of Tokens on failure.</returns>
        public async Task<bool> RefreshAccess()
        {
            try
            {
                var response = await _crest.RefreshAccessTokenAsync();

                if (response.TokenType == "Bearer")
                {
                    UserSsoCharacter.AccessToken = response.AccessToken;
                    UserSsoCharacter.RefreshToken = response.RefreshToken;
                    UserSsoCharacter.TokenExpiration = DateTime.UtcNow.AddSeconds(response.ExpiresIn);

                    return true;
                }
            }
            catch (eZet.EveLib.EveAuthModule.EveAuthException e)
            {
                //unforunately we want to be a little effiecient determining key status
                //so see if we got a 400 error
                //we are ignoring other errors because god knows what fuckups can happen by CCP and
                //we dont want to invalidate all our keys
                var webResponse = e.WebException.Response as HttpWebResponse;

                if(webResponse != null)
                {
                    if(webResponse.StatusCode == HttpStatusCode.BadRequest ||
                        webResponse.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        UserSsoCharacter.Valid = false;
                        return true;
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }

            return false;
        }

        public async Task<bool> GetLocationCrest()
        {
            if(_characterCrest == null)
            {
                throw new InvalidOperationException("Character CREST data not fetched");
            }

            try
            {
                Expando location = null;
                try
                {
                    location = await _characterCrest.GetAsync(r => r.location);
                }
                catch { }

                LastLocationQueryAt = DateTime.UtcNow;

                if ( location != null &&
                        location.Properties.ContainsKey("solarSystem"))
                {
                    ulong locationId = (ulong)location["solarSystem"].id;
                    var loc = new CharacterLocation()
                    {
                        CharacterId = UserSsoCharacter.CharacterId,
                        SystemId = locationId
                    };

                    loc.Save();

                    if (LastSuccessfulLocationQueryAt > DateTime.UtcNow.AddSeconds(ScribeSettings.Settings.CrestLocation.JumpValidAgeSeconds))
                    {
                        if (currentSystemId.HasValue && currentSystemId.Value != locationId)
                        {
                            var lochistory = new CharacterLocationHistory()
                            {
                                CharacterId = UserSsoCharacter.CharacterId,
                                PreviousSystemId = currentSystemId.Value,
                                CurrentSystemId = locationId
                            };

                            lochistory.Create();
                        }
                    }

                    currentSystemId = locationId;

                    LastSuccessfulLocationQueryAt = DateTime.UtcNow;

                    return true;
                }

                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }


        public async Task<bool> GetLocationESI()
        {
            try
            {

                // Configure OAuth2 access token for authorization: evesso
                ESI.Client.Configuration.Default.AccessToken = _crest.AccessToken;
                var apiInstance = new ESI.Api.LocationApi();

                ESI.Model.GetCharactersCharacterIdLocationOk locationResponse = null;
                ESI.Model.GetCharactersCharacterIdShipOk shipResponse = null;
                try
                {
                    // Get character location
                    locationResponse = await apiInstance.GetCharactersCharacterIdLocationAsync((int)UserSsoCharacter.CharacterId, "tranquility");
                    shipResponse = await apiInstance.GetCharactersCharacterIdShipAsync((int)UserSsoCharacter.CharacterId, "tranquility");
                }
                catch
                {
                }

                LastLocationQueryAt = DateTime.UtcNow;

                if (shipResponse != null)
                {
                    CurrentShipId = (UInt64)shipResponse.ShipTypeId;
                }

                if (locationResponse != null )
                {
                    ulong locationId = (ulong)locationResponse.SolarSystemId;
                    var loc = new CharacterLocation()
                    {
                        CharacterId = UserSsoCharacter.CharacterId,
                        SystemId = locationId,
                        ShipId = CurrentShipId
                    };

                    loc.Save();

                    if (LastSuccessfulLocationQueryAt > DateTime.UtcNow.AddSeconds(ScribeSettings.Settings.CrestLocation.JumpValidAgeSeconds))
                    {
                        if (currentSystemId.HasValue && currentSystemId.Value != locationId)
                        {
                            var lochistory = new CharacterLocationHistory()
                            {
                                CharacterId = UserSsoCharacter.CharacterId,
                                PreviousSystemId = currentSystemId.Value,
                                CurrentSystemId = locationId,
                                ShipId = CurrentShipId
                            };

                            lochistory.Create();
                        }
                    }

                    currentSystemId = locationId;

                    LastSuccessfulLocationQueryAt = DateTime.UtcNow;


                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ShouldGetLocation()
        {
            return UserSsoCharacter.Valid && (LastLocationQueryAt < DateTime.UtcNow.AddSeconds(ScribeSettings.Settings.CrestLocation.Interval));
        }

        public void SessionWaitFastFoward()
        {
            if(State == SsoCharacterState.NoActiveSessionWait)
            {
                lock(_pollTimerLock)
                {
                    _pollTimer.Dispose();
                    QueryQueue.Add(this);
                }
            }
        }
      
        public async Task Poll()
        {
            if (!UserSsoCharacter.Valid)
            {
                return;
            }


            Session session = null;

            if(!UserSsoCharacter.AlwaysTrackLocation)
            {
                session = Session.Find(UserSsoCharacter.UserId, UserSsoCharacter.CharacterId);
            }
            else
            {
                session = Session.Find(UserSsoCharacter.UserId);
            }

            if(session == null || session.UpdatedAt.AddMinutes(1) < DateTime.UtcNow )
            {
                State = SsoCharacterState.NoActiveSessionWait;
                //not an active session, dont poll as often but also dont continue
                lock (_pollTimerLock)
                {
                    _pollTimer = new Timer(new TimerCallback(_pollTimerCallback), null, 20 * 1000, Timeout.Infinite);
                }

                return;
            }
            if (UserSsoCharacter.TokenExpiration < DateTime.UtcNow)
            {
                bool changed = await RefreshAccess();
                if (changed)
                {
                    UserSsoCharacter.Save();
                }

                if(!UserSsoCharacter.Valid)
                {
                    return;
                }
            }

            // CREST may not return anything when the server is down :/
            /* if(ScopeEsiLocationReadLocation)
             {
                 if ( ShouldGetLocation())
                 {
                     if (!await GetLocationESI())
                     {
                         State = SsoCharacterState.ErrorSlowdown;
                         //not an active char or CREST is having issues, slow down
                         lock (_pollTimerLock)
                         {
                             _pollTimer = new Timer(new TimerCallback(_pollTimerCallback), null, 20 * 1000, Timeout.Infinite);
                         }

                         return;
                     }

                 }
             }
             else*/
            if (UserSsoCharacter.ScopeCharacterLocationRead)
            {
                if (_characterCrest == null)
                {
                    try
                    {
                        _characterCrest = await (await (await _crest.GetAsync(_crest.Host)).GetAsync(r => r.decode)).GetAsync(r => r.character);
                    }
                    catch
                    {
                        _characterCrest = null;
                    }
                }

                if (_characterCrest != null &&
                    ShouldGetLocation())
                {
                    if (!await GetLocationCrest())
                    {
                        State = SsoCharacterState.ErrorSlowdown;
                        //not an active char or CREST is having issues, slow down
                        lock (_pollTimerLock)
                        {
                            _pollTimer = new Timer(new TimerCallback(_pollTimerCallback), null, 20 * 1000, Timeout.Infinite);
                        }

                        return;
                    }

                }
            }

            State = SsoCharacterState.WaitingToPoll;
            lock (_pollTimerLock)
            {
                _pollTimer = new Timer(new TimerCallback(_pollTimerCallback), null, ScribeSettings.Settings.CrestLocation.Interval * 1000, Timeout.Infinite);
            }
        }
    }
}
