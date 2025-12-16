# Flipdish.Api.MenuZonesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMenuZone**](MenuZonesApi.md#addmenuzone) | **POST** /api/v1.0/menus/{menuId}/zones | Adds a new menu zone to a menu.
[**DeleteMenuZone**](MenuZonesApi.md#deletemenuzone) | **DELETE** /api/v1.0/menus/{menuId}/zones/{menuZoneId} | Deletes a menu zone.
[**DeleteMenuZoneImage**](MenuZonesApi.md#deletemenuzoneimage) | **DELETE** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/image | Deletes a menu zone image.
[**FlipMenuZones**](MenuZonesApi.md#flipmenuzones) | **PUT** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/flip/{menuZoneI2} | Flips the order of two menu zones.
[**GetMenuZone**](MenuZonesApi.md#getmenuzone) | **GET** /api/v1.0/menus/{menuId}/zones/{menuZoneId} | Gets a specific menu zone for a given zone id
[**GetMenuZonesForMenuId**](MenuZonesApi.md#getmenuzonesformenuid) | **GET** /api/v1.0/menus/{menuId}/zones | Gets all the menu zones for a menu
[**SetMenuSectionMenuZone**](MenuZonesApi.md#setmenusectionmenuzone) | **PUT** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/section/{menuSectionId} | Assigns a zone to a menu section.
[**SetMenuZoneDescription**](MenuZonesApi.md#setmenuzonedescription) | **PUT** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/description | Sets the description of a menu zone.
[**SetMenuZoneName**](MenuZonesApi.md#setmenuzonename) | **PUT** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/name/{menuZoneName} | Sets the name of a menu zone.
[**UpdateMenuZone**](MenuZonesApi.md#updatemenuzone) | **PUT** /api/v1.0/menus/{menuId}/zones/{menuZoneId} | Updates a menu zone.
[**UploadMenuZoneImage**](MenuZonesApi.md#uploadmenuzoneimage) | **POST** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/image | Uploads an image for a menu zone.


<a name="addmenuzone"></a>
# **AddMenuZone**
> RestApiResultMenuZone AddMenuZone (int? menuId, MenuZone menuZone)

Adds a new menu zone to a menu.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddMenuZoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuId = 56;  // int? | The menu id.
            var menuZone = new MenuZone(); // MenuZone | The object containing the new zone. This is optional and not supplying it will generate an empty default zone.

            try
            {
                // Adds a new menu zone to a menu.
                RestApiResultMenuZone result = apiInstance.AddMenuZone(menuId, menuZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.AddMenuZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| The menu id. | 
 **menuZone** | [**MenuZone**](MenuZone.md)| The object containing the new zone. This is optional and not supplying it will generate an empty default zone. | 

### Return type

[**RestApiResultMenuZone**](RestApiResultMenuZone.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenuzone"></a>
# **DeleteMenuZone**
> void DeleteMenuZone (int? menuZoneId, string menuId)

Deletes a menu zone.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuZoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuZoneId = 56;  // int? | The menu zone id.
            var menuId = menuId_example;  // string | 

            try
            {
                // Deletes a menu zone.
                apiInstance.DeleteMenuZone(menuZoneId, menuId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.DeleteMenuZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuZoneId** | **int?**| The menu zone id. | 
 **menuId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenuzoneimage"></a>
# **DeleteMenuZoneImage**
> void DeleteMenuZoneImage (int? menuZoneId, string menuId)

Deletes a menu zone image.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteMenuZoneImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuZoneId = 56;  // int? | The zone Id/
            var menuId = menuId_example;  // string | 

            try
            {
                // Deletes a menu zone image.
                apiInstance.DeleteMenuZoneImage(menuZoneId, menuId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.DeleteMenuZoneImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuZoneId** | **int?**| The zone Id/ | 
 **menuId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="flipmenuzones"></a>
# **FlipMenuZones**
> void FlipMenuZones (int? menuZoneId, int? menuZoneI2, string menuId)

Flips the order of two menu zones.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class FlipMenuZonesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuZoneId = 56;  // int? | Source.
            var menuZoneI2 = 56;  // int? | Destination.
            var menuId = menuId_example;  // string | 

            try
            {
                // Flips the order of two menu zones.
                apiInstance.FlipMenuZones(menuZoneId, menuZoneI2, menuId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.FlipMenuZones: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuZoneId** | **int?**| Source. | 
 **menuZoneI2** | **int?**| Destination. | 
 **menuId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuzone"></a>
# **GetMenuZone**
> RestApiResultMenuZone GetMenuZone (int? menuId, int? menuZoneId)

Gets a specific menu zone for a given zone id

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuZoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuId = 56;  // int? | The menu id.
            var menuZoneId = 56;  // int? | The menu zone id.

            try
            {
                // Gets a specific menu zone for a given zone id
                RestApiResultMenuZone result = apiInstance.GetMenuZone(menuId, menuZoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.GetMenuZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| The menu id. | 
 **menuZoneId** | **int?**| The menu zone id. | 

### Return type

[**RestApiResultMenuZone**](RestApiResultMenuZone.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuzonesformenuid"></a>
# **GetMenuZonesForMenuId**
> RestApiArrayResultMenuZone GetMenuZonesForMenuId (int? menuId)

Gets all the menu zones for a menu

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuZonesForMenuIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuId = 56;  // int? | The menu id to load zones for

            try
            {
                // Gets all the menu zones for a menu
                RestApiArrayResultMenuZone result = apiInstance.GetMenuZonesForMenuId(menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.GetMenuZonesForMenuId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| The menu id to load zones for | 

### Return type

[**RestApiArrayResultMenuZone**](RestApiArrayResultMenuZone.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenusectionmenuzone"></a>
# **SetMenuSectionMenuZone**
> void SetMenuSectionMenuZone (int? menuZoneId, int? menuSectionId, string menuId)

Assigns a zone to a menu section.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetMenuSectionMenuZoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuZoneId = 56;  // int? | The menu id.
            var menuSectionId = 56;  // int? | The menu section id.
            var menuId = menuId_example;  // string | 

            try
            {
                // Assigns a zone to a menu section.
                apiInstance.SetMenuSectionMenuZone(menuZoneId, menuSectionId, menuId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.SetMenuSectionMenuZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuZoneId** | **int?**| The menu id. | 
 **menuSectionId** | **int?**| The menu section id. | 
 **menuId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenuzonedescription"></a>
# **SetMenuZoneDescription**
> void SetMenuZoneDescription (int? menuZoneId, string description, string menuId)

Sets the description of a menu zone.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetMenuZoneDescriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuZoneId = 56;  // int? | The zone id.
            var description = description_example;  // string | The new description. Add as a raw string in the request, without any JSON wrapper.
            var menuId = menuId_example;  // string | 

            try
            {
                // Sets the description of a menu zone.
                apiInstance.SetMenuZoneDescription(menuZoneId, description, menuId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.SetMenuZoneDescription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuZoneId** | **int?**| The zone id. | 
 **description** | **string**| The new description. Add as a raw string in the request, without any JSON wrapper. | 
 **menuId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenuzonename"></a>
# **SetMenuZoneName**
> void SetMenuZoneName (int? menuZoneId, string menuZoneName, string menuId)

Sets the name of a menu zone.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetMenuZoneNameExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuZoneId = 56;  // int? | The menu zone id.
            var menuZoneName = menuZoneName_example;  // string | The new name.
            var menuId = menuId_example;  // string | 

            try
            {
                // Sets the name of a menu zone.
                apiInstance.SetMenuZoneName(menuZoneId, menuZoneName, menuId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.SetMenuZoneName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuZoneId** | **int?**| The menu zone id. | 
 **menuZoneName** | **string**| The new name. | 
 **menuId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemenuzone"></a>
# **UpdateMenuZone**
> void UpdateMenuZone (int? menuId, int? menuZoneId, MenuZone menuZone)

Updates a menu zone.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateMenuZoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuId = 56;  // int? | The menu id.
            var menuZoneId = 56;  // int? | The menu zone id.
            var menuZone = new MenuZone(); // MenuZone | The object containing the updated values.

            try
            {
                // Updates a menu zone.
                apiInstance.UpdateMenuZone(menuId, menuZoneId, menuZone);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.UpdateMenuZone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**| The menu id. | 
 **menuZoneId** | **int?**| The menu zone id. | 
 **menuZone** | [**MenuZone**](MenuZone.md)| The object containing the updated values. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadmenuzoneimage"></a>
# **UploadMenuZoneImage**
> void UploadMenuZoneImage (int? menuZoneId, List<HttpPostedFileBase> _file, string menuId)

Uploads an image for a menu zone.

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadMenuZoneImageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuZoneId = 56;  // int? | The zone id.
            var _file = new List<HttpPostedFileBase>(); // List<HttpPostedFileBase> | The file to upload.
            var menuId = menuId_example;  // string | 

            try
            {
                // Uploads an image for a menu zone.
                apiInstance.UploadMenuZoneImage(menuZoneId, _file, menuId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.UploadMenuZoneImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuZoneId** | **int?**| The zone id. | 
 **_file** | [**List&lt;HttpPostedFileBase&gt;**](HttpPostedFileBase.md)| The file to upload. | 
 **menuId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

