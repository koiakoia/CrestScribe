using System;
using MySql.Data.MySqlClient;
using Dapper;

namespace borkedLabs.CrestScribe
{
    public class CharacterLocationHistory
    {
        public UInt64 CharacterId { get; set; }
        public UInt64 PreviousSystemId { get; set; }
        public UInt64 CurrentSystemId { get; set; }
        public UInt64 ShipId { get; set; } = 0;

        private DateTime _changedAt;
        public DateTime ChangedAt
        {
            get
            {
                return _changedAt;
            }
            set
            {
                _changedAt = DateTime.SpecifyKind(value, DateTimeKind.Utc);
            }
        }

        public bool Create()
        {
            using (MySqlConnection db = Database.GetConnection())
            {
                ChangedAt = DateTime.UtcNow;

                string q = @"INSERT INTO character_location_history (character_id,previous_system_id,current_system_id,changed_at,ship_id) 
                                                    VALUES(@CharacterId,@PreviousSystemId,@CurrentSystemId,@ChangedAt,@ShipId)";

                var count = db.Execute(q, this);
                return count > 0;
            }
        }
    }
}
