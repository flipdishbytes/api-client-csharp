# Flipdish.Model.StoreFeeConfigUpdatedEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventName** | **string** | The event name | [optional] 
**StoreId** | **int?** | Store Id | [optional] 
**StoreGroupId** | **int?** | Store group Id | [optional] 
**User** | [**UserEventInfo**](UserEventInfo.md) | User which updated this store address | [optional] 
**Description** | **string** | Description | [optional] 
**Changes** | **string** | Diff between before and after | [optional] 
**StoreFeeConfig** | [**StoreFeeConfig**](StoreFeeConfig.md) | Store fee config | [optional] 
**FlipdishEventId** | **Guid?** | The identitfier of the event | [optional] 
**CreateTime** | **DateTime?** | The time of creation of the event | [optional] 
**Position** | **int?** | Position | [optional] 
**AppId** | **string** | App id | [optional] 
**OrgId** | **string** | Org id | [optional] 
**IpAddress** | **string** | Ip Address | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

