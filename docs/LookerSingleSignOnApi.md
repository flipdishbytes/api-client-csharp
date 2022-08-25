# IO.Swagger.Api.LookerSingleSignOnApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSSOEndpoint**](LookerSingleSignOnApi.md#getssoendpoint) | **GET** /api/v1.0/{appId}/looker/sso | Get the generic single sign on embed URL for Looker dashboards


<a name="getssoendpoint"></a>
# **GetSSOEndpoint**
> DashboardEmbed GetSSOEndpoint (string appId, string embedPath, string filters = null)

Get the generic single sign on embed URL for Looker dashboards

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSSOEndpointExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LookerSingleSignOnApi();
            var appId = appId_example;  // string | AppNameId
            var embedPath = embedPath_example;  // string | Embed URL of the dashboard
            var filters = filters_example;  // string | Filters that will be passed to the dashboard (optional) 

            try
            {
                // Get the generic single sign on embed URL for Looker dashboards
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
 **appId** | **string**| AppNameId | 
 **embedPath** | **string**| Embed URL of the dashboard | 
 **filters** | **string**| Filters that will be passed to the dashboard | [optional] 

### Return type

[**DashboardEmbed**](DashboardEmbed.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

