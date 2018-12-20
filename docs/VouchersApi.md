# Flipdish.Api.VouchersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVoucherById**](VouchersApi.md#getvoucherbyid) | **GET** /api/v1.0/vouchers/{voucherId} | [PRIVATE API] Get voucher by identifier
[**GetVouchers**](VouchersApi.md#getvouchers) | **GET** /api/v1.0/{appId}/vouchers | [PRIVATE API] Get vouchers for App Id
[**UpdateVoucher**](VouchersApi.md#updatevoucher) | **POST** /api/v1.0/vouchers/{voucherId} | [PRIVATE API] Updates voucher


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
            var voucherId = 56;  // int? | 

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
 **voucherId** | **int?**|  | 

### Return type

[**RestApiResultVoucherWithStats**](RestApiResultVoucherWithStats.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvouchers"></a>
# **GetVouchers**
> RestApiPaginationResultVoucher GetVouchers (string appId, int? pageIndex = null, int? pageSize = null, List<string> searchCodes = null, List<string> statusSearch = null, List<string> typeSearch = null, List<int?> storeIds = null)

[PRIVATE API] Get vouchers for App Id

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
            var storeIds = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // [PRIVATE API] Get vouchers for App Id
                RestApiPaginationResultVoucher result = apiInstance.GetVouchers(appId, pageIndex, pageSize, searchCodes, statusSearch, typeSearch, storeIds);
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
 **storeIds** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 

### Return type

[**RestApiPaginationResultVoucher**](RestApiPaginationResultVoucher.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevoucher"></a>
# **UpdateVoucher**
> RestApiResultVoucher UpdateVoucher (int? voucherId, VoucherBase voucher)

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
            var voucherId = 56;  // int? | 
            var voucher = new VoucherBase(); // VoucherBase | 

            try
            {
                // [PRIVATE API] Updates voucher
                RestApiResultVoucher result = apiInstance.UpdateVoucher(voucherId, voucher);
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
 **voucher** | [**VoucherBase**](VoucherBase.md)|  | 

### Return type

[**RestApiResultVoucher**](RestApiResultVoucher.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

