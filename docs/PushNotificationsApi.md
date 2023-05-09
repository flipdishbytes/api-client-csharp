# Flipdish.Api.PushNotificationsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePushNotification**](PushNotificationsApi.md#deletepushnotification) | **DELETE** /api/v1.0/{appId}/pushnotifications/{scheduledPushNotificationId} | 
[**GetPushNotifications**](PushNotificationsApi.md#getpushnotifications) | **GET** /api/v1.0/{appId}/pushnotifications | 
[**SchedulePushNotification**](PushNotificationsApi.md#schedulepushnotification) | **POST** /api/v1.0/{appId}/pushnotifications | 
[**UpdatePushNotification**](PushNotificationsApi.md#updatepushnotification) | **POST** /api/v1.0/{appId}/pushnotifications/{scheduledPushNotificationId} | 


<a name="deletepushnotification"></a>
# **DeletePushNotification**
> void DeletePushNotification (string appId, int? scheduledPushNotificationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeletePushNotificationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PushNotificationsApi();
            var appId = appId_example;  // string | 
            var scheduledPushNotificationId = 56;  // int? | 

            try
            {
                apiInstance.DeletePushNotification(appId, scheduledPushNotificationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.DeletePushNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **scheduledPushNotificationId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpushnotifications"></a>
# **GetPushNotifications**
> RestApiPaginationResultPushNotificationResponse GetPushNotifications (string appId, int? page = null, int? limit = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPushNotificationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PushNotificationsApi();
            var appId = appId_example;  // string | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                RestApiPaginationResultPushNotificationResponse result = apiInstance.GetPushNotifications(appId, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.GetPushNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultPushNotificationResponse**](RestApiPaginationResultPushNotificationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulepushnotification"></a>
# **SchedulePushNotification**
> RestApiResultPushNotificationResponse SchedulePushNotification (string appId, PushNotificationRequest notification)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SchedulePushNotificationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PushNotificationsApi();
            var appId = appId_example;  // string | 
            var notification = new PushNotificationRequest(); // PushNotificationRequest | 

            try
            {
                RestApiResultPushNotificationResponse result = apiInstance.SchedulePushNotification(appId, notification);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.SchedulePushNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **notification** | [**PushNotificationRequest**](PushNotificationRequest.md)|  | 

### Return type

[**RestApiResultPushNotificationResponse**](RestApiResultPushNotificationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepushnotification"></a>
# **UpdatePushNotification**
> RestApiResultPushNotificationResponse UpdatePushNotification (string appId, int? scheduledPushNotificationId, PushNotificationRequest notification)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdatePushNotificationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PushNotificationsApi();
            var appId = appId_example;  // string | 
            var scheduledPushNotificationId = 56;  // int? | 
            var notification = new PushNotificationRequest(); // PushNotificationRequest | 

            try
            {
                RestApiResultPushNotificationResponse result = apiInstance.UpdatePushNotification(appId, scheduledPushNotificationId, notification);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.UpdatePushNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **scheduledPushNotificationId** | **int?**|  | 
 **notification** | [**PushNotificationRequest**](PushNotificationRequest.md)|  | 

### Return type

[**RestApiResultPushNotificationResponse**](RestApiResultPushNotificationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

