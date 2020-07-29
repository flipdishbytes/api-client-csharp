# Flipdish.Api.HydraApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignEmv**](HydraApi.md#assignemv) | **POST** /api/v1.0/{appId}/hydra/emvterminal/assign/{hydraConfigId}/{emvTerminalId} | Assign an EMV terminal to a kiosk
[**CancelEmvPayment**](HydraApi.md#cancelemvpayment) | **POST** /api/v1.0/{appId}/hydra/cancelemvpayment/{orderId} | 
[**GetAttachedDevices**](HydraApi.md#getattacheddevices) | **GET** /api/v1.0/{appId}/hydra/{deviceType}/list | [Private]
[**GetEMVTerminalDetails**](HydraApi.md#getemvterminaldetails) | **GET** /api/v1.0/{appId}/hydra/emvterminal | [Private]
[**GetEmvOrderState**](HydraApi.md#getemvorderstate) | **GET** /api/v1.0/{appId}/hydra/emvorderstate/{orderId} | [Private]
[**GetRegistration**](HydraApi.md#getregistration) | **GET** /api/v1.0/hydra/registration | 
[**GetSettings**](HydraApi.md#getsettings) | **GET** /api/v1.0/hydra/settings | [Private]
[**HydraCreateEmv**](HydraApi.md#hydracreateemv) | **POST** /api/v1.0/{appId}/emvterminals | [Private]
[**HydraDeleteEmv**](HydraApi.md#hydradeleteemv) | **DELETE** /api/v1.0/{appId}/emvterminals/{id} | [Private]
[**HydraGetEmvsForAppId**](HydraApi.md#hydragetemvsforappid) | **GET** /api/v1.0/{appId}/emvterminals | List EMV terminals belonging to the given AppNameId
[**LoginWithDeviceId**](HydraApi.md#loginwithdeviceid) | **POST** /api/v1.0/hydra/{deviceId}/login | [Private]
[**Register**](HydraApi.md#register) | **POST** /api/v1.0/{appId}/hydra/registration | [Private]
[**UnAssign**](HydraApi.md#unassign) | **DELETE** /api/v1.0/{appId}/hydra/{deviceId}/registration | [Private]
[**UnassignEmv**](HydraApi.md#unassignemv) | **POST** /api/v1.0/{appId}/hydra/emvterminal/unassign/{hydraConfigId} | Unassign the currently assigned EMV terminal from a kiosk


<a name="assignemv"></a>
# **AssignEmv**
> void AssignEmv (string appId, int? hydraConfigId, int? emvTerminalId)

Assign an EMV terminal to a kiosk

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
                // Assign an EMV terminal to a kiosk
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

<a name="getattacheddevices"></a>
# **GetAttachedDevices**
> RestApiPaginationResultHydraDeviceDetails GetAttachedDevices (string appId, string deviceType, int? pageIndex = null, int? pageSize = null, int? storeId = null, string deviceName = null, string deviceSerial = null)

[Private]

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
                // [Private]
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

[Private]

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
                // [Private]
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

[Private]

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
                // [Private]
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

[Private]

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
                // [Private]
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

[Private]

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
                // [Private]
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

[Private]

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
                // [Private]
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

<a name="hydragetemvsforappid"></a>
# **HydraGetEmvsForAppId**
> RestApiArrayResultEmvTerminalWithAssignments HydraGetEmvsForAppId (string appId)

List EMV terminals belonging to the given AppNameId

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
                // List EMV terminals belonging to the given AppNameId
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

[Private]

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
                // [Private]
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

[Private]

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
                // [Private]
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

[Private]

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
                // [Private]
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

Unassign the currently assigned EMV terminal from a kiosk

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
                // Unassign the currently assigned EMV terminal from a kiosk
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

