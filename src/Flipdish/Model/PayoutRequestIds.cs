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
    /// Payout Request ids for filtering on Payouts
    /// </summary>
    [DataContract]
    public partial class PayoutRequestIds :  IEquatable<PayoutRequestIds>, IValidatableObject
    {
        /// <summary>
        /// Defines States
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatesEnum
        {
            
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 1,
            
            /// <summary>
            /// Enum InTransit for value: InTransit
            /// </summary>
            [EnumMember(Value = "InTransit")]
            InTransit = 2,
            
            /// <summary>
            /// Enum Paid for value: Paid
            /// </summary>
            [EnumMember(Value = "Paid")]
            Paid = 3,
            
            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 4,
            
            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled = 5
        }


        /// <summary>
        /// List of {Flipdish.PublicModels.V1.Payouts.PayoutStatus} so search for
        /// </summary>
        /// <value>List of {Flipdish.PublicModels.V1.Payouts.PayoutStatus} so search for</value>
        [DataMember(Name="States", EmitDefaultValue=false)]
        public List<StatesEnum> States { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutRequestIds" /> class.
        /// </summary>
        /// <param name="bankAccountIds">List of bank account ids to search for.</param>
        /// <param name="states">List of {Flipdish.PublicModels.V1.Payouts.PayoutStatus} so search for.</param>
        public PayoutRequestIds(List<int?> bankAccountIds = default(List<int?>), List<StatesEnum> states = default(List<StatesEnum>))
        {
            this.BankAccountIds = bankAccountIds;
            this.States = states;
        }
        
        /// <summary>
        /// List of bank account ids to search for
        /// </summary>
        /// <value>List of bank account ids to search for</value>
        [DataMember(Name="BankAccountIds", EmitDefaultValue=false)]
        public List<int?> BankAccountIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutRequestIds {\n");
            sb.Append("  BankAccountIds: ").Append(BankAccountIds).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
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
            return this.Equals(input as PayoutRequestIds);
        }

        /// <summary>
        /// Returns true if PayoutRequestIds instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutRequestIds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutRequestIds input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BankAccountIds == input.BankAccountIds ||
                    this.BankAccountIds != null &&
                    this.BankAccountIds.SequenceEqual(input.BankAccountIds)
                ) && 
                (
                    this.States == input.States ||
                    this.States != null &&
                    this.States.SequenceEqual(input.States)
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
                if (this.BankAccountIds != null)
                    hashCode = hashCode * 59 + this.BankAccountIds.GetHashCode();
                if (this.States != null)
                    hashCode = hashCode * 59 + this.States.GetHashCode();
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
