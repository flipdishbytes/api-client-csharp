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
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITipsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns current tip configuration for a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <returns>RestApiResultTipConfiguration</returns>
        RestApiResultTipConfiguration TipConfigGet (int? storeId);

        /// <summary>
        /// Returns current tip configuration for a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <returns>ApiResponse of RestApiResultTipConfiguration</returns>
        ApiResponse<RestApiResultTipConfiguration> TipConfigGetWithHttpInfo (int? storeId);
        /// <summary>
        /// Update or insert current tip configuration for a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <param name="updateConfig">Update Configuration</param>
        /// <returns>RestApiResultTipConfiguration</returns>
        RestApiResultTipConfiguration TipConfigUpsert (int? storeId, UpdateTipConfiguration updateConfig);

        /// <summary>
        /// Update or insert current tip configuration for a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <param name="updateConfig">Update Configuration</param>
        /// <returns>ApiResponse of RestApiResultTipConfiguration</returns>
        ApiResponse<RestApiResultTipConfiguration> TipConfigUpsertWithHttpInfo (int? storeId, UpdateTipConfiguration updateConfig);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns current tip configuration for a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <returns>Task of RestApiResultTipConfiguration</returns>
        System.Threading.Tasks.Task<RestApiResultTipConfiguration> TipConfigGetAsync (int? storeId);

        /// <summary>
        /// Returns current tip configuration for a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <returns>Task of ApiResponse (RestApiResultTipConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultTipConfiguration>> TipConfigGetAsyncWithHttpInfo (int? storeId);
        /// <summary>
        /// Update or insert current tip configuration for a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <param name="updateConfig">Update Configuration</param>
        /// <returns>Task of RestApiResultTipConfiguration</returns>
        System.Threading.Tasks.Task<RestApiResultTipConfiguration> TipConfigUpsertAsync (int? storeId, UpdateTipConfiguration updateConfig);

        /// <summary>
        /// Update or insert current tip configuration for a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <param name="updateConfig">Update Configuration</param>
        /// <returns>Task of ApiResponse (RestApiResultTipConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultTipConfiguration>> TipConfigUpsertAsyncWithHttpInfo (int? storeId, UpdateTipConfiguration updateConfig);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TipsApi : ITipsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TipsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TipsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TipsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TipsApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Returns current tip configuration for a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <returns>RestApiResultTipConfiguration</returns>
        public RestApiResultTipConfiguration TipConfigGet (int? storeId)
        {
             ApiResponse<RestApiResultTipConfiguration> localVarResponse = TipConfigGetWithHttpInfo(storeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns current tip configuration for a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <returns>ApiResponse of RestApiResultTipConfiguration</returns>
        public ApiResponse< RestApiResultTipConfiguration > TipConfigGetWithHttpInfo (int? storeId)
        {
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling TipsApi->TipConfigGet");

            var localVarPath = "/api/v1.0/stores/{storeId}/tipconfig";
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

            if (storeId != null) localVarPathParams.Add("storeId", this.Configuration.ApiClient.ParameterToString(storeId)); // path parameter

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
                Exception exception = ExceptionFactory("TipConfigGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultTipConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultTipConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultTipConfiguration)));
        }

        /// <summary>
        /// Returns current tip configuration for a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <returns>Task of RestApiResultTipConfiguration</returns>
        public async System.Threading.Tasks.Task<RestApiResultTipConfiguration> TipConfigGetAsync (int? storeId)
        {
             ApiResponse<RestApiResultTipConfiguration> localVarResponse = await TipConfigGetAsyncWithHttpInfo(storeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns current tip configuration for a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <returns>Task of ApiResponse (RestApiResultTipConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultTipConfiguration>> TipConfigGetAsyncWithHttpInfo (int? storeId)
        {
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling TipsApi->TipConfigGet");

            var localVarPath = "/api/v1.0/stores/{storeId}/tipconfig";
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

            if (storeId != null) localVarPathParams.Add("storeId", this.Configuration.ApiClient.ParameterToString(storeId)); // path parameter

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
                Exception exception = ExceptionFactory("TipConfigGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultTipConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultTipConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultTipConfiguration)));
        }

        /// <summary>
        /// Update or insert current tip configuration for a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <param name="updateConfig">Update Configuration</param>
        /// <returns>RestApiResultTipConfiguration</returns>
        public RestApiResultTipConfiguration TipConfigUpsert (int? storeId, UpdateTipConfiguration updateConfig)
        {
             ApiResponse<RestApiResultTipConfiguration> localVarResponse = TipConfigUpsertWithHttpInfo(storeId, updateConfig);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update or insert current tip configuration for a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <param name="updateConfig">Update Configuration</param>
        /// <returns>ApiResponse of RestApiResultTipConfiguration</returns>
        public ApiResponse< RestApiResultTipConfiguration > TipConfigUpsertWithHttpInfo (int? storeId, UpdateTipConfiguration updateConfig)
        {
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling TipsApi->TipConfigUpsert");
            // verify the required parameter 'updateConfig' is set
            if (updateConfig == null)
                throw new ApiException(400, "Missing required parameter 'updateConfig' when calling TipsApi->TipConfigUpsert");

            var localVarPath = "/api/v1.0/stores/{storeId}/tipconfig";
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
            if (updateConfig != null && updateConfig.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(updateConfig); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateConfig; // byte array
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
                Exception exception = ExceptionFactory("TipConfigUpsert", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultTipConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultTipConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultTipConfiguration)));
        }

        /// <summary>
        /// Update or insert current tip configuration for a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <param name="updateConfig">Update Configuration</param>
        /// <returns>Task of RestApiResultTipConfiguration</returns>
        public async System.Threading.Tasks.Task<RestApiResultTipConfiguration> TipConfigUpsertAsync (int? storeId, UpdateTipConfiguration updateConfig)
        {
             ApiResponse<RestApiResultTipConfiguration> localVarResponse = await TipConfigUpsertAsyncWithHttpInfo(storeId, updateConfig);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update or insert current tip configuration for a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store Id</param>
        /// <param name="updateConfig">Update Configuration</param>
        /// <returns>Task of ApiResponse (RestApiResultTipConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultTipConfiguration>> TipConfigUpsertAsyncWithHttpInfo (int? storeId, UpdateTipConfiguration updateConfig)
        {
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling TipsApi->TipConfigUpsert");
            // verify the required parameter 'updateConfig' is set
            if (updateConfig == null)
                throw new ApiException(400, "Missing required parameter 'updateConfig' when calling TipsApi->TipConfigUpsert");

            var localVarPath = "/api/v1.0/stores/{storeId}/tipconfig";
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
            if (updateConfig != null && updateConfig.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(updateConfig); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateConfig; // byte array
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
                Exception exception = ExceptionFactory("TipConfigUpsert", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultTipConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultTipConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultTipConfiguration)));
        }

    }
}
