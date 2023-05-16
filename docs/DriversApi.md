# Flipdish.Api.DriversApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DriversAddDriverNotificationToken**](DriversApi.md#driversadddrivernotificationtoken) | **POST** /api/v1.0/drivers/token | 
[**DriversDeleteDriverProfileImage**](DriversApi.md#driversdeletedriverprofileimage) | **DELETE** /api/v1.0/drivers/profile/image | 
[**DriversDriverLogin**](DriversApi.md#driversdriverlogin) | **POST** /api/v1.0/drivers/login | 
[**DriversDriverRequestLoginCodeSms**](DriversApi.md#driversdriverrequestlogincodesms) | **POST** /api/v1.0/drivers/pin | 
[**DriversGetDriverProfile**](DriversApi.md#driversgetdriverprofile) | **GET** /api/v1.0/drivers/profile | 
[**DriversGetStoresForDriver**](DriversApi.md#driversgetstoresfordriver) | **GET** /api/v1.0/drivers/assignedstores | 
[**DriversRemoveDriverNotificationToken**](DriversApi.md#driversremovedrivernotificationtoken) | **DELETE** /api/v1.0/drivers/token | 
[**DriversSetDriverPresenceForStore**](DriversApi.md#driverssetdriverpresenceforstore) | **POST** /api/v1.0/drivers/stores/{storeId}/presence/{presence} | 
[**DriversSetDriverProfileImage**](DriversApi.md#driverssetdriverprofileimage) | **POST** /api/v1.0/drivers/profile/image | 
[**DriversUpdateDeliveryTrackingStatus**](DriversApi.md#driversupdatedeliverytrackingstatus) | **POST** /api/v1.0/orders/{orderId}/tracking/{deliveryTrackingStatus} | 
[**DriversUpdateDriverProfile**](DriversApi.md#driversupdatedriverprofile) | **POST** /api/v1.0/drivers/profile | 


<a name="driversadddrivernotificationtoken"></a>
# **DriversAddDriverNotificationToken**
> Object DriversAddDriverNotificationToken (UpdateDriverNotificationToken updateDriverToken)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriversAddDriverNotificationTokenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var updateDriverToken = new UpdateDriverNotificationToken(); // UpdateDriverNotificationToken | 

            try
            {
                Object result = apiInstance.DriversAddDriverNotificationToken(updateDriverToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriversAddDriverNotificationToken: " + e.Message );
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

<a name="driversdeletedriverprofileimage"></a>
# **DriversDeleteDriverProfileImage**
> Object DriversDeleteDriverProfileImage ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriversDeleteDriverProfileImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();

            try
            {
                Object result = apiInstance.DriversDeleteDriverProfileImage();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriversDeleteDriverProfileImage: " + e.Message );
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

<a name="driversdriverlogin"></a>
# **DriversDriverLogin**
> Object DriversDriverLogin (DriverLoginModel driverLoginModel)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriversDriverLoginExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var driverLoginModel = new DriverLoginModel(); // DriverLoginModel | 

            try
            {
                Object result = apiInstance.DriversDriverLogin(driverLoginModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriversDriverLogin: " + e.Message );
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

<a name="driversdriverrequestlogincodesms"></a>
# **DriversDriverRequestLoginCodeSms**
> Object DriversDriverRequestLoginCodeSms (DriverRequestLoginPinModel driverRequestLoginPinModel)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriversDriverRequestLoginCodeSmsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var driverRequestLoginPinModel = new DriverRequestLoginPinModel(); // DriverRequestLoginPinModel | 

            try
            {
                Object result = apiInstance.DriversDriverRequestLoginCodeSms(driverRequestLoginPinModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriversDriverRequestLoginCodeSms: " + e.Message );
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

<a name="driversgetdriverprofile"></a>
# **DriversGetDriverProfile**
> Object DriversGetDriverProfile ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriversGetDriverProfileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();

            try
            {
                Object result = apiInstance.DriversGetDriverProfile();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriversGetDriverProfile: " + e.Message );
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

<a name="driversgetstoresfordriver"></a>
# **DriversGetStoresForDriver**
> Object DriversGetStoresForDriver ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriversGetStoresForDriverExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();

            try
            {
                Object result = apiInstance.DriversGetStoresForDriver();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriversGetStoresForDriver: " + e.Message );
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

<a name="driversremovedrivernotificationtoken"></a>
# **DriversRemoveDriverNotificationToken**
> Object DriversRemoveDriverNotificationToken (UpdateDriverNotificationToken removeDriverToken)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriversRemoveDriverNotificationTokenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var removeDriverToken = new UpdateDriverNotificationToken(); // UpdateDriverNotificationToken | 

            try
            {
                Object result = apiInstance.DriversRemoveDriverNotificationToken(removeDriverToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriversRemoveDriverNotificationToken: " + e.Message );
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

<a name="driverssetdriverpresenceforstore"></a>
# **DriversSetDriverPresenceForStore**
> Object DriversSetDriverPresenceForStore (int? storeId, string presence)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriversSetDriverPresenceForStoreExample
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
                Object result = apiInstance.DriversSetDriverPresenceForStore(storeId, presence);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriversSetDriverPresenceForStore: " + e.Message );
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

<a name="driverssetdriverprofileimage"></a>
# **DriversSetDriverProfileImage**
> Object DriversSetDriverProfileImage ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriversSetDriverProfileImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();

            try
            {
                Object result = apiInstance.DriversSetDriverProfileImage();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriversSetDriverProfileImage: " + e.Message );
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

<a name="driversupdatedeliverytrackingstatus"></a>
# **DriversUpdateDeliveryTrackingStatus**
> Object DriversUpdateDeliveryTrackingStatus (int? orderId, string deliveryTrackingStatus)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriversUpdateDeliveryTrackingStatusExample
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
                Object result = apiInstance.DriversUpdateDeliveryTrackingStatus(orderId, deliveryTrackingStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriversUpdateDeliveryTrackingStatus: " + e.Message );
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

<a name="driversupdatedriverprofile"></a>
# **DriversUpdateDriverProfile**
> Object DriversUpdateDriverProfile (UpdateDriverProfileModel updateDriverProfile)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DriversUpdateDriverProfileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DriversApi();
            var updateDriverProfile = new UpdateDriverProfileModel(); // UpdateDriverProfileModel | 

            try
            {
                Object result = apiInstance.DriversUpdateDriverProfile(updateDriverProfile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriversApi.DriversUpdateDriverProfile: " + e.Message );
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

