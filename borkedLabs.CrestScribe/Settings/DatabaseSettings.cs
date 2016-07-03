using Newtonsoft.Json;

namespace borkedLabs.CrestScribe.Settings
{
    public class DatabaseSettings
    {
        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("schema")]
        public string Schema { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
