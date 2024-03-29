# Flipdish.Api.LookerSingleSignOnApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSSOEndpoint**](LookerSingleSignOnApi.md#getssoendpoint) | **GET** /api/v1.0/{appId}/looker/sso | 


<a name="getssoendpoint"></a>
# **GetSSOEndpoint**
> DashboardEmbed GetSSOEndpoint (string appId, string embedPath, string filters = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetSSOEndpointExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LookerSingleSignOnApi();
            var appId = appId_example;  // string | 
            var embedPath = embedPath_example;  // string | 
            var filters = filters_example;  // string |  (optional) 

            try
            {
                DashboardEmbed result = apiInstance.GetSSOEndpoint(appId, embedPath, filters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LookerSingleSignOnApi.GetSSOEndpoint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **embedPath** | **string**|  | 
 **filters** | **string**|  | [optional] 

### Return type

[**DashboardEmbed**](DashboardEmbed.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

