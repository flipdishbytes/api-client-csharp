# Flipdish.Model.OrderRejectedEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventName** | **string** | The event name | [optional] 
**Description** | **string** | Description | [optional] 
**OrderRejectedTime** | **DateTime?** | Order Rejected Time | [optional] 
**Reason** | **string** | Reason for Rejection | [optional] 
**User** | [**UserEventInfo**](UserEventInfo.md) | User who has rejected the order | [optional] 
**Order** | [**Order**](Order.md) | Order | [optional] 
**FlipdishEventId** | **Guid?** | The identitfier of the event | [optional] 
**CreateTime** | **DateTime?** | The time of creation of the event | [optional] 
**Position** | **int?** | Position | [optional] 
**AppId** | **string** | App id | [optional] 
**IpAddress** | **string** | Ip Address | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

