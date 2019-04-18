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
    public interface IHomeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [PRIVATE API] Dismiss Home Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeActionId">Id of the action</param>
        /// <returns>Object</returns>
        Object DismissHomeAction (int? homeActionId);

        /// <summary>
        /// [PRIVATE API] Dismiss Home Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeActionId">Id of the action</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DismissHomeActionWithHttpInfo (int? homeActionId);
        /// <summary>
        /// [PRIVATE API] Get Home Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Name Id</param>
        /// <returns>RestApiArrayResultHomeAction</returns>
        RestApiArrayResultHomeAction GetHomeActions (string appId);

        /// <summary>
        /// [PRIVATE API] Get Home Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Name Id</param>
        /// <returns>ApiResponse of RestApiArrayResultHomeAction</returns>
        ApiResponse<RestApiArrayResultHomeAction> GetHomeActionsWithHttpInfo (string appId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// [PRIVATE API] Dismiss Home Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeActionId">Id of the action</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DismissHomeActionAsync (int? homeActionId);

        /// <summary>
        /// [PRIVATE API] Dismiss Home Action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeActionId">Id of the action</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DismissHomeActionAsyncWithHttpInfo (int? homeActionId);
        /// <summary>
        /// [PRIVATE API] Get Home Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Name Id</param>
        /// <returns>Task of RestApiArrayResultHomeAction</returns>
        System.Threading.Tasks.Task<RestApiArrayResultHomeAction> GetHomeActionsAsync (string appId);

        /// <summary>
        /// [PRIVATE API] Get Home Actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Name Id</param>
        /// <returns>Task of ApiResponse (RestApiArrayResultHomeAction)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiArrayResultHomeAction>> GetHomeActionsAsyncWithHttpInfo (string appId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class HomeApi : IHomeApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HomeApi(String basePath)
        {
            this.Configuration = new Flipdish.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public HomeApi(Flipdish.Client.Configuration configuration = null)
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
        /// [PRIVATE API] Dismiss Home Action 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeActionId">Id of the action</param>
        /// <returns>Object</returns>
        public Object DismissHomeAction (int? homeActionId)
        {
             ApiResponse<Object> localVarResponse = DismissHomeActionWithHttpInfo(homeActionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [PRIVATE API] Dismiss Home Action 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeActionId">Id of the action</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DismissHomeActionWithHttpInfo (int? homeActionId)
        {
            // verify the required parameter 'homeActionId' is set
            if (homeActionId == null)
                throw new ApiException(400, "Missing required parameter 'homeActionId' when calling HomeApi->DismissHomeAction");

            var localVarPath = "/api/v1.0/home/{homeActionId}";
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

            if (homeActionId != null) localVarPathParams.Add("homeActionId", this.Configuration.ApiClient.ParameterToString(homeActionId)); // path parameter

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
                Exception exception = ExceptionFactory("DismissHomeAction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// [PRIVATE API] Dismiss Home Action 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeActionId">Id of the action</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DismissHomeActionAsync (int? homeActionId)
        {
             ApiResponse<Object> localVarResponse = await DismissHomeActionAsyncWithHttpInfo(homeActionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [PRIVATE API] Dismiss Home Action 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="homeActionId">Id of the action</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DismissHomeActionAsyncWithHttpInfo (int? homeActionId)
        {
            // verify the required parameter 'homeActionId' is set
            if (homeActionId == null)
                throw new ApiException(400, "Missing required parameter 'homeActionId' when calling HomeApi->DismissHomeAction");

            var localVarPath = "/api/v1.0/home/{homeActionId}";
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

            if (homeActionId != null) localVarPathParams.Add("homeActionId", this.Configuration.ApiClient.ParameterToString(homeActionId)); // path parameter

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
                Exception exception = ExceptionFactory("DismissHomeAction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// [PRIVATE API] Get Home Actions 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Name Id</param>
        /// <returns>RestApiArrayResultHomeAction</returns>
        public RestApiArrayResultHomeAction GetHomeActions (string appId)
        {
             ApiResponse<RestApiArrayResultHomeAction> localVarResponse = GetHomeActionsWithHttpInfo(appId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [PRIVATE API] Get Home Actions 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Name Id</param>
        /// <returns>ApiResponse of RestApiArrayResultHomeAction</returns>
        public ApiResponse< RestApiArrayResultHomeAction > GetHomeActionsWithHttpInfo (string appId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling HomeApi->GetHomeActions");

            var localVarPath = "/api/v1.0/home";
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

            if (appId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "appId", appId)); // query parameter

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
                Exception exception = ExceptionFactory("GetHomeActions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiArrayResultHomeAction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiArrayResultHomeAction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiArrayResultHomeAction)));
        }

        /// <summary>
        /// [PRIVATE API] Get Home Actions 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Name Id</param>
        /// <returns>Task of RestApiArrayResultHomeAction</returns>
        public async System.Threading.Tasks.Task<RestApiArrayResultHomeAction> GetHomeActionsAsync (string appId)
        {
             ApiResponse<RestApiArrayResultHomeAction> localVarResponse = await GetHomeActionsAsyncWithHttpInfo(appId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [PRIVATE API] Get Home Actions 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Name Id</param>
        /// <returns>Task of ApiResponse (RestApiArrayResultHomeAction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiArrayResultHomeAction>> GetHomeActionsAsyncWithHttpInfo (string appId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling HomeApi->GetHomeActions");

            var localVarPath = "/api/v1.0/home";
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

            if (appId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "appId", appId)); // query parameter

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
                Exception exception = ExceptionFactory("GetHomeActions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiArrayResultHomeAction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiArrayResultHomeAction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiArrayResultHomeAction)));
        }

    }
}
