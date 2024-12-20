# Flipdish.Model.BankAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Id of this account | [optional] 
**AccountName** | **string** | Name of this account | [optional] 
**Iban** | **string** | IBAN of this account | [optional] 
**Swift** | **string** | SWIFT of this bank account | [optional] 
**PopulatedAccountFields** | [**List&lt;AccountFieldKeyValuePair&gt;**](AccountFieldKeyValuePair.md) | A list of one or more populated account fields (field key-value pairs).  If this list contains at least one item, the Iban, Swift and NationalClearingCode fields should be ignored. | [optional] 
**AccountState** | **string** | Status of Account | [optional] 
**StoreNames** | **List&lt;string&gt;** | Store Names that are attached to this account | [optional] 
**StoreIds** | **List&lt;int?&gt;** | Store Ids that are attached to this account | [optional] 
**BankAddress** | **string** | Address lf the bank | [optional] 
**BankCountryCode** | **string** | CountryCode of the Bank Account | [optional] 
**AccountHolderAddress** | **string** | Account Holders Address | [optional] 
**AccountHolderCountryCode** | **string** | Account Holders Country Code | [optional] 
**VatNumber** | **string** | Account Holders Vat Number | [optional] 
**StripeAccountId** | **string** | Stripe Id of the connected account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

