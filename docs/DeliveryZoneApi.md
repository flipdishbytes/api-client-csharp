# Flipdish.Api.DeliveryZoneApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDeliveryZone**](DeliveryZoneApi.md#adddeliveryzone) | **POST** /api/v1.0/stores/{storeId}/deliveryzones | 
[**GetDeliveryZones**](DeliveryZoneApi.md#getdeliveryzones) | **GET** /api/v1.0/stores/{storeId}/deliveryzones | 
[**RemoveDeliveryZone**](DeliveryZoneApi.md#removedeliveryzone) | **DELETE** /api/v1.0/stores/{storeId}/deliveryzones/{deliveryZoneId} | 
[**UpdateDeliveryZone**](DeliveryZoneApi.md#updatedeliveryzone) | **POST** /api/v1.0/stores/{storeId}/deliveryzones/{deliveryZoneId} | 


<a name="adddeliveryzone"></a>
# **AddDeliveryZone**
> RestApiResultDeliveryZone AddDeliveryZone (int? storeId, DeliveryZoneBase deliveryZoneBase)



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
            var storeId = 56;  // int? | 
            var deliveryZoneBase = new DeliveryZoneBase(); // DeliveryZoneBase | 

            try
            {
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
 **storeId** | **int?**|  | 
 **deliveryZoneBase** | [**DeliveryZoneBase**](DeliveryZoneBase.md)|  | 

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
            var storeId = 56;  // int? | 

            try
            {
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
 **storeId** | **int?**|  | 

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
            var storeId = 56;  // int? | 
            var deliveryZoneId = 56;  // int? | 

            try
            {
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
 **storeId** | **int?**|  | 
 **deliveryZoneId** | **int?**|  | 

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
            var storeId = 56;  // int? | 
            var deliveryZoneId = 56;  // int? | 
            var deliveryZone = new DeliveryZoneBase(); // DeliveryZoneBase | 

            try
            {
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
 **storeId** | **int?**|  | 
 **deliveryZoneId** | **int?**|  | 
 **deliveryZone** | [**DeliveryZoneBase**](DeliveryZoneBase.md)|  | 

### Return type

[**RestApiResultDeliveryZone**](RestApiResultDeliveryZone.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

