# Flipdish.Api.VouchersApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteVoucherMetadata**](VouchersApi.md#deletevouchermetadata) | **DELETE** /api/v1.0/vouchers/{voucherId}/menu/{menuId}/store/{storeId}/metadata/{key} | Delete voucher metadata
[**GetVoucherById**](VouchersApi.md#getvoucherbyid) | **GET** /api/v1.0/vouchers/{voucherId} | Get voucher by identifier
[**GetVoucherMetadata**](VouchersApi.md#getvouchermetadata) | **GET** /api/v1.0/vouchers/{voucherId}/menu/{menuId}/store/{storeId}/metadata | Get voucher metadata
[**GetVoucherMetadata_0**](VouchersApi.md#getvouchermetadata_0) | **GET** /api/v1.0/vouchers/{voucherId}/menu/{menuId}/store/{storeId}/metadata/{key} | Get voucher metadata
[**GetVouchers**](VouchersApi.md#getvouchers) | **GET** /api/v1.0/vouchers | Get vouchers
[**SetVoucherMetadata**](VouchersApi.md#setvouchermetadata) | **PUT** /api/v1.0/vouchers/{voucherId}/menu/{menuId}/store/{storeId}/metadata/{key} | Add voucher metadata


<a name="deletevouchermetadata"></a>
# **DeleteVoucherMetadata**
> FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1ApiResultsRestApiDefaultResponse DeleteVoucherMetadata (int? voucherId, int? menuId, int? storeId, string key)

Delete voucher metadata

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class DeleteVoucherMetadataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VouchersApi();
            var voucherId = 56;  // int? | 
            var menuId = 56;  // int? | 
            var storeId = 56;  // int? | 
            var key = key_example;  // string | 

            try
            {
                // Delete voucher metadata
                FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1ApiResultsRestApiDefaultResponse result = apiInstance.DeleteVoucherMetadata(voucherId, menuId, storeId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VouchersApi.DeleteVoucherMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voucherId** | **int?**|  | 
 **menuId** | **int?**|  | 
 **storeId** | **int?**|  | 
 **key** | **string**|  | 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1ApiResultsRestApiDefaultResponse**](FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1ApiResultsRestApiDefaultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvoucherbyid"></a>
# **GetVoucherById**
> FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1VouchersVoucher GetVoucherById (int? voucherId)

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
                FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1VouchersVoucher result = apiInstance.GetVoucherById(voucherId);
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

[**FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1VouchersVoucher**](FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1VouchersVoucher.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvouchermetadata"></a>
# **GetVoucherMetadata**
> FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1Metadata GetVoucherMetadata (int? voucherId, int? menuId, int? storeId)

Get voucher metadata

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetVoucherMetadataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VouchersApi();
            var voucherId = 56;  // int? | 
            var menuId = 56;  // int? | 
            var storeId = 56;  // int? | 

            try
            {
                // Get voucher metadata
                FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1Metadata result = apiInstance.GetVoucherMetadata(voucherId, menuId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VouchersApi.GetVoucherMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voucherId** | **int?**|  | 
 **menuId** | **int?**|  | 
 **storeId** | **int?**|  | 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1Metadata**](FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1Metadata.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvouchermetadata_0"></a>
# **GetVoucherMetadata_0**
> FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1Metadata GetVoucherMetadata_0 (int? voucherId, int? menuId, int? storeId, string key)

Get voucher metadata

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetVoucherMetadata_0Example
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VouchersApi();
            var voucherId = 56;  // int? | 
            var menuId = 56;  // int? | 
            var storeId = 56;  // int? | 
            var key = key_example;  // string | 

            try
            {
                // Get voucher metadata
                FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1Metadata result = apiInstance.GetVoucherMetadata_0(voucherId, menuId, storeId, key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VouchersApi.GetVoucherMetadata_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voucherId** | **int?**|  | 
 **menuId** | **int?**|  | 
 **storeId** | **int?**|  | 
 **key** | **string**|  | 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1Metadata**](FlipdishPublicModelsV1ApiResultsRestApiResultFlipdishPublicModelsV1Metadata.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvouchers"></a>
# **GetVouchers**
> FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1VouchersVoucher GetVouchers (string filter = null, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string orderBy = null, string subType = null, string status = null, string code = null, DateTime? validFromBegin = null, DateTime? validFromEnd = null, DateTime? expiryBegin = null, DateTime? expiryEnd = null, double? amount = null, string voucherType = null, string description = null)

Get vouchers

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
            var filter = filter_example;  // string |  (optional) 
            var pageNumber = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var sortOrder = sortOrder_example;  // string |  (optional) 
            var orderBy = orderBy_example;  // string |  (optional) 
            var subType = subType_example;  // string |  (optional) 
            var status = status_example;  // string |  (optional) 
            var code = code_example;  // string |  (optional) 
            var validFromBegin = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var validFromEnd = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var expiryBegin = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var expiryEnd = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var amount = 1.2;  // double? |  (optional) 
            var voucherType = voucherType_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 

            try
            {
                // Get vouchers
                FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1VouchersVoucher result = apiInstance.GetVouchers(filter, pageNumber, pageSize, sortOrder, orderBy, subType, status, code, validFromBegin, validFromEnd, expiryBegin, expiryEnd, amount, voucherType, description);
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
 **filter** | **string**|  | [optional] 
 **pageNumber** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **sortOrder** | **string**|  | [optional] 
 **orderBy** | **string**|  | [optional] 
 **subType** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **code** | **string**|  | [optional] 
 **validFromBegin** | **DateTime?**|  | [optional] 
 **validFromEnd** | **DateTime?**|  | [optional] 
 **expiryBegin** | **DateTime?**|  | [optional] 
 **expiryEnd** | **DateTime?**|  | [optional] 
 **amount** | **double?**|  | [optional] 
 **voucherType** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 

### Return type

[**FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1VouchersVoucher**](FlipdishPublicModelsV1ApiResultsRestApiPaginationResultFlipdishPublicModelsV1VouchersVoucher.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setvouchermetadata"></a>
# **SetVoucherMetadata**
> void SetVoucherMetadata (int? voucherId, int? menuId, int? storeId, string key, string value)

Add voucher metadata

### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class SetVoucherMetadataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VouchersApi();
            var voucherId = 56;  // int? | 
            var menuId = 56;  // int? | 
            var storeId = 56;  // int? | 
            var key = key_example;  // string | 
            var value = value_example;  // string | 

            try
            {
                // Add voucher metadata
                apiInstance.SetVoucherMetadata(voucherId, menuId, storeId, key, value);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VouchersApi.SetVoucherMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **voucherId** | **int?**|  | 
 **menuId** | **int?**|  | 
 **storeId** | **int?**|  | 
 **key** | **string**|  | 
 **value** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

