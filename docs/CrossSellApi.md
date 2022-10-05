# Flipdish.Api.CrossSellApi

All URIs are relative to *https://api.flipdish.co*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrossSellMenuItems**](CrossSellApi.md#getcrosssellmenuitems) | **GET** /api/v1.0/{appId}/crossSell/menuItems | Get all Menu items by MenuId for cross sells


<a name="getcrosssellmenuitems"></a>
# **GetCrossSellMenuItems**
> RestApiResultCrossSellMenuItems GetCrossSellMenuItems (int? menuId, List<int?> menuItemId, int? limit, double? totalValue, string appId)

Get all Menu items by MenuId for cross sells

Can be called by any flipdish kiosk  [BETA - this endpoint is under development, do not use it in your production system]

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
            var menuId = 56;  // int? | Requested MenuId
            var menuItemId = new List<int?>(); // List<int?> | Selected Menu items
            var limit = 56;  // int? | Set the limit of items returned
            var totalValue = 1.2;  // double? | Get the total cost of items in the basket
            var appId = appId_example;  // string | 

            try
            {
                // Get all Menu items by MenuId for cross sells
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
 **menuId** | **int?**| Requested MenuId | 
 **menuItemId** | [**List&lt;int?&gt;**](int?.md)| Selected Menu items | 
 **limit** | **int?**| Set the limit of items returned | 
 **totalValue** | **double?**| Get the total cost of items in the basket | 
 **appId** | **string**|  | 

### Return type

[**RestApiResultCrossSellMenuItems**](RestApiResultCrossSellMenuItems.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

