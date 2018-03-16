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
using Flipdish.Client;
using Flipdish.Model;

namespace Flipdish.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStoresApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get store by identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <returns>RestApiResultStore</returns>
        RestApiResultStore GetStoreById (int? storeId);

        /// <summary>
        /// Get store by identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <returns>ApiResponse of RestApiResultStore</returns>
        ApiResponse<RestApiResultStore> GetStoreByIdWithHttpInfo (int? storeId);
        /// <summary>
        /// Get all stores
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchQuery">Search query (optional)</param>
        /// <param name="page">Requested page index (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>RestApiPaginationResultStore</returns>
        RestApiPaginationResultStore GetStores (string searchQuery = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get all stores
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchQuery">Search query (optional)</param>
        /// <param name="page">Requested page index (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>ApiResponse of RestApiPaginationResultStore</returns>
        ApiResponse<RestApiPaginationResultStore> GetStoresWithHttpInfo (string searchQuery = null, int? page = null, int? limit = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get store by identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <returns>Task of RestApiResultStore</returns>
        System.Threading.Tasks.Task<RestApiResultStore> GetStoreByIdAsync (int? storeId);

        /// <summary>
        /// Get store by identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <returns>Task of ApiResponse (RestApiResultStore)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultStore>> GetStoreByIdAsyncWithHttpInfo (int? storeId);
        /// <summary>
        /// Get all stores
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchQuery">Search query (optional)</param>
        /// <param name="page">Requested page index (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>Task of RestApiPaginationResultStore</returns>
        System.Threading.Tasks.Task<RestApiPaginationResultStore> GetStoresAsync (string searchQuery = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get all stores
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchQuery">Search query (optional)</param>
        /// <param name="page">Requested page index (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>Task of ApiResponse (RestApiPaginationResultStore)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiPaginationResultStore>> GetStoresAsyncWithHttpInfo (string searchQuery = null, int? page = null, int? limit = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StoresApi : IStoresApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StoresApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoresApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoresApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StoresApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
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
        public Configuration Configuration {get; set;}

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
        /// Get store by identifier 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <returns>RestApiResultStore</returns>
        public RestApiResultStore GetStoreById (int? storeId)
        {
             ApiResponse<RestApiResultStore> localVarResponse = GetStoreByIdWithHttpInfo(storeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get store by identifier 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <returns>ApiResponse of RestApiResultStore</returns>
        public ApiResponse< RestApiResultStore > GetStoreByIdWithHttpInfo (int? storeId)
        {
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling StoresApi->GetStoreById");

            var localVarPath = "/api/v1.0/stores/{storeId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storeId != null) localVarPathParams.Add("storeId", Configuration.ApiClient.ParameterToString(storeId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStoreById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultStore>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultStore) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultStore)));
        }

        /// <summary>
        /// Get store by identifier 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <returns>Task of RestApiResultStore</returns>
        public async System.Threading.Tasks.Task<RestApiResultStore> GetStoreByIdAsync (int? storeId)
        {
             ApiResponse<RestApiResultStore> localVarResponse = await GetStoreByIdAsyncWithHttpInfo(storeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get store by identifier 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <returns>Task of ApiResponse (RestApiResultStore)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultStore>> GetStoreByIdAsyncWithHttpInfo (int? storeId)
        {
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling StoresApi->GetStoreById");

            var localVarPath = "/api/v1.0/stores/{storeId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storeId != null) localVarPathParams.Add("storeId", Configuration.ApiClient.ParameterToString(storeId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStoreById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultStore>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultStore) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultStore)));
        }

        /// <summary>
        /// Get all stores 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchQuery">Search query (optional)</param>
        /// <param name="page">Requested page index (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>RestApiPaginationResultStore</returns>
        public RestApiPaginationResultStore GetStores (string searchQuery = null, int? page = null, int? limit = null)
        {
             ApiResponse<RestApiPaginationResultStore> localVarResponse = GetStoresWithHttpInfo(searchQuery, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all stores 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchQuery">Search query (optional)</param>
        /// <param name="page">Requested page index (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>ApiResponse of RestApiPaginationResultStore</returns>
        public ApiResponse< RestApiPaginationResultStore > GetStoresWithHttpInfo (string searchQuery = null, int? page = null, int? limit = null)
        {

            var localVarPath = "/api/v1.0/stores";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchQuery != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchQuery", searchQuery)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStores", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiPaginationResultStore>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiPaginationResultStore) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiPaginationResultStore)));
        }

        /// <summary>
        /// Get all stores 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchQuery">Search query (optional)</param>
        /// <param name="page">Requested page index (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>Task of RestApiPaginationResultStore</returns>
        public async System.Threading.Tasks.Task<RestApiPaginationResultStore> GetStoresAsync (string searchQuery = null, int? page = null, int? limit = null)
        {
             ApiResponse<RestApiPaginationResultStore> localVarResponse = await GetStoresAsyncWithHttpInfo(searchQuery, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all stores 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchQuery">Search query (optional)</param>
        /// <param name="page">Requested page index (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>Task of ApiResponse (RestApiPaginationResultStore)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiPaginationResultStore>> GetStoresAsyncWithHttpInfo (string searchQuery = null, int? page = null, int? limit = null)
        {

            var localVarPath = "/api/v1.0/stores";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchQuery != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchQuery", searchQuery)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStores", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiPaginationResultStore>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiPaginationResultStore) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiPaginationResultStore)));
        }

    }
}
