# Flipdish.Model.CreateEndUserFeeConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Channel** | **string** | The order channel this fee config applies to | 
**PaymentMethod** | **string** | The payment method this fee config applies to | 
**MinOrderAmount** | **double?** | Order amount below which MinFixedFee is charged instead of the percent/fixed calculation | [optional] 
**MinFixedFee** | **double?** | Fixed fee charged for orders at or below MinOrderAmount | [optional] 
**PercentFee** | **double?** | Percentage fee applied to the order amount | [optional] 
**FixedFee** | **double?** | Fixed fee compared against the percentage fee - the greater of the two is charged | [optional] 
**Cap** | **double?** | Maximum fee that can be charged | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

