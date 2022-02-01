# Flipdish.Model.LightspeedSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **string** | Company Id | [optional] 
**UseOAuth** | **bool?** | Use OAuth for authentication | [optional] 
**Enabled** | **bool?** | Enabled | [optional] 
**EstimatedMinutesForDelivery** | **int?** | Estimated minutes for delivery | [optional] 
**EstimatedMinutesForCollection** | **int?** | Estimated minutes for collection | [optional] 
**GeographicLocation** | **string** | Geographic location (euc1, nae1, euw2, ....)) | [optional] 
**Establishment** | **bool?** | Is the CompanyId an establishment (kind of the store of a group of store) | [optional] 
**VoucherId** | **string** | The Lightspeed voucher identifier to map with our | [optional] 
**DeliveryFeeId** | **string** | The Lightspeed delivery fee identifier to map with our | [optional] 
**ProcessingFeeId** | **string** | The Lightspeed processing fee identifier to map with our | [optional] 
**PriceType** | **string** | Which price to choose from Lightspeed menu | [optional] 
**MenuId** | **int?** | The menu id of the store | [optional] 
**CollectionTableId** | **int?** | Collection Table ID to send orders | [optional] 
**DeliveryTableId** | **int?** | Delivery Table ID to send orders | [optional] 
**CollectionTableIds** | **Dictionary&lt;string, string&gt;** | Collection Table IDs to send orders to | [optional] 
**DeliveryTableIds** | **Dictionary&lt;string, string&gt;** | Delivery Table IDs to send orders to | [optional] 
**UseTaxInclusivePrices** | **bool?** | Exclude tax | [optional] 
**SkipStatusCheckAndAcceptOrderAfterSending** | **bool?** | WARNING: only use this option if the Liteserver is not synchronizing within max 5 minutes with Lightspeed cloud! | [optional] 
**SendTableNumberToTableId** | **bool?** | Send Table Number to Table Id | [optional] 
**AddChefNoteToProduct** | **bool?** | Add ChefNote To Product | [optional] 
**ChefNoteItemId** | **string** | The Lightspeed Chef Note Item Id to map | [optional] 
**ChefNoteModifierId** | **string** | The Lightspeed Chef Note Modifier Id to map | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

