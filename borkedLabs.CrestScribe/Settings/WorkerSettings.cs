using Newtonsoft.Json;

namespace borkedLabs.CrestScribe.Settings
{
    public class WorkerSettings
    {
        /// <summary>
        /// Total number of workers to spawn
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
