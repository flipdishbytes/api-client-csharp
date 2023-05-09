# Flipdish.Api.DeliveryTrackingApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignDriverToOrder**](DeliveryTrackingApi.md#assigndrivertoorder) | **POST** /api/v1.0/{appId}/drivers/{driverId}/orders/{orderId} | 
[**AssignDriverToOrders**](DeliveryTrackingApi.md#assigndrivertoorders) | **POST** /api/v1.0/{appId}/drivers/{driverId}/orders | 
[**GetDrivers**](DeliveryTrackingApi.md#getdrivers) | **GET** /api/v1.0/{appId}/drivers | 
[**InviteDriverToApp**](DeliveryTrackingApi.md#invitedrivertoapp) | **POST** /api/v1.0/{appId}/drivers | 
[**RemoveDriverFromApp**](DeliveryTrackingApi.md#removedriverfromapp) | **DELETE** /api/v1.0/{appId}/drivers/{driverId} | 
[**UnassignDriverFromOrder**](DeliveryTrackingApi.md#unassigndriverfromorder) | **DELETE** /api/v1.0/{appId}/orders/{orderId}/driver | 


<a name="assigndrivertoorder"></a>
# **AssignDriverToOrder**
> void AssignDriverToOrder (string appId, int? orderId, int? driverId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AssignDriverToOrderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeliveryTrackingApi();
            var appId = appId_example;  // string | 
            var orderId = 56;  // int? | 
            var driverId = 56;  // int? | 

            try
            {
                apiInstance.AssignDriverToOrder(appId, orderId, driverId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryTrackingApi.AssignDriverToOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **orderId** | **int?**|  | 
 **driverId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assigndrivertoorders"></a>
# **AssignDriverToOrders**
> void AssignDriverToOrders (string appId, int? driverId, List<OrderIdAndSequenceNumber> orderIdAndSequenceNumbers)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AssignDriverToOrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeliveryTrackingApi();
            var appId = appId_example;  // string | 
            var driverId = 56;  // int? | 
            var orderIdAndSequenceNumbers = new List<OrderIdAndSequenceNumber>(); // List<OrderIdAndSequenceNumber> | 

            try
            {
                apiInstance.AssignDriverToOrders(appId, driverId, orderIdAndSequenceNumbers);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryTrackingApi.AssignDriverToOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **driverId** | **int?**|  | 
 **orderIdAndSequenceNumbers** | [**List&lt;OrderIdAndSequenceNumber&gt;**](OrderIdAndSequenceNumber.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdrivers"></a>
# **GetDrivers**
> RestApiArrayResultDriver GetDrivers (string appId, string name = null, string phoneNumber = null, int? storeId = null, string presence = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetDriversExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeliveryTrackingApi();
            var appId = appId_example;  // string | 
            var name = name_example;  // string |  (optional) 
            var phoneNumber = phoneNumber_example;  // string |  (optional) 
            var storeId = 56;  // int? |  (optional) 
            var presence = presence_example;  // string |  (optional) 

            try
            {
                RestApiArrayResultDriver result = apiInstance.GetDrivers(appId, name, phoneNumber, storeId, presence);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryTrackingApi.GetDrivers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **name** | **string**|  | [optional] 
 **phoneNumber** | **string**|  | [optional] 
 **storeId** | **int?**|  | [optional] 
 **presence** | **string**|  | [optional] 

### Return type

[**RestApiArrayResultDriver**](RestApiArrayResultDriver.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitedrivertoapp"></a>
# **InviteDriverToApp**
> RestApiResultDriver InviteDriverToApp (string appId, DriverInvitation driverInvitation)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class InviteDriverToAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeliveryTrackingApi();
            var appId = appId_example;  // string | 
            var driverInvitation = new DriverInvitation(); // DriverInvitation | 

            try
            {
                RestApiResultDriver result = apiInstance.InviteDriverToApp(appId, driverInvitation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryTrackingApi.InviteDriverToApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **driverInvitation** | [**DriverInvitation**](DriverInvitation.md)|  | 

### Return type

[**RestApiResultDriver**](RestApiResultDriver.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removedriverfromapp"></a>
# **RemoveDriverFromApp**
> void RemoveDriverFromApp (string appId, int? driverId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RemoveDriverFromAppExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeliveryTrackingApi();
            var appId = appId_example;  // string | 
            var driverId = 56;  // int? | 

            try
            {
                apiInstance.RemoveDriverFromApp(appId, driverId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryTrackingApi.RemoveDriverFromApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **driverId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassigndriverfromorder"></a>
# **UnassignDriverFromOrder**
> void UnassignDriverFromOrder (string appId, int? orderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UnassignDriverFromOrderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeliveryTrackingApi();
            var appId = appId_example;  // string | 
            var orderId = 56;  // int? | 

            try
            {
                apiInstance.UnassignDriverFromOrder(appId, orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryTrackingApi.UnassignDriverFromOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **orderId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

