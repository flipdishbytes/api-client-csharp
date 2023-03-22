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
    public interface IInvoicesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get list of invoices
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id (optional) (optional)</param>
        /// <param name="limit">Limit of invoices to return (optional) (optional)</param>
        /// <param name="pageId">Id for use in pagination. Use the next_page value returned in a previous response to request subsequent results. Do not include this on the first call (optional) (optional)</param>
        /// <param name="excludeNotOwnedInvoices">Exclude not owned invoices. Set to true to only view your invoices (optional) (optional)</param>
        /// <param name="dateFrom">Filter starting from this date (optional) (optional)</param>
        /// <param name="dateTo">Filter ending from this date (optional) (optional)</param>
        /// <param name="invoiceNumber">Invoice number (optional) (optional)</param>
        /// <returns>RestApiFinanceSearchPaginationResultInvoice</returns>
        RestApiFinanceSearchPaginationResultInvoice GetInvoices (string appId, string subscriptionId = null, int? limit = null, string pageId = null, bool? excludeNotOwnedInvoices = null, DateTime? dateFrom = null, DateTime? dateTo = null, string invoiceNumber = null);

        /// <summary>
        /// Get list of invoices
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id (optional) (optional)</param>
        /// <param name="limit">Limit of invoices to return (optional) (optional)</param>
        /// <param name="pageId">Id for use in pagination. Use the next_page value returned in a previous response to request subsequent results. Do not include this on the first call (optional) (optional)</param>
        /// <param name="excludeNotOwnedInvoices">Exclude not owned invoices. Set to true to only view your invoices (optional) (optional)</param>
        /// <param name="dateFrom">Filter starting from this date (optional) (optional)</param>
        /// <param name="dateTo">Filter ending from this date (optional) (optional)</param>
        /// <param name="invoiceNumber">Invoice number (optional) (optional)</param>
        /// <returns>ApiResponse of RestApiFinanceSearchPaginationResultInvoice</returns>
        ApiResponse<RestApiFinanceSearchPaginationResultInvoice> GetInvoicesWithHttpInfo (string appId, string subscriptionId = null, int? limit = null, string pageId = null, bool? excludeNotOwnedInvoices = null, DateTime? dateFrom = null, DateTime? dateTo = null, string invoiceNumber = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get list of invoices
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id (optional) (optional)</param>
        /// <param name="limit">Limit of invoices to return (optional) (optional)</param>
        /// <param name="pageId">Id for use in pagination. Use the next_page value returned in a previous response to request subsequent results. Do not include this on the first call (optional) (optional)</param>
        /// <param name="excludeNotOwnedInvoices">Exclude not owned invoices. Set to true to only view your invoices (optional) (optional)</param>
        /// <param name="dateFrom">Filter starting from this date (optional) (optional)</param>
        /// <param name="dateTo">Filter ending from this date (optional) (optional)</param>
        /// <param name="invoiceNumber">Invoice number (optional) (optional)</param>
        /// <returns>Task of RestApiFinanceSearchPaginationResultInvoice</returns>
        System.Threading.Tasks.Task<RestApiFinanceSearchPaginationResultInvoice> GetInvoicesAsync (string appId, string subscriptionId = null, int? limit = null, string pageId = null, bool? excludeNotOwnedInvoices = null, DateTime? dateFrom = null, DateTime? dateTo = null, string invoiceNumber = null);

        /// <summary>
        /// Get list of invoices
        /// </summary>
        /// <remarks>
        /// [BETA - this endpoint is under development, do not use it in your production system]
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id (optional) (optional)</param>
        /// <param name="limit">Limit of invoices to return (optional) (optional)</param>
        /// <param name="pageId">Id for use in pagination. Use the next_page value returned in a previous response to request subsequent results. Do not include this on the first call (optional) (optional)</param>
        /// <param name="excludeNotOwnedInvoices">Exclude not owned invoices. Set to true to only view your invoices (optional) (optional)</param>
        /// <param name="dateFrom">Filter starting from this date (optional) (optional)</param>
        /// <param name="dateTo">Filter ending from this date (optional) (optional)</param>
        /// <param name="invoiceNumber">Invoice number (optional) (optional)</param>
        /// <returns>Task of ApiResponse (RestApiFinanceSearchPaginationResultInvoice)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiFinanceSearchPaginationResultInvoice>> GetInvoicesAsyncWithHttpInfo (string appId, string subscriptionId = null, int? limit = null, string pageId = null, bool? excludeNotOwnedInvoices = null, DateTime? dateFrom = null, DateTime? dateTo = null, string invoiceNumber = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InvoicesApi : IInvoicesApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoicesApi(String basePath)
        {
            this.Configuration = new Flipdish.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InvoicesApi(Flipdish.Client.Configuration configuration = null)
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
        /// Get list of invoices [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id (optional) (optional)</param>
        /// <param name="limit">Limit of invoices to return (optional) (optional)</param>
        /// <param name="pageId">Id for use in pagination. Use the next_page value returned in a previous response to request subsequent results. Do not include this on the first call (optional) (optional)</param>
        /// <param name="excludeNotOwnedInvoices">Exclude not owned invoices. Set to true to only view your invoices (optional) (optional)</param>
        /// <param name="dateFrom">Filter starting from this date (optional) (optional)</param>
        /// <param name="dateTo">Filter ending from this date (optional) (optional)</param>
        /// <param name="invoiceNumber">Invoice number (optional) (optional)</param>
        /// <returns>RestApiFinanceSearchPaginationResultInvoice</returns>
        public RestApiFinanceSearchPaginationResultInvoice GetInvoices (string appId, string subscriptionId = null, int? limit = null, string pageId = null, bool? excludeNotOwnedInvoices = null, DateTime? dateFrom = null, DateTime? dateTo = null, string invoiceNumber = null)
        {
             ApiResponse<RestApiFinanceSearchPaginationResultInvoice> localVarResponse = GetInvoicesWithHttpInfo(appId, subscriptionId, limit, pageId, excludeNotOwnedInvoices, dateFrom, dateTo, invoiceNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of invoices [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id (optional) (optional)</param>
        /// <param name="limit">Limit of invoices to return (optional) (optional)</param>
        /// <param name="pageId">Id for use in pagination. Use the next_page value returned in a previous response to request subsequent results. Do not include this on the first call (optional) (optional)</param>
        /// <param name="excludeNotOwnedInvoices">Exclude not owned invoices. Set to true to only view your invoices (optional) (optional)</param>
        /// <param name="dateFrom">Filter starting from this date (optional) (optional)</param>
        /// <param name="dateTo">Filter ending from this date (optional) (optional)</param>
        /// <param name="invoiceNumber">Invoice number (optional) (optional)</param>
        /// <returns>ApiResponse of RestApiFinanceSearchPaginationResultInvoice</returns>
        public ApiResponse< RestApiFinanceSearchPaginationResultInvoice > GetInvoicesWithHttpInfo (string appId, string subscriptionId = null, int? limit = null, string pageId = null, bool? excludeNotOwnedInvoices = null, DateTime? dateFrom = null, DateTime? dateTo = null, string invoiceNumber = null)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling InvoicesApi->GetInvoices");

            var localVarPath = "./api/v1.0/{appId}/invoices";
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
            if (subscriptionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "subscriptionId", subscriptionId)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (pageId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pageId", pageId)); // query parameter
            if (excludeNotOwnedInvoices != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "excludeNotOwnedInvoices", excludeNotOwnedInvoices)); // query parameter
            if (dateFrom != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "dateFrom", dateFrom)); // query parameter
            if (dateTo != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "dateTo", dateTo)); // query parameter
            if (invoiceNumber != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "invoiceNumber", invoiceNumber)); // query parameter

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
                Exception exception = ExceptionFactory("GetInvoices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiFinanceSearchPaginationResultInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiFinanceSearchPaginationResultInvoice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiFinanceSearchPaginationResultInvoice)));
        }

        /// <summary>
        /// Get list of invoices [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id (optional) (optional)</param>
        /// <param name="limit">Limit of invoices to return (optional) (optional)</param>
        /// <param name="pageId">Id for use in pagination. Use the next_page value returned in a previous response to request subsequent results. Do not include this on the first call (optional) (optional)</param>
        /// <param name="excludeNotOwnedInvoices">Exclude not owned invoices. Set to true to only view your invoices (optional) (optional)</param>
        /// <param name="dateFrom">Filter starting from this date (optional) (optional)</param>
        /// <param name="dateTo">Filter ending from this date (optional) (optional)</param>
        /// <param name="invoiceNumber">Invoice number (optional) (optional)</param>
        /// <returns>Task of RestApiFinanceSearchPaginationResultInvoice</returns>
        public async System.Threading.Tasks.Task<RestApiFinanceSearchPaginationResultInvoice> GetInvoicesAsync (string appId, string subscriptionId = null, int? limit = null, string pageId = null, bool? excludeNotOwnedInvoices = null, DateTime? dateFrom = null, DateTime? dateTo = null, string invoiceNumber = null)
        {
             ApiResponse<RestApiFinanceSearchPaginationResultInvoice> localVarResponse = await GetInvoicesAsyncWithHttpInfo(appId, subscriptionId, limit, pageId, excludeNotOwnedInvoices, dateFrom, dateTo, invoiceNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of invoices [BETA - this endpoint is under development, do not use it in your production system]
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">App Id</param>
        /// <param name="subscriptionId">Subscription Id (optional) (optional)</param>
        /// <param name="limit">Limit of invoices to return (optional) (optional)</param>
        /// <param name="pageId">Id for use in pagination. Use the next_page value returned in a previous response to request subsequent results. Do not include this on the first call (optional) (optional)</param>
        /// <param name="excludeNotOwnedInvoices">Exclude not owned invoices. Set to true to only view your invoices (optional) (optional)</param>
        /// <param name="dateFrom">Filter starting from this date (optional) (optional)</param>
        /// <param name="dateTo">Filter ending from this date (optional) (optional)</param>
        /// <param name="invoiceNumber">Invoice number (optional) (optional)</param>
        /// <returns>Task of ApiResponse (RestApiFinanceSearchPaginationResultInvoice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiFinanceSearchPaginationResultInvoice>> GetInvoicesAsyncWithHttpInfo (string appId, string subscriptionId = null, int? limit = null, string pageId = null, bool? excludeNotOwnedInvoices = null, DateTime? dateFrom = null, DateTime? dateTo = null, string invoiceNumber = null)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling InvoicesApi->GetInvoices");

            var localVarPath = "./api/v1.0/{appId}/invoices";
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
            if (subscriptionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "subscriptionId", subscriptionId)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (pageId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pageId", pageId)); // query parameter
            if (excludeNotOwnedInvoices != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "excludeNotOwnedInvoices", excludeNotOwnedInvoices)); // query parameter
            if (dateFrom != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "dateFrom", dateFrom)); // query parameter
            if (dateTo != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "dateTo", dateTo)); // query parameter
            if (invoiceNumber != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "invoiceNumber", invoiceNumber)); // query parameter

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
                Exception exception = ExceptionFactory("GetInvoices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiFinanceSearchPaginationResultInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (RestApiFinanceSearchPaginationResultInvoice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiFinanceSearchPaginationResultInvoice)));
        }

    }
}
