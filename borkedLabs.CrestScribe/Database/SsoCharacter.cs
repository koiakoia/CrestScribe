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

namespace borkedLabs.CrestScribe.Database
{
    public class UserSsoCharacter
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
            }
        }

        public uint UserId { get; set; }

        public string CharacterOwnerHash { get; set; }

        public UInt64 CharacterId { get; set; }

        public bool AlwaysTrackLocation { get; set; }

        public bool ScopeCharacterLocationRead { get; set; }
        public bool ScopeCharacterNavigationWrite { get; set; }
        public bool ScopeEsiLocationReadLocation { get; set; }
        public bool ScopeEsiLocationReadShipType { get; set; }
        public bool ScopeEsiLocationReadOnline { get; set; }
        public bool ScopeEsiUiWriteWaypoint { get; set; }
        public bool ScopeEsiUiOpenWindow { get; set; }

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


        public UserSsoCharacter()
        {
        }
        
        public bool Save()
        {
            using (MySqlConnection sql = SqlContext.GetConnection())
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


        public static UserSsoCharacter Find(uint userId, string characterOwnerHash)
        {
            using (MySqlConnection sql = new MySqlConnection(ScribeSettings.Settings.Database.ConnectionString))
            {
                sql.Open();

                string q = @"SELECT user_id as UserId, refresh_token as RefreshToken, access_token AccessToken,
                                    character_id CharacterId,character_owner_hash CharacterOwnerHash, 
                                    access_token_expiration TokenExpiration, created_at CreatedAt, 
                                    updated_at UpdatedAt, valid Valid,
                                    always_track_location AlwaysTrackLocation,
                                    scope_character_location_read ScopeCharacterLocationRead,
                                    scope_character_navigation_write ScopeCharacterNavigationWrite,
                                    scope_esi_location_read_location ScopeEsiLocationReadLocation,
                                    scope_esi_location_read_ship_type ScopeEsiLocationReadShipType,
                                    scope_esi_location_read_online ScopeEsiLocationReadOnline,
                                    scope_esi_ui_write_waypoint ScopeEsiUiWriteWaypoint,
                                    scope_esi_ui_open_window ScopeEsiUiOpenWindow
                            FROM user_ssocharacter 
                            WHERE character_owner_hash = @characterOwnerHash AND user_id = @UserId";
                return sql.Query<UserSsoCharacter>(q, new { userId = userId, characterOwnerHash = characterOwnerHash }).FirstOrDefault();
            }
        }
    }
}
