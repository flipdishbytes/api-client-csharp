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
    public interface ICustomersApi : IApiAccessor
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
        /// <param name="customerId"></param>
        /// <returns>Object</returns>
        Object CustomersGetOptOutMarketingLink (string appId, int? customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> CustomersGetOptOutMarketingLinkWithHttpInfo (string appId, int? customerId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>RestApiResultCustomer</returns>
        RestApiResultCustomer GetCustomerById (string appId, int? customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>ApiResponse of RestApiResultCustomer</returns>
        ApiResponse<RestApiResultCustomer> GetCustomerByIdWithHttpInfo (string appId, int? customerId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <param name="updateCustomer"></param>
        /// <returns>RestApiResultCustomer</returns>
        RestApiResultCustomer UpdateCustomerById (string appId, int? customerId, CustomerUpdateModel updateCustomer);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <param name="updateCustomer"></param>
        /// <returns>ApiResponse of RestApiResultCustomer</returns>
        ApiResponse<RestApiResultCustomer> UpdateCustomerByIdWithHttpInfo (string appId, int? customerId, CustomerUpdateModel updateCustomer);
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
        /// <param name="customerId"></param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> CustomersGetOptOutMarketingLinkAsync (string appId, int? customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CustomersGetOptOutMarketingLinkAsyncWithHttpInfo (string appId, int? customerId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>Task of RestApiResultCustomer</returns>
        System.Threading.Tasks.Task<RestApiResultCustomer> GetCustomerByIdAsync (string appId, int? customerId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (RestApiResultCustomer)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultCustomer>> GetCustomerByIdAsyncWithHttpInfo (string appId, int? customerId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <param name="updateCustomer"></param>
        /// <returns>Task of RestApiResultCustomer</returns>
        System.Threading.Tasks.Task<RestApiResultCustomer> UpdateCustomerByIdAsync (string appId, int? customerId, CustomerUpdateModel updateCustomer);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <param name="updateCustomer"></param>
        /// <returns>Task of ApiResponse (RestApiResultCustomer)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultCustomer>> UpdateCustomerByIdAsyncWithHttpInfo (string appId, int? customerId, CustomerUpdateModel updateCustomer);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CustomersApi : ICustomersApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomersApi(String basePath)
        {
            this.Configuration = new Flipdish.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomersApi(Flipdish.Client.Configuration configuration = null)
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
        /// <param name="customerId"></param>
        /// <returns>Object</returns>
        public Object CustomersGetOptOutMarketingLink (string appId, int? customerId)
        {
             ApiResponse<Object> localVarResponse = CustomersGetOptOutMarketingLinkWithHttpInfo(appId, customerId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > CustomersGetOptOutMarketingLinkWithHttpInfo (string appId, int? customerId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling CustomersApi->CustomersGetOptOutMarketingLink");
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersApi->CustomersGetOptOutMarketingLink");

            var localVarPath = "./api/v1.0/{appId}/customers/{customerId}/opt-out-link";
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
            if (customerId != null) localVarPathParams.Add("customerId", this.Configuration.ApiClient.ParameterToString(customerId)); // path parameter

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
                Exception exception = ExceptionFactory("CustomersGetOptOutMarketingLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> CustomersGetOptOutMarketingLinkAsync (string appId, int? customerId)
        {
             ApiResponse<Object> localVarResponse = await CustomersGetOptOutMarketingLinkAsyncWithHttpInfo(appId, customerId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CustomersGetOptOutMarketingLinkAsyncWithHttpInfo (string appId, int? customerId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling CustomersApi->CustomersGetOptOutMarketingLink");
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersApi->CustomersGetOptOutMarketingLink");

            var localVarPath = "./api/v1.0/{appId}/customers/{customerId}/opt-out-link";
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
            if (customerId != null) localVarPathParams.Add("customerId", this.Configuration.ApiClient.ParameterToString(customerId)); // path parameter

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
                Exception exception = ExceptionFactory("CustomersGetOptOutMarketingLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>RestApiResultCustomer</returns>
        public RestApiResultCustomer GetCustomerById (string appId, int? customerId)
        {
             ApiResponse<RestApiResultCustomer> localVarResponse = GetCustomerByIdWithHttpInfo(appId, customerId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>ApiResponse of RestApiResultCustomer</returns>
        public ApiResponse< RestApiResultCustomer > GetCustomerByIdWithHttpInfo (string appId, int? customerId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling CustomersApi->GetCustomerById");
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersApi->GetCustomerById");

            var localVarPath = "./api/v1.0/{appId}/customers/{customerId}";
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
            if (customerId != null) localVarPathParams.Add("customerId", this.Configuration.ApiClient.ParameterToString(customerId)); // path parameter

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
                Exception exception = ExceptionFactory("GetCustomerById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultCustomer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultCustomer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultCustomer)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>Task of RestApiResultCustomer</returns>
        public async System.Threading.Tasks.Task<RestApiResultCustomer> GetCustomerByIdAsync (string appId, int? customerId)
        {
             ApiResponse<RestApiResultCustomer> localVarResponse = await GetCustomerByIdAsyncWithHttpInfo(appId, customerId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <returns>Task of ApiResponse (RestApiResultCustomer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultCustomer>> GetCustomerByIdAsyncWithHttpInfo (string appId, int? customerId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling CustomersApi->GetCustomerById");
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersApi->GetCustomerById");

            var localVarPath = "./api/v1.0/{appId}/customers/{customerId}";
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
            if (customerId != null) localVarPathParams.Add("customerId", this.Configuration.ApiClient.ParameterToString(customerId)); // path parameter

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
                Exception exception = ExceptionFactory("GetCustomerById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultCustomer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultCustomer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultCustomer)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <param name="updateCustomer"></param>
        /// <returns>RestApiResultCustomer</returns>
        public RestApiResultCustomer UpdateCustomerById (string appId, int? customerId, CustomerUpdateModel updateCustomer)
        {
             ApiResponse<RestApiResultCustomer> localVarResponse = UpdateCustomerByIdWithHttpInfo(appId, customerId, updateCustomer);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <param name="updateCustomer"></param>
        /// <returns>ApiResponse of RestApiResultCustomer</returns>
        public ApiResponse< RestApiResultCustomer > UpdateCustomerByIdWithHttpInfo (string appId, int? customerId, CustomerUpdateModel updateCustomer)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling CustomersApi->UpdateCustomerById");
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersApi->UpdateCustomerById");
            // verify the required parameter 'updateCustomer' is set
            if (updateCustomer == null)
                throw new ApiException(400, "Missing required parameter 'updateCustomer' when calling CustomersApi->UpdateCustomerById");

            var localVarPath = "./api/v1.0/{appId}/customers/{customerId}";
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
            if (customerId != null) localVarPathParams.Add("customerId", this.Configuration.ApiClient.ParameterToString(customerId)); // path parameter
            if (updateCustomer != null && updateCustomer.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(updateCustomer); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateCustomer; // byte array
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
                Exception exception = ExceptionFactory("UpdateCustomerById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultCustomer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultCustomer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultCustomer)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <param name="updateCustomer"></param>
        /// <returns>Task of RestApiResultCustomer</returns>
        public async System.Threading.Tasks.Task<RestApiResultCustomer> UpdateCustomerByIdAsync (string appId, int? customerId, CustomerUpdateModel updateCustomer)
        {
             ApiResponse<RestApiResultCustomer> localVarResponse = await UpdateCustomerByIdAsyncWithHttpInfo(appId, customerId, updateCustomer);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="customerId"></param>
        /// <param name="updateCustomer"></param>
        /// <returns>Task of ApiResponse (RestApiResultCustomer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultCustomer>> UpdateCustomerByIdAsyncWithHttpInfo (string appId, int? customerId, CustomerUpdateModel updateCustomer)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling CustomersApi->UpdateCustomerById");
            // verify the required parameter 'customerId' is set
            if (customerId == null)
                throw new ApiException(400, "Missing required parameter 'customerId' when calling CustomersApi->UpdateCustomerById");
            // verify the required parameter 'updateCustomer' is set
            if (updateCustomer == null)
                throw new ApiException(400, "Missing required parameter 'updateCustomer' when calling CustomersApi->UpdateCustomerById");

            var localVarPath = "./api/v1.0/{appId}/customers/{customerId}";
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
            if (customerId != null) localVarPathParams.Add("customerId", this.Configuration.ApiClient.ParameterToString(customerId)); // path parameter
            if (updateCustomer != null && updateCustomer.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(updateCustomer); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateCustomer; // byte array
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
                Exception exception = ExceptionFactory("UpdateCustomerById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultCustomer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiResultCustomer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultCustomer)));
        }

    }
}
