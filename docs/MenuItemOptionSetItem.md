# Flipdish.Model.MenuItemOptionSetItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MenuItemOptionSetItemId** | **int?** | Menu item option set item identifier | [optional] 
**PublicId** | **Guid?** | Permanent reference to the item. | [optional] 
**Metadata** | [**List&lt;CreateMetadata&gt;**](CreateMetadata.md) | List of metadata | [optional] 
**NextMenuItemOptionSetId** | **int?** | if null, next option set is next. if -1, this is the final option set | [optional] 
**ProductId** | **string** | Product Id when the OptionSet is associated to a Product | [optional] 
**Name** | **string** | Name | [optional] 
**Price** | **double?** | Price | [optional] 
**IsAvailable** | **bool?** | Is available | [optional] 
**DisplayOrder** | **int?** | Display order. Displayed in ascending order. | [optional] 
**CellLayoutType** | **string** | Small | Medium | Large  Affects the layout of the menu. | [optional] 
**ImageUrl** | **string** | Image url | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

