# Flipdish.Model.MenuSectionItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActualPrice** | **double?** | Actual price - the minimum price possible when all required option set items prices are included. | [optional] 
**MenuItemOptionSets** | [**List&lt;MenuItemOptionSet&gt;**](MenuItemOptionSet.md) | Menu item option sets | [optional] 
**DailySpecialHours** | [**List&lt;BusinessHoursPeriod&gt;**](BusinessHoursPeriod.md) | Daily special hours | [optional] 
**PublicId** | **Guid?** | Permanent reference to the item. | [optional] 
**TaxRateName** | **string** | Tax rate name | [optional] 
**TaxRateId** | **int?** | TaxRate | [optional] 
**TaxValue** | **double?** | TaxValue - the tax associated with this item, based on TaxRate / TaxType and Currency (currency determines decimal point precision) | [optional] 
**ExcludeFromVoucherDiscounting** | **bool?** | If true, the item is excluded from voucher discount calculations | [optional] 
**Metadata** | [**List&lt;CreateMetadata&gt;**](CreateMetadata.md) | List of metadata | [optional] 
**CatalogItemId** | **string** | Catalog item Id when the Item is associated to a Product | [optional] 
**Name** | **string** | Menu item name (like \&quot;Korma\&quot;) | [optional] 
**Description** | **string** | Description (like \&quot;A lovely dish from the east\&quot;) | [optional] 
**SpicinessRating** | **string** | Spiciness rating | [optional] 
**Price** | **double?** | Price - this is only used when there is no master option set and should be set to 0 if a master option set exists. | [optional] 
**DisplayOrder** | **int?** | Display order | [optional] 
**Alcohol** | **bool?** | To be set true if the item or an option of the item contains an alcoholic drink. | [optional] 
**IsAvailable** | **bool?** | True if we accept orders for this item still | [optional] 
**CellLayoutType** | **string** | Small | Medium | Large  Affects the layout of the menu. | [optional] 
**DisableVouchers** | **bool?** | If true, then vouchers won&#39;t be applied for this item | [optional] 
**ImageName** | **string** | Image url | [optional] 
**ImageUrl** | **string** | Image url | [optional] 
**MenuItemId** | **int?** | Menu Item Id | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

