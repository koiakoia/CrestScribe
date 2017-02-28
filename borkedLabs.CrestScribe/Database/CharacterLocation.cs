using System;
using MySql.Data.MySqlClient;
using Dapper;

namespace borkedLabs.CrestScribe.Database
{
    public class CharacterLocation
    {
        public UInt64 CharacterId { get; set; }
        public UInt64 SystemId { get; set; }
        public UInt64 ShipId { get; set; }

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

        public bool Save()
        {
            using (MySqlConnection db = SqlContext.GetConnection())
            {
                UpdatedAt = DateTime.UtcNow;

                string q = @"INSERT INTO character_location (character_id,system_id,ship_id,updated_at) VALUES(@CharacterId,@SystemId,@ShipId,@UpdatedAt)
                                ON DUPLICATE KEY UPDATE 
                                    system_id = @SystemId,
                                    ship_id = @ShipId,
                                    updated_at = @UpdatedAt";

                var count = db.Execute(q, this);
                return count > 0;
            }
        }
    }
}
