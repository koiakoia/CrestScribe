using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using eZet.EveLib.EveAuthModule;
using eZet.EveLib.EveCrestModule;

namespace borkedLabs.CrestScribe
{
    public class SsoCharacter
    {
        private EveCrest _crest;
        public string AccessToken { get; set; }

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
                _crest = new EveCrest(RefreshToken, ScribeSettings.Settings.Sso.EncodedKey);
            }
        }

        public UInt64 CharacterId { get; set; }

        public string CharacterOwnerHash { get; set; }

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

        public DateTime LastLocationQuery { get; set; }

        public Timer _updateTimer;

        public SsoCharacter()
        {
            _crest = new EveCrest(RefreshToken, ScribeSettings.Settings.Sso.EncodedKey);
        }

        public async Task<bool> RefreshAccess()
        {
            return false;
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
            catch
            {
                return false;
            }

            return false;
        }

        public async Task<bool> GetLocation()
        {
            return true;
            try
            {
                var location =
                await
                    (await (await (await _crest.GetRootAsync()).QueryAsync(r => r.Decode)).QueryAsync(r => r.Character))
                        .QueryAsync(r => r.Location);

                LastLocationQuery = DateTime.UtcNow;
                return true;
            }
            catch
            {
                return false;
            }

            return false;
        }

        public async Task Update()
        {
            if (TokenExpiration < DateTime.UtcNow)
            {
                bool success = await RefreshAccess();
            }

            if (ShouldGetLocation())
            {
                await GetLocation();
            }
        }

        public bool ShouldGetLocation()
        {
            return LastLocationQuery < DateTime.UtcNow.AddSeconds(ScribeSettings.Settings.CrestLocation.Interval);
        }
    }
}
