# Flipdish.Api.StoresApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveStore**](StoresApi.md#archivestore) | **POST** /api/v1.0/stores/{storeId}/archive | Archive store
[**AssignMenu**](StoresApi.md#assignmenu) | **POST** /api/v1.0/stores/{storeId}/menu/{menuId} | Assign Menu to Store
[**CloneStore**](StoresApi.md#clonestore) | **POST** /api/v1.0/stores/{storeId}/clone | Clone store with store clone settings
[**CreateBusinessHoursOverrideByStoreId**](StoresApi.md#createbusinesshoursoverridebystoreid) | **POST** /api/v1.0/stores/{storeId}/businesshoursoverrides | Create Business Hours Override for a store
[**CreateStore**](StoresApi.md#createstore) | **POST** /api/v1.0/stores | Create store with Store Group identifier
[**DeleteBusinessHoursOverride**](StoresApi.md#deletebusinesshoursoverride) | **DELETE** /api/v1.0/stores/{storeId}/businesshoursoverrides/{businessHoursOverrideId} | Delete Business Hours Override for a store
[**GetBankAccountForStore**](StoresApi.md#getbankaccountforstore) | **GET** /api/v1.0/stores/{storeId}/bankaccount | Get Stores Bank Account Id
[**GetBusinessHours**](StoresApi.md#getbusinesshours) | **GET** /api/v1.0/stores/{storeId}/availability/{deliveryType} | Get Business hours
[**GetBusinessHoursOverrideByStoreId**](StoresApi.md#getbusinesshoursoverridebystoreid) | **GET** /api/v1.0/stores/{storeId}/businesshoursoverrides | Get business hours overrides by store identifier
[**GetEndOfDayReport**](StoresApi.md#getendofdayreport) | **GET** /api/v1.0/stores/{storeId}/endofdayreport | Get store end of day report
[**GetPreOrderConfig**](StoresApi.md#getpreorderconfig) | **GET** /api/v1.0/stores/{storeId}/preorderconfig/{deliveryType} | Get the pre order config for a store, by type
[**GetPreOrderPreview**](StoresApi.md#getpreorderpreview) | **GET** /api/v1.0/stores/{storeId}/preorderconfig/{deliveryType}/preview | Get the Preview times of the pre-order configuration
[**GetProcessingFeeConfigsByStoreId**](StoresApi.md#getprocessingfeeconfigsbystoreid) | **GET** /api/v1.0/stores/{storeId}/processingfeeconfigs | Get processing fee configs by store identifier
[**GetProcessingFeeConfigsByStoreIdAndPaymentAccountType**](StoresApi.md#getprocessingfeeconfigsbystoreidandpaymentaccounttype) | **GET** /api/v1.0/stores/{storeId}/processingfeeconfigs/{paymentAccountType} | Get processing fee configs by store identifier
[**GetStoreById**](StoresApi.md#getstorebyid) | **GET** /api/v1.0/stores/{storeId} | Get store by identifier
[**GetStoreHeadersByAppId**](StoresApi.md#getstoreheadersbyappid) | **GET** /api/v1.0/{appId}/stores/header | Get all stores by app name id
[**GetStoreNetSales**](StoresApi.md#getstorenetsales) | **GET** /api/v1.0/{appId}/stores/stats | Get stores statistics by app name id and storeIds
[**GetStores**](StoresApi.md#getstores) | **GET** /api/v1.0/stores | Get all stores, excluding archived ones
[**GetStoresByAppId**](StoresApi.md#getstoresbyappid) | **GET** /api/v1.0/{appId}/stores | Get all stores by app name id
[**PublishStore**](StoresApi.md#publishstore) | **POST** /api/v1.0/stores/{storeId}/publish | Publish store
[**SetBusinessHours**](StoresApi.md#setbusinesshours) | **POST** /api/v1.0/stores/{storeId}/availability/{deliveryType} | Set Business hours
[**SetPreOrdeEnabled**](StoresApi.md#setpreordeenabled) | **POST** /api/v1.0/stores/{storeId}/preorderconfig/{deliveryType}/enabled | UPDATE pre order config for a store, by type
[**UnpublishStore**](StoresApi.md#unpublishstore) | **POST** /api/v1.0/stores/{storeId}/unpublish | Unpublish store
[**UpdatePreOrderConfig**](StoresApi.md#updatepreorderconfig) | **POST** /api/v1.0/stores/{storeId}/preorderconfig/{deliveryType} | UPDATE pre order config for a store, by type
[**UpdateStore**](StoresApi.md#updatestore) | **POST** /api/v1.0/stores/{storeId} | Update store by identifier
[**UpdateStoreAddress**](StoresApi.md#updatestoreaddress) | **POST** /api/v1.0/stores/{storeId}/address | Update store address
[**UpdateStoreAddressCoordinates**](StoresApi.md#updatestoreaddresscoordinates) | **POST** /api/v1.0/stores/{storeId}/address/coordinates | Update store address coordinates


<a name="archivestore"></a>
# **ArchiveStore**
> void ArchiveStore (int? storeId)

Archive store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ArchiveStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier

            try
            {
                // Archive store
                apiInstance.ArchiveStore(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.ArchiveStore: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignmenu"></a>
# **AssignMenu**
> RestApiArrayResultRestApiDefaultResponse AssignMenu (int? storeId, int? menuId)

Assign Menu to Store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class AssignMenuExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var menuId = 56;  // int? | Id of Menu to assign to store

            try
            {
                // Assign Menu to Store
                RestApiArrayResultRestApiDefaultResponse result = apiInstance.AssignMenu(storeId, menuId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.AssignMenu: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **menuId** | **int?**| Id of Menu to assign to store | 

### Return type

[**RestApiArrayResultRestApiDefaultResponse**](RestApiArrayResultRestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

<a name="getbankaccountforstore"></a>
# **GetBankAccountForStore**
> RestApiResultAssignedBankAccount GetBankAccountForStore (int? storeId)

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
    public class GetBankAccountForStoreExample
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
                RestApiResultAssignedBankAccount result = apiInstance.GetBankAccountForStore(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetBankAccountForStore: " + e.Message );
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

Get Business hours

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
            var deliveryType = deliveryType_example;  // string | Delivery type

            try
            {
                // Get Business hours
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
 **deliveryType** | **string**| Delivery type | 

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

<a name="getendofdayreport"></a>
# **GetEndOfDayReport**
> RestApiResultStoreEndOfDayReport GetEndOfDayReport (int? storeId, DateTime? date = null)

Get store end of day report

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetEndOfDayReportExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Store identifier (optional) 

            try
            {
                // Get store end of day report
                RestApiResultStoreEndOfDayReport result = apiInstance.GetEndOfDayReport(storeId, date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetEndOfDayReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **date** | **DateTime?**| Store identifier | [optional] 

### Return type

[**RestApiResultStoreEndOfDayReport**](RestApiResultStoreEndOfDayReport.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpreorderconfig"></a>
# **GetPreOrderConfig**
> RestApiResultPreOrderConfig GetPreOrderConfig (int? storeId, string deliveryType)

Get the pre order config for a store, by type

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPreOrderConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var deliveryType = deliveryType_example;  // string | \"delivery\" or \"pickup\"

            try
            {
                // Get the pre order config for a store, by type
                RestApiResultPreOrderConfig result = apiInstance.GetPreOrderConfig(storeId, deliveryType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetPreOrderConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **deliveryType** | **string**| \&quot;delivery\&quot; or \&quot;pickup\&quot; | 

### Return type

[**RestApiResultPreOrderConfig**](RestApiResultPreOrderConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpreorderpreview"></a>
# **GetPreOrderPreview**
> RestApiArrayResultPreOrderTime GetPreOrderPreview (int? storeId, string deliveryType, int? preOrderConfigLeadTimeMinutes = null, int? preOrderConfigIntervalMinutes = null, int? preOrderConfigMaxOrderAheadDays = null, bool? preOrderConfigIncludeAsap = null, bool? preOrderConfigIncludeMoreGranularInitialTime = null, string preOrderConfigCutOffTimePreviousDayBasic = null, string preOrderConfigCutOffTimeCurrentDayBasic = null, string preOrderConfigPreOrderTimeDisplayType = null, bool? preOrderConfigAlwaysAppearOpen = null, bool? preOrderConfigRequireExplicitSelectAlways = null)

Get the Preview times of the pre-order configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetPreOrderPreviewExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var deliveryType = deliveryType_example;  // string | \"delivery\" or \"pickup\"
            var preOrderConfigLeadTimeMinutes = 56;  // int? | Lead Time in Minutes (optional) 
            var preOrderConfigIntervalMinutes = 56;  // int? | Interval in minutes (optional) 
            var preOrderConfigMaxOrderAheadDays = 56;  // int? | Max Days to order ahead (optional) 
            var preOrderConfigIncludeAsap = true;  // bool? | Show ASAP as option (optional) 
            var preOrderConfigIncludeMoreGranularInitialTime = true;  // bool? | Granual Init' Time (optional) 
            var preOrderConfigCutOffTimePreviousDayBasic = preOrderConfigCutOffTimePreviousDayBasic_example;  // string | Cut off time previous day (optional) 
            var preOrderConfigCutOffTimeCurrentDayBasic = preOrderConfigCutOffTimeCurrentDayBasic_example;  // string | Cut off time current day (optional) 
            var preOrderConfigPreOrderTimeDisplayType = preOrderConfigPreOrderTimeDisplayType_example;  // string | Type of time displayed. (optional) 
            var preOrderConfigAlwaysAppearOpen = true;  // bool? | Specifies whether a customer can pre-order outside the store opening hours or not. (optional) 
            var preOrderConfigRequireExplicitSelectAlways = true;  // bool? | Force customer to select collection time. (optional) 

            try
            {
                // Get the Preview times of the pre-order configuration
                RestApiArrayResultPreOrderTime result = apiInstance.GetPreOrderPreview(storeId, deliveryType, preOrderConfigLeadTimeMinutes, preOrderConfigIntervalMinutes, preOrderConfigMaxOrderAheadDays, preOrderConfigIncludeAsap, preOrderConfigIncludeMoreGranularInitialTime, preOrderConfigCutOffTimePreviousDayBasic, preOrderConfigCutOffTimeCurrentDayBasic, preOrderConfigPreOrderTimeDisplayType, preOrderConfigAlwaysAppearOpen, preOrderConfigRequireExplicitSelectAlways);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetPreOrderPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **deliveryType** | **string**| \&quot;delivery\&quot; or \&quot;pickup\&quot; | 
 **preOrderConfigLeadTimeMinutes** | **int?**| Lead Time in Minutes | [optional] 
 **preOrderConfigIntervalMinutes** | **int?**| Interval in minutes | [optional] 
 **preOrderConfigMaxOrderAheadDays** | **int?**| Max Days to order ahead | [optional] 
 **preOrderConfigIncludeAsap** | **bool?**| Show ASAP as option | [optional] 
 **preOrderConfigIncludeMoreGranularInitialTime** | **bool?**| Granual Init&#39; Time | [optional] 
 **preOrderConfigCutOffTimePreviousDayBasic** | **string**| Cut off time previous day | [optional] 
 **preOrderConfigCutOffTimeCurrentDayBasic** | **string**| Cut off time current day | [optional] 
 **preOrderConfigPreOrderTimeDisplayType** | **string**| Type of time displayed. | [optional] 
 **preOrderConfigAlwaysAppearOpen** | **bool?**| Specifies whether a customer can pre-order outside the store opening hours or not. | [optional] 
 **preOrderConfigRequireExplicitSelectAlways** | **bool?**| Force customer to select collection time. | [optional] 

### Return type

[**RestApiArrayResultPreOrderTime**](RestApiArrayResultPreOrderTime.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
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

<a name="getstoreheadersbyappid"></a>
# **GetStoreHeadersByAppId**
> RestApiPaginationResultStoreHeader GetStoreHeadersByAppId (string appId, string storeNameQuery = null, int? page = null, int? limit = null)

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
    public class GetStoreHeadersByAppIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var appId = appId_example;  // string | App Name Id
            var storeNameQuery = storeNameQuery_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Get all stores by app name id
                RestApiPaginationResultStoreHeader result = apiInstance.GetStoreHeadersByAppId(appId, storeNameQuery, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreHeadersByAppId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name Id | 
 **storeNameQuery** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultStoreHeader**](RestApiPaginationResultStoreHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorenetsales"></a>
# **GetStoreNetSales**
> RestApiArrayResultStoreStatistics GetStoreNetSales (string appId, List<int?> storeId)

Get stores statistics by app name id and storeIds

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
            var appId = appId_example;  // string | App Name Id
            var storeId = new List<int?>(); // List<int?> | Store Ids

            try
            {
                // Get stores statistics by app name id and storeIds
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
 **appId** | **string**| App Name Id | 
 **storeId** | [**List&lt;int?&gt;**](int?.md)| Store Ids | 

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

Get all stores, excluding archived ones

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
                // Get all stores, excluding archived ones
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

<a name="publishstore"></a>
# **PublishStore**
> void PublishStore (int? storeId)

Publish store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PublishStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier

            try
            {
                // Publish store
                apiInstance.PublishStore(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.PublishStore: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbusinesshours"></a>
# **SetBusinessHours**
> RestApiResultBusinessHoursPeriod SetBusinessHours (int? storeId, string deliveryType, BusinessHoursPeriodBase businessHoursPeriod)

Set Business hours

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
            var deliveryType = deliveryType_example;  // string | Delivery type
            var businessHoursPeriod = new BusinessHoursPeriodBase(); // BusinessHoursPeriodBase | Business Hours Period

            try
            {
                // Set Business hours
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
 **deliveryType** | **string**| Delivery type | 
 **businessHoursPeriod** | [**BusinessHoursPeriodBase**](BusinessHoursPeriodBase.md)| Business Hours Period | 

### Return type

[**RestApiResultBusinessHoursPeriod**](RestApiResultBusinessHoursPeriod.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpreordeenabled"></a>
# **SetPreOrdeEnabled**
> RestApiArrayResultRestApiDefaultResponse SetPreOrdeEnabled (int? storeId, string deliveryType, bool? enabled)

UPDATE pre order config for a store, by type

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetPreOrdeEnabledExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var deliveryType = deliveryType_example;  // string | \"delivery\" or \"pickup\"
            var enabled = true;  // bool? | Update pre order config values

            try
            {
                // UPDATE pre order config for a store, by type
                RestApiArrayResultRestApiDefaultResponse result = apiInstance.SetPreOrdeEnabled(storeId, deliveryType, enabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.SetPreOrdeEnabled: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **deliveryType** | **string**| \&quot;delivery\&quot; or \&quot;pickup\&quot; | 
 **enabled** | **bool?**| Update pre order config values | 

### Return type

[**RestApiArrayResultRestApiDefaultResponse**](RestApiArrayResultRestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unpublishstore"></a>
# **UnpublishStore**
> void UnpublishStore (int? storeId)

Unpublish store

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UnpublishStoreExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier

            try
            {
                // Unpublish store
                apiInstance.UnpublishStore(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.UnpublishStore: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepreorderconfig"></a>
# **UpdatePreOrderConfig**
> RestApiArrayResultRestApiDefaultResponse UpdatePreOrderConfig (int? storeId, string deliveryType, PreOrderConfig preOrderConfig)

UPDATE pre order config for a store, by type

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdatePreOrderConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | Store identifier
            var deliveryType = deliveryType_example;  // string | \"delivery\" or \"pickup\"
            var preOrderConfig = new PreOrderConfig(); // PreOrderConfig | Update pre order config values

            try
            {
                // UPDATE pre order config for a store, by type
                RestApiArrayResultRestApiDefaultResponse result = apiInstance.UpdatePreOrderConfig(storeId, deliveryType, preOrderConfig);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.UpdatePreOrderConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**| Store identifier | 
 **deliveryType** | **string**| \&quot;delivery\&quot; or \&quot;pickup\&quot; | 
 **preOrderConfig** | [**PreOrderConfig**](PreOrderConfig.md)| Update pre order config values | 

### Return type

[**RestApiArrayResultRestApiDefaultResponse**](RestApiArrayResultRestApiDefaultResponse.md)

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

