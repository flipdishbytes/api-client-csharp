# Flipdish.Api.VouchersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVoucher**](VouchersApi.md#createvoucher) | **POST** /api/v1.0/vouchers/{appId} | 
[**GetVoucherById**](VouchersApi.md#getvoucherbyid) | **GET** /api/v1.0/vouchers/{voucherId} | 
[**GetVoucherStatsById**](VouchersApi.md#getvoucherstatsbyid) | **GET** /api/v1.0/vouchers/stats/{voucherId} | 
[**GetVouchers**](VouchersApi.md#getvouchers) | **GET** /api/v1.0/{appId}/vouchers/summaries | 
[**UpdateVoucher**](VouchersApi.md#updatevoucher) | **POST** /api/v1.0/vouchers/{voucherId} | 
[**UpdateVoucherUsage**](VouchersApi.md#updatevoucherusage) | **POST** /api/v1.0/{appId}/vouchers/{voucherId}/usage | 


<a name="createvoucher"></a>
# **CreateVoucher**
> RestApiResultVoucherWithStats CreateVoucher (string appId, CreateVoucher voucher)



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
            var appId = appId_example;  // string | 
            var voucher = new CreateVoucher(); // CreateVoucher | 

            try
            {
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
 **appId** | **string**|  | 
 **voucher** | [**CreateVoucher**](CreateVoucher.md)|  | 

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
            var voucherId = 56;  // int? | 

            try
            {
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
 **voucherId** | **int?**|  | 

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
            var voucherId = 56;  // int? | 
            var aggregateDataBy = aggregateDataBy_example;  // string | 
            var dataPointLimit = 56;  // int? |  (optional) 

            try
            {
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
 **voucherId** | **int?**|  | 
 **aggregateDataBy** | **string**|  | 
 **dataPointLimit** | **int?**|  | [optional] 

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
> RestApiPaginationResultVoucherSummary GetVouchers (string appId, int? pageIndex = null, int? pageSize = null, List<string> searchCodes = null, List<string> statusSearch = null, List<string> typeSearch = null, List<string> subTypeSearch = null, List<int?> storeIds = null, List<string> channelRestrictions = null)



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
            var appId = appId_example;  // string | 
            var pageIndex = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var searchCodes = new List<string>(); // List<string> |  (optional) 
            var statusSearch = statusSearch_example;  // List<string> |  (optional) 
            var typeSearch = typeSearch_example;  // List<string> |  (optional) 
            var subTypeSearch = subTypeSearch_example;  // List<string> |  (optional) 
            var storeIds = new List<int?>(); // List<int?> |  (optional) 
            var channelRestrictions = channelRestrictions_example;  // List<string> |  (optional) 

            try
            {
                RestApiPaginationResultVoucherSummary result = apiInstance.GetVouchers(appId, pageIndex, pageSize, searchCodes, statusSearch, typeSearch, subTypeSearch, storeIds, channelRestrictions);
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
 **appId** | **string**|  | 
 **pageIndex** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **searchCodes** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **statusSearch** | **List&lt;string&gt;**|  | [optional] 
 **typeSearch** | **List&lt;string&gt;**|  | [optional] 
 **subTypeSearch** | **List&lt;string&gt;**|  | [optional] 
 **storeIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **channelRestrictions** | **List&lt;string&gt;**|  | [optional] 

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
> RestApiResultVoucherWithStats UpdateVoucher (int? voucherId, UpdateVoucher voucher, List<int?> storeId = null, int? percentValue = null, double? lumpValue = null, double? maxDiscountAmount = null)



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
            var voucherId = 56;  // int? | 
            var voucher = new UpdateVoucher(); // UpdateVoucher | 
            var storeId = new List<int?>(); // List<int?> |  (optional) 
            var percentValue = 56;  // int? |  (optional) 
            var lumpValue = 1.2;  // double? |  (optional) 
            var maxDiscountAmount = 1.2;  // double? |  (optional) 

            try
            {
                RestApiResultVoucherWithStats result = apiInstance.UpdateVoucher(voucherId, voucher, storeId, percentValue, lumpValue, maxDiscountAmount);
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
 **voucherId** | **int?**|  | 
 **voucher** | [**UpdateVoucher**](UpdateVoucher.md)|  | 
 **storeId** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **percentValue** | **int?**|  | [optional] 
 **lumpValue** | **double?**|  | [optional] 
 **maxDiscountAmount** | **double?**|  | [optional] 

### Return type

[**RestApiResultVoucherWithStats**](RestApiResultVoucherWithStats.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevoucherusage"></a>
# **UpdateVoucherUsage**
> void UpdateVoucherUsage (string appId, int? voucherId, UpdateVoucherUsage voucherUsage)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class UpdateVoucherUsageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VouchersApi();
            var appId = appId_example;  // string | 
            var voucherId = 56;  // int? | 
            var voucherUsage = new UpdateVoucherUsage(); // UpdateVoucherUsage | 

            try
            {
                apiInstance.UpdateVoucherUsage(appId, voucherId, voucherUsage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VouchersApi.UpdateVoucherUsage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**|  | 
 **voucherId** | **int?**|  | 
 **voucherUsage** | [**UpdateVoucherUsage**](UpdateVoucherUsage.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

