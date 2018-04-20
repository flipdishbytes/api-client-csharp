# Flipdish.Model.HttpRequestAndResponseLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Verb** | **string** | Verb associated with the HTTP call. | [optional] 
**RequestUri** | **string** | Http request URI. | [optional] 
**StatusCode** | **int?** | Http response status code. | [optional] 
**ReasonPhrase** | **string** | Http response status line. | [optional] 
**CallDurationInMilliseconds** | **long?** | Call duration representing the duration of the HTTP call in milliseconds. | [optional] 
**UserId** | **string** | Identity of the caller. | [optional] 
**IpAddress** | **string** | Ip address of the caller | [optional] 
**CreatedDateTime** | **string** | Timestamp at which the HTTP call took place. | [optional] 
**RequestHeaders** | **Dictionary&lt;string, string&gt;** | Http request headers. | [optional] 
**RequestBody** | **string** | Http request body, if any. | [optional] 
**RequestLength** | **long?** | Http request content-length | [optional] 
**ResponseHeaders** | **Dictionary&lt;string, string&gt;** | Http response headers. | [optional] 
**ResponseBody** | **string** | Http response body. | [optional] 
**ResponseLength** | **long?** | Http response content-length | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

