/* 
 * Flipdish Open API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Flipdish.Client;
using Flipdish.Model;

namespace Flipdish.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChannelsStoreMappingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets the relationship between Flipdish Store and Channel Store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <returns>RestApiArrayResultStoreChannelStoreMapping</returns>
        RestApiArrayResultStoreChannelStoreMapping ChannelsGetStoreChannelStoreMapping (string appId, int? channelId);

        /// <summary>
        /// Gets the relationship between Flipdish Store and Channel Store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <returns>ApiResponse of RestApiArrayResultStoreChannelStoreMapping</returns>
        ApiResponse<RestApiArrayResultStoreChannelStoreMapping> ChannelsGetStoreChannelStoreMappingWithHttpInfo (string appId, int? channelId);
        /// <summary>
        /// Sets the relationship between Flipdish Store and Channel Store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <param name="stores">Flipdish and Channel Store configuration</param>
        /// <returns>RestApiArrayResultStoreChannelStoreMapping</returns>
        RestApiArrayResultStoreChannelStoreMapping ChannelsSetStoreChannelStoreMapping (string appId, int? channelId, List<ChannelStoreMapping> stores);

        /// <summary>
        /// Sets the relationship between Flipdish Store and Channel Store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <param name="stores">Flipdish and Channel Store configuration</param>
        /// <returns>ApiResponse of RestApiArrayResultStoreChannelStoreMapping</returns>
        ApiResponse<RestApiArrayResultStoreChannelStoreMapping> ChannelsSetStoreChannelStoreMappingWithHttpInfo (string appId, int? channelId, List<ChannelStoreMapping> stores);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets the relationship between Flipdish Store and Channel Store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <returns>Task of RestApiArrayResultStoreChannelStoreMapping</returns>
        System.Threading.Tasks.Task<RestApiArrayResultStoreChannelStoreMapping> ChannelsGetStoreChannelStoreMappingAsync (string appId, int? channelId);

        /// <summary>
        /// Gets the relationship between Flipdish Store and Channel Store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <returns>Task of ApiResponse (RestApiArrayResultStoreChannelStoreMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiArrayResultStoreChannelStoreMapping>> ChannelsGetStoreChannelStoreMappingAsyncWithHttpInfo (string appId, int? channelId);
        /// <summary>
        /// Sets the relationship between Flipdish Store and Channel Store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <param name="stores">Flipdish and Channel Store configuration</param>
        /// <returns>Task of RestApiArrayResultStoreChannelStoreMapping</returns>
        System.Threading.Tasks.Task<RestApiArrayResultStoreChannelStoreMapping> ChannelsSetStoreChannelStoreMappingAsync (string appId, int? channelId, List<ChannelStoreMapping> stores);

        /// <summary>
        /// Sets the relationship between Flipdish Store and Channel Store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <param name="stores">Flipdish and Channel Store configuration</param>
        /// <returns>Task of ApiResponse (RestApiArrayResultStoreChannelStoreMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiArrayResultStoreChannelStoreMapping>> ChannelsSetStoreChannelStoreMappingAsyncWithHttpInfo (string appId, int? channelId, List<ChannelStoreMapping> stores);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ChannelsStoreMappingApi : IChannelsStoreMappingApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsStoreMappingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChannelsStoreMappingApi(String basePath)
        {
            this.Configuration = new Flipdish.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsStoreMappingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ChannelsStoreMappingApi(Flipdish.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Flipdish.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
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
        public Flipdish.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Flipdish.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Gets the relationship between Flipdish Store and Channel Store 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <returns>RestApiArrayResultStoreChannelStoreMapping</returns>
        public RestApiArrayResultStoreChannelStoreMapping ChannelsGetStoreChannelStoreMapping (string appId, int? channelId)
        {
             ApiResponse<RestApiArrayResultStoreChannelStoreMapping> localVarResponse = ChannelsGetStoreChannelStoreMappingWithHttpInfo(appId, channelId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the relationship between Flipdish Store and Channel Store 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <returns>ApiResponse of RestApiArrayResultStoreChannelStoreMapping</returns>
        public ApiResponse< RestApiArrayResultStoreChannelStoreMapping > ChannelsGetStoreChannelStoreMappingWithHttpInfo (string appId, int? channelId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling ChannelsStoreMappingApi->ChannelsGetStoreChannelStoreMapping");
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling ChannelsStoreMappingApi->ChannelsGetStoreChannelStoreMapping");

            var localVarPath = "./api/v1.0/{appId}/channels/storemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (appId != null) localVarPathParams.Add("appId", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (channelId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "channelId", channelId)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChannelsGetStoreChannelStoreMapping", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiArrayResultStoreChannelStoreMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiArrayResultStoreChannelStoreMapping) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiArrayResultStoreChannelStoreMapping)));
        }

        /// <summary>
        /// Gets the relationship between Flipdish Store and Channel Store 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <returns>Task of RestApiArrayResultStoreChannelStoreMapping</returns>
        public async System.Threading.Tasks.Task<RestApiArrayResultStoreChannelStoreMapping> ChannelsGetStoreChannelStoreMappingAsync (string appId, int? channelId)
        {
             ApiResponse<RestApiArrayResultStoreChannelStoreMapping> localVarResponse = await ChannelsGetStoreChannelStoreMappingAsyncWithHttpInfo(appId, channelId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the relationship between Flipdish Store and Channel Store 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <returns>Task of ApiResponse (RestApiArrayResultStoreChannelStoreMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiArrayResultStoreChannelStoreMapping>> ChannelsGetStoreChannelStoreMappingAsyncWithHttpInfo (string appId, int? channelId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling ChannelsStoreMappingApi->ChannelsGetStoreChannelStoreMapping");
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling ChannelsStoreMappingApi->ChannelsGetStoreChannelStoreMapping");

            var localVarPath = "./api/v1.0/{appId}/channels/storemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (appId != null) localVarPathParams.Add("appId", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (channelId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "channelId", channelId)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChannelsGetStoreChannelStoreMapping", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiArrayResultStoreChannelStoreMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiArrayResultStoreChannelStoreMapping) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiArrayResultStoreChannelStoreMapping)));
        }

        /// <summary>
        /// Sets the relationship between Flipdish Store and Channel Store 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <param name="stores">Flipdish and Channel Store configuration</param>
        /// <returns>RestApiArrayResultStoreChannelStoreMapping</returns>
        public RestApiArrayResultStoreChannelStoreMapping ChannelsSetStoreChannelStoreMapping (string appId, int? channelId, List<ChannelStoreMapping> stores)
        {
             ApiResponse<RestApiArrayResultStoreChannelStoreMapping> localVarResponse = ChannelsSetStoreChannelStoreMappingWithHttpInfo(appId, channelId, stores);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sets the relationship between Flipdish Store and Channel Store 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <param name="stores">Flipdish and Channel Store configuration</param>
        /// <returns>ApiResponse of RestApiArrayResultStoreChannelStoreMapping</returns>
        public ApiResponse< RestApiArrayResultStoreChannelStoreMapping > ChannelsSetStoreChannelStoreMappingWithHttpInfo (string appId, int? channelId, List<ChannelStoreMapping> stores)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling ChannelsStoreMappingApi->ChannelsSetStoreChannelStoreMapping");
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling ChannelsStoreMappingApi->ChannelsSetStoreChannelStoreMapping");
            // verify the required parameter 'stores' is set
            if (stores == null)
                throw new ApiException(400, "Missing required parameter 'stores' when calling ChannelsStoreMappingApi->ChannelsSetStoreChannelStoreMapping");

            var localVarPath = "./api/v1.0/{appId}/channels/storemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (appId != null) localVarPathParams.Add("appId", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (channelId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "channelId", channelId)); // query parameter
            if (stores != null && stores.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(stores); // http body (model) parameter
            }
            else
            {
                localVarPostBody = stores; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChannelsSetStoreChannelStoreMapping", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiArrayResultStoreChannelStoreMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiArrayResultStoreChannelStoreMapping) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiArrayResultStoreChannelStoreMapping)));
        }

        /// <summary>
        /// Sets the relationship between Flipdish Store and Channel Store 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <param name="stores">Flipdish and Channel Store configuration</param>
        /// <returns>Task of RestApiArrayResultStoreChannelStoreMapping</returns>
        public async System.Threading.Tasks.Task<RestApiArrayResultStoreChannelStoreMapping> ChannelsSetStoreChannelStoreMappingAsync (string appId, int? channelId, List<ChannelStoreMapping> stores)
        {
             ApiResponse<RestApiArrayResultStoreChannelStoreMapping> localVarResponse = await ChannelsSetStoreChannelStoreMappingAsyncWithHttpInfo(appId, channelId, stores);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sets the relationship between Flipdish Store and Channel Store 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">Flipdish App Name Id</param>
        /// <param name="channelId">Flipdish Channel ID</param>
        /// <param name="stores">Flipdish and Channel Store configuration</param>
        /// <returns>Task of ApiResponse (RestApiArrayResultStoreChannelStoreMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiArrayResultStoreChannelStoreMapping>> ChannelsSetStoreChannelStoreMappingAsyncWithHttpInfo (string appId, int? channelId, List<ChannelStoreMapping> stores)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling ChannelsStoreMappingApi->ChannelsSetStoreChannelStoreMapping");
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling ChannelsStoreMappingApi->ChannelsSetStoreChannelStoreMapping");
            // verify the required parameter 'stores' is set
            if (stores == null)
                throw new ApiException(400, "Missing required parameter 'stores' when calling ChannelsStoreMappingApi->ChannelsSetStoreChannelStoreMapping");

            var localVarPath = "./api/v1.0/{appId}/channels/storemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (appId != null) localVarPathParams.Add("appId", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (channelId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "channelId", channelId)); // query parameter
            if (stores != null && stores.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(stores); // http body (model) parameter
            }
            else
            {
                localVarPostBody = stores; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChannelsSetStoreChannelStoreMapping", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiArrayResultStoreChannelStoreMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiArrayResultStoreChannelStoreMapping) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiArrayResultStoreChannelStoreMapping)));
        }

    }
}
