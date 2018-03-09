# Flipdish.Api.MenuSectionsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMenuSection**](MenuSectionsApi.md#createmenusection) | **POST** /api/v1.0/menus/{menuId}/sections | Create menu section
[**DeleteMenuSection**](MenuSectionsApi.md#deletemenusection) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId} | Delete menu section
[**DeleteMenuSectionImage**](MenuSectionsApi.md#deletemenusectionimage) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/image | Delete menu section image
[**GetMenuSectionById**](MenuSectionsApi.md#getmenusectionbyid) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId} | Get menu section by identifier
[**GetMenuSections**](MenuSectionsApi.md#getmenusections) | **GET** /api/v1.0/menus/{menuId}/sections | Get menu sections
[**UpdateMenuSection**](MenuSectionsApi.md#updatemenusection) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId} | Update menu section
[**UploadMenuSectionImage**](MenuSectionsApi.md#uploadmenusectionimage) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/image | Upload menu section image


<a name="createmenusection"></a>
# **CreateMenuSection**
> Object CreateMenuSection (int? menuId, FlipdishPublicModelsV1MenusMenuSectionBase menuSection)

Create menu section

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateMenuSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSection = new FlipdishPublicModelsV1MenusMenuSectionBase(); // FlipdishPublicModelsV1MenusMenuSectionBase | Menu section

            try
            {
                // Create menu section
                Object result = apiInstance.CreateMenuSection(menuId, menuSection);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionsApi.CreateMenuSection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSection** | [**FlipdishPublicModelsV1MenusMenuSectionBase**](FlipdishPublicModelsV1MenusMenuSectionBase.md)| Menu section | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenusection"></a>
# **DeleteMenuSection**
> void DeleteMenuSection (int? menuId, int? menuSectionId)

Delete menu section

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier

            try
            {
                // Delete menu section
                apiInstance.DeleteMenuSection(menuId, menuSectionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionsApi.DeleteMenuSection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenusectionimage"></a>
# **DeleteMenuSectionImage**
> void DeleteMenuSectionImage (int? menuId, int? menuSectionId)

Delete menu section image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuSectionImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier

            try
            {
                // Delete menu section image
                apiInstance.DeleteMenuSectionImage(menuId, menuSectionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionsApi.DeleteMenuSectionImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenusectionbyid"></a>
# **GetMenuSectionById**
> FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1MenusMenuSection GetMenuSectionById (int? menuId, int? menuSectionId)

Get menu section by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuSectionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier

            try
            {
                // Get menu section by identifier
                FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1MenusMenuSection result = apiInstance.GetMenuSectionById(menuId, menuSectionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionsApi.GetMenuSectionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1MenusMenuSection**](FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1MenusMenuSection.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenusections"></a>
# **GetMenuSections**
> FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSection GetMenuSections (int? menuId)

Get menu sections

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuSectionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionsApi();
            var menuId = 56;  // int? | Menu identifier

            try
            {
                // Get menu sections
                FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSection result = apiInstance.GetMenuSections(menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionsApi.GetMenuSections: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSection**](FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSection.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemenusection"></a>
# **UpdateMenuSection**
> void UpdateMenuSection (int? menuId, int? menuSectionId, MenuSectionBase menuSection)

Update menu section

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateMenuSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSection = new MenuSectionBase(); // MenuSectionBase | Menu section changes (delta)

            try
            {
                // Update menu section
                apiInstance.UpdateMenuSection(menuId, menuSectionId, menuSection);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionsApi.UpdateMenuSection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **menuSection** | [**MenuSectionBase**](MenuSectionBase.md)| Menu section changes (delta) | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadmenusectionimage"></a>
# **UploadMenuSectionImage**
> FlipdishPublicModelsV1ApiResultsRestApiStringResult UploadMenuSectionImage (int? menuId, int? menuSectionId, System.IO.Stream image)

Upload menu section image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadMenuSectionImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var image = new System.IO.Stream(); // System.IO.Stream | Menu section image

            try
            {
                // Upload menu section image
                FlipdishPublicModelsV1ApiResultsRestApiStringResult result = apiInstance.UploadMenuSectionImage(menuId, menuSectionId, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionsApi.UploadMenuSectionImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **menuSectionId** | **int?**| Menu section identifier | 
 **image** | **System.IO.Stream**| Menu section image | 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiStringResult**](FlipdishPublicModelsV1ApiResultsRestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

