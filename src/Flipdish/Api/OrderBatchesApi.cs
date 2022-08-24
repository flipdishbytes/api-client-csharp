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
    public interface IOrderBatchesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns order batches
        /// </summary>
        /// <remarks>
        /// Entries are sorted by date, from the most recent. At most 100 entries are returned.
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="createdFrom">Start date for retrieving the entries (optional)</param>
        /// <param name="createdTo">End date for retrieving the entries (optional)</param>
        /// <returns>RestApiArrayResultOrderBatchItem</returns>
        RestApiArrayResultOrderBatchItem GetAllOrderBatches (string appId, int? storeId, DateTime? createdFrom = null, DateTime? createdTo = null);

        /// <summary>
        /// Returns order batches
        /// </summary>
        /// <remarks>
        /// Entries are sorted by date, from the most recent. At most 100 entries are returned.
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="createdFrom">Start date for retrieving the entries (optional)</param>
        /// <param name="createdTo">End date for retrieving the entries (optional)</param>
        /// <returns>ApiResponse of RestApiArrayResultOrderBatchItem</returns>
        ApiResponse<RestApiArrayResultOrderBatchItem> GetAllOrderBatchesWithHttpInfo (string appId, int? storeId, DateTime? createdFrom = null, DateTime? createdTo = null);
        /// <summary>
        /// Returns the order batch details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="batchId">Order Batch Id</param>
        /// <returns>RestApiResultOrderBatch</returns>
        RestApiResultOrderBatch GetOrderBatch (string appId, int? storeId, int? batchId);

        /// <summary>
        /// Returns the order batch details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="batchId">Order Batch Id</param>
        /// <returns>ApiResponse of RestApiResultOrderBatch</returns>
        ApiResponse<RestApiResultOrderBatch> GetOrderBatchWithHttpInfo (string appId, int? storeId, int? batchId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns order batches
        /// </summary>
        /// <remarks>
        /// Entries are sorted by date, from the most recent. At most 100 entries are returned.
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="createdFrom">Start date for retrieving the entries (optional)</param>
        /// <param name="createdTo">End date for retrieving the entries (optional)</param>
        /// <returns>Task of RestApiArrayResultOrderBatchItem</returns>
        System.Threading.Tasks.Task<RestApiArrayResultOrderBatchItem> GetAllOrderBatchesAsync (string appId, int? storeId, DateTime? createdFrom = null, DateTime? createdTo = null);

        /// <summary>
        /// Returns order batches
        /// </summary>
        /// <remarks>
        /// Entries are sorted by date, from the most recent. At most 100 entries are returned.
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="createdFrom">Start date for retrieving the entries (optional)</param>
        /// <param name="createdTo">End date for retrieving the entries (optional)</param>
        /// <returns>Task of ApiResponse (RestApiArrayResultOrderBatchItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiArrayResultOrderBatchItem>> GetAllOrderBatchesAsyncWithHttpInfo (string appId, int? storeId, DateTime? createdFrom = null, DateTime? createdTo = null);
        /// <summary>
        /// Returns the order batch details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="batchId">Order Batch Id</param>
        /// <returns>Task of RestApiResultOrderBatch</returns>
        System.Threading.Tasks.Task<RestApiResultOrderBatch> GetOrderBatchAsync (string appId, int? storeId, int? batchId);

        /// <summary>
        /// Returns the order batch details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="batchId">Order Batch Id</param>
        /// <returns>Task of ApiResponse (RestApiResultOrderBatch)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultOrderBatch>> GetOrderBatchAsyncWithHttpInfo (string appId, int? storeId, int? batchId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrderBatchesApi : IOrderBatchesApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBatchesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderBatchesApi(String basePath)
        {
            this.Configuration = new Flipdish.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBatchesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrderBatchesApi(Flipdish.Client.Configuration configuration = null)
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
        /// Returns order batches Entries are sorted by date, from the most recent. At most 100 entries are returned.
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="createdFrom">Start date for retrieving the entries (optional)</param>
        /// <param name="createdTo">End date for retrieving the entries (optional)</param>
        /// <returns>RestApiArrayResultOrderBatchItem</returns>
        public RestApiArrayResultOrderBatchItem GetAllOrderBatches (string appId, int? storeId, DateTime? createdFrom = null, DateTime? createdTo = null)
        {
             ApiResponse<RestApiArrayResultOrderBatchItem> localVarResponse = GetAllOrderBatchesWithHttpInfo(appId, storeId, createdFrom, createdTo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns order batches Entries are sorted by date, from the most recent. At most 100 entries are returned.
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="createdFrom">Start date for retrieving the entries (optional)</param>
        /// <param name="createdTo">End date for retrieving the entries (optional)</param>
        /// <returns>ApiResponse of RestApiArrayResultOrderBatchItem</returns>
        public ApiResponse< RestApiArrayResultOrderBatchItem > GetAllOrderBatchesWithHttpInfo (string appId, int? storeId, DateTime? createdFrom = null, DateTime? createdTo = null)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling OrderBatchesApi->GetAllOrderBatches");
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling OrderBatchesApi->GetAllOrderBatches");

            var localVarPath = "/api/v1.0/{appId}/stores/{storeId}/order-batches";
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
            if (createdFrom != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "createdFrom", createdFrom)); // query parameter
            if (createdTo != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "createdTo", createdTo)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllOrderBatches", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiArrayResultOrderBatchItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiArrayResultOrderBatchItem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiArrayResultOrderBatchItem)));
        }

        /// <summary>
        /// Returns order batches Entries are sorted by date, from the most recent. At most 100 entries are returned.
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="createdFrom">Start date for retrieving the entries (optional)</param>
        /// <param name="createdTo">End date for retrieving the entries (optional)</param>
        /// <returns>Task of RestApiArrayResultOrderBatchItem</returns>
        public async System.Threading.Tasks.Task<RestApiArrayResultOrderBatchItem> GetAllOrderBatchesAsync (string appId, int? storeId, DateTime? createdFrom = null, DateTime? createdTo = null)
        {
             ApiResponse<RestApiArrayResultOrderBatchItem> localVarResponse = await GetAllOrderBatchesAsyncWithHttpInfo(appId, storeId, createdFrom, createdTo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns order batches Entries are sorted by date, from the most recent. At most 100 entries are returned.
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="createdFrom">Start date for retrieving the entries (optional)</param>
        /// <param name="createdTo">End date for retrieving the entries (optional)</param>
        /// <returns>Task of ApiResponse (RestApiArrayResultOrderBatchItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiArrayResultOrderBatchItem>> GetAllOrderBatchesAsyncWithHttpInfo (string appId, int? storeId, DateTime? createdFrom = null, DateTime? createdTo = null)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling OrderBatchesApi->GetAllOrderBatches");
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling OrderBatchesApi->GetAllOrderBatches");

            var localVarPath = "/api/v1.0/{appId}/stores/{storeId}/order-batches";
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
            if (createdFrom != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "createdFrom", createdFrom)); // query parameter
            if (createdTo != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "createdTo", createdTo)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllOrderBatches", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiArrayResultOrderBatchItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiArrayResultOrderBatchItem) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiArrayResultOrderBatchItem)));
        }

        /// <summary>
        /// Returns the order batch details 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="batchId">Order Batch Id</param>
        /// <returns>RestApiResultOrderBatch</returns>
        public RestApiResultOrderBatch GetOrderBatch (string appId, int? storeId, int? batchId)
        {
             ApiResponse<RestApiResultOrderBatch> localVarResponse = GetOrderBatchWithHttpInfo(appId, storeId, batchId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the order batch details 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="batchId">Order Batch Id</param>
        /// <returns>ApiResponse of RestApiResultOrderBatch</returns>
        public ApiResponse< RestApiResultOrderBatch > GetOrderBatchWithHttpInfo (string appId, int? storeId, int? batchId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling OrderBatchesApi->GetOrderBatch");
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling OrderBatchesApi->GetOrderBatch");
            // verify the required parameter 'batchId' is set
            if (batchId == null)
                throw new ApiException(400, "Missing required parameter 'batchId' when calling OrderBatchesApi->GetOrderBatch");

            var localVarPath = "/api/v1.0/{appId}/stores/{storeId}/order-batches/{batchId}";
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
            if (batchId != null) localVarPathParams.Add("batchId", this.Configuration.ApiClient.ParameterToString(batchId)); // path parameter

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
                Exception exception = ExceptionFactory("GetOrderBatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultOrderBatch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultOrderBatch) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultOrderBatch)));
        }

        /// <summary>
        /// Returns the order batch details 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="batchId">Order Batch Id</param>
        /// <returns>Task of RestApiResultOrderBatch</returns>
        public async System.Threading.Tasks.Task<RestApiResultOrderBatch> GetOrderBatchAsync (string appId, int? storeId, int? batchId)
        {
             ApiResponse<RestApiResultOrderBatch> localVarResponse = await GetOrderBatchAsyncWithHttpInfo(appId, storeId, batchId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the order batch details 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="storeId">Store Id</param>
        /// <param name="batchId">Order Batch Id</param>
        /// <returns>Task of ApiResponse (RestApiResultOrderBatch)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultOrderBatch>> GetOrderBatchAsyncWithHttpInfo (string appId, int? storeId, int? batchId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling OrderBatchesApi->GetOrderBatch");
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling OrderBatchesApi->GetOrderBatch");
            // verify the required parameter 'batchId' is set
            if (batchId == null)
                throw new ApiException(400, "Missing required parameter 'batchId' when calling OrderBatchesApi->GetOrderBatch");

            var localVarPath = "/api/v1.0/{appId}/stores/{storeId}/order-batches/{batchId}";
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
            if (batchId != null) localVarPathParams.Add("batchId", this.Configuration.ApiClient.ParameterToString(batchId)); // path parameter

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
                Exception exception = ExceptionFactory("GetOrderBatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultOrderBatch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultOrderBatch) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultOrderBatch)));
        }

    }
}