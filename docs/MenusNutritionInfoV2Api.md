# Flipdish.Api.MenusNutritionInfoV2Api

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrUpdateMenuItemNutritionInfoV2**](MenusNutritionInfoV2Api.md#addorupdatemenuitemnutritioninfov2) | **POST** /api/v1.0/{appId}/menus/{menuId}/menuItem/{publicId}/nutritionv2 | Add or update menuitem nutrition info by menu item&#39;s publicId
[**AddOrUpdateMenuItemOptionSetItemNutritionInfoV2**](MenusNutritionInfoV2Api.md#addorupdatemenuitemoptionsetitemnutritioninfov2) | **POST** /api/v1.0/{appId}/menus/{menuId}/menuItemOption/{publicId}/nutritionv2 | Add or update menuitem option set item&#39;s nutrition info by its publicId
[**GetAllergensV2**](MenusNutritionInfoV2Api.md#getallergensv2) | **GET** /api/v1.0/{appId}/menus/nutritionv2/allergens | Get allergens
[**GetMenuNutritionInfoV2ByMenuId**](MenusNutritionInfoV2Api.md#getmenunutritioninfov2bymenuid) | **GET** /api/v1.0/{appId}/menus/{menuId}/nutritionv2 | Get menu nutrition by menuId


<a name="addorupdatemenuitemnutritioninfov2"></a>
# **AddOrUpdateMenuItemNutritionInfoV2**
> Object AddOrUpdateMenuItemNutritionInfoV2 (int? menuId, string publicId, ItemNutritionInfoV2AddUpdateModel addOrUpdateModel, string appId)

Add or update menuitem nutrition info by menu item's publicId

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddOrUpdateMenuItemNutritionInfoV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusNutritionInfoV2Api();
            var menuId = 56;  // int? | Menu identifier
            var publicId = publicId_example;  // string | Menu item's publicId
            var addOrUpdateModel = new ItemNutritionInfoV2AddUpdateModel(); // ItemNutritionInfoV2AddUpdateModel | Allergen ids
            var appId = appId_example;  // string | 

            try
            {
                // Add or update menuitem nutrition info by menu item's publicId
                Object result = apiInstance.AddOrUpdateMenuItemNutritionInfoV2(menuId, publicId, addOrUpdateModel, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusNutritionInfoV2Api.AddOrUpdateMenuItemNutritionInfoV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **publicId** | **string**| Menu item&#39;s publicId | 
 **addOrUpdateModel** | [**ItemNutritionInfoV2AddUpdateModel**](ItemNutritionInfoV2AddUpdateModel.md)| Allergen ids | 
 **appId** | **string**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorupdatemenuitemoptionsetitemnutritioninfov2"></a>
# **AddOrUpdateMenuItemOptionSetItemNutritionInfoV2**
> Object AddOrUpdateMenuItemOptionSetItemNutritionInfoV2 (int? menuId, string publicId, ItemNutritionInfoV2AddUpdateModel addOrUpdateModel, string appId)

Add or update menuitem option set item's nutrition info by its publicId

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddOrUpdateMenuItemOptionSetItemNutritionInfoV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusNutritionInfoV2Api();
            var menuId = 56;  // int? | Menu identifier
            var publicId = publicId_example;  // string | Menu item option set item's publicId
            var addOrUpdateModel = new ItemNutritionInfoV2AddUpdateModel(); // ItemNutritionInfoV2AddUpdateModel | Allergen ids
            var appId = appId_example;  // string | 

            try
            {
                // Add or update menuitem option set item's nutrition info by its publicId
                Object result = apiInstance.AddOrUpdateMenuItemOptionSetItemNutritionInfoV2(menuId, publicId, addOrUpdateModel, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusNutritionInfoV2Api.AddOrUpdateMenuItemOptionSetItemNutritionInfoV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| Menu identifier | 
 **publicId** | **string**| Menu item option set item&#39;s publicId | 
 **addOrUpdateModel** | [**ItemNutritionInfoV2AddUpdateModel**](ItemNutritionInfoV2AddUpdateModel.md)| Allergen ids | 
 **appId** | **string**|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallergensv2"></a>
# **GetAllergensV2**
> RestApiArrayResultAllergen GetAllergensV2 (string appId, string languageId = null)

Get allergens

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetAllergensV2Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusNutritionInfoV2Api();
            var appId = appId_example;  // string | 
            var languageId = languageId_example;  // string |  (optional) 

            try
            {
                // Get allergens
                RestApiArrayResultAllergen result = apiInstance.GetAllergensV2(appId, languageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusNutritionInfoV2Api.GetAllergensV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **languageId** | **string**|  | [optional] 

### Return type

[**RestApiArrayResultAllergen**](RestApiArrayResultAllergen.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenunutritioninfov2bymenuid"></a>
# **GetMenuNutritionInfoV2ByMenuId**
> RestApiResultNutritionInfoV2 GetMenuNutritionInfoV2ByMenuId (string appId, int? menuId, string languageId = null)

Get menu nutrition by menuId

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuNutritionInfoV2ByMenuIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenusNutritionInfoV2Api();
            var appId = appId_example;  // string | 
            var menuId = 56;  // int? | Menu identifier
            var languageId = languageId_example;  // string |  (optional) 

            try
            {
                // Get menu nutrition by menuId
                RestApiResultNutritionInfoV2 result = apiInstance.GetMenuNutritionInfoV2ByMenuId(appId, menuId, languageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenusNutritionInfoV2Api.GetMenuNutritionInfoV2ByMenuId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **menuId** | **int?**| Menu identifier | 
 **languageId** | **string**|  | [optional] 

### Return type

[**RestApiResultNutritionInfoV2**](RestApiResultNutritionInfoV2.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

