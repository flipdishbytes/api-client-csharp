# Flipdish.Api.CatalogGroupsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveGroup**](CatalogGroupsApi.md#archivegroup) | **POST** /api/v1.0/{appId}/catalog/groups/{catalogItemId}/archive | Archive Catalog Group
[**CreateCatalogGroup**](CatalogGroupsApi.md#createcataloggroup) | **POST** /api/v1.0/{appId}/catalog/groups | Create a Catalog Group
[**DuplicateGroup**](CatalogGroupsApi.md#duplicategroup) | **POST** /api/v1.0/{appId}/catalog/groups/{catalogItemId}/duplicate | Duplicate Catalog Group
[**GetGroupById**](CatalogGroupsApi.md#getgroupbyid) | **GET** /api/v1.0/{appId}/catalog/groups/{catalogItemId} | Get group by Id
[**GetGroups**](CatalogGroupsApi.md#getgroups) | **GET** /api/v1.0/{appId}/catalog/groups | Get paginated groups by app name id filtered by types
[**UpdateGroup**](CatalogGroupsApi.md#updategroup) | **POST** /api/v1.0/{appId}/catalog/groups/{catalogItemId} | Update Catalog Group


<a name="archivegroup"></a>
# **ArchiveGroup**
> void ArchiveGroup (string appId, string catalogItemId)

Archive Catalog Group

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
    public class ArchiveGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogGroupsApi();
            var appId = appId_example;  // string | 
            var catalogItemId = catalogItemId_example;  // string | 

            try
            {
                // Archive Catalog Group
                apiInstance.ArchiveGroup(appId, catalogItemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogGroupsApi.ArchiveGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogItemId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcataloggroup"></a>
# **CreateCatalogGroup**
> RestApiResultCatalogGroup CreateCatalogGroup (string appId, CreateCatalogGroup createCatalogGroup)

Create a Catalog Group

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
    public class CreateCatalogGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogGroupsApi();
            var appId = appId_example;  // string | 
            var createCatalogGroup = new CreateCatalogGroup(); // CreateCatalogGroup | 

            try
            {
                // Create a Catalog Group
                RestApiResultCatalogGroup result = apiInstance.CreateCatalogGroup(appId, createCatalogGroup);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogGroupsApi.CreateCatalogGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **createCatalogGroup** | [**CreateCatalogGroup**](CreateCatalogGroup.md)|  | 

### Return type

[**RestApiResultCatalogGroup**](RestApiResultCatalogGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="duplicategroup"></a>
# **DuplicateGroup**
> void DuplicateGroup (string appId, string catalogItemId)

Duplicate Catalog Group

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
    public class DuplicateGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogGroupsApi();
            var appId = appId_example;  // string | 
            var catalogItemId = catalogItemId_example;  // string | 

            try
            {
                // Duplicate Catalog Group
                apiInstance.DuplicateGroup(appId, catalogItemId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogGroupsApi.DuplicateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogItemId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupbyid"></a>
# **GetGroupById**
> CatalogGroup GetGroupById (string appId, string catalogItemId)

Get group by Id

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
    public class GetGroupByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogGroupsApi();
            var appId = appId_example;  // string | 
            var catalogItemId = catalogItemId_example;  // string | 

            try
            {
                // Get group by Id
                CatalogGroup result = apiInstance.GetGroupById(appId, catalogItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogGroupsApi.GetGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogItemId** | **string**|  | 

### Return type

[**CatalogGroup**](CatalogGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroups"></a>
# **GetGroups**
> RestApiPaginationResultCatalogGroup GetGroups (string appId, List<string> groupTypes, string searchTerm = null, int? page = null, int? limit = null)

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
    public class GetGroupsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogGroupsApi();
            var appId = appId_example;  // string | 
            var groupTypes = groupTypes_example;  // List<string> | 
            var searchTerm = searchTerm_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Get paginated groups by app name id filtered by types
                RestApiPaginationResultCatalogGroup result = apiInstance.GetGroups(appId, groupTypes, searchTerm, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogGroupsApi.GetGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **groupTypes** | **List&lt;string&gt;**|  | 
 **searchTerm** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultCatalogGroup**](RestApiPaginationResultCatalogGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroup"></a>
# **UpdateGroup**
> void UpdateGroup (string appId, string catalogItemId, UpdateCatalogGroup updateCatalogGroup)

Update Catalog Group

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
    public class UpdateGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogGroupsApi();
            var appId = appId_example;  // string | 
            var catalogItemId = catalogItemId_example;  // string | 
            var updateCatalogGroup = new UpdateCatalogGroup(); // UpdateCatalogGroup | 

            try
            {
                // Update Catalog Group
                apiInstance.UpdateGroup(appId, catalogItemId, updateCatalogGroup);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogGroupsApi.UpdateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogItemId** | **string**|  | 
 **updateCatalogGroup** | [**UpdateCatalogGroup**](UpdateCatalogGroup.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

