# Flipdish.Model.OrderSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **int?** | Order identifier | [optional] 
**DeliveryType** | **string** | Delivery type | [optional] 
**PickupLocationType** | **string** | Pickup location type | [optional] 
**TableServiceCatagory** | **string** | Table service category | [optional] 
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
**AppType** | **string** | Type of app end user is on | [optional] 
**LocalOrderId** | **string** | Local order Id. This is used for displaying a \&quot;shorter\&quot; order ID for customers (eg. Kiosk orders) | [optional] 
**DropOffLocationId** | **int?** | id of the collection/drop off location | [optional] 
**DropOffLocation** | **string** | Represents table service drop off location | [optional] 
**AcceptedFor** | **DateTime?** | Time store has accepted the order for | [optional] 
**Channel** | [**Channel**](Channel.md) | Channel where the Order comes from | [optional] 
**InFraudZone** | **bool?** | Was order made within a fraud zone | [optional] 
**UnusualHighValueOrder** | **bool?** | Is order of unusually high value | [optional] 
**ChannelOrderId** | **string** | ChannelOrderId from external channel | [optional] 
**ChannelOrderDisplayId** | **string** | ChannelOrderDisplayId from external channel | [optional] 
**ExternalOrderId** | **string** | ExternalOrderId from external channel | [optional] 
**ExternalOrderDisplayId** | **string** | ExternalOrderDisplayId from external channel | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

