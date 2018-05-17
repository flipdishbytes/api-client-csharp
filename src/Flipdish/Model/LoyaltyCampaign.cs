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
    /// The loyalty campaign
    /// </summary>
    [DataContract]
    public partial class LoyaltyCampaign :  IEquatable<LoyaltyCampaign>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyCampaign" /> class.
        /// </summary>
        /// <param name="From">Date and time of campaign beginning.</param>
        /// <param name="VoucherValidPeriodDays">Number of days for which the voucher will be valid..</param>
        /// <param name="IncludeDeliveryFee">Discount will include delivery fee.</param>
        /// <param name="OrdersBeforeReceivingVoucher">Number of orders customer needs to make, before receiving voucher.</param>
        /// <param name="PercentDiscountAmount">Discount amount in percents.</param>
        public LoyaltyCampaign(DateTime? From = default(DateTime?), int? VoucherValidPeriodDays = default(int?), bool? IncludeDeliveryFee = default(bool?), int? OrdersBeforeReceivingVoucher = default(int?), int? PercentDiscountAmount = default(int?))
        {
            this.From = From;
            this.VoucherValidPeriodDays = VoucherValidPeriodDays;
            this.IncludeDeliveryFee = IncludeDeliveryFee;
            this.OrdersBeforeReceivingVoucher = OrdersBeforeReceivingVoucher;
            this.PercentDiscountAmount = PercentDiscountAmount;
        }
        
        /// <summary>
        /// Date and time of campaign beginning
        /// </summary>
        /// <value>Date and time of campaign beginning</value>
        [DataMember(Name="From", EmitDefaultValue=false)]
        public DateTime? From { get; set; }

        /// <summary>
        /// Number of days for which the voucher will be valid.
        /// </summary>
        /// <value>Number of days for which the voucher will be valid.</value>
        [DataMember(Name="VoucherValidPeriodDays", EmitDefaultValue=false)]
        public int? VoucherValidPeriodDays { get; set; }

        /// <summary>
        /// Discount will include delivery fee
        /// </summary>
        /// <value>Discount will include delivery fee</value>
        [DataMember(Name="IncludeDeliveryFee", EmitDefaultValue=false)]
        public bool? IncludeDeliveryFee { get; set; }

        /// <summary>
        /// Number of orders customer needs to make, before receiving voucher
        /// </summary>
        /// <value>Number of orders customer needs to make, before receiving voucher</value>
        [DataMember(Name="OrdersBeforeReceivingVoucher", EmitDefaultValue=false)]
        public int? OrdersBeforeReceivingVoucher { get; set; }

        /// <summary>
        /// Discount amount in percents
        /// </summary>
        /// <value>Discount amount in percents</value>
        [DataMember(Name="PercentDiscountAmount", EmitDefaultValue=false)]
        public int? PercentDiscountAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyCampaign {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  VoucherValidPeriodDays: ").Append(VoucherValidPeriodDays).Append("\n");
            sb.Append("  IncludeDeliveryFee: ").Append(IncludeDeliveryFee).Append("\n");
            sb.Append("  OrdersBeforeReceivingVoucher: ").Append(OrdersBeforeReceivingVoucher).Append("\n");
            sb.Append("  PercentDiscountAmount: ").Append(PercentDiscountAmount).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoyaltyCampaign);
        }

        /// <summary>
        /// Returns true if LoyaltyCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyCampaign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.VoucherValidPeriodDays == input.VoucherValidPeriodDays ||
                    (this.VoucherValidPeriodDays != null &&
                    this.VoucherValidPeriodDays.Equals(input.VoucherValidPeriodDays))
                ) && 
                (
                    this.IncludeDeliveryFee == input.IncludeDeliveryFee ||
                    (this.IncludeDeliveryFee != null &&
                    this.IncludeDeliveryFee.Equals(input.IncludeDeliveryFee))
                ) && 
                (
                    this.OrdersBeforeReceivingVoucher == input.OrdersBeforeReceivingVoucher ||
                    (this.OrdersBeforeReceivingVoucher != null &&
                    this.OrdersBeforeReceivingVoucher.Equals(input.OrdersBeforeReceivingVoucher))
                ) && 
                (
                    this.PercentDiscountAmount == input.PercentDiscountAmount ||
                    (this.PercentDiscountAmount != null &&
                    this.PercentDiscountAmount.Equals(input.PercentDiscountAmount))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.VoucherValidPeriodDays != null)
                    hashCode = hashCode * 59 + this.VoucherValidPeriodDays.GetHashCode();
                if (this.IncludeDeliveryFee != null)
                    hashCode = hashCode * 59 + this.IncludeDeliveryFee.GetHashCode();
                if (this.OrdersBeforeReceivingVoucher != null)
                    hashCode = hashCode * 59 + this.OrdersBeforeReceivingVoucher.GetHashCode();
                if (this.PercentDiscountAmount != null)
                    hashCode = hashCode * 59 + this.PercentDiscountAmount.GetHashCode();
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
