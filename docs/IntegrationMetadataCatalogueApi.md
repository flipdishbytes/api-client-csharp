# Flipdish.Api.IntegrationMetadataCatalogueApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IntegrationMetadataCatalogueGetPixelPointProducts**](IntegrationMetadataCatalogueApi.md#integrationmetadatacataloguegetpixelpointproducts) | **GET** /api/v1.0/integrationmetadatacatalogue/pixelpoint/stores/{storeId}/products | 


<a name="integrationmetadatacataloguegetpixelpointproducts"></a>
# **IntegrationMetadataCatalogueGetPixelPointProducts**
> RestApiResultPixelPointProductCatalogue IntegrationMetadataCatalogueGetPixelPointProducts (int? storeId, string nameContains = null, int? page = null, int? pageSize = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class IntegrationMetadataCatalogueGetPixelPointProductsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IntegrationMetadataCatalogueApi();
            var storeId = 56;  // int? | 
            var nameContains = nameContains_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                RestApiResultPixelPointProductCatalogue result = apiInstance.IntegrationMetadataCatalogueGetPixelPointProducts(storeId, nameContains, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationMetadataCatalogueApi.IntegrationMetadataCatalogueGetPixelPointProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **nameContains** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

### Return type

[**RestApiResultPixelPointProductCatalogue**](RestApiResultPixelPointProductCatalogue.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

