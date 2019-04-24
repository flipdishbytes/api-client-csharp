# Flipdish.Model.CreateVoucher
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VoucherType** | **string** | Voucher Type | [optional] 
**Stores** | **List&lt;int?&gt;** | Stores that this voucher applies to | [optional] 
**AddItemDetails** | [**AddItemDetails**](AddItemDetails.md) | Add item details | [optional] 
**CreditNoteDetails** | [**CreditNoteDetails**](CreditNoteDetails.md) | Credit note details | [optional] 
**LumpDiscountDetails** | [**LumpDiscountDetails**](LumpDiscountDetails.md) | Lump discount details | [optional] 
**PercentDiscountDetails** | [**PercentDiscountDetails**](PercentDiscountDetails.md) | Percent discount details | [optional] 
**Code** | **string** | Voucher Code | [optional] 
**Description** | **string** | Voucher Description (Visible on printout) | [optional] 
**ValidOnOrdersOver** | **double?** | Valid on orders on or above | [optional] 
**TakesPriority** | **bool?** | Takes priority | [optional] 
**IsEnabled** | **bool?** | Is voucher enabled | [optional] 
**IsAutomaticallyApplied** | **bool?** | Is voucher automatically applied | [optional] 
**IncludeDeliveryFee** | **bool?** | Include delivery fees | [optional] 
**IsValidForDeliveryOrders** | **bool?** | Valid for delivery orders | [optional] 
**IsValidForPickupOrders** | **bool?** | Valid for pickup orders | [optional] 
**IsValidForOrdersPayedOnline** | **bool?** | Valid for orders payed online | [optional] 
**IsValidForOrdersPayedByCash** | **bool?** | Valid for orders payed in cash | [optional] 
**IsValidForFirstOrderOnly** | **bool?** | Valid only on the first order by the customer | [optional] 
**IsValidOncePerCustomer** | **bool?** | Valid once per customer | [optional] 
**IsValidOnlyOnce** | **bool?** | Valid only once, by any customer (once used cannot be used again by any other customer) | [optional] 
**StartDate** | **DateTime?** | Voucher Starts On (Time in UTC) | [optional] 
**ExpiryDate** | **DateTime?** | Voucher Expires On (Time in UTC) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

