# Flipdish.Api.CatalogGroupsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveCatalogGroup**](CatalogGroupsApi.md#archivecataloggroup) | **POST** /api/v1.0/{appId}/catalog/groups/{catalogGroupId}/archive | Archive Catalog Group
[**CreateCatalogGroup**](CatalogGroupsApi.md#createcataloggroup) | **POST** /api/v1.0/{appId}/catalog/groups | Create a Catalog Group
[**DuplicateCatalogGroup**](CatalogGroupsApi.md#duplicatecataloggroup) | **POST** /api/v1.0/{appId}/catalog/groups/{catalogGroupId}/duplicate | Duplicate Catalog Group
[**GetCatalogGroupById**](CatalogGroupsApi.md#getcataloggroupbyid) | **GET** /api/v1.0/{appId}/catalog/groups/{catalogGroupId} | Get group by Id
[**GetGroups**](CatalogGroupsApi.md#getgroups) | **GET** /api/v1.0/{appId}/catalog/groups | Get paginated groups by app name id filtered by types
[**UpdateCatalogGroup**](CatalogGroupsApi.md#updatecataloggroup) | **POST** /api/v1.0/{appId}/catalog/groups/{catalogGroupId} | Update Catalog Group


<a name="archivecataloggroup"></a>
# **ArchiveCatalogGroup**
> void ArchiveCatalogGroup (string appId, string catalogGroupId)

Archive Catalog Group

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ArchiveCatalogGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogGroupsApi();
            var appId = appId_example;  // string | 
            var catalogGroupId = catalogGroupId_example;  // string | 

            try
            {
                // Archive Catalog Group
                apiInstance.ArchiveCatalogGroup(appId, catalogGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogGroupsApi.ArchiveCatalogGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogGroupId** | **string**|  | 

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

<a name="duplicatecataloggroup"></a>
# **DuplicateCatalogGroup**
> void DuplicateCatalogGroup (string appId, string catalogGroupId)

Duplicate Catalog Group

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DuplicateCatalogGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogGroupsApi();
            var appId = appId_example;  // string | 
            var catalogGroupId = catalogGroupId_example;  // string | 

            try
            {
                // Duplicate Catalog Group
                apiInstance.DuplicateCatalogGroup(appId, catalogGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogGroupsApi.DuplicateCatalogGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogGroupId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcataloggroupbyid"></a>
# **GetCatalogGroupById**
> CatalogGroup GetCatalogGroupById (string appId, string catalogGroupId)

Get group by Id

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetCatalogGroupByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogGroupsApi();
            var appId = appId_example;  // string | 
            var catalogGroupId = catalogGroupId_example;  // string | 

            try
            {
                // Get group by Id
                CatalogGroup result = apiInstance.GetCatalogGroupById(appId, catalogGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogGroupsApi.GetCatalogGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogGroupId** | **string**|  | 

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

<a name="updatecataloggroup"></a>
# **UpdateCatalogGroup**
> void UpdateCatalogGroup (string appId, string catalogGroupId, UpdateCatalogGroup updateCatalogGroup)

Update Catalog Group

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateCatalogGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CatalogGroupsApi();
            var appId = appId_example;  // string | 
            var catalogGroupId = catalogGroupId_example;  // string | 
            var updateCatalogGroup = new UpdateCatalogGroup(); // UpdateCatalogGroup | 

            try
            {
                // Update Catalog Group
                apiInstance.UpdateCatalogGroup(appId, catalogGroupId, updateCatalogGroup);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogGroupsApi.UpdateCatalogGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **catalogGroupId** | **string**|  | 
 **updateCatalogGroup** | [**UpdateCatalogGroup**](UpdateCatalogGroup.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

