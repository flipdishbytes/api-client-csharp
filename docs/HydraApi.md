# Flipdish.Api.HydraApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignEmv**](HydraApi.md#assignemv) | **POST** /api/v1.0/{appId}/hydra/emvterminal/assign/{hydraConfigId}/{emvTerminalId} | 
[**AttachStoreToKiosk**](HydraApi.md#attachstoretokiosk) | **POST** /api/v1.0/{appId}/AttachStoreToKiosk/{deviceId}/store/{storeId} | 
[**AttachStoreToTerminal**](HydraApi.md#attachstoretoterminal) | **POST** /api/v1.0/{appId}/hydra/{deviceId}/attach/{storeId} | 
[**CancelEmvPayment**](HydraApi.md#cancelemvpayment) | **POST** /api/v1.0/{appId}/hydra/cancelemvpayment/{orderId} | 
[**DetachStoreFromTerminal**](HydraApi.md#detachstorefromterminal) | **POST** /api/v1.0/{appId}/hydra/{deviceId}/detach/{storeId} | 
[**GetAblyToken**](HydraApi.md#getablytoken) | **GET** /api/v1.0/hydra/ably_token | 
[**GetAttachedDevice**](HydraApi.md#getattacheddevice) | **GET** /api/v1.0/{appId}/hydra/{deviceType}/{deviceId} | 
[**GetAttachedDevices**](HydraApi.md#getattacheddevices) | **GET** /api/v1.0/{appId}/hydra/{deviceType}/list | 
[**GetEMVTerminalDetails**](HydraApi.md#getemvterminaldetails) | **GET** /api/v1.0/{appId}/hydra/emvterminal | 
[**GetEmvOrderState**](HydraApi.md#getemvorderstate) | **GET** /api/v1.0/{appId}/hydra/emvorderstate/{orderId} | 
[**GetKioskCashPaymentSettings**](HydraApi.md#getkioskcashpaymentsettings) | **GET** /api/v1.0/{appId}/kioskcashsettings/{deviceId} | 
[**GetKioskSettings**](HydraApi.md#getkiosksettings) | **GET** /api/v1.0/{appId}/kiosksettings/{deviceId} | 
[**GetRegistration**](HydraApi.md#getregistration) | **GET** /api/v1.0/hydra/registration | 
[**GetSettings**](HydraApi.md#getsettings) | **GET** /api/v1.0/hydra/settings | 
[**HydraCreateEmv**](HydraApi.md#hydracreateemv) | **POST** /api/v1.0/{appId}/emvterminals | 
[**HydraDeleteEmv**](HydraApi.md#hydradeleteemv) | **DELETE** /api/v1.0/{appId}/emvterminals/{id} | 
[**HydraDetachStoreFromKiosk**](HydraApi.md#hydradetachstorefromkiosk) | **DELETE** /api/v1.0/{appId}/DetachStoreFromKiosk/{deviceId}/store/{storeId} | 
[**HydraGetEmvsForAppId**](HydraApi.md#hydragetemvsforappid) | **GET** /api/v1.0/{appId}/emvterminals | 
[**LoginWithDeviceId**](HydraApi.md#loginwithdeviceid) | **POST** /api/v1.0/hydra/{deviceId}/login | 
[**Register**](HydraApi.md#register) | **POST** /api/v1.0/{appId}/hydra/registration | 
[**UnAssign**](HydraApi.md#unassign) | **DELETE** /api/v1.0/{appId}/hydra/{deviceId}/registration | 
[**UnassignEmv**](HydraApi.md#unassignemv) | **POST** /api/v1.0/{appId}/hydra/emvterminal/unassign/{hydraConfigId} | 
[**UpdateKioskCashVisibilitySettings**](HydraApi.md#updatekioskcashvisibilitysettings) | **POST** /api/v1.0/{appId}/kioskupdatecashsettings | 
[**UpdateKioskSettings**](HydraApi.md#updatekiosksettings) | **POST** /api/v1.0/{appId}/kiosksettings/{deviceId} | 


<a name="assignemv"></a>
# **AssignEmv**
> void AssignEmv (string appId, int? hydraConfigId, int? emvTerminalId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AssignEmvExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var hydraConfigId = 56;  // int? | 
            var emvTerminalId = 56;  // int? | 

            try
            {
                apiInstance.AssignEmv(appId, hydraConfigId, emvTerminalId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.AssignEmv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **hydraConfigId** | **int?**|  | 
 **emvTerminalId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachstoretokiosk"></a>
# **AttachStoreToKiosk**
> RestApiResultHydraStatus AttachStoreToKiosk (string appId, int? storeId, string deviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AttachStoreToKioskExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 
            var deviceId = deviceId_example;  // string | 

            try
            {
                RestApiResultHydraStatus result = apiInstance.AttachStoreToKiosk(appId, storeId, deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.AttachStoreToKiosk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 
 **deviceId** | **string**|  | 

### Return type

[**RestApiResultHydraStatus**](RestApiResultHydraStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachstoretoterminal"></a>
# **AttachStoreToTerminal**
> RestApiResultHydraStatus AttachStoreToTerminal (string appId, string deviceId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AttachStoreToTerminalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultHydraStatus result = apiInstance.AttachStoreToTerminal(appId, deviceId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.AttachStoreToTerminal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 
 **storeId** | **int?**|  | 

### Return type

[**RestApiResultHydraStatus**](RestApiResultHydraStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelemvpayment"></a>
# **CancelEmvPayment**
> void CancelEmvPayment (int? orderId, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CancelEmvPaymentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var orderId = 56;  // int? | 
            var appId = appId_example;  // string | 

            try
            {
                apiInstance.CancelEmvPayment(orderId, appId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.CancelEmvPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**|  | 
 **appId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="detachstorefromterminal"></a>
# **DetachStoreFromTerminal**
> RestApiResultHydraStatus DetachStoreFromTerminal (string appId, string deviceId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DetachStoreFromTerminalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultHydraStatus result = apiInstance.DetachStoreFromTerminal(appId, deviceId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.DetachStoreFromTerminal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 
 **storeId** | **int?**|  | 

### Return type

[**RestApiResultHydraStatus**](RestApiResultHydraStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getablytoken"></a>
# **GetAblyToken**
> void GetAblyToken ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAblyTokenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();

            try
            {
                apiInstance.GetAblyToken();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.GetAblyToken: " + e.Message );
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

<a name="getattacheddevice"></a>
# **GetAttachedDevice**
> RestApiResultHydraDeviceDetails GetAttachedDevice (string appId, string deviceType, string deviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAttachedDeviceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var deviceType = deviceType_example;  // string | 
            var deviceId = deviceId_example;  // string | 

            try
            {
                RestApiResultHydraDeviceDetails result = apiInstance.GetAttachedDevice(appId, deviceType, deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.GetAttachedDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceType** | **string**|  | 
 **deviceId** | **string**|  | 

### Return type

[**RestApiResultHydraDeviceDetails**](RestApiResultHydraDeviceDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattacheddevices"></a>
# **GetAttachedDevices**
> RestApiPaginationResultHydraDeviceDetails GetAttachedDevices (string appId, string deviceType, int? pageIndex = null, int? pageSize = null, int? storeId = null, string deviceName = null, string deviceSerial = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAttachedDevicesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var deviceType = deviceType_example;  // string | 
            var pageIndex = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var storeId = 56;  // int? |  (optional) 
            var deviceName = deviceName_example;  // string |  (optional) 
            var deviceSerial = deviceSerial_example;  // string |  (optional) 

            try
            {
                RestApiPaginationResultHydraDeviceDetails result = apiInstance.GetAttachedDevices(appId, deviceType, pageIndex, pageSize, storeId, deviceName, deviceSerial);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.GetAttachedDevices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceType** | **string**|  | 
 **pageIndex** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **storeId** | **int?**|  | [optional] 
 **deviceName** | **string**|  | [optional] 
 **deviceSerial** | **string**|  | [optional] 

### Return type

[**RestApiPaginationResultHydraDeviceDetails**](RestApiPaginationResultHydraDeviceDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemvterminaldetails"></a>
# **GetEMVTerminalDetails**
> RestApiResultPaymentTerminalDetails GetEMVTerminalDetails (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetEMVTerminalDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultPaymentTerminalDetails result = apiInstance.GetEMVTerminalDetails(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.GetEMVTerminalDetails: " + e.Message );
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

[**RestApiResultPaymentTerminalDetails**](RestApiResultPaymentTerminalDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemvorderstate"></a>
# **GetEmvOrderState**
> RestApiResultPaymentTerminalTransactionDetails GetEmvOrderState (int? orderId, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetEmvOrderStateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var orderId = 56;  // int? | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultPaymentTerminalTransactionDetails result = apiInstance.GetEmvOrderState(orderId, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.GetEmvOrderState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultPaymentTerminalTransactionDetails**](RestApiResultPaymentTerminalTransactionDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkioskcashpaymentsettings"></a>
# **GetKioskCashPaymentSettings**
> RestApiArrayResultKioskCashPaymentSettings GetKioskCashPaymentSettings (string appId, string deviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetKioskCashPaymentSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 

            try
            {
                RestApiArrayResultKioskCashPaymentSettings result = apiInstance.GetKioskCashPaymentSettings(appId, deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.GetKioskCashPaymentSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 

### Return type

[**RestApiArrayResultKioskCashPaymentSettings**](RestApiArrayResultKioskCashPaymentSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkiosksettings"></a>
# **GetKioskSettings**
> RestApiResultKioskSettings GetKioskSettings (string appId, string deviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetKioskSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 

            try
            {
                RestApiResultKioskSettings result = apiInstance.GetKioskSettings(appId, deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.GetKioskSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 

### Return type

[**RestApiResultKioskSettings**](RestApiResultKioskSettings.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistration"></a>
# **GetRegistration**
> RestApiResultHydraStatus GetRegistration ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetRegistrationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();

            try
            {
                RestApiResultHydraStatus result = apiInstance.GetRegistration();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.GetRegistration: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiResultHydraStatus**](RestApiResultHydraStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsettings"></a>
# **GetSettings**
> RestApiResultHydraConfig GetSettings ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();

            try
            {
                RestApiResultHydraConfig result = apiInstance.GetSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.GetSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiResultHydraConfig**](RestApiResultHydraConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hydracreateemv"></a>
# **HydraCreateEmv**
> Object HydraCreateEmv (string appId, EmvTerminal emv)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class HydraCreateEmvExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var emv = new EmvTerminal(); // EmvTerminal | 

            try
            {
                Object result = apiInstance.HydraCreateEmv(appId, emv);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.HydraCreateEmv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **emv** | [**EmvTerminal**](EmvTerminal.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hydradeleteemv"></a>
# **HydraDeleteEmv**
> Object HydraDeleteEmv (string appId, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class HydraDeleteEmvExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var id = 56;  // int? | 

            try
            {
                Object result = apiInstance.HydraDeleteEmv(appId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.HydraDeleteEmv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **id** | **int?**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hydradetachstorefromkiosk"></a>
# **HydraDetachStoreFromKiosk**
> RestApiResultHydraStatus HydraDetachStoreFromKiosk (string appId, int? storeId, string deviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class HydraDetachStoreFromKioskExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 
            var deviceId = deviceId_example;  // string | 

            try
            {
                RestApiResultHydraStatus result = apiInstance.HydraDetachStoreFromKiosk(appId, storeId, deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.HydraDetachStoreFromKiosk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 
 **deviceId** | **string**|  | 

### Return type

[**RestApiResultHydraStatus**](RestApiResultHydraStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hydragetemvsforappid"></a>
# **HydraGetEmvsForAppId**
> RestApiArrayResultEmvTerminalWithAssignments HydraGetEmvsForAppId (string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class HydraGetEmvsForAppIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 

            try
            {
                RestApiArrayResultEmvTerminalWithAssignments result = apiInstance.HydraGetEmvsForAppId(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.HydraGetEmvsForAppId: " + e.Message );
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

[**RestApiArrayResultEmvTerminalWithAssignments**](RestApiArrayResultEmvTerminalWithAssignments.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loginwithdeviceid"></a>
# **LoginWithDeviceId**
> void LoginWithDeviceId (string deviceId, string hydraUserType = null, string serialNumber = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class LoginWithDeviceIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var deviceId = deviceId_example;  // string | 
            var hydraUserType = hydraUserType_example;  // string |  (optional) 
            var serialNumber = serialNumber_example;  // string |  (optional) 

            try
            {
                apiInstance.LoginWithDeviceId(deviceId, hydraUserType, serialNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.LoginWithDeviceId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**|  | 
 **hydraUserType** | **string**|  | [optional] 
 **serialNumber** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="register"></a>
# **Register**
> RestApiResultHydraStatus Register (string appId, HydraRegistrationRequest hydraRegistration)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RegisterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var hydraRegistration = new HydraRegistrationRequest(); // HydraRegistrationRequest | 

            try
            {
                RestApiResultHydraStatus result = apiInstance.Register(appId, hydraRegistration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.Register: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **hydraRegistration** | [**HydraRegistrationRequest**](HydraRegistrationRequest.md)|  | 

### Return type

[**RestApiResultHydraStatus**](RestApiResultHydraStatus.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassign"></a>
# **UnAssign**
> void UnAssign (string appId, string deviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UnAssignExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 

            try
            {
                apiInstance.UnAssign(appId, deviceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.UnAssign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassignemv"></a>
# **UnassignEmv**
> void UnassignEmv (string appId, int? hydraConfigId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UnassignEmvExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var hydraConfigId = 56;  // int? | 

            try
            {
                apiInstance.UnassignEmv(appId, hydraConfigId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.UnassignEmv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **hydraConfigId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatekioskcashvisibilitysettings"></a>
# **UpdateKioskCashVisibilitySettings**
> void UpdateKioskCashVisibilitySettings (string appId, string deviceId, bool? isCashEnabled)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateKioskCashVisibilitySettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 
            var isCashEnabled = true;  // bool? | 

            try
            {
                apiInstance.UpdateKioskCashVisibilitySettings(appId, deviceId, isCashEnabled);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.UpdateKioskCashVisibilitySettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 
 **isCashEnabled** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatekiosksettings"></a>
# **UpdateKioskSettings**
> void UpdateKioskSettings (string appId, string deviceId, KioskSettings settings)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateKioskSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HydraApi();
            var appId = appId_example;  // string | 
            var deviceId = deviceId_example;  // string | 
            var settings = new KioskSettings(); // KioskSettings | 

            try
            {
                apiInstance.UpdateKioskSettings(appId, deviceId, settings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.UpdateKioskSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **deviceId** | **string**|  | 
 **settings** | [**KioskSettings**](KioskSettings.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

