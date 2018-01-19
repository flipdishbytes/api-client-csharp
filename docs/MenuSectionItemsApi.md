# Flipdish.Api.MenuSectionItemsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMenuSectionItem**](MenuSectionItemsApi.md#createmenusectionitem) | **POST** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems | Create menu section item
[**DeleteMenuSectionItem**](MenuSectionItemsApi.md#deletemenusectionitem) | **DELETE** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | Delete menu section item
[**DeleteMenuSectionItemImage**](MenuSectionItemsApi.md#deletemenusectionitemimage) | **DELETE** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/image | Delete menu section item image
[**GetMenuItemById**](MenuSectionItemsApi.md#getmenuitembyid) | **GET** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | Get menu item by identifier
[**GetMenuItems**](MenuSectionItemsApi.md#getmenuitems) | **GET** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems | Get menu items
[**UpdateMenuSectionItem**](MenuSectionItemsApi.md#updatemenusectionitem) | **PATCH** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | Update menu section item
[**UploadMenuSectionItemImage**](MenuSectionItemsApi.md#uploadmenusectionitemimage) | **POST** /api/v{apiVersion}/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/image | Upload menu section item image


<a name="createmenusectionitem"></a>
# **CreateMenuSectionItem**
> Object CreateMenuSectionItem (int? menuId, int? menuSectionId, MenuSectionItemBase menuSectionItem, string apiVersion)

Create menu section item

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateMenuSectionItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItem = new MenuSectionItemBase(); // MenuSectionItemBase | Menu section item
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Create menu section item
                Object result = apiInstance.CreateMenuSectionItem(menuId, menuSectionId, menuSectionItem, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.CreateMenuSectionItem: " + e.Message );
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
 **menuSectionItem** | [**MenuSectionItemBase**](MenuSectionItemBase.md)| Menu section item | 
 **apiVersion** | **string**| API version | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenusectionitem"></a>
# **DeleteMenuSectionItem**
> void DeleteMenuSectionItem (int? menuId, int? menuSectionId, int? menuSectionItemId, string apiVersion)

Delete menu section item

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuSectionItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Delete menu section item
                apiInstance.DeleteMenuSectionItem(menuId, menuSectionId, menuSectionItemId, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.DeleteMenuSectionItem: " + e.Message );
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
 **menuSectionItemId** | **int?**| Menu section item identifier | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenusectionitemimage"></a>
# **DeleteMenuSectionItemImage**
> void DeleteMenuSectionItemImage (int? menuId, int? menuSectionId, int? menuSectionItemId, string apiVersion)

Delete menu section item image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuSectionItemImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Delete menu section item image
                apiInstance.DeleteMenuSectionItemImage(menuId, menuSectionId, menuSectionItemId, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.DeleteMenuSectionItemImage: " + e.Message );
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
 **menuSectionItemId** | **int?**| Menu section item identifier | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitembyid"></a>
# **GetMenuItemById**
> RestApiResultMenuSectionItem GetMenuItemById (int? menuId, int? menuSectionId, int? menuSectionItemId, string apiVersion)

Get menu item by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu item identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get menu item by identifier
                RestApiResultMenuSectionItem result = apiInstance.GetMenuItemById(menuId, menuSectionId, menuSectionItemId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.GetMenuItemById: " + e.Message );
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
 **menuSectionItemId** | **int?**| Menu item identifier | 
 **apiVersion** | **string**| API version | 

### Return type

[**RestApiResultMenuSectionItem**](RestApiResultMenuSectionItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitems"></a>
# **GetMenuItems**
> RestApiArrayResultMenuSectionItem GetMenuItems (int? menuId, int? menuSectionId, string apiVersion)

Get menu items

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Get menu items
                RestApiArrayResultMenuSectionItem result = apiInstance.GetMenuItems(menuId, menuSectionId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.GetMenuItems: " + e.Message );
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

[**RestApiArrayResultMenuSectionItem**](RestApiArrayResultMenuSectionItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemenusectionitem"></a>
# **UpdateMenuSectionItem**
> void UpdateMenuSectionItem (int? menuId, int? menuSectionId, int? menuSectionItemId, MenuSectionItemBase menuSectionItem, string apiVersion)

Update menu section item

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateMenuSectionItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var menuSectionItem = new MenuSectionItemBase(); // MenuSectionItemBase | Menu section item (delta)
            var apiVersion = apiVersion_example;  // string | API version

            try
            {
                // Update menu section item
                apiInstance.UpdateMenuSectionItem(menuId, menuSectionId, menuSectionItemId, menuSectionItem, apiVersion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.UpdateMenuSectionItem: " + e.Message );
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
 **menuSectionItemId** | **int?**| Menu section item identifier | 
 **menuSectionItem** | [**MenuSectionItemBase**](MenuSectionItemBase.md)| Menu section item (delta) | 
 **apiVersion** | **string**| API version | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadmenusectionitemimage"></a>
# **UploadMenuSectionItemImage**
> RestApiStringResult UploadMenuSectionItemImage (int? menuId, int? menuSectionId, int? menuSectionItemId, string apiVersion, System.IO.Stream image)

Upload menu section item image

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadMenuSectionItemImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuSectionItemsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var apiVersion = apiVersion_example;  // string | API version
            var image = new System.IO.Stream(); // System.IO.Stream | Menu section item image

            try
            {
                // Upload menu section item image
                RestApiStringResult result = apiInstance.UploadMenuSectionItemImage(menuId, menuSectionId, menuSectionItemId, apiVersion, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuSectionItemsApi.UploadMenuSectionItemImage: " + e.Message );
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
 **menuSectionItemId** | **int?**| Menu section item identifier | 
 **apiVersion** | **string**| API version | 
 **image** | **System.IO.Stream**| Menu section item image | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

