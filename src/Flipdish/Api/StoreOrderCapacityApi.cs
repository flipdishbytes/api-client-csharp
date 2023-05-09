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
    public interface IStoreOrderCapacityApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <returns>RestApiResultStoreOrderCapacityConfig</returns>
        RestApiResultStoreOrderCapacityConfig GetStoreOrderCapacity (string appId, int? storeId, string deliveryType);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <returns>ApiResponse of RestApiResultStoreOrderCapacityConfig</returns>
        ApiResponse<RestApiResultStoreOrderCapacityConfig> GetStoreOrderCapacityWithHttpInfo (string appId, int? storeId, string deliveryType);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <param name="newOrderCapacityConfig"></param>
        /// <param name="appId"></param>
        /// <returns></returns>
        void UpdateStoreOrderCapacityConfig (int? storeId, string deliveryType, StoreOrderCapacityConfigEditModel newOrderCapacityConfig, string appId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <param name="newOrderCapacityConfig"></param>
        /// <param name="appId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateStoreOrderCapacityConfigWithHttpInfo (int? storeId, string deliveryType, StoreOrderCapacityConfigEditModel newOrderCapacityConfig, string appId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <returns>Task of RestApiResultStoreOrderCapacityConfig</returns>
        System.Threading.Tasks.Task<RestApiResultStoreOrderCapacityConfig> GetStoreOrderCapacityAsync (string appId, int? storeId, string deliveryType);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <returns>Task of ApiResponse (RestApiResultStoreOrderCapacityConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultStoreOrderCapacityConfig>> GetStoreOrderCapacityAsyncWithHttpInfo (string appId, int? storeId, string deliveryType);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <param name="newOrderCapacityConfig"></param>
        /// <param name="appId"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateStoreOrderCapacityConfigAsync (int? storeId, string deliveryType, StoreOrderCapacityConfigEditModel newOrderCapacityConfig, string appId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <param name="newOrderCapacityConfig"></param>
        /// <param name="appId"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateStoreOrderCapacityConfigAsyncWithHttpInfo (int? storeId, string deliveryType, StoreOrderCapacityConfigEditModel newOrderCapacityConfig, string appId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StoreOrderCapacityApi : IStoreOrderCapacityApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreOrderCapacityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoreOrderCapacityApi(String basePath)
        {
            this.Configuration = new Flipdish.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreOrderCapacityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StoreOrderCapacityApi(Flipdish.Client.Configuration configuration = null)
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
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <returns>RestApiResultStoreOrderCapacityConfig</returns>
        public RestApiResultStoreOrderCapacityConfig GetStoreOrderCapacity (string appId, int? storeId, string deliveryType)
        {
             ApiResponse<RestApiResultStoreOrderCapacityConfig> localVarResponse = GetStoreOrderCapacityWithHttpInfo(appId, storeId, deliveryType);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <returns>ApiResponse of RestApiResultStoreOrderCapacityConfig</returns>
        public ApiResponse< RestApiResultStoreOrderCapacityConfig > GetStoreOrderCapacityWithHttpInfo (string appId, int? storeId, string deliveryType)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling StoreOrderCapacityApi->GetStoreOrderCapacity");
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling StoreOrderCapacityApi->GetStoreOrderCapacity");
            // verify the required parameter 'deliveryType' is set
            if (deliveryType == null)
                throw new ApiException(400, "Missing required parameter 'deliveryType' when calling StoreOrderCapacityApi->GetStoreOrderCapacity");

            var localVarPath = "./api/v1.0/{appId}/storeordercapacity/{storeId}/{deliveryType}";
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
            if (storeId != null) localVarPathParams.Add("storeId", this.Configuration.ApiClient.ParameterToString(storeId)); // path parameter
            if (deliveryType != null) localVarPathParams.Add("deliveryType", this.Configuration.ApiClient.ParameterToString(deliveryType)); // path parameter

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
                Exception exception = ExceptionFactory("GetStoreOrderCapacity", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultStoreOrderCapacityConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultStoreOrderCapacityConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultStoreOrderCapacityConfig)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <returns>Task of RestApiResultStoreOrderCapacityConfig</returns>
        public async System.Threading.Tasks.Task<RestApiResultStoreOrderCapacityConfig> GetStoreOrderCapacityAsync (string appId, int? storeId, string deliveryType)
        {
             ApiResponse<RestApiResultStoreOrderCapacityConfig> localVarResponse = await GetStoreOrderCapacityAsyncWithHttpInfo(appId, storeId, deliveryType);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <returns>Task of ApiResponse (RestApiResultStoreOrderCapacityConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultStoreOrderCapacityConfig>> GetStoreOrderCapacityAsyncWithHttpInfo (string appId, int? storeId, string deliveryType)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling StoreOrderCapacityApi->GetStoreOrderCapacity");
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling StoreOrderCapacityApi->GetStoreOrderCapacity");
            // verify the required parameter 'deliveryType' is set
            if (deliveryType == null)
                throw new ApiException(400, "Missing required parameter 'deliveryType' when calling StoreOrderCapacityApi->GetStoreOrderCapacity");

            var localVarPath = "./api/v1.0/{appId}/storeordercapacity/{storeId}/{deliveryType}";
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
            if (storeId != null) localVarPathParams.Add("storeId", this.Configuration.ApiClient.ParameterToString(storeId)); // path parameter
            if (deliveryType != null) localVarPathParams.Add("deliveryType", this.Configuration.ApiClient.ParameterToString(deliveryType)); // path parameter

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
                Exception exception = ExceptionFactory("GetStoreOrderCapacity", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultStoreOrderCapacityConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultStoreOrderCapacityConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultStoreOrderCapacityConfig)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <param name="newOrderCapacityConfig"></param>
        /// <param name="appId"></param>
        /// <returns></returns>
        public void UpdateStoreOrderCapacityConfig (int? storeId, string deliveryType, StoreOrderCapacityConfigEditModel newOrderCapacityConfig, string appId)
        {
             UpdateStoreOrderCapacityConfigWithHttpInfo(storeId, deliveryType, newOrderCapacityConfig, appId);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <param name="newOrderCapacityConfig"></param>
        /// <param name="appId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateStoreOrderCapacityConfigWithHttpInfo (int? storeId, string deliveryType, StoreOrderCapacityConfigEditModel newOrderCapacityConfig, string appId)
        {
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling StoreOrderCapacityApi->UpdateStoreOrderCapacityConfig");
            // verify the required parameter 'deliveryType' is set
            if (deliveryType == null)
                throw new ApiException(400, "Missing required parameter 'deliveryType' when calling StoreOrderCapacityApi->UpdateStoreOrderCapacityConfig");
            // verify the required parameter 'newOrderCapacityConfig' is set
            if (newOrderCapacityConfig == null)
                throw new ApiException(400, "Missing required parameter 'newOrderCapacityConfig' when calling StoreOrderCapacityApi->UpdateStoreOrderCapacityConfig");
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling StoreOrderCapacityApi->UpdateStoreOrderCapacityConfig");

            var localVarPath = "./api/v1.0/{appId}/storeordercapacity/{storeId}";
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

            if (storeId != null) localVarPathParams.Add("storeId", this.Configuration.ApiClient.ParameterToString(storeId)); // path parameter
            if (appId != null) localVarPathParams.Add("appId", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (deliveryType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "deliveryType", deliveryType)); // query parameter
            if (newOrderCapacityConfig != null && newOrderCapacityConfig.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(newOrderCapacityConfig); // http body (model) parameter
            }
            else
            {
                localVarPostBody = newOrderCapacityConfig; // byte array
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
                Exception exception = ExceptionFactory("UpdateStoreOrderCapacityConfig", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <param name="newOrderCapacityConfig"></param>
        /// <param name="appId"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateStoreOrderCapacityConfigAsync (int? storeId, string deliveryType, StoreOrderCapacityConfigEditModel newOrderCapacityConfig, string appId)
        {
             await UpdateStoreOrderCapacityConfigAsyncWithHttpInfo(storeId, deliveryType, newOrderCapacityConfig, appId);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId"></param>
        /// <param name="deliveryType"></param>
        /// <param name="newOrderCapacityConfig"></param>
        /// <param name="appId"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateStoreOrderCapacityConfigAsyncWithHttpInfo (int? storeId, string deliveryType, StoreOrderCapacityConfigEditModel newOrderCapacityConfig, string appId)
        {
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling StoreOrderCapacityApi->UpdateStoreOrderCapacityConfig");
            // verify the required parameter 'deliveryType' is set
            if (deliveryType == null)
                throw new ApiException(400, "Missing required parameter 'deliveryType' when calling StoreOrderCapacityApi->UpdateStoreOrderCapacityConfig");
            // verify the required parameter 'newOrderCapacityConfig' is set
            if (newOrderCapacityConfig == null)
                throw new ApiException(400, "Missing required parameter 'newOrderCapacityConfig' when calling StoreOrderCapacityApi->UpdateStoreOrderCapacityConfig");
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling StoreOrderCapacityApi->UpdateStoreOrderCapacityConfig");

            var localVarPath = "./api/v1.0/{appId}/storeordercapacity/{storeId}";
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

            if (storeId != null) localVarPathParams.Add("storeId", this.Configuration.ApiClient.ParameterToString(storeId)); // path parameter
            if (appId != null) localVarPathParams.Add("appId", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (deliveryType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "deliveryType", deliveryType)); // query parameter
            if (newOrderCapacityConfig != null && newOrderCapacityConfig.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(newOrderCapacityConfig); // http body (model) parameter
            }
            else
            {
                localVarPostBody = newOrderCapacityConfig; // byte array
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
                Exception exception = ExceptionFactory("UpdateStoreOrderCapacityConfig", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

    }
}
