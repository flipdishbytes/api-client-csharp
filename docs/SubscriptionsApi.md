# Flipdish.Api.SubscriptionsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSubscriptionById**](SubscriptionsApi.md#getsubscriptionbyid) | **GET** /api/v1.0/{appId}/subscriptions/{subscriptionId} | 
[**GetSubscriptionsForApp**](SubscriptionsApi.md#getsubscriptionsforapp) | **GET** /api/v1.0/{appId}/subscriptions | 


<a name="getsubscriptionbyid"></a>
# **GetSubscriptionById**
> RestApiResultSubscription GetSubscriptionById (string appId, string subscriptionId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetSubscriptionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();
            var appId = appId_example;  // string | 
            var subscriptionId = subscriptionId_example;  // string | 

            try
            {
                RestApiResultSubscription result = apiInstance.GetSubscriptionById(appId, subscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetSubscriptionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **subscriptionId** | **string**|  | 

### Return type

[**RestApiResultSubscription**](RestApiResultSubscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionsforapp"></a>
# **GetSubscriptionsForApp**
> RestApiArrayResultSubscriptionSummary GetSubscriptionsForApp (string appId, bool? excludeNotOwnedSubscriptions = null, List<int?> storeId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetSubscriptionsForAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();
            var appId = appId_example;  // string | 
            var excludeNotOwnedSubscriptions = true;  // bool? |  (optional) 
            var storeId = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                RestApiArrayResultSubscriptionSummary result = apiInstance.GetSubscriptionsForApp(appId, excludeNotOwnedSubscriptions, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetSubscriptionsForApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **excludeNotOwnedSubscriptions** | **bool?**|  | [optional] 
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiArrayResultSubscriptionSummary**](RestApiArrayResultSubscriptionSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

