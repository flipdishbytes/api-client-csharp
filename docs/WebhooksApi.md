# Flipdish.Api.WebhooksApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWebhookSubscription**](WebhooksApi.md#createwebhooksubscription) | **POST** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions | 
[**CreateWebhookSubscriptionEventNames**](WebhooksApi.md#createwebhooksubscriptioneventnames) | **POST** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId}/events/{eventName} | 
[**DeleteWebhookSubscription**](WebhooksApi.md#deletewebhooksubscription) | **DELETE** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId} | 
[**DeleteWebhookSubscriptionEventName**](WebhooksApi.md#deletewebhooksubscriptioneventname) | **DELETE** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId}/events/{eventName} | 
[**GetWebhookEventNames**](WebhooksApi.md#getwebhookeventnames) | **GET** /api/v1.0/{appId}/webhooks/events | 
[**GetWebhookEventNamesBySubscriptionId**](WebhooksApi.md#getwebhookeventnamesbysubscriptionid) | **GET** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId}/events | 
[**GetWebhookEventSample**](WebhooksApi.md#getwebhookeventsample) | **GET** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId}/events/{eventName}/test | 
[**GetWebhookLogs**](WebhooksApi.md#getwebhooklogs) | **GET** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId}/logs | 
[**GetWebhookSubscriptions**](WebhooksApi.md#getwebhooksubscriptions) | **GET** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions | 
[**UpdateWebhookSubscription**](WebhooksApi.md#updatewebhooksubscription) | **PUT** /api/v1.0/{appId}/webhooks/{oauthAppId}/subscriptions/{webhookSubscriptionId} | 


<a name="createwebhooksubscription"></a>
# **CreateWebhookSubscription**
> RestApiIntegerResult CreateWebhookSubscription (string oauthAppId, WebhookSubscription webhookSubscription, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateWebhookSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var oauthAppId = oauthAppId_example;  // string | 
            var webhookSubscription = new WebhookSubscription(); // WebhookSubscription | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiIntegerResult result = apiInstance.CreateWebhookSubscription(oauthAppId, webhookSubscription, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.CreateWebhookSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oauthAppId** | **string**|  | 
 **webhookSubscription** | [**WebhookSubscription**](WebhookSubscription.md)|  | 
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
            var oauthAppId = oauthAppId_example;  // string | 
            var webhookSubscriptionId = 56;  // int? | 
            var eventName = eventName_example;  // string | 
            var appId = appId_example;  // string | 

            try
            {
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
 **oauthAppId** | **string**|  | 
 **webhookSubscriptionId** | **int?**|  | 
 **eventName** | **string**|  | 
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
            var oauthAppId = oauthAppId_example;  // string | 
            var webhookSubscriptionId = 56;  // int? | 
            var appId = appId_example;  // string | 

            try
            {
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
 **oauthAppId** | **string**|  | 
 **webhookSubscriptionId** | **int?**|  | 
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
            var oauthAppId = oauthAppId_example;  // string | 
            var webhookSubscriptionId = 56;  // int? | 
            var eventName = eventName_example;  // string | 
            var appId = appId_example;  // string | 

            try
            {
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
 **oauthAppId** | **string**|  | 
 **webhookSubscriptionId** | **int?**|  | 
 **eventName** | **string**|  | 
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
            var oauthAppId = oauthAppId_example;  // string | 
            var webhookSubscriptionId = 56;  // int? | 
            var appId = appId_example;  // string | 

            try
            {
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
 **oauthAppId** | **string**|  | 
 **webhookSubscriptionId** | **int?**|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiStringArrayResult**](RestApiStringArrayResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhookeventsample"></a>
# **GetWebhookEventSample**
> WebhookEventSample GetWebhookEventSample (string eventName, string appId, string oauthAppId, string webhookSubscriptionId, string version = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetWebhookEventSampleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var eventName = eventName_example;  // string | 
            var appId = appId_example;  // string | 
            var oauthAppId = oauthAppId_example;  // string | 
            var webhookSubscriptionId = webhookSubscriptionId_example;  // string | 
            var version = version_example;  // string |  (optional) 

            try
            {
                WebhookEventSample result = apiInstance.GetWebhookEventSample(eventName, appId, oauthAppId, webhookSubscriptionId, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhookEventSample: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**|  | 
 **appId** | **string**|  | 
 **oauthAppId** | **string**|  | 
 **webhookSubscriptionId** | **string**|  | 
 **version** | **string**|  | [optional] 

### Return type

[**WebhookEventSample**](WebhookEventSample.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooklogs"></a>
# **GetWebhookLogs**
> RestApiPaginationResultWebhookLog GetWebhookLogs (string oauthAppId, int? webhookSubscriptionId, DateTime? start, DateTime? end, string appId, int? page = null, int? limit = null)



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
            var oauthAppId = oauthAppId_example;  // string | 
            var webhookSubscriptionId = 56;  // int? | 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var appId = appId_example;  // string | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
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
 **oauthAppId** | **string**|  | 
 **webhookSubscriptionId** | **int?**|  | 
 **start** | **DateTime?**|  | 
 **end** | **DateTime?**|  | 
 **appId** | **string**|  | 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

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
            var oauthAppId = oauthAppId_example;  // string | 
            var appId = appId_example;  // string | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
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
 **oauthAppId** | **string**|  | 
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
            var oauthAppId = oauthAppId_example;  // string | 
            var webhookSubscriptionId = 56;  // int? | 
            var webhookSubscription = new WebhookSubscription(); // WebhookSubscription | 
            var appId = appId_example;  // string | 

            try
            {
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
 **oauthAppId** | **string**|  | 
 **webhookSubscriptionId** | **int?**|  | 
 **webhookSubscription** | [**WebhookSubscription**](WebhookSubscription.md)|  | 
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

