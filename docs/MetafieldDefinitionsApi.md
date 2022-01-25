# Flipdish.Api.MetafieldDefinitionsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMetafieldDefinitions**](MetafieldDefinitionsApi.md#getmetafielddefinitions) | **GET** /api/v1.0/{appId}/metafields/definitions/{ownerEntity} | Get paginated groups by app name id filtered by types


<a name="getmetafielddefinitions"></a>
# **GetMetafieldDefinitions**
> RestApiPaginationResultMetafieldDefinition GetMetafieldDefinitions (string appId, string ownerEntity, string searchTerm = null, int? page = null, int? limit = null)

Get paginated groups by app name id filtered by types

[BETA - this endpoint is under development, do not use it in your production system]

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMetafieldDefinitionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MetafieldDefinitionsApi();
            var appId = appId_example;  // string | 
            var ownerEntity = ownerEntity_example;  // string | 
            var searchTerm = searchTerm_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Get paginated groups by app name id filtered by types
                RestApiPaginationResultMetafieldDefinition result = apiInstance.GetMetafieldDefinitions(appId, ownerEntity, searchTerm, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetafieldDefinitionsApi.GetMetafieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **ownerEntity** | **string**|  | 
 **searchTerm** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultMetafieldDefinition**](RestApiPaginationResultMetafieldDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

