# Flipdish.Api.DriversApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDriverNotificationToken**](DriversApi.md#adddrivernotificationtoken) | **POST** /api/v1.0/drivers/token | Add driver token
[**DeleteDriverProfileImage**](DriversApi.md#deletedriverprofileimage) | **DELETE** /api/v1.0/drivers/profile/image | Delete driver profile image
[**DriverLogin**](DriversApi.md#driverlogin) | **POST** /api/v1.0/drivers/login | [PRIVATE] Login with phone number and pin
[**DriverRequestLoginCodeSms**](DriversApi.md#driverrequestlogincodesms) | **POST** /api/v1.0/drivers/pin | [PRIVATE] Request an SMS to be sent to the driver with their login code
[**GetDriverProfile**](DriversApi.md#getdriverprofile) | **GET** /api/v1.0/drivers/profile | Get driver profile
[**GetStoresForDriver**](DriversApi.md#getstoresfordriver) | **GET** /api/v1.0/drivers/assignedstores | Get stores for driver
[**RemoveDriverNotificationToken**](DriversApi.md#removedrivernotificationtoken) | **DELETE** /api/v1.0/drivers/token | Delete driver token
[**SetDriverPresenceForStore**](DriversApi.md#setdriverpresenceforstore) | **POST** /api/v1.0/drivers/stores/{storeId}/presence/{presence} | 
[**SetDriverProfileImage**](DriversApi.md#setdriverprofileimage) | **POST** /api/v1.0/drivers/profile/image | Set driver profile image and returns it&#39;s url
[**UpdateDeliveryTrackingStatus**](DriversApi.md#updatedeliverytrackingstatus) | **POST** /api/v1.0/orders/{orderId}/tracking/{deliveryTrackingStatus} | Change delivery tracking status and return the updated status.
[**UpdateDriverProfile**](DriversApi.md#updatedriverprofile) | **POST** /api/v1.0/drivers/profile | Update driver profile


<a name="adddrivernotificationtoken"></a>
# **AddDriverNotificationToken**
> void AddDriverNotificationToken (UpdateDriverNotificationToken updateDriverToken)

Add driver token

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddDriverNotificationTokenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var updateDriverToken = new UpdateDriverNotificationToken(); // UpdateDriverNotificationToken | 

            try
            {
                // Add driver token
                apiInstance.AddDriverNotificationToken(updateDriverToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.AddDriverNotificationToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateDriverToken** | [**UpdateDriverNotificationToken**](UpdateDriverNotificationToken.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedriverprofileimage"></a>
# **DeleteDriverProfileImage**
> void DeleteDriverProfileImage ()

Delete driver profile image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteDriverProfileImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();

            try
            {
                // Delete driver profile image
                apiInstance.DeleteDriverProfileImage();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DeleteDriverProfileImage: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="driverlogin"></a>
# **DriverLogin**
> void DriverLogin (DriverLoginModel driverLoginModel)

[PRIVATE] Login with phone number and pin

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriverLoginExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var driverLoginModel = new DriverLoginModel(); // DriverLoginModel | Driver request login code model

            try
            {
                // [PRIVATE] Login with phone number and pin
                apiInstance.DriverLogin(driverLoginModel);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriverLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **driverLoginModel** | [**DriverLoginModel**](DriverLoginModel.md)| Driver request login code model | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="driverrequestlogincodesms"></a>
# **DriverRequestLoginCodeSms**
> void DriverRequestLoginCodeSms (DriverRequestLoginPinModel driverRequestLoginPinModel)

[PRIVATE] Request an SMS to be sent to the driver with their login code

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriverRequestLoginCodeSmsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var driverRequestLoginPinModel = new DriverRequestLoginPinModel(); // DriverRequestLoginPinModel | Driver request login code model

            try
            {
                // [PRIVATE] Request an SMS to be sent to the driver with their login code
                apiInstance.DriverRequestLoginCodeSms(driverRequestLoginPinModel);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriverRequestLoginCodeSms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **driverRequestLoginPinModel** | [**DriverRequestLoginPinModel**](DriverRequestLoginPinModel.md)| Driver request login code model | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdriverprofile"></a>
# **GetDriverProfile**
> RestApiResultDriver GetDriverProfile ()

Get driver profile

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetDriverProfileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();

            try
            {
                // Get driver profile
                RestApiResultDriver result = apiInstance.GetDriverProfile();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.GetDriverProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiResultDriver**](RestApiResultDriver.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoresfordriver"></a>
# **GetStoresForDriver**
> RestApiArrayResultDriverStore GetStoresForDriver ()

Get stores for driver

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoresForDriverExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();

            try
            {
                // Get stores for driver
                RestApiArrayResultDriverStore result = apiInstance.GetStoresForDriver();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.GetStoresForDriver: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiArrayResultDriverStore**](RestApiArrayResultDriverStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removedrivernotificationtoken"></a>
# **RemoveDriverNotificationToken**
> void RemoveDriverNotificationToken (UpdateDriverNotificationToken removeDriverToken)

Delete driver token

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RemoveDriverNotificationTokenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var removeDriverToken = new UpdateDriverNotificationToken(); // UpdateDriverNotificationToken | 

            try
            {
                // Delete driver token
                apiInstance.RemoveDriverNotificationToken(removeDriverToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.RemoveDriverNotificationToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **removeDriverToken** | [**UpdateDriverNotificationToken**](UpdateDriverNotificationToken.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdriverpresenceforstore"></a>
# **SetDriverPresenceForStore**
> void SetDriverPresenceForStore (int? storeId, string presence)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetDriverPresenceForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var storeId = 56;  // int? | 
            var presence = presence_example;  // string | 

            try
            {
                apiInstance.SetDriverPresenceForStore(storeId, presence);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.SetDriverPresenceForStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **presence** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdriverprofileimage"></a>
# **SetDriverProfileImage**
> RestApiStringResult SetDriverProfileImage ()

Set driver profile image and returns it's url

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetDriverProfileImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();

            try
            {
                // Set driver profile image and returns it's url
                RestApiStringResult result = apiInstance.SetDriverProfileImage();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.SetDriverProfileImage: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedeliverytrackingstatus"></a>
# **UpdateDeliveryTrackingStatus**
> RestApiStringResult UpdateDeliveryTrackingStatus (int? orderId, string deliveryTrackingStatus)

Change delivery tracking status and return the updated status.

...

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateDeliveryTrackingStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var orderId = 56;  // int? | Order identifier
            var deliveryTrackingStatus = deliveryTrackingStatus_example;  // string | 

            try
            {
                // Change delivery tracking status and return the updated status.
                RestApiStringResult result = apiInstance.UpdateDeliveryTrackingStatus(orderId, deliveryTrackingStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.UpdateDeliveryTrackingStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**| Order identifier | 
 **deliveryTrackingStatus** | **string**|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedriverprofile"></a>
# **UpdateDriverProfile**
> void UpdateDriverProfile (UpdateDriverProfileModel updateDriverProfile)

Update driver profile

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateDriverProfileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var updateDriverProfile = new UpdateDriverProfileModel(); // UpdateDriverProfileModel | Update the driver profile (i.e Name)

            try
            {
                // Update driver profile
                apiInstance.UpdateDriverProfile(updateDriverProfile);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.UpdateDriverProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateDriverProfile** | [**UpdateDriverProfileModel**](UpdateDriverProfileModel.md)| Update the driver profile (i.e Name) | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

