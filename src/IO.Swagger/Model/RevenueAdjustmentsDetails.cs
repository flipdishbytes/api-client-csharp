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
    /// Revenue Adjustments breakdown
    /// </summary>
    [DataContract]
    public partial class RevenueAdjustmentsDetails :  IEquatable<RevenueAdjustmentsDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueAdjustmentsDetails" /> class.
        /// </summary>
        /// <param name="onlineSalesRefundedAmount">Online sales refunds.</param>
        /// <param name="cashSalesRefundedAmount">Cash sales refunds.</param>
        /// <param name="customerCashFees">Customer cash fees.</param>
        /// <param name="refundsCount">Number of refunds.</param>
        /// <param name="totalOnlineRevenueAdjustments">Total revenue adjustments.</param>
        public RevenueAdjustmentsDetails(double? onlineSalesRefundedAmount = default(double?), double? cashSalesRefundedAmount = default(double?), double? customerCashFees = default(double?), int? refundsCount = default(int?), double? totalOnlineRevenueAdjustments = default(double?))
        {
            this.OnlineSalesRefundedAmount = onlineSalesRefundedAmount;
            this.CashSalesRefundedAmount = cashSalesRefundedAmount;
            this.CustomerCashFees = customerCashFees;
            this.RefundsCount = refundsCount;
            this.TotalOnlineRevenueAdjustments = totalOnlineRevenueAdjustments;
        }
        
        /// <summary>
        /// Online sales refunds
        /// </summary>
        /// <value>Online sales refunds</value>
        [DataMember(Name="OnlineSalesRefundedAmount", EmitDefaultValue=false)]
        public double? OnlineSalesRefundedAmount { get; set; }

        /// <summary>
        /// Cash sales refunds
        /// </summary>
        /// <value>Cash sales refunds</value>
        [DataMember(Name="CashSalesRefundedAmount", EmitDefaultValue=false)]
        public double? CashSalesRefundedAmount { get; set; }

        /// <summary>
        /// Customer cash fees
        /// </summary>
        /// <value>Customer cash fees</value>
        [DataMember(Name="CustomerCashFees", EmitDefaultValue=false)]
        public double? CustomerCashFees { get; set; }

        /// <summary>
        /// Number of refunds
        /// </summary>
        /// <value>Number of refunds</value>
        [DataMember(Name="RefundsCount", EmitDefaultValue=false)]
        public int? RefundsCount { get; set; }

        /// <summary>
        /// Total revenue adjustments
        /// </summary>
        /// <value>Total revenue adjustments</value>
        [DataMember(Name="TotalOnlineRevenueAdjustments", EmitDefaultValue=false)]
        public double? TotalOnlineRevenueAdjustments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RevenueAdjustmentsDetails {\n");
            sb.Append("  OnlineSalesRefundedAmount: ").Append(OnlineSalesRefundedAmount).Append("\n");
            sb.Append("  CashSalesRefundedAmount: ").Append(CashSalesRefundedAmount).Append("\n");
            sb.Append("  CustomerCashFees: ").Append(CustomerCashFees).Append("\n");
            sb.Append("  RefundsCount: ").Append(RefundsCount).Append("\n");
            sb.Append("  TotalOnlineRevenueAdjustments: ").Append(TotalOnlineRevenueAdjustments).Append("\n");
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
            return this.Equals(input as RevenueAdjustmentsDetails);
        }

        /// <summary>
        /// Returns true if RevenueAdjustmentsDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of RevenueAdjustmentsDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RevenueAdjustmentsDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OnlineSalesRefundedAmount == input.OnlineSalesRefundedAmount ||
                    (this.OnlineSalesRefundedAmount != null &&
                    this.OnlineSalesRefundedAmount.Equals(input.OnlineSalesRefundedAmount))
                ) && 
                (
                    this.CashSalesRefundedAmount == input.CashSalesRefundedAmount ||
                    (this.CashSalesRefundedAmount != null &&
                    this.CashSalesRefundedAmount.Equals(input.CashSalesRefundedAmount))
                ) && 
                (
                    this.CustomerCashFees == input.CustomerCashFees ||
                    (this.CustomerCashFees != null &&
                    this.CustomerCashFees.Equals(input.CustomerCashFees))
                ) && 
                (
                    this.RefundsCount == input.RefundsCount ||
                    (this.RefundsCount != null &&
                    this.RefundsCount.Equals(input.RefundsCount))
                ) && 
                (
                    this.TotalOnlineRevenueAdjustments == input.TotalOnlineRevenueAdjustments ||
                    (this.TotalOnlineRevenueAdjustments != null &&
                    this.TotalOnlineRevenueAdjustments.Equals(input.TotalOnlineRevenueAdjustments))
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
                if (this.OnlineSalesRefundedAmount != null)
                    hashCode = hashCode * 59 + this.OnlineSalesRefundedAmount.GetHashCode();
                if (this.CashSalesRefundedAmount != null)
                    hashCode = hashCode * 59 + this.CashSalesRefundedAmount.GetHashCode();
                if (this.CustomerCashFees != null)
                    hashCode = hashCode * 59 + this.CustomerCashFees.GetHashCode();
                if (this.RefundsCount != null)
                    hashCode = hashCode * 59 + this.RefundsCount.GetHashCode();
                if (this.TotalOnlineRevenueAdjustments != null)
                    hashCode = hashCode * 59 + this.TotalOnlineRevenueAdjustments.GetHashCode();
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
