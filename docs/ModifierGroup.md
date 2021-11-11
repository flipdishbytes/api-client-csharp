# Flipdish.Model.ModifierGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **string** | Unique product id | [optional] 
**Sku** | **string** | Stock Keeping Unit (SKU) | [optional] 
**Name** | **string** | Product name | [optional] 
**Description** | **string** | Product description | [optional] 
**Price** | **double?** | Product price | [optional] 
**ProductType** | **string** | Product Type (SimpleProduct, Modifier, ModifierGroup, etc) | [optional] 
**ImageFileName** | **string** | Image File Name | [optional] 
**IsArchived** | **bool?** | Returns true if the product is archived | [optional] 
**Alcohol** | **bool?** | Product contains alcohol | [optional] 
**Discriminator** | **string** |  | 
**subProducts** | [**List&lt;ModifierGroupSubProduct&gt;**](ModifierGroupSubProduct.md) | Collection of products associated with this product | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
