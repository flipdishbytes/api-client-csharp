# IO.Swagger.Api.CatalogImagesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UploadCatalogImage**](CatalogImagesApi.md#uploadcatalogimage) | **POST** /api/v1.0/{appId}/catalog/images | Upload a Catalog Image


<a name="uploadcatalogimage"></a>
# **UploadCatalogImage**
> CatalogImage UploadCatalogImage (string appId, System.IO.Stream image)

Upload a Catalog Image

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadCatalogImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogImagesApi();
            var appId = appId_example;  // string | 
            var image = new System.IO.Stream(); // System.IO.Stream | Catalog image

            try
            {
                // Upload a Catalog Image
                CatalogImage result = apiInstance.UploadCatalogImage(appId, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogImagesApi.UploadCatalogImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **image** | **System.IO.Stream**| Catalog image | 

### Return type

[**CatalogImage**](CatalogImage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

