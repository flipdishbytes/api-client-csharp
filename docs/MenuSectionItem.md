# Flipdish.Model.MenuSectionItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MenuItemId** | **int?** | Menu item identifier. This ID may change at any time. Use &#x60;PublicId&#x60; if you need a perminant reference to the item. | [optional] 
**ActualPrice** | **double?** | Actual price - the minimum price possible when all required option set items prices are included. | [optional] 
**ImageUrl** | **string** | Image url | [optional] 
**MenuItemOptionSets** | [**List&lt;MenuItemOptionSet&gt;**](MenuItemOptionSet.md) | Menu item option sets | [optional] 
**DailySpecialHours** | [**List&lt;BusinessHoursPeriod&gt;**](BusinessHoursPeriod.md) | Daily special hours | [optional] 
**PublicId** | **Guid?** | Permanent reference to the item. | [optional] 
**Name** | **string** | Menu item name (like \&quot;Korma\&quot;) | [optional] 
**Description** | **string** | Description (like \&quot;A lovely dish from the east\&quot;) | [optional] 
**SpicinessRating** | **string** | Spiciness rating | [optional] 
**Price** | **double?** | Price - this is only used when there is no master option set and should be set to 0 if a master option set exists. | [optional] 
**DisplayOrder** | **int?** | Display order | [optional] 
**Alcohol** | **bool?** | To be set true if the item or an option of the item contains an alcoholic drink. | [optional] 
**IsAvailable** | **bool?** | True if we accept orders for this item still | [optional] 
**CellLayoutType** | **string** | Small | Medium | Large  Affects the layout of the menu. | [optional] 
**DisableVouchers** | **bool?** | If true, then vouchers won&#39;t be applied for this item | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

