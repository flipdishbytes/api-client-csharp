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
    /// Campaign statistics
    /// </summary>
    [DataContract]
    public partial class CampaignStatistics :  IEquatable<CampaignStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignStatistics" /> class.
        /// </summary>
        /// <param name="vouchersIssued">Number of issued vouchers.</param>
        /// <param name="vouchersRedeemed">Number of redeemed vouchers.</param>
        /// <param name="conversion">Conversion percentage of campaign (VouchersIssued / VouchersRedeemed).</param>
        /// <param name="salesGenerated">Sales generated by campaign (TotalAmount - FeeChargedToCustomer ie. the discounted sale value).</param>
        /// <param name="returnOfInvestment">Return of investment percentage of campaign (TotalAmount / DiscountAmount).</param>
        public CampaignStatistics(int? vouchersIssued = default(int?), int? vouchersRedeemed = default(int?), double? conversion = default(double?), double? salesGenerated = default(double?), double? returnOfInvestment = default(double?))
        {
            this.VouchersIssued = vouchersIssued;
            this.VouchersRedeemed = vouchersRedeemed;
            this.Conversion = conversion;
            this.SalesGenerated = salesGenerated;
            this.ReturnOfInvestment = returnOfInvestment;
        }
        
        /// <summary>
        /// Number of issued vouchers
        /// </summary>
        /// <value>Number of issued vouchers</value>
        [DataMember(Name="VouchersIssued", EmitDefaultValue=false)]
        public int? VouchersIssued { get; set; }

        /// <summary>
        /// Number of redeemed vouchers
        /// </summary>
        /// <value>Number of redeemed vouchers</value>
        [DataMember(Name="VouchersRedeemed", EmitDefaultValue=false)]
        public int? VouchersRedeemed { get; set; }

        /// <summary>
        /// Conversion percentage of campaign (VouchersIssued / VouchersRedeemed)
        /// </summary>
        /// <value>Conversion percentage of campaign (VouchersIssued / VouchersRedeemed)</value>
        [DataMember(Name="Conversion", EmitDefaultValue=false)]
        public double? Conversion { get; set; }

        /// <summary>
        /// Sales generated by campaign (TotalAmount - FeeChargedToCustomer ie. the discounted sale value)
        /// </summary>
        /// <value>Sales generated by campaign (TotalAmount - FeeChargedToCustomer ie. the discounted sale value)</value>
        [DataMember(Name="SalesGenerated", EmitDefaultValue=false)]
        public double? SalesGenerated { get; set; }

        /// <summary>
        /// Return of investment percentage of campaign (TotalAmount / DiscountAmount)
        /// </summary>
        /// <value>Return of investment percentage of campaign (TotalAmount / DiscountAmount)</value>
        [DataMember(Name="ReturnOfInvestment", EmitDefaultValue=false)]
        public double? ReturnOfInvestment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignStatistics {\n");
            sb.Append("  VouchersIssued: ").Append(VouchersIssued).Append("\n");
            sb.Append("  VouchersRedeemed: ").Append(VouchersRedeemed).Append("\n");
            sb.Append("  Conversion: ").Append(Conversion).Append("\n");
            sb.Append("  SalesGenerated: ").Append(SalesGenerated).Append("\n");
            sb.Append("  ReturnOfInvestment: ").Append(ReturnOfInvestment).Append("\n");
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
            return this.Equals(input as CampaignStatistics);
        }

        /// <summary>
        /// Returns true if CampaignStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VouchersIssued == input.VouchersIssued ||
                    (this.VouchersIssued != null &&
                    this.VouchersIssued.Equals(input.VouchersIssued))
                ) && 
                (
                    this.VouchersRedeemed == input.VouchersRedeemed ||
                    (this.VouchersRedeemed != null &&
                    this.VouchersRedeemed.Equals(input.VouchersRedeemed))
                ) && 
                (
                    this.Conversion == input.Conversion ||
                    (this.Conversion != null &&
                    this.Conversion.Equals(input.Conversion))
                ) && 
                (
                    this.SalesGenerated == input.SalesGenerated ||
                    (this.SalesGenerated != null &&
                    this.SalesGenerated.Equals(input.SalesGenerated))
                ) && 
                (
                    this.ReturnOfInvestment == input.ReturnOfInvestment ||
                    (this.ReturnOfInvestment != null &&
                    this.ReturnOfInvestment.Equals(input.ReturnOfInvestment))
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
                if (this.VouchersIssued != null)
                    hashCode = hashCode * 59 + this.VouchersIssued.GetHashCode();
                if (this.VouchersRedeemed != null)
                    hashCode = hashCode * 59 + this.VouchersRedeemed.GetHashCode();
                if (this.Conversion != null)
                    hashCode = hashCode * 59 + this.Conversion.GetHashCode();
                if (this.SalesGenerated != null)
                    hashCode = hashCode * 59 + this.SalesGenerated.GetHashCode();
                if (this.ReturnOfInvestment != null)
                    hashCode = hashCode * 59 + this.ReturnOfInvestment.GetHashCode();
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