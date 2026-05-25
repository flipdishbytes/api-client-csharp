# Flipdish.Api.MenuOptionSetsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMenuItemOptionSet**](MenuOptionSetsApi.md#createmenuitemoptionset) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets | 
[**DeleteMenuItemOptionSet**](MenuOptionSetsApi.md#deletemenuitemoptionset) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | 
[**DeleteOptionSetImage**](MenuOptionSetsApi.md#deleteoptionsetimage) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/image | 
[**GetMenuItemOptionSetById**](MenuOptionSetsApi.md#getmenuitemoptionsetbyid) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | Get menu item option set by identifier
[**GetMenuItemOptionSets**](MenuOptionSetsApi.md#getmenuitemoptionsets) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets | Get menu item option sets
[**UpdateMenuItemOptionSet**](MenuOptionSetsApi.md#updatemenuitemoptionset) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | 
[**UploadOptionSetImage**](MenuOptionSetsApi.md#uploadoptionsetimage) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/image | 


<a name="createmenuitemoptionset"></a>
# **CreateMenuItemOptionSet**
> Object CreateMenuItemOptionSet (int? menuId, int? menuSectionId, int? menuSectionItemId, MenuItemOptionSetBase menuItemOptionSet)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateMenuItemOptionSetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var menuItemOptionSet = new MenuItemOptionSetBase(); // MenuItemOptionSetBase | 

            try
            {
                Object result = apiInstance.CreateMenuItemOptionSet(menuId, menuSectionId, menuSectionItemId, menuItemOptionSet);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.CreateMenuItemOptionSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **menuItemOptionSet** | [**MenuItemOptionSetBase**](MenuItemOptionSetBase.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenuitemoptionset"></a>
# **DeleteMenuItemOptionSet**
> void DeleteMenuItemOptionSet (int? menuId, int? menuSectionItemId, int? menuSectionId, int? optionSetId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuItemOptionSetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var optionSetId = 56;  // int? | 

            try
            {
                apiInstance.DeleteMenuItemOptionSet(menuId, menuSectionItemId, menuSectionId, optionSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.DeleteMenuItemOptionSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **optionSetId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoptionsetimage"></a>
# **DeleteOptionSetImage**
> void DeleteOptionSetImage (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteOptionSetImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var optionSetId = 56;  // int? | 

            try
            {
                apiInstance.DeleteOptionSetImage(menuId, menuSectionId, menuSectionItemId, optionSetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.DeleteOptionSetImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **optionSetId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitemoptionsetbyid"></a>
# **GetMenuItemOptionSetById**
> RestApiResultMenuItemOptionSet GetMenuItemOptionSetById (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId)

Get menu item option set by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemOptionSetByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier
            var optionSetId = 56;  // int? | Menu item option set identifier

            try
            {
                // Get menu item option set by identifier
                RestApiResultMenuItemOptionSet result = apiInstance.GetMenuItemOptionSetById(menuId, menuSectionId, menuSectionItemId, optionSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.GetMenuItemOptionSetById: " + e.Message );
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
 **optionSetId** | **int?**| Menu item option set identifier | 

### Return type

[**RestApiResultMenuItemOptionSet**](RestApiResultMenuItemOptionSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuitemoptionsets"></a>
# **GetMenuItemOptionSets**
> RestApiArrayResultMenuItemOptionSet GetMenuItemOptionSets (int? menuId, int? menuSectionId, int? menuSectionItemId)

Get menu item option sets

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuItemOptionSetsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | Menu identifier
            var menuSectionId = 56;  // int? | Menu section identifier
            var menuSectionItemId = 56;  // int? | Menu section item identifier

            try
            {
                // Get menu item option sets
                RestApiArrayResultMenuItemOptionSet result = apiInstance.GetMenuItemOptionSets(menuId, menuSectionId, menuSectionItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.GetMenuItemOptionSets: " + e.Message );
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

### Return type

[**RestApiArrayResultMenuItemOptionSet**](RestApiArrayResultMenuItemOptionSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemenuitemoptionset"></a>
# **UpdateMenuItemOptionSet**
> void UpdateMenuItemOptionSet (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, MenuItemOptionSetBase menuItemOptionSet)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateMenuItemOptionSetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var optionSetId = 56;  // int? | 
            var menuItemOptionSet = new MenuItemOptionSetBase(); // MenuItemOptionSetBase | 

            try
            {
                apiInstance.UpdateMenuItemOptionSet(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSet);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.UpdateMenuItemOptionSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **optionSetId** | **int?**|  | 
 **menuItemOptionSet** | [**MenuItemOptionSetBase**](MenuItemOptionSetBase.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadoptionsetimage"></a>
# **UploadOptionSetImage**
> RestApiStringResult UploadOptionSetImage (int? menuId, int? menuSectionId, int? menuSectionItemId, int? optionSetId, System.IO.Stream image)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadOptionSetImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuOptionSetsApi();
            var menuId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuSectionItemId = 56;  // int? | 
            var optionSetId = 56;  // int? | 
            var image = new System.IO.Stream(); // System.IO.Stream | Option set image

            try
            {
                RestApiStringResult result = apiInstance.UploadOptionSetImage(menuId, menuSectionId, menuSectionItemId, optionSetId, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuOptionSetsApi.UploadOptionSetImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuSectionItemId** | **int?**|  | 
 **optionSetId** | **int?**|  | 
 **image** | **System.IO.Stream**| Option set image | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

