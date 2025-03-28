# Flipdish.Model.StoreOpeningHoursUpdatedEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventName** | **string** | The event name | [optional] 
**OrgId** | **string** | Organisation Id | [optional] 
**StoreId** | **int?** | Store Id | [optional] 
**StoreGroupId** | **int?** | Store group Id | [optional] 
**User** | [**UserEventInfo**](UserEventInfo.md) | User which updated opening hours for this store | [optional] 
**DeliveryType** | **string** | Type of opening hours Delivery / Pickup | [optional] 
**DeliveryTypeString** | **string** | Type of opening hours Delivery / Pickup as a string | [optional] 
**BusinessHoursPeriodOld** | [**BusinessHoursPeriod**](BusinessHoursPeriod.md) | The period that was updated | [optional] 
**BusinessHoursPeriod** | [**BusinessHoursPeriod**](BusinessHoursPeriod.md) | The new values of the period | [optional] 
**Description** | **string** | Description | [optional] 
**FlipdishEventId** | **Guid?** | The identitfier of the event | [optional] 
**CreateTime** | **DateTime?** | The time of creation of the event | [optional] 
**Position** | **int?** | Position | [optional] 
**AppId** | **string** | App id | [optional] 
**IpAddress** | **string** | Ip Address | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

