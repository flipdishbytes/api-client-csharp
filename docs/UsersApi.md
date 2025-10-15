# Flipdish.Api.UsersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPreviousOrderCountForStore**](UsersApi.md#getpreviousordercountforstore) | **GET** /api/v1.0/users/{userId}/previousordercount/{storeId} | 
[**GetRestaurantUserAccounts**](UsersApi.md#getrestaurantuseraccounts) | **GET** /api/v1.0/users/{userId}/RestaurantUserAccounts | 
[**GetRestaurantUserStores**](UsersApi.md#getrestaurantuserstores) | **GET** /api/v1.0/users/{userId}/RestaurantUserStores | 
[**GetRoles**](UsersApi.md#getroles) | **GET** /api/v1.0/users/roles | 
[**GetRolesAndUnassignedRoles**](UsersApi.md#getrolesandunassignedroles) | **GET** /api/v1.0/users/{userId}/roles | 
[**GetUserById**](UsersApi.md#getuserbyid) | **GET** /api/v1.0/users/{userId} | 
[**GetUserNotes**](UsersApi.md#getusernotes) | **GET** /api/v1.0/users/{userId}/UserNotes | 
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

<a name="getrestaurantuseraccounts"></a>
# **GetRestaurantUserAccounts**
> RestApiArrayResultUserFlipdishAccount GetRestaurantUserAccounts (int? userId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetRestaurantUserAccountsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 

            try
            {
                RestApiArrayResultUserFlipdishAccount result = apiInstance.GetRestaurantUserAccounts(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetRestaurantUserAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 

### Return type

[**RestApiArrayResultUserFlipdishAccount**](RestApiArrayResultUserFlipdishAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestaurantuserstores"></a>
# **GetRestaurantUserStores**
> RestApiArrayResultUserStoreInfo GetRestaurantUserStores (int? userId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetRestaurantUserStoresExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 

            try
            {
                RestApiArrayResultUserStoreInfo result = apiInstance.GetRestaurantUserStores(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetRestaurantUserStores: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 

### Return type

[**RestApiArrayResultUserStoreInfo**](RestApiArrayResultUserStoreInfo.md)

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

<a name="getrolesandunassignedroles"></a>
# **GetRolesAndUnassignedRoles**
> RestApiResultUserRole GetRolesAndUnassignedRoles (int? userId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetRolesAndUnassignedRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 

            try
            {
                RestApiResultUserRole result = apiInstance.GetRolesAndUnassignedRoles(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetRolesAndUnassignedRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 

### Return type

[**RestApiResultUserRole**](RestApiResultUserRole.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserbyid"></a>
# **GetUserById**
> RestApiResultUserInfo GetUserById (int? userId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetUserByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 

            try
            {
                RestApiResultUserInfo result = apiInstance.GetUserById(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 

### Return type

[**RestApiResultUserInfo**](RestApiResultUserInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusernotes"></a>
# **GetUserNotes**
> RestApiArrayResultUserNote GetUserNotes (int? userId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetUserNotesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 

            try
            {
                RestApiArrayResultUserNote result = apiInstance.GetUserNotes(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 

### Return type

[**RestApiArrayResultUserNote**](RestApiArrayResultUserNote.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchusers"></a>
# **SearchUsers**
> RestApiPaginationResultUserSearch SearchUsers (string searchQuery, bool? hasUserLoggedIn = null, string userDiscriminator = null, string searchIn = null, int? pageIndex = null, int? pageSize = null)



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
                RestApiPaginationResultUserSearch result = apiInstance.SearchUsers(searchQuery, hasUserLoggedIn, userDiscriminator, searchIn, pageIndex, pageSize);
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

[**RestApiPaginationResultUserSearch**](RestApiPaginationResultUserSearch.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

