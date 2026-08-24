# Flipdish.Model.StripeConnectedAccountInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountStatus** | **string** | Stripe connected account status | [optional] 
**StripeId** | **string** | Stripe connected account id | [optional] 
**CardPaymentStatus** | **string** | Current status of the Card Payment capability of the account | [optional] 
**PayoutScheduleInterval** | **string** | Payouts Schedule Interval | [optional] 
**PayoutsEnabled** | **bool?** | Payouts Enabled status | [optional] 
**PayoutsPaused** | **bool?** | Flag indicating if payouts are paused | [optional] 
**PaymentsEnabled** | **bool?** | Flag indicating if payments are enabled | [optional] 
**DisabledReason** | **string** | If the Stripe connected account is disabled, this is Stripe&#39;s raw  requirements.disabled_reason describing why, as last recorded from a Stripe  connected-account webhook. Known values are requirements.fields_needed,  requirements.past_due, requirements.pending_verification,  rejected.fraud, rejected.terms_of_service, rejected.listed,  rejected.other and platform_paused, but Stripe can introduce new ones, so  the value is passed through unmapped (the same way  CapabilityRequirementsInfo.DisabledReason is). null when the account is  not disabled. Note that {Flipdish.PublicModels.V1.BankAccount.StripeConnectedAccountInfo.AccountStatus} is a deliberately lossy mapping of  this value and the two can legitimately disagree - do not derive one from the other. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

