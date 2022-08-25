# Flipdish.Api.DeliveryZoneApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDeliveryZone**](DeliveryZoneApi.md#adddeliveryzone) | **POST** /api/v1.0/stores/{storeId}/deliveryzones | Adds a delivery zone to the store id
[**GetDeliveryZones**](DeliveryZoneApi.md#getdeliveryzones) | **GET** /api/v1.0/stores/{storeId}/deliveryzones | Get all the delivery zones associated with a store
[**RemoveDeliveryZone**](DeliveryZoneApi.md#removedeliveryzone) | **DELETE** /api/v1.0/stores/{storeId}/deliveryzones/{deliveryZoneId} | Removes the existing delivery zone
[**UpdateDeliveryZone**](DeliveryZoneApi.md#updatedeliveryzone) | **POST** /api/v1.0/stores/{storeId}/deliveryzones/{deliveryZoneId} | Updates the existing delivery zone


<a name="adddeliveryzone"></a>
# **AddDeliveryZone**
> RestApiResultDeliveryZone AddDeliveryZone (int? storeId, DeliveryZoneBase deliveryZoneBase)

Adds a delivery zone to the store id

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddDeliveryZoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeliveryZoneApi();
            var storeId = 56;  // int? | Store Id to which the delivery zone will be added
            var deliveryZoneBase = new DeliveryZoneBase(); // DeliveryZoneBase | Optional delivery zone, if not supplied will create a default zone

            try
            {
                // Adds a delivery zone to the store id
                RestApiResultDeliveryZone result = apiInstance.AddDeliveryZone(storeId, deliveryZoneBase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryZoneApi.AddDeliveryZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store Id to which the delivery zone will be added | 
 **deliveryZoneBase** | [**DeliveryZoneBase**](DeliveryZoneBase.md)| Optional delivery zone, if not supplied will create a default zone | 

### Return type

[**RestApiResultDeliveryZone**](RestApiResultDeliveryZone.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeliveryzones"></a>
# **GetDeliveryZones**
> RestApiArrayResultDeliveryZone GetDeliveryZones (int? storeId)

Get all the delivery zones associated with a store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetDeliveryZonesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeliveryZoneApi();
            var storeId = 56;  // int? | Store Id to which the delivery zones are associated

            try
            {
                // Get all the delivery zones associated with a store
                RestApiArrayResultDeliveryZone result = apiInstance.GetDeliveryZones(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryZoneApi.GetDeliveryZones: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store Id to which the delivery zones are associated | 

### Return type

[**RestApiArrayResultDeliveryZone**](RestApiArrayResultDeliveryZone.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removedeliveryzone"></a>
# **RemoveDeliveryZone**
> void RemoveDeliveryZone (int? storeId, int? deliveryZoneId)

Removes the existing delivery zone

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RemoveDeliveryZoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeliveryZoneApi();
            var storeId = 56;  // int? | Store Id to which the delivery zone belongs
            var deliveryZoneId = 56;  // int? | Delivery zone id to be removed

            try
            {
                // Removes the existing delivery zone
                apiInstance.RemoveDeliveryZone(storeId, deliveryZoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryZoneApi.RemoveDeliveryZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store Id to which the delivery zone belongs | 
 **deliveryZoneId** | **int?**| Delivery zone id to be removed | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedeliveryzone"></a>
# **UpdateDeliveryZone**
> RestApiResultDeliveryZone UpdateDeliveryZone (int? storeId, int? deliveryZoneId, DeliveryZoneBase deliveryZone)

Updates the existing delivery zone

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateDeliveryZoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DeliveryZoneApi();
            var storeId = 56;  // int? | Store Id to which the delivery zone belongs
            var deliveryZoneId = 56;  // int? | Delivery zone id to be updated
            var deliveryZone = new DeliveryZoneBase(); // DeliveryZoneBase | Delta of delivery zone parameters that need to be changed

            try
            {
                // Updates the existing delivery zone
                RestApiResultDeliveryZone result = apiInstance.UpdateDeliveryZone(storeId, deliveryZoneId, deliveryZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryZoneApi.UpdateDeliveryZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store Id to which the delivery zone belongs | 
 **deliveryZoneId** | **int?**| Delivery zone id to be updated | 
 **deliveryZone** | [**DeliveryZoneBase**](DeliveryZoneBase.md)| Delta of delivery zone parameters that need to be changed | 

### Return type

[**RestApiResultDeliveryZone**](RestApiResultDeliveryZone.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

