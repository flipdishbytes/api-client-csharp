# Flipdish.Model.LoyaltyCampaign
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignId** | **int?** | Id of campaign | [optional] 
**Statistics** | [**CampaignStatistics**](CampaignStatistics.md) | Statistics of campaign | [optional] 
**Stores** | [**List&lt;StoreCampaignStartTime&gt;**](StoreCampaignStartTime.md) | Stores this campaign applies to with campaign start time in Utc | [optional] 
**PublicId** | **Guid?** | Permanent reference to the item. | [optional] 
**OrdersBeforeReceivingVoucher** | **int?** | Number of orders customer needs to make, before receiving voucher | [optional] 
**PercentDiscountAmount** | **int?** | Discount amount in percents | [optional] 
**RoundingStrategy** | **int?** | Controls how the loyalty voucher&#39;s amount is rounded | [optional] 
**ShouldIncludeOrdersWithLoyaltyVoucher** | **bool?** | Controls whether we should include orders with loyalty vouchers in the campaign calculation | [optional] 
**VoucherValidPeriodDays** | **int?** | Number of days for which the voucher will be valid. | [optional] 
**IncludeDeliveryFee** | **bool?** | Discount will include delivery fee | [optional] 
**AutoApplyResultingVouchers** | **bool?** | Automatically apply resulting vouchers | [optional] 
**IncludeExistingOrders** | **bool?** | Campaign will apply to existing orders | [optional] 
**IsEnabled** | **bool?** | Is campaign enabled | [optional] 
**StoreIds** | **List&lt;int?&gt;** | Ids of stores this campaign applies to | [optional] 
**AppId** | **string** | The app that this campaign belongs to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

