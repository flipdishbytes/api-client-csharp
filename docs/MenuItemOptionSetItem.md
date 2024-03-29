# Flipdish.Model.MenuItemOptionSetItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MenuItemOptionSetItemId** | **int?** | Menu item option set item identifier | [optional] 
**PublicId** | **Guid?** | Permanent reference to the item. | [optional] 
**Metadata** | [**List&lt;CreateMetadata&gt;**](CreateMetadata.md) | List of metadata | [optional] 
**NextMenuItemOptionSetId** | **int?** | if null, next option set is next. if -1, this is the final option set | [optional] 
**CatalogItemId** | **string** | Catalog item Id when the OptionSet is associated to a Product | [optional] 
**TaxRateName** | **string** | Tax rate name | [optional] 
**TaxRateId** | **int?** |  | [optional] 
**TaxValue** | **double?** |  | [optional] 
**Name** | **string** | Name | [optional] 
**Price** | **double?** | Price | [optional] 
**DepositReturnFee** | **double?** | An optional fee that can be added to the price of the item. | [optional] 
**IsAvailable** | **bool?** | Is available | [optional] 
**DisplayOrder** | **int?** | Display order. Displayed in ascending order. | [optional] 
**CellLayoutType** | **string** | Small | Medium | Large  Affects the layout of the menu. | [optional] 
**ImageUrl** | **string** | Image url | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

