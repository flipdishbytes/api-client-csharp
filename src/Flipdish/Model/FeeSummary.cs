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
    /// FeeSummary
    /// </summary>
    [DataContract]
    public partial class FeeSummary :  IEquatable<FeeSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeSummary" /> class.
        /// </summary>
        /// <param name="FeeAmount">FeeAmount.</param>
        /// <param name="PercentageRate">PercentageRate.</param>
        /// <param name="PerTransactionFee">PerTransactionFee.</param>
        public FeeSummary(double? FeeAmount = default(double?), double? PercentageRate = default(double?), double? PerTransactionFee = default(double?))
        {
            this.FeeAmount = FeeAmount;
            this.PercentageRate = PercentageRate;
            this.PerTransactionFee = PerTransactionFee;
        }
        
        /// <summary>
        /// Gets or Sets FeeAmount
        /// </summary>
        [DataMember(Name="FeeAmount", EmitDefaultValue=false)]
        public double? FeeAmount { get; set; }

        /// <summary>
        /// Gets or Sets PercentageRate
        /// </summary>
        [DataMember(Name="PercentageRate", EmitDefaultValue=false)]
        public double? PercentageRate { get; set; }

        /// <summary>
        /// Gets or Sets PerTransactionFee
        /// </summary>
        [DataMember(Name="PerTransactionFee", EmitDefaultValue=false)]
        public double? PerTransactionFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeSummary {\n");
            sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
            sb.Append("  PercentageRate: ").Append(PercentageRate).Append("\n");
            sb.Append("  PerTransactionFee: ").Append(PerTransactionFee).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FeeSummary);
        }

        /// <summary>
        /// Returns true if FeeSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of FeeSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FeeAmount == other.FeeAmount ||
                    this.FeeAmount != null &&
                    this.FeeAmount.Equals(other.FeeAmount)
                ) && 
                (
                    this.PercentageRate == other.PercentageRate ||
                    this.PercentageRate != null &&
                    this.PercentageRate.Equals(other.PercentageRate)
                ) && 
                (
                    this.PerTransactionFee == other.PerTransactionFee ||
                    this.PerTransactionFee != null &&
                    this.PerTransactionFee.Equals(other.PerTransactionFee)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.FeeAmount != null)
                    hash = hash * 59 + this.FeeAmount.GetHashCode();
                if (this.PercentageRate != null)
                    hash = hash * 59 + this.PercentageRate.GetHashCode();
                if (this.PerTransactionFee != null)
                    hash = hash * 59 + this.PerTransactionFee.GetHashCode();
                return hash;
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
