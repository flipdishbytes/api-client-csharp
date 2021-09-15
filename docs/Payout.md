# Flipdish.Model.Payout
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayoutId** | **int?** | The id of the payout. | [optional] 
**PayeeBankAccountId** | **int?** | Bank account identifier | [optional] 
**AccountName** | **string** | Account name of the payout destination | [optional] 
**PayoutStatus** | **string** | Status of the payout | [optional] 
**CreatedDate** | **DateTime?** | Date payout was created | [optional] 
**PeriodStartTime** | **DateTime?** | This payout includes operations after at this date (inclusive) | [optional] 
**PeriodEndTime** | **DateTime?** | This payout includes operations before at this date (exclusive) | [optional] 
**DestinationBank** | **string** | Destination bank name | [optional] 
**DestinationAccount** | **string** | Last 4 digits of the destination bank IBAN | [optional] 
**Amount** | **double?** | Payout amount | [optional] 
**PayoutType** | **string** | Type of payout source | [optional] 
**Currency** | **string** | Payout currency | [optional] 
**CutoffDate** | **DateTime?** | Payouts before this date do not have a details breakdown | [optional] 
**OnlineSalesAmount** | **double?** |  | [optional] 
**OnlineSalesDeliveryCharges** | **double?** |  | [optional] 
**OnlineSalesTips** | **double?** |  | [optional] 
**TotalOnlineRevenue** | **double?** |  | [optional] 
**OnlineSalesFees** | **double?** |  | [optional] 
**CashSalesRefundedFees** | **double?** |  | [optional] 
**OnlineSalesRefundedFees** | **double?** |  | [optional] 
**SalesFeesVat** | **double?** |  | [optional] 
**TotalFees** | **double?** |  | [optional] 
**OnlineSalesRefundedAmount** | **double?** |  | [optional] 
**TotalOnlineRevenueAdjustments** | **double?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

