# Flipdish.Api.LocationAreasApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLocationArea**](LocationAreasApi.md#createlocationarea) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas | Create a Location Area, i.e: Room, Floor, Parking lot
[**GetLocationArea**](LocationAreasApi.md#getlocationarea) | **GET** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId} | Retrieve a Location Area
[**GetLocationsForStore**](LocationAreasApi.md#getlocationsforstore) | **GET** /api/v1.0/{appId}/stores/{storeId}/location-areas | Retrieve all Location Areas for a Store
[**UpdateLocationArea**](LocationAreasApi.md#updatelocationarea) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/update | Update a Location Area, i.e: Room, Floor, Car park space


<a name="createlocationarea"></a>
# **CreateLocationArea**
> Object CreateLocationArea (CreateLocationArea locationAreaInput, string appId, int? storeId)

Create a Location Area, i.e: Room, Floor, Parking lot

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
            var locationAreaInput = new CreateLocationArea(); // CreateLocationArea | Input data for creating the Location Area
            var appId = appId_example;  // string | AppId i.e: (fd1234)
            var storeId = 56;  // int? | Id of the Store

            try
            {
                // Create a Location Area, i.e: Room, Floor, Parking lot
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
 **locationAreaInput** | [**CreateLocationArea**](CreateLocationArea.md)| Input data for creating the Location Area | 
 **appId** | **string**| AppId i.e: (fd1234) | 
 **storeId** | **int?**| Id of the Store | 

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

Retrieve a Location Area

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
            var locationAreaId = 56;  // int? | Id of the Location Area
            var appId = appId_example;  // string | AppId i.e: (fd1234)
            var storeId = 56;  // int? | Id of the Store

            try
            {
                // Retrieve a Location Area
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
 **locationAreaId** | **int?**| Id of the Location Area | 
 **appId** | **string**| AppId i.e: (fd1234) | 
 **storeId** | **int?**| Id of the Store | 

### Return type

[**RestApiResultLocationAreaWithLocations**](RestApiResultLocationAreaWithLocations.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocationsforstore"></a>
# **GetLocationsForStore**
> RestApiArrayResultLocationAreaWithLocations GetLocationsForStore (string appId, int? storeId)

Retrieve all Location Areas for a Store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetLocationsForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationAreasApi();
            var appId = appId_example;  // string | AppId i.e: (fd1234)
            var storeId = 56;  // int? | Id of the Store

            try
            {
                // Retrieve all Location Areas for a Store
                RestApiArrayResultLocationAreaWithLocations result = apiInstance.GetLocationsForStore(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationAreasApi.GetLocationsForStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| AppId i.e: (fd1234) | 
 **storeId** | **int?**| Id of the Store | 

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
> LocationArea UpdateLocationArea (UpdateLocationArea locationAreaInput, string appId, int? storeId, string locationAreaId)

Update a Location Area, i.e: Room, Floor, Car park space

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
            var locationAreaInput = new UpdateLocationArea(); // UpdateLocationArea | Input data for updating the Location Area
            var appId = appId_example;  // string | AppId i.e: (fd1234)
            var storeId = 56;  // int? | Id of the Store
            var locationAreaId = locationAreaId_example;  // string | 

            try
            {
                // Update a Location Area, i.e: Room, Floor, Car park space
                LocationArea result = apiInstance.UpdateLocationArea(locationAreaInput, appId, storeId, locationAreaId);
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
 **locationAreaInput** | [**UpdateLocationArea**](UpdateLocationArea.md)| Input data for updating the Location Area | 
 **appId** | **string**| AppId i.e: (fd1234) | 
 **storeId** | **int?**| Id of the Store | 
 **locationAreaId** | **string**|  | 

### Return type

[**LocationArea**](LocationArea.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

