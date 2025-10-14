# Flipdish.Api.UsersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPreviousOrderCountForStore**](UsersApi.md#getpreviousordercountforstore) | **GET** /api/v1.0/users/{userId}/previousordercount/{storeId} | 
[**GetRoles**](UsersApi.md#getroles) | **GET** /api/v1.0/users/roles | 
[**SearchUsers**](UsersApi.md#searchusers) | **GET** /api/v1.0/users/search | 


<a name="getpreviousordercountforstore"></a>
# **GetPreviousOrderCountForStore**
> RestApiStringResult GetPreviousOrderCountForStore (int? userId, int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPreviousOrderCountForStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var storeId = 56;  // int? | 

            try
            {
                RestApiStringResult result = apiInstance.GetPreviousOrderCountForStore(userId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetPreviousOrderCountForStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **storeId** | **int?**|  | 

### Return type

[**RestApiStringResult**](RestApiStringResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroles"></a>
# **GetRoles**
> RestApiStringArrayResult GetRoles ()



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();

            try
            {
                RestApiStringArrayResult result = apiInstance.GetRoles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RestApiStringArrayResult**](RestApiStringArrayResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchusers"></a>
# **SearchUsers**
> RestApiPaginationResultUser SearchUsers (string searchQuery, bool? hasUserLoggedIn = null, string userDiscriminator = null, string searchIn = null, int? pageIndex = null, int? pageSize = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SearchUsersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var searchQuery = searchQuery_example;  // string | 
            var hasUserLoggedIn = true;  // bool? |  (optional) 
            var userDiscriminator = userDiscriminator_example;  // string |  (optional) 
            var searchIn = searchIn_example;  // string |  (optional) 
            var pageIndex = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                RestApiPaginationResultUser result = apiInstance.SearchUsers(searchQuery, hasUserLoggedIn, userDiscriminator, searchIn, pageIndex, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SearchUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchQuery** | **string**|  | 
 **hasUserLoggedIn** | **bool?**|  | [optional] 
 **userDiscriminator** | **string**|  | [optional] 
 **searchIn** | **string**|  | [optional] 
 **pageIndex** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultUser**](RestApiPaginationResultUser.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

