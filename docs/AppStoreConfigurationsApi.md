# Flipdish.Api.AppStoreConfigurationsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppStoreConfigurationsAppStoreHandleOauthResponseCode**](AppStoreConfigurationsApi.md#appstoreconfigurationsappstorehandleoauthresponsecode) | **GET** /api/v1.0/appstore/oauthresponse/{appStoreAppId}/responsecode | 
[**CreateAppStoreConfig**](AppStoreConfigurationsApi.md#createappstoreconfig) | **POST** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config | 
[**DeleteAppStoreConfig**](AppStoreConfigurationsApi.md#deleteappstoreconfig) | **DELETE** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId} | 
[**ExecuteConfigurationAction**](AppStoreConfigurationsApi.md#executeconfigurationaction) | **POST** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId}/action | 
[**GetAppStoreConfig**](AppStoreConfigurationsApi.md#getappstoreconfig) | **GET** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId} | 
[**GetConfiguredAppSingleApp**](AppStoreConfigurationsApi.md#getconfiguredappsingleapp) | **GET** /api/v1.0/{appId}/appstore/apps/{appStoreAppId} | 
[**GetConfiguredApps**](AppStoreConfigurationsApi.md#getconfiguredapps) | **GET** /api/v1.0/{appId}/appstore/apps | 
[**UpdateAppStoreConfig**](AppStoreConfigurationsApi.md#updateappstoreconfig) | **PUT** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId} | 
[**UpdateAppStoreConfigSettingValues**](AppStoreConfigurationsApi.md#updateappstoreconfigsettingvalues) | **POST** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId}/updatesettings | 


<a name="appstoreconfigurationsappstorehandleoauthresponsecode"></a>
# **AppStoreConfigurationsAppStoreHandleOauthResponseCode**
> Object AppStoreConfigurationsAppStoreHandleOauthResponseCode (string appStoreAppId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AppStoreConfigurationsAppStoreHandleOauthResponseCodeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appStoreAppId = appStoreAppId_example;  // string | 

            try
            {
                Object result = apiInstance.AppStoreConfigurationsAppStoreHandleOauthResponseCode(appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.AppStoreConfigurationsAppStoreHandleOauthResponseCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appStoreAppId** | **string**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createappstoreconfig"></a>
# **CreateAppStoreConfig**
> RestApiResultAppStoreAppConfiguration CreateAppStoreConfig (string appId, string appStoreAppId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateAppStoreConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 

            try
            {
                RestApiResultAppStoreAppConfiguration result = apiInstance.CreateAppStoreConfig(appId, appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.CreateAppStoreConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 

### Return type

[**RestApiResultAppStoreAppConfiguration**](RestApiResultAppStoreAppConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteappstoreconfig"></a>
# **DeleteAppStoreConfig**
> RestApiStringResult DeleteAppStoreConfig (string appId, string appStoreAppId, string configId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteAppStoreConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var configId = configId_example;  // string | 

            try
            {
                RestApiStringResult result = apiInstance.DeleteAppStoreConfig(appId, appStoreAppId, configId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.DeleteAppStoreConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **configId** | **string**|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executeconfigurationaction"></a>
# **ExecuteConfigurationAction**
> ExecuteConfigurationActionResult ExecuteConfigurationAction (string appId, string appStoreAppId, string configId, ExecuteConfigurationActionRequest executeConfigurationActionRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ExecuteConfigurationActionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var configId = configId_example;  // string | 
            var executeConfigurationActionRequest = new ExecuteConfigurationActionRequest(); // ExecuteConfigurationActionRequest | 

            try
            {
                ExecuteConfigurationActionResult result = apiInstance.ExecuteConfigurationAction(appId, appStoreAppId, configId, executeConfigurationActionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.ExecuteConfigurationAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **configId** | **string**|  | 
 **executeConfigurationActionRequest** | [**ExecuteConfigurationActionRequest**](ExecuteConfigurationActionRequest.md)|  | 

### Return type

[**ExecuteConfigurationActionResult**](ExecuteConfigurationActionResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappstoreconfig"></a>
# **GetAppStoreConfig**
> AppStoreAppConfiguration GetAppStoreConfig (string appId, string appStoreAppId, string configId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppStoreConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var configId = configId_example;  // string | 

            try
            {
                AppStoreAppConfiguration result = apiInstance.GetAppStoreConfig(appId, appStoreAppId, configId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.GetAppStoreConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **configId** | **string**|  | 

### Return type

[**AppStoreAppConfiguration**](AppStoreAppConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfiguredappsingleapp"></a>
# **GetConfiguredAppSingleApp**
> RestApiArrayResultAppStoreAppConfigurationSummary GetConfiguredAppSingleApp (string appId, string appStoreAppId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetConfiguredAppSingleAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 

            try
            {
                RestApiArrayResultAppStoreAppConfigurationSummary result = apiInstance.GetConfiguredAppSingleApp(appId, appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.GetConfiguredAppSingleApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 

### Return type

[**RestApiArrayResultAppStoreAppConfigurationSummary**](RestApiArrayResultAppStoreAppConfigurationSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfiguredapps"></a>
# **GetConfiguredApps**
> RestApiArrayResultAppStoreAppConfigurationHeader GetConfiguredApps (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetConfiguredAppsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultAppStoreAppConfigurationHeader result = apiInstance.GetConfiguredApps(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.GetConfiguredApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

[**RestApiArrayResultAppStoreAppConfigurationHeader**](RestApiArrayResultAppStoreAppConfigurationHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappstoreconfig"></a>
# **UpdateAppStoreConfig**
> void UpdateAppStoreConfig (string appId, string appStoreAppId, string configId, UpdateAppStoreAppConfiguration updateAppStoreAppConfiguration)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateAppStoreConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var configId = configId_example;  // string | 
            var updateAppStoreAppConfiguration = new UpdateAppStoreAppConfiguration(); // UpdateAppStoreAppConfiguration | 

            try
            {
                apiInstance.UpdateAppStoreConfig(appId, appStoreAppId, configId, updateAppStoreAppConfiguration);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.UpdateAppStoreConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **configId** | **string**|  | 
 **updateAppStoreAppConfiguration** | [**UpdateAppStoreAppConfiguration**](UpdateAppStoreAppConfiguration.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappstoreconfigsettingvalues"></a>
# **UpdateAppStoreConfigSettingValues**
> void UpdateAppStoreConfigSettingValues (string appId, string appStoreAppId, string configId, UpdateAppStoreAppConfigurationValuesBatch updateAppStoreAppConfigurationValues)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateAppStoreConfigSettingValuesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreConfigurationsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var configId = configId_example;  // string | 
            var updateAppStoreAppConfigurationValues = new UpdateAppStoreAppConfigurationValuesBatch(); // UpdateAppStoreAppConfigurationValuesBatch | 

            try
            {
                apiInstance.UpdateAppStoreConfigSettingValues(appId, appStoreAppId, configId, updateAppStoreAppConfigurationValues);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreConfigurationsApi.UpdateAppStoreConfigSettingValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **configId** | **string**|  | 
 **updateAppStoreAppConfigurationValues** | [**UpdateAppStoreAppConfigurationValuesBatch**](UpdateAppStoreAppConfigurationValuesBatch.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

