# Flipdish.Api.CatalogGroupsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCatalogGroupById**](CatalogGroupsApi.md#getcataloggroupbyid) | **GET** /api/v1.0/{appId}/catalog/groups/{catalogGroupId} | Get group by Id
[**GetGroups**](CatalogGroupsApi.md#getgroups) | **GET** /api/v1.0/{appId}/catalog/groups | Get paginated groups by app name id filtered by types


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

