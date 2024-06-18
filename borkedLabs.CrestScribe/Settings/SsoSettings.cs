using Newtonsoft.Json;

namespace borkedLabs.CrestScribe.Settings
{
    public class SsoSettings
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonIgnore]
        public string EncodedKey
        {
            get
            {
                return EveAuth.Encode(Key, Secret);
            }
        }
    }
}
