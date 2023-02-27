# Flipdish.Api.SubscriptionsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSubscriptionById**](SubscriptionsApi.md#getsubscriptionbyid) | **GET** /api/v1.0/{appId}/subscriptions/{subscriptionId} | Get subscription by id
[**GetSubscriptionInvoices**](SubscriptionsApi.md#getsubscriptioninvoices) | **GET** /api/v1.0/{appId}/subscriptions/{subscriptionId}/invoices | Get list of invoices for a subscription by id
[**GetSubscriptionsForApp**](SubscriptionsApi.md#getsubscriptionsforapp) | **GET** /api/v1.0/{appId}/subscriptions | Get list of subscriptions for an App


<a name="getsubscriptionbyid"></a>
# **GetSubscriptionById**
> Subscription GetSubscriptionById (string appId, string subscriptionId)

Get subscription by id

[BETA - this endpoint is under development, do not use it in your production system]

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
            var appId = appId_example;  // string | App Id
            var subscriptionId = subscriptionId_example;  // string | Subscription Id

            try
            {
                // Get subscription by id
                Subscription result = apiInstance.GetSubscriptionById(appId, subscriptionId);
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
 **appId** | **string**| App Id | 
 **subscriptionId** | **string**| Subscription Id | 

### Return type

[**Subscription**](Subscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptioninvoices"></a>
# **GetSubscriptionInvoices**
> RestApiPaginationResultInvoice GetSubscriptionInvoices (string appId, string subscriptionId, int? limit = null, string startingAfterId = null)

Get list of invoices for a subscription by id

[BETA - this endpoint is under development, do not use it in your production system] Due to the nature of this request, page will always remain as 0.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetSubscriptionInvoicesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();
            var appId = appId_example;  // string | App Id
            var subscriptionId = subscriptionId_example;  // string | Subscription Id
            var limit = 56;  // int? | Limit of invoices to return (optional) 
            var startingAfterId = startingAfterId_example;  // string | Id for use in pagination. This defines your last known invoice in the list. For instance, if you make a list request and receive 10 invoices, last invoice ends with in_xxx, your subsequent call should include startingAfterId=in_xxx in order to fetch the next page of the invoices list. (optional) 

            try
            {
                // Get list of invoices for a subscription by id
                RestApiPaginationResultInvoice result = apiInstance.GetSubscriptionInvoices(appId, subscriptionId, limit, startingAfterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetSubscriptionInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Id | 
 **subscriptionId** | **string**| Subscription Id | 
 **limit** | **int?**| Limit of invoices to return | [optional] 
 **startingAfterId** | **string**| Id for use in pagination. This defines your last known invoice in the list. For instance, if you make a list request and receive 10 invoices, last invoice ends with in_xxx, your subsequent call should include startingAfterId&#x3D;in_xxx in order to fetch the next page of the invoices list. | [optional] 

### Return type

[**RestApiPaginationResultInvoice**](RestApiPaginationResultInvoice.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionsforapp"></a>
# **GetSubscriptionsForApp**
> RestApiArrayResultSubscriptionSummary GetSubscriptionsForApp (string appId, bool? excludeNotOwnedSubscriptions = null)

Get list of subscriptions for an App

[BETA - this endpoint is under development, do not use it in your production system]

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
            var appId = appId_example;  // string | App Id
            var excludeNotOwnedSubscriptions = true;  // bool? | Exclude not owned subscriptions. Set to true to only view your subscriptions (optional) 

            try
            {
                // Get list of subscriptions for an App
                RestApiArrayResultSubscriptionSummary result = apiInstance.GetSubscriptionsForApp(appId, excludeNotOwnedSubscriptions);
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
 **appId** | **string**| App Id | 
 **excludeNotOwnedSubscriptions** | **bool?**| Exclude not owned subscriptions. Set to true to only view your subscriptions | [optional] 

### Return type

[**RestApiArrayResultSubscriptionSummary**](RestApiArrayResultSubscriptionSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

