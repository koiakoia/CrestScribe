using Newtonsoft.Json;
using System.IO;

namespace borkedLabs.CrestScribe.Settings
{
    public class SettingsRoot
    {
        [JsonProperty("sso")]
        public SsoSettings Sso { get; set; }

        [JsonProperty("database")]
        public DatabaseSettings Database { get; set; }

        [JsonProperty("crest_location")]
        public CrestLocationSettings CrestLocation { get; set; }

        [JsonProperty("worker")]
        public WorkerSettings Worker { get; set; }

        public static SettingsRoot Load(string file)
        {
            using (StreamReader f = File.OpenText(file))
            {
                var serializer = JsonSerializer.CreateDefault();
                var result = (SettingsRoot)serializer.Deserialize(f, typeof(SettingsRoot));

                return result;
            }
        }
    }

}
