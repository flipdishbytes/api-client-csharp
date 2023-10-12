# Flipdish.Api.MenuZonesApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMenuZone**](MenuZonesApi.md#addmenuzone) | **POST** /api/v1.0/menus/{menuId}/zones | 
[**DeleteMenuZone**](MenuZonesApi.md#deletemenuzone) | **DELETE** /api/v1.0/menus/{menuId}/zones/{menuZoneId} | 
[**FlipMenuZones**](MenuZonesApi.md#flipmenuzones) | **PUT** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/flip/{menuZoneI2} | 
[**GetMenuZone**](MenuZonesApi.md#getmenuzone) | **GET** /api/v1.0/menus/{menuId}/zones/{menuZoneId} | 
[**GetMenuZonesForMenu**](MenuZonesApi.md#getmenuzonesformenu) | **GET** /api/v1.0/menus/{menuId}/zones | 
[**SetMenuSectionMenuZone**](MenuZonesApi.md#setmenusectionmenuzone) | **PUT** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/description | 
[**SetMenuSectionMenuZone_0**](MenuZonesApi.md#setmenusectionmenuzone_0) | **PUT** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/section/{menuSectionId} | 
[**SetMenuZoneName**](MenuZonesApi.md#setmenuzonename) | **PUT** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/name/{menuZoneName} | 
[**UpdateMenuZone**](MenuZonesApi.md#updatemenuzone) | **PUT** /api/v1.0/menus/{menuId}/zones/{menuZoneId} | 
[**UploadMenuZoneImage**](MenuZonesApi.md#uploadmenuzoneimage) | **POST** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/image | 
[**UploadMenuZoneImage_0**](MenuZonesApi.md#uploadmenuzoneimage_0) | **DELETE** /api/v1.0/menus/{menuId}/zones/{menuZoneId}/image | 


<a name="addmenuzone"></a>
# **AddMenuZone**
> RestApiResultMenuZone AddMenuZone (int? menuId, MenuZone menuZone)



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
            var menuId = 56;  // int? | 
            var menuZone = new MenuZone(); // MenuZone | 

            try
            {
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
 **menuId** | **int?**|  | 
 **menuZone** | [**MenuZone**](MenuZone.md)|  | 

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
            var menuZoneId = 56;  // int? | 
            var menuId = menuId_example;  // string | 

            try
            {
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
 **menuZoneId** | **int?**|  | 
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
            var menuZoneId = 56;  // int? | 
            var menuZoneI2 = 56;  // int? | 
            var menuId = menuId_example;  // string | 

            try
            {
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
 **menuZoneId** | **int?**|  | 
 **menuZoneI2** | **int?**|  | 
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
            var menuId = 56;  // int? | 
            var menuZoneId = 56;  // int? | 

            try
            {
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
 **menuId** | **int?**|  | 
 **menuZoneId** | **int?**|  | 

### Return type

[**RestApiResultMenuZone**](RestApiResultMenuZone.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenuzonesformenu"></a>
# **GetMenuZonesForMenu**
> RestApiArrayResultMenuZone GetMenuZonesForMenu (int? menuId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetMenuZonesForMenuExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuId = 56;  // int? | 

            try
            {
                RestApiArrayResultMenuZone result = apiInstance.GetMenuZonesForMenu(menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.GetMenuZonesForMenu: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 

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
> void SetMenuSectionMenuZone (int? menuZoneId, string description, string menuId)



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
            var menuZoneId = 56;  // int? | 
            var description = description_example;  // string | 
            var menuId = menuId_example;  // string | 

            try
            {
                apiInstance.SetMenuSectionMenuZone(menuZoneId, description, menuId);
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
 **menuZoneId** | **int?**|  | 
 **description** | **string**|  | 
 **menuId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenusectionmenuzone_0"></a>
# **SetMenuSectionMenuZone_0**
> void SetMenuSectionMenuZone_0 (int? menuZoneId, int? menuSectionId, string menuId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetMenuSectionMenuZone_0Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuZoneId = 56;  // int? | 
            var menuSectionId = 56;  // int? | 
            var menuId = menuId_example;  // string | 

            try
            {
                apiInstance.SetMenuSectionMenuZone_0(menuZoneId, menuSectionId, menuId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.SetMenuSectionMenuZone_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuZoneId** | **int?**|  | 
 **menuSectionId** | **int?**|  | 
 **menuId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenuzonename"></a>
# **SetMenuZoneName**
> void SetMenuZoneName (int? menuZoneId, string menuZoneName, string menuId)



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
            var menuZoneId = 56;  // int? | 
            var menuZoneName = menuZoneName_example;  // string | 
            var menuId = menuId_example;  // string | 

            try
            {
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
 **menuZoneId** | **int?**|  | 
 **menuZoneName** | **string**|  | 
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
            var menuId = 56;  // int? | 
            var menuZoneId = 56;  // int? | 
            var menuZone = new MenuZone(); // MenuZone | 

            try
            {
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
 **menuId** | **int?**|  | 
 **menuZoneId** | **int?**|  | 
 **menuZone** | [**MenuZone**](MenuZone.md)|  | 

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
            var menuZoneId = 56;  // int? | 
            var _file = new List<HttpPostedFileBase>(); // List<HttpPostedFileBase> | 
            var menuId = menuId_example;  // string | 

            try
            {
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
 **menuZoneId** | **int?**|  | 
 **_file** | [**List&lt;HttpPostedFileBase&gt;**](HttpPostedFileBase.md)|  | 
 **menuId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadmenuzoneimage_0"></a>
# **UploadMenuZoneImage_0**
> void UploadMenuZoneImage_0 (int? menuZoneId, string menuId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UploadMenuZoneImage_0Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MenuZonesApi();
            var menuZoneId = 56;  // int? | 
            var menuId = menuId_example;  // string | 

            try
            {
                apiInstance.UploadMenuZoneImage_0(menuZoneId, menuId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuZonesApi.UploadMenuZoneImage_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuZoneId** | **int?**|  | 
 **menuId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

