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
using borkedLabs.CrestScribe.ESI;
using Newtonsoft.Json;

namespace borkedLabs.CrestScribe
{
    public enum SsoCharacterState
    {
        Init,
        NoActiveSessionWait,
        WaitingToPoll,
        ErrorSlowdown,
        InvalidToken
    }

    public class CharacterMaintainer
    {
        private UserSsoCharacter _userSsoCharacter;

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
        public BlockingCollection<CharacterMaintainer> QueryQueue { get;set; }

        public SsoCharacterState State { get; private set; } = SsoCharacterState.Init;

        public CharacterMaintainer(UserSsoCharacter character)
        {
            _userSsoCharacter = character;
            _crest = new DynamicCrest(_userSsoCharacter.AccessToken);
            _crest.EncodedKey = ScribeSettings.Settings.Sso.EncodedKey;
            _crest.RefreshToken = _userSsoCharacter.RefreshToken;
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
                    _userSsoCharacter.AccessToken = response.AccessToken;
                    _userSsoCharacter.RefreshToken = response.RefreshToken;
                    _userSsoCharacter.TokenExpiration = DateTime.UtcNow.AddSeconds(response.ExpiresIn);

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
                        _userSsoCharacter.Valid = false;
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
                        CharacterId = _userSsoCharacter.CharacterId,
                        SystemId = locationId
                    };

                    var redis = ScribeCoreWorker.Redis.GetDatabase();
                    await redis.StringSetAsync("character-location-" + _userSsoCharacter.CharacterId, JsonConvert.SerializeObject(loc));

                    if (LastSuccessfulLocationQueryAt > DateTime.UtcNow.AddSeconds(ScribeSettings.Settings.CrestLocation.JumpValidAgeSeconds))
                    {
                        if (currentSystemId.HasValue && currentSystemId.Value != locationId)
                        {
                            var lochistory = new CharacterLocationHistory()
                            {
                                CharacterId = _userSsoCharacter.CharacterId,
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
                var client = new ESI.ESIClient()
                {
                    AccessToken = _crest.AccessToken
                };


                ESIResponseLocationLocationv1 locationResponse = null;
                ESIResponseLocationShipv1 shipResponse = null;
                try
                {
                    bool online = true;

                    if(_userSsoCharacter.ScopeEsiLocationReadOnline)
                    {
                        online = false;

                        var onlineQuery = await client.GetOnlinev1((int)_userSsoCharacter.CharacterId);

                        if (onlineQuery.IsSuccessStatus)
                            online = onlineQuery.Result;
                    }

                    if(online)
                    {
                        // Get character location
                        var query1 = await client.GetLocationv1((int)_userSsoCharacter.CharacterId);
                        locationResponse = query1.Result;
                        var query2 = await client.GetShipv1((int)_userSsoCharacter.CharacterId);
                        shipResponse = query2.Result;
                    }
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
                        CharacterId = _userSsoCharacter.CharacterId,
                        SystemId = locationId,
                        ShipId = CurrentShipId
                    };

                    var redis = ScribeCoreWorker.Redis.GetDatabase();
                    await redis.StringSetAsync("character-location-" + _userSsoCharacter.CharacterId, JsonConvert.SerializeObject(loc), new TimeSpan(0,2,0));

                    if (LastSuccessfulLocationQueryAt > DateTime.UtcNow.AddSeconds(ScribeSettings.Settings.CrestLocation.JumpValidAgeSeconds))
                    {
                        if (currentSystemId.HasValue && currentSystemId.Value != locationId)
                        {
                            var lochistory = new CharacterLocationHistory()
                            {
                                CharacterId = _userSsoCharacter.CharacterId,
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
            return _userSsoCharacter.Valid && (LastLocationQueryAt < DateTime.UtcNow.AddSeconds(ScribeSettings.Settings.CrestLocation.Interval));
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

        public void ResyncWithDatabase()
        {
            var charResult = UserSsoCharacter.Find(_userSsoCharacter.UserId, _userSsoCharacter.CharacterOwnerHash);

            if(charResult != null)
            {
                _userSsoCharacter = charResult;
                _crest.AccessToken = _userSsoCharacter.AccessToken;
                _crest.RefreshToken = _userSsoCharacter.RefreshToken;

                //should we reschedule the character?
                if( State == SsoCharacterState.InvalidToken &&
                    charResult.Valid)
                {
                    State = SsoCharacterState.NoActiveSessionWait;
                    setTimer(20);
                }
                else if(!charResult.Valid)
                {
                    State = SsoCharacterState.InvalidToken;
                    setTimer(600);
                }
            }
        }

        private void setTimer(int timeoutSeconds)
        {
            lock (_pollTimerLock)
            {
                _pollTimer = new Timer(new TimerCallback(_pollTimerCallback), null, timeoutSeconds * 1000, Timeout.Infinite);
            }
        }
      
        public async Task Poll()
        {
            if (State == SsoCharacterState.InvalidToken)
            {
                ResyncWithDatabase();
                if (!_userSsoCharacter.Valid)
                    return;
            }


            Session session = null;

            if(!_userSsoCharacter.AlwaysTrackLocation)
            {
                session = Session.Find(_userSsoCharacter.UserId, _userSsoCharacter.CharacterId);
            }
            else
            {
                session = Session.Find(_userSsoCharacter.UserId);
            }

            if(session == null || session.UpdatedAt.AddMinutes(1) < DateTime.UtcNow )
            {
                State = SsoCharacterState.NoActiveSessionWait;
                //not an active session, dont poll as often but also dont continue
                setTimer(20);

                return;
            }
            if (_userSsoCharacter.TokenExpiration < DateTime.UtcNow)
            {
                bool changed = await RefreshAccess();
                if (changed)
                {
                    _userSsoCharacter.Save();
                }

                if (!_userSsoCharacter.Valid)
                {
                    State = SsoCharacterState.InvalidToken;
                    return;
                }
            }

            // CREST may not return anything when the server is down :/
            
            if(_userSsoCharacter.ScopeEsiLocationReadLocation)
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
            else if (_userSsoCharacter.ScopeCharacterLocationRead)
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
                        setTimer(20);

                        return;
                    }

                }
            }

            State = SsoCharacterState.WaitingToPoll;
            lock (_pollTimerLock)
            {
                setTimer(ScribeSettings.Settings.CrestLocation.Interval);
            }
        }
    }
}
