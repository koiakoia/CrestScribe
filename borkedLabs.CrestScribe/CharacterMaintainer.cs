using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Diagnostics;
using System.Net.Http;

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

        /// <summary>
        ///     Gets or sets the IEveAuth instance used for Eve SSO.
        /// </summary>
        /// <value>The eve sso.</value>
        public static EveAuth _eveAuth { get; set; } = new EveAuth();

        public CharacterMaintainer(UserSsoCharacter character)
        {
            _userSsoCharacter = character;
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

        public async Task<AuthResponse> refreshAccessTokenAsync()
        {
            var response = await _eveAuth.RefreshAsync(ScribeSettings.Settings.Sso.EncodedKey, _userSsoCharacter.RefreshToken).ConfigureAwait(false);
            return response;
        }

        /// <summary>
        /// Attempts to refresh the tokens. Failure of token refresh (bad tokens) may set the valid flag to false.
        /// </summary>
        /// <returns>Whether or not a database update is possible. Valid flag may change instead of Tokens on failure.</returns>
        public async Task<bool> RefreshAccess()
        {
            try
            {
                var response = await refreshAccessTokenAsync();

                if (response.TokenType == "Bearer")
                {
                    _userSsoCharacter.AccessToken = response.AccessToken;
                    _userSsoCharacter.RefreshToken = response.RefreshToken;
                    _userSsoCharacter.TokenExpiration = DateTime.UtcNow.AddSeconds(response.ExpiresIn);

                    return true;
                }
            }
            catch (HttpRequestException e)
            {
                //unforunately we want to be a little effiecient determining key status
                //so see if we got a 400 error
                //we are ignoring other errors because god knows what fuckups can happen by CCP and
                //we dont want to invalidate all our keys
                if(e.StatusCode.HasValue)
                {
                    if(e.StatusCode == HttpStatusCode.BadRequest ||
                        e.StatusCode == HttpStatusCode.Unauthorized)
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

        private bool? isOnline = null;
        private DateTime lastOnlineCheckTime = DateTime.UtcNow;

        public async Task<bool> GetLocationESI()
        {
            try
            {
                // Configure OAuth2 access token for authorization: evesso
                var client = new ESI.ESIClient()
                {
                    AccessToken = _userSsoCharacter.AccessToken
                };

                ESIResponseLocationLocationv2 locationResponse = null;
                ESIResponseLocationShipv2 shipResponse = null;
                try
                {
                    if (_userSsoCharacter.ScopeEsiLocationReadOnline)
                    {
                        if(!isOnline.HasValue || (DateTime.UtcNow - lastOnlineCheckTime).TotalSeconds > 60)
                        {
                            ESIResponse<ESIResponseLocationOnlinev3> onlineQuery = null;
                            int attempts = 0;

                            do
                            {
                                Debug.WriteLine("[{0}] Online querying {1}", DateTime.Now.ToString(), _userSsoCharacter.CharacterId);
                                onlineQuery = await client.GetOnlinev3((int)_userSsoCharacter.CharacterId);
                            } while ((onlineQuery == null || onlineQuery.StatusCode == HttpStatusCode.BadGateway) && ++attempts < 2);

                            if (onlineQuery.IsSuccessStatus)
                                isOnline = onlineQuery.Result.Online;
                            else
                                isOnline = null;

                            lastOnlineCheckTime = DateTime.UtcNow;
                        }

                    }
                    else
                    {
                        isOnline = true;
                    }

                    if(isOnline.HasValue && isOnline.Value == true)
                    {
                        // Get character location

                        int attempts = 0;
                        ESIResponse<ESIResponseLocationLocationv2> query1 = null;
                        do
                        {
                            Debug.WriteLine("[{0}] Location querying {1}", DateTime.Now.ToString(), _userSsoCharacter.CharacterId);
                            query1 = await client.GetLocationv2((int)_userSsoCharacter.CharacterId);
                        } while ((query1 == null || query1.StatusCode == HttpStatusCode.BadGateway) && ++attempts < 2);
                        locationResponse = query1.Result;

                        attempts = 0;
                        ESIResponse<ESIResponseLocationShipv2> query2;
                        do
                        {
                            Debug.WriteLine("[{0}] Ship querying {1}", DateTime.Now.ToString(), _userSsoCharacter.CharacterId);
                            query2 = await client.GetShipv2((int)_userSsoCharacter.CharacterId);
                        } while ((query2 == null || query2.StatusCode == HttpStatusCode.BadGateway) && ++attempts < 2);
                        shipResponse = query2.Result;
                    }
                }
                catch(Exception ex)
                {
                    logger.Error(ex, "Exception fetching online status");
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
                    await redis.StringSetAsync("siggy:location:character#" + _userSsoCharacter.CharacterId, JsonConvert.SerializeObject(loc), new TimeSpan(0,2,0));

                    Debug.WriteLine("[{0}] Got location {1} for character {2}", DateTime.Now.ToString(), loc.SystemId, _userSsoCharacter.CharacterId);

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
            return _userSsoCharacter.Valid;
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
                Debug.WriteLine("[{0}] Setting timeout {1} s", DateTime.Now.ToString(), timeoutSeconds);
                _pollTimer = new Timer(new TimerCallback(_pollTimerCallback), null, timeoutSeconds * 1000, Timeout.Infinite);
            }
        }

        public async Task Poll()
        {
            Debug.WriteLine("[{0}] Polling character {1}", DateTime.Now.ToString(), _userSsoCharacter.CharacterId);
            if (State == SsoCharacterState.InvalidToken)
            {
                Debug.WriteLine("[{0}] Resyncing invalid token", DateTime.Now.ToString());
                ResyncWithDatabase();
                if (!_userSsoCharacter.Valid)
                    return;
            }


            bool active = false;

            if(!_userSsoCharacter.AlwaysTrackLocation)
            {
                active = await SiggyUsers.IsActive(_userSsoCharacter.UserId, _userSsoCharacter.CharacterId);
            }
            else
            {
                active = await SiggyUsers.IsActive(_userSsoCharacter.UserId);
            }

            if(!active)
            {
                State = SsoCharacterState.NoActiveSessionWait;
                //not an active session, dont poll as often but also dont continue
                setTimer(20);

                return;
            }

            //refresh early to avoid forbidden errors
            if (_userSsoCharacter.TokenExpiration.Subtract(new TimeSpan(0,1,0)) < DateTime.UtcNow)
            {
                Debug.WriteLine("[{0}] Refreshing token", DateTime.Now.ToString());
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
                        setTimer(20);

                        return;
                    }

                }
            }

            State = SsoCharacterState.WaitingToPoll;
            setTimer(ScribeSettings.Settings.CrestLocation.Interval);
        }
    }
}
