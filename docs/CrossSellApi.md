# Flipdish.Api.CrossSellApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrossSellMenuItems**](CrossSellApi.md#getcrosssellmenuitems) | **GET** /api/v1.0/{appId}/crossSell/menuItems | 


<a name="getcrosssellmenuitems"></a>
# **GetCrossSellMenuItems**
> RestApiResultCrossSellMenuItems GetCrossSellMenuItems (int? menuId, List<int?> menuItemId, int? limit, double? totalValue, string appId)



### Example
```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class GetCrossSellMenuItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CrossSellApi();
            var menuId = 56;  // int? | 
            var menuItemId = new List<int?>(); // List<int?> | 
            var limit = 56;  // int? | 
            var totalValue = 1.2;  // double? | 
            var appId = appId_example;  // string | 

            try
            {
                RestApiResultCrossSellMenuItems result = apiInstance.GetCrossSellMenuItems(menuId, menuItemId, limit, totalValue, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrossSellApi.GetCrossSellMenuItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuId** | **int?**|  | 
 **menuItemId** | [**List&lt;int?&gt;**](int?.md)|  | 
 **limit** | **int?**|  | 
 **totalValue** | **double?**|  | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultCrossSellMenuItems**](RestApiResultCrossSellMenuItems.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

