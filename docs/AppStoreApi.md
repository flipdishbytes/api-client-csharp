# Flipdish.Api.AppStoreApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAppStoreApp**](AppStoreApi.md#getappstoreapp) | **GET** /api/v1.0/appstore/apps/{appStoreAppId} | Get App store app
[**GetAppStoreApps**](AppStoreApi.md#getappstoreapps) | **GET** /api/v1.0/appstore/apps | Get list of App store app summaries


<a name="getappstoreapp"></a>
# **GetAppStoreApp**
> AppStoreApp GetAppStoreApp (string appStoreAppId)

Get App store app

App store app must be verified or you are the owner [BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppStoreAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreApi();
            var appStoreAppId = appStoreAppId_example;  // string | App store app id

            try
            {
                // Get App store app
                AppStoreApp result = apiInstance.GetAppStoreApp(appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreApi.GetAppStoreApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appStoreAppId** | **string**| App store app id | 

### Return type

[**AppStoreApp**](AppStoreApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappstoreapps"></a>
# **GetAppStoreApps**
> RestApiPaginationResultAppStoreAppSummary GetAppStoreApps (string search, int? page = null, int? limit = null, bool? excludeNotOwned = null)

Get list of App store app summaries

Only returns verified applications [BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppStoreAppsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreApi();
            var search = search_example;  // string | Query App store app name
            var page = 56;  // int? | Requested page index (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 
            var excludeNotOwned = true;  // bool? | Exclude App store apps that user is not the owner off (optional) 

            try
            {
                // Get list of App store app summaries
                RestApiPaginationResultAppStoreAppSummary result = apiInstance.GetAppStoreApps(search, page, limit, excludeNotOwned);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreApi.GetAppStoreApps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| Query App store app name | 
 **page** | **int?**| Requested page index | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 
 **excludeNotOwned** | **bool?**| Exclude App store apps that user is not the owner off | [optional] 

### Return type

[**RestApiPaginationResultAppStoreAppSummary**](RestApiPaginationResultAppStoreAppSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

