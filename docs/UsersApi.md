# Flipdish.Api.UsersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUserNote**](UsersApi.md#addusernote) | **POST** /api/v1.0/users/{userId}/AddUserNote | 
[**AddUserToRole**](UsersApi.md#addusertorole) | **POST** /api/v1.0/users/{userId}/AddUserToRole/{roleName} | 
[**AnonymizeUser**](UsersApi.md#anonymizeuser) | **POST** /api/v1.0/users/{userId}/AnonymizeUser | 
[**BlockUserPhoneNumber**](UsersApi.md#blockuserphonenumber) | **POST** /api/v1.0/users/{userId}/BlockUserPhoneNumber | 
[**CreateUserDeliveryLocation**](UsersApi.md#createuserdeliverylocation) | **POST** /api/v1.0/users/{userId}/deliveryLocations | 
[**GetPreviousOrderCountForStore**](UsersApi.md#getpreviousordercountforstore) | **GET** /api/v1.0/users/{userId}/previousordercount/{storeId} | 
[**GetRestaurantUserAccounts**](UsersApi.md#getrestaurantuseraccounts) | **GET** /api/v1.0/users/{userId}/RestaurantUserAccounts | 
[**GetRestaurantUserStores**](UsersApi.md#getrestaurantuserstores) | **GET** /api/v1.0/users/{userId}/RestaurantUserStores | 
[**GetRoles**](UsersApi.md#getroles) | **GET** /api/v1.0/users/roles | 
[**GetRolesAndUnassignedRoles**](UsersApi.md#getrolesandunassignedroles) | **GET** /api/v1.0/users/{userId}/roles | 
[**GetUserById**](UsersApi.md#getuserbyid) | **GET** /api/v1.0/users/{userId} | 
[**GetUserDeliveryLocationsForAdmin**](UsersApi.md#getuserdeliverylocationsforadmin) | **GET** /api/v1.0/users/{userId}/deliveryLocations | 
[**GetUserNotes**](UsersApi.md#getusernotes) | **GET** /api/v1.0/users/{userId}/UserNotes | 
[**GetUserOrderByIdForAdmin**](UsersApi.md#getuserorderbyidforadmin) | **GET** /api/v1.0/users/{userId}/orders/{orderId} | 
[**GetUserOrdersForAdmin**](UsersApi.md#getuserordersforadmin) | **GET** /api/v1.0/users/{userId}/orders | 
[**GetUserSmsConversationItems**](UsersApi.md#getusersmsconversationitems) | **GET** /api/v1.0/users/{userId}/smsConversationItems | 
[**HideUserDeliveryLocation**](UsersApi.md#hideuserdeliverylocation) | **POST** /api/v1.0/users/{userId}/deliveryLocations/{deliveryLocationId}/hide | 
[**MarkUserAsFraudulent**](UsersApi.md#markuserasfraudulent) | **POST** /api/v1.0/users/{userId}/MarkUserAsFraudulent | 
[**MarkUserAsSuspicious**](UsersApi.md#markuserassuspicious) | **POST** /api/v1.0/users/{userId}/MarkUserAsSuspicious | 
[**RemoveFlipdishAccountIdForUser**](UsersApi.md#removeflipdishaccountidforuser) | **POST** /api/v1.0/users/{userId}/RemoveFlipdishAccountId/{accountId} | 
[**RemoveUserFromRole**](UsersApi.md#removeuserfromrole) | **POST** /api/v1.0/users/{userId}/RemoveUserFromRole/{roleName} | 
[**ResetMfa**](UsersApi.md#resetmfa) | **POST** /api/v1.0/users/{userId}/ResetMfa | 
[**SearchFlipdishAccounts**](UsersApi.md#searchflipdishaccounts) | **GET** /api/v1.0/users/searchFlipdishAccounts | 
[**SearchUsers**](UsersApi.md#searchusers) | **GET** /api/v1.0/users/search | 
[**SendUserPushNotification**](UsersApi.md#senduserpushnotification) | **POST** /api/v1.0/users/{userId}/pushNotifications | 
[**SendUserSms**](UsersApi.md#sendusersms) | **POST** /api/v1.0/users/{userId}/sms | 
[**SetCustomerName**](UsersApi.md#setcustomername) | **POST** /api/v1.0/users/{userId}/SetCustomerName | 
[**SetFlipdishAccountIdForUser**](UsersApi.md#setflipdishaccountidforuser) | **POST** /api/v1.0/users/{userId}/SetFlipdishAccountId/{accountId} | 
[**SetUserDeliveryLocationCoordinates**](UsersApi.md#setuserdeliverylocationcoordinates) | **POST** /api/v1.0/users/{userId}/deliveryLocations/{deliveryLocationId}/coordinates | 
[**SetUserDeliveryLocationField**](UsersApi.md#setuserdeliverylocationfield) | **POST** /api/v1.0/users/{userId}/deliveryLocations/{deliveryLocationId}/fields | 
[**SetUserLanguage**](UsersApi.md#setuserlanguage) | **POST** /api/v1.0/users/{userId}/SetLanguage/{languageId} | 
[**UnblockUserPhoneNumber**](UsersApi.md#unblockuserphonenumber) | **POST** /api/v1.0/users/{userId}/UnblockUserPhoneNumber | 


<a name="addusernote"></a>
# **AddUserNote**
> RestApiDefaultResponse AddUserNote (int? userId, string note)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddUserNoteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var note = note_example;  // string | 

            try
            {
                RestApiDefaultResponse result = apiInstance.AddUserNote(userId, note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.AddUserNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **note** | **string**|  | 

### Return type

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addusertorole"></a>
# **AddUserToRole**
> RestApiResultUserRole AddUserToRole (int? userId, string roleName)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AddUserToRoleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var roleName = roleName_example;  // string | 

            try
            {
                RestApiResultUserRole result = apiInstance.AddUserToRole(userId, roleName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.AddUserToRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **roleName** | **string**|  | 

### Return type

[**RestApiResultUserRole**](RestApiResultUserRole.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="anonymizeuser"></a>
# **AnonymizeUser**
> RestApiDefaultResponse AnonymizeUser (int? userId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AnonymizeUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 

            try
            {
                RestApiDefaultResponse result = apiInstance.AnonymizeUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.AnonymizeUser: " + e.Message );
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

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="blockuserphonenumber"></a>
# **BlockUserPhoneNumber**
> RestApiDefaultResponse BlockUserPhoneNumber (int? userId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class BlockUserPhoneNumberExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 

            try
            {
                RestApiDefaultResponse result = apiInstance.BlockUserPhoneNumber(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.BlockUserPhoneNumber: " + e.Message );
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

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuserdeliverylocation"></a>
# **CreateUserDeliveryLocation**
> RestApiDefaultResponse CreateUserDeliveryLocation (int? userId, CreateUserDeliveryLocationRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateUserDeliveryLocationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var request = new CreateUserDeliveryLocationRequest(); // CreateUserDeliveryLocationRequest | 

            try
            {
                RestApiDefaultResponse result = apiInstance.CreateUserDeliveryLocation(userId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUserDeliveryLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **request** | [**CreateUserDeliveryLocationRequest**](CreateUserDeliveryLocationRequest.md)|  | 

### Return type

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

<a name="getuserdeliverylocationsforadmin"></a>
# **GetUserDeliveryLocationsForAdmin**
> RestApiArrayResultUserDeliveryLocationAdmin GetUserDeliveryLocationsForAdmin (int? userId, int? whiteLabelId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetUserDeliveryLocationsForAdminExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var whiteLabelId = 56;  // int? |  (optional) 

            try
            {
                RestApiArrayResultUserDeliveryLocationAdmin result = apiInstance.GetUserDeliveryLocationsForAdmin(userId, whiteLabelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserDeliveryLocationsForAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **whiteLabelId** | **int?**|  | [optional] 

### Return type

[**RestApiArrayResultUserDeliveryLocationAdmin**](RestApiArrayResultUserDeliveryLocationAdmin.md)

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

<a name="getuserorderbyidforadmin"></a>
# **GetUserOrderByIdForAdmin**
> RestApiResultOrder GetUserOrderByIdForAdmin (int? userId, int? orderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetUserOrderByIdForAdminExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var orderId = 56;  // int? | 

            try
            {
                RestApiResultOrder result = apiInstance.GetUserOrderByIdForAdmin(userId, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserOrderByIdForAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **orderId** | **int?**|  | 

### Return type

[**RestApiResultOrder**](RestApiResultOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserordersforadmin"></a>
# **GetUserOrdersForAdmin**
> RestApiArrayResultUserOrderSummary GetUserOrdersForAdmin (int? userId, int? skip = null, int? take = null, int? whiteLabelId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetUserOrdersForAdminExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var skip = 56;  // int? |  (optional) 
            var take = 56;  // int? |  (optional) 
            var whiteLabelId = 56;  // int? |  (optional) 

            try
            {
                RestApiArrayResultUserOrderSummary result = apiInstance.GetUserOrdersForAdmin(userId, skip, take, whiteLabelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserOrdersForAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **skip** | **int?**|  | [optional] 
 **take** | **int?**|  | [optional] 
 **whiteLabelId** | **int?**|  | [optional] 

### Return type

[**RestApiArrayResultUserOrderSummary**](RestApiArrayResultUserOrderSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersmsconversationitems"></a>
# **GetUserSmsConversationItems**
> RestApiArrayResultUserSmsChatItem GetUserSmsConversationItems (int? userId, int? mostRecentCount = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetUserSmsConversationItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var mostRecentCount = 56;  // int? |  (optional) 

            try
            {
                RestApiArrayResultUserSmsChatItem result = apiInstance.GetUserSmsConversationItems(userId, mostRecentCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserSmsConversationItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **mostRecentCount** | **int?**|  | [optional] 

### Return type

[**RestApiArrayResultUserSmsChatItem**](RestApiArrayResultUserSmsChatItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hideuserdeliverylocation"></a>
# **HideUserDeliveryLocation**
> RestApiDefaultResponse HideUserDeliveryLocation (int? userId, int? deliveryLocationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class HideUserDeliveryLocationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var deliveryLocationId = 56;  // int? | 

            try
            {
                RestApiDefaultResponse result = apiInstance.HideUserDeliveryLocation(userId, deliveryLocationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.HideUserDeliveryLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **deliveryLocationId** | **int?**|  | 

### Return type

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markuserasfraudulent"></a>
# **MarkUserAsFraudulent**
> RestApiDefaultResponse MarkUserAsFraudulent (int? userId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MarkUserAsFraudulentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 

            try
            {
                RestApiDefaultResponse result = apiInstance.MarkUserAsFraudulent(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.MarkUserAsFraudulent: " + e.Message );
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

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markuserassuspicious"></a>
# **MarkUserAsSuspicious**
> RestApiDefaultResponse MarkUserAsSuspicious (int? userId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class MarkUserAsSuspiciousExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 

            try
            {
                RestApiDefaultResponse result = apiInstance.MarkUserAsSuspicious(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.MarkUserAsSuspicious: " + e.Message );
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

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeflipdishaccountidforuser"></a>
# **RemoveFlipdishAccountIdForUser**
> RestApiDefaultResponse RemoveFlipdishAccountIdForUser (int? userId, int? accountId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RemoveFlipdishAccountIdForUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var accountId = 56;  // int? | 

            try
            {
                RestApiDefaultResponse result = apiInstance.RemoveFlipdishAccountIdForUser(userId, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.RemoveFlipdishAccountIdForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **accountId** | **int?**|  | 

### Return type

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuserfromrole"></a>
# **RemoveUserFromRole**
> RestApiResultUserRole RemoveUserFromRole (int? userId, string roleName)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class RemoveUserFromRoleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var roleName = roleName_example;  // string | 

            try
            {
                RestApiResultUserRole result = apiInstance.RemoveUserFromRole(userId, roleName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.RemoveUserFromRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **roleName** | **string**|  | 

### Return type

[**RestApiResultUserRole**](RestApiResultUserRole.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetmfa"></a>
# **ResetMfa**
> RestApiDefaultResponse ResetMfa (int? userId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ResetMfaExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 

            try
            {
                RestApiDefaultResponse result = apiInstance.ResetMfa(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ResetMfa: " + e.Message );
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

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchflipdishaccounts"></a>
# **SearchFlipdishAccounts**
> RestApiArrayResultFlipdishAccountName SearchFlipdishAccounts (string searchPattern)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SearchFlipdishAccountsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var searchPattern = searchPattern_example;  // string | 

            try
            {
                RestApiArrayResultFlipdishAccountName result = apiInstance.SearchFlipdishAccounts(searchPattern);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SearchFlipdishAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchPattern** | **string**|  | 

### Return type

[**RestApiArrayResultFlipdishAccountName**](RestApiArrayResultFlipdishAccountName.md)

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

<a name="senduserpushnotification"></a>
# **SendUserPushNotification**
> RestApiResultUserPushNotificationSentResult SendUserPushNotification (int? userId, SendUserPushNotificationRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SendUserPushNotificationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var request = new SendUserPushNotificationRequest(); // SendUserPushNotificationRequest | 

            try
            {
                RestApiResultUserPushNotificationSentResult result = apiInstance.SendUserPushNotification(userId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SendUserPushNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **request** | [**SendUserPushNotificationRequest**](SendUserPushNotificationRequest.md)|  | 

### Return type

[**RestApiResultUserPushNotificationSentResult**](RestApiResultUserPushNotificationSentResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendusersms"></a>
# **SendUserSms**
> RestApiDefaultResponse SendUserSms (int? userId, SendUserSmsRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SendUserSmsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var request = new SendUserSmsRequest(); // SendUserSmsRequest | 

            try
            {
                RestApiDefaultResponse result = apiInstance.SendUserSms(userId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SendUserSms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **request** | [**SendUserSmsRequest**](SendUserSmsRequest.md)|  | 

### Return type

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcustomername"></a>
# **SetCustomerName**
> RestApiDefaultResponse SetCustomerName (int? userId, string customerName)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetCustomerNameExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var customerName = customerName_example;  // string | 

            try
            {
                RestApiDefaultResponse result = apiInstance.SetCustomerName(userId, customerName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SetCustomerName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **customerName** | **string**|  | 

### Return type

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setflipdishaccountidforuser"></a>
# **SetFlipdishAccountIdForUser**
> RestApiDefaultResponse SetFlipdishAccountIdForUser (int? userId, int? accountId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetFlipdishAccountIdForUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var accountId = 56;  // int? | 

            try
            {
                RestApiDefaultResponse result = apiInstance.SetFlipdishAccountIdForUser(userId, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SetFlipdishAccountIdForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **accountId** | **int?**|  | 

### Return type

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setuserdeliverylocationcoordinates"></a>
# **SetUserDeliveryLocationCoordinates**
> RestApiDefaultResponse SetUserDeliveryLocationCoordinates (int? userId, int? deliveryLocationId, SetUserDeliveryLocationCoordinatesRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetUserDeliveryLocationCoordinatesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var deliveryLocationId = 56;  // int? | 
            var request = new SetUserDeliveryLocationCoordinatesRequest(); // SetUserDeliveryLocationCoordinatesRequest | 

            try
            {
                RestApiDefaultResponse result = apiInstance.SetUserDeliveryLocationCoordinates(userId, deliveryLocationId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SetUserDeliveryLocationCoordinates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **deliveryLocationId** | **int?**|  | 
 **request** | [**SetUserDeliveryLocationCoordinatesRequest**](SetUserDeliveryLocationCoordinatesRequest.md)|  | 

### Return type

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setuserdeliverylocationfield"></a>
# **SetUserDeliveryLocationField**
> RestApiDefaultResponse SetUserDeliveryLocationField (int? userId, int? deliveryLocationId, SetUserDeliveryLocationFieldRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetUserDeliveryLocationFieldExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var deliveryLocationId = 56;  // int? | 
            var request = new SetUserDeliveryLocationFieldRequest(); // SetUserDeliveryLocationFieldRequest | 

            try
            {
                RestApiDefaultResponse result = apiInstance.SetUserDeliveryLocationField(userId, deliveryLocationId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SetUserDeliveryLocationField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **deliveryLocationId** | **int?**|  | 
 **request** | [**SetUserDeliveryLocationFieldRequest**](SetUserDeliveryLocationFieldRequest.md)|  | 

### Return type

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setuserlanguage"></a>
# **SetUserLanguage**
> RestApiDefaultResponse SetUserLanguage (int? userId, string languageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetUserLanguageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var languageId = languageId_example;  // string | 

            try
            {
                RestApiDefaultResponse result = apiInstance.SetUserLanguage(userId, languageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SetUserLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **languageId** | **string**|  | 

### Return type

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unblockuserphonenumber"></a>
# **UnblockUserPhoneNumber**
> RestApiDefaultResponse UnblockUserPhoneNumber (int? userId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UnblockUserPhoneNumberExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 

            try
            {
                RestApiDefaultResponse result = apiInstance.UnblockUserPhoneNumber(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UnblockUserPhoneNumber: " + e.Message );
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

[**RestApiDefaultResponse**](RestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

