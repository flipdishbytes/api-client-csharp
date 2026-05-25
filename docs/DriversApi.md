# Flipdish.Api.DriversApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDriverNotificationToken**](DriversApi.md#adddrivernotificationtoken) | **POST** /api/v1.0/drivers/token | 
[**DeleteDriverProfileImage**](DriversApi.md#deletedriverprofileimage) | **DELETE** /api/v1.0/drivers/profile/image | 
[**DriverLogin**](DriversApi.md#driverlogin) | **POST** /api/v1.0/drivers/login | 
[**DriverRequestLoginCodeSms**](DriversApi.md#driverrequestlogincodesms) | **POST** /api/v1.0/drivers/pin | 
[**GetDriverProfile**](DriversApi.md#getdriverprofile) | **GET** /api/v1.0/drivers/profile | 
[**GetStoresForDriver**](DriversApi.md#getstoresfordriver) | **GET** /api/v1.0/drivers/assignedstores | 
[**RemoveDriverNotificationToken**](DriversApi.md#removedrivernotificationtoken) | **DELETE** /api/v1.0/drivers/token | 
[**SetDriverPresenceForStore**](DriversApi.md#setdriverpresenceforstore) | **POST** /api/v1.0/drivers/stores/{storeId}/presence/{presence} | 
[**SetDriverProfileImage**](DriversApi.md#setdriverprofileimage) | **POST** /api/v1.0/drivers/profile/image | 
[**UpdateDeliveryTrackingStatus**](DriversApi.md#updatedeliverytrackingstatus) | **POST** /api/v1.0/orders/{orderId}/tracking/{deliveryTrackingStatus} | 
[**UpdateDriverProfile**](DriversApi.md#updatedriverprofile) | **POST** /api/v1.0/drivers/profile | 


<a name="adddrivernotificationtoken"></a>
# **AddDriverNotificationToken**
> Object AddDriverNotificationToken (UpdateDriverNotificationToken updateDriverToken)



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
                Object result = apiInstance.AddDriverNotificationToken(updateDriverToken);
                Debug.WriteLine(result);
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedriverprofileimage"></a>
# **DeleteDriverProfileImage**
> Object DeleteDriverProfileImage ()



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
                Object result = apiInstance.DeleteDriverProfileImage();
                Debug.WriteLine(result);
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="driverlogin"></a>
# **DriverLogin**
> Object DriverLogin (DriverLoginModel driverLoginModel)



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
            var driverLoginModel = new DriverLoginModel(); // DriverLoginModel | 

            try
            {
                Object result = apiInstance.DriverLogin(driverLoginModel);
                Debug.WriteLine(result);
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
 **driverLoginModel** | [**DriverLoginModel**](DriverLoginModel.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="driverrequestlogincodesms"></a>
# **DriverRequestLoginCodeSms**
> Object DriverRequestLoginCodeSms (DriverRequestLoginPinModel driverRequestLoginPinModel)



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
            var driverRequestLoginPinModel = new DriverRequestLoginPinModel(); // DriverRequestLoginPinModel | 

            try
            {
                Object result = apiInstance.DriverRequestLoginCodeSms(driverRequestLoginPinModel);
                Debug.WriteLine(result);
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
 **driverRequestLoginPinModel** | [**DriverRequestLoginPinModel**](DriverRequestLoginPinModel.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdriverprofile"></a>
# **GetDriverProfile**
> Object GetDriverProfile ()



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
                Object result = apiInstance.GetDriverProfile();
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoresfordriver"></a>
# **GetStoresForDriver**
> Object GetStoresForDriver ()



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
                Object result = apiInstance.GetStoresForDriver();
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removedrivernotificationtoken"></a>
# **RemoveDriverNotificationToken**
> Object RemoveDriverNotificationToken (UpdateDriverNotificationToken removeDriverToken)



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
                Object result = apiInstance.RemoveDriverNotificationToken(removeDriverToken);
                Debug.WriteLine(result);
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdriverpresenceforstore"></a>
# **SetDriverPresenceForStore**
> Object SetDriverPresenceForStore (int? storeId, string presence)



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
                Object result = apiInstance.SetDriverPresenceForStore(storeId, presence);
                Debug.WriteLine(result);
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdriverprofileimage"></a>
# **SetDriverProfileImage**
> Object SetDriverProfileImage ()



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
                Object result = apiInstance.SetDriverProfileImage();
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedeliverytrackingstatus"></a>
# **UpdateDeliveryTrackingStatus**
> Object UpdateDeliveryTrackingStatus (int? orderId, string deliveryTrackingStatus)



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
            var orderId = 56;  // int? | 
            var deliveryTrackingStatus = deliveryTrackingStatus_example;  // string | 

            try
            {
                Object result = apiInstance.UpdateDeliveryTrackingStatus(orderId, deliveryTrackingStatus);
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
 **orderId** | **int?**|  | 
 **deliveryTrackingStatus** | **string**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedriverprofile"></a>
# **UpdateDriverProfile**
> Object UpdateDriverProfile (UpdateDriverProfileModel updateDriverProfile)



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
            var updateDriverProfile = new UpdateDriverProfileModel(); // UpdateDriverProfileModel | 

            try
            {
                Object result = apiInstance.UpdateDriverProfile(updateDriverProfile);
                Debug.WriteLine(result);
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
 **updateDriverProfile** | [**UpdateDriverProfileModel**](UpdateDriverProfileModel.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

