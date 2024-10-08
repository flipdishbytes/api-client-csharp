# Flipdish.Api.StoreGroupsApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignStoresToStoreGroup**](StoreGroupsApi.md#assignstorestostoregroup) | **POST** /api/v1.0/{appId}/storegroups/{storeGroupId}/assignStores | 
[**CreateStoreGroup**](StoreGroupsApi.md#createstoregroup) | **POST** /api/v1.0/{appNameId}/storegroups | 
[**GetStoreGroup**](StoreGroupsApi.md#getstoregroup) | **GET** /api/v1.0/storegroups/{storeGroupId} | 
[**GetStoreGroups**](StoreGroupsApi.md#getstoregroups) | **GET** /api/v1.0/{appNameId}/storegroups | 
[**GetStoreGroupsExtended**](StoreGroupsApi.md#getstoregroupsextended) | **GET** /api/v1.0/{appNameId}/storegroups/extended | 
[**RemoveStoreGroup**](StoreGroupsApi.md#removestoregroup) | **DELETE** /api/v1.0/storegroups/{storeGroupId} | 
[**SetMenuMessagePerDeliveryType**](StoreGroupsApi.md#setmenumessageperdeliverytype) | **POST** /api/v1.0/storegroups/{storeGroupId}/{deliveryType}/MenuMessagePerDeliveryType | 
[**UpdateStoreGroup**](StoreGroupsApi.md#updatestoregroup) | **POST** /api/v1.0/storegroups/{storeGroupId} | 


<a name="assignstorestostoregroup"></a>
# **AssignStoresToStoreGroup**
> void AssignStoresToStoreGroup (string appId, int? storeGroupId, List<int?> storeIds)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AssignStoresToStoreGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreGroupsApi();
            var appId = appId_example;  // string | 
            var storeGroupId = 56;  // int? | 
            var storeIds = ;  // List<int?> | 

            try
            {
                apiInstance.AssignStoresToStoreGroup(appId, storeGroupId, storeIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreGroupsApi.AssignStoresToStoreGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeGroupId** | **int?**|  | 
 **storeIds** | **List&lt;int?&gt;**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstoregroup"></a>
# **CreateStoreGroup**
> RestApiResultStoreGroup CreateStoreGroup (string appNameId, StoreGroupBase storeGroup)



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
            var appNameId = appNameId_example;  // string | 
            var storeGroup = new StoreGroupBase(); // StoreGroupBase | 

            try
            {
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
 **appNameId** | **string**|  | 
 **storeGroup** | [**StoreGroupBase**](StoreGroupBase.md)|  | 

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
            var storeGroupId = 56;  // int? | 

            try
            {
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
 **storeGroupId** | **int?**|  | 

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
            var appNameId = appNameId_example;  // string | 
            var searchQuery = searchQuery_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
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
 **appNameId** | **string**|  | 
 **searchQuery** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

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
            var appNameId = appNameId_example;  // string | 
            var searchQuery = searchQuery_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var groupingRadius = 56;  // int? |  (optional) 

            try
            {
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
 **appNameId** | **string**|  | 
 **searchQuery** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
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
            var storeGroupId = 56;  // int? | 

            try
            {
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
 **storeGroupId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenumessageperdeliverytype"></a>
# **SetMenuMessagePerDeliveryType**
> void SetMenuMessagePerDeliveryType (int? storeGroupId, string deliveryType, string menuMessage)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetMenuMessagePerDeliveryTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreGroupsApi();
            var storeGroupId = 56;  // int? | 
            var deliveryType = deliveryType_example;  // string | 
            var menuMessage = menuMessage_example;  // string | 

            try
            {
                apiInstance.SetMenuMessagePerDeliveryType(storeGroupId, deliveryType, menuMessage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreGroupsApi.SetMenuMessagePerDeliveryType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeGroupId** | **int?**|  | 
 **deliveryType** | **string**|  | 
 **menuMessage** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestoregroup"></a>
# **UpdateStoreGroup**
> RestApiResultStoreGroupBase UpdateStoreGroup (int? storeGroupId, StoreGroupBase storeGroup)



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
            var storeGroupId = 56;  // int? | 
            var storeGroup = new StoreGroupBase(); // StoreGroupBase | 

            try
            {
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
 **storeGroupId** | **int?**|  | 
 **storeGroup** | [**StoreGroupBase**](StoreGroupBase.md)|  | 

### Return type

[**RestApiResultStoreGroupBase**](RestApiResultStoreGroupBase.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

