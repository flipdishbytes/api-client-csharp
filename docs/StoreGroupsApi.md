# Flipdish.Api.StoreGroupsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStoreGroup**](StoreGroupsApi.md#createstoregroup) | **POST** /api/v1.0/{appNameId}/storegroups | Creates a Store Group  It will be attached to an existing App
[**GetStoreGroup**](StoreGroupsApi.md#getstoregroup) | **GET** /api/v1.0/storegroups/{storeGroupId} | Returns a Store Groups
[**GetStoreGroups**](StoreGroupsApi.md#getstoregroups) | **GET** /api/v1.0/{appNameId}/storegroups | Returns a paginated list of Store Groups
[**GetStoreGroupsExtended**](StoreGroupsApi.md#getstoregroupsextended) | **GET** /api/v1.0/{appNameId}/storegroups/extended | [PRIVATE API] Returns a paginated list of Extended Store Groups
[**RemoveStoreGroup**](StoreGroupsApi.md#removestoregroup) | **DELETE** /api/v1.0/storegroups/{storeGroupId} | Deletes a Store Group  Can only remove a store group if there is no stores attached to the group
[**UpdateStoreGroup**](StoreGroupsApi.md#updatestoregroup) | **POST** /api/v1.0/storegroups/{storeGroupId} | Updates Store Group


<a name="createstoregroup"></a>
# **CreateStoreGroup**
> RestApiResultStoreGroup CreateStoreGroup (string appNameId, StoreGroupBase storeGroup)

Creates a Store Group  It will be attached to an existing App

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateStoreGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreGroupsApi();
            var appNameId = appNameId_example;  // string | App Name Id
            var storeGroup = new StoreGroupBase(); // StoreGroupBase | Store group definition

            try
            {
                // Creates a Store Group  It will be attached to an existing App
                RestApiResultStoreGroup result = apiInstance.CreateStoreGroup(appNameId, storeGroup);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreGroupsApi.CreateStoreGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appNameId** | **string**| App Name Id | 
 **storeGroup** | [**StoreGroupBase**](StoreGroupBase.md)| Store group definition | 

### Return type

[**RestApiResultStoreGroup**](RestApiResultStoreGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoregroup"></a>
# **GetStoreGroup**
> RestApiResultStoreGroup GetStoreGroup (int? storeGroupId)

Returns a Store Groups

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreGroupsApi();
            var storeGroupId = 56;  // int? | Store Group Id

            try
            {
                // Returns a Store Groups
                RestApiResultStoreGroup result = apiInstance.GetStoreGroup(storeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreGroupsApi.GetStoreGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeGroupId** | **int?**| Store Group Id | 

### Return type

[**RestApiResultStoreGroup**](RestApiResultStoreGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoregroups"></a>
# **GetStoreGroups**
> RestApiPaginationResultStoreGroup GetStoreGroups (string appNameId, string searchQuery = null, int? page = null, int? limit = null)

Returns a paginated list of Store Groups

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreGroupsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreGroupsApi();
            var appNameId = appNameId_example;  // string | App Name Id
            var searchQuery = searchQuery_example;  // string | Search query (optional) 
            var page = 56;  // int? | Requested page index (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 

            try
            {
                // Returns a paginated list of Store Groups
                RestApiPaginationResultStoreGroup result = apiInstance.GetStoreGroups(appNameId, searchQuery, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreGroupsApi.GetStoreGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appNameId** | **string**| App Name Id | 
 **searchQuery** | **string**| Search query | [optional] 
 **page** | **int?**| Requested page index | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 

### Return type

[**RestApiPaginationResultStoreGroup**](RestApiPaginationResultStoreGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoregroupsextended"></a>
# **GetStoreGroupsExtended**
> RestApiPaginationResultStoreGroupExtended GetStoreGroupsExtended (string appNameId, string searchQuery = null, int? page = null, int? limit = null, int? groupingRadius = null)

[PRIVATE API] Returns a paginated list of Extended Store Groups

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreGroupsExtendedExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreGroupsApi();
            var appNameId = appNameId_example;  // string | App Name Id
            var searchQuery = searchQuery_example;  // string | Search query (optional) 
            var page = 56;  // int? | Requested page index (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 
            var groupingRadius = 56;  // int? |  (optional) 

            try
            {
                // [PRIVATE API] Returns a paginated list of Extended Store Groups
                RestApiPaginationResultStoreGroupExtended result = apiInstance.GetStoreGroupsExtended(appNameId, searchQuery, page, limit, groupingRadius);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreGroupsApi.GetStoreGroupsExtended: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appNameId** | **string**| App Name Id | 
 **searchQuery** | **string**| Search query | [optional] 
 **page** | **int?**| Requested page index | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 
 **groupingRadius** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultStoreGroupExtended**](RestApiPaginationResultStoreGroupExtended.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removestoregroup"></a>
# **RemoveStoreGroup**
> void RemoveStoreGroup (int? storeGroupId)

Deletes a Store Group  Can only remove a store group if there is no stores attached to the group

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RemoveStoreGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreGroupsApi();
            var storeGroupId = 56;  // int? | Store Group Id

            try
            {
                // Deletes a Store Group  Can only remove a store group if there is no stores attached to the group
                apiInstance.RemoveStoreGroup(storeGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreGroupsApi.RemoveStoreGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeGroupId** | **int?**| Store Group Id | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestoregroup"></a>
# **UpdateStoreGroup**
> RestApiResultStoreGroupBase UpdateStoreGroup (int? storeGroupId, StoreGroupBase storeGroup)

Updates Store Group

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateStoreGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreGroupsApi();
            var storeGroupId = 56;  // int? | Store Group Id
            var storeGroup = new StoreGroupBase(); // StoreGroupBase | Store Group Delta

            try
            {
                // Updates Store Group
                RestApiResultStoreGroupBase result = apiInstance.UpdateStoreGroup(storeGroupId, storeGroup);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreGroupsApi.UpdateStoreGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeGroupId** | **int?**| Store Group Id | 
 **storeGroup** | [**StoreGroupBase**](StoreGroupBase.md)| Store Group Delta | 

### Return type

[**RestApiResultStoreGroupBase**](RestApiResultStoreGroupBase.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

