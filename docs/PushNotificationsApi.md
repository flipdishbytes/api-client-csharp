# IO.Swagger.Api.PushNotificationsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePushNotification**](PushNotificationsApi.md#deletepushnotification) | **DELETE** /api/v1.0/{appId}/pushnotifications/{scheduledPushNotificationId} | [PRIVATE] Push notification to cutomers
[**GetPushNotifications**](PushNotificationsApi.md#getpushnotifications) | **GET** /api/v1.0/{appId}/pushnotifications | [PRIVATE] Push notification to cutomers
[**SchedulePushNotification**](PushNotificationsApi.md#schedulepushnotification) | **POST** /api/v1.0/{appId}/pushnotifications | [PRIVATE] Push notification to cutomers
[**UpdatePushNotification**](PushNotificationsApi.md#updatepushnotification) | **POST** /api/v1.0/{appId}/pushnotifications/{scheduledPushNotificationId} | [PRIVATE] Update the push notification


<a name="deletepushnotification"></a>
# **DeletePushNotification**
> void DeletePushNotification (string appId, int? scheduledPushNotificationId)

[PRIVATE] Push notification to cutomers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var scheduledPushNotificationId = 56;  // int? | ID of Scheduled push notifiaction to delete

            try
            {
                // [PRIVATE] Push notification to cutomers
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
 **scheduledPushNotificationId** | **int?**| ID of Scheduled push notifiaction to delete | 

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

[PRIVATE] Push notification to cutomers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
                // [PRIVATE] Push notification to cutomers
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

[PRIVATE] Push notification to cutomers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SchedulePushNotificationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PushNotificationsApi();
            var appId = appId_example;  // string | Application Id
            var notification = new PushNotificationRequest(); // PushNotificationRequest | Notification to send

            try
            {
                // [PRIVATE] Push notification to cutomers
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
 **appId** | **string**| Application Id | 
 **notification** | [**PushNotificationRequest**](PushNotificationRequest.md)| Notification to send | 

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

[PRIVATE] Update the push notification

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePushNotificationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PushNotificationsApi();
            var appId = appId_example;  // string | Application Id
            var scheduledPushNotificationId = 56;  // int? | Notification Id
            var notification = new PushNotificationRequest(); // PushNotificationRequest | Notification to send

            try
            {
                // [PRIVATE] Update the push notification
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
 **appId** | **string**| Application Id | 
 **scheduledPushNotificationId** | **int?**| Notification Id | 
 **notification** | [**PushNotificationRequest**](PushNotificationRequest.md)| Notification to send | 

### Return type

[**RestApiResultPushNotificationResponse**](RestApiResultPushNotificationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

