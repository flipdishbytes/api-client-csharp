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
    public interface IPaymentIntentsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns stripe payment intent for a given id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentIntentId">Stripe payment intent identifier</param>
        /// <returns>RestApiResultPaymentIntent</returns>
        RestApiResultPaymentIntent GetPaymentIntent (string paymentIntentId);

        /// <summary>
        /// Returns stripe payment intent for a given id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentIntentId">Stripe payment intent identifier</param>
        /// <returns>ApiResponse of RestApiResultPaymentIntent</returns>
        ApiResponse<RestApiResultPaymentIntent> GetPaymentIntentWithHttpInfo (string paymentIntentId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns stripe payment intent for a given id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentIntentId">Stripe payment intent identifier</param>
        /// <returns>Task of RestApiResultPaymentIntent</returns>
        System.Threading.Tasks.Task<RestApiResultPaymentIntent> GetPaymentIntentAsync (string paymentIntentId);

        /// <summary>
        /// Returns stripe payment intent for a given id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentIntentId">Stripe payment intent identifier</param>
        /// <returns>Task of ApiResponse (RestApiResultPaymentIntent)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultPaymentIntent>> GetPaymentIntentAsyncWithHttpInfo (string paymentIntentId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentIntentsApi : IPaymentIntentsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentIntentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentIntentsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentIntentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentIntentsApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// Returns stripe payment intent for a given id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentIntentId">Stripe payment intent identifier</param>
        /// <returns>RestApiResultPaymentIntent</returns>
        public RestApiResultPaymentIntent GetPaymentIntent (string paymentIntentId)
        {
             ApiResponse<RestApiResultPaymentIntent> localVarResponse = GetPaymentIntentWithHttpInfo(paymentIntentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns stripe payment intent for a given id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentIntentId">Stripe payment intent identifier</param>
        /// <returns>ApiResponse of RestApiResultPaymentIntent</returns>
        public ApiResponse< RestApiResultPaymentIntent > GetPaymentIntentWithHttpInfo (string paymentIntentId)
        {
            // verify the required parameter 'paymentIntentId' is set
            if (paymentIntentId == null)
                throw new ApiException(400, "Missing required parameter 'paymentIntentId' when calling PaymentIntentsApi->GetPaymentIntent");

            var localVarPath = "/api/v1.0/payment_intents/{paymentIntentId}";
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

            if (paymentIntentId != null) localVarPathParams.Add("paymentIntentId", this.Configuration.ApiClient.ParameterToString(paymentIntentId)); // path parameter

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
                Exception exception = ExceptionFactory("GetPaymentIntent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultPaymentIntent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultPaymentIntent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultPaymentIntent)));
        }

        /// <summary>
        /// Returns stripe payment intent for a given id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentIntentId">Stripe payment intent identifier</param>
        /// <returns>Task of RestApiResultPaymentIntent</returns>
        public async System.Threading.Tasks.Task<RestApiResultPaymentIntent> GetPaymentIntentAsync (string paymentIntentId)
        {
             ApiResponse<RestApiResultPaymentIntent> localVarResponse = await GetPaymentIntentAsyncWithHttpInfo(paymentIntentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns stripe payment intent for a given id 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentIntentId">Stripe payment intent identifier</param>
        /// <returns>Task of ApiResponse (RestApiResultPaymentIntent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultPaymentIntent>> GetPaymentIntentAsyncWithHttpInfo (string paymentIntentId)
        {
            // verify the required parameter 'paymentIntentId' is set
            if (paymentIntentId == null)
                throw new ApiException(400, "Missing required parameter 'paymentIntentId' when calling PaymentIntentsApi->GetPaymentIntent");

            var localVarPath = "/api/v1.0/payment_intents/{paymentIntentId}";
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

            if (paymentIntentId != null) localVarPathParams.Add("paymentIntentId", this.Configuration.ApiClient.ParameterToString(paymentIntentId)); // path parameter

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
                Exception exception = ExceptionFactory("GetPaymentIntent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultPaymentIntent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultPaymentIntent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultPaymentIntent)));
        }

    }
}
