# IO.Swagger.Model.PayoutStore
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StoreId** | **int?** | The id of the Store. | [optional] 
**StoreName** | **string** | Name of the store | [optional] 
**Amount** | **double?** | Amount of the payout for this Store | [optional] 
**OnlineRevenue** | [**RevenueDetail**](RevenueDetail.md) | Revenue details (DEPRECATED: Use Revenue) | [optional] 
**Revenue** | [**RevenueDetail**](RevenueDetail.md) | Revenue details | [optional] 
**RevenueAdjustments** | [**RevenueAdjustmentsDetails**](RevenueAdjustmentsDetails.md) | Revenue Adjustments breakdown | [optional] 
**FlipdishFees** | [**FlipdishFeesDetails**](FlipdishFeesDetails.md) | Fees breakdown | [optional] 
**Chargebacks** | [**ChargebackDetails**](ChargebackDetails.md) | Chargebacks breakdown | [optional] 
**OtherCharges** | [**OtherChargesDetails**](OtherChargesDetails.md) | Breakdown of other charges | [optional] 
**Balance** | [**BalanceDetails**](BalanceDetails.md) | Period opening and closing balance | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

