# Flipdish.Model.MenuSectionItemBase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Menu item name (like \&quot;Korma\&quot;) | [optional] 
**Description** | **string** | Description (like \&quot;A lovely dish from the east\&quot;) | [optional] 
**SpicinessRating** | **string** | Spiciness rating | [optional] 
**Price** | **double?** | Price - this is only used when there is no master option set and should be set to 0 if a master option set exists. | [optional] 
**DepositReturnFee** | **double?** | An optional fee that can be added to the price of the item. | [optional] 
**DisplayOrder** | **int?** | Display order | [optional] 
**Alcohol** | **bool?** | To be set true if the item or an option of the item contains an alcoholic drink. | [optional] 
**IsAvailable** | **bool?** | True if we accept orders for this item still | [optional] 
**CellLayoutType** | **string** | Small | Medium | Large  Affects the layout of the menu. | [optional] 
**DisableVouchers** | **bool?** | If true, then vouchers won&#39;t be applied for this item | [optional] 
**ImageName** | **string** | Image url | [optional] 
**ImageUrl** | **string** | Image url | [optional] 
**MenuItemId** | **int?** | Menu Item Id | [optional] 
**ExcludeFromVoucherDiscounting** | **bool?** | If true, the item is excluded from voucher discount calculations | [optional] 
**PublicId** | **Guid?** | Permanent reference to the item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

