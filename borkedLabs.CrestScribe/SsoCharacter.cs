using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using eZet.EveLib.DynamicCrest;
using MySql.Data.MySqlClient;
using Dapper;
using System.Net;

namespace borkedLabs.CrestScribe
{
    public class SsoCharacter
    {
        #region SQLFields

        private string _accessToken;
        public string AccessToken
        {
            get
            {
                return _accessToken;
            }
            set
            {
                _accessToken = value;
                _crest.AccessToken = _accessToken;
            }
        }

        private string _refreshToken { get; set; }
        public string RefreshToken
        {
            get
            {
                return _refreshToken;
            }
            set
            {
                _refreshToken = value;
                _crest.RefreshToken = _refreshToken;
            }
        }

        public uint UserId { get; set; }

        public string CharacterOwnerHash { get; set; }

        public UInt64 CharacterId { get; set; }

        private DateTime _tokenExpiration;
        public DateTime TokenExpiration
        {
            get
            {
                return _tokenExpiration;
            }
            set
            {
                _tokenExpiration = DateTime.SpecifyKind(value, DateTimeKind.Utc);
            }
        }

        private DateTime _createdAt;
        public DateTime CreatedAt
        {
            get
            {
                return _createdAt;
            }
            set
            {
                _createdAt = DateTime.SpecifyKind(value, DateTimeKind.Utc);
            }
        }

        private DateTime _updatedAt;
        public DateTime UpdatedAt
        {
            get
            {
                return _updatedAt;
            }
            set
            {
                _updatedAt = DateTime.SpecifyKind(value, DateTimeKind.Utc);
            }
        }

        public bool Valid { get; set; }
        #endregion

        private DynamicCrest _crest;
        private CancellationTokenSource _pollCts = new CancellationTokenSource();
        private Task _task;
        private Expando _characterCrest;

        public DateTime LastLocationQuery { get; set; }

        public SsoCharacter()
        {
            _crest = new DynamicCrest(AccessToken);
            _crest.EncodedKey = ScribeSettings.Settings.Sso.EncodedKey;
            _crest.RefreshToken = RefreshToken;
            _crest.EnableAutomaticTokenRefresh = false;
            LastLocationQuery = DateTime.MinValue;
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
                    AccessToken = response.AccessToken;
                    RefreshToken = response.RefreshToken;
                    TokenExpiration = DateTime.UtcNow.AddSeconds(response.ExpiresIn);

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
                        Valid = false;
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

        public async Task<bool> GetLocation()
        {
            if(_characterCrest == null)
            {
                throw new InvalidOperationException("Character CREST data not fetched");
            }

            try
            {
                var location = await _characterCrest.GetAsync(r => r.location);

                LastLocationQuery = DateTime.UtcNow;

                if (location.Properties.ContainsKey("solarSystem"))
                {
                    ulong locationId = (ulong)location["solarSystem"].id;
                    var loc = new CharacterLocation()
                    {
                        CharacterId = CharacterId,
                        SystemId = locationId
                    };

                    loc.Save();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Save()
        {
            using (MySqlConnection sql = Database.GetConnection())
            {
                UpdatedAt = DateTime.UtcNow;
                string q = @"UPDATE user_ssocharacter SET refresh_token = @RefreshToken, 
                                    access_token = @AccessToken, 
                                    access_token_expiration = @TokenExpiration,
                                    updated_at = @UpdatedAt,
                                    valid = @Valid
                                WHERE character_owner_hash = @CharacterOwnerHash AND user_id = @UserId";

                var count = sql.Execute(q, this);
                return count > 0;
            }
        }

        public bool ShouldGetLocation()
        {
            return Valid && (LastLocationQuery < DateTime.UtcNow.AddSeconds(ScribeSettings.Settings.CrestLocation.Interval));
        }

        private TimeSpan _pollDelay;

        public Task StartCrestPoll()
        {
            if (_task != null)
            {
                return null;
            }

            _pollDelay = new TimeSpan(0, 0, 0, ScribeSettings.Settings.CrestLocation.Interval);
            _task = Task.Run(async () => {
                while (!_pollCts.IsCancellationRequested)
                {
                    await Task.Delay(_pollDelay, _pollCts.Token);

                    if (!_pollCts.IsCancellationRequested)
                        await Poll();
                }
            });

            return _task;
        }

        public async Task Poll()
        {
            if (!Valid)
            {
                //lets exit our polling since are we invalid now
                _pollCts.Cancel();
                return;
            }

            var session = Session.Find(CharacterId, UserId);

            if(session == null || session.UpdatedAt.AddMinutes(1) < DateTime.UtcNow)
            {
                //not an active session, dont poll as often but also dont continue
                _pollDelay = new TimeSpan(0, 0, 0, 60);
                return;
            }
            else
            {
                _pollDelay = new TimeSpan(0, 0, 0, ScribeSettings.Settings.CrestLocation.Interval);
            }

            if (TokenExpiration < DateTime.UtcNow)
            {
                bool changed = await RefreshAccess();
                if (changed)
                {
                    Save();
                }

                if(!Valid)
                {
                    _pollCts.Cancel();
                    return;
                }
            }

            if(_characterCrest == null)
            {
                _characterCrest = await (await (await _crest.GetAsync(_crest.Host)).GetAsync(r => r.decode)).GetAsync(r => r.character);
            }

            if (ShouldGetLocation())
            {
                await GetLocation();
            }
        }

        public void StopCrestPoll()
        {
            _pollCts.Cancel();
            Task.WaitAll(_task);
            _task = null;
        }
    }
}
