# IO.Swagger.Model.EmvTerminalWithAssignments
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmvTerminalId** | **string** | Flipdish Internal identifier of the Terminal | [optional] 
**TerminalId** | **string** | External Identifier of the Terminal | [optional] 
**IsAssignedToHydraDevice** | **bool?** | true if the terminal is assigned to a hydra device (e.g. a kiosk) | [optional] 
**HydraConfigId** | **int?** | hydra device id (null if the terminal is not assigned to any hydra device) | [optional] 
**HydraDeviceId** | **string** | external hydra device id (null if the terminal is not assigned to any hydra device) | [optional] 
**HydraName** | **string** | hydra device name (null if the terminal is not assigned to any hydra device) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

