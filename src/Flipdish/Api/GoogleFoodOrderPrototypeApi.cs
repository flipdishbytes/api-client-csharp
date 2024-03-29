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
    public interface IGoogleFoodOrderPrototypeApi : IApiAccessor
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
        /// <param name="orderRequest"></param>
        /// <returns>RestApiResultSubmitOrderResponseDm</returns>
        RestApiResultSubmitOrderResponseDm CreateOrder (string appId, CreateOrderRequest orderRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderRequest"></param>
        /// <returns>ApiResponse of RestApiResultSubmitOrderResponseDm</returns>
        ApiResponse<RestApiResultSubmitOrderResponseDm> CreateOrderWithHttpInfo (string appId, CreateOrderRequest orderRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderId"></param>
        /// <param name="request"></param>
        /// <returns>RestApiResultSubmitOrderResponseDm</returns>
        RestApiResultSubmitOrderResponseDm SubmitOrder (string appId, int? orderId, SubmitOrderRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderId"></param>
        /// <param name="request"></param>
        /// <returns>ApiResponse of RestApiResultSubmitOrderResponseDm</returns>
        ApiResponse<RestApiResultSubmitOrderResponseDm> SubmitOrderWithHttpInfo (string appId, int? orderId, SubmitOrderRequest request);
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
        /// <param name="orderRequest"></param>
        /// <returns>Task of RestApiResultSubmitOrderResponseDm</returns>
        System.Threading.Tasks.Task<RestApiResultSubmitOrderResponseDm> CreateOrderAsync (string appId, CreateOrderRequest orderRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderRequest"></param>
        /// <returns>Task of ApiResponse (RestApiResultSubmitOrderResponseDm)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultSubmitOrderResponseDm>> CreateOrderAsyncWithHttpInfo (string appId, CreateOrderRequest orderRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderId"></param>
        /// <param name="request"></param>
        /// <returns>Task of RestApiResultSubmitOrderResponseDm</returns>
        System.Threading.Tasks.Task<RestApiResultSubmitOrderResponseDm> SubmitOrderAsync (string appId, int? orderId, SubmitOrderRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderId"></param>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse (RestApiResultSubmitOrderResponseDm)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultSubmitOrderResponseDm>> SubmitOrderAsyncWithHttpInfo (string appId, int? orderId, SubmitOrderRequest request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GoogleFoodOrderPrototypeApi : IGoogleFoodOrderPrototypeApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleFoodOrderPrototypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GoogleFoodOrderPrototypeApi(String basePath)
        {
            this.Configuration = new Flipdish.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleFoodOrderPrototypeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GoogleFoodOrderPrototypeApi(Flipdish.Client.Configuration configuration = null)
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
        /// <param name="orderRequest"></param>
        /// <returns>RestApiResultSubmitOrderResponseDm</returns>
        public RestApiResultSubmitOrderResponseDm CreateOrder (string appId, CreateOrderRequest orderRequest)
        {
             ApiResponse<RestApiResultSubmitOrderResponseDm> localVarResponse = CreateOrderWithHttpInfo(appId, orderRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderRequest"></param>
        /// <returns>ApiResponse of RestApiResultSubmitOrderResponseDm</returns>
        public ApiResponse< RestApiResultSubmitOrderResponseDm > CreateOrderWithHttpInfo (string appId, CreateOrderRequest orderRequest)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling GoogleFoodOrderPrototypeApi->CreateOrder");
            // verify the required parameter 'orderRequest' is set
            if (orderRequest == null)
                throw new ApiException(400, "Missing required parameter 'orderRequest' when calling GoogleFoodOrderPrototypeApi->CreateOrder");

            var localVarPath = "./api/v1.0/{appId}/googleorder";
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
            if (orderRequest != null && orderRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(orderRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = orderRequest; // byte array
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
                Exception exception = ExceptionFactory("CreateOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultSubmitOrderResponseDm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultSubmitOrderResponseDm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultSubmitOrderResponseDm)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderRequest"></param>
        /// <returns>Task of RestApiResultSubmitOrderResponseDm</returns>
        public async System.Threading.Tasks.Task<RestApiResultSubmitOrderResponseDm> CreateOrderAsync (string appId, CreateOrderRequest orderRequest)
        {
             ApiResponse<RestApiResultSubmitOrderResponseDm> localVarResponse = await CreateOrderAsyncWithHttpInfo(appId, orderRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderRequest"></param>
        /// <returns>Task of ApiResponse (RestApiResultSubmitOrderResponseDm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultSubmitOrderResponseDm>> CreateOrderAsyncWithHttpInfo (string appId, CreateOrderRequest orderRequest)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling GoogleFoodOrderPrototypeApi->CreateOrder");
            // verify the required parameter 'orderRequest' is set
            if (orderRequest == null)
                throw new ApiException(400, "Missing required parameter 'orderRequest' when calling GoogleFoodOrderPrototypeApi->CreateOrder");

            var localVarPath = "./api/v1.0/{appId}/googleorder";
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
            if (orderRequest != null && orderRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(orderRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = orderRequest; // byte array
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
                Exception exception = ExceptionFactory("CreateOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultSubmitOrderResponseDm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultSubmitOrderResponseDm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultSubmitOrderResponseDm)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderId"></param>
        /// <param name="request"></param>
        /// <returns>RestApiResultSubmitOrderResponseDm</returns>
        public RestApiResultSubmitOrderResponseDm SubmitOrder (string appId, int? orderId, SubmitOrderRequest request)
        {
             ApiResponse<RestApiResultSubmitOrderResponseDm> localVarResponse = SubmitOrderWithHttpInfo(appId, orderId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderId"></param>
        /// <param name="request"></param>
        /// <returns>ApiResponse of RestApiResultSubmitOrderResponseDm</returns>
        public ApiResponse< RestApiResultSubmitOrderResponseDm > SubmitOrderWithHttpInfo (string appId, int? orderId, SubmitOrderRequest request)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling GoogleFoodOrderPrototypeApi->SubmitOrder");
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling GoogleFoodOrderPrototypeApi->SubmitOrder");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling GoogleFoodOrderPrototypeApi->SubmitOrder");

            var localVarPath = "./api/v1.0/{appId}/googleorder/{orderId}/submit";
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
            if (orderId != null) localVarPathParams.Add("orderId", this.Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("SubmitOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultSubmitOrderResponseDm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultSubmitOrderResponseDm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultSubmitOrderResponseDm)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderId"></param>
        /// <param name="request"></param>
        /// <returns>Task of RestApiResultSubmitOrderResponseDm</returns>
        public async System.Threading.Tasks.Task<RestApiResultSubmitOrderResponseDm> SubmitOrderAsync (string appId, int? orderId, SubmitOrderRequest request)
        {
             ApiResponse<RestApiResultSubmitOrderResponseDm> localVarResponse = await SubmitOrderAsyncWithHttpInfo(appId, orderId, request);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="orderId"></param>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse (RestApiResultSubmitOrderResponseDm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultSubmitOrderResponseDm>> SubmitOrderAsyncWithHttpInfo (string appId, int? orderId, SubmitOrderRequest request)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling GoogleFoodOrderPrototypeApi->SubmitOrder");
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling GoogleFoodOrderPrototypeApi->SubmitOrder");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling GoogleFoodOrderPrototypeApi->SubmitOrder");

            var localVarPath = "./api/v1.0/{appId}/googleorder/{orderId}/submit";
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
            if (orderId != null) localVarPathParams.Add("orderId", this.Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
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
                Exception exception = ExceptionFactory("SubmitOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultSubmitOrderResponseDm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultSubmitOrderResponseDm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultSubmitOrderResponseDm)));
        }

    }
}
