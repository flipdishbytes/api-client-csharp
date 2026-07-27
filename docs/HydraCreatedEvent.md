# Flipdish.Model.HydraCreatedEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**User** | [**UserEventInfo**](UserEventInfo.md) | Optional user who triggered creation (may be null for device self-create). | [optional] 
**DeviceId** | **string** | Device id | [optional] 
**HydraUserId** | **int?** | Zeus Hydra user id | [optional] 
**UserType** | **string** | Hydra user type (Kiosk / Terminal) as integer. Prefer {Flipdish.PublicModels.V1.Events.Hydra.HydraCreatedEvent.DeviceType}. | [optional] 
**DeviceType** | **string** | Hydra device type (Kiosk / Terminal), serialized as string. | [optional] 
**EventName** | **string** | The event name | [optional] 
**FlipdishEventId** | **Guid?** | The identitfier of the event | [optional] 
**CreateTime** | **DateTime?** | The time of creation of the event | [optional] 
**Position** | **int?** | Position | [optional] 
**AppId** | **string** | App id | [optional] 
**OrgId** | **string** | Org id | [optional] 
**IpAddress** | **string** | Ip Address | [optional] 
**ActivityId** | **string** | Activity Id | [optional] 
**ActivityType** | **string** | Activity Type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

