# Flipdish.Model.OrderCapacityConfigUpdatedEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventName** | **string** | The event name | [optional] 
**StoreId** | **int?** | Id of the store whose order capacity configuration has been updated | [optional] 
**User** | [**UserEventInfo**](UserEventInfo.md) | User which updated order capacity configuration for this store | [optional] 
**Description** | **string** | Description | [optional] 
**OrderCapacityConfig** | [**StoreOrderCapacityConfigEditModel**](StoreOrderCapacityConfigEditModel.md) | Updated order capacity configuration | [optional] 
**FlipdishEventId** | **Guid?** | The identitfier of the event | [optional] 
**CreateTime** | **DateTime?** | The time of creation of the event | [optional] 
**Position** | **int?** | Position | [optional] 
**AppId** | **string** | App id | [optional] 
**IpAddress** | **string** | Ip Address | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

