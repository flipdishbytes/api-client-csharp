# IO.Swagger.Api.LocationApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLocation**](LocationApi.md#createlocation) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location | Create a Location i.e: Table, Hotel Room, Car park space
[**DeleteLocation**](LocationApi.md#deletelocation) | **DELETE** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location/{locationId}/delete | Set a Location as deleted
[**MapLocationToExternalId**](LocationApi.md#maplocationtoexternalid) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location/{locationId}/map-external | Set or unset External Location Id on a Location
[**MoveLocation**](LocationApi.md#movelocation) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location/{locationId}/move | Move a Location to a different location Area
[**UpdateLocation**](LocationApi.md#updatelocation) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location/{locationId}/update | Update a Location i.e: Table, Hotel Room, Car park space


<a name="createlocation"></a>
# **CreateLocation**
> Object CreateLocation (List<CreateLocation> createLocationInput, int? locationAreaId, string appId, int? storeId)

Create a Location i.e: Table, Hotel Room, Car park space

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateLocationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var createLocationInput = new List<CreateLocation>(); // List<CreateLocation> | Input data for creating the Location
            var locationAreaId = 56;  // int? | Id of the Location area where the Location belongs
            var appId = appId_example;  // string | AppId i.e: (fd1234)
            var storeId = 56;  // int? | Id of the Store

            try
            {
                // Create a Location i.e: Table, Hotel Room, Car park space
                Object result = apiInstance.CreateLocation(createLocationInput, locationAreaId, appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.CreateLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createLocationInput** | [**List&lt;CreateLocation&gt;**](CreateLocation.md)| Input data for creating the Location | 
 **locationAreaId** | **int?**| Id of the Location area where the Location belongs | 
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

<a name="deletelocation"></a>
# **DeleteLocation**
> Object DeleteLocation (int? locationId, int? locationAreaId, string appId, int? storeId)

Set a Location as deleted

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLocationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | Id of the Location that will be moved
            var locationAreaId = 56;  // int? | Id of the Location Area that the Location belong
            var appId = appId_example;  // string | AppId i.e: (fd1234)
            var storeId = 56;  // int? | Id of the Store

            try
            {
                // Set a Location as deleted
                Object result = apiInstance.DeleteLocation(locationId, locationAreaId, appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.DeleteLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **int?**| Id of the Location that will be moved | 
 **locationAreaId** | **int?**| Id of the Location Area that the Location belong | 
 **appId** | **string**| AppId i.e: (fd1234) | 
 **storeId** | **int?**| Id of the Store | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="maplocationtoexternalid"></a>
# **MapLocationToExternalId**
> RestApiResultMappedLocation MapLocationToExternalId (int? locationId, int? locationAreaId, string appId, int? storeId, string externalLocationId = null)

Set or unset External Location Id on a Location

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapLocationToExternalIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | Id of the Location that will be mapped
            var locationAreaId = 56;  // int? | Id of the Location Area that the Location belong
            var appId = appId_example;  // string | AppId i.e: (fd1234)
            var storeId = 56;  // int? | Id of the Store
            var externalLocationId = externalLocationId_example;  // string | External Id to be mapped to the location (optional) 

            try
            {
                // Set or unset External Location Id on a Location
                RestApiResultMappedLocation result = apiInstance.MapLocationToExternalId(locationId, locationAreaId, appId, storeId, externalLocationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.MapLocationToExternalId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **int?**| Id of the Location that will be mapped | 
 **locationAreaId** | **int?**| Id of the Location Area that the Location belong | 
 **appId** | **string**| AppId i.e: (fd1234) | 
 **storeId** | **int?**| Id of the Store | 
 **externalLocationId** | **string**| External Id to be mapped to the location | [optional] 

### Return type

[**RestApiResultMappedLocation**](RestApiResultMappedLocation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movelocation"></a>
# **MoveLocation**
> Object MoveLocation (int? locationId, int? locationAreaId, int? newLocationAreaId, string appId, int? storeId)

Move a Location to a different location Area

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MoveLocationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | Id of the Location that will be moved
            var locationAreaId = 56;  // int? | Id of the new Location area that it should be moved to
            var newLocationAreaId = 56;  // int? | Id of the new Location area that it should be moved to
            var appId = appId_example;  // string | AppId i.e: (fd1234)
            var storeId = 56;  // int? | Id of the Store

            try
            {
                // Move a Location to a different location Area
                Object result = apiInstance.MoveLocation(locationId, locationAreaId, newLocationAreaId, appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.MoveLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **int?**| Id of the Location that will be moved | 
 **locationAreaId** | **int?**| Id of the new Location area that it should be moved to | 
 **newLocationAreaId** | **int?**| Id of the new Location area that it should be moved to | 
 **appId** | **string**| AppId i.e: (fd1234) | 
 **storeId** | **int?**| Id of the Store | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocation"></a>
# **UpdateLocation**
> RestApiResultLocationAreaLocation UpdateLocation (CreateLocation updateLocationInput, int? locationAreaId, int? locationId, string appId, int? storeId)

Update a Location i.e: Table, Hotel Room, Car park space

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateLocationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var updateLocationInput = new CreateLocation(); // CreateLocation | Input data for updating the Location
            var locationAreaId = 56;  // int? | Id of the Location area where the Location belongs
            var locationId = 56;  // int? | Id of the Location to be updated
            var appId = appId_example;  // string | AppId i.e: (fd1234)
            var storeId = 56;  // int? | Id of the Store

            try
            {
                // Update a Location i.e: Table, Hotel Room, Car park space
                RestApiResultLocationAreaLocation result = apiInstance.UpdateLocation(updateLocationInput, locationAreaId, locationId, appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.UpdateLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateLocationInput** | [**CreateLocation**](CreateLocation.md)| Input data for updating the Location | 
 **locationAreaId** | **int?**| Id of the Location area where the Location belongs | 
 **locationId** | **int?**| Id of the Location to be updated | 
 **appId** | **string**| AppId i.e: (fd1234) | 
 **storeId** | **int?**| Id of the Store | 

### Return type

[**RestApiResultLocationAreaLocation**](RestApiResultLocationAreaLocation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

