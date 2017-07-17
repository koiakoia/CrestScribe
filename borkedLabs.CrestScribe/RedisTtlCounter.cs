using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borkedLabs.CrestScribe
{
    public class RedisTtlCounter
    {
        public static async Task IncrementCounter(string key)
        {
            var redis = ScribeCoreWorker.Redis.GetDatabase();


            var unixTimestamp = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

            await redis.SortedSetAddAsync(key, Guid.NewGuid().ToString(), unixTimestamp);
        }
    }
}
