# Flipdish.Model.AppStoreAppSubscriptionSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalSubscriptions** | **int?** | Total subscriptions (per the AppId subscription setup) | [optional] 
**UsedSubscriptions** | **int?** | Number of subscriptions configured and enabled | [optional] 
**SubscriptionAccountIsSetupForClient** | **bool?** | Is client setup for subscriptions | [optional] 
**SubscriptionAccounts** | [**List&lt;AppStoreAppSubscriptionAccount&gt;**](AppStoreAppSubscriptionAccount.md) | Available accounts for subscriptions (only if requesting user has enough permissions to see the list, otherwise empty list or null) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

