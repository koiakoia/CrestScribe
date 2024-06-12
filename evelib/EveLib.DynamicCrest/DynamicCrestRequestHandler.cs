using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using eZet.EveLib.Core;
using eZet.EveLib.Core.Cache;
using eZet.EveLib.Core.RequestHandlers;
using eZet.EveLib.Core.Util;
using eZet.EveLib.DynamicCrest.Exceptions;
using eZet.EveLib.DynamicCrest.Models;

namespace eZet.EveLib.DynamicCrest {
    /// <summary>
    ///     Performs requests on the Eve Online CREST API.
    /// </summary>
    public class DynamicCrestRequestHandler {
        /// <summary>
        ///     The default public max concurrent requests
        /// </summary>
        public const int DefaultPublicMaxConcurrentRequests = 30;

        /// <summary>
        ///     The default authed max concurrent requests
        /// </summary>
        public const int DefaultAuthedMaxConcurrentRequests = 10;

        /// <summary>
        ///     The defualt charset
        /// </summary>
        public const string DefaultCharset = "utf-8";

        /// <summary>
        ///     The token type
        /// </summary>
        public const string TokenType = "Bearer";

        private readonly TraceSource _trace = new TraceSource("EveLib", SourceLevels.All);
        private int _authedMaxConcurrentRequests;
        private SemaphoreSlim _authedPool;
        private int _publicMaxConcurrentRequests;
        private SemaphoreSlim _publicPool;

        /// <summary>
        ///     Creates a new DynamicCrestRequestHandler
        /// </summary>
        /// <param name="serializer"></param>
        public DynamicCrestRequestHandler(JsonSerializer serializer) {
            Serializer = serializer;
            PublicMaxConcurrentRequests = DefaultPublicMaxConcurrentRequests;
            AuthedMaxConcurrentRequests = DefaultAuthedMaxConcurrentRequests;
            _publicPool = new SemaphoreSlim(PublicMaxConcurrentRequests, PublicMaxConcurrentRequests);
            _authedPool = new SemaphoreSlim(AuthedMaxConcurrentRequests, AuthedMaxConcurrentRequests);
            UserAgent = Config.UserAgent;
            Cache = Config.CacheFactory("EveCrestCache");
            CacheLevel = CacheLevel.Default;
        }

        /// <summary>
        ///     Gets or sets the cache mode.
        /// </summary>
        /// <value>The cache mode.</value>
        public CacheLevel CacheLevel { get; set; }

        /// <summary>
        ///     Gets or sets the cache used by this request handler
        /// </summary>
        /// <value>The cache.</value>
        public IEveLibCache Cache { get; set; }

        /// <summary>
        ///     Gets or sets the size of the public burst.
        /// </summary>
        /// <value>The size of the public burst.</value>
        public int PublicMaxConcurrentRequests {
            get { return _publicMaxConcurrentRequests; }
            set {
                _publicMaxConcurrentRequests = value;
                _publicPool = new SemaphoreSlim(value, value);
            }
        }

        /// <summary>
        ///     Gets or sets the size of the authed burst.
        /// </summary>
        /// <value>The size of the authed burst.</value>
        public int AuthedMaxConcurrentRequests {
            get { return _authedMaxConcurrentRequests; }
            set {
                _authedMaxConcurrentRequests = value;
                _authedPool = new SemaphoreSlim(value, value);
            }
        }

        /// <summary>
        ///     Sets or gets whether to throw a DeprecatedResourceException when requesting a deprecated resource. This will help
        ///     discover outdated models.
        /// </summary>
        public bool ThrowOnDeprecated { get; set; }

        /// <summary>
        ///     Sets or gets whether to throw a NotImplementedException when requesting a resource model with no ContentType. Used
        ///     for debugging.
        /// </summary>
        public bool ThrowOnMissingContentType { get; set; }

        /// <summary>
        ///     Gets or sets the serializer used to deserialize CREST errors.
        /// </summary>
        public JsonSerializer Serializer { get; set; }

        /// <summary>
        ///     Gets or sets the x requested with.
        /// </summary>
        /// <value>The x requested with.</value>
        public string XRequestedWith { get; set; }

        /// <summary>
        ///     Gets or sets the user agent.
        /// </summary>
        /// <value>The user agent.</value>
        public string UserAgent { get; set; }

        /// <summary>
        ///     post as an asynchronous operation.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="accessToken">The access token.</param>
        /// <param name="postData">The post data.</param>
        /// <returns>Task&lt;System.String&gt;.</returns>
        public async Task<string> PostAsync(Uri uri, string accessToken, string postData) {
            var request = HttpRequestHelper.CreateRequest(HttpMethod.Post, uri);
            request.Content = new StringContent(postData, Encoding.UTF8, "application/json");

            string retval = null;
            request.Headers.Add("Authorization", TokenType + " " + accessToken);

            var response = await requestAsync(request, accessToken);
            if (response.StatusCode == HttpStatusCode.Created) {
                retval = response.Headers.Location.ToString();
            }
            return retval;
        }

        /// <summary>
        ///     put as an asynchronous operation.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="accessToken">The access token.</param>
        /// <param name="postData">The post data.</param>
        /// <returns>Task&lt;System.Boolean&gt;.</returns>
        public async Task<bool> PutAsync(Uri uri, string accessToken, string postData) {
            var request = HttpRequestHelper.CreateRequest(HttpMethod.Put, uri);
            request.Content = new StringContent(postData, Encoding.UTF8, "application/json");

            request.Headers.Add("HttpRequestHeader.Authorization", TokenType + " " + accessToken);

            var response = await requestAsync(request, accessToken);
            var retval = response.StatusCode == HttpStatusCode.OK;
            return retval;
        }


        /// <summary>
        ///     delete as an asynchronous operation.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="accessToken">The access token.</param>
        /// <returns>Task&lt;System.Boolean&gt;.</returns>
        public async Task<bool> DeleteAsync(Uri uri, string accessToken) {
            var request = HttpRequestHelper.CreateRequest(HttpMethod.Delete, uri);
            var response = await requestAsync(request, accessToken);
            var retval = response.StatusCode == HttpStatusCode.OK;
            return retval;
        }


        /// <summary>
        ///     options as an asynchronous operation.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns>Task&lt;CrestOptions&gt;.</returns>
        public async Task<CrestOptions> OptionsAsync(Uri uri) {
            var request = HttpRequestHelper.CreateRequest(HttpMethod.Options, uri);
            var response = await requestAsync(request, null).ConfigureAwait(false);
            var content = await HttpRequestHelper.GetResponseContentAsync(response).ConfigureAwait(false);
            var result = Serializer.Deserialize<CrestOptions>(content);
            //result.ResponseHeaders = response.Headers;
            //result.Uri = uri;
            return result;
        }

        /// <summary>
        ///     head as an asynchronous operation.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="accessToken">The access token.</param>
        /// <returns>Task.</returns>
        public async Task<System.Net.Http.Headers.HttpResponseHeaders> HeadAsync(Uri uri, string accessToken) {
            var request = HttpRequestHelper.CreateRequest(HttpMethod.Head, uri);
            var response = await requestAsync(request, accessToken).ConfigureAwait(false);
            return response.Headers;
            //var content = await HttpRequestHelper.GetResponseContentAsync(response).ConfigureAwait(false);
            //var result = Serializer.Deserialize<CrestOptions>(content);
        }

        /// <summary>
        ///     get as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri">The URI.</param>
        /// <param name="accessToken">The access token.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        public async Task<dynamic> GetAsync<T>(Uri uri, string accessToken) {
            string responseContent = null;

            if (CacheLevel == CacheLevel.Default || CacheLevel == CacheLevel.CacheOnly)
                responseContent = await Cache.LoadAsync(uri).ConfigureAwait(false);
            var cached = responseContent != null;
            dynamic result;
            if (cached) {
                result = Serializer.Deserialize<T>(responseContent);
                result.IsFromCache = true;
                return result;
            }
            if (CacheLevel == CacheLevel.CacheOnly) return default(T);

            // set up request
            var request = HttpRequestHelper.CreateRequest(HttpMethod.Get, uri);
            //request.Accept = ContentTypes.Get<T>(ThrowOnMissingContentType) + ";";
            _trace.TraceEvent(TraceEventType.Error, 0, "Initiating Request: " + uri);
            var response = await requestAsync(request, accessToken).ConfigureAwait(false);

            // handle response
            var header = response.Headers;
            responseContent = await HttpRequestHelper.GetResponseContentAsync(response).ConfigureAwait(false);
            if (CacheLevel == CacheLevel.Default || CacheLevel == CacheLevel.Refresh)
                await Cache.StoreAsync(uri, getCacheExpirationTime(header), responseContent).ConfigureAwait(false);
            result = Serializer.Deserialize<T>(responseContent);
            result.ResponseHeaders = header;
            result.Uri = uri;
            return result;
        }

        /// <summary>
        ///     request as an asynchronous operation.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="accessToken">The access token.</param>
        /// <returns>Task&lt;HttpWebResponse&gt;.</returns>
        /// <exception cref="DeprecatedResourceException">The CREST resource is deprecated.</exception>
        /// <exception cref="EveCrestException">
        ///     Undefined error
        ///     or
        ///     or
        /// </exception>
        private async Task<HttpResponseMessage> requestAsync(HttpRequestMessage request, string accessToken) {
            var mode = accessToken == null ? DynamicCrest.CrestMode.Public : DynamicCrest.CrestMode.Authenticated;
            HttpResponseMessage response = new HttpResponseMessage();
            if (!string.IsNullOrEmpty(XRequestedWith)) request.Headers.Add("X-Requested-With", XRequestedWith);
            if (!string.IsNullOrEmpty(UserAgent)) request.Headers.UserAgent.ParseAdd(UserAgent);
            try {
                if (mode == DynamicCrest.CrestMode.Authenticated) {
                    request.Headers.Add("Authorization", TokenType + " " + accessToken);
                    await _authedPool.WaitAsync().ConfigureAwait(false);
                }
                else {
                    await _publicPool.WaitAsync().ConfigureAwait(false);
                }
                response = await HttpRequestHelper.GetResponseAsync(request).ConfigureAwait(false);
                //if (response.StatusCode != HttpStatusCode.OK && response.StatusCode != HttpStatusCode.Created && response.StatusCode != HttpStatusCode.Accepted) {
                //    await throwCrestException(response);
                //}
                var deprecated = response.Headers.Contains("X-Deprecated");
                if (deprecated) {
                    _trace.TraceEvent(TraceEventType.Warning, 0,
                        "This CREST resource is deprecated. Please update to the newest EveLib version or notify the developers.");
                    if (ThrowOnDeprecated) {
                        throw new DeprecatedResourceException("The CREST resource is deprecated.", response);
                    }
                }
            }
            catch (Exception exception) {
                var e = exception as WebException;
                if (e == null) throw;
                _trace.TraceEvent(TraceEventType.Error, 0, "CREST Request Failed.");
                if (e.Response == null) {
                    throw new EveCrestException(e.Message, e);
                }
            }
            finally {
                // release semaphores
                if (mode == DynamicCrest.CrestMode.Authenticated) _authedPool.Release();
                else _publicPool.Release();
            }
            return response;
        }

/*
        /// <summary>
        ///     Throws the crest exception.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>Task.</returns>
        /// <exception cref="EveCrestException">null</exception>
        private async Task throwCrestException(HttpWebResponse response) {
            var responseContent = await HttpRequestHelper.GetResponseContentAsync(response);
            var error = Serializer.Deserialize<CrestError>(responseContent);
            _trace.TraceEvent(TraceEventType.Verbose, 0, "Message: {0}, Key: {1}",
                "Exception Type: {2}, Ref ID: {3}", error.Message, error.Key, error.ExceptionType,
                error.RefId);
            throw new EveCrestException(error.Message, null, error.Key, error.ExceptionType, error.RefId);
        }
*/

        /// <summary>
        ///     Gets the cache expiration time.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <returns>DateTime.</returns>
        private static DateTime getCacheExpirationTime(System.Net.Http.Headers.HttpResponseHeaders header) {
            var cache = header.CacheControl.ToString();
            if (cache == null) return DateTime.UtcNow;
            var sec = int.Parse(cache);
            return DateTime.UtcNow.AddSeconds(sec);
        }


        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///     Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="finalize">
        ///     <c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only
        ///     unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool finalize) {
            _authedPool.Dispose();
            _publicPool.Dispose();
        }
    }
}