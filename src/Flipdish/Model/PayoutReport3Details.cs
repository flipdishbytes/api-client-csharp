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
    /// PayoutReport3Details
    /// </summary>
    [DataContract]
    public partial class PayoutReport3Details :  IEquatable<PayoutReport3Details>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutReport3Details" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="summary">summary.</param>
        /// <param name="revenue">revenue.</param>
        /// <param name="flipdishFees">flipdishFees.</param>
        /// <param name="adjustments">adjustments.</param>
        public PayoutReport3Details(double? amount = default(double?), PayoutReport3DetailsSummary summary = default(PayoutReport3DetailsSummary), PayoutReport3DetailsRevenue revenue = default(PayoutReport3DetailsRevenue), PayoutReport3DetailsFlipdishFees flipdishFees = default(PayoutReport3DetailsFlipdishFees), PayoutReport3DetailsAdjustments adjustments = default(PayoutReport3DetailsAdjustments))
        {
            this.Amount = amount;
            this.Summary = summary;
            this.Revenue = revenue;
            this.FlipdishFees = flipdishFees;
            this.Adjustments = adjustments;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="Summary", EmitDefaultValue=false)]
        public PayoutReport3DetailsSummary Summary { get; set; }

        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name="Revenue", EmitDefaultValue=false)]
        public PayoutReport3DetailsRevenue Revenue { get; set; }

        /// <summary>
        /// Gets or Sets FlipdishFees
        /// </summary>
        [DataMember(Name="FlipdishFees", EmitDefaultValue=false)]
        public PayoutReport3DetailsFlipdishFees FlipdishFees { get; set; }

        /// <summary>
        /// Gets or Sets Adjustments
        /// </summary>
        [DataMember(Name="Adjustments", EmitDefaultValue=false)]
        public PayoutReport3DetailsAdjustments Adjustments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutReport3Details {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  FlipdishFees: ").Append(FlipdishFees).Append("\n");
            sb.Append("  Adjustments: ").Append(Adjustments).Append("\n");
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
            return this.Equals(input as PayoutReport3Details);
        }

        /// <summary>
        /// Returns true if PayoutReport3Details instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutReport3Details to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutReport3Details input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Revenue == input.Revenue ||
                    (this.Revenue != null &&
                    this.Revenue.Equals(input.Revenue))
                ) && 
                (
                    this.FlipdishFees == input.FlipdishFees ||
                    (this.FlipdishFees != null &&
                    this.FlipdishFees.Equals(input.FlipdishFees))
                ) && 
                (
                    this.Adjustments == input.Adjustments ||
                    (this.Adjustments != null &&
                    this.Adjustments.Equals(input.Adjustments))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Revenue != null)
                    hashCode = hashCode * 59 + this.Revenue.GetHashCode();
                if (this.FlipdishFees != null)
                    hashCode = hashCode * 59 + this.FlipdishFees.GetHashCode();
                if (this.Adjustments != null)
                    hashCode = hashCode * 59 + this.Adjustments.GetHashCode();
                return hashCode;
            }
        }
    }

}
