# Flipdish.Api.VouchersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVoucher**](VouchersApi.md#createvoucher) | **POST** /api/v1.0/vouchers/{appId} | [PRIVATE API] Create voucher
[**GetVoucherById**](VouchersApi.md#getvoucherbyid) | **GET** /api/v1.0/vouchers/{voucherId} | [PRIVATE API] Get voucher by identifier
[**GetVoucherStatsById**](VouchersApi.md#getvoucherstatsbyid) | **GET** /api/v1.0/vouchers/stats/{voucherId} | [PRIVATE API] Get voucher stats by identifier
[**GetVouchers**](VouchersApi.md#getvouchers) | **GET** /api/v1.0/{appId}/vouchers/summaries | [PRIVATE API] Get vouchers summaries for App Id
[**UpdateVoucher**](VouchersApi.md#updatevoucher) | **POST** /api/v1.0/vouchers/{voucherId} | [PRIVATE API] Updates voucher


<a name="createvoucher"></a>
# **CreateVoucher**
> RestApiResultVoucherWithStats CreateVoucher (string appId, CreateVoucher voucher)

[PRIVATE API] Create voucher

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class CreateVoucherExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VouchersApi();
            var appId = appId_example;  // string | App Name Id
            var voucher = new CreateVoucher(); // CreateVoucher | Voucher Details

            try
            {
                // [PRIVATE API] Create voucher
                RestApiResultVoucherWithStats result = apiInstance.CreateVoucher(appId, voucher);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VouchersApi.CreateVoucher: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| App Name Id | 
 **voucher** | [**CreateVoucher**](CreateVoucher.md)| Voucher Details | 

### Return type

[**RestApiResultVoucherWithStats**](RestApiResultVoucherWithStats.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvoucherbyid"></a>
# **GetVoucherById**
> RestApiResultVoucherWithStats GetVoucherById (int? voucherId)

[PRIVATE API] Get voucher by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetVoucherByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VouchersApi();
            var voucherId = 56;  // int? | Id of the voucher

            try
            {
                // [PRIVATE API] Get voucher by identifier
                RestApiResultVoucherWithStats result = apiInstance.GetVoucherById(voucherId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VouchersApi.GetVoucherById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voucherId** | **int?**| Id of the voucher | 

### Return type

[**RestApiResultVoucherWithStats**](RestApiResultVoucherWithStats.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvoucherstatsbyid"></a>
# **GetVoucherStatsById**
> RestApiArrayResultVoucherDataPoint GetVoucherStatsById (int? voucherId, string aggregateDataBy, int? dataPointLimit = null)

[PRIVATE API] Get voucher stats by identifier

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetVoucherStatsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VouchersApi();
            var voucherId = 56;  // int? | Id of the voucher
            var aggregateDataBy = aggregateDataBy_example;  // string | Aggregate data by day \\ week \\ month
            var dataPointLimit = 56;  // int? | Amount of data points per request (optional) 

            try
            {
                // [PRIVATE API] Get voucher stats by identifier
                RestApiArrayResultVoucherDataPoint result = apiInstance.GetVoucherStatsById(voucherId, aggregateDataBy, dataPointLimit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VouchersApi.GetVoucherStatsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voucherId** | **int?**| Id of the voucher | 
 **aggregateDataBy** | **string**| Aggregate data by day \\ week \\ month | 
 **dataPointLimit** | **int?**| Amount of data points per request | [optional] 

### Return type

[**RestApiArrayResultVoucherDataPoint**](RestApiArrayResultVoucherDataPoint.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvouchers"></a>
# **GetVouchers**
> RestApiPaginationResultVoucherSummary GetVouchers (string appId, int? pageIndex = null, int? pageSize = null, List<string> searchCodes = null, List<string> statusSearch = null, List<string> typeSearch = null, List<string> subTypeSearch = null, List<int?> storeIds = null)

[PRIVATE API] Get vouchers summaries for App Id

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetVouchersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VouchersApi();
            var appId = appId_example;  // string | Application Id
            var pageIndex = 56;  // int? | Page Number (optional) 
            var pageSize = 56;  // int? | Page Size (optional) 
            var searchCodes = new List<string>(); // List<string> | Search by Voucher Code\\s (optional) 
            var statusSearch = statusSearch_example;  // List<string> | Search by Status (optional) 
            var typeSearch = typeSearch_example;  // List<string> | Search by Type (optional) 
            var subTypeSearch = subTypeSearch_example;  // List<string> | Search by Sub Type (optional) 
            var storeIds = new List<int?>(); // List<int?> | Search by Store Ids (optional) 

            try
            {
                // [PRIVATE API] Get vouchers summaries for App Id
                RestApiPaginationResultVoucherSummary result = apiInstance.GetVouchers(appId, pageIndex, pageSize, searchCodes, statusSearch, typeSearch, subTypeSearch, storeIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VouchersApi.GetVouchers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Application Id | 
 **pageIndex** | **int?**| Page Number | [optional] 
 **pageSize** | **int?**| Page Size | [optional] 
 **searchCodes** | [**List&lt;string&gt;**](string.md)| Search by Voucher Code\\s | [optional] 
 **statusSearch** | **List&lt;string&gt;**| Search by Status | [optional] 
 **typeSearch** | **List&lt;string&gt;**| Search by Type | [optional] 
 **subTypeSearch** | **List&lt;string&gt;**| Search by Sub Type | [optional] 
 **storeIds** | [**List&lt;int?&gt;**](int?.md)| Search by Store Ids | [optional] 

### Return type

[**RestApiPaginationResultVoucherSummary**](RestApiPaginationResultVoucherSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevoucher"></a>
# **UpdateVoucher**
> RestApiResultVoucherWithStats UpdateVoucher (int? voucherId, VoucherBase voucher, List<int?> storeId = null, int? percentValue = null, double? lumpValue = null, int? freeItemId = null)

[PRIVATE API] Updates voucher

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateVoucherExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VouchersApi();
            var voucherId = 56;  // int? | Id of the voucher
            var voucher = new VoucherBase(); // VoucherBase | Updated details for the voucher
            var storeId = new List<int?>(); // List<int?> |  (optional) 
            var percentValue = 56;  // int? | Percent voucher value (can have 1 of 3) (optional) 
            var lumpValue = 1.2;  // double? | Lump voucher value (can have 1 of 3) (optional) 
            var freeItemId = 56;  // int? | Free Item Id (can have 1 of 3) (optional) 

            try
            {
                // [PRIVATE API] Updates voucher
                RestApiResultVoucherWithStats result = apiInstance.UpdateVoucher(voucherId, voucher, storeId, percentValue, lumpValue, freeItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VouchersApi.UpdateVoucher: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voucherId** | **int?**| Id of the voucher | 
 **voucher** | [**VoucherBase**](VoucherBase.md)| Updated details for the voucher | 
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **percentValue** | **int?**| Percent voucher value (can have 1 of 3) | [optional] 
 **lumpValue** | **double?**| Lump voucher value (can have 1 of 3) | [optional] 
 **freeItemId** | **int?**| Free Item Id (can have 1 of 3) | [optional] 

### Return type

[**RestApiResultVoucherWithStats**](RestApiResultVoucherWithStats.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

