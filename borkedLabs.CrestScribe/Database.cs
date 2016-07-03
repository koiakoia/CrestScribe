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
                                    access_token_expiration TokenExpiration, created_at CreatedAt, updated_at UpdatedAt, valid Valid
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
