# IO.Swagger.Model.BankAccountSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Id of this account | [optional] 
**StoreNames** | **List&lt;string&gt;** | Store Names that are attached to this account | [optional] 
**AccountState** | **string** | Status of Account | [optional] 
**CurrencyCode** | **string** | Currency of Account | [optional] 
**StripeConnectedAccountInfo** | [**StripeConnectedAccountInfo**](StripeConnectedAccountInfo.md) | Information about the Stripe connected account associated with this bank account (if any) | [optional] 
**AccountName** | **string** | Name of this account | [optional] 
**Iban** | **string** | IBAN of this account | [optional] 
**Swift** | **string** | SWIFT of this bank account | [optional] 
**NationalClearingCode** | **string** | National Clearing Code (BSB in Australia, Routing Number in USA/Canada, NCC in NZ) | [optional] 
**PopulatedAccountFields** | [**List&lt;AccountFieldKeyValuePair&gt;**](AccountFieldKeyValuePair.md) | A list of one or more populated account fields (field key-value pairs).  If this list contains at least one item, the Iban, Swift and NationalClearingCode fields will be ignored. | [optional] 
**RejectionReason** | **string** | Reason for Rejection | [optional] 
**BusinessType** | **string** | Business Type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

