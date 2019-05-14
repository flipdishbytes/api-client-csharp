# Flipdish.Model.OrderSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **int?** | Order identifier | [optional] 
**DeliveryType** | **string** | Delivery type | [optional] 
**OrderState** | **string** | Order state | [optional] 
**RequestedForTime** | **DateTime?** | Order requested for | [optional] 
**StoreName** | **string** | Name of the store | [optional] 
**StoreIanaTimeZone** | **string** | Store IANA time zone | [optional] 
**CustomerName** | **string** | Name of the customer | [optional] 
**CustomerPhoneNumber** | **string** | Phone number of customer | [optional] 
**Amount** | **double?** | This is the sum of the OrderItemsAmount, DeliveryAmount, TipAmount and Voucher.Amount (which is usually negative) and OnlineOrderingFee  It does include the OnlineOrderingFee | [optional] 
**RefundedAmount** | **double?** | Refunded amount | [optional] 
**PaymentAccountType** | **string** | Payment Account | [optional] 
**PaymentStatus** | **string** | Status of the payment | [optional] 
**Currency** | **string** | Currency of payment | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

