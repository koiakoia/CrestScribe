using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borkedLabs.CrestScribe.ESI
{
    public class ESIResponseLocationLocationv1
    {
        [JsonProperty("solar_system_id")]
        public UInt64 SolarSystemId { get; set; }

        [JsonProperty("station_id")]
        public UInt64 StationId { get; set; }

        [JsonProperty("structure_id")]
        public UInt64 StructureId { get; set; }
    }

    public class ESIResponseLocationShipv1
    {
        [JsonProperty("ship_item_id")]
        public UInt64 ShipItemId { get; set; }

        [JsonProperty("ship_name")]
        public string ShipName { get; set; }

        [JsonProperty("ship_type_id")]
        public UInt64 ShipTypeId { get; set; }
    }
}
