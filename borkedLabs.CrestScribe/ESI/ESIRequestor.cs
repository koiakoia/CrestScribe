using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace borkedLabs.CrestScribe.ESI
{
    public static class ESIRequestor
    {
        public static HttpClient HttpClient = new HttpClient(new Http2CustomHandler());

        public static string UserAgent { get; set; } = "siggy.scribe/1.0.0.0 (siggy.borkedlabs.com)";

        private static Uri defaultBaseUri = new Uri("https://esi.tech.ccp.is/");

        public static Uri BaseUri
        {
            get
            {
                return HttpClient.BaseAddress;
            }
            set
            {
                HttpClient.BaseAddress = value;
            }
        }

        public static void Configure()
        {
            BaseUri = defaultBaseUri;
            HttpClient.DefaultRequestHeaders.Add("User-Agent", UserAgent);
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<ESIResponse<T>> GetAsync<T>(ESIClient client, string methodPath)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, methodPath);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", client.AccessToken);

            using (var r = await HttpClient.SendAsync(requestMessage))
            {
                T model = default(T);

                if (r.IsSuccessStatusCode)
                {
                    string result = await r.Content.ReadAsStringAsync();
                    await RedisTtlCounter.IncrementCounter(string.Format("ttlc:esiSuccess:{0}", r.StatusCode));

                    model = JsonConvert.DeserializeObject<T>(result);
                }
                else
                {
                    await RedisTtlCounter.IncrementCounter(string.Format("ttlc:esiFailure:{0}",r.StatusCode));
                    Debug.WriteLine("[{0}] {1} Method response status code {2}", DateTime.Now.ToString(), methodPath, r.StatusCode);
                }

                return new ESIResponse<T>(r.StatusCode, model);
            }
        }
    }
}
