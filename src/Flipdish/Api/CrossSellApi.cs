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
    public interface ICrossSellApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="menuId"></param>
        /// <param name="menuItemId"></param>
        /// <param name="limit"></param>
        /// <param name="totalValue"></param>
        /// <param name="appId"></param>
        /// <returns>RestApiResultCrossSellMenuItems</returns>
        RestApiResultCrossSellMenuItems GetCrossSellMenuItems (int? menuId, List<int?> menuItemId, int? limit, double? totalValue, string appId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="menuId"></param>
        /// <param name="menuItemId"></param>
        /// <param name="limit"></param>
        /// <param name="totalValue"></param>
        /// <param name="appId"></param>
        /// <returns>ApiResponse of RestApiResultCrossSellMenuItems</returns>
        ApiResponse<RestApiResultCrossSellMenuItems> GetCrossSellMenuItemsWithHttpInfo (int? menuId, List<int?> menuItemId, int? limit, double? totalValue, string appId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="menuId"></param>
        /// <param name="menuItemId"></param>
        /// <param name="limit"></param>
        /// <param name="totalValue"></param>
        /// <param name="appId"></param>
        /// <returns>Task of RestApiResultCrossSellMenuItems</returns>
        System.Threading.Tasks.Task<RestApiResultCrossSellMenuItems> GetCrossSellMenuItemsAsync (int? menuId, List<int?> menuItemId, int? limit, double? totalValue, string appId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="menuId"></param>
        /// <param name="menuItemId"></param>
        /// <param name="limit"></param>
        /// <param name="totalValue"></param>
        /// <param name="appId"></param>
        /// <returns>Task of ApiResponse (RestApiResultCrossSellMenuItems)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultCrossSellMenuItems>> GetCrossSellMenuItemsAsyncWithHttpInfo (int? menuId, List<int?> menuItemId, int? limit, double? totalValue, string appId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CrossSellApi : ICrossSellApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossSellApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CrossSellApi(String basePath)
        {
            this.Configuration = new Flipdish.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossSellApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CrossSellApi(Flipdish.Client.Configuration configuration = null)
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
        /// <param name="menuId"></param>
        /// <param name="menuItemId"></param>
        /// <param name="limit"></param>
        /// <param name="totalValue"></param>
        /// <param name="appId"></param>
        /// <returns>RestApiResultCrossSellMenuItems</returns>
        public RestApiResultCrossSellMenuItems GetCrossSellMenuItems (int? menuId, List<int?> menuItemId, int? limit, double? totalValue, string appId)
        {
             ApiResponse<RestApiResultCrossSellMenuItems> localVarResponse = GetCrossSellMenuItemsWithHttpInfo(menuId, menuItemId, limit, totalValue, appId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="menuId"></param>
        /// <param name="menuItemId"></param>
        /// <param name="limit"></param>
        /// <param name="totalValue"></param>
        /// <param name="appId"></param>
        /// <returns>ApiResponse of RestApiResultCrossSellMenuItems</returns>
        public ApiResponse< RestApiResultCrossSellMenuItems > GetCrossSellMenuItemsWithHttpInfo (int? menuId, List<int?> menuItemId, int? limit, double? totalValue, string appId)
        {
            // verify the required parameter 'menuId' is set
            if (menuId == null)
                throw new ApiException(400, "Missing required parameter 'menuId' when calling CrossSellApi->GetCrossSellMenuItems");
            // verify the required parameter 'menuItemId' is set
            if (menuItemId == null)
                throw new ApiException(400, "Missing required parameter 'menuItemId' when calling CrossSellApi->GetCrossSellMenuItems");
            // verify the required parameter 'limit' is set
            if (limit == null)
                throw new ApiException(400, "Missing required parameter 'limit' when calling CrossSellApi->GetCrossSellMenuItems");
            // verify the required parameter 'totalValue' is set
            if (totalValue == null)
                throw new ApiException(400, "Missing required parameter 'totalValue' when calling CrossSellApi->GetCrossSellMenuItems");
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling CrossSellApi->GetCrossSellMenuItems");

            var localVarPath = "./api/v1.0/{appId}/crossSell/menuItems";
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
            if (menuId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "menuId", menuId)); // query parameter
            if (menuItemId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "menuItemId", menuItemId)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (totalValue != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "totalValue", totalValue)); // query parameter

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
                Exception exception = ExceptionFactory("GetCrossSellMenuItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultCrossSellMenuItems>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultCrossSellMenuItems) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultCrossSellMenuItems)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="menuId"></param>
        /// <param name="menuItemId"></param>
        /// <param name="limit"></param>
        /// <param name="totalValue"></param>
        /// <param name="appId"></param>
        /// <returns>Task of RestApiResultCrossSellMenuItems</returns>
        public async System.Threading.Tasks.Task<RestApiResultCrossSellMenuItems> GetCrossSellMenuItemsAsync (int? menuId, List<int?> menuItemId, int? limit, double? totalValue, string appId)
        {
             ApiResponse<RestApiResultCrossSellMenuItems> localVarResponse = await GetCrossSellMenuItemsAsyncWithHttpInfo(menuId, menuItemId, limit, totalValue, appId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="menuId"></param>
        /// <param name="menuItemId"></param>
        /// <param name="limit"></param>
        /// <param name="totalValue"></param>
        /// <param name="appId"></param>
        /// <returns>Task of ApiResponse (RestApiResultCrossSellMenuItems)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultCrossSellMenuItems>> GetCrossSellMenuItemsAsyncWithHttpInfo (int? menuId, List<int?> menuItemId, int? limit, double? totalValue, string appId)
        {
            // verify the required parameter 'menuId' is set
            if (menuId == null)
                throw new ApiException(400, "Missing required parameter 'menuId' when calling CrossSellApi->GetCrossSellMenuItems");
            // verify the required parameter 'menuItemId' is set
            if (menuItemId == null)
                throw new ApiException(400, "Missing required parameter 'menuItemId' when calling CrossSellApi->GetCrossSellMenuItems");
            // verify the required parameter 'limit' is set
            if (limit == null)
                throw new ApiException(400, "Missing required parameter 'limit' when calling CrossSellApi->GetCrossSellMenuItems");
            // verify the required parameter 'totalValue' is set
            if (totalValue == null)
                throw new ApiException(400, "Missing required parameter 'totalValue' when calling CrossSellApi->GetCrossSellMenuItems");
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling CrossSellApi->GetCrossSellMenuItems");

            var localVarPath = "./api/v1.0/{appId}/crossSell/menuItems";
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
            if (menuId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "menuId", menuId)); // query parameter
            if (menuItemId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "menuItemId", menuItemId)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (totalValue != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "totalValue", totalValue)); // query parameter

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
                Exception exception = ExceptionFactory("GetCrossSellMenuItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultCrossSellMenuItems>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultCrossSellMenuItems) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultCrossSellMenuItems)));
        }

    }
}
