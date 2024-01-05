# Flipdish.Api.AppStoreSubscriptionsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAppStoreSubscription**](AppStoreSubscriptionsApi.md#createappstoresubscription) | **GET** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/subscriptions | 
[**CreateAppStoreSubscription_0**](AppStoreSubscriptionsApi.md#createappstoresubscription_0) | **POST** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/subscriptions | 
[**DeleteAppSubscription**](AppStoreSubscriptionsApi.md#deleteappsubscription) | **DELETE** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/subscriptions/{subscriptionId} | 
[**GetAppStoreSubscriptionChangeJobStatus**](AppStoreSubscriptionsApi.md#getappstoresubscriptionchangejobstatus) | **GET** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/subscriptions/jobs/{jobId} | 
[**UpdateAppStoreSubscription**](AppStoreSubscriptionsApi.md#updateappstoresubscription) | **POST** /api/v1.0/{appId}/appstore/apps/{appStoreAppId}/subscriptions/{subscriptionId} | 


<a name="createappstoresubscription"></a>
# **CreateAppStoreSubscription**
> RestApiArrayResultAppStoreSubscriptionItem CreateAppStoreSubscription (string appId, string appStoreAppId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateAppStoreSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreSubscriptionsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 

            try
            {
                RestApiArrayResultAppStoreSubscriptionItem result = apiInstance.CreateAppStoreSubscription(appId, appStoreAppId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreSubscriptionsApi.CreateAppStoreSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 

### Return type

[**RestApiArrayResultAppStoreSubscriptionItem**](RestApiArrayResultAppStoreSubscriptionItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createappstoresubscription_0"></a>
# **CreateAppStoreSubscription_0**
> RestApiResultAppStoreSubscriptionJobResponse CreateAppStoreSubscription_0 (string appId, string appStoreAppId, AddAppStoreSubscriptionRequest addAppStoreSubscriptionRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateAppStoreSubscription_0Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreSubscriptionsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var addAppStoreSubscriptionRequest = new AddAppStoreSubscriptionRequest(); // AddAppStoreSubscriptionRequest | 

            try
            {
                RestApiResultAppStoreSubscriptionJobResponse result = apiInstance.CreateAppStoreSubscription_0(appId, appStoreAppId, addAppStoreSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreSubscriptionsApi.CreateAppStoreSubscription_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **addAppStoreSubscriptionRequest** | [**AddAppStoreSubscriptionRequest**](AddAppStoreSubscriptionRequest.md)|  | 

### Return type

[**RestApiResultAppStoreSubscriptionJobResponse**](RestApiResultAppStoreSubscriptionJobResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteappsubscription"></a>
# **DeleteAppSubscription**
> RestApiResultAppStoreSubscriptionJobResponse DeleteAppSubscription (string appId, string appStoreAppId, string subscriptionId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteAppSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreSubscriptionsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var subscriptionId = subscriptionId_example;  // string | 

            try
            {
                RestApiResultAppStoreSubscriptionJobResponse result = apiInstance.DeleteAppSubscription(appId, appStoreAppId, subscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreSubscriptionsApi.DeleteAppSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **subscriptionId** | **string**|  | 

### Return type

[**RestApiResultAppStoreSubscriptionJobResponse**](RestApiResultAppStoreSubscriptionJobResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappstoresubscriptionchangejobstatus"></a>
# **GetAppStoreSubscriptionChangeJobStatus**
> RestApiResultAppStoreSubscriptionChangeJobStatusResponse GetAppStoreSubscriptionChangeJobStatus (string appId, string appStoreAppId, string jobId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAppStoreSubscriptionChangeJobStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreSubscriptionsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var jobId = jobId_example;  // string | 

            try
            {
                RestApiResultAppStoreSubscriptionChangeJobStatusResponse result = apiInstance.GetAppStoreSubscriptionChangeJobStatus(appId, appStoreAppId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreSubscriptionsApi.GetAppStoreSubscriptionChangeJobStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **jobId** | **string**|  | 

### Return type

[**RestApiResultAppStoreSubscriptionChangeJobStatusResponse**](RestApiResultAppStoreSubscriptionChangeJobStatusResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappstoresubscription"></a>
# **UpdateAppStoreSubscription**
> RestApiResultAppStoreSubscriptionJobResponse UpdateAppStoreSubscription (string appId, string appStoreAppId, string subscriptionId, UpdateAppStoreSubscriptionRequest updateAppStoreSubscriptionRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateAppStoreSubscriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppStoreSubscriptionsApi();
            var appId = appId_example;  // string | 
            var appStoreAppId = appStoreAppId_example;  // string | 
            var subscriptionId = subscriptionId_example;  // string | 
            var updateAppStoreSubscriptionRequest = new UpdateAppStoreSubscriptionRequest(); // UpdateAppStoreSubscriptionRequest | 

            try
            {
                RestApiResultAppStoreSubscriptionJobResponse result = apiInstance.UpdateAppStoreSubscription(appId, appStoreAppId, subscriptionId, updateAppStoreSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppStoreSubscriptionsApi.UpdateAppStoreSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **appStoreAppId** | **string**|  | 
 **subscriptionId** | **string**|  | 
 **updateAppStoreSubscriptionRequest** | [**UpdateAppStoreSubscriptionRequest**](UpdateAppStoreSubscriptionRequest.md)|  | 

### Return type

[**RestApiResultAppStoreSubscriptionJobResponse**](RestApiResultAppStoreSubscriptionJobResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

