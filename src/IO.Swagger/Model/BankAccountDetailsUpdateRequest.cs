/* 
 * Flipdish Open API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Represents a request to update bank account information details
    /// </summary>
    [DataContract]
    public partial class BankAccountDetailsUpdateRequest :  IEquatable<BankAccountDetailsUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Business Type
        /// </summary>
        /// <value>Business Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BusinessTypeEnum
        {
            
            /// <summary>
            /// Enum Individual for value: Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual = 1,
            
            /// <summary>
            /// Enum Company for value: Company
            /// </summary>
            [EnumMember(Value = "Company")]
            Company = 2,
            
            /// <summary>
            /// Enum NonProfit for value: NonProfit
            /// </summary>
            [EnumMember(Value = "NonProfit")]
            NonProfit = 3,
            
            /// <summary>
            /// Enum GovernmentEntity for value: GovernmentEntity
            /// </summary>
            [EnumMember(Value = "GovernmentEntity")]
            GovernmentEntity = 4
        }

        /// <summary>
        /// Business Type
        /// </summary>
        /// <value>Business Type</value>
        [DataMember(Name="BusinessType", EmitDefaultValue=false)]
        public BusinessTypeEnum? BusinessType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountDetailsUpdateRequest" /> class.
        /// </summary>
        /// <param name="bankAddress">Address of the bank account.</param>
        /// <param name="accountHolderAddress">Address of the payee.</param>
        /// <param name="vatNumber">Account Holders Vat Number.</param>
        /// <param name="storeIds">List of stores to attach to Account.</param>
        /// <param name="bankName">Name of Bank.</param>
        /// <param name="accountName">Name of this account.</param>
        /// <param name="iban">IBAN of this account.</param>
        /// <param name="swift">SWIFT of this bank account.</param>
        /// <param name="nationalClearingCode">National Clearing Code (BSB in Australia, Routing Number in USA/Canada, NCC in NZ).</param>
        /// <param name="populatedAccountFields">A list of one or more populated account fields (field key-value pairs).  If this list contains at least one item, the Iban, Swift and NationalClearingCode fields will be ignored..</param>
        /// <param name="rejectionReason">Reason for Rejection.</param>
        /// <param name="businessType">Business Type.</param>
        public BankAccountDetailsUpdateRequest(string bankAddress = default(string), string accountHolderAddress = default(string), string vatNumber = default(string), List<int?> storeIds = default(List<int?>), string bankName = default(string), string accountName = default(string), string iban = default(string), string swift = default(string), string nationalClearingCode = default(string), List<AccountFieldKeyValuePair> populatedAccountFields = default(List<AccountFieldKeyValuePair>), string rejectionReason = default(string), BusinessTypeEnum? businessType = default(BusinessTypeEnum?))
        {
            this.BankAddress = bankAddress;
            this.AccountHolderAddress = accountHolderAddress;
            this.VatNumber = vatNumber;
            this.StoreIds = storeIds;
            this.BankName = bankName;
            this.AccountName = accountName;
            this.Iban = iban;
            this.Swift = swift;
            this.NationalClearingCode = nationalClearingCode;
            this.PopulatedAccountFields = populatedAccountFields;
            this.RejectionReason = rejectionReason;
            this.BusinessType = businessType;
        }
        
        /// <summary>
        /// Address of the bank account
        /// </summary>
        /// <value>Address of the bank account</value>
        [DataMember(Name="BankAddress", EmitDefaultValue=false)]
        public string BankAddress { get; set; }

        /// <summary>
        /// Address of the payee
        /// </summary>
        /// <value>Address of the payee</value>
        [DataMember(Name="AccountHolderAddress", EmitDefaultValue=false)]
        public string AccountHolderAddress { get; set; }

        /// <summary>
        /// Account Holders Vat Number
        /// </summary>
        /// <value>Account Holders Vat Number</value>
        [DataMember(Name="VatNumber", EmitDefaultValue=false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// List of stores to attach to Account
        /// </summary>
        /// <value>List of stores to attach to Account</value>
        [DataMember(Name="StoreIds", EmitDefaultValue=false)]
        public List<int?> StoreIds { get; set; }

        /// <summary>
        /// Name of Bank
        /// </summary>
        /// <value>Name of Bank</value>
        [DataMember(Name="BankName", EmitDefaultValue=false)]
        public string BankName { get; set; }

        /// <summary>
        /// Name of this account
        /// </summary>
        /// <value>Name of this account</value>
        [DataMember(Name="AccountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// IBAN of this account
        /// </summary>
        /// <value>IBAN of this account</value>
        [DataMember(Name="Iban", EmitDefaultValue=false)]
        public string Iban { get; set; }

        /// <summary>
        /// SWIFT of this bank account
        /// </summary>
        /// <value>SWIFT of this bank account</value>
        [DataMember(Name="Swift", EmitDefaultValue=false)]
        public string Swift { get; set; }

        /// <summary>
        /// National Clearing Code (BSB in Australia, Routing Number in USA/Canada, NCC in NZ)
        /// </summary>
        /// <value>National Clearing Code (BSB in Australia, Routing Number in USA/Canada, NCC in NZ)</value>
        [DataMember(Name="NationalClearingCode", EmitDefaultValue=false)]
        public string NationalClearingCode { get; set; }

        /// <summary>
        /// A list of one or more populated account fields (field key-value pairs).  If this list contains at least one item, the Iban, Swift and NationalClearingCode fields will be ignored.
        /// </summary>
        /// <value>A list of one or more populated account fields (field key-value pairs).  If this list contains at least one item, the Iban, Swift and NationalClearingCode fields will be ignored.</value>
        [DataMember(Name="PopulatedAccountFields", EmitDefaultValue=false)]
        public List<AccountFieldKeyValuePair> PopulatedAccountFields { get; set; }

        /// <summary>
        /// Reason for Rejection
        /// </summary>
        /// <value>Reason for Rejection</value>
        [DataMember(Name="RejectionReason", EmitDefaultValue=false)]
        public string RejectionReason { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccountDetailsUpdateRequest {\n");
            sb.Append("  BankAddress: ").Append(BankAddress).Append("\n");
            sb.Append("  AccountHolderAddress: ").Append(AccountHolderAddress).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Swift: ").Append(Swift).Append("\n");
            sb.Append("  NationalClearingCode: ").Append(NationalClearingCode).Append("\n");
            sb.Append("  PopulatedAccountFields: ").Append(PopulatedAccountFields).Append("\n");
            sb.Append("  RejectionReason: ").Append(RejectionReason).Append("\n");
            sb.Append("  BusinessType: ").Append(BusinessType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BankAccountDetailsUpdateRequest);
        }

        /// <summary>
        /// Returns true if BankAccountDetailsUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccountDetailsUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountDetailsUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BankAddress == input.BankAddress ||
                    (this.BankAddress != null &&
                    this.BankAddress.Equals(input.BankAddress))
                ) && 
                (
                    this.AccountHolderAddress == input.AccountHolderAddress ||
                    (this.AccountHolderAddress != null &&
                    this.AccountHolderAddress.Equals(input.AccountHolderAddress))
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
                ) && 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
                (
                    this.Swift == input.Swift ||
                    (this.Swift != null &&
                    this.Swift.Equals(input.Swift))
                ) && 
                (
                    this.NationalClearingCode == input.NationalClearingCode ||
                    (this.NationalClearingCode != null &&
                    this.NationalClearingCode.Equals(input.NationalClearingCode))
                ) && 
                (
                    this.PopulatedAccountFields == input.PopulatedAccountFields ||
                    this.PopulatedAccountFields != null &&
                    this.PopulatedAccountFields.SequenceEqual(input.PopulatedAccountFields)
                ) && 
                (
                    this.RejectionReason == input.RejectionReason ||
                    (this.RejectionReason != null &&
                    this.RejectionReason.Equals(input.RejectionReason))
                ) && 
                (
                    this.BusinessType == input.BusinessType ||
                    (this.BusinessType != null &&
                    this.BusinessType.Equals(input.BusinessType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BankAddress != null)
                    hashCode = hashCode * 59 + this.BankAddress.GetHashCode();
                if (this.AccountHolderAddress != null)
                    hashCode = hashCode * 59 + this.AccountHolderAddress.GetHashCode();
                if (this.VatNumber != null)
                    hashCode = hashCode * 59 + this.VatNumber.GetHashCode();
                if (this.StoreIds != null)
                    hashCode = hashCode * 59 + this.StoreIds.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.Swift != null)
                    hashCode = hashCode * 59 + this.Swift.GetHashCode();
                if (this.NationalClearingCode != null)
                    hashCode = hashCode * 59 + this.NationalClearingCode.GetHashCode();
                if (this.PopulatedAccountFields != null)
                    hashCode = hashCode * 59 + this.PopulatedAccountFields.GetHashCode();
                if (this.RejectionReason != null)
                    hashCode = hashCode * 59 + this.RejectionReason.GetHashCode();
                if (this.BusinessType != null)
                    hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
