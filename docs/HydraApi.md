# Flipdish.Api.HydraApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAttachedDevices**](HydraApi.md#getattacheddevices) | **GET** /api/v1.0/{appId}/hydra/{deviceType}/list | [Private]
[**GetRegistration**](HydraApi.md#getregistration) | **GET** /api/v1.0/hydra/registration | 
[**GetSettings**](HydraApi.md#getsettings) | **GET** /api/v1.0/hydra/settings | [Private]
[**GetTerminalDetails**](HydraApi.md#getterminaldetails) | **GET** /api/v1.0/{appId}/hydra/terminal | [Private]
[**LoginWithDeviceId**](HydraApi.md#loginwithdeviceid) | **POST** /api/v1.0/hydra/{deviceId}/login | [Private]
[**Register**](HydraApi.md#register) | **POST** /api/v1.0/{appId}/hydra/registration | [Private]
[**UnAssign**](HydraApi.md#unassign) | **DELETE** /api/v1.0/{appId}/hydra/{deviceId}/registration | [Private]


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

<a name="getterminaldetails"></a>
# **GetTerminalDetails**
> RestApiResultPaymentTerminalDetails GetTerminalDetails (string appId)

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
    public class GetTerminalDetailsExample
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
                RestApiResultPaymentTerminalDetails result = apiInstance.GetTerminalDetails(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HydraApi.GetTerminalDetails: " + e.Message );
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

<a name="loginwithdeviceid"></a>
# **LoginWithDeviceId**
> void LoginWithDeviceId (string deviceId, string hydraUserType = null)

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

            try
            {
                // [Private]
                apiInstance.LoginWithDeviceId(deviceId, hydraUserType);
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

