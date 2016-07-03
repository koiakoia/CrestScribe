using Newtonsoft.Json;

namespace borkedLabs.CrestScribe.Settings
{
    public class CrestLocationSettings
    {
        /// <summary>
        /// Interval between location query updates in seconds
        /// </summary>
        [JsonProperty("interval")]
        public int Interval { get; set; }
    }
}
