using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eZet.EveLib.Core.Util {
    /// <summary>
    ///     Helper class for performing web requests
    /// </summary>
    public static class HttpRequestHelper {
        /// <summary>
        ///     Default content type
        /// </summary>
        public const string ContentType = "application/x-www-form-urlencoded";

        private static readonly TraceSource Trace = new TraceSource("siggy");

        static readonly HttpClient httpClient = new HttpClient();
        public static HttpRequestMessage CreateRequest(HttpMethod method, Uri uri) {
            var request = new HttpRequestMessage(method, uri);
            request.Headers.UserAgent.ParseAdd(Config.UserAgent);
            return request;
        }

        /// <summary>
        ///     Performs a web request against the specified URI, and returns the response content
        /// </summary>
        /// <param name="uri">URI to request</param>
        /// <returns>The response content</returns>
        public static Task<string> RequestAsync(HttpMethod method, Uri uri) {
            var request = CreateRequest(method, uri);
            return GetResponseContentAsync(request);
        }

        /// <summary>
        ///     Performs a web request against the specified URI, and returns the response content
        /// </summary>
        /// <param name="uri">URI to request</param>
        /// <param name="postData"></param>
        /// <returns>The response content</returns>
        public static async Task<string> PostRequestAsync(Uri uri, string postData) {

            using StringContent content = new(postData, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PostAsync(
                uri,
                content);

            if( response.IsSuccessStatusCode )
            {
                return await response.Content.ReadAsStringAsync();
            }

            return null;
        }

        /// <summary>
        ///     Executes a web request using the given request, and returns the HttpWebResponse
        /// </summary>
        /// <param name="request">The web request</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> GetResponseAsync(HttpRequestMessage request) {
            try {
                using HttpResponseMessage response = await httpClient.SendAsync(request);
                if (response != null) {
                    Trace.TraceEvent(TraceEventType.Information, 0,
                        "Response status: " + response.StatusCode);
                }

                return response;
            }
            catch (HttpRequestException e) {
                throw;
            }
        }

        /// <summary>
        ///     Extracts and returns the response content from a HttpWebResponse
        /// </summary>
        /// <param name="response">The HttpWebResponse</param>
        /// <returns></returns>
        public static async Task<string> GetResponseContentAsync(HttpResponseMessage response) {
            string data = await response.Content.ReadAsStringAsync();
            return data;
        }

        public static async Task<string> GetResponseContentAsync(HttpRequestMessage message)
        {
            Trace.TraceEvent(TraceEventType.Start, 0, "Starting request: " + message.RequestUri);
            using HttpResponseMessage response = await httpClient.SendAsync(message);

            Trace.TraceEvent(TraceEventType.Stop, 0, "Finished request: " + message.RequestUri);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return null;
        }
    }
}