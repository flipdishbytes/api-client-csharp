# Flipdish.Api.WebhooksApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CraeteWebhookSubscription**](WebhooksApi.md#craetewebhooksubscription) | **POST** /api/v{apiVersion}/webhooks/{clientId}/subscriptions | Create a webhook subscription for you Oauth client
[**CreateWebhookSubscriptionEventNames**](WebhooksApi.md#createwebhooksubscriptioneventnames) | **POST** /api/v{apiVersion}/webhooks/{clientId}/subscriptions/{webhookSubscriptionId}/events/{eventName} | Add event name to your webhook subscription
[**DeleteWebhookSubscription**](WebhooksApi.md#deletewebhooksubscription) | **DELETE** /api/v{apiVersion}/webhooks/{clientId}/subscriptions/{webhookSubscriptionId} | Delete you webhook subscription
[**DeleteWebhookSubscriptionEventName**](WebhooksApi.md#deletewebhooksubscriptioneventname) | **DELETE** /api/v{apiVersion}/webhooks/{clientId}/subscriptions/{webhookSubscriptionId}/events/{eventName} | Remove event name to your webhook subscription
[**GetWebhookEventNames**](WebhooksApi.md#getwebhookeventnames) | **GET** /api/v{apiVersion}/webhooks/events | Get all webhook subscription event names
[**GetWebhookEventNamesBySubscriptionId**](WebhooksApi.md#getwebhookeventnamesbysubscriptionid) | **GET** /api/v{apiVersion}/webhooks/{clientId}/subscriptions/{webhookSubscriptionId}/events | Get your webhook subscriptions selected event names
[**GetWebhookLogs**](WebhooksApi.md#getwebhooklogs) | **GET** /api/v{apiVersion}/webhooks/{clientId}/subscriptions/{webhookSubscriptionId}/logs | Get logs for your webhook subscription
[**GetWebhookSubscriptions**](WebhooksApi.md#getwebhooksubscriptions) | **GET** /api/v{apiVersion}/webhooks/{clientId}/subscriptions | Get all webhook subscriptions by your Oauth client id
[**UpdateWebhookSubscription**](WebhooksApi.md#updatewebhooksubscription) | **PUT** /api/v{apiVersion}/webhooks/{clientId}/subscriptions/{webhookSubscriptionId} | Update a webhook subscription object


<a name="craetewebhooksubscription"></a>
# **CraeteWebhookSubscription**
> RestApiIntegerResult CraeteWebhookSubscription (string clientId, WebhookSubscription webhookSubscription, string apiVersion)

Create a webhook subscription for you Oauth client

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CraeteWebhookSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var clientId = clientId_example;  // string | Oauth client identifier
            var webhookSubscription = new WebhookSubscription(); // WebhookSubscription | Webhook subscription object
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Create a webhook subscription for you Oauth client
                RestApiIntegerResult result = apiInstance.CraeteWebhookSubscription(clientId, webhookSubscription, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.CraeteWebhookSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Oauth client identifier | 
 **webhookSubscription** | [**WebhookSubscription**](WebhookSubscription.md)| Webhook subscription object | 
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiIntegerResult**](RestApiIntegerResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createwebhooksubscriptioneventnames"></a>
# **CreateWebhookSubscriptionEventNames**
> void CreateWebhookSubscriptionEventNames (string clientId, int? webhookSubscriptionId, string eventName, string apiVersion)

Add event name to your webhook subscription

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateWebhookSubscriptionEventNamesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var clientId = clientId_example;  // string | Oauth client identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var eventName = eventName_example;  // string | Webhook subscription event name
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Add event name to your webhook subscription
                apiInstance.CreateWebhookSubscriptionEventNames(clientId, webhookSubscriptionId, eventName, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.CreateWebhookSubscriptionEventNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Oauth client identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **eventName** | **string**| Webhook subscription event name | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewebhooksubscription"></a>
# **DeleteWebhookSubscription**
> void DeleteWebhookSubscription (string clientId, int? webhookSubscriptionId, string apiVersion)

Delete you webhook subscription

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteWebhookSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var clientId = clientId_example;  // string | Oauth client identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Delete you webhook subscription
                apiInstance.DeleteWebhookSubscription(clientId, webhookSubscriptionId, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhookSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Oauth client identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewebhooksubscriptioneventname"></a>
# **DeleteWebhookSubscriptionEventName**
> void DeleteWebhookSubscriptionEventName (string clientId, int? webhookSubscriptionId, string eventName, string apiVersion)

Remove event name to your webhook subscription

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteWebhookSubscriptionEventNameExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var clientId = clientId_example;  // string | Oauth client identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var eventName = eventName_example;  // string | Webhook subscription event name
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Remove event name to your webhook subscription
                apiInstance.DeleteWebhookSubscriptionEventName(clientId, webhookSubscriptionId, eventName, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhookSubscriptionEventName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Oauth client identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **eventName** | **string**| Webhook subscription event name | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhookeventnames"></a>
# **GetWebhookEventNames**
> RestApiStringArrayResult GetWebhookEventNames (string apiVersion)

Get all webhook subscription event names

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetWebhookEventNamesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get all webhook subscription event names
                RestApiStringArrayResult result = apiInstance.GetWebhookEventNames(apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhookEventNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiStringArrayResult**](RestApiStringArrayResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhookeventnamesbysubscriptionid"></a>
# **GetWebhookEventNamesBySubscriptionId**
> RestApiStringArrayResult GetWebhookEventNamesBySubscriptionId (string clientId, int? webhookSubscriptionId, string apiVersion)

Get your webhook subscriptions selected event names

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetWebhookEventNamesBySubscriptionIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var clientId = clientId_example;  // string | Oauth client identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get your webhook subscriptions selected event names
                RestApiStringArrayResult result = apiInstance.GetWebhookEventNamesBySubscriptionId(clientId, webhookSubscriptionId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhookEventNamesBySubscriptionId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Oauth client identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiStringArrayResult**](RestApiStringArrayResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooklogs"></a>
# **GetWebhookLogs**
> RestApiArrayResultWebhookLog GetWebhookLogs (string clientId, int? webhookSubscriptionId, DateTime? start, DateTime? end, string apiVersion, int? take = null)

Get logs for your webhook subscription

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetWebhookLogsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var clientId = clientId_example;  // string | Oauth client identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start time
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End time
            var apiVersion = apiVersion_example;  // string | API version
            var take = 56;  // int? | Page size (optional) 

            try
            {
                // Get logs for your webhook subscription
                RestApiArrayResultWebhookLog result = apiInstance.GetWebhookLogs(clientId, webhookSubscriptionId, start, end, apiVersion, take);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhookLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Oauth client identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **start** | **DateTime?**| Start time | 
 **end** | **DateTime?**| End time | 
 **apiVersion** | **string**| API version | 
 **take** | **int?**| Page size | [optional] 

### Return type

[**RestApiArrayResultWebhookLog**](RestApiArrayResultWebhookLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooksubscriptions"></a>
# **GetWebhookSubscriptions**
> RestApiArrayResultWebhookSubscription GetWebhookSubscriptions (string clientId, string apiVersion)

Get all webhook subscriptions by your Oauth client id

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetWebhookSubscriptionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var clientId = clientId_example;  // string | Oauth client identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get all webhook subscriptions by your Oauth client id
                RestApiArrayResultWebhookSubscription result = apiInstance.GetWebhookSubscriptions(clientId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhookSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Oauth client identifier | 
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiArrayResultWebhookSubscription**](RestApiArrayResultWebhookSubscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebhooksubscription"></a>
# **UpdateWebhookSubscription**
> void UpdateWebhookSubscription (string clientId, int? webhookSubscriptionId, WebhookSubscription webhookSubscription, string apiVersion)

Update a webhook subscription object

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateWebhookSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var clientId = clientId_example;  // string | Oauth client identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var webhookSubscription = new WebhookSubscription(); // WebhookSubscription | Webhook subscription object
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Update a webhook subscription object
                apiInstance.UpdateWebhookSubscription(clientId, webhookSubscriptionId, webhookSubscription, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.UpdateWebhookSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Oauth client identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **webhookSubscription** | [**WebhookSubscription**](WebhookSubscription.md)| Webhook subscription object | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

