# Flipdish.Model.UserInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhoneNumber** | **string** | The user&#39;s phone number. | [optional] 
**Email** | **string** | The user&#39;s email address. | [optional] 
**EmailConfirmed** | **bool?** | Indicates if the user&#39;s email address has been confirmed. | [optional] 
**PreventFromUsingCards** | **bool?** | Indicates if the user is prevented from using cards. | [optional] 
**IsUserPhoneNumberBlocked** | **bool?** | Indicates if the user&#39;s phone number is blocked. | [optional] 
**UserWhiteLabels** | [**List&lt;UserWhiteLabelInfo&gt;**](UserWhiteLabelInfo.md) | List of white label information associated with the user. | [optional] 
**UserId** | **int?** | The unique identifier for the user. | [optional] 
**UserName** | **string** | The user&#39;s username. | [optional] 
**CustomerName** | **string** | The customer&#39;s name. | [optional] 
**HasLoggedIn** | **bool?** | Indicates if the user has logged in. | [optional] 
**DisableAppRatingControl** | **bool?** | Indicates if the app rating control is disabled for the user. | [optional] 
**GloballyOptedOut** | **bool?** | Indicates if the user has globally opted out. | [optional] 
**CompletedOrderCount** | **int?** | The number of completed orders by the user. | [optional] 
**CancelledOrderCount** | **int?** | The number of cancelled orders by the user. | [optional] 
**OrderTotalValue** | **double?** | The total value of orders placed by the user. | [optional] 
**TsMostRecentOrder** | **DateTime?** | The timestamp of the user&#39;s most recent order. | [optional] 
**TsFirstOrder** | **DateTime?** | The timestamp of the user&#39;s first order. | [optional] 
**IsRestaurantUser** | **bool?** | Indicates if the user is a restaurant user. | [optional] 
**Installs** | [**List&lt;AppInstall&gt;**](AppInstall.md) | List of app installs associated with the user. | [optional] 
**DeliveryLocations** | [**List&lt;DeliveryLocation&gt;**](DeliveryLocation.md) | List of delivery locations associated with the user. | [optional] 
**PaymentAccounts** | [**List&lt;PaymentAccount&gt;**](PaymentAccount.md) | List of payment accounts associated with the user. | [optional] 
**LanguageId** | **string** | The language identifier for the user. | [optional] 
**CurrentLanguageName** | **string** | Current language name for the user. | [optional] 
**Languages** | [**List&lt;Language&gt;**](Language.md) | Available languages that the user can choose from. | [optional] 
**SalesForceContactId** | **string** | The Salesforce contact ID for the user. | [optional] 
**StripeCustomerId** | **string** | The Stripe customer ID for the user. | [optional] 
**UserMonthlyCommissions** | [**List&lt;UserMonthlyCommission&gt;**](UserMonthlyCommission.md) | User&#39;s monthly commissions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

