# Flipdish.Model.RetentionCampaign
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignId** | **int?** | Id of campaign | [optional] 
**Statistics** | [**CampaignStatistics**](CampaignStatistics.md) | Statistics of campaign | [optional] 
**Stores** | [**List&lt;StoreCampaignStartTime&gt;**](StoreCampaignStartTime.md) | Stores this campaign applies to with campaign start time in Utc | [optional] 
**PublicId** | **Guid?** | Permanent reference to the item. | [optional] 
**NotifyCustomerAfterMinutes** | **int?** | Time in minutes, after which customer will receive retention voucher if he/she does not order | [optional] 
**PercentDiscountAmount** | **int?** | Discount amount in percents | [optional] 
**MaxDiscount** | **double?** | Maximum discount for percentage discounts | [optional] 
**LumpDiscountAmount** | **double?** | Discount amount in sum of money | [optional] 
**VoucherValidPeriodDays** | **int?** | Number of days for which the voucher will be valid. | [optional] 
**IncludeDeliveryFee** | **bool?** | Discount will include delivery fee | [optional] 
**AutoApplyResultingVouchers** | **bool?** | Automatically apply resulting vouchers | [optional] 
**IncludeExistingOrders** | **bool?** | Campaign will apply to existing orders | [optional] 
**IsEnabled** | **bool?** | Is campaign enabled | [optional] 
**StoreIds** | **List&lt;int?&gt;** | Ids of stores this campaign applies to | [optional] 
**AppId** | **string** | The app that this campaign belongs to. | [optional] 
**ForceDiscount** | **bool?** | Controls whether the voucher generated from this campaign will override discount exclusions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

