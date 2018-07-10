# Flipdish.Api.SubscriptionsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubscriptionsCancelSubscription**](SubscriptionsApi.md#subscriptionscancelsubscription) | **DELETE** /api/v1.0/subscriptions/{subscriptionId} | Cancel the subscription
[**SubscriptionsGetCard**](SubscriptionsApi.md#subscriptionsgetcard) | **GET** /api/v1.0/subscriptions/{subscriptionId}/card | Get the card linked to the subscription
[**SubscriptionsGetPlansByCurrency**](SubscriptionsApi.md#subscriptionsgetplansbycurrency) | **GET** /api/v1.0/subscriptions/plans | Get avaialble plans for currency&#39;s user
[**SubscriptionsGetSubscription**](SubscriptionsApi.md#subscriptionsgetsubscription) | **GET** /api/v1.0/subscriptions/{subscriptionId} | Get the subscription including the payment history
[**SubscriptionsGetUserSubscriptionByAppId**](SubscriptionsApi.md#subscriptionsgetusersubscriptionbyappid) | **GET** /api/v1.0/subscriptions | Get subscription by appId
[**SubscriptionsReplaceOldCardWithNewCard**](SubscriptionsApi.md#subscriptionsreplaceoldcardwithnewcard) | **POST** /api/v1.0/subscriptions/{subscriptionId}/card/new | Add a new card and replace the old one
[**SubscriptionsSubscribe**](SubscriptionsApi.md#subscriptionssubscribe) | **POST** /api/v1.0/subscriptions | Create a new subscription
[**SubscriptionsUpdateCardExpiringDate**](SubscriptionsApi.md#subscriptionsupdatecardexpiringdate) | **POST** /api/v1.0/subscriptions/{subscriptionId}/card | Update card expiring date
[**SubscriptionsUpdateSubscription**](SubscriptionsApi.md#subscriptionsupdatesubscription) | **POST** /api/v1.0/subscriptions/{subscriptionId} | Update the subscription


<a name="subscriptionscancelsubscription"></a>
# **SubscriptionsCancelSubscription**
> Object SubscriptionsCancelSubscription (int? subscriptionId)

Cancel the subscription

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubscriptionsCancelSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();
            var subscriptionId = 56;  // int? | Subscription identifier

            try
            {
                // Cancel the subscription
                Object result = apiInstance.SubscriptionsCancelSubscription(subscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsCancelSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **int?**| Subscription identifier | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsgetcard"></a>
# **SubscriptionsGetCard**
> RestApiResultCard SubscriptionsGetCard (int? subscriptionId)

Get the card linked to the subscription

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubscriptionsGetCardExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();
            var subscriptionId = 56;  // int? | Subscription identifier

            try
            {
                // Get the card linked to the subscription
                RestApiResultCard result = apiInstance.SubscriptionsGetCard(subscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsGetCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **int?**| Subscription identifier | 

### Return type

[**RestApiResultCard**](RestApiResultCard.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsgetplansbycurrency"></a>
# **SubscriptionsGetPlansByCurrency**
> RestApiResultSubscriptionPlansResponse SubscriptionsGetPlansByCurrency ()

Get avaialble plans for currency's user

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubscriptionsGetPlansByCurrencyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();

            try
            {
                // Get avaialble plans for currency's user
                RestApiResultSubscriptionPlansResponse result = apiInstance.SubscriptionsGetPlansByCurrency();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsGetPlansByCurrency: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiResultSubscriptionPlansResponse**](RestApiResultSubscriptionPlansResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsgetsubscription"></a>
# **SubscriptionsGetSubscription**
> RestApiResultSubscription SubscriptionsGetSubscription (int? subscriptionId)

Get the subscription including the payment history

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubscriptionsGetSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();
            var subscriptionId = 56;  // int? | Subscription Identifier

            try
            {
                // Get the subscription including the payment history
                RestApiResultSubscription result = apiInstance.SubscriptionsGetSubscription(subscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsGetSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **int?**| Subscription Identifier | 

### Return type

[**RestApiResultSubscription**](RestApiResultSubscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsgetusersubscriptionbyappid"></a>
# **SubscriptionsGetUserSubscriptionByAppId**
> RestApiResultSubscription SubscriptionsGetUserSubscriptionByAppId (string appId)

Get subscription by appId

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubscriptionsGetUserSubscriptionByAppIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();
            var appId = appId_example;  // string | The string app identifier

            try
            {
                // Get subscription by appId
                RestApiResultSubscription result = apiInstance.SubscriptionsGetUserSubscriptionByAppId(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsGetUserSubscriptionByAppId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| The string app identifier | 

### Return type

[**RestApiResultSubscription**](RestApiResultSubscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsreplaceoldcardwithnewcard"></a>
# **SubscriptionsReplaceOldCardWithNewCard**
> Object SubscriptionsReplaceOldCardWithNewCard (int? subscriptionId, CardWithToken card)

Add a new card and replace the old one

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubscriptionsReplaceOldCardWithNewCardExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();
            var subscriptionId = 56;  // int? | Subscription identifier
            var card = new CardWithToken(); // CardWithToken | Token Id

            try
            {
                // Add a new card and replace the old one
                Object result = apiInstance.SubscriptionsReplaceOldCardWithNewCard(subscriptionId, card);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsReplaceOldCardWithNewCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **int?**| Subscription identifier | 
 **card** | [**CardWithToken**](CardWithToken.md)| Token Id | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionssubscribe"></a>
# **SubscriptionsSubscribe**
> Object SubscriptionsSubscribe (SubscriptionWithToken subscription)

Create a new subscription

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubscriptionsSubscribeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();
            var subscription = new SubscriptionWithToken(); // SubscriptionWithToken | Data necessary to create a new subscription

            try
            {
                // Create a new subscription
                Object result = apiInstance.SubscriptionsSubscribe(subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsSubscribe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscription** | [**SubscriptionWithToken**](SubscriptionWithToken.md)| Data necessary to create a new subscription | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsupdatecardexpiringdate"></a>
# **SubscriptionsUpdateCardExpiringDate**
> RestApiResultCard SubscriptionsUpdateCardExpiringDate (int? subscriptionId, CardBase card)

Update card expiring date

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubscriptionsUpdateCardExpiringDateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();
            var subscriptionId = 56;  // int? | Subscription identifier
            var card = new CardBase(); // CardBase | Data to update card expiring date

            try
            {
                // Update card expiring date
                RestApiResultCard result = apiInstance.SubscriptionsUpdateCardExpiringDate(subscriptionId, card);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsUpdateCardExpiringDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **int?**| Subscription identifier | 
 **card** | [**CardBase**](CardBase.md)| Data to update card expiring date | 

### Return type

[**RestApiResultCard**](RestApiResultCard.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscriptionsupdatesubscription"></a>
# **SubscriptionsUpdateSubscription**
> Object SubscriptionsUpdateSubscription (int? subscriptionId, SubscriptionBase subscription)

Update the subscription

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SubscriptionsUpdateSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi();
            var subscriptionId = 56;  // int? | Subscription identifier
            var subscription = new SubscriptionBase(); // SubscriptionBase | Data to update the subscription

            try
            {
                // Update the subscription
                Object result = apiInstance.SubscriptionsUpdateSubscription(subscriptionId, subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SubscriptionsUpdateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionId** | **int?**| Subscription identifier | 
 **subscription** | [**SubscriptionBase**](SubscriptionBase.md)| Data to update the subscription | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

