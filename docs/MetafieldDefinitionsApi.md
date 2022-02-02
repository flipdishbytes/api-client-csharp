# Flipdish.Api.MetafieldDefinitionsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMetafieldDefinition**](MetafieldDefinitionsApi.md#createmetafielddefinition) | **POST** /api/v1.0/{appId}/metafields/definitions/{ownerEntity} | Create a Metafield Definition
[**GetMetafieldDefinitions**](MetafieldDefinitionsApi.md#getmetafielddefinitions) | **GET** /api/v1.0/{appId}/metafields/definitions/{ownerEntity} | Get {Flipdish.PublicModels.V1.Metafields.MetafieldDefinition}s for the specified {Flipdish.PublicModels.V1.Metafields.OwnerEntity}
[**GetOwnerEntityConfigurations**](MetafieldDefinitionsApi.md#getownerentityconfigurations) | **GET** /api/v1.0/{appId}/metafields/definitions | Get OwnerEntity Configurations which contain information to manage Metafield Definitions
[**UpdateMetafieldDefinition**](MetafieldDefinitionsApi.md#updatemetafielddefinition) | **POST** /api/v1.0/{appId}/metafields/definitions/{ownerEntity}/{key} | Create a Metafield Definition


<a name="createmetafielddefinition"></a>
# **CreateMetafieldDefinition**
> RestApiResultMetafieldDefinition CreateMetafieldDefinition (string appId, string ownerEntity, CreateMetafieldDefinition createMetafieldDefinition)

Create a Metafield Definition

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
    public class CreateMetafieldDefinitionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MetafieldDefinitionsApi();
            var appId = appId_example;  // string | 
            var ownerEntity = ownerEntity_example;  // string | 
            var createMetafieldDefinition = new CreateMetafieldDefinition(); // CreateMetafieldDefinition | 

            try
            {
                // Create a Metafield Definition
                RestApiResultMetafieldDefinition result = apiInstance.CreateMetafieldDefinition(appId, ownerEntity, createMetafieldDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetafieldDefinitionsApi.CreateMetafieldDefinition: " + e.Message );
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
 **createMetafieldDefinition** | [**CreateMetafieldDefinition**](CreateMetafieldDefinition.md)|  | 

### Return type

[**RestApiResultMetafieldDefinition**](RestApiResultMetafieldDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetafielddefinitions"></a>
# **GetMetafieldDefinitions**
> RestApiPaginationResultMetafieldDefinition GetMetafieldDefinitions (string appId, string ownerEntity, string searchTerm = null, int? page = null, int? limit = null)

Get {Flipdish.PublicModels.V1.Metafields.MetafieldDefinition}s for the specified {Flipdish.PublicModels.V1.Metafields.OwnerEntity}

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
                // Get {Flipdish.PublicModels.V1.Metafields.MetafieldDefinition}s for the specified {Flipdish.PublicModels.V1.Metafields.OwnerEntity}
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

<a name="getownerentityconfigurations"></a>
# **GetOwnerEntityConfigurations**
> OwnerEntityConfigurations GetOwnerEntityConfigurations (string appId)

Get OwnerEntity Configurations which contain information to manage Metafield Definitions

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
    public class GetOwnerEntityConfigurationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MetafieldDefinitionsApi();
            var appId = appId_example;  // string | 

            try
            {
                // Get OwnerEntity Configurations which contain information to manage Metafield Definitions
                OwnerEntityConfigurations result = apiInstance.GetOwnerEntityConfigurations(appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetafieldDefinitionsApi.GetOwnerEntityConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 

### Return type

[**OwnerEntityConfigurations**](OwnerEntityConfigurations.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemetafielddefinition"></a>
# **UpdateMetafieldDefinition**
> RestApiResultMetafieldDefinition UpdateMetafieldDefinition (string appId, string ownerEntity, string key, UpdateMetafieldDefinition updateMetafieldDefinition)

Create a Metafield Definition

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
    public class UpdateMetafieldDefinitionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MetafieldDefinitionsApi();
            var appId = appId_example;  // string | 
            var ownerEntity = ownerEntity_example;  // string | 
            var key = key_example;  // string | 
            var updateMetafieldDefinition = new UpdateMetafieldDefinition(); // UpdateMetafieldDefinition | 

            try
            {
                // Create a Metafield Definition
                RestApiResultMetafieldDefinition result = apiInstance.UpdateMetafieldDefinition(appId, ownerEntity, key, updateMetafieldDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetafieldDefinitionsApi.UpdateMetafieldDefinition: " + e.Message );
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
 **key** | **string**|  | 
 **updateMetafieldDefinition** | [**UpdateMetafieldDefinition**](UpdateMetafieldDefinition.md)|  | 

### Return type

[**RestApiResultMetafieldDefinition**](RestApiResultMetafieldDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

