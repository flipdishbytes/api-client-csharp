# Flipdish.Api.LocationAreasApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLocationArea**](LocationAreasApi.md#createlocationarea) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas | 
[**GetLocationArea**](LocationAreasApi.md#getlocationarea) | **GET** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId} | 
[**GetLocationAreasForStore**](LocationAreasApi.md#getlocationareasforstore) | **GET** /api/v1.0/{appId}/stores/{storeId}/location-areas | 
[**UpdateLocationArea**](LocationAreasApi.md#updatelocationarea) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/update | 


<a name="createlocationarea"></a>
# **CreateLocationArea**
> Object CreateLocationArea (CreateLocationArea locationAreaInput, string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateLocationAreaExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationAreasApi();
            var locationAreaInput = new CreateLocationArea(); // CreateLocationArea | 
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                Object result = apiInstance.CreateLocationArea(locationAreaInput, appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAreasApi.CreateLocationArea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAreaInput** | [**CreateLocationArea**](CreateLocationArea.md)|  | 
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationarea"></a>
# **GetLocationArea**
> RestApiResultLocationAreaWithLocations GetLocationArea (int? locationAreaId, string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetLocationAreaExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationAreasApi();
            var locationAreaId = 56;  // int? | 
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultLocationAreaWithLocations result = apiInstance.GetLocationArea(locationAreaId, appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAreasApi.GetLocationArea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAreaId** | **int?**|  | 
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 

### Return type

[**RestApiResultLocationAreaWithLocations**](RestApiResultLocationAreaWithLocations.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationareasforstore"></a>
# **GetLocationAreasForStore**
> RestApiArrayResultLocationAreaWithLocations GetLocationAreasForStore (string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetLocationAreasForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationAreasApi();
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiArrayResultLocationAreaWithLocations result = apiInstance.GetLocationAreasForStore(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAreasApi.GetLocationAreasForStore: " + e.Message );
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

### Return type

[**RestApiArrayResultLocationAreaWithLocations**](RestApiArrayResultLocationAreaWithLocations.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocationarea"></a>
# **UpdateLocationArea**
> RestApiResultLocationArea UpdateLocationArea (UpdateLocationArea locationAreaInput, string appId, int? storeId, string locationAreaId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateLocationAreaExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationAreasApi();
            var locationAreaInput = new UpdateLocationArea(); // UpdateLocationArea | 
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 
            var locationAreaId = locationAreaId_example;  // string | 

            try
            {
                RestApiResultLocationArea result = apiInstance.UpdateLocationArea(locationAreaInput, appId, storeId, locationAreaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAreasApi.UpdateLocationArea: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationAreaInput** | [**UpdateLocationArea**](UpdateLocationArea.md)|  | 
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 
 **locationAreaId** | **string**|  | 

### Return type

[**RestApiResultLocationArea**](RestApiResultLocationArea.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

