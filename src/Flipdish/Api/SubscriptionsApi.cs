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
    public interface ISubscriptionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get subscription by id
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id</param>
        /// <returns>RestApiResultSubscription</returns>
        RestApiResultSubscription GetSubscriptionById (string appId, string subscriptionId);

        /// <summary>
        /// Get subscription by id
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id</param>
        /// <returns>ApiResponse of RestApiResultSubscription</returns>
        ApiResponse<RestApiResultSubscription> GetSubscriptionByIdWithHttpInfo (string appId, string subscriptionId);
        /// <summary>
        /// Get list of subscriptions for an App
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="excludeNotOwnedSubscriptions">Exclude not owned subscriptions. Set to true to only view your subscriptions (optional)</param>
        /// <param name="storeId">Store Ids (optional)</param>
        /// <returns>RestApiArrayResultSubscriptionSummary</returns>
        RestApiArrayResultSubscriptionSummary GetSubscriptionsForApp (string appId, bool? excludeNotOwnedSubscriptions = null, List<int?> storeId = null);

        /// <summary>
        /// Get list of subscriptions for an App
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="excludeNotOwnedSubscriptions">Exclude not owned subscriptions. Set to true to only view your subscriptions (optional)</param>
        /// <param name="storeId">Store Ids (optional)</param>
        /// <returns>ApiResponse of RestApiArrayResultSubscriptionSummary</returns>
        ApiResponse<RestApiArrayResultSubscriptionSummary> GetSubscriptionsForAppWithHttpInfo (string appId, bool? excludeNotOwnedSubscriptions = null, List<int?> storeId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get subscription by id
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id</param>
        /// <returns>Task of RestApiResultSubscription</returns>
        System.Threading.Tasks.Task<RestApiResultSubscription> GetSubscriptionByIdAsync (string appId, string subscriptionId);

        /// <summary>
        /// Get subscription by id
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id</param>
        /// <returns>Task of ApiResponse (RestApiResultSubscription)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultSubscription>> GetSubscriptionByIdAsyncWithHttpInfo (string appId, string subscriptionId);
        /// <summary>
        /// Get list of subscriptions for an App
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="excludeNotOwnedSubscriptions">Exclude not owned subscriptions. Set to true to only view your subscriptions (optional)</param>
        /// <param name="storeId">Store Ids (optional)</param>
        /// <returns>Task of RestApiArrayResultSubscriptionSummary</returns>
        System.Threading.Tasks.Task<RestApiArrayResultSubscriptionSummary> GetSubscriptionsForAppAsync (string appId, bool? excludeNotOwnedSubscriptions = null, List<int?> storeId = null);

        /// <summary>
        /// Get list of subscriptions for an App
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="excludeNotOwnedSubscriptions">Exclude not owned subscriptions. Set to true to only view your subscriptions (optional)</param>
        /// <param name="storeId">Store Ids (optional)</param>
        /// <returns>Task of ApiResponse (RestApiArrayResultSubscriptionSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiArrayResultSubscriptionSummary>> GetSubscriptionsForAppAsyncWithHttpInfo (string appId, bool? excludeNotOwnedSubscriptions = null, List<int?> storeId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionsApi : ISubscriptionsApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionsApi(String basePath)
        {
            this.Configuration = new Flipdish.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubscriptionsApi(Flipdish.Client.Configuration configuration = null)
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
        /// Get subscription by id [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id</param>
        /// <returns>RestApiResultSubscription</returns>
        public RestApiResultSubscription GetSubscriptionById (string appId, string subscriptionId)
        {
             ApiResponse<RestApiResultSubscription> localVarResponse = GetSubscriptionByIdWithHttpInfo(appId, subscriptionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get subscription by id [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id</param>
        /// <returns>ApiResponse of RestApiResultSubscription</returns>
        public ApiResponse< RestApiResultSubscription > GetSubscriptionByIdWithHttpInfo (string appId, string subscriptionId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling SubscriptionsApi->GetSubscriptionById");
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionsApi->GetSubscriptionById");

            var localVarPath = "./api/v1.0/{appId}/subscriptions/{subscriptionId}";
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
            if (subscriptionId != null) localVarPathParams.Add("subscriptionId", this.Configuration.ApiClient.ParameterToString(subscriptionId)); // path parameter

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
                Exception exception = ExceptionFactory("GetSubscriptionById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultSubscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultSubscription) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultSubscription)));
        }

        /// <summary>
        /// Get subscription by id [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id</param>
        /// <returns>Task of RestApiResultSubscription</returns>
        public async System.Threading.Tasks.Task<RestApiResultSubscription> GetSubscriptionByIdAsync (string appId, string subscriptionId)
        {
             ApiResponse<RestApiResultSubscription> localVarResponse = await GetSubscriptionByIdAsyncWithHttpInfo(appId, subscriptionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get subscription by id [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id</param>
        /// <returns>Task of ApiResponse (RestApiResultSubscription)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultSubscription>> GetSubscriptionByIdAsyncWithHttpInfo (string appId, string subscriptionId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling SubscriptionsApi->GetSubscriptionById");
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionsApi->GetSubscriptionById");

            var localVarPath = "./api/v1.0/{appId}/subscriptions/{subscriptionId}";
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
            if (subscriptionId != null) localVarPathParams.Add("subscriptionId", this.Configuration.ApiClient.ParameterToString(subscriptionId)); // path parameter

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
                Exception exception = ExceptionFactory("GetSubscriptionById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultSubscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultSubscription) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultSubscription)));
        }

        /// <summary>
        /// Get list of subscriptions for an App [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="excludeNotOwnedSubscriptions">Exclude not owned subscriptions. Set to true to only view your subscriptions (optional)</param>
        /// <param name="storeId">Store Ids (optional)</param>
        /// <returns>RestApiArrayResultSubscriptionSummary</returns>
        public RestApiArrayResultSubscriptionSummary GetSubscriptionsForApp (string appId, bool? excludeNotOwnedSubscriptions = null, List<int?> storeId = null)
        {
             ApiResponse<RestApiArrayResultSubscriptionSummary> localVarResponse = GetSubscriptionsForAppWithHttpInfo(appId, excludeNotOwnedSubscriptions, storeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of subscriptions for an App [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="excludeNotOwnedSubscriptions">Exclude not owned subscriptions. Set to true to only view your subscriptions (optional)</param>
        /// <param name="storeId">Store Ids (optional)</param>
        /// <returns>ApiResponse of RestApiArrayResultSubscriptionSummary</returns>
        public ApiResponse< RestApiArrayResultSubscriptionSummary > GetSubscriptionsForAppWithHttpInfo (string appId, bool? excludeNotOwnedSubscriptions = null, List<int?> storeId = null)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling SubscriptionsApi->GetSubscriptionsForApp");

            var localVarPath = "./api/v1.0/{appId}/subscriptions";
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
            if (excludeNotOwnedSubscriptions != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "excludeNotOwnedSubscriptions", excludeNotOwnedSubscriptions)); // query parameter
            if (storeId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "storeId", storeId)); // query parameter

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
                Exception exception = ExceptionFactory("GetSubscriptionsForApp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiArrayResultSubscriptionSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiArrayResultSubscriptionSummary) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiArrayResultSubscriptionSummary)));
        }

        /// <summary>
        /// Get list of subscriptions for an App [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="excludeNotOwnedSubscriptions">Exclude not owned subscriptions. Set to true to only view your subscriptions (optional)</param>
        /// <param name="storeId">Store Ids (optional)</param>
        /// <returns>Task of RestApiArrayResultSubscriptionSummary</returns>
        public async System.Threading.Tasks.Task<RestApiArrayResultSubscriptionSummary> GetSubscriptionsForAppAsync (string appId, bool? excludeNotOwnedSubscriptions = null, List<int?> storeId = null)
        {
             ApiResponse<RestApiArrayResultSubscriptionSummary> localVarResponse = await GetSubscriptionsForAppAsyncWithHttpInfo(appId, excludeNotOwnedSubscriptions, storeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of subscriptions for an App [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="excludeNotOwnedSubscriptions">Exclude not owned subscriptions. Set to true to only view your subscriptions (optional)</param>
        /// <param name="storeId">Store Ids (optional)</param>
        /// <returns>Task of ApiResponse (RestApiArrayResultSubscriptionSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiArrayResultSubscriptionSummary>> GetSubscriptionsForAppAsyncWithHttpInfo (string appId, bool? excludeNotOwnedSubscriptions = null, List<int?> storeId = null)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling SubscriptionsApi->GetSubscriptionsForApp");

            var localVarPath = "./api/v1.0/{appId}/subscriptions";
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
            if (excludeNotOwnedSubscriptions != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "excludeNotOwnedSubscriptions", excludeNotOwnedSubscriptions)); // query parameter
            if (storeId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "storeId", storeId)); // query parameter

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
                Exception exception = ExceptionFactory("GetSubscriptionsForApp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiArrayResultSubscriptionSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiArrayResultSubscriptionSummary) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiArrayResultSubscriptionSummary)));
        }

    }
}
