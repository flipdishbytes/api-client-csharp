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
    /// PayoutReport3DetailsRevenue
    /// </summary>
    [DataContract]
    public partial class PayoutReport3DetailsRevenue :  IEquatable<PayoutReport3DetailsRevenue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutReport3DetailsRevenue" /> class.
        /// </summary>
        /// <param name="grossSales">grossSales.</param>
        /// <param name="salesTax">salesTax.</param>
        /// <param name="deliveryCharges">deliveryCharges.</param>
        /// <param name="otherCharges">otherCharges.</param>
        /// <param name="tips">tips.</param>
        /// <param name="totalRevenue">totalRevenue.</param>
        /// <param name="revenueForFeeCalculations">revenueForFeeCalculations.</param>
        /// <param name="drsCharges">drsCharges.</param>
        public PayoutReport3DetailsRevenue(PayoutReport3DetailsSalesLine grossSales = default(PayoutReport3DetailsSalesLine), PayoutReport3DetailsSalesLine salesTax = default(PayoutReport3DetailsSalesLine), PayoutReport3DetailsSalesLine deliveryCharges = default(PayoutReport3DetailsSalesLine), PayoutReport3DetailsSalesLine otherCharges = default(PayoutReport3DetailsSalesLine), PayoutReport3DetailsSalesLine tips = default(PayoutReport3DetailsSalesLine), PayoutReport3DetailsSalesLine totalRevenue = default(PayoutReport3DetailsSalesLine), PayoutReport3DetailsSalesLine revenueForFeeCalculations = default(PayoutReport3DetailsSalesLine), PayoutReport3DetailsSalesLine drsCharges = default(PayoutReport3DetailsSalesLine))
        {
            this.GrossSales = grossSales;
            this.SalesTax = salesTax;
            this.DeliveryCharges = deliveryCharges;
            this.OtherCharges = otherCharges;
            this.Tips = tips;
            this.TotalRevenue = totalRevenue;
            this.RevenueForFeeCalculations = revenueForFeeCalculations;
            this.DrsCharges = drsCharges;
        }
        
        /// <summary>
        /// Gets or Sets GrossSales
        /// </summary>
        [DataMember(Name="GrossSales", EmitDefaultValue=false)]
        public PayoutReport3DetailsSalesLine GrossSales { get; set; }

        /// <summary>
        /// Gets or Sets SalesTax
        /// </summary>
        [DataMember(Name="SalesTax", EmitDefaultValue=false)]
        public PayoutReport3DetailsSalesLine SalesTax { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryCharges
        /// </summary>
        [DataMember(Name="DeliveryCharges", EmitDefaultValue=false)]
        public PayoutReport3DetailsSalesLine DeliveryCharges { get; set; }

        /// <summary>
        /// Gets or Sets OtherCharges
        /// </summary>
        [DataMember(Name="OtherCharges", EmitDefaultValue=false)]
        public PayoutReport3DetailsSalesLine OtherCharges { get; set; }

        /// <summary>
        /// Gets or Sets Tips
        /// </summary>
        [DataMember(Name="Tips", EmitDefaultValue=false)]
        public PayoutReport3DetailsSalesLine Tips { get; set; }

        /// <summary>
        /// Gets or Sets TotalRevenue
        /// </summary>
        [DataMember(Name="TotalRevenue", EmitDefaultValue=false)]
        public PayoutReport3DetailsSalesLine TotalRevenue { get; set; }

        /// <summary>
        /// Gets or Sets RevenueForFeeCalculations
        /// </summary>
        [DataMember(Name="RevenueForFeeCalculations", EmitDefaultValue=false)]
        public PayoutReport3DetailsSalesLine RevenueForFeeCalculations { get; set; }

        /// <summary>
        /// Gets or Sets DrsCharges
        /// </summary>
        [DataMember(Name="DrsCharges", EmitDefaultValue=false)]
        public PayoutReport3DetailsSalesLine DrsCharges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutReport3DetailsRevenue {\n");
            sb.Append("  GrossSales: ").Append(GrossSales).Append("\n");
            sb.Append("  SalesTax: ").Append(SalesTax).Append("\n");
            sb.Append("  DeliveryCharges: ").Append(DeliveryCharges).Append("\n");
            sb.Append("  OtherCharges: ").Append(OtherCharges).Append("\n");
            sb.Append("  Tips: ").Append(Tips).Append("\n");
            sb.Append("  TotalRevenue: ").Append(TotalRevenue).Append("\n");
            sb.Append("  RevenueForFeeCalculations: ").Append(RevenueForFeeCalculations).Append("\n");
            sb.Append("  DrsCharges: ").Append(DrsCharges).Append("\n");
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
            return this.Equals(input as PayoutReport3DetailsRevenue);
        }

        /// <summary>
        /// Returns true if PayoutReport3DetailsRevenue instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutReport3DetailsRevenue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutReport3DetailsRevenue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GrossSales == input.GrossSales ||
                    (this.GrossSales != null &&
                    this.GrossSales.Equals(input.GrossSales))
                ) && 
                (
                    this.SalesTax == input.SalesTax ||
                    (this.SalesTax != null &&
                    this.SalesTax.Equals(input.SalesTax))
                ) && 
                (
                    this.DeliveryCharges == input.DeliveryCharges ||
                    (this.DeliveryCharges != null &&
                    this.DeliveryCharges.Equals(input.DeliveryCharges))
                ) && 
                (
                    this.OtherCharges == input.OtherCharges ||
                    (this.OtherCharges != null &&
                    this.OtherCharges.Equals(input.OtherCharges))
                ) && 
                (
                    this.Tips == input.Tips ||
                    (this.Tips != null &&
                    this.Tips.Equals(input.Tips))
                ) && 
                (
                    this.TotalRevenue == input.TotalRevenue ||
                    (this.TotalRevenue != null &&
                    this.TotalRevenue.Equals(input.TotalRevenue))
                ) && 
                (
                    this.RevenueForFeeCalculations == input.RevenueForFeeCalculations ||
                    (this.RevenueForFeeCalculations != null &&
                    this.RevenueForFeeCalculations.Equals(input.RevenueForFeeCalculations))
                ) && 
                (
                    this.DrsCharges == input.DrsCharges ||
                    (this.DrsCharges != null &&
                    this.DrsCharges.Equals(input.DrsCharges))
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
                if (this.GrossSales != null)
                    hashCode = hashCode * 59 + this.GrossSales.GetHashCode();
                if (this.SalesTax != null)
                    hashCode = hashCode * 59 + this.SalesTax.GetHashCode();
                if (this.DeliveryCharges != null)
                    hashCode = hashCode * 59 + this.DeliveryCharges.GetHashCode();
                if (this.OtherCharges != null)
                    hashCode = hashCode * 59 + this.OtherCharges.GetHashCode();
                if (this.Tips != null)
                    hashCode = hashCode * 59 + this.Tips.GetHashCode();
                if (this.TotalRevenue != null)
                    hashCode = hashCode * 59 + this.TotalRevenue.GetHashCode();
                if (this.RevenueForFeeCalculations != null)
                    hashCode = hashCode * 59 + this.RevenueForFeeCalculations.GetHashCode();
                if (this.DrsCharges != null)
                    hashCode = hashCode * 59 + this.DrsCharges.GetHashCode();
                return hashCode;
            }
        }
    }

}
