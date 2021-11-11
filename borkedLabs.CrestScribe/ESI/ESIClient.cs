using borkedLabs.CrestScribe.ESI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace borkedLabs.CrestScribe.ESI
{
    public class ESIClient
    {
        public string AccessToken;

        public async Task<ESIResponse<ESIResponseLocationLocationv2>> GetLocationv2(int characterId)
        {
            return await ESIRequestor.GetAsync<ESIResponseLocationLocationv2>(this, $"/v2/characters/{characterId}/location");
        }

        public async Task<ESIResponse<ESIResponseLocationShipv1>> GetShipv1(int characterId)
        {
            return await ESIRequestor.GetAsync<ESIResponseLocationShipv1>(this, $"/v1/characters/{characterId}/ship");
        }

        public async Task<ESIResponse<ESIResponseLocationOnlinev3>> GetOnlinev3(int characterId)
        {
            return await ESIRequestor.GetAsync<ESIResponseLocationOnlinev3>(this, $"/v3/characters/{characterId}/online");
        }
    }
}
