# Flipdish.Api.AppStoreApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAppStoreApp**](AppStoreApi.md#getappstoreapp) | **GET** /api/v1.0/appstore/apps/{appStoreAppId} | 
[**GetAppStoreApps**](AppStoreApi.md#getappstoreapps) | **GET** /api/v1.0/appstore/apps | 


<a name="getappstoreapp"></a>
# **GetAppStoreApp**
> RestApiResultAppStoreApp GetAppStoreApp (string appStoreAppId)



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
            var appStoreAppId = appStoreAppId_example;  // string | 

            try
            {
                RestApiResultAppStoreApp result = apiInstance.GetAppStoreApp(appStoreAppId);
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
 **appStoreAppId** | **string**|  | 

### Return type

[**RestApiResultAppStoreApp**](RestApiResultAppStoreApp.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappstoreapps"></a>
# **GetAppStoreApps**
> RestApiPaginationResultAppStoreAppSummary GetAppStoreApps (string search, int? page = null, int? limit = null, bool? excludeNotOwned = null)



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
            var search = search_example;  // string | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var excludeNotOwned = true;  // bool? |  (optional) 

            try
            {
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
 **search** | **string**|  | 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **excludeNotOwned** | **bool?**|  | [optional] 

### Return type

[**RestApiPaginationResultAppStoreAppSummary**](RestApiPaginationResultAppStoreAppSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

