# Flipdish.Api.AppStoreConfigurationsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAppStoreConfig**](AppStoreConfigurationsApi.md#createappstoreconfig) | **POST** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config | Create app store app configuration
[**DeleteAppStoreConfig**](AppStoreConfigurationsApi.md#deleteappstoreconfig) | **DELETE** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId} | Delete app store app configuration
[**GetAppStoreConfig**](AppStoreConfigurationsApi.md#getappstoreconfig) | **GET** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId} | Get app store app configuration
[**GetConfiguredAppSingleApp**](AppStoreConfigurationsApi.md#getconfiguredappsingleapp) | **GET** /api/v1.0/{appId}/appstore/apps/{appStoreAppId} | Get list of app store app configurations for one app store app
[**GetConfiguredApps**](AppStoreConfigurationsApi.md#getconfiguredapps) | **GET** /api/v1.0/{appId}/appstore/apps | Get list of app store apps which have been configured
[**UpdateAppStoreConfig**](AppStoreConfigurationsApi.md#updateappstoreconfig) | **PUT** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/config/{configId} | Update app store app configuration


<a name="createappstoreconfig"></a>
# **CreateAppStoreConfig**
> RestApiResultAppConfigurationSummary CreateAppStoreConfig (string appId, string appStoreAppId)

Create app store app configuration

[BETA - this endpoint is under development, do not use it in your production system] This adds an Application to a Whitelabel that can later be configured to specific stores

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
            var appId = appId_example;  // string | App Id
            var appStoreAppId = appStoreAppId_example;  // string | App Store App Id

            try
            {
                // Create app store app configuration
                RestApiResultAppConfigurationSummary result = apiInstance.CreateAppStoreConfig(appId, appStoreAppId);
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
 **appId** | **string**| App Id | 
 **appStoreAppId** | **string**| App Store App Id | 

### Return type

[**RestApiResultAppConfigurationSummary**](RestApiResultAppConfigurationSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteappstoreconfig"></a>
# **DeleteAppStoreConfig**
> RestApiStringResult DeleteAppStoreConfig (string appId, string appStoreAppId, string configId)

Delete app store app configuration

[BETA - this endpoint is under development, do not use it in your production system]

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
            var appId = appId_example;  // string | App Id
            var appStoreAppId = appStoreAppId_example;  // string | App Store App Id
            var configId = configId_example;  // string | App Store Configuration Id

            try
            {
                // Delete app store app configuration
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
 **appId** | **string**| App Id | 
 **appStoreAppId** | **string**| App Store App Id | 
 **configId** | **string**| App Store Configuration Id | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappstoreconfig"></a>
# **GetAppStoreConfig**
> AppConfigurationDetail GetAppStoreConfig (string appId, string appStoreAppId, string configId)

Get app store app configuration

[BETA - this endpoint is under development, do not use it in your production system]

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
            var appId = appId_example;  // string | App Id
            var appStoreAppId = appStoreAppId_example;  // string | App Store App Id
            var configId = configId_example;  // string | App Store Configuration Id

            try
            {
                // Get app store app configuration
                AppConfigurationDetail result = apiInstance.GetAppStoreConfig(appId, appStoreAppId, configId);
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
 **appId** | **string**| App Id | 
 **appStoreAppId** | **string**| App Store App Id | 
 **configId** | **string**| App Store Configuration Id | 

### Return type

[**AppConfigurationDetail**](AppConfigurationDetail.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfiguredappsingleapp"></a>
# **GetConfiguredAppSingleApp**
> RestApiArrayResultAppConfigurationSummary GetConfiguredAppSingleApp (string appId, string appStoreAppId)

Get list of app store app configurations for one app store app

[ALPHA - this endpoint is not ready to be consumed]

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
            var appId = appId_example;  // string | App Id
            var appStoreAppId = appStoreAppId_example;  // string | App Store App Id

            try
            {
                // Get list of app store app configurations for one app store app
                RestApiArrayResultAppConfigurationSummary result = apiInstance.GetConfiguredAppSingleApp(appId, appStoreAppId);
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
 **appId** | **string**| App Id | 
 **appStoreAppId** | **string**| App Store App Id | 

### Return type

[**RestApiArrayResultAppConfigurationSummary**](RestApiArrayResultAppConfigurationSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfiguredapps"></a>
# **GetConfiguredApps**
> RestApiArrayResultAppConfigurationHeader GetConfiguredApps (string appId)

Get list of app store apps which have been configured

[ALPHA - this endpoint is not ready to be consumed]

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
            var appId = appId_example;  // string | App Id

            try
            {
                // Get list of app store apps which have been configured
                RestApiArrayResultAppConfigurationHeader result = apiInstance.GetConfiguredApps(appId);
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
 **appId** | **string**| App Id | 

### Return type

[**RestApiArrayResultAppConfigurationHeader**](RestApiArrayResultAppConfigurationHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappstoreconfig"></a>
# **UpdateAppStoreConfig**
> void UpdateAppStoreConfig (string appId, string appStoreAppId, string configId, AppConfigurationBase appConfigurationBase)

Update app store app configuration

[BETA - this endpoint is under development, do not use it in your production system]

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
            var appId = appId_example;  // string | App Id
            var appStoreAppId = appStoreAppId_example;  // string | App Store App Id
            var configId = configId_example;  // string | App Store Configuration Id
            var appConfigurationBase = new AppConfigurationBase(); // AppConfigurationBase | App Store Configuration Base

            try
            {
                // Update app store app configuration
                apiInstance.UpdateAppStoreConfig(appId, appStoreAppId, configId, appConfigurationBase);
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
 **appId** | **string**| App Id | 
 **appStoreAppId** | **string**| App Store App Id | 
 **configId** | **string**| App Store Configuration Id | 
 **appConfigurationBase** | [**AppConfigurationBase**](AppConfigurationBase.md)| App Store Configuration Base | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

