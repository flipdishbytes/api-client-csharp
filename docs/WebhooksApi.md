# Flipdish.Api.WebhooksApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CraeteWebhookSubscription**](WebhooksApi.md#craetewebhooksubscription) | **POST** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions | Create a webhook subscription for you Oauth App
[**CreateWebhookSubscriptionEventNames**](WebhooksApi.md#createwebhooksubscriptioneventnames) | **POST** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId}/events/{eventName} | Add event name to your webhook subscription
[**DeleteWebhookSubscription**](WebhooksApi.md#deletewebhooksubscription) | **DELETE** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId} | Delete you webhook subscription
[**DeleteWebhookSubscriptionEventName**](WebhooksApi.md#deletewebhooksubscriptioneventname) | **DELETE** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId}/events/{eventName} | Remove event name to your webhook subscription
[**GetWebhookEventNames**](WebhooksApi.md#getwebhookeventnames) | **GET** /api/v1.0/{appId}/webhooks/events | Get all webhook subscription event names
[**GetWebhookEventNamesBySubscriptionId**](WebhooksApi.md#getwebhookeventnamesbysubscriptionid) | **GET** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId}/events | Get your webhook subscriptions selected event names
[**GetWebhookLogs**](WebhooksApi.md#getwebhooklogs) | **GET** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId}/logs | Get logs for your webhook subscription
[**GetWebhookSubscriptions**](WebhooksApi.md#getwebhooksubscriptions) | **GET** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions | Get all webhook subscriptions by your Oauth App id
[**UpdateWebhookSubscription**](WebhooksApi.md#updatewebhooksubscription) | **PUT** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId} | Update a webhook subscription object


<a name="craetewebhooksubscription"></a>
# **CraeteWebhookSubscription**
> RestApiIntegerResult CraeteWebhookSubscription (string oauthAppId, WebhookSubscription webhookSubscription, string appId)

Create a webhook subscription for you Oauth App

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
            var oauthAppId = oauthAppId_example;  // string | Oauth App identifier
            var webhookSubscription = new WebhookSubscription(); // WebhookSubscription | Webhook subscription object
            var appId = appId_example;  // string | 

            try
            {
                // Create a webhook subscription for you Oauth App
                RestApiIntegerResult result = apiInstance.CraeteWebhookSubscription(oauthAppId, webhookSubscription, appId);
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
 **oauthAppId** | **string**| Oauth App identifier | 
 **webhookSubscription** | [**WebhookSubscription**](WebhookSubscription.md)| Webhook subscription object | 
 **appId** | **string**|  | 

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
> void CreateWebhookSubscriptionEventNames (string oauthAppId, int? webhookSubscriptionId, string eventName, string appId)

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
            var oauthAppId = oauthAppId_example;  // string | Oauth App identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var eventName = eventName_example;  // string | Webhook subscription event name
            var appId = appId_example;  // string | 

            try
            {
                // Add event name to your webhook subscription
                apiInstance.CreateWebhookSubscriptionEventNames(oauthAppId, webhookSubscriptionId, eventName, appId);
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
 **oauthAppId** | **string**| Oauth App identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **eventName** | **string**| Webhook subscription event name | 
 **appId** | **string**|  | 

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
> void DeleteWebhookSubscription (string oauthAppId, int? webhookSubscriptionId, string appId)

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
            var oauthAppId = oauthAppId_example;  // string | Oauth App identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var appId = appId_example;  // string | 

            try
            {
                // Delete you webhook subscription
                apiInstance.DeleteWebhookSubscription(oauthAppId, webhookSubscriptionId, appId);
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
 **oauthAppId** | **string**| Oauth App identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **appId** | **string**|  | 

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
> void DeleteWebhookSubscriptionEventName (string oauthAppId, int? webhookSubscriptionId, string eventName, string appId)

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
            var oauthAppId = oauthAppId_example;  // string | Oauth App identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var eventName = eventName_example;  // string | Webhook subscription event name
            var appId = appId_example;  // string | 

            try
            {
                // Remove event name to your webhook subscription
                apiInstance.DeleteWebhookSubscriptionEventName(oauthAppId, webhookSubscriptionId, eventName, appId);
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
 **oauthAppId** | **string**| Oauth App identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **eventName** | **string**| Webhook subscription event name | 
 **appId** | **string**|  | 

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
> RestApiStringArrayResult GetWebhookEventNames (string appId)

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
            var appId = appId_example;  // string | 

            try
            {
                // Get all webhook subscription event names
                RestApiStringArrayResult result = apiInstance.GetWebhookEventNames(appId);
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
 **appId** | **string**|  | 

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
> RestApiStringArrayResult GetWebhookEventNamesBySubscriptionId (string oauthAppId, int? webhookSubscriptionId, string appId)

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
            var oauthAppId = oauthAppId_example;  // string | Oauth App identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var appId = appId_example;  // string | 

            try
            {
                // Get your webhook subscriptions selected event names
                RestApiStringArrayResult result = apiInstance.GetWebhookEventNamesBySubscriptionId(oauthAppId, webhookSubscriptionId, appId);
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
 **oauthAppId** | **string**| Oauth App identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **appId** | **string**|  | 

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
> RestApiPaginationResultWebhookLog GetWebhookLogs (string oauthAppId, int? webhookSubscriptionId, DateTime? start, DateTime? end, string appId, int? page = null, int? limit = null)

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
            var oauthAppId = oauthAppId_example;  // string | Oauth App identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Start time
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | End time
            var appId = appId_example;  // string | 
            var page = 56;  // int? | Page number (optional) 
            var limit = 56;  // int? | Page size (optional) 

            try
            {
                // Get logs for your webhook subscription
                RestApiPaginationResultWebhookLog result = apiInstance.GetWebhookLogs(oauthAppId, webhookSubscriptionId, start, end, appId, page, limit);
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
 **oauthAppId** | **string**| Oauth App identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **start** | **DateTime?**| Start time | 
 **end** | **DateTime?**| End time | 
 **appId** | **string**|  | 
 **page** | **int?**| Page number | [optional] 
 **limit** | **int?**| Page size | [optional] 

### Return type

[**RestApiPaginationResultWebhookLog**](RestApiPaginationResultWebhookLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooksubscriptions"></a>
# **GetWebhookSubscriptions**
> RestApiPaginationResultWebhookSubscription GetWebhookSubscriptions (string oauthAppId, string appId, int? page = null, int? limit = null)

Get all webhook subscriptions by your Oauth App id

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
            var oauthAppId = oauthAppId_example;  // string | Oauth App identifier
            var appId = appId_example;  // string | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Get all webhook subscriptions by your Oauth App id
                RestApiPaginationResultWebhookSubscription result = apiInstance.GetWebhookSubscriptions(oauthAppId, appId, page, limit);
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
 **oauthAppId** | **string**| Oauth App identifier | 
 **appId** | **string**|  | 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultWebhookSubscription**](RestApiPaginationResultWebhookSubscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebhooksubscription"></a>
# **UpdateWebhookSubscription**
> void UpdateWebhookSubscription (string oauthAppId, int? webhookSubscriptionId, WebhookSubscription webhookSubscription, string appId)

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
            var oauthAppId = oauthAppId_example;  // string | Oauth App identifier
            var webhookSubscriptionId = 56;  // int? | Webhook subscription identifier
            var webhookSubscription = new WebhookSubscription(); // WebhookSubscription | Webhook subscription object
            var appId = appId_example;  // string | 

            try
            {
                // Update a webhook subscription object
                apiInstance.UpdateWebhookSubscription(oauthAppId, webhookSubscriptionId, webhookSubscription, appId);
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
 **oauthAppId** | **string**| Oauth App identifier | 
 **webhookSubscriptionId** | **int?**| Webhook subscription identifier | 
 **webhookSubscription** | [**WebhookSubscription**](WebhookSubscription.md)| Webhook subscription object | 
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

