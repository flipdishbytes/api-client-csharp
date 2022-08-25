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
    public interface IKioskStoreSettingsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get all kiosk settings associated with a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <param name="appId">App Name Id</param>
        /// <returns>RestApiResultStoreKioskSettings</returns>
        RestApiResultStoreKioskSettings GetAllKioskSettingsForStore (int? storeId, string appId);

        /// <summary>
        /// Get all kiosk settings associated with a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <param name="appId">App Name Id</param>
        /// <returns>ApiResponse of RestApiResultStoreKioskSettings</returns>
        ApiResponse<RestApiResultStoreKioskSettings> GetAllKioskSettingsForStoreWithHttpInfo (int? storeId, string appId);
        /// <summary>
        /// [For Kiosk use only] Get all stores connected to a Kiosk
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>RestApiResultKioskStoreSettings</returns>
        RestApiResultKioskStoreSettings GetAllStoreSettingsForKioskHydra ();

        /// <summary>
        /// [For Kiosk use only] Get all stores connected to a Kiosk
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of RestApiResultKioskStoreSettings</returns>
        ApiResponse<RestApiResultKioskStoreSettings> GetAllStoreSettingsForKioskHydraWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="deviceId"></param>
        /// <param name="isCashEnabled"></param>
        /// <returns>RestApiResultKioskCashSetting</returns>
        RestApiResultKioskCashSetting UpdateCashSettingForKiosk (string appId, string deviceId, bool? isCashEnabled);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="deviceId"></param>
        /// <param name="isCashEnabled"></param>
        /// <returns>ApiResponse of RestApiResultKioskCashSetting</returns>
        ApiResponse<RestApiResultKioskCashSetting> UpdateCashSettingForKioskWithHttpInfo (string appId, string deviceId, bool? isCashEnabled);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get all kiosk settings associated with a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <param name="appId">App Name Id</param>
        /// <returns>Task of RestApiResultStoreKioskSettings</returns>
        System.Threading.Tasks.Task<RestApiResultStoreKioskSettings> GetAllKioskSettingsForStoreAsync (int? storeId, string appId);

        /// <summary>
        /// Get all kiosk settings associated with a store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <param name="appId">App Name Id</param>
        /// <returns>Task of ApiResponse (RestApiResultStoreKioskSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultStoreKioskSettings>> GetAllKioskSettingsForStoreAsyncWithHttpInfo (int? storeId, string appId);
        /// <summary>
        /// [For Kiosk use only] Get all stores connected to a Kiosk
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of RestApiResultKioskStoreSettings</returns>
        System.Threading.Tasks.Task<RestApiResultKioskStoreSettings> GetAllStoreSettingsForKioskHydraAsync ();

        /// <summary>
        /// [For Kiosk use only] Get all stores connected to a Kiosk
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (RestApiResultKioskStoreSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultKioskStoreSettings>> GetAllStoreSettingsForKioskHydraAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="deviceId"></param>
        /// <param name="isCashEnabled"></param>
        /// <returns>Task of RestApiResultKioskCashSetting</returns>
        System.Threading.Tasks.Task<RestApiResultKioskCashSetting> UpdateCashSettingForKioskAsync (string appId, string deviceId, bool? isCashEnabled);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="deviceId"></param>
        /// <param name="isCashEnabled"></param>
        /// <returns>Task of ApiResponse (RestApiResultKioskCashSetting)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiResultKioskCashSetting>> UpdateCashSettingForKioskAsyncWithHttpInfo (string appId, string deviceId, bool? isCashEnabled);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class KioskStoreSettingsApi : IKioskStoreSettingsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="KioskStoreSettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KioskStoreSettingsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KioskStoreSettingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public KioskStoreSettingsApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// Get all kiosk settings associated with a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <param name="appId">App Name Id</param>
        /// <returns>RestApiResultStoreKioskSettings</returns>
        public RestApiResultStoreKioskSettings GetAllKioskSettingsForStore (int? storeId, string appId)
        {
             ApiResponse<RestApiResultStoreKioskSettings> localVarResponse = GetAllKioskSettingsForStoreWithHttpInfo(storeId, appId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all kiosk settings associated with a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <param name="appId">App Name Id</param>
        /// <returns>ApiResponse of RestApiResultStoreKioskSettings</returns>
        public ApiResponse< RestApiResultStoreKioskSettings > GetAllKioskSettingsForStoreWithHttpInfo (int? storeId, string appId)
        {
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling KioskStoreSettingsApi->GetAllKioskSettingsForStore");
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling KioskStoreSettingsApi->GetAllKioskSettingsForStore");

            var localVarPath = "/api/v1.0/{appId}/kiosksettings/store/{storeId}";
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

            if (storeId != null) localVarPathParams.Add("storeId", this.Configuration.ApiClient.ParameterToString(storeId)); // path parameter
            if (appId != null) localVarPathParams.Add("appId", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter

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
                Exception exception = ExceptionFactory("GetAllKioskSettingsForStore", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultStoreKioskSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultStoreKioskSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultStoreKioskSettings)));
        }

        /// <summary>
        /// Get all kiosk settings associated with a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <param name="appId">App Name Id</param>
        /// <returns>Task of RestApiResultStoreKioskSettings</returns>
        public async System.Threading.Tasks.Task<RestApiResultStoreKioskSettings> GetAllKioskSettingsForStoreAsync (int? storeId, string appId)
        {
             ApiResponse<RestApiResultStoreKioskSettings> localVarResponse = await GetAllKioskSettingsForStoreAsyncWithHttpInfo(storeId, appId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all kiosk settings associated with a store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storeId">Store identifier</param>
        /// <param name="appId">App Name Id</param>
        /// <returns>Task of ApiResponse (RestApiResultStoreKioskSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultStoreKioskSettings>> GetAllKioskSettingsForStoreAsyncWithHttpInfo (int? storeId, string appId)
        {
            // verify the required parameter 'storeId' is set
            if (storeId == null)
                throw new ApiException(400, "Missing required parameter 'storeId' when calling KioskStoreSettingsApi->GetAllKioskSettingsForStore");
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling KioskStoreSettingsApi->GetAllKioskSettingsForStore");

            var localVarPath = "/api/v1.0/{appId}/kiosksettings/store/{storeId}";
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

            if (storeId != null) localVarPathParams.Add("storeId", this.Configuration.ApiClient.ParameterToString(storeId)); // path parameter
            if (appId != null) localVarPathParams.Add("appId", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter

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
                Exception exception = ExceptionFactory("GetAllKioskSettingsForStore", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultStoreKioskSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultStoreKioskSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultStoreKioskSettings)));
        }

        /// <summary>
        /// [For Kiosk use only] Get all stores connected to a Kiosk 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>RestApiResultKioskStoreSettings</returns>
        public RestApiResultKioskStoreSettings GetAllStoreSettingsForKioskHydra ()
        {
             ApiResponse<RestApiResultKioskStoreSettings> localVarResponse = GetAllStoreSettingsForKioskHydraWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// [For Kiosk use only] Get all stores connected to a Kiosk 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of RestApiResultKioskStoreSettings</returns>
        public ApiResponse< RestApiResultKioskStoreSettings > GetAllStoreSettingsForKioskHydraWithHttpInfo ()
        {

            var localVarPath = "/api/v1.0/kioskstoresettings";
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
                Exception exception = ExceptionFactory("GetAllStoreSettingsForKioskHydra", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultKioskStoreSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultKioskStoreSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultKioskStoreSettings)));
        }

        /// <summary>
        /// [For Kiosk use only] Get all stores connected to a Kiosk 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of RestApiResultKioskStoreSettings</returns>
        public async System.Threading.Tasks.Task<RestApiResultKioskStoreSettings> GetAllStoreSettingsForKioskHydraAsync ()
        {
             ApiResponse<RestApiResultKioskStoreSettings> localVarResponse = await GetAllStoreSettingsForKioskHydraAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// [For Kiosk use only] Get all stores connected to a Kiosk 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (RestApiResultKioskStoreSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultKioskStoreSettings>> GetAllStoreSettingsForKioskHydraAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1.0/kioskstoresettings";
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
                Exception exception = ExceptionFactory("GetAllStoreSettingsForKioskHydra", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultKioskStoreSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultKioskStoreSettings) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultKioskStoreSettings)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="deviceId"></param>
        /// <param name="isCashEnabled"></param>
        /// <returns>RestApiResultKioskCashSetting</returns>
        public RestApiResultKioskCashSetting UpdateCashSettingForKiosk (string appId, string deviceId, bool? isCashEnabled)
        {
             ApiResponse<RestApiResultKioskCashSetting> localVarResponse = UpdateCashSettingForKioskWithHttpInfo(appId, deviceId, isCashEnabled);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="deviceId"></param>
        /// <param name="isCashEnabled"></param>
        /// <returns>ApiResponse of RestApiResultKioskCashSetting</returns>
        public ApiResponse< RestApiResultKioskCashSetting > UpdateCashSettingForKioskWithHttpInfo (string appId, string deviceId, bool? isCashEnabled)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling KioskStoreSettingsApi->UpdateCashSettingForKiosk");
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling KioskStoreSettingsApi->UpdateCashSettingForKiosk");
            // verify the required parameter 'isCashEnabled' is set
            if (isCashEnabled == null)
                throw new ApiException(400, "Missing required parameter 'isCashEnabled' when calling KioskStoreSettingsApi->UpdateCashSettingForKiosk");

            var localVarPath = "/api/v1.0/{appId}/kiosksettings/cash";
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
            if (deviceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "deviceId", deviceId)); // query parameter
            if (isCashEnabled != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "isCashEnabled", isCashEnabled)); // query parameter

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
                Exception exception = ExceptionFactory("UpdateCashSettingForKiosk", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultKioskCashSetting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultKioskCashSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultKioskCashSetting)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="deviceId"></param>
        /// <param name="isCashEnabled"></param>
        /// <returns>Task of RestApiResultKioskCashSetting</returns>
        public async System.Threading.Tasks.Task<RestApiResultKioskCashSetting> UpdateCashSettingForKioskAsync (string appId, string deviceId, bool? isCashEnabled)
        {
             ApiResponse<RestApiResultKioskCashSetting> localVarResponse = await UpdateCashSettingForKioskAsyncWithHttpInfo(appId, deviceId, isCashEnabled);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId"></param>
        /// <param name="deviceId"></param>
        /// <param name="isCashEnabled"></param>
        /// <returns>Task of ApiResponse (RestApiResultKioskCashSetting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiResultKioskCashSetting>> UpdateCashSettingForKioskAsyncWithHttpInfo (string appId, string deviceId, bool? isCashEnabled)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling KioskStoreSettingsApi->UpdateCashSettingForKiosk");
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling KioskStoreSettingsApi->UpdateCashSettingForKiosk");
            // verify the required parameter 'isCashEnabled' is set
            if (isCashEnabled == null)
                throw new ApiException(400, "Missing required parameter 'isCashEnabled' when calling KioskStoreSettingsApi->UpdateCashSettingForKiosk");

            var localVarPath = "/api/v1.0/{appId}/kiosksettings/cash";
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
            if (deviceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "deviceId", deviceId)); // query parameter
            if (isCashEnabled != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "isCashEnabled", isCashEnabled)); // query parameter

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
                Exception exception = ExceptionFactory("UpdateCashSettingForKiosk", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiResultKioskCashSetting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiResultKioskCashSetting) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiResultKioskCashSetting)));
        }

    }
}
