# Flipdish.Api.HomeApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DismissHomeAction**](HomeApi.md#dismisshomeaction) | **POST** /api/v1.0/home/{homeActionId} | [PRIVATE API] Dismiss Home Action
[**GetHomeActions**](HomeApi.md#gethomeactions) | **GET** /api/v1.0/home | [PRIVATE API] Get Home Actions


<a name="dismisshomeaction"></a>
# **DismissHomeAction**
> Object DismissHomeAction (int? homeActionId)

[PRIVATE API] Dismiss Home Action

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DismissHomeActionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HomeApi();
            var homeActionId = 56;  // int? | Id of the action

            try
            {
                // [PRIVATE API] Dismiss Home Action
                Object result = apiInstance.DismissHomeAction(homeActionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HomeApi.DismissHomeAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **homeActionId** | **int?**| Id of the action | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethomeactions"></a>
# **GetHomeActions**
> RestApiArrayResultHomeAction GetHomeActions (string appId)

[PRIVATE API] Get Home Actions

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetHomeActionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HomeApi();
            var appId = appId_example;  // string | App Name Id

            try
            {
                // [PRIVATE API] Get Home Actions
                RestApiArrayResultHomeAction result = apiInstance.GetHomeActions(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HomeApi.GetHomeActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name Id | 

### Return type

[**RestApiArrayResultHomeAction**](RestApiArrayResultHomeAction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

