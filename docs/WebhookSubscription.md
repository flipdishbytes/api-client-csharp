# Flipdish.Model.WebhookSubscription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Webhook subscription identifier | [optional] 
**OwnerUserId** | **int?** | Webhook subscription owner user identifier | [optional] 
**Version** | **string** | Webhook subscription owner user identifier | [optional] 
**EventNames** | **List&lt;string&gt;** | Webhook subscription event names | [optional] 
**CallbackUrl** | **string** | Callback url. Flipdish system POST messages to this url. | [optional] 
**Enabled** | **bool?** | Is webhook subscription enabled. | [optional] 
**VerifyToken** | **string** | This is your token which will be in the Header of each POST request from Flipdish with name: X-Verify-Token. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

