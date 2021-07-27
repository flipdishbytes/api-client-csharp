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
    /// Retention campaign base
    /// </summary>
    [DataContract]
    public partial class RetentionCampaignBase :  IEquatable<RetentionCampaignBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionCampaignBase" /> class.
        /// </summary>
        /// <param name="notifyCustomerAfterMinutes">Time in minutes, after which customer will receive retention voucher if he/she does not order.</param>
        /// <param name="percentDiscountAmount">Discount amount in percents.</param>
        /// <param name="lumpDiscountAmount">Discount amount in sum of money.</param>
        /// <param name="voucherValidPeriodDays">Number of days for which the voucher will be valid..</param>
        /// <param name="includeDeliveryFee">Discount will include delivery fee.</param>
        /// <param name="autoApplyResultingVouchers">Automatically apply resulting vouchers.</param>
        /// <param name="includeExistingOrders">Campaign will apply to existing orders.</param>
        /// <param name="isEnabled">Is campaign enabled.</param>
        /// <param name="storeIds">Ids of stores this campaign applies to.</param>
        public RetentionCampaignBase(int? notifyCustomerAfterMinutes = default(int?), int? percentDiscountAmount = default(int?), double? lumpDiscountAmount = default(double?), int? voucherValidPeriodDays = default(int?), bool? includeDeliveryFee = default(bool?), bool? autoApplyResultingVouchers = default(bool?), bool? includeExistingOrders = default(bool?), bool? isEnabled = default(bool?), List<int?> storeIds = default(List<int?>))
        {
            this.NotifyCustomerAfterMinutes = notifyCustomerAfterMinutes;
            this.PercentDiscountAmount = percentDiscountAmount;
            this.LumpDiscountAmount = lumpDiscountAmount;
            this.VoucherValidPeriodDays = voucherValidPeriodDays;
            this.IncludeDeliveryFee = includeDeliveryFee;
            this.AutoApplyResultingVouchers = autoApplyResultingVouchers;
            this.IncludeExistingOrders = includeExistingOrders;
            this.IsEnabled = isEnabled;
            this.StoreIds = storeIds;
        }
        
        /// <summary>
        /// Time in minutes, after which customer will receive retention voucher if he/she does not order
        /// </summary>
        /// <value>Time in minutes, after which customer will receive retention voucher if he/she does not order</value>
        [DataMember(Name="NotifyCustomerAfterMinutes", EmitDefaultValue=false)]
        public int? NotifyCustomerAfterMinutes { get; set; }

        /// <summary>
        /// Discount amount in percents
        /// </summary>
        /// <value>Discount amount in percents</value>
        [DataMember(Name="PercentDiscountAmount", EmitDefaultValue=false)]
        public int? PercentDiscountAmount { get; set; }

        /// <summary>
        /// Discount amount in sum of money
        /// </summary>
        /// <value>Discount amount in sum of money</value>
        [DataMember(Name="LumpDiscountAmount", EmitDefaultValue=false)]
        public double? LumpDiscountAmount { get; set; }

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
        /// Automatically apply resulting vouchers
        /// </summary>
        /// <value>Automatically apply resulting vouchers</value>
        [DataMember(Name="AutoApplyResultingVouchers", EmitDefaultValue=false)]
        public bool? AutoApplyResultingVouchers { get; set; }

        /// <summary>
        /// Campaign will apply to existing orders
        /// </summary>
        /// <value>Campaign will apply to existing orders</value>
        [DataMember(Name="IncludeExistingOrders", EmitDefaultValue=false)]
        public bool? IncludeExistingOrders { get; set; }

        /// <summary>
        /// Is campaign enabled
        /// </summary>
        /// <value>Is campaign enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Ids of stores this campaign applies to
        /// </summary>
        /// <value>Ids of stores this campaign applies to</value>
        [DataMember(Name="StoreIds", EmitDefaultValue=false)]
        public List<int?> StoreIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetentionCampaignBase {\n");
            sb.Append("  NotifyCustomerAfterMinutes: ").Append(NotifyCustomerAfterMinutes).Append("\n");
            sb.Append("  PercentDiscountAmount: ").Append(PercentDiscountAmount).Append("\n");
            sb.Append("  LumpDiscountAmount: ").Append(LumpDiscountAmount).Append("\n");
            sb.Append("  VoucherValidPeriodDays: ").Append(VoucherValidPeriodDays).Append("\n");
            sb.Append("  IncludeDeliveryFee: ").Append(IncludeDeliveryFee).Append("\n");
            sb.Append("  AutoApplyResultingVouchers: ").Append(AutoApplyResultingVouchers).Append("\n");
            sb.Append("  IncludeExistingOrders: ").Append(IncludeExistingOrders).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
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
            return this.Equals(input as RetentionCampaignBase);
        }

        /// <summary>
        /// Returns true if RetentionCampaignBase instances are equal
        /// </summary>
        /// <param name="input">Instance of RetentionCampaignBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetentionCampaignBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotifyCustomerAfterMinutes == input.NotifyCustomerAfterMinutes ||
                    (this.NotifyCustomerAfterMinutes != null &&
                    this.NotifyCustomerAfterMinutes.Equals(input.NotifyCustomerAfterMinutes))
                ) && 
                (
                    this.PercentDiscountAmount == input.PercentDiscountAmount ||
                    (this.PercentDiscountAmount != null &&
                    this.PercentDiscountAmount.Equals(input.PercentDiscountAmount))
                ) && 
                (
                    this.LumpDiscountAmount == input.LumpDiscountAmount ||
                    (this.LumpDiscountAmount != null &&
                    this.LumpDiscountAmount.Equals(input.LumpDiscountAmount))
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
                    this.AutoApplyResultingVouchers == input.AutoApplyResultingVouchers ||
                    (this.AutoApplyResultingVouchers != null &&
                    this.AutoApplyResultingVouchers.Equals(input.AutoApplyResultingVouchers))
                ) && 
                (
                    this.IncludeExistingOrders == input.IncludeExistingOrders ||
                    (this.IncludeExistingOrders != null &&
                    this.IncludeExistingOrders.Equals(input.IncludeExistingOrders))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
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
                if (this.NotifyCustomerAfterMinutes != null)
                    hashCode = hashCode * 59 + this.NotifyCustomerAfterMinutes.GetHashCode();
                if (this.PercentDiscountAmount != null)
                    hashCode = hashCode * 59 + this.PercentDiscountAmount.GetHashCode();
                if (this.LumpDiscountAmount != null)
                    hashCode = hashCode * 59 + this.LumpDiscountAmount.GetHashCode();
                if (this.VoucherValidPeriodDays != null)
                    hashCode = hashCode * 59 + this.VoucherValidPeriodDays.GetHashCode();
                if (this.IncludeDeliveryFee != null)
                    hashCode = hashCode * 59 + this.IncludeDeliveryFee.GetHashCode();
                if (this.AutoApplyResultingVouchers != null)
                    hashCode = hashCode * 59 + this.AutoApplyResultingVouchers.GetHashCode();
                if (this.IncludeExistingOrders != null)
                    hashCode = hashCode * 59 + this.IncludeExistingOrders.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.StoreIds != null)
                    hashCode = hashCode * 59 + this.StoreIds.GetHashCode();
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
            // NotifyCustomerAfterMinutes (int?) maximum
            if(this.NotifyCustomerAfterMinutes > (int?)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NotifyCustomerAfterMinutes, must be a value less than or equal to 2147483647.", new [] { "NotifyCustomerAfterMinutes" });
            }

            // NotifyCustomerAfterMinutes (int?) minimum
            if(this.NotifyCustomerAfterMinutes < (int?)1440)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NotifyCustomerAfterMinutes, must be a value greater than or equal to 1440.", new [] { "NotifyCustomerAfterMinutes" });
            }

            // PercentDiscountAmount (int?) maximum
            if(this.PercentDiscountAmount > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PercentDiscountAmount, must be a value less than or equal to 100.", new [] { "PercentDiscountAmount" });
            }

            // PercentDiscountAmount (int?) minimum
            if(this.PercentDiscountAmount < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PercentDiscountAmount, must be a value greater than or equal to 1.", new [] { "PercentDiscountAmount" });
            }

            // LumpDiscountAmount (double?) maximum
            if(this.LumpDiscountAmount > (double?)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LumpDiscountAmount, must be a value less than or equal to 2147483647.", new [] { "LumpDiscountAmount" });
            }

            // LumpDiscountAmount (double?) minimum
            if(this.LumpDiscountAmount < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LumpDiscountAmount, must be a value greater than or equal to 0.", new [] { "LumpDiscountAmount" });
            }

            // VoucherValidPeriodDays (int?) maximum
            if(this.VoucherValidPeriodDays > (int?)300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VoucherValidPeriodDays, must be a value less than or equal to 300.", new [] { "VoucherValidPeriodDays" });
            }

            // VoucherValidPeriodDays (int?) minimum
            if(this.VoucherValidPeriodDays < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VoucherValidPeriodDays, must be a value greater than or equal to 1.", new [] { "VoucherValidPeriodDays" });
            }

            yield break;
        }
    }

}
