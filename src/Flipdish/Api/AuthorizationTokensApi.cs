/* 
 * Flipdish Open API
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
    public interface IAuthorizationTokensApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get authorization tokens
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client identifier</param>
        /// <param name="apiVersion">API version</param>
        /// <param name="page">Requested page number (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>RestApiPaginationResultOAuthTokenModel</returns>
        RestApiPaginationResultOAuthTokenModel GetAuthorizationTokens (string clientId, string apiVersion, int? page = null, int? limit = null);

        /// <summary>
        /// Get authorization tokens
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client identifier</param>
        /// <param name="apiVersion">API version</param>
        /// <param name="page">Requested page number (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>ApiResponse of RestApiPaginationResultOAuthTokenModel</returns>
        ApiResponse<RestApiPaginationResultOAuthTokenModel> GetAuthorizationTokensWithHttpInfo (string clientId, string apiVersion, int? page = null, int? limit = null);
        /// <summary>
        /// Revoke token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Token identifier key</param>
        /// <param name="apiVersion">API version</param>
        /// <returns></returns>
        void RevokeToken (string key, string apiVersion);

        /// <summary>
        /// Revoke token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Token identifier key</param>
        /// <param name="apiVersion">API version</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RevokeTokenWithHttpInfo (string key, string apiVersion);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get authorization tokens
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client identifier</param>
        /// <param name="apiVersion">API version</param>
        /// <param name="page">Requested page number (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>Task of RestApiPaginationResultOAuthTokenModel</returns>
        System.Threading.Tasks.Task<RestApiPaginationResultOAuthTokenModel> GetAuthorizationTokensAsync (string clientId, string apiVersion, int? page = null, int? limit = null);

        /// <summary>
        /// Get authorization tokens
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client identifier</param>
        /// <param name="apiVersion">API version</param>
        /// <param name="page">Requested page number (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>Task of ApiResponse (RestApiPaginationResultOAuthTokenModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiPaginationResultOAuthTokenModel>> GetAuthorizationTokensAsyncWithHttpInfo (string clientId, string apiVersion, int? page = null, int? limit = null);
        /// <summary>
        /// Revoke token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Token identifier key</param>
        /// <param name="apiVersion">API version</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RevokeTokenAsync (string key, string apiVersion);

        /// <summary>
        /// Revoke token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Token identifier key</param>
        /// <param name="apiVersion">API version</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RevokeTokenAsyncWithHttpInfo (string key, string apiVersion);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthorizationTokensApi : IAuthorizationTokensApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationTokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthorizationTokensApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationTokensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthorizationTokensApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;

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
        /// Get authorization tokens 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client identifier</param>
        /// <param name="apiVersion">API version</param>
        /// <param name="page">Requested page number (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>RestApiPaginationResultOAuthTokenModel</returns>
        public RestApiPaginationResultOAuthTokenModel GetAuthorizationTokens (string clientId, string apiVersion, int? page = null, int? limit = null)
        {
             ApiResponse<RestApiPaginationResultOAuthTokenModel> localVarResponse = GetAuthorizationTokensWithHttpInfo(clientId, apiVersion, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get authorization tokens 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client identifier</param>
        /// <param name="apiVersion">API version</param>
        /// <param name="page">Requested page number (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>ApiResponse of RestApiPaginationResultOAuthTokenModel</returns>
        public ApiResponse< RestApiPaginationResultOAuthTokenModel > GetAuthorizationTokensWithHttpInfo (string clientId, string apiVersion, int? page = null, int? limit = null)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling AuthorizationTokensApi->GetAuthorizationTokens");
            // verify the required parameter 'apiVersion' is set
            if (apiVersion == null)
                throw new ApiException(400, "Missing required parameter 'apiVersion' when calling AuthorizationTokensApi->GetAuthorizationTokens");

            var localVarPath = "/api/v{apiVersion}/authorizationtokens/{clientId}";
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            if (apiVersion != null) localVarPathParams.Add("apiVersion", Configuration.ApiClient.ParameterToString(apiVersion)); // path parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter

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
                Exception exception = ExceptionFactory("GetAuthorizationTokens", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiPaginationResultOAuthTokenModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiPaginationResultOAuthTokenModel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiPaginationResultOAuthTokenModel)));
        }

        /// <summary>
        /// Get authorization tokens 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client identifier</param>
        /// <param name="apiVersion">API version</param>
        /// <param name="page">Requested page number (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>Task of RestApiPaginationResultOAuthTokenModel</returns>
        public async System.Threading.Tasks.Task<RestApiPaginationResultOAuthTokenModel> GetAuthorizationTokensAsync (string clientId, string apiVersion, int? page = null, int? limit = null)
        {
             ApiResponse<RestApiPaginationResultOAuthTokenModel> localVarResponse = await GetAuthorizationTokensAsyncWithHttpInfo(clientId, apiVersion, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get authorization tokens 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">Client identifier</param>
        /// <param name="apiVersion">API version</param>
        /// <param name="page">Requested page number (optional)</param>
        /// <param name="limit">Requested page limit (optional)</param>
        /// <returns>Task of ApiResponse (RestApiPaginationResultOAuthTokenModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiPaginationResultOAuthTokenModel>> GetAuthorizationTokensAsyncWithHttpInfo (string clientId, string apiVersion, int? page = null, int? limit = null)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling AuthorizationTokensApi->GetAuthorizationTokens");
            // verify the required parameter 'apiVersion' is set
            if (apiVersion == null)
                throw new ApiException(400, "Missing required parameter 'apiVersion' when calling AuthorizationTokensApi->GetAuthorizationTokens");

            var localVarPath = "/api/v{apiVersion}/authorizationtokens/{clientId}";
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            if (apiVersion != null) localVarPathParams.Add("apiVersion", Configuration.ApiClient.ParameterToString(apiVersion)); // path parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter

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
                Exception exception = ExceptionFactory("GetAuthorizationTokens", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiPaginationResultOAuthTokenModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiPaginationResultOAuthTokenModel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiPaginationResultOAuthTokenModel)));
        }

        /// <summary>
        /// Revoke token 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Token identifier key</param>
        /// <param name="apiVersion">API version</param>
        /// <returns></returns>
        public void RevokeToken (string key, string apiVersion)
        {
             RevokeTokenWithHttpInfo(key, apiVersion);
        }

        /// <summary>
        /// Revoke token 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Token identifier key</param>
        /// <param name="apiVersion">API version</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RevokeTokenWithHttpInfo (string key, string apiVersion)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling AuthorizationTokensApi->RevokeToken");
            // verify the required parameter 'apiVersion' is set
            if (apiVersion == null)
                throw new ApiException(400, "Missing required parameter 'apiVersion' when calling AuthorizationTokensApi->RevokeToken");

            var localVarPath = "/api/v{apiVersion}/authorizationtokens/{key}";
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (key != null) localVarPathParams.Add("key", Configuration.ApiClient.ParameterToString(key)); // path parameter
            if (apiVersion != null) localVarPathParams.Add("apiVersion", Configuration.ApiClient.ParameterToString(apiVersion)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RevokeToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Revoke token 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Token identifier key</param>
        /// <param name="apiVersion">API version</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RevokeTokenAsync (string key, string apiVersion)
        {
             await RevokeTokenAsyncWithHttpInfo(key, apiVersion);

        }

        /// <summary>
        /// Revoke token 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Token identifier key</param>
        /// <param name="apiVersion">API version</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RevokeTokenAsyncWithHttpInfo (string key, string apiVersion)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling AuthorizationTokensApi->RevokeToken");
            // verify the required parameter 'apiVersion' is set
            if (apiVersion == null)
                throw new ApiException(400, "Missing required parameter 'apiVersion' when calling AuthorizationTokensApi->RevokeToken");

            var localVarPath = "/api/v{apiVersion}/authorizationtokens/{key}";
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (key != null) localVarPathParams.Add("key", Configuration.ApiClient.ParameterToString(key)); // path parameter
            if (apiVersion != null) localVarPathParams.Add("apiVersion", Configuration.ApiClient.ParameterToString(apiVersion)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RevokeToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
