# Flipdish.Api.AppStoreEntitlementsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAppStoreAppEntitlements**](AppStoreEntitlementsApi.md#getappstoreappentitlements) | **GET** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/entitlements | 


<a name="getappstoreappentitlements"></a>
# **GetAppStoreAppEntitlements**
> RestApiResultAppStoreAppEntitlements GetAppStoreAppEntitlements (string appId, string appStoreAppId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppStoreAppEntitlementsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreEntitlementsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 

            try
            {
                RestApiResultAppStoreAppEntitlements result = apiInstance.GetAppStoreAppEntitlements(appId, appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreEntitlementsApi.GetAppStoreAppEntitlements: " + e.Message );
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

[**RestApiResultAppStoreAppEntitlements**](RestApiResultAppStoreAppEntitlements.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

