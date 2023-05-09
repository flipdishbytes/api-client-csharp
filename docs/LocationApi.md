# Flipdish.Api.LocationApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLocation**](LocationApi.md#createlocation) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location | 
[**DeleteLocation**](LocationApi.md#deletelocation) | **DELETE** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location/{locationId}/delete | 
[**MapLocationToExternalId**](LocationApi.md#maplocationtoexternalid) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location/{locationId}/map-external | 
[**MoveLocation**](LocationApi.md#movelocation) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location/{locationId}/move | 
[**UpdateLocation**](LocationApi.md#updatelocation) | **POST** /api/v1.0/{appId}/stores/{storeId}/location-areas/{locationAreaId}/location/{locationId}/update | 


<a name="createlocation"></a>
# **CreateLocation**
> Object CreateLocation (List<CreateLocation> createLocationInput, int? locationAreaId, string appId, int? storeId)



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
            var createLocationInput = new List<CreateLocation>(); // List<CreateLocation> | 
            var locationAreaId = 56;  // int? | 
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
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
 **createLocationInput** | [**List&lt;CreateLocation&gt;**](CreateLocation.md)|  | 
 **locationAreaId** | **int?**|  | 
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

<a name="deletelocation"></a>
# **DeleteLocation**
> Object DeleteLocation (int? locationId, int? locationAreaId, string appId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteLocationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | 
            var locationAreaId = 56;  // int? | 
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
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
 **locationId** | **int?**|  | 
 **locationAreaId** | **int?**|  | 
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 

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



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MapLocationToExternalIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | 
            var locationAreaId = 56;  // int? | 
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 
            var externalLocationId = externalLocationId_example;  // string |  (optional) 

            try
            {
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
 **locationId** | **int?**|  | 
 **locationAreaId** | **int?**|  | 
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 
 **externalLocationId** | **string**|  | [optional] 

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



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MoveLocationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var locationId = 56;  // int? | 
            var locationAreaId = 56;  // int? | 
            var newLocationAreaId = 56;  // int? | 
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
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
 **locationId** | **int?**|  | 
 **locationAreaId** | **int?**|  | 
 **newLocationAreaId** | **int?**|  | 
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 

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
            var updateLocationInput = new CreateLocation(); // CreateLocation | 
            var locationAreaId = 56;  // int? | 
            var locationId = 56;  // int? | 
            var appId = appId_example;  // string | 
            var storeId = 56;  // int? | 

            try
            {
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
 **updateLocationInput** | [**CreateLocation**](CreateLocation.md)|  | 
 **locationAreaId** | **int?**|  | 
 **locationId** | **int?**|  | 
 **appId** | **string**|  | 
 **storeId** | **int?**|  | 

### Return type

[**RestApiResultLocationAreaLocation**](RestApiResultLocationAreaLocation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

