# Flipdish - the C# library for the Flipdish Open API v1.0

No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: v1.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Flipdish.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Flipdish.Api;
using Flipdish.Client;
using Flipdish.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthorizationTokensApi();
            var clientId = clientId_example;  // string | Client identifier
            var page = 56;  // int? | Requested page number (optional) 
            var limit = 56;  // int? | Requested page limit (optional) 

            try
            {
                // Get authorization tokens
                RestApiPaginationResultOAuthTokenModel result = apiInstance.GetAuthorizationTokens(clientId, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationTokensApi.GetAuthorizationTokens: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.flipdish.co*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthorizationTokensApi* | [**GetAuthorizationTokens**](docs/AuthorizationTokensApi.md#getauthorizationtokens) | **GET** /api/v1.0/authorizationtokens/{clientId} | Get authorization tokens
*AuthorizationTokensApi* | [**RevokeToken**](docs/AuthorizationTokensApi.md#revoketoken) | **DELETE** /api/v1.0/authorizationtokens/{key} | Revoke token
*HttpRequestResponseLogsApi* | [**GetHttpLogsByUserIdAsync**](docs/HttpRequestResponseLogsApi.md#gethttplogsbyuseridasync) | **GET** /api/v1.0/interactions/logs | Get API interaction logs
*MenuOptionSetItemsApi* | [**AddMenuItemOptionSetItem**](docs/MenuOptionSetItemsApi.md#addmenuitemoptionsetitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems | Create menu item option set item
*MenuOptionSetItemsApi* | [**DeleteOptionSetItemImage**](docs/MenuOptionSetItemsApi.md#deleteoptionsetitemimage) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId}/image | Delete menu item option set item image
*MenuOptionSetItemsApi* | [**GetMenuItemOptionSetItemById**](docs/MenuOptionSetItemsApi.md#getmenuitemoptionsetitembyid) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId} | Get menu item option set item by identifier
*MenuOptionSetItemsApi* | [**GetMenuItemOptionSetItems**](docs/MenuOptionSetItemsApi.md#getmenuitemoptionsetitems) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems | Get menu item option set items
*MenuOptionSetItemsApi* | [**RemoveMenuItemOptionSetItem**](docs/MenuOptionSetItemsApi.md#removemenuitemoptionsetitem) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId} | Delete menu item option set item
*MenuOptionSetItemsApi* | [**UpdateMenuItemOptionSetItem**](docs/MenuOptionSetItemsApi.md#updatemenuitemoptionsetitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId} | Update menu item option set item
*MenuOptionSetItemsApi* | [**UploadOptionSetItemImage**](docs/MenuOptionSetItemsApi.md#uploadoptionsetitemimage) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/optionsetitems/{menuItemOptionSetItemId}/image | Upload menu item option set item image
*MenuOptionSetsApi* | [**CreateMenuItemOptionSet**](docs/MenuOptionSetsApi.md#createmenuitemoptionset) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets | Create menu item option set
*MenuOptionSetsApi* | [**DeleteMenuItemOptionSet**](docs/MenuOptionSetsApi.md#deletemenuitemoptionset) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | Delete menu item option set
*MenuOptionSetsApi* | [**DeleteOptionSetImage**](docs/MenuOptionSetsApi.md#deleteoptionsetimage) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/image | Delete option set image
*MenuOptionSetsApi* | [**GetMenuItemOptionSetById**](docs/MenuOptionSetsApi.md#getmenuitemoptionsetbyid) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | Get menu item option set by identifier
*MenuOptionSetsApi* | [**GetMenuItemOptionSets**](docs/MenuOptionSetsApi.md#getmenuitemoptionsets) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets | Get menu item option sets
*MenuOptionSetsApi* | [**UpdateMenuItemOptionSet**](docs/MenuOptionSetsApi.md#updatemenuitemoptionset) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId} | Update menu item option set
*MenuOptionSetsApi* | [**UploadOptionSetImage**](docs/MenuOptionSetsApi.md#uploadoptionsetimage) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/optionsets/{optionSetId}/image | Upload menu item option set image
*MenuSectionItemsApi* | [**CreateMenuSectionItem**](docs/MenuSectionItemsApi.md#createmenusectionitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems | Create menu section item
*MenuSectionItemsApi* | [**DeleteMenuSectionItem**](docs/MenuSectionItemsApi.md#deletemenusectionitem) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | Delete menu section item
*MenuSectionItemsApi* | [**DeleteMenuSectionItemImage**](docs/MenuSectionItemsApi.md#deletemenusectionitemimage) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/image | Delete menu section item image
*MenuSectionItemsApi* | [**GetMenuItemById**](docs/MenuSectionItemsApi.md#getmenuitembyid) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | Get menu item by identifier
*MenuSectionItemsApi* | [**GetMenuItems**](docs/MenuSectionItemsApi.md#getmenuitems) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems | Get menu items
*MenuSectionItemsApi* | [**UpdateMenuSectionItem**](docs/MenuSectionItemsApi.md#updatemenusectionitem) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId} | Update menu section item
*MenuSectionItemsApi* | [**UploadMenuSectionItemImage**](docs/MenuSectionItemsApi.md#uploadmenusectionitemimage) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/sectionitems/{menuSectionItemId}/image | Upload menu section item image
*MenuSectionsApi* | [**CreateMenuSection**](docs/MenuSectionsApi.md#createmenusection) | **POST** /api/v1.0/menus/{menuId}/sections | Create menu section
*MenuSectionsApi* | [**DeleteMenuSection**](docs/MenuSectionsApi.md#deletemenusection) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId} | Delete menu section
*MenuSectionsApi* | [**DeleteMenuSectionImage**](docs/MenuSectionsApi.md#deletemenusectionimage) | **DELETE** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/image | Delete menu section image
*MenuSectionsApi* | [**GetMenuSectionById**](docs/MenuSectionsApi.md#getmenusectionbyid) | **GET** /api/v1.0/menus/{menuId}/sections/{menuSectionId} | Get menu section by identifier
*MenuSectionsApi* | [**GetMenuSections**](docs/MenuSectionsApi.md#getmenusections) | **GET** /api/v1.0/menus/{menuId}/sections | Get menu sections
*MenuSectionsApi* | [**UpdateMenuSection**](docs/MenuSectionsApi.md#updatemenusection) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId} | Update menu section
*MenuSectionsApi* | [**UploadMenuSectionImage**](docs/MenuSectionsApi.md#uploadmenusectionimage) | **POST** /api/v1.0/menus/{menuId}/sections/{menuSectionId}/image | Upload menu section image
*MenusApi* | [**DeleteMenuItemMetadata**](docs/MenusApi.md#deletemenuitemmetadata) | **GET** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/{key}/store/{storeId} | Get a menu item metadata by key
*MenusApi* | [**DeleteMenuItemMetadata_0**](docs/MenusApi.md#deletemenuitemmetadata_0) | **DELETE** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/{key}/store/{storeId} | Update a menu items metadata
*MenusApi* | [**DeleteMenuSectionImage**](docs/MenusApi.md#deletemenusectionimage) | **DELETE** /api/v1.0/menus/{menuId}/image | Delete menu image
*MenusApi* | [**GetMenuById**](docs/MenusApi.md#getmenubyid) | **GET** /api/v1.0/menus/{menuId} | Get menu by identifier
*MenusApi* | [**GetMenuItemMetadata**](docs/MenusApi.md#getmenuitemmetadata) | **GET** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/store/{storeId} | Get a menu items metadata
*MenusApi* | [**GetMenuItemOptionSetItemMetadata**](docs/MenusApi.md#getmenuitemoptionsetitemmetadata) | **GET** /api/v1.0/menus/{menuId}/optionsetitem/{optionSetItemId}/metadata/store/{storeId} | Get a menu item option set item metadata by key
*MenusApi* | [**SetMenuItemMetadata**](docs/MenusApi.md#setmenuitemmetadata) | **PUT** /api/v1.0/menus/{menuId}/menuitem/{menuItemId}/metadata/store/{storeId} | Update a menu items metadata
*MenusApi* | [**SetMenuItemOptionSetItemMetadata**](docs/MenusApi.md#setmenuitemoptionsetitemmetadata) | **PUT** /api/v1.0/menus/{menuId}/optionsetitem/{optionSetItemId}/metadata/store/{storeId} | Update a menu item option set items metadata
*MenusApi* | [**UpdateMenu**](docs/MenusApi.md#updatemenu) | **POST** /api/v1.0/menus/{menuId} | Update menu section item
*MenusApi* | [**UploadMenuSectionImage**](docs/MenusApi.md#uploadmenusectionimage) | **POST** /api/v1.0/menus/{menuId}/image | Upload menu image
*OAuthClientsApi* | [**AddRedirectUri**](docs/OAuthClientsApi.md#addredirecturi) | **POST** /api/v1.0/oauthclients/{oAuthClientId}/redirecturis | Create OAuth client redirect uri
*OAuthClientsApi* | [**CreateOAuthClient**](docs/OAuthClientsApi.md#createoauthclient) | **POST** /api/v1.0/oauthclients | Create OAuth client
*OAuthClientsApi* | [**DeleteOAuthClient**](docs/OAuthClientsApi.md#deleteoauthclient) | **DELETE** /api/v1.0/oauthclients/{oAuthClientId} | Delete OAuth client
*OAuthClientsApi* | [**GetOAuthClientByClientId**](docs/OAuthClientsApi.md#getoauthclientbyclientid) | **GET** /api/v1.0/oauthclients/{clientId} | Get OAuth client by identifier
*OAuthClientsApi* | [**GetOAuthClientSecret**](docs/OAuthClientsApi.md#getoauthclientsecret) | **GET** /api/v1.0/oauthclients/{clientId}/secret | Get OAuth client secret key
*OAuthClientsApi* | [**GetOAuthClients**](docs/OAuthClientsApi.md#getoauthclients) | **GET** /api/v1.0/oauthclients | Get all OAuth client
*OAuthClientsApi* | [**GetOauthAccessToken**](docs/OAuthClientsApi.md#getoauthaccesstoken) | **GET** /api/v1.0/oauthclients/{oAuthClientId}/accesstoken | Get OAuth access token for client
*OAuthClientsApi* | [**GetRedirectUris**](docs/OAuthClientsApi.md#getredirecturis) | **GET** /api/v1.0/oauthclients/{oAuthClientId}/redirecturis | Get OAuth client redirect uris
*OAuthClientsApi* | [**RemoveRedirectUri**](docs/OAuthClientsApi.md#removeredirecturi) | **DELETE** /api/v1.0/oauthclients/{oAuthClientId}/redirecturis/{uriId} | Delete OAuth client redirect uri
*OrdersApi* | [**AcceptOrder**](docs/OrdersApi.md#acceptorder) | **POST** /api/v1.0/orders/{id}/accept | Accept order
*OrdersApi* | [**GetOrderById**](docs/OrdersApi.md#getorderbyid) | **GET** /api/v1.0/orders/{id} | Get order by ID
*OrdersApi* | [**GetOrders**](docs/OrdersApi.md#getorders) | **GET** /api/v1.0/orders | Get orders by filter
*OrdersApi* | [**RefundOrder**](docs/OrdersApi.md#refundorder) | **POST** /api/v1.0/orders/{id}/refund | Refund order
*OrdersApi* | [**RejectOrder**](docs/OrdersApi.md#rejectorder) | **POST** /api/v1.0/orders/{id}/reject | Reject order
*StoresApi* | [**GetStoreById**](docs/StoresApi.md#getstorebyid) | **GET** /api/v1.0/stores/{storeId} | Get store by identifier
*StoresApi* | [**GetStores**](docs/StoresApi.md#getstores) | **GET** /api/v1.0/stores | Get all stores
*UsersApi* | [**GetRoles**](docs/UsersApi.md#getroles) | **GET** /api/v1.0/users/roles | Get role names
*VouchersApi* | [**DeleteVoucherMetadata**](docs/VouchersApi.md#deletevouchermetadata) | **DELETE** /api/v1.0/vouchers/{voucherId}/menu/{menuId}/store/{storeId}/metadata/{key} | Delete voucher metadata
*VouchersApi* | [**GetVoucherById**](docs/VouchersApi.md#getvoucherbyid) | **GET** /api/v1.0/vouchers/{voucherId} | Get voucher by identifier
*VouchersApi* | [**GetVoucherMetadata**](docs/VouchersApi.md#getvouchermetadata) | **GET** /api/v1.0/vouchers/{voucherId}/menu/{menuId}/store/{storeId}/metadata | Get voucher metadata
*VouchersApi* | [**GetVoucherMetadata_0**](docs/VouchersApi.md#getvouchermetadata_0) | **GET** /api/v1.0/vouchers/{voucherId}/menu/{menuId}/store/{storeId}/metadata/{key} | Get voucher metadata
*VouchersApi* | [**GetVouchers**](docs/VouchersApi.md#getvouchers) | **GET** /api/v1.0/vouchers | Get vouchers
*VouchersApi* | [**SetVoucherMetadata**](docs/VouchersApi.md#setvouchermetadata) | **PUT** /api/v1.0/vouchers/{voucherId}/menu/{menuId}/store/{storeId}/metadata/{key} | Add voucher metadata
*WebhooksApi* | [**CraeteWebhookSubscription**](docs/WebhooksApi.md#craetewebhooksubscription) | **POST** /api/v1.0/webhooks/{clientId}/subscriptions | Create a webhook subscription for you Oauth client
*WebhooksApi* | [**CreateWebhookSubscriptionEventNames**](docs/WebhooksApi.md#createwebhooksubscriptioneventnames) | **POST** /api/v1.0/webhooks/{clientId}/subscriptions/{webhookSubscriptionId}/events/{eventName} | Add event name to your webhook subscription
*WebhooksApi* | [**DeleteWebhookSubscription**](docs/WebhooksApi.md#deletewebhooksubscription) | **DELETE** /api/v1.0/webhooks/{clientId}/subscriptions/{webhookSubscriptionId} | Delete you webhook subscription
*WebhooksApi* | [**DeleteWebhookSubscriptionEventName**](docs/WebhooksApi.md#deletewebhooksubscriptioneventname) | **DELETE** /api/v1.0/webhooks/{clientId}/subscriptions/{webhookSubscriptionId}/events/{eventName} | Remove event name to your webhook subscription
*WebhooksApi* | [**GetWebhookEventNames**](docs/WebhooksApi.md#getwebhookeventnames) | **GET** /api/v1.0/webhooks/events | Get all webhook subscription event names
*WebhooksApi* | [**GetWebhookEventNamesBySubscriptionId**](docs/WebhooksApi.md#getwebhookeventnamesbysubscriptionid) | **GET** /api/v1.0/webhooks/{clientId}/subscriptions/{webhookSubscriptionId}/events | Get your webhook subscriptions selected event names
*WebhooksApi* | [**GetWebhookLogs**](docs/WebhooksApi.md#getwebhooklogs) | **GET** /api/v1.0/webhooks/{clientId}/subscriptions/{webhookSubscriptionId}/logs | Get logs for your webhook subscription
*WebhooksApi* | [**GetWebhookSubscriptions**](docs/WebhooksApi.md#getwebhooksubscriptions) | **GET** /api/v1.0/webhooks/{clientId}/subscriptions | Get all webhook subscriptions by your Oauth client id
*WebhooksApi* | [**UpdateWebhookSubscription**](docs/WebhooksApi.md#updatewebhooksubscription) | **PUT** /api/v1.0/webhooks/{clientId}/subscriptions/{webhookSubscriptionId} | Update a webhook subscription object


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Accept](docs/Accept.md)
 - [Model.BusinessHoursPeriod](docs/BusinessHoursPeriod.md)
 - [Model.Coordinates](docs/Coordinates.md)
 - [Model.CustomerSummary](docs/CustomerSummary.md)
 - [Model.DeliveryFeeArea](docs/DeliveryFeeArea.md)
 - [Model.DeliveryLocation](docs/DeliveryLocation.md)
 - [Model.FeeSummary](docs/FeeSummary.md)
 - [Model.HttpRequestAndResponseLog](docs/HttpRequestAndResponseLog.md)
 - [Model.Menu](docs/Menu.md)
 - [Model.MenuBase](docs/MenuBase.md)
 - [Model.MenuItemOptionSet](docs/MenuItemOptionSet.md)
 - [Model.MenuItemOptionSetBase](docs/MenuItemOptionSetBase.md)
 - [Model.MenuItemOptionSetItem](docs/MenuItemOptionSetItem.md)
 - [Model.MenuItemOptionSetItemBase](docs/MenuItemOptionSetItemBase.md)
 - [Model.MenuSection](docs/MenuSection.md)
 - [Model.MenuSectionAvailability](docs/MenuSectionAvailability.md)
 - [Model.MenuSectionBase](docs/MenuSectionBase.md)
 - [Model.MenuSectionItem](docs/MenuSectionItem.md)
 - [Model.MenuSectionItemBase](docs/MenuSectionItemBase.md)
 - [Model.Metadata](docs/Metadata.md)
 - [Model.OAuthClient](docs/OAuthClient.md)
 - [Model.OAuthTokenModel](docs/OAuthTokenModel.md)
 - [Model.OauthClientRedirectUri](docs/OauthClientRedirectUri.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderItem](docs/OrderItem.md)
 - [Model.OrderItemOption](docs/OrderItemOption.md)
 - [Model.Range](docs/Range.md)
 - [Model.Refund](docs/Refund.md)
 - [Model.Reject](docs/Reject.md)
 - [Model.RestApiArrayResultMenuItemOptionSet](docs/RestApiArrayResultMenuItemOptionSet.md)
 - [Model.RestApiArrayResultMenuItemOptionSetItem](docs/RestApiArrayResultMenuItemOptionSetItem.md)
 - [Model.RestApiArrayResultMenuSection](docs/RestApiArrayResultMenuSection.md)
 - [Model.RestApiArrayResultMenuSectionItem](docs/RestApiArrayResultMenuSectionItem.md)
 - [Model.RestApiArrayResultMetadata](docs/RestApiArrayResultMetadata.md)
 - [Model.RestApiArrayResultOAuthClient](docs/RestApiArrayResultOAuthClient.md)
 - [Model.RestApiArrayResultOauthClientRedirectUri](docs/RestApiArrayResultOauthClientRedirectUri.md)
 - [Model.RestApiArrayResultRestApiDefaultResponse](docs/RestApiArrayResultRestApiDefaultResponse.md)
 - [Model.RestApiArrayResultWebhookSubscription](docs/RestApiArrayResultWebhookSubscription.md)
 - [Model.RestApiDefaultResponse](docs/RestApiDefaultResponse.md)
 - [Model.RestApiErrorResult](docs/RestApiErrorResult.md)
 - [Model.RestApiForbiddenResult](docs/RestApiForbiddenResult.md)
 - [Model.RestApiIntegerResult](docs/RestApiIntegerResult.md)
 - [Model.RestApiPaginationResultHttpRequestAndResponseLog](docs/RestApiPaginationResultHttpRequestAndResponseLog.md)
 - [Model.RestApiPaginationResultOAuthTokenModel](docs/RestApiPaginationResultOAuthTokenModel.md)
 - [Model.RestApiPaginationResultOrder](docs/RestApiPaginationResultOrder.md)
 - [Model.RestApiPaginationResultStore](docs/RestApiPaginationResultStore.md)
 - [Model.RestApiPaginationResultVoucher](docs/RestApiPaginationResultVoucher.md)
 - [Model.RestApiPaginationResultWebhookLog](docs/RestApiPaginationResultWebhookLog.md)
 - [Model.RestApiResultMenu](docs/RestApiResultMenu.md)
 - [Model.RestApiResultMenuItemOptionSet](docs/RestApiResultMenuItemOptionSet.md)
 - [Model.RestApiResultMenuItemOptionSetItem](docs/RestApiResultMenuItemOptionSetItem.md)
 - [Model.RestApiResultMenuSection](docs/RestApiResultMenuSection.md)
 - [Model.RestApiResultMenuSectionItem](docs/RestApiResultMenuSectionItem.md)
 - [Model.RestApiResultMetadata](docs/RestApiResultMetadata.md)
 - [Model.RestApiResultOAuthClient](docs/RestApiResultOAuthClient.md)
 - [Model.RestApiResultOauthClientRedirectUri](docs/RestApiResultOauthClientRedirectUri.md)
 - [Model.RestApiResultOrder](docs/RestApiResultOrder.md)
 - [Model.RestApiResultStore](docs/RestApiResultStore.md)
 - [Model.RestApiResultVoucher](docs/RestApiResultVoucher.md)
 - [Model.RestApiStringArrayResult](docs/RestApiStringArrayResult.md)
 - [Model.RestApiStringResult](docs/RestApiStringResult.md)
 - [Model.RestApiUnauthorizedResult](docs/RestApiUnauthorizedResult.md)
 - [Model.Store](docs/Store.md)
 - [Model.StoreAddress](docs/StoreAddress.md)
 - [Model.StoreNote](docs/StoreNote.md)
 - [Model.StoreSummary](docs/StoreSummary.md)
 - [Model.ValidationErrorResult](docs/ValidationErrorResult.md)
 - [Model.Voucher](docs/Voucher.md)
 - [Model.VoucherSummary](docs/VoucherSummary.md)
 - [Model.WebhookLog](docs/WebhookLog.md)
 - [Model.WebhookSubscription](docs/WebhookSubscription.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth2"></a>
### oauth2

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: https://app.getflipdish.com/identity/connect/authorize
- **Scopes**: 
  - api: Access to Flipdish API

