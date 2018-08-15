# Flipdish.Model.Subscription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubscriptionId** | **int?** | The subscription identifier | [optional] 
**StartDate** | **DateTime?** | Starting date of the subscription | [optional] 
**Status** | **string** | Status of the subscription (TrialPeriod, Ongoing, Unpaid, Canceled) | [optional] 
**UserId** | **int?** | Flipdish user identifier | [optional] 
**SubscriptionPlan** | [**SubscriptionPlan**](SubscriptionPlan.md) | Subscription Plan | [optional] 
**Card** | [**Card**](Card.md) | Card | [optional] 
**AppId** | **string** | App name Id of the subscription | 
**VatNumber** | **string** | Last 4 digits of the card | [optional] 
**VatCountryCode** | **string** | Expiry date of the card | 
**Quantity** | **int?** | Number of physical restaurants | [optional] 
**SubscriptionPlanId** | **int?** | Subscription plan identifier | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

