# Flipdish.Api.KioskEntitlementsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QueryKioskEntitlements**](KioskEntitlementsApi.md#querykioskentitlements) | **GET** /api/v1.0/{appId}/kiosk/entitlements | 


<a name="querykioskentitlements"></a>
# **QueryKioskEntitlements**
> RestApiResultKioskEntitlementsResult QueryKioskEntitlements (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class QueryKioskEntitlementsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KioskEntitlementsApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultKioskEntitlementsResult result = apiInstance.QueryKioskEntitlements(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KioskEntitlementsApi.QueryKioskEntitlements: " + e.Message );
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

[**RestApiResultKioskEntitlementsResult**](RestApiResultKioskEntitlementsResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

