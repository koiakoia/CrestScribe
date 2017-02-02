/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.3.9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ESI.Client;
using ESI.Model;

namespace ESI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISovereigntyApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List sovereignty campaigns
        /// </summary>
        /// <remarks>
        /// Shows sovereignty data for campaigns.  - --  Alternate route: &#x60;/v1/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/legacy/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/latest/sovereignty/campaigns/&#x60;   - --  This route is cached for up to 5 seconds
        /// </remarks>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>List&lt;GetSovereigntyCampaigns200Ok&gt;</returns>
        List<GetSovereigntyCampaigns200Ok> GetSovereigntyCampaigns (string datasource = null);

        /// <summary>
        /// List sovereignty campaigns
        /// </summary>
        /// <remarks>
        /// Shows sovereignty data for campaigns.  - --  Alternate route: &#x60;/v1/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/legacy/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/latest/sovereignty/campaigns/&#x60;   - --  This route is cached for up to 5 seconds
        /// </remarks>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>ApiResponse of List&lt;GetSovereigntyCampaigns200Ok&gt;</returns>
        ApiResponse<List<GetSovereigntyCampaigns200Ok>> GetSovereigntyCampaignsWithHttpInfo (string datasource = null);
        /// <summary>
        /// List sovereignty structures
        /// </summary>
        /// <remarks>
        /// Shows sovereignty data for structures.  - --  Alternate route: &#x60;/v1/sovereignty/structures/&#x60;  Alternate route: &#x60;/legacy/sovereignty/structures/&#x60;  Alternate route: &#x60;/latest/sovereignty/structures/&#x60;   - --  This route is cached for up to 120 seconds
        /// </remarks>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>List&lt;GetSovereigntyStructures200Ok&gt;</returns>
        List<GetSovereigntyStructures200Ok> GetSovereigntyStructures (string datasource = null);

        /// <summary>
        /// List sovereignty structures
        /// </summary>
        /// <remarks>
        /// Shows sovereignty data for structures.  - --  Alternate route: &#x60;/v1/sovereignty/structures/&#x60;  Alternate route: &#x60;/legacy/sovereignty/structures/&#x60;  Alternate route: &#x60;/latest/sovereignty/structures/&#x60;   - --  This route is cached for up to 120 seconds
        /// </remarks>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>ApiResponse of List&lt;GetSovereigntyStructures200Ok&gt;</returns>
        ApiResponse<List<GetSovereigntyStructures200Ok>> GetSovereigntyStructuresWithHttpInfo (string datasource = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List sovereignty campaigns
        /// </summary>
        /// <remarks>
        /// Shows sovereignty data for campaigns.  - --  Alternate route: &#x60;/v1/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/legacy/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/latest/sovereignty/campaigns/&#x60;   - --  This route is cached for up to 5 seconds
        /// </remarks>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>Task of List&lt;GetSovereigntyCampaigns200Ok&gt;</returns>
        System.Threading.Tasks.Task<List<GetSovereigntyCampaigns200Ok>> GetSovereigntyCampaignsAsync (string datasource = null);

        /// <summary>
        /// List sovereignty campaigns
        /// </summary>
        /// <remarks>
        /// Shows sovereignty data for campaigns.  - --  Alternate route: &#x60;/v1/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/legacy/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/latest/sovereignty/campaigns/&#x60;   - --  This route is cached for up to 5 seconds
        /// </remarks>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>Task of ApiResponse (List&lt;GetSovereigntyCampaigns200Ok&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<GetSovereigntyCampaigns200Ok>>> GetSovereigntyCampaignsAsyncWithHttpInfo (string datasource = null);
        /// <summary>
        /// List sovereignty structures
        /// </summary>
        /// <remarks>
        /// Shows sovereignty data for structures.  - --  Alternate route: &#x60;/v1/sovereignty/structures/&#x60;  Alternate route: &#x60;/legacy/sovereignty/structures/&#x60;  Alternate route: &#x60;/latest/sovereignty/structures/&#x60;   - --  This route is cached for up to 120 seconds
        /// </remarks>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>Task of List&lt;GetSovereigntyStructures200Ok&gt;</returns>
        System.Threading.Tasks.Task<List<GetSovereigntyStructures200Ok>> GetSovereigntyStructuresAsync (string datasource = null);

        /// <summary>
        /// List sovereignty structures
        /// </summary>
        /// <remarks>
        /// Shows sovereignty data for structures.  - --  Alternate route: &#x60;/v1/sovereignty/structures/&#x60;  Alternate route: &#x60;/legacy/sovereignty/structures/&#x60;  Alternate route: &#x60;/latest/sovereignty/structures/&#x60;   - --  This route is cached for up to 120 seconds
        /// </remarks>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>Task of ApiResponse (List&lt;GetSovereigntyStructures200Ok&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<GetSovereigntyStructures200Ok>>> GetSovereigntyStructuresAsyncWithHttpInfo (string datasource = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SovereigntyApi : ISovereigntyApi
    {
        private ESI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SovereigntyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SovereigntyApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = ESI.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SovereigntyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SovereigntyApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ESI.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ESI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// List sovereignty campaigns Shows sovereignty data for campaigns.  - --  Alternate route: &#x60;/v1/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/legacy/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/latest/sovereignty/campaigns/&#x60;   - --  This route is cached for up to 5 seconds
        /// </summary>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>List&lt;GetSovereigntyCampaigns200Ok&gt;</returns>
        public List<GetSovereigntyCampaigns200Ok> GetSovereigntyCampaigns (string datasource = null)
        {
             ApiResponse<List<GetSovereigntyCampaigns200Ok>> localVarResponse = GetSovereigntyCampaignsWithHttpInfo(datasource);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List sovereignty campaigns Shows sovereignty data for campaigns.  - --  Alternate route: &#x60;/v1/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/legacy/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/latest/sovereignty/campaigns/&#x60;   - --  This route is cached for up to 5 seconds
        /// </summary>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>ApiResponse of List&lt;GetSovereigntyCampaigns200Ok&gt;</returns>
        public ApiResponse< List<GetSovereigntyCampaigns200Ok> > GetSovereigntyCampaignsWithHttpInfo (string datasource = null)
        {

            var localVarPath = "/sovereignty/campaigns/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (datasource != null) localVarQueryParams.Add("datasource", Configuration.ApiClient.ParameterToString(datasource)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSovereigntyCampaigns", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<GetSovereigntyCampaigns200Ok>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<GetSovereigntyCampaigns200Ok>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<GetSovereigntyCampaigns200Ok>)));
            
        }

        /// <summary>
        /// List sovereignty campaigns Shows sovereignty data for campaigns.  - --  Alternate route: &#x60;/v1/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/legacy/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/latest/sovereignty/campaigns/&#x60;   - --  This route is cached for up to 5 seconds
        /// </summary>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>Task of List&lt;GetSovereigntyCampaigns200Ok&gt;</returns>
        public async System.Threading.Tasks.Task<List<GetSovereigntyCampaigns200Ok>> GetSovereigntyCampaignsAsync (string datasource = null)
        {
             ApiResponse<List<GetSovereigntyCampaigns200Ok>> localVarResponse = await GetSovereigntyCampaignsAsyncWithHttpInfo(datasource);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List sovereignty campaigns Shows sovereignty data for campaigns.  - --  Alternate route: &#x60;/v1/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/legacy/sovereignty/campaigns/&#x60;  Alternate route: &#x60;/latest/sovereignty/campaigns/&#x60;   - --  This route is cached for up to 5 seconds
        /// </summary>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>Task of ApiResponse (List&lt;GetSovereigntyCampaigns200Ok&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<GetSovereigntyCampaigns200Ok>>> GetSovereigntyCampaignsAsyncWithHttpInfo (string datasource = null)
        {

            var localVarPath = "/sovereignty/campaigns/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (datasource != null) localVarQueryParams.Add("datasource", Configuration.ApiClient.ParameterToString(datasource)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSovereigntyCampaigns", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<GetSovereigntyCampaigns200Ok>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<GetSovereigntyCampaigns200Ok>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<GetSovereigntyCampaigns200Ok>)));
            
        }

        /// <summary>
        /// List sovereignty structures Shows sovereignty data for structures.  - --  Alternate route: &#x60;/v1/sovereignty/structures/&#x60;  Alternate route: &#x60;/legacy/sovereignty/structures/&#x60;  Alternate route: &#x60;/latest/sovereignty/structures/&#x60;   - --  This route is cached for up to 120 seconds
        /// </summary>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>List&lt;GetSovereigntyStructures200Ok&gt;</returns>
        public List<GetSovereigntyStructures200Ok> GetSovereigntyStructures (string datasource = null)
        {
             ApiResponse<List<GetSovereigntyStructures200Ok>> localVarResponse = GetSovereigntyStructuresWithHttpInfo(datasource);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List sovereignty structures Shows sovereignty data for structures.  - --  Alternate route: &#x60;/v1/sovereignty/structures/&#x60;  Alternate route: &#x60;/legacy/sovereignty/structures/&#x60;  Alternate route: &#x60;/latest/sovereignty/structures/&#x60;   - --  This route is cached for up to 120 seconds
        /// </summary>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>ApiResponse of List&lt;GetSovereigntyStructures200Ok&gt;</returns>
        public ApiResponse< List<GetSovereigntyStructures200Ok> > GetSovereigntyStructuresWithHttpInfo (string datasource = null)
        {

            var localVarPath = "/sovereignty/structures/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (datasource != null) localVarQueryParams.Add("datasource", Configuration.ApiClient.ParameterToString(datasource)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSovereigntyStructures", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<GetSovereigntyStructures200Ok>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<GetSovereigntyStructures200Ok>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<GetSovereigntyStructures200Ok>)));
            
        }

        /// <summary>
        /// List sovereignty structures Shows sovereignty data for structures.  - --  Alternate route: &#x60;/v1/sovereignty/structures/&#x60;  Alternate route: &#x60;/legacy/sovereignty/structures/&#x60;  Alternate route: &#x60;/latest/sovereignty/structures/&#x60;   - --  This route is cached for up to 120 seconds
        /// </summary>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>Task of List&lt;GetSovereigntyStructures200Ok&gt;</returns>
        public async System.Threading.Tasks.Task<List<GetSovereigntyStructures200Ok>> GetSovereigntyStructuresAsync (string datasource = null)
        {
             ApiResponse<List<GetSovereigntyStructures200Ok>> localVarResponse = await GetSovereigntyStructuresAsyncWithHttpInfo(datasource);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List sovereignty structures Shows sovereignty data for structures.  - --  Alternate route: &#x60;/v1/sovereignty/structures/&#x60;  Alternate route: &#x60;/legacy/sovereignty/structures/&#x60;  Alternate route: &#x60;/latest/sovereignty/structures/&#x60;   - --  This route is cached for up to 120 seconds
        /// </summary>
        /// <exception cref="ESI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <returns>Task of ApiResponse (List&lt;GetSovereigntyStructures200Ok&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<GetSovereigntyStructures200Ok>>> GetSovereigntyStructuresAsyncWithHttpInfo (string datasource = null)
        {

            var localVarPath = "/sovereignty/structures/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (datasource != null) localVarQueryParams.Add("datasource", Configuration.ApiClient.ParameterToString(datasource)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSovereigntyStructures", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<GetSovereigntyStructures200Ok>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<GetSovereigntyStructures200Ok>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<GetSovereigntyStructures200Ok>)));
            
        }

    }
}
