# Flipdish.Model.ExternalStoreEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventName** | **string** | The event name | [optional] 
**StoreId** | **int?** | Store Id | [optional] 
**User** | [**UserEventInfo**](UserEventInfo.md) | User which did the action | [optional] 
**Description** | **string** | Description | [optional] 
**DescriptionFormat** | **string** | Description with format placeholders | [optional] 
**DescriptionFields** | **string** | Description with format placeholders | [optional] 
**DescriptionId** | **string** | Description | [optional] 
**Ref1** | **string** | Ref (reference field) | [optional] 
**Ref2** | **string** | Ref2 (reference field) | [optional] 
**Ref3** | **string** | Ref3 (reference field) | [optional] 
**Ref4** | **string** | Ref4 (reference field) | [optional] 
**OrderId** | **int?** | Order Id | [optional] 
**Tags** | **List&lt;string&gt;** | Tags | [optional] 
**FieldChanges** | [**List&lt;FieldChangeInformation&gt;**](FieldChangeInformation.md) | Field changes list | [optional] 
**FlipdishEventId** | **Guid?** | The identitfier of the event | [optional] 
**CreateTime** | **DateTime?** | The time of creation of the event | [optional] 
**Position** | **int?** | Position | [optional] 
**AppId** | **string** | App id | [optional] 
**IpAddress** | **string** | Ip Address | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

