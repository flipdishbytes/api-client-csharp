# Flipdish.Api.DeviceApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignDevice**](DeviceApi.md#assigndevice) | **POST** /api/v1.0/{appId}/devices/assign | 
[**EnrollDevice**](DeviceApi.md#enrolldevice) | **POST** /api/v1.0/{appId}/devices/enroll | 
[**GetDeviceDetails**](DeviceApi.md#getdevicedetails) | **GET** /api/v1.0/{appId}/devices/device/{deviceModel}/{deviceId} | 
[**SearchDevices**](DeviceApi.md#searchdevices) | **GET** /api/v1.0/{appId}/devices/search | 


<a name="assigndevice"></a>
# **AssignDevice**
> RestApiResultClientDeviceEnrollmentResult AssignDevice (string appId, ClientDeviceAssignEnrolledDevice assignDeviceRequest)



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
            var appId = appId_example;  // string | 
            var assignDeviceRequest = new ClientDeviceAssignEnrolledDevice(); // ClientDeviceAssignEnrolledDevice | 

            try
            {
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
 **appId** | **string**|  | 
 **assignDeviceRequest** | [**ClientDeviceAssignEnrolledDevice**](ClientDeviceAssignEnrolledDevice.md)|  | 

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
            var appId = appId_example;  // string | 
            var deviceEnrollmentRequest = new ClientDeviceEnroll(); // ClientDeviceEnroll | 

            try
            {
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
 **appId** | **string**|  | 
 **deviceEnrollmentRequest** | [**ClientDeviceEnroll**](ClientDeviceEnroll.md)|  | 

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
            var appId = appId_example;  // string | 
            var deviceModel = deviceModel_example;  // string | 
            var deviceId = deviceId_example;  // string | 

            try
            {
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
 **appId** | **string**|  | 
 **deviceModel** | **string**|  | 
 **deviceId** | **string**|  | 

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
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? |  (optional) 
            var deviceModel = deviceModel_example;  // string |  (optional) 

            try
            {
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
 **appId** | **string**|  | 
 **storeId** | **int?**|  | [optional] 
 **deviceModel** | **string**|  | [optional] 

### Return type

[**RestApiArrayResultClientDeviceSummary**](RestApiArrayResultClientDeviceSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

