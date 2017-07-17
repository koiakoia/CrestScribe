using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using borkedLabs.CrestScribe.Database;

namespace borkedLabs.CrestScribe
{
    public class SiggyUsers
    {
        public static async Task<bool> IsActive(uint userId)
        {
            var redis = ScribeCoreWorker.Redis.GetDatabase();

            return await redis.SetContainsAsync(string.Format("siggy:actives:user#{0}", userId), "active");
        }

        public static async Task<bool> IsActive(uint userId, UInt64 characterId)
        {
            var redis = ScribeCoreWorker.Redis.GetDatabase();

            return await redis.SetContainsAsync(string.Format("siggy:actives:user#{0}", userId), characterId);
        }
    }
}
