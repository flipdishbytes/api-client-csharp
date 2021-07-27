# Flipdish.Model.KioskBluetoothTerminalFirmwareVersionStatusEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceId** | **string** | Device Id of the Kiosk | [optional] 
**SerialNumber** | **string** | Serial Number of the device | [optional] 
**HasFirmwareUpdate** | **bool?** | Indicates if Payment Terminal has Firmware Update | [optional] 
**HasConfigUpdate** | **bool?** | Indicates if Payment Terminal has Config Update | [optional] 
**HasKeyUpdate** | **bool?** | Indicates if Payment Terminal has Key Update | [optional] 
**UpdateTimeEstimate** | **string** | ETA to install the update | [optional] 
**UserEventInfo** | [**UserEventInfo**](UserEventInfo.md) | User who made the changes | [optional] 
**EventName** | **string** | The event name | [optional] 
**FlipdishEventId** | **Guid?** | The identitfier of the event | [optional] 
**CreateTime** | **DateTime?** | The time of creation of the event | [optional] 
**Position** | **int?** | Position | [optional] 
**AppId** | **string** | App id | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

