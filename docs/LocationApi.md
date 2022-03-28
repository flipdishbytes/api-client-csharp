# Flipdish.Api.LocationApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLocation**](LocationApi.md#createlocation) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location | Create a Location i.e: Table, Hotel Room, Car park space
[**UpdateLocation**](LocationApi.md#updatelocation) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location/{locationId}/update | Update a Location i.e: Table, Hotel Room, Car park space


<a name="createlocation"></a>
# **CreateLocation**
> Object CreateLocation (CreateLocation createLocationInput, int? locationAreaId, string appId, int? storeId)

Create a Location i.e: Table, Hotel Room, Car park space

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateLocationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var createLocationInput = new CreateLocation(); // CreateLocation | Input data for creating the Location
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
 **createLocationInput** | [**CreateLocation**](CreateLocation.md)| Input data for creating the Location | 
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

<a name="updatelocation"></a>
# **UpdateLocation**
> LocationAreaLocation UpdateLocation (CreateLocation updateLocationInput, int? locationAreaId, int? locationId, string appId, int? storeId)

Update a Location i.e: Table, Hotel Room, Car park space

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

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
                LocationAreaLocation result = apiInstance.UpdateLocation(updateLocationInput, locationAreaId, locationId, appId, storeId);
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

[**LocationAreaLocation**](LocationAreaLocation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

