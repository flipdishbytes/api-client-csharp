# IO.Swagger.Model.BankAccountDetailsUpdateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankAddress** | **string** | Address of the bank account | [optional] 
**AccountHolderAddress** | **string** | Address of the payee | [optional] 
**VatNumber** | **string** | Account Holders Vat Number | [optional] 
**StoreIds** | **List&lt;int?&gt;** | List of stores to attach to Account | [optional] 
**BankName** | **string** | Name of Bank | [optional] 
**AccountName** | **string** | Name of this account | [optional] 
**Iban** | **string** | IBAN of this account | [optional] 
**Swift** | **string** | SWIFT of this bank account | [optional] 
**NationalClearingCode** | **string** | National Clearing Code (BSB in Australia, Routing Number in USA/Canada, NCC in NZ) | [optional] 
**PopulatedAccountFields** | [**List&lt;AccountFieldKeyValuePair&gt;**](AccountFieldKeyValuePair.md) | A list of one or more populated account fields (field key-value pairs).  If this list contains at least one item, the Iban, Swift and NationalClearingCode fields will be ignored. | [optional] 
**RejectionReason** | **string** | Reason for Rejection | [optional] 
**BusinessType** | **string** | Business Type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

