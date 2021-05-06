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
    /// Fees breakdown
    /// </summary>
    [DataContract]
    public partial class FlipdishFeesDetails :  IEquatable<FlipdishFeesDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlipdishFeesDetails" /> class.
        /// </summary>
        /// <param name="onlineSalesFees">Fees on online sales.</param>
        /// <param name="cashSalesFees">Fees on cash sales.</param>
        /// <param name="totalSalesFees">Total online and cash sales.</param>
        /// <param name="onlineSalesRefundedFees">Fees on refunds for online sales.</param>
        /// <param name="cashSalesRefundedFees">Fees on refunds for cash sales.</param>
        /// <param name="salesFeesVat">VAT on sales fees.</param>
        /// <param name="totalFees">Total fees.</param>
        public FlipdishFeesDetails(double? onlineSalesFees = default(double?), double? cashSalesFees = default(double?), double? totalSalesFees = default(double?), double? onlineSalesRefundedFees = default(double?), double? cashSalesRefundedFees = default(double?), double? salesFeesVat = default(double?), double? totalFees = default(double?))
        {
            this.OnlineSalesFees = onlineSalesFees;
            this.CashSalesFees = cashSalesFees;
            this.TotalSalesFees = totalSalesFees;
            this.OnlineSalesRefundedFees = onlineSalesRefundedFees;
            this.CashSalesRefundedFees = cashSalesRefundedFees;
            this.SalesFeesVat = salesFeesVat;
            this.TotalFees = totalFees;
        }
        
        /// <summary>
        /// Fees on online sales
        /// </summary>
        /// <value>Fees on online sales</value>
        [DataMember(Name="OnlineSalesFees", EmitDefaultValue=false)]
        public double? OnlineSalesFees { get; set; }

        /// <summary>
        /// Fees on cash sales
        /// </summary>
        /// <value>Fees on cash sales</value>
        [DataMember(Name="CashSalesFees", EmitDefaultValue=false)]
        public double? CashSalesFees { get; set; }

        /// <summary>
        /// Total online and cash sales
        /// </summary>
        /// <value>Total online and cash sales</value>
        [DataMember(Name="TotalSalesFees", EmitDefaultValue=false)]
        public double? TotalSalesFees { get; set; }

        /// <summary>
        /// Fees on refunds for online sales
        /// </summary>
        /// <value>Fees on refunds for online sales</value>
        [DataMember(Name="OnlineSalesRefundedFees", EmitDefaultValue=false)]
        public double? OnlineSalesRefundedFees { get; set; }

        /// <summary>
        /// Fees on refunds for cash sales
        /// </summary>
        /// <value>Fees on refunds for cash sales</value>
        [DataMember(Name="CashSalesRefundedFees", EmitDefaultValue=false)]
        public double? CashSalesRefundedFees { get; set; }

        /// <summary>
        /// VAT on sales fees
        /// </summary>
        /// <value>VAT on sales fees</value>
        [DataMember(Name="SalesFeesVat", EmitDefaultValue=false)]
        public double? SalesFeesVat { get; set; }

        /// <summary>
        /// Total fees
        /// </summary>
        /// <value>Total fees</value>
        [DataMember(Name="TotalFees", EmitDefaultValue=false)]
        public double? TotalFees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlipdishFeesDetails {\n");
            sb.Append("  OnlineSalesFees: ").Append(OnlineSalesFees).Append("\n");
            sb.Append("  CashSalesFees: ").Append(CashSalesFees).Append("\n");
            sb.Append("  TotalSalesFees: ").Append(TotalSalesFees).Append("\n");
            sb.Append("  OnlineSalesRefundedFees: ").Append(OnlineSalesRefundedFees).Append("\n");
            sb.Append("  CashSalesRefundedFees: ").Append(CashSalesRefundedFees).Append("\n");
            sb.Append("  SalesFeesVat: ").Append(SalesFeesVat).Append("\n");
            sb.Append("  TotalFees: ").Append(TotalFees).Append("\n");
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
            return this.Equals(input as FlipdishFeesDetails);
        }

        /// <summary>
        /// Returns true if FlipdishFeesDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of FlipdishFeesDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlipdishFeesDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OnlineSalesFees == input.OnlineSalesFees ||
                    (this.OnlineSalesFees != null &&
                    this.OnlineSalesFees.Equals(input.OnlineSalesFees))
                ) && 
                (
                    this.CashSalesFees == input.CashSalesFees ||
                    (this.CashSalesFees != null &&
                    this.CashSalesFees.Equals(input.CashSalesFees))
                ) && 
                (
                    this.TotalSalesFees == input.TotalSalesFees ||
                    (this.TotalSalesFees != null &&
                    this.TotalSalesFees.Equals(input.TotalSalesFees))
                ) && 
                (
                    this.OnlineSalesRefundedFees == input.OnlineSalesRefundedFees ||
                    (this.OnlineSalesRefundedFees != null &&
                    this.OnlineSalesRefundedFees.Equals(input.OnlineSalesRefundedFees))
                ) && 
                (
                    this.CashSalesRefundedFees == input.CashSalesRefundedFees ||
                    (this.CashSalesRefundedFees != null &&
                    this.CashSalesRefundedFees.Equals(input.CashSalesRefundedFees))
                ) && 
                (
                    this.SalesFeesVat == input.SalesFeesVat ||
                    (this.SalesFeesVat != null &&
                    this.SalesFeesVat.Equals(input.SalesFeesVat))
                ) && 
                (
                    this.TotalFees == input.TotalFees ||
                    (this.TotalFees != null &&
                    this.TotalFees.Equals(input.TotalFees))
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
                if (this.OnlineSalesFees != null)
                    hashCode = hashCode * 59 + this.OnlineSalesFees.GetHashCode();
                if (this.CashSalesFees != null)
                    hashCode = hashCode * 59 + this.CashSalesFees.GetHashCode();
                if (this.TotalSalesFees != null)
                    hashCode = hashCode * 59 + this.TotalSalesFees.GetHashCode();
                if (this.OnlineSalesRefundedFees != null)
                    hashCode = hashCode * 59 + this.OnlineSalesRefundedFees.GetHashCode();
                if (this.CashSalesRefundedFees != null)
                    hashCode = hashCode * 59 + this.CashSalesRefundedFees.GetHashCode();
                if (this.SalesFeesVat != null)
                    hashCode = hashCode * 59 + this.SalesFeesVat.GetHashCode();
                if (this.TotalFees != null)
                    hashCode = hashCode * 59 + this.TotalFees.GetHashCode();
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
