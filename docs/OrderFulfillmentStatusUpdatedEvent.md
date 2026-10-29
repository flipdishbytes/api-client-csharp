# Flipdish.Model.OrderFulfillmentStatusUpdatedEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventName** | **string** | The event name | [optional] 
**StoreId** | **int?** | Store Id | [optional] 
**Description** | **string** | Description | [optional] 
**OrderId** | **int?** | Order Id | [optional] 
**StatusName** | **string** | Fulfillment status name | [optional] 
**StatusId** | **string** | Fulfillment status ID | [optional] 
**Customer** | [**FulfillmentStatusEventCustomer**](FulfillmentStatusEventCustomer.md) | Optional slim customer (Id + language) for push / notification consumers | [optional] 
**Store** | [**FulfillmentStatusEventStore**](FulfillmentStatusEventStore.md) | Optional slim store (Name); StoreId remains top-level | [optional] 
**AppType** | **string** | Order app type (e.g. Ios, Android) when known | [optional] 
**FlipdishEventId** | **Guid?** | The identitfier of the event | [optional] 
**CreateTime** | **DateTime?** | The time of creation of the event | [optional] 
**Position** | **int?** | Position | [optional] 
**AppId** | **string** | App id | [optional] 
**OrgId** | **string** | Org id | [optional] 
**IpAddress** | **string** | Ip Address | [optional] 
**ActivityId** | **string** | Activity Id | [optional] 
**ActivityType** | **string** | Activity Type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

