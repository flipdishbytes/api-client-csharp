# Flipdish.Api.MenuSectionsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMenuSection**](MenuSectionsApi.md#createmenusection) | **POST** /api/v{apiVersion}/menus/{menuId}/sections | Create menu section
[**DeleteMenuSection**](MenuSectionsApi.md#deletemenusection) | **DELETE** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId} | Delete menu section
[**DeleteMenuSectionImage**](MenuSectionsApi.md#deletemenusectionimage) | **DELETE** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/image | Delete menu section image
[**GetMenuSectionById**](MenuSectionsApi.md#getmenusectionbyid) | **GET** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId} | Get menu section by identifier
[**GetMenuSections**](MenuSectionsApi.md#getmenusections) | **GET** /api/v{apiVersion}/menus/{menuId}/sections | Get menu sections
[**UpdateMenuSection**](MenuSectionsApi.md#updatemenusection) | **PATCH** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId} | Update menu section
[**UploadMenuSectionImage**](MenuSectionsApi.md#uploadmenusectionimage) | **POST** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/image | Upload menu section image


<a name="createmenusection"></a>
# **CreateMenuSection**
> Object CreateMenuSection (int? menuId, MenuSectionBase menuSection, string apiVersion)

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
            var menuSection = new MenuSectionBase(); // MenuSectionBase | Menu section
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Create menu section
                Object result = apiInstance.CreateMenuSection(menuId, menuSection, apiVersion);
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
 **menuSection** | [**MenuSectionBase**](MenuSectionBase.md)| Menu section | 
 **apiVersion** | **string**| API version | 

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
> void DeleteMenuSection (int? menuId, int? menuSectionId, string apiVersion)

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
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Delete menu section
                apiInstance.DeleteMenuSection(menuId, menuSectionId, apiVersion);
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
 **apiVersion** | **string**| API version | 

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
> void DeleteMenuSectionImage (int? menuId, int? menuSectionId, string apiVersion)

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
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Delete menu section image
                apiInstance.DeleteMenuSectionImage(menuId, menuSectionId, apiVersion);
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
 **apiVersion** | **string**| API version | 

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
> RestApiResultMenuSection GetMenuSectionById (int? menuId, int? menuSectionId, string apiVersion)

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
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get menu section by identifier
                RestApiResultMenuSection result = apiInstance.GetMenuSectionById(menuId, menuSectionId, apiVersion);
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
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiResultMenuSection**](RestApiResultMenuSection.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenusections"></a>
# **GetMenuSections**
> RestApiArrayResultMenuSection GetMenuSections (int? menuId, string apiVersion)

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
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get menu sections
                RestApiArrayResultMenuSection result = apiInstance.GetMenuSections(menuId, apiVersion);
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
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiArrayResultMenuSection**](RestApiArrayResultMenuSection.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemenusection"></a>
# **UpdateMenuSection**
> void UpdateMenuSection (int? menuId, MenuSectionBase menuSection, string apiVersion, string menuSectionId)

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
            var menuSection = new MenuSectionBase(); // MenuSectionBase | Menu section changes (delta)
            var apiVersion = apiVersion_example;  // string | API version
            var menuSectionId = menuSectionId_example;  // string | 

            try
            {
                // Update menu section
                apiInstance.UpdateMenuSection(menuId, menuSection, apiVersion, menuSectionId);
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
 **menuSection** | [**MenuSectionBase**](MenuSectionBase.md)| Menu section changes (delta) | 
 **apiVersion** | **string**| API version | 
 **menuSectionId** | **string**|  | 

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
> RestApiStringResult UploadMenuSectionImage (int? menuId, int? menuSectionId, string apiVersion, System.IO.Stream image)

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
            var apiVersion = apiVersion_example;  // string | API version
            var image = new System.IO.Stream(); // System.IO.Stream | Menu section image

            try
            {
                // Upload menu section image
                RestApiStringResult result = apiInstance.UploadMenuSectionImage(menuId, menuSectionId, apiVersion, image);
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
 **apiVersion** | **string**| API version | 
 **image** | **System.IO.Stream**| Menu section image | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

