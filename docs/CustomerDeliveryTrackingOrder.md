# IO.Swagger.Model.CustomerDeliveryTrackingOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **int?** | Order Id | [optional] 
**Address** | **string** | Pretified address string in country format | [optional] 
**DeliveryNotes** | **string** | Delivery Notes | [optional] 
**StorePhoneNumber** | **string** | Phone number of the store | [optional] 
**AppIconUrl** | **string** | App Icon of the store | [optional] 
**OrderTrackingCode** | **string** | Order Tracking Code | [optional] 
**PaymentMethodDescription** | **string** | Payment method description i.e Cash/Card/iDeal/Paypal | [optional] 
**LastFourDigits** | **string** | Last 4 digits of the card if applicable otherwise null | [optional] 
**OrderLines** | [**List&lt;CustomerDeliveryTrackingOrderLine&gt;**](CustomerDeliveryTrackingOrderLine.md) | Order lines of the order | [optional] 
**TotalAmount** | **double?** | Total amount for the order including tax | [optional] 
**Currency** | **string** | Currency | [optional] 
**Latitude** | **double?** | Customer Location Latitude | [optional] 
**Longitude** | **double?** | Customer Location Longitude | [optional] 
**Placed** | **DateTime?** | Order placed time | [optional] 
**RequestedFor** | **DateTime?** | Order requested for | [optional] 
**DriverId** | **int?** | Driver Id | [optional] 
**DriverName** | **string** | Driver Name | [optional] 
**DriverImage** | **string** | Driver Image | [optional] 
**EstimatedMinutesForDelivery** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

