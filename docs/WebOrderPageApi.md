# Flipdish.Api.WebOrderPageApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWebOrderPage**](WebOrderPageApi.md#getweborderpage) | **GET** /api/v1.0/apps/{appId}/weborderpage | 
[**SetWebOrderPage**](WebOrderPageApi.md#setweborderpage) | **POST** /api/v1.0/apps/{appId}/weborderpage | 


<a name="getweborderpage"></a>
# **GetWebOrderPage**
> RestApiResultWebOrderPage GetWebOrderPage (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetWebOrderPageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebOrderPageApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultWebOrderPage result = apiInstance.GetWebOrderPage(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebOrderPageApi.GetWebOrderPage: " + e.Message );
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

[**RestApiResultWebOrderPage**](RestApiResultWebOrderPage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setweborderpage"></a>
# **SetWebOrderPage**
> void SetWebOrderPage (string appId, SetWebOrderPage setWebOrderPage)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetWebOrderPageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebOrderPageApi();
            var appId = appId_example;  // string | 
            var setWebOrderPage = new SetWebOrderPage(); // SetWebOrderPage | 

            try
            {
                apiInstance.SetWebOrderPage(appId, setWebOrderPage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebOrderPageApi.SetWebOrderPage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **setWebOrderPage** | [**SetWebOrderPage**](SetWebOrderPage.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

