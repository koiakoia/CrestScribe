using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borkedLabs.CrestScribe.Settings
{
    public class CommandBusSettings
    {
        /// <summary>
        /// Interval between location query updates in seconds
        /// </summary>
        [JsonProperty("host")]
        public string Host { get; set; }

        /// <summary>
        /// Max valid age between change of two systems to count
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonIgnore]
        public string ConnectionString
        {
            get
            {
                return "@tcp://" + Host + ":" + Port;
            }
        }
    }
}
