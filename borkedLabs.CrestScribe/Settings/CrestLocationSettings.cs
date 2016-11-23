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

        /// <summary>
        /// Max valid age between change of two systems to count
        /// </summary>
        [JsonProperty("jump_valid_age")]
        public int JumpValidAge { get; set; }

        [JsonIgnore]
        public int JumpValidAgeSeconds
        {
            get
            {
                return -1 * JumpValidAge;
            }
        }
    }
}
