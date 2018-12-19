# Flipdish.Api.VouchersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVoucherById**](VouchersApi.md#getvoucherbyid) | **GET** /api/v1.0/vouchers/{voucherId} | Get voucher by identifier
[**GetVouchers**](VouchersApi.md#getvouchers) | **GET** /api/v1.0/{appNameId}/vouchers | Get vouchers for App Id
[**UpdateVoucher**](VouchersApi.md#updatevoucher) | **POST** /api/v1.0/vouchers/{voucherId} | Updates voucher


<a name="getvoucherbyid"></a>
# **GetVoucherById**
> RestApiResultVoucherWithStats GetVoucherById (int? voucherId)

Get voucher by identifier

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
                // Get voucher by identifier
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
> RestApiPaginationResultVoucherWithStats GetVouchers (string appNameId, int? pageIndex, int? pageSize, List<string> searchCodes, List<string> statusSearch, List<string> typeSearch, List<int?> physicalRestaurantIds)

Get vouchers for App Id

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
            var appNameId = appNameId_example;  // string | 
            var pageIndex = 56;  // int? | 
            var pageSize = 56;  // int? | 
            var searchCodes = new List<string>(); // List<string> | 
            var statusSearch = statusSearch_example;  // List<string> | 
            var typeSearch = typeSearch_example;  // List<string> | 
            var physicalRestaurantIds = new List<int?>(); // List<int?> | 

            try
            {
                // Get vouchers for App Id
                RestApiPaginationResultVoucherWithStats result = apiInstance.GetVouchers(appNameId, pageIndex, pageSize, searchCodes, statusSearch, typeSearch, physicalRestaurantIds);
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
 **appNameId** | **string**|  | 
 **pageIndex** | **int?**|  | 
 **pageSize** | **int?**|  | 
 **searchCodes** | [**List&lt;string&gt;**](string.md)|  | 
 **statusSearch** | **List&lt;string&gt;**|  | 
 **typeSearch** | **List&lt;string&gt;**|  | 
 **physicalRestaurantIds** | [**List&lt;int?&gt;**](int?.md)|  | 

### Return type

[**RestApiPaginationResultVoucherWithStats**](RestApiPaginationResultVoucherWithStats.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevoucher"></a>
# **UpdateVoucher**
> RestApiResultVoucher UpdateVoucher (int? voucherId, VoucherBase voucher)

Updates voucher

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
                // Updates voucher
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

