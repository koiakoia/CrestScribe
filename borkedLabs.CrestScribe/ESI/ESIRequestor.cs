using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public static string UserAgent { get; set; }

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

                if(r.IsSuccessStatusCode)
                {
                    string result = await r.Content.ReadAsStringAsync();

                    model = JsonConvert.DeserializeObject<T>(result);
                }

                return new ESIResponse<T>(r.StatusCode, model);
            }
        }
    }
}
