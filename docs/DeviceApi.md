# Flipdish.Api.DeviceApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignDevice**](DeviceApi.md#assigndevice) | **POST** /api/v1.0/{appId}/devices/assign | Assign device to AppId. Device must have been enrolled before
[**EnrollDevice**](DeviceApi.md#enrolldevice) | **POST** /api/v1.0/{appId}/devices/enroll | Enroll a new device - this returns a PIN code for actually assigning it later
[**GetDeviceDetails**](DeviceApi.md#getdevicedetails) | **GET** /api/v1.0/{appId}/devices/device/{deviceModel}/{deviceId} | Get details for a device by model and deviceid
[**SearchDevices**](DeviceApi.md#searchdevices) | **GET** /api/v1.0/{appId}/devices/search | Search devices by AppId and optionally storeId


<a name="assigndevice"></a>
# **AssignDevice**
> RestApiResultClientDeviceEnrollmentResult AssignDevice (string appId, ClientDeviceAssignEnrolledDevice assignDeviceRequest)

Assign device to AppId. Device must have been enrolled before

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AssignDeviceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeviceApi();
            var appId = appId_example;  // string | App Id
            var assignDeviceRequest = new ClientDeviceAssignEnrolledDevice(); // ClientDeviceAssignEnrolledDevice | Assign request

            try
            {
                // Assign device to AppId. Device must have been enrolled before
                RestApiResultClientDeviceEnrollmentResult result = apiInstance.AssignDevice(appId, assignDeviceRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.AssignDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Id | 
 **assignDeviceRequest** | [**ClientDeviceAssignEnrolledDevice**](ClientDeviceAssignEnrolledDevice.md)| Assign request | 

### Return type

[**RestApiResultClientDeviceEnrollmentResult**](RestApiResultClientDeviceEnrollmentResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enrolldevice"></a>
# **EnrollDevice**
> RestApiResultClientDeviceEnrollmentResult EnrollDevice (string appId, ClientDeviceEnroll deviceEnrollmentRequest)

Enroll a new device - this returns a PIN code for actually assigning it later

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class EnrollDeviceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeviceApi();
            var appId = appId_example;  // string | App Id - not for the device, only for permission checking
            var deviceEnrollmentRequest = new ClientDeviceEnroll(); // ClientDeviceEnroll | Request object for enrolling device

            try
            {
                // Enroll a new device - this returns a PIN code for actually assigning it later
                RestApiResultClientDeviceEnrollmentResult result = apiInstance.EnrollDevice(appId, deviceEnrollmentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.EnrollDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Id - not for the device, only for permission checking | 
 **deviceEnrollmentRequest** | [**ClientDeviceEnroll**](ClientDeviceEnroll.md)| Request object for enrolling device | 

### Return type

[**RestApiResultClientDeviceEnrollmentResult**](RestApiResultClientDeviceEnrollmentResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevicedetails"></a>
# **GetDeviceDetails**
> RestApiResultClientDevice GetDeviceDetails (string appId, string deviceModel, string deviceId)

Get details for a device by model and deviceid

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetDeviceDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeviceApi();
            var appId = appId_example;  // string | App Id
            var deviceModel = deviceModel_example;  // string | Device Model
            var deviceId = deviceId_example;  // string | Device Id

            try
            {
                // Get details for a device by model and deviceid
                RestApiResultClientDevice result = apiInstance.GetDeviceDetails(appId, deviceModel, deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.GetDeviceDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Id | 
 **deviceModel** | **string**| Device Model | 
 **deviceId** | **string**| Device Id | 

### Return type

[**RestApiResultClientDevice**](RestApiResultClientDevice.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchdevices"></a>
# **SearchDevices**
> RestApiArrayResultClientDeviceSummary SearchDevices (string appId, int? storeId = null, string deviceModel = null)

Search devices by AppId and optionally storeId

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SearchDevicesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeviceApi();
            var appId = appId_example;  // string | App Id
            var storeId = 56;  // int? | Store Id (optional) (optional) 
            var deviceModel = deviceModel_example;  // string | Device Model (optional) (optional) 

            try
            {
                // Search devices by AppId and optionally storeId
                RestApiArrayResultClientDeviceSummary result = apiInstance.SearchDevices(appId, storeId, deviceModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceApi.SearchDevices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Id | 
 **storeId** | **int?**| Store Id (optional) | [optional] 
 **deviceModel** | **string**| Device Model (optional) | [optional] 

### Return type

[**RestApiArrayResultClientDeviceSummary**](RestApiArrayResultClientDeviceSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

