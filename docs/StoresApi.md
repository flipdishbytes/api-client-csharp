# Flipdish.Api.StoresApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveStore**](StoresApi.md#archivestore) | **POST** /api/v1.0/stores/{storeId}/archive | 
[**AssignMenu**](StoresApi.md#assignmenu) | **POST** /api/v1.0/stores/{storeId}/menu/{menuId} | 
[**CloneStore**](StoresApi.md#clonestore) | **POST** /api/v1.0/stores/{storeId}/clone | 
[**ConfigureStoreServiceCharge**](StoresApi.md#configurestoreservicecharge) | **POST** /api/v1.0/stores/{storeId}/servicecharge | 
[**CreateBusinessHoursOverrideByStoreId**](StoresApi.md#createbusinesshoursoverridebystoreid) | **POST** /api/v1.0/stores/{storeId}/businesshoursoverrides | 
[**CreateStore**](StoresApi.md#createstore) | **POST** /api/v1.0/stores | 
[**CreateStoreInProperty**](StoresApi.md#createstoreinproperty) | **POST** /api/v1.0/properties/{propertyId}/stores | 
[**DeleteBusinessHoursOverride**](StoresApi.md#deletebusinesshoursoverride) | **DELETE** /api/v1.0/stores/{storeId}/businesshoursoverrides/{businessHoursOverrideId} | 
[**GetBankAccountForStore**](StoresApi.md#getbankaccountforstore) | **GET** /api/v1.0/stores/{storeId}/bankaccount | 
[**GetBusinessHours**](StoresApi.md#getbusinesshours) | **GET** /api/v1.0/stores/{storeId}/availability/{deliveryType} | 
[**GetBusinessHoursOverrideByStoreId**](StoresApi.md#getbusinesshoursoverridebystoreid) | **GET** /api/v1.0/stores/{storeId}/businesshoursoverrides | 
[**GetEndOfDayReport**](StoresApi.md#getendofdayreport) | **GET** /api/v1.0/stores/{storeId}/endofdayreport | 
[**GetPreOrderConfig**](StoresApi.md#getpreorderconfig) | **GET** /api/v1.0/stores/{storeId}/preorderconfig/{deliveryType} | 
[**GetPreOrderPreview**](StoresApi.md#getpreorderpreview) | **GET** /api/v1.0/stores/{storeId}/preorderconfig/{deliveryType}/preview | 
[**GetProcessingFeeConfigsByStoreId**](StoresApi.md#getprocessingfeeconfigsbystoreid) | **GET** /api/v1.0/stores/{storeId}/processingfeeconfigs | 
[**GetProcessingFeeConfigsByStoreIdAndPaymentAccountType**](StoresApi.md#getprocessingfeeconfigsbystoreidandpaymentaccounttype) | **GET** /api/v1.0/stores/{storeId}/processingfeeconfigs/{paymentAccountType} | 
[**GetStoreById**](StoresApi.md#getstorebyid) | **GET** /api/v1.0/stores/{storeId} | 
[**GetStoreDeliveryFeeConfig**](StoresApi.md#getstoredeliveryfeeconfig) | **GET** /api/v1.0/stores/{storeId}/feeConfig/deliveryZones | 
[**GetStoreFeeConfig**](StoresApi.md#getstorefeeconfig) | **GET** /api/v1.0/stores/{storeId}/feeConfig | 
[**GetStoreHeadersByAppId**](StoresApi.md#getstoreheadersbyappid) | **GET** /api/v1.0/{appId}/stores/header | 
[**GetStoreLeadTimes**](StoresApi.md#getstoreleadtimes) | **GET** /api/v1.0/stores/{storeId}/leadTimes | 
[**GetStoreNetSales**](StoresApi.md#getstorenetsales) | **GET** /api/v1.0/{appId}/stores/stats | 
[**GetStoreServiceCharge**](StoresApi.md#getstoreservicecharge) | **GET** /api/v1.0/stores/{storeId}/servicecharge | 
[**GetStores**](StoresApi.md#getstores) | **GET** /api/v1.0/stores | 
[**GetStoresByAppId**](StoresApi.md#getstoresbyappid) | **GET** /api/v1.0/{appId}/stores | 
[**GetStoresByStoreIdWithValidations**](StoresApi.md#getstoresbystoreidwithvalidations) | **GET** /api/v1.0/{appId}/storevalidation/kiosk | 
[**PublishStore**](StoresApi.md#publishstore) | **POST** /api/v1.0/stores/{storeId}/publish | 
[**PutStoreDeliveryFeeConfig**](StoresApi.md#putstoredeliveryfeeconfig) | **PUT** /api/v1.0/stores/{storeId}/feeConfig/deliveryZones | 
[**SetBusinessHours**](StoresApi.md#setbusinesshours) | **POST** /api/v1.0/stores/{storeId}/availability/{deliveryType} | 
[**SetPreOrdeEnabled**](StoresApi.md#setpreordeenabled) | **POST** /api/v1.0/stores/{storeId}/preorderconfig/{deliveryType}/enabled | 
[**SetStoreLeadTimes**](StoresApi.md#setstoreleadtimes) | **POST** /api/v1.0/stores/{storeId}/leadTimes | 
[**SupportedSalesChannelsTypes**](StoresApi.md#supportedsaleschannelstypes) | **POST** /api/v1.0/properties/{propertyId}/stores/{storeId}/supportedSalesChannels | 
[**UnpublishStore**](StoresApi.md#unpublishstore) | **POST** /api/v1.0/stores/{storeId}/unpublish | 
[**UpdatePreOrderConfig**](StoresApi.md#updatepreorderconfig) | **POST** /api/v1.0/stores/{storeId}/preorderconfig/{deliveryType} | 
[**UpdateStore**](StoresApi.md#updatestore) | **POST** /api/v1.0/stores/{storeId} | 
[**UpdateStoreAddress**](StoresApi.md#updatestoreaddress) | **POST** /api/v1.0/stores/{storeId}/address | 
[**UpdateStoreAddressCoordinates**](StoresApi.md#updatestoreaddresscoordinates) | **POST** /api/v1.0/stores/{storeId}/address/coordinates | 
[**UpdateStoreAddressForm**](StoresApi.md#updatestoreaddressform) | **POST** /api/v1.0/stores/{storeId}/addressform | 


<a name="archivestore"></a>
# **ArchiveStore**
> void ArchiveStore (int? storeId)



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
            var storeId = 56;  // int? | 

            try
            {
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
 **storeId** | **int?**|  | 

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
            var storeId = 56;  // int? | 
            var menuId = 56;  // int? | 

            try
            {
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
 **storeId** | **int?**|  | 
 **menuId** | **int?**|  | 

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
            var storeId = 56;  // int? | 
            var settings = new StoreCloneSettings(); // StoreCloneSettings | 

            try
            {
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
 **storeId** | **int?**|  | 
 **settings** | [**StoreCloneSettings**](StoreCloneSettings.md)|  | 

### Return type

[**RestApiResultStore**](RestApiResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurestoreservicecharge"></a>
# **ConfigureStoreServiceCharge**
> RestApiResultServiceCharge ConfigureStoreServiceCharge (int? storeId, ServiceCharge serviceCharge)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class ConfigureStoreServiceChargeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | 
            var serviceCharge = new ServiceCharge(); // ServiceCharge | 

            try
            {
                RestApiResultServiceCharge result = apiInstance.ConfigureStoreServiceCharge(storeId, serviceCharge);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.ConfigureStoreServiceCharge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **serviceCharge** | [**ServiceCharge**](ServiceCharge.md)|  | 

### Return type

[**RestApiResultServiceCharge**](RestApiResultServiceCharge.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbusinesshoursoverridebystoreid"></a>
# **CreateBusinessHoursOverrideByStoreId**
> RestApiResultBusinessHoursOverride CreateBusinessHoursOverrideByStoreId (int? storeId, BusinessHoursOverrideBase businessHoursOverride)



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
            var storeId = 56;  // int? | 
            var businessHoursOverride = new BusinessHoursOverrideBase(); // BusinessHoursOverrideBase | 

            try
            {
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
 **storeId** | **int?**|  | 
 **businessHoursOverride** | [**BusinessHoursOverrideBase**](BusinessHoursOverrideBase.md)|  | 

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
            var storeGroupId = 56;  // int? | 
            var store = new StoreCreateBase(); // StoreCreateBase | 

            try
            {
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
 **storeGroupId** | **int?**|  | 
 **store** | [**StoreCreateBase**](StoreCreateBase.md)|  | 

### Return type

[**RestApiResultStore**](RestApiResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstoreinproperty"></a>
# **CreateStoreInProperty**
> RestApiResultStore CreateStoreInProperty (int? storeGroupId, string propertyId, StoreCreateBase store, bool? autoAssignMenu = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateStoreInPropertyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeGroupId = 56;  // int? | 
            var propertyId = propertyId_example;  // string | 
            var store = new StoreCreateBase(); // StoreCreateBase | 
            var autoAssignMenu = true;  // bool? |  (optional) 

            try
            {
                RestApiResultStore result = apiInstance.CreateStoreInProperty(storeGroupId, propertyId, store, autoAssignMenu);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.CreateStoreInProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeGroupId** | **int?**|  | 
 **propertyId** | **string**|  | 
 **store** | [**StoreCreateBase**](StoreCreateBase.md)|  | 
 **autoAssignMenu** | **bool?**|  | [optional] 

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
            var storeId = 56;  // int? | 

            try
            {
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
 **storeId** | **int?**|  | 

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
            var storeId = 56;  // int? | 
            var deliveryType = deliveryType_example;  // string | 

            try
            {
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
 **storeId** | **int?**|  | 
 **deliveryType** | **string**|  | 

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
            var storeId = 56;  // int? | 
            var after = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
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
 **storeId** | **int?**|  | 
 **after** | **DateTime?**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

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
            var storeId = 56;  // int? | 
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
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
 **storeId** | **int?**|  | 
 **date** | **DateTime?**|  | [optional] 

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
            var storeId = 56;  // int? | 
            var deliveryType = deliveryType_example;  // string | 

            try
            {
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
 **storeId** | **int?**|  | 
 **deliveryType** | **string**|  | 

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
            var storeId = 56;  // int? | 
            var deliveryType = deliveryType_example;  // string | 
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
 **storeId** | **int?**|  | 
 **deliveryType** | **string**|  | 
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
            var storeId = 56;  // int? | 
            var appNameId = appNameId_example;  // string |  (optional) 

            try
            {
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
 **storeId** | **int?**|  | 
 **appNameId** | **string**|  | [optional] 

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
            var storeId = 56;  // int? | 
            var paymentAccountType = paymentAccountType_example;  // string | 
            var appNameId = appNameId_example;  // string |  (optional) 

            try
            {
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
 **storeId** | **int?**|  | 
 **paymentAccountType** | **string**|  | 
 **appNameId** | **string**|  | [optional] 

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
            var storeId = 56;  // int? | 

            try
            {
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
 **storeId** | **int?**|  | 

### Return type

[**RestApiResultStore**](RestApiResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoredeliveryfeeconfig"></a>
# **GetStoreDeliveryFeeConfig**
> RestApiArrayResultStoreDeliveryZoneFeeConfig GetStoreDeliveryFeeConfig (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreDeliveryFeeConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | 

            try
            {
                RestApiArrayResultStoreDeliveryZoneFeeConfig result = apiInstance.GetStoreDeliveryFeeConfig(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreDeliveryFeeConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 

### Return type

[**RestApiArrayResultStoreDeliveryZoneFeeConfig**](RestApiArrayResultStoreDeliveryZoneFeeConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorefeeconfig"></a>
# **GetStoreFeeConfig**
> StoreFeeConfig GetStoreFeeConfig (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreFeeConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | 

            try
            {
                StoreFeeConfig result = apiInstance.GetStoreFeeConfig(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreFeeConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 

### Return type

[**StoreFeeConfig**](StoreFeeConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoreheadersbyappid"></a>
# **GetStoreHeadersByAppId**
> RestApiPaginationResultStoreHeader GetStoreHeadersByAppId (string appId, string storeNameQuery = null, string salesChannelType = null, int? page = null, int? limit = null)



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
            var appId = appId_example;  // string | 
            var storeNameQuery = storeNameQuery_example;  // string |  (optional) 
            var salesChannelType = salesChannelType_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                RestApiPaginationResultStoreHeader result = apiInstance.GetStoreHeadersByAppId(appId, storeNameQuery, salesChannelType, page, limit);
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
 **appId** | **string**|  | 
 **storeNameQuery** | **string**|  | [optional] 
 **salesChannelType** | **string**|  | [optional] 
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

<a name="getstoreleadtimes"></a>
# **GetStoreLeadTimes**
> RestApiResultOrderLeadTimes GetStoreLeadTimes (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreLeadTimesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | 

            try
            {
                RestApiResultOrderLeadTimes result = apiInstance.GetStoreLeadTimes(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreLeadTimes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 

### Return type

[**RestApiResultOrderLeadTimes**](RestApiResultOrderLeadTimes.md)

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

<a name="getstoreservicecharge"></a>
# **GetStoreServiceCharge**
> ServiceCharge GetStoreServiceCharge (int? storeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoreServiceChargeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | 

            try
            {
                ServiceCharge result = apiInstance.GetStoreServiceCharge(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreServiceCharge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 

### Return type

[**ServiceCharge**](ServiceCharge.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstores"></a>
# **GetStores**
> RestApiPaginationResultStore GetStores (string searchQuery = null, int? page = null, int? limit = null, int? storeGroupId = null)



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
            var searchQuery = searchQuery_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var storeGroupId = 56;  // int? |  (optional) 

            try
            {
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
 **searchQuery** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **storeGroupId** | **int?**|  | [optional] 

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
            var appId = appId_example;  // string | 
            var searchQuery = searchQuery_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
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
 **appId** | **string**|  | 
 **searchQuery** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultStore**](RestApiPaginationResultStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoresbystoreidwithvalidations"></a>
# **GetStoresByStoreIdWithValidations**
> RestApiPaginationResultStoreValidationConfig GetStoresByStoreIdWithValidations (List<int?> storeId, string appId, int? page = null, int? limit = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetStoresByStoreIdWithValidationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = new List<int?>(); // List<int?> | 
            var appId = appId_example;  // string | 
            var page = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                RestApiPaginationResultStoreValidationConfig result = apiInstance.GetStoresByStoreIdWithValidations(storeId, appId, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoresByStoreIdWithValidations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | 
 **appId** | **string**|  | 
 **page** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**RestApiPaginationResultStoreValidationConfig**](RestApiPaginationResultStoreValidationConfig.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="publishstore"></a>
# **PublishStore**
> void PublishStore (int? storeId)



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
            var storeId = 56;  // int? | 

            try
            {
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
 **storeId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstoredeliveryfeeconfig"></a>
# **PutStoreDeliveryFeeConfig**
> void PutStoreDeliveryFeeConfig (int? storeId, StoreDeliveryZoneFeeConfigUpdateRequest feeConfigUpdateRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class PutStoreDeliveryFeeConfigExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | 
            var feeConfigUpdateRequest = new StoreDeliveryZoneFeeConfigUpdateRequest(); // StoreDeliveryZoneFeeConfigUpdateRequest | 

            try
            {
                apiInstance.PutStoreDeliveryFeeConfig(storeId, feeConfigUpdateRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.PutStoreDeliveryFeeConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **feeConfigUpdateRequest** | [**StoreDeliveryZoneFeeConfigUpdateRequest**](StoreDeliveryZoneFeeConfigUpdateRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbusinesshours"></a>
# **SetBusinessHours**
> RestApiResultBusinessHoursPeriod SetBusinessHours (int? storeId, string deliveryType, BusinessHoursPeriodBase businessHoursPeriod)



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
            var storeId = 56;  // int? | 
            var deliveryType = deliveryType_example;  // string | 
            var businessHoursPeriod = new BusinessHoursPeriodBase(); // BusinessHoursPeriodBase | 

            try
            {
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
 **storeId** | **int?**|  | 
 **deliveryType** | **string**|  | 
 **businessHoursPeriod** | [**BusinessHoursPeriodBase**](BusinessHoursPeriodBase.md)|  | 

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
            var storeId = 56;  // int? | 
            var deliveryType = deliveryType_example;  // string | 
            var enabled = true;  // bool? | 

            try
            {
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
 **storeId** | **int?**|  | 
 **deliveryType** | **string**|  | 
 **enabled** | **bool?**|  | 

### Return type

[**RestApiArrayResultRestApiDefaultResponse**](RestApiArrayResultRestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setstoreleadtimes"></a>
# **SetStoreLeadTimes**
> RestApiResultOrderLeadTimes SetStoreLeadTimes (int? storeId, LeadTime leadTime)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetStoreLeadTimesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | 
            var leadTime = new LeadTime(); // LeadTime | 

            try
            {
                RestApiResultOrderLeadTimes result = apiInstance.SetStoreLeadTimes(storeId, leadTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.SetStoreLeadTimes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **leadTime** | [**LeadTime**](LeadTime.md)|  | 

### Return type

[**RestApiResultOrderLeadTimes**](RestApiResultOrderLeadTimes.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="supportedsaleschannelstypes"></a>
# **SupportedSalesChannelsTypes**
> void SupportedSalesChannelsTypes (string propertyId, int? storeId, List<string> salesChannelTypes)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SupportedSalesChannelsTypesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var propertyId = propertyId_example;  // string | 
            var storeId = 56;  // int? | 
            var salesChannelTypes = salesChannelTypes_example;  // List<string> | 

            try
            {
                apiInstance.SupportedSalesChannelsTypes(propertyId, storeId, salesChannelTypes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.SupportedSalesChannelsTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **propertyId** | **string**|  | 
 **storeId** | **int?**|  | 
 **salesChannelTypes** | **List&lt;string&gt;**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unpublishstore"></a>
# **UnpublishStore**
> void UnpublishStore (int? storeId)



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
            var storeId = 56;  // int? | 

            try
            {
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
 **storeId** | **int?**|  | 

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
            var storeId = 56;  // int? | 
            var deliveryType = deliveryType_example;  // string | 
            var preOrderConfig = new PreOrderConfig(); // PreOrderConfig | 

            try
            {
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
 **storeId** | **int?**|  | 
 **deliveryType** | **string**|  | 
 **preOrderConfig** | [**PreOrderConfig**](PreOrderConfig.md)|  | 

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
            var storeId = 56;  // int? | 
            var store = new StoreBase(); // StoreBase | 

            try
            {
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
 **storeId** | **int?**|  | 
 **store** | [**StoreBase**](StoreBase.md)|  | 

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
            var storeId = 56;  // int? | 
            var storeAddress = new StoreAddressBase(); // StoreAddressBase | 

            try
            {
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
 **storeId** | **int?**|  | 
 **storeAddress** | [**StoreAddressBase**](StoreAddressBase.md)|  | 

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
            var storeId = 56;  // int? | 
            var coordinates = new Coordinates(); // Coordinates | 
            var appNameId = appNameId_example;  // string |  (optional) 

            try
            {
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
 **storeId** | **int?**|  | 
 **coordinates** | [**Coordinates**](Coordinates.md)|  | 
 **appNameId** | **string**|  | [optional] 

### Return type

[**RestApiResultCoordinates**](RestApiResultCoordinates.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestoreaddressform"></a>
# **UpdateStoreAddressForm**
> Object UpdateStoreAddressForm (int? storeId, StoreAddressForm address)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateStoreAddressFormExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoresApi();
            var storeId = 56;  // int? | 
            var address = new StoreAddressForm(); // StoreAddressForm | 

            try
            {
                Object result = apiInstance.UpdateStoreAddressForm(storeId, address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.UpdateStoreAddressForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **int?**|  | 
 **address** | [**StoreAddressForm**](StoreAddressForm.md)|  | 

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

