using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace borkedLabs.CrestScribe
{
    public class Session
    {
        public string Id { get; set; }
        public UInt64 CharacterId { get; set; }

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

        public static Session Find(uint userId)
        {
            using (MySqlConnection sql = Database.GetConnection())
            {
                sql.Open();

                string q = @"SELECT id Id, character_id CharacterId, updated_at UpdatedAt
                            FROM sessions 
                            WHERE user_id = @userId
                            ORDER BY updated_at DESC
                            LIMIT 1";

                return sql.Query<Session>(q, new { userId = userId }).FirstOrDefault();
            }
        }

        public static Session Find(uint userId, UInt64 characterId)
        {
            using (MySqlConnection sql = Database.GetConnection())
            {
                sql.Open();

                string q = @"SELECT id Id, character_id CharacterId, updated_at UpdatedAt
                            FROM sessions 
                            WHERE character_id = @characterId AND user_id = @userId
                            ORDER BY updated_at DESC
                            LIMIT 1";

                return sql.Query<Session>(q, new { characterId = characterId, userId = userId }).FirstOrDefault();
            }
        }
    }
}
