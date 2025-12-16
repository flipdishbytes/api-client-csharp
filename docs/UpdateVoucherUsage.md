# Flipdish.Model.UpdateVoucherUsage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsUsed** | **bool?** | Flag indicating whether the voucher is used | [optional] 
**UsedByCustomerId** | **int?** | Indicates Customer that used the voucher. | [optional] 
**TransactionKey** | **string** | An opaque string, to ensure idempotency. This allows for safely retrying requests without accidentally performing the same stamp operation twice.   This will typically contain the the ID of the sale order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

