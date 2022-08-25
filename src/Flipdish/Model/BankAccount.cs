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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Flipdish.Client.SwaggerDateConverter;

namespace Flipdish.Model
{
    /// <summary>
    /// BANK ACCOUNT
    /// </summary>
    [DataContract]
    public partial class BankAccount :  IEquatable<BankAccount>
    {
        /// <summary>
        /// Status of Account
        /// </summary>
        /// <value>Status of Account</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountStateEnum
        {
            
            /// <summary>
            /// Enum Unverified for value: Unverified
            /// </summary>
            [EnumMember(Value = "Unverified")]
            Unverified = 1,
            
            /// <summary>
            /// Enum AwatingVerification for value: AwatingVerification
            /// </summary>
            [EnumMember(Value = "AwatingVerification")]
            AwatingVerification = 2,
            
            /// <summary>
            /// Enum Verified for value: Verified
            /// </summary>
            [EnumMember(Value = "Verified")]
            Verified = 3,
            
            /// <summary>
            /// Enum Grandfathered for value: Grandfathered
            /// </summary>
            [EnumMember(Value = "Grandfathered")]
            Grandfathered = 4
        }

        /// <summary>
        /// Status of Account
        /// </summary>
        /// <value>Status of Account</value>
        [DataMember(Name="AccountState", EmitDefaultValue=false)]
        public AccountStateEnum? AccountState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount" /> class.
        /// </summary>
        /// <param name="id">Id of this account.</param>
        /// <param name="accountName">Name of this account.</param>
        /// <param name="iban">IBAN of this account.</param>
        /// <param name="swift">SWIFT of this bank account.</param>
        /// <param name="populatedAccountFields">A list of one or more populated account fields (field key-value pairs).  If this list contains at least one item, the Iban, Swift and NationalClearingCode fields should be ignored..</param>
        /// <param name="accountState">Status of Account.</param>
        /// <param name="storeNames">Store Names that are attached to this account.</param>
        /// <param name="bankAddress">Address lf the bank.</param>
        /// <param name="bankCountryCode">CountryCode of the Bank Account.</param>
        /// <param name="accountHolderAddress">Account Holders Address.</param>
        /// <param name="accountHolderCountryCode">Account Holders Country Code.</param>
        /// <param name="vatNumber">Account Holders Vat Number.</param>
        public BankAccount(int? id = default(int?), string accountName = default(string), string iban = default(string), string swift = default(string), List<AccountFieldKeyValuePair> populatedAccountFields = default(List<AccountFieldKeyValuePair>), AccountStateEnum? accountState = default(AccountStateEnum?), List<string> storeNames = default(List<string>), string bankAddress = default(string), string bankCountryCode = default(string), string accountHolderAddress = default(string), string accountHolderCountryCode = default(string), string vatNumber = default(string))
        {
            this.Id = id;
            this.AccountName = accountName;
            this.Iban = iban;
            this.Swift = swift;
            this.PopulatedAccountFields = populatedAccountFields;
            this.AccountState = accountState;
            this.StoreNames = storeNames;
            this.BankAddress = bankAddress;
            this.BankCountryCode = bankCountryCode;
            this.AccountHolderAddress = accountHolderAddress;
            this.AccountHolderCountryCode = accountHolderCountryCode;
            this.VatNumber = vatNumber;
        }
        
        /// <summary>
        /// Id of this account
        /// </summary>
        /// <value>Id of this account</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

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
        /// A list of one or more populated account fields (field key-value pairs).  If this list contains at least one item, the Iban, Swift and NationalClearingCode fields should be ignored.
        /// </summary>
        /// <value>A list of one or more populated account fields (field key-value pairs).  If this list contains at least one item, the Iban, Swift and NationalClearingCode fields should be ignored.</value>
        [DataMember(Name="PopulatedAccountFields", EmitDefaultValue=false)]
        public List<AccountFieldKeyValuePair> PopulatedAccountFields { get; set; }


        /// <summary>
        /// Store Names that are attached to this account
        /// </summary>
        /// <value>Store Names that are attached to this account</value>
        [DataMember(Name="StoreNames", EmitDefaultValue=false)]
        public List<string> StoreNames { get; set; }

        /// <summary>
        /// Address lf the bank
        /// </summary>
        /// <value>Address lf the bank</value>
        [DataMember(Name="BankAddress", EmitDefaultValue=false)]
        public string BankAddress { get; set; }

        /// <summary>
        /// CountryCode of the Bank Account
        /// </summary>
        /// <value>CountryCode of the Bank Account</value>
        [DataMember(Name="BankCountryCode", EmitDefaultValue=false)]
        public string BankCountryCode { get; set; }

        /// <summary>
        /// Account Holders Address
        /// </summary>
        /// <value>Account Holders Address</value>
        [DataMember(Name="AccountHolderAddress", EmitDefaultValue=false)]
        public string AccountHolderAddress { get; set; }

        /// <summary>
        /// Account Holders Country Code
        /// </summary>
        /// <value>Account Holders Country Code</value>
        [DataMember(Name="AccountHolderCountryCode", EmitDefaultValue=false)]
        public string AccountHolderCountryCode { get; set; }

        /// <summary>
        /// Account Holders Vat Number
        /// </summary>
        /// <value>Account Holders Vat Number</value>
        [DataMember(Name="VatNumber", EmitDefaultValue=false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Swift: ").Append(Swift).Append("\n");
            sb.Append("  PopulatedAccountFields: ").Append(PopulatedAccountFields).Append("\n");
            sb.Append("  AccountState: ").Append(AccountState).Append("\n");
            sb.Append("  StoreNames: ").Append(StoreNames).Append("\n");
            sb.Append("  BankAddress: ").Append(BankAddress).Append("\n");
            sb.Append("  BankCountryCode: ").Append(BankCountryCode).Append("\n");
            sb.Append("  AccountHolderAddress: ").Append(AccountHolderAddress).Append("\n");
            sb.Append("  AccountHolderCountryCode: ").Append(AccountHolderCountryCode).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
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
            return this.Equals(input as BankAccount);
        }

        /// <summary>
        /// Returns true if BankAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.PopulatedAccountFields == input.PopulatedAccountFields ||
                    this.PopulatedAccountFields != null &&
                    this.PopulatedAccountFields.SequenceEqual(input.PopulatedAccountFields)
                ) && 
                (
                    this.AccountState == input.AccountState ||
                    (this.AccountState != null &&
                    this.AccountState.Equals(input.AccountState))
                ) && 
                (
                    this.StoreNames == input.StoreNames ||
                    this.StoreNames != null &&
                    this.StoreNames.SequenceEqual(input.StoreNames)
                ) && 
                (
                    this.BankAddress == input.BankAddress ||
                    (this.BankAddress != null &&
                    this.BankAddress.Equals(input.BankAddress))
                ) && 
                (
                    this.BankCountryCode == input.BankCountryCode ||
                    (this.BankCountryCode != null &&
                    this.BankCountryCode.Equals(input.BankCountryCode))
                ) && 
                (
                    this.AccountHolderAddress == input.AccountHolderAddress ||
                    (this.AccountHolderAddress != null &&
                    this.AccountHolderAddress.Equals(input.AccountHolderAddress))
                ) && 
                (
                    this.AccountHolderCountryCode == input.AccountHolderCountryCode ||
                    (this.AccountHolderCountryCode != null &&
                    this.AccountHolderCountryCode.Equals(input.AccountHolderCountryCode))
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.Swift != null)
                    hashCode = hashCode * 59 + this.Swift.GetHashCode();
                if (this.PopulatedAccountFields != null)
                    hashCode = hashCode * 59 + this.PopulatedAccountFields.GetHashCode();
                if (this.AccountState != null)
                    hashCode = hashCode * 59 + this.AccountState.GetHashCode();
                if (this.StoreNames != null)
                    hashCode = hashCode * 59 + this.StoreNames.GetHashCode();
                if (this.BankAddress != null)
                    hashCode = hashCode * 59 + this.BankAddress.GetHashCode();
                if (this.BankCountryCode != null)
                    hashCode = hashCode * 59 + this.BankCountryCode.GetHashCode();
                if (this.AccountHolderAddress != null)
                    hashCode = hashCode * 59 + this.AccountHolderAddress.GetHashCode();
                if (this.AccountHolderCountryCode != null)
                    hashCode = hashCode * 59 + this.AccountHolderCountryCode.GetHashCode();
                if (this.VatNumber != null)
                    hashCode = hashCode * 59 + this.VatNumber.GetHashCode();
                return hashCode;
            }
        }
    }

}
