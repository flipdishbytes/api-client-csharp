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
using SwaggerDateConverter = Flipdish.Client.SwaggerDateConverter;

namespace Flipdish.Model
{
    /// <summary>
    /// Represents a Stripe custom connected account
    /// </summary>
    [DataContract]
    public partial class StripeConnectedAccount :  IEquatable<StripeConnectedAccount>, IValidatableObject
    {
        /// <summary>
        /// Card payments capability status (Inactive, Pending, Active, Unrequested)
        /// </summary>
        /// <value>Card payments capability status (Inactive, Pending, Active, Unrequested)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardPaymentsStatusEnum
        {
            
            /// <summary>
            /// Enum Inactive for value: Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive = 1,
            
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 2,
            
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 3,
            
            /// <summary>
            /// Enum Unrequested for value: Unrequested
            /// </summary>
            [EnumMember(Value = "Unrequested")]
            Unrequested = 4
        }

        /// <summary>
        /// Card payments capability status (Inactive, Pending, Active, Unrequested)
        /// </summary>
        /// <value>Card payments capability status (Inactive, Pending, Active, Unrequested)</value>
        [DataMember(Name="CardPaymentsStatus", EmitDefaultValue=false)]
        public CardPaymentsStatusEnum? CardPaymentsStatus { get; set; }
        /// <summary>
        /// Transfers capability status (Inactive, Pending, Active, Unrequested)
        /// </summary>
        /// <value>Transfers capability status (Inactive, Pending, Active, Unrequested)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransfersStatusEnum
        {
            
            /// <summary>
            /// Enum Inactive for value: Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive = 1,
            
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 2,
            
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 3,
            
            /// <summary>
            /// Enum Unrequested for value: Unrequested
            /// </summary>
            [EnumMember(Value = "Unrequested")]
            Unrequested = 4
        }

        /// <summary>
        /// Transfers capability status (Inactive, Pending, Active, Unrequested)
        /// </summary>
        /// <value>Transfers capability status (Inactive, Pending, Active, Unrequested)</value>
        [DataMember(Name="TransfersStatus", EmitDefaultValue=false)]
        public TransfersStatusEnum? TransfersStatus { get; set; }
        /// <summary>
        /// Current status of the account
        /// </summary>
        /// <value>Current status of the account</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountStatusEnum
        {
            
            /// <summary>
            /// Enum Disabled for value: Disabled
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled = 1,
            
            /// <summary>
            /// Enum Enabled for value: Enabled
            /// </summary>
            [EnumMember(Value = "Enabled")]
            Enabled = 2,
            
            /// <summary>
            /// Enum AdditionalInformationRequired for value: AdditionalInformationRequired
            /// </summary>
            [EnumMember(Value = "AdditionalInformationRequired")]
            AdditionalInformationRequired = 3,
            
            /// <summary>
            /// Enum PendingVerification for value: PendingVerification
            /// </summary>
            [EnumMember(Value = "PendingVerification")]
            PendingVerification = 4,
            
            /// <summary>
            /// Enum Unverified for value: Unverified
            /// </summary>
            [EnumMember(Value = "Unverified")]
            Unverified = 5
        }

        /// <summary>
        /// Current status of the account
        /// </summary>
        /// <value>Current status of the account</value>
        [DataMember(Name="AccountStatus", EmitDefaultValue=false)]
        public AccountStatusEnum? AccountStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeConnectedAccount" /> class.
        /// </summary>
        /// <param name="flipdishConnectedAccountId">Flipdish connected account identifier.</param>
        /// <param name="stripeId">Stripe&#39;s own connected account identifier.</param>
        /// <param name="whitelabelConfigId">Id of the WhitelabelConfig the connected account is assigned to.</param>
        /// <param name="cardPaymentsStatus">Card payments capability status (Inactive, Pending, Active, Unrequested).</param>
        /// <param name="transfersStatus">Transfers capability status (Inactive, Pending, Active, Unrequested).</param>
        /// <param name="accountStatus">Current status of the account.</param>
        public StripeConnectedAccount(int? flipdishConnectedAccountId = default(int?), string stripeId = default(string), int? whitelabelConfigId = default(int?), CardPaymentsStatusEnum? cardPaymentsStatus = default(CardPaymentsStatusEnum?), TransfersStatusEnum? transfersStatus = default(TransfersStatusEnum?), AccountStatusEnum? accountStatus = default(AccountStatusEnum?))
        {
            this.FlipdishConnectedAccountId = flipdishConnectedAccountId;
            this.StripeId = stripeId;
            this.WhitelabelConfigId = whitelabelConfigId;
            this.CardPaymentsStatus = cardPaymentsStatus;
            this.TransfersStatus = transfersStatus;
            this.AccountStatus = accountStatus;
        }
        
        /// <summary>
        /// Flipdish connected account identifier
        /// </summary>
        /// <value>Flipdish connected account identifier</value>
        [DataMember(Name="FlipdishConnectedAccountId", EmitDefaultValue=false)]
        public int? FlipdishConnectedAccountId { get; set; }

        /// <summary>
        /// Stripe&#39;s own connected account identifier
        /// </summary>
        /// <value>Stripe&#39;s own connected account identifier</value>
        [DataMember(Name="StripeId", EmitDefaultValue=false)]
        public string StripeId { get; set; }

        /// <summary>
        /// Id of the WhitelabelConfig the connected account is assigned to
        /// </summary>
        /// <value>Id of the WhitelabelConfig the connected account is assigned to</value>
        [DataMember(Name="WhitelabelConfigId", EmitDefaultValue=false)]
        public int? WhitelabelConfigId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StripeConnectedAccount {\n");
            sb.Append("  FlipdishConnectedAccountId: ").Append(FlipdishConnectedAccountId).Append("\n");
            sb.Append("  StripeId: ").Append(StripeId).Append("\n");
            sb.Append("  WhitelabelConfigId: ").Append(WhitelabelConfigId).Append("\n");
            sb.Append("  CardPaymentsStatus: ").Append(CardPaymentsStatus).Append("\n");
            sb.Append("  TransfersStatus: ").Append(TransfersStatus).Append("\n");
            sb.Append("  AccountStatus: ").Append(AccountStatus).Append("\n");
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
            return this.Equals(input as StripeConnectedAccount);
        }

        /// <summary>
        /// Returns true if StripeConnectedAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of StripeConnectedAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripeConnectedAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlipdishConnectedAccountId == input.FlipdishConnectedAccountId ||
                    (this.FlipdishConnectedAccountId != null &&
                    this.FlipdishConnectedAccountId.Equals(input.FlipdishConnectedAccountId))
                ) && 
                (
                    this.StripeId == input.StripeId ||
                    (this.StripeId != null &&
                    this.StripeId.Equals(input.StripeId))
                ) && 
                (
                    this.WhitelabelConfigId == input.WhitelabelConfigId ||
                    (this.WhitelabelConfigId != null &&
                    this.WhitelabelConfigId.Equals(input.WhitelabelConfigId))
                ) && 
                (
                    this.CardPaymentsStatus == input.CardPaymentsStatus ||
                    (this.CardPaymentsStatus != null &&
                    this.CardPaymentsStatus.Equals(input.CardPaymentsStatus))
                ) && 
                (
                    this.TransfersStatus == input.TransfersStatus ||
                    (this.TransfersStatus != null &&
                    this.TransfersStatus.Equals(input.TransfersStatus))
                ) && 
                (
                    this.AccountStatus == input.AccountStatus ||
                    (this.AccountStatus != null &&
                    this.AccountStatus.Equals(input.AccountStatus))
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
                if (this.FlipdishConnectedAccountId != null)
                    hashCode = hashCode * 59 + this.FlipdishConnectedAccountId.GetHashCode();
                if (this.StripeId != null)
                    hashCode = hashCode * 59 + this.StripeId.GetHashCode();
                if (this.WhitelabelConfigId != null)
                    hashCode = hashCode * 59 + this.WhitelabelConfigId.GetHashCode();
                if (this.CardPaymentsStatus != null)
                    hashCode = hashCode * 59 + this.CardPaymentsStatus.GetHashCode();
                if (this.TransfersStatus != null)
                    hashCode = hashCode * 59 + this.TransfersStatus.GetHashCode();
                if (this.AccountStatus != null)
                    hashCode = hashCode * 59 + this.AccountStatus.GetHashCode();
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
