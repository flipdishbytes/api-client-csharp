# Flipdish.Model.OrderIngestSubmitOrderRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppType** | **string** | [Required] Indicated the name from where the request is coming from | [optional] 
**StoreId** | **int?** | [Required] Store Id | [optional] 
**CurrencyCode** | **string** | [Required] Currency Code  These must match three letter codes ISO 4127 http://en.wikipedia.org/wiki/ISO_4217 | [optional] 
**Cart** | [**Cart**](Cart.md) | [Required] Cart of the user | [optional] 
**FulfillmentInfo** | [**FulfillmentInfo**](FulfillmentInfo.md) | [Required] Relevant fulfillment Information | [optional] 
**ChannelOrderId** | **string** | [Required] Order ID in the external System | [optional] 
**ChannelPublicOrderId** | **string** | [Optional] Public Order ID in the external System | [optional] 
**OrderDateUtc** | **DateTime?** | Date the order was placed at in UTC  [Required] | [optional] 
**PaymentInfo** | [**PaymentInfo**](PaymentInfo.md) | Payment Information  [Required] | [optional] 
**Contact** | [**Contact**](Contact.md) | Contact Information  [Required] | [optional] 
**TipAmount** | **double?** | Tip amount | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

