# Flipdish.Api.LookerDashboardApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LookerDashboardGetAll**](LookerDashboardApi.md#lookerdashboardgetall) | **GET** /api/v1.0/{appId}/looker/dashboards | 


<a name="lookerdashboardgetall"></a>
# **LookerDashboardGetAll**
> void LookerDashboardGetAll (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class LookerDashboardGetAllExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LookerDashboardApi();
            var appId = appId_example;  // string | 

            try
            {
                apiInstance.LookerDashboardGetAll(appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookerDashboardApi.LookerDashboardGetAll: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

