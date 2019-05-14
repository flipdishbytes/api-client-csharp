# Flipdish.Api.StoresApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloneStore**](StoresApi.md#clonestore) | **POST** /api/v1.0/stores/{storeId}/clone | Clone store with store clone settings
[**CreateBusinessHoursOverrideByStoreId**](StoresApi.md#createbusinesshoursoverridebystoreid) | **POST** /api/v1.0/stores/{storeId}/businesshoursoverrides | Create Business Hours Override for a store
[**CreateStore**](StoresApi.md#createstore) | **POST** /api/v1.0/stores | Create store with Store Group identifier
[**DeleteBusinessHoursOverride**](StoresApi.md#deletebusinesshoursoverride) | **DELETE** /api/v1.0/stores/{storeId}/businesshoursoverrides/{businessHoursOverrideId} | Delete Business Hours Override for a store
[**GetBankAccount**](StoresApi.md#getbankaccount) | **GET** /api/v1.0/stores/{storeId}/bankaccount | Get Stores Bank Account Id
[**GetBusinessHours**](StoresApi.md#getbusinesshours) | **GET** /api/v1.0/stores/{storeId}/availability/{deliveryType} | Get Bussiness hours
[**GetBusinessHoursOverrideByStoreId**](StoresApi.md#getbusinesshoursoverridebystoreid) | **GET** /api/v1.0/stores/{storeId}/businesshoursoverrides | Get business hours overrides by store identifier
[**GetProcessingFeeConfigsByStoreId**](StoresApi.md#getprocessingfeeconfigsbystoreid) | **GET** /api/v1.0/stores/{storeId}/processingfeeconfigs | Get processing fee configs by store identifier
[**GetProcessingFeeConfigsByStoreIdAndPaymentAccountType**](StoresApi.md#getprocessingfeeconfigsbystoreidandpaymentaccounttype) | **GET** /api/v1.0/stores/{storeId}/processingfeeconfigs/{paymentAccountType} | Get processing fee configs by store identifier
[**GetStoreById**](StoresApi.md#getstorebyid) | **GET** /api/v1.0/stores/{storeId} | Get store by identifier
[**GetStoreNetSales**](StoresApi.md#getstorenetsales) | **GET** /api/v1.0/{appId}/stores/stats | 
[**GetStores**](StoresApi.md#getstores) | **GET** /api/v1.0/stores | Get all stores
[**GetStoresByAppId**](StoresApi.md#getstoresbyappid) | **GET** /api/v1.0/{appId}/stores | Get all stores by app name id
[**SetBusinessHours**](StoresApi.md#setbusinesshours) | **POST** /api/v1.0/stores/{storeId}/availability/{deliveryType} | Set Bussiness hours
[**UpdateStore**](StoresApi.md#updatestore) | **POST** /api/v1.0/stores/{storeId} | Update store by identifier
[**UpdateStoreAddress**](StoresApi.md#updatestoreaddress) | **POST** /api/v1.0/stores/{storeId}/address | Update store address
[**UpdateStoreAddressCoordinates**](StoresApi.md#updatestoreaddresscoordinates) | **POST** /api/v1.0/stores/{storeId}/address/coordinates | Update store address coordinates


<a name="clonestore"></a>
# **CloneStore**
> RestApiResultStore CloneStore (int? storeId, StoreCloneSettings settings)

Clone store with store clone settings

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CloneStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var settings = new StoreCloneSettings(); // StoreCloneSettings | Settings for cloning the store

            try
            {
                // Clone store with store clone settings
                RestApiResultStore result = apiInstance.CloneStore(storeId, settings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.CloneStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **settings** | [**StoreCloneSettings**](StoreCloneSettings.md)| Settings for cloning the store | 

### Return type

[**RestApiResultStore**](RestApiResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbusinesshoursoverridebystoreid"></a>
# **CreateBusinessHoursOverrideByStoreId**
> RestApiResultBusinessHoursOverride CreateBusinessHoursOverrideByStoreId (int? storeId, BusinessHoursOverrideBase businessHoursOverride)

Create Business Hours Override for a store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateBusinessHoursOverrideByStoreIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var businessHoursOverride = new BusinessHoursOverrideBase(); // BusinessHoursOverrideBase | Business Hours Override

            try
            {
                // Create Business Hours Override for a store
                RestApiResultBusinessHoursOverride result = apiInstance.CreateBusinessHoursOverrideByStoreId(storeId, businessHoursOverride);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.CreateBusinessHoursOverrideByStoreId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **businessHoursOverride** | [**BusinessHoursOverrideBase**](BusinessHoursOverrideBase.md)| Business Hours Override | 

### Return type

[**RestApiResultBusinessHoursOverride**](RestApiResultBusinessHoursOverride.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstore"></a>
# **CreateStore**
> RestApiResultStore CreateStore (int? storeGroupId, StoreCreateBase store)

Create store with Store Group identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeGroupId = 56;  // int? | Store Group identifier
            var store = new StoreCreateBase(); // StoreCreateBase | Store

            try
            {
                // Create store with Store Group identifier
                RestApiResultStore result = apiInstance.CreateStore(storeGroupId, store);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.CreateStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeGroupId** | **int?**| Store Group identifier | 
 **store** | [**StoreCreateBase**](StoreCreateBase.md)| Store | 

### Return type

[**RestApiResultStore**](RestApiResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebusinesshoursoverride"></a>
# **DeleteBusinessHoursOverride**
> RestApiArrayResultRestApiDefaultResponse DeleteBusinessHoursOverride (int? storeId, int? businessHoursOverrideId)

Delete Business Hours Override for a store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteBusinessHoursOverrideExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | 
            var businessHoursOverrideId = 56;  // int? | 

            try
            {
                // Delete Business Hours Override for a store
                RestApiArrayResultRestApiDefaultResponse result = apiInstance.DeleteBusinessHoursOverride(storeId, businessHoursOverrideId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.DeleteBusinessHoursOverride: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **businessHoursOverrideId** | **int?**|  | 

### Return type

[**RestApiArrayResultRestApiDefaultResponse**](RestApiArrayResultRestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbankaccount"></a>
# **GetBankAccount**
> RestApiResultAssignedBankAccount GetBankAccount (int? storeId)

Get Stores Bank Account Id

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetBankAccountExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier

            try
            {
                // Get Stores Bank Account Id
                RestApiResultAssignedBankAccount result = apiInstance.GetBankAccount(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetBankAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 

### Return type

[**RestApiResultAssignedBankAccount**](RestApiResultAssignedBankAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbusinesshours"></a>
# **GetBusinessHours**
> RestApiArrayResultBusinessHoursPeriod GetBusinessHours (int? storeId, string deliveryType)

Get Bussiness hours

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetBusinessHoursExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var deliveryType = deliveryType_example;  // string | Deliery type

            try
            {
                // Get Bussiness hours
                RestApiArrayResultBusinessHoursPeriod result = apiInstance.GetBusinessHours(storeId, deliveryType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetBusinessHours: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **deliveryType** | **string**| Deliery type | 

### Return type

[**RestApiArrayResultBusinessHoursPeriod**](RestApiArrayResultBusinessHoursPeriod.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbusinesshoursoverridebystoreid"></a>
# **GetBusinessHoursOverrideByStoreId**
> RestApiPaginationResultBusinessHoursOverride GetBusinessHoursOverrideByStoreId (int? storeId, DateTime? after = null, int? page = null, int? limit = null)

Get business hours overrides by store identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetBusinessHoursOverrideByStoreIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var after = 2013-10-20T19:20:30+01:00;  // DateTime? | Return results that ended after this datetime. Default value is the current datetime. (optional) 
            var page = 56;  // int? | Requested page index (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 

            try
            {
                // Get business hours overrides by store identifier
                RestApiPaginationResultBusinessHoursOverride result = apiInstance.GetBusinessHoursOverrideByStoreId(storeId, after, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetBusinessHoursOverrideByStoreId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **after** | **DateTime?**| Return results that ended after this datetime. Default value is the current datetime. | [optional] 
 **page** | **int?**| Requested page index | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 

### Return type

[**RestApiPaginationResultBusinessHoursOverride**](RestApiPaginationResultBusinessHoursOverride.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessingfeeconfigsbystoreid"></a>
# **GetProcessingFeeConfigsByStoreId**
> RestApiArrayResultProcessingFeeConfig GetProcessingFeeConfigsByStoreId (int? storeId, string appNameId = null)

Get processing fee configs by store identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetProcessingFeeConfigsByStoreIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var appNameId = appNameId_example;  // string | App Name Id(Not used, still here for compatability reasons) (optional) 

            try
            {
                // Get processing fee configs by store identifier
                RestApiArrayResultProcessingFeeConfig result = apiInstance.GetProcessingFeeConfigsByStoreId(storeId, appNameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetProcessingFeeConfigsByStoreId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **appNameId** | **string**| App Name Id(Not used, still here for compatability reasons) | [optional] 

### Return type

[**RestApiArrayResultProcessingFeeConfig**](RestApiArrayResultProcessingFeeConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessingfeeconfigsbystoreidandpaymentaccounttype"></a>
# **GetProcessingFeeConfigsByStoreIdAndPaymentAccountType**
> RestApiResultProcessingFeeConfig GetProcessingFeeConfigsByStoreIdAndPaymentAccountType (int? storeId, string paymentAccountType, string appNameId = null)

Get processing fee configs by store identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetProcessingFeeConfigsByStoreIdAndPaymentAccountTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var paymentAccountType = paymentAccountType_example;  // string | 
            var appNameId = appNameId_example;  // string | App Name Id(Not used, still here for compatability reasons) (optional) 

            try
            {
                // Get processing fee configs by store identifier
                RestApiResultProcessingFeeConfig result = apiInstance.GetProcessingFeeConfigsByStoreIdAndPaymentAccountType(storeId, paymentAccountType, appNameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetProcessingFeeConfigsByStoreIdAndPaymentAccountType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **paymentAccountType** | **string**|  | 
 **appNameId** | **string**| App Name Id(Not used, still here for compatability reasons) | [optional] 

### Return type

[**RestApiResultProcessingFeeConfig**](RestApiResultProcessingFeeConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorebyid"></a>
# **GetStoreById**
> RestApiResultStore GetStoreById (int? storeId)

Get store by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier

            try
            {
                // Get store by identifier
                RestApiResultStore result = apiInstance.GetStoreById(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 

### Return type

[**RestApiResultStore**](RestApiResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorenetsales"></a>
# **GetStoreNetSales**
> RestApiArrayResultStoreStatistics GetStoreNetSales (string appId, List<int?> storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreNetSalesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var appId = appId_example;  // string | 
            var storeId = new List<int?>(); // List<int?> | 

            try
            {
                RestApiArrayResultStoreStatistics result = apiInstance.GetStoreNetSales(appId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreNetSales: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | 

### Return type

[**RestApiArrayResultStoreStatistics**](RestApiArrayResultStoreStatistics.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstores"></a>
# **GetStores**
> RestApiPaginationResultStore GetStores (string searchQuery = null, int? page = null, int? limit = null, int? storeGroupId = null)

Get all stores

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoresExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var searchQuery = searchQuery_example;  // string | Search query (optional) 
            var page = 56;  // int? | Requested page index (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 
            var storeGroupId = 56;  // int? | Store Group Id (optional) 

            try
            {
                // Get all stores
                RestApiPaginationResultStore result = apiInstance.GetStores(searchQuery, page, limit, storeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStores: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchQuery** | **string**| Search query | [optional] 
 **page** | **int?**| Requested page index | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 
 **storeGroupId** | **int?**| Store Group Id | [optional] 

### Return type

[**RestApiPaginationResultStore**](RestApiPaginationResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoresbyappid"></a>
# **GetStoresByAppId**
> RestApiPaginationResultStore GetStoresByAppId (string appId, string searchQuery = null, int? page = null, int? limit = null)

Get all stores by app name id

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoresByAppIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var appId = appId_example;  // string | App Name Id
            var searchQuery = searchQuery_example;  // string | Search query (optional) 
            var page = 56;  // int? | Requested page index (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 

            try
            {
                // Get all stores by app name id
                RestApiPaginationResultStore result = apiInstance.GetStoresByAppId(appId, searchQuery, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoresByAppId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name Id | 
 **searchQuery** | **string**| Search query | [optional] 
 **page** | **int?**| Requested page index | [optional] 
 **limit** | **int?**| Requested page limit | [optional] 

### Return type

[**RestApiPaginationResultStore**](RestApiPaginationResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbusinesshours"></a>
# **SetBusinessHours**
> RestApiResultBusinessHoursPeriod SetBusinessHours (int? storeId, string deliveryType, BusinessHoursPeriodBase businessHoursPeriod)

Set Bussiness hours

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetBusinessHoursExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var deliveryType = deliveryType_example;  // string | Deliery type
            var businessHoursPeriod = new BusinessHoursPeriodBase(); // BusinessHoursPeriodBase | Business Hours Period

            try
            {
                // Set Bussiness hours
                RestApiResultBusinessHoursPeriod result = apiInstance.SetBusinessHours(storeId, deliveryType, businessHoursPeriod);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.SetBusinessHours: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **deliveryType** | **string**| Deliery type | 
 **businessHoursPeriod** | [**BusinessHoursPeriodBase**](BusinessHoursPeriodBase.md)| Business Hours Period | 

### Return type

[**RestApiResultBusinessHoursPeriod**](RestApiResultBusinessHoursPeriod.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestore"></a>
# **UpdateStore**
> RestApiResultStore UpdateStore (int? storeId, StoreBase store)

Update store by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store Group identifier
            var store = new StoreBase(); // StoreBase | Store

            try
            {
                // Update store by identifier
                RestApiResultStore result = apiInstance.UpdateStore(storeId, store);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.UpdateStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store Group identifier | 
 **store** | [**StoreBase**](StoreBase.md)| Store | 

### Return type

[**RestApiResultStore**](RestApiResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestoreaddress"></a>
# **UpdateStoreAddress**
> RestApiResultStoreAddress UpdateStoreAddress (int? storeId, StoreAddressBase storeAddress)

Update store address

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateStoreAddressExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var storeAddress = new StoreAddressBase(); // StoreAddressBase | Store address

            try
            {
                // Update store address
                RestApiResultStoreAddress result = apiInstance.UpdateStoreAddress(storeId, storeAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.UpdateStoreAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **storeAddress** | [**StoreAddressBase**](StoreAddressBase.md)| Store address | 

### Return type

[**RestApiResultStoreAddress**](RestApiResultStoreAddress.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestoreaddresscoordinates"></a>
# **UpdateStoreAddressCoordinates**
> RestApiResultCoordinates UpdateStoreAddressCoordinates (int? storeId, Coordinates coordinates, string appNameId = null)

Update store address coordinates

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateStoreAddressCoordinatesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var coordinates = new Coordinates(); // Coordinates | Store address coordinates
            var appNameId = appNameId_example;  // string | App Name Id(Not used, still here for compatability reasons) (optional) 

            try
            {
                // Update store address coordinates
                RestApiResultCoordinates result = apiInstance.UpdateStoreAddressCoordinates(storeId, coordinates, appNameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.UpdateStoreAddressCoordinates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **coordinates** | [**Coordinates**](Coordinates.md)| Store address coordinates | 
 **appNameId** | **string**| App Name Id(Not used, still here for compatability reasons) | [optional] 

### Return type

[**RestApiResultCoordinates**](RestApiResultCoordinates.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

