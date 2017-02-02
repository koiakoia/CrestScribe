using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace borkedLabs.CrestScribe
{
    class Database
    {
        public static List<SsoCharacter> GetSSOCharacters(DateTime createdAtCutoff)
        {
            var result = new List<SsoCharacter>();
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
                                    scope_esi_ui_write_waypoint ScopeEsiUiWriteWaypoint,
                                    scope_esi_ui_open_window ScopeEsiUiOpenWindow
                            FROM user_ssocharacter WHERE created_at > @createdAtCutoff";
                return sql.Query<SsoCharacter>(q, new { createdAtCutoff = createdAtCutoff } ).ToList();
            }
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ScribeSettings.Settings.Database.ConnectionString);
        }
    }
}
