# Flipdish.Api.DeliveryTrackingApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignDriverToOrder**](DeliveryTrackingApi.md#assigndrivertoorder) | **POST** /api/v1.0/{appId}/drivers/{driverId}/orders/{orderId} | [PRIVATE] Assign driver to order
[**AssignDriverToOrders**](DeliveryTrackingApi.md#assigndrivertoorders) | **POST** /api/v1.0/{appId}/drivers/{driverId}/orders | Assign driver to multiple orders
[**GetDrivers**](DeliveryTrackingApi.md#getdrivers) | **GET** /api/v1.0/{appId}/drivers | [PRIVATE] Get drivers by App
[**InviteDriverToApp**](DeliveryTrackingApi.md#invitedrivertoapp) | **POST** /api/v1.0/{appId}/drivers | [PRIVATE] Invite driver
[**RemoveDriverFromApp**](DeliveryTrackingApi.md#removedriverfromapp) | **DELETE** /api/v1.0/{appId}/drivers/{driverId} | [PRIVATE] Unassign driver from app
[**UnassignDriverFromOrder**](DeliveryTrackingApi.md#unassigndriverfromorder) | **DELETE** /api/v1.0/{appId}/orders/{orderId}/driver | [PRIVATE] Unassign driver from order


<a name="assigndrivertoorder"></a>
# **AssignDriverToOrder**
> void AssignDriverToOrder (string appId, int? orderId, int? driverId)

[PRIVATE] Assign driver to order

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
            var appId = appId_example;  // string | Application identifier
            var orderId = 56;  // int? | Order Id
            var driverId = 56;  // int? | Driver Id

            try
            {
                // [PRIVATE] Assign driver to order
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
 **appId** | **string**| Application identifier | 
 **orderId** | **int?**| Order Id | 
 **driverId** | **int?**| Driver Id | 

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

Assign driver to multiple orders

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
            var appId = appId_example;  // string | Application identifier
            var driverId = 56;  // int? | Driver Id
            var orderIdAndSequenceNumbers = new List<OrderIdAndSequenceNumber>(); // List<OrderIdAndSequenceNumber> | Array of object containing OrderId and Sequence

            try
            {
                // Assign driver to multiple orders
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
 **appId** | **string**| Application identifier | 
 **driverId** | **int?**| Driver Id | 
 **orderIdAndSequenceNumbers** | [**List&lt;OrderIdAndSequenceNumber&gt;**](OrderIdAndSequenceNumber.md)| Array of object containing OrderId and Sequence | 

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

[PRIVATE] Get drivers by App

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
            var appId = appId_example;  // string | Application identifier
            var name = name_example;  // string | Driver's username (optional) 
            var phoneNumber = phoneNumber_example;  // string | Driver's phone number (optional) 
            var storeId = 56;  // int? | Store Id (optional) 
            var presence = presence_example;  // string | Offline/Online (optional) 

            try
            {
                // [PRIVATE] Get drivers by App
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
 **appId** | **string**| Application identifier | 
 **name** | **string**| Driver&#39;s username | [optional] 
 **phoneNumber** | **string**| Driver&#39;s phone number | [optional] 
 **storeId** | **int?**| Store Id | [optional] 
 **presence** | **string**| Offline/Online | [optional] 

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

[PRIVATE] Invite driver

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
            var appId = appId_example;  // string | Application identifier
            var driverInvitation = new DriverInvitation(); // DriverInvitation | Driver invitation model

            try
            {
                // [PRIVATE] Invite driver
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
 **appId** | **string**| Application identifier | 
 **driverInvitation** | [**DriverInvitation**](DriverInvitation.md)| Driver invitation model | 

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

[PRIVATE] Unassign driver from app

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
            var appId = appId_example;  // string | Application identifier
            var driverId = 56;  // int? | Driver Id

            try
            {
                // [PRIVATE] Unassign driver from app
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
 **appId** | **string**| Application identifier | 
 **driverId** | **int?**| Driver Id | 

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

[PRIVATE] Unassign driver from order

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
            var appId = appId_example;  // string | Application identifier
            var orderId = 56;  // int? | Order Id

            try
            {
                // [PRIVATE] Unassign driver from order
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
 **appId** | **string**| Application identifier | 
 **orderId** | **int?**| Order Id | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

