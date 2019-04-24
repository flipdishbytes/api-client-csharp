# Flipdish.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Store** | [**StoreSummary**](StoreSummary.md) | Store summary | [optional] 
**Customer** | [**CustomerSummary**](CustomerSummary.md) | Customer summary | [optional] 
**Voucher** | [**OrderVoucherSummary**](OrderVoucherSummary.md) | Voucher summary | [optional] 
**Fees** | [**FeeSummary**](FeeSummary.md) | Fee summary | [optional] 
**OrderItems** | [**List&lt;OrderItem&gt;**](OrderItem.md) | Ordered items | [optional] 
**DeliveryLocation** | [**DeliveryLocation**](DeliveryLocation.md) | Delivery location for delivery orders | [optional] 
**CustomerLocation** | [**Coordinates**](Coordinates.md) | Customer location | [optional] 
**OrderId** | **int?** | Order identifier | [optional] 
**DeliveryType** | **string** | Delivery type | [optional] 
**PickupLocationType** | **string** | Pickup location type | [optional] 
**TipAmount** | **double?** | Tip amount | [optional] 
**DeliveryAmount** | **double?** | Delivery amount | [optional] 
**OrderItemsAmount** | **double?** | Ordered items amount | [optional] 
**Amount** | **double?** | This is the sum of the OrderItemsAmount, DeliveryAmount, TipAmount and Voucher.Amount (which is usually negative) and OnlineOrderingFee for cash orders.  It does not include the OnlineOrderingFee in the case of card orders as this fee is charged by Flipdish directly to the customer. | [optional] 
**ProcessingFee** | **double?** | This contains the online ordering processing fee. For card payments this is charged directly to the customer and for cash orders it is paid by the customer to the store. It is tax inclusive. | [optional] 
**PaymentAccountType** | **string** | Payment account type | [optional] 
**PaymentAccountDescription** | **string** | Payment account description (like Visa ****2371 or Apple Pay. or Cash) | [optional] 
**OrderState** | **string** | Order state | [optional] 
**IsPreOrder** | **bool?** | Is pre-order | [optional] 
**PlacedTime** | **DateTime?** | Order placed time | [optional] 
**RequestedForTime** | **DateTime?** | Order requested for | [optional] 
**ChefNote** | **string** | Chef note | [optional] 
**AppType** | **string** | Used app type | [optional] 
**UserRating** | **int?** | User rating | [optional] 
**PaymentStatus** | **string** | Status of the payment | [optional] 
**RejectionReason** | **string** | Rejection reason. Can have value if the order is rejected. | [optional] 
**RefundedAmount** | **double?** | Amount refunded to customer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

