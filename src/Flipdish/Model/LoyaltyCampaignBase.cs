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
    /// Loyalty campaign base
    /// </summary>
    [DataContract]
    public partial class LoyaltyCampaignBase :  IEquatable<LoyaltyCampaignBase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyCampaignBase" /> class.
        /// </summary>
        /// <param name="ordersBeforeReceivingVoucher">Number of orders customer needs to make, before receiving voucher.</param>
        /// <param name="percentDiscountAmount">Discount amount in percents.</param>
        /// <param name="maxDiscount">Maximum discount for percentage discounts.</param>
        /// <param name="roundingStrategy">Controls how the loyalty voucher&#39;s amount is rounded.</param>
        /// <param name="shouldIncludeOrdersWithLoyaltyVoucher">Controls whether we should include orders with loyalty vouchers in the campaign calculation.</param>
        /// <param name="voucherValidPeriodDays">Number of days for which the voucher will be valid..</param>
        /// <param name="includeDeliveryFee">Discount will include delivery fee.</param>
        /// <param name="autoApplyResultingVouchers">Automatically apply resulting vouchers.</param>
        /// <param name="includeExistingOrders">Campaign will apply to existing orders.</param>
        /// <param name="isEnabled">Is campaign enabled.</param>
        /// <param name="storeIds">Ids of stores this campaign applies to.</param>
        /// <param name="appId">The app that this campaign belongs to..</param>
        /// <param name="forceDiscount">Controls whether the voucher generated from this campaign will override discount exclusions.</param>
        public LoyaltyCampaignBase(int? ordersBeforeReceivingVoucher = default(int?), int? percentDiscountAmount = default(int?), double? maxDiscount = default(double?), int? roundingStrategy = default(int?), bool? shouldIncludeOrdersWithLoyaltyVoucher = default(bool?), int? voucherValidPeriodDays = default(int?), bool? includeDeliveryFee = default(bool?), bool? autoApplyResultingVouchers = default(bool?), bool? includeExistingOrders = default(bool?), bool? isEnabled = default(bool?), List<int?> storeIds = default(List<int?>), string appId = default(string), bool? forceDiscount = default(bool?))
        {
            this.OrdersBeforeReceivingVoucher = ordersBeforeReceivingVoucher;
            this.PercentDiscountAmount = percentDiscountAmount;
            this.MaxDiscount = maxDiscount;
            this.RoundingStrategy = roundingStrategy;
            this.ShouldIncludeOrdersWithLoyaltyVoucher = shouldIncludeOrdersWithLoyaltyVoucher;
            this.VoucherValidPeriodDays = voucherValidPeriodDays;
            this.IncludeDeliveryFee = includeDeliveryFee;
            this.AutoApplyResultingVouchers = autoApplyResultingVouchers;
            this.IncludeExistingOrders = includeExistingOrders;
            this.IsEnabled = isEnabled;
            this.StoreIds = storeIds;
            this.AppId = appId;
            this.ForceDiscount = forceDiscount;
        }
        
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
        /// Maximum discount for percentage discounts
        /// </summary>
        /// <value>Maximum discount for percentage discounts</value>
        [DataMember(Name="MaxDiscount", EmitDefaultValue=false)]
        public double? MaxDiscount { get; set; }

        /// <summary>
        /// Controls how the loyalty voucher&#39;s amount is rounded
        /// </summary>
        /// <value>Controls how the loyalty voucher&#39;s amount is rounded</value>
        [DataMember(Name="RoundingStrategy", EmitDefaultValue=false)]
        public int? RoundingStrategy { get; set; }

        /// <summary>
        /// Controls whether we should include orders with loyalty vouchers in the campaign calculation
        /// </summary>
        /// <value>Controls whether we should include orders with loyalty vouchers in the campaign calculation</value>
        [DataMember(Name="ShouldIncludeOrdersWithLoyaltyVoucher", EmitDefaultValue=false)]
        public bool? ShouldIncludeOrdersWithLoyaltyVoucher { get; set; }

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
        /// The app that this campaign belongs to.
        /// </summary>
        /// <value>The app that this campaign belongs to.</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Controls whether the voucher generated from this campaign will override discount exclusions
        /// </summary>
        /// <value>Controls whether the voucher generated from this campaign will override discount exclusions</value>
        [DataMember(Name="ForceDiscount", EmitDefaultValue=false)]
        public bool? ForceDiscount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyCampaignBase {\n");
            sb.Append("  OrdersBeforeReceivingVoucher: ").Append(OrdersBeforeReceivingVoucher).Append("\n");
            sb.Append("  PercentDiscountAmount: ").Append(PercentDiscountAmount).Append("\n");
            sb.Append("  MaxDiscount: ").Append(MaxDiscount).Append("\n");
            sb.Append("  RoundingStrategy: ").Append(RoundingStrategy).Append("\n");
            sb.Append("  ShouldIncludeOrdersWithLoyaltyVoucher: ").Append(ShouldIncludeOrdersWithLoyaltyVoucher).Append("\n");
            sb.Append("  VoucherValidPeriodDays: ").Append(VoucherValidPeriodDays).Append("\n");
            sb.Append("  IncludeDeliveryFee: ").Append(IncludeDeliveryFee).Append("\n");
            sb.Append("  AutoApplyResultingVouchers: ").Append(AutoApplyResultingVouchers).Append("\n");
            sb.Append("  IncludeExistingOrders: ").Append(IncludeExistingOrders).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  ForceDiscount: ").Append(ForceDiscount).Append("\n");
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
            return this.Equals(input as LoyaltyCampaignBase);
        }

        /// <summary>
        /// Returns true if LoyaltyCampaignBase instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyCampaignBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyCampaignBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrdersBeforeReceivingVoucher == input.OrdersBeforeReceivingVoucher ||
                    (this.OrdersBeforeReceivingVoucher != null &&
                    this.OrdersBeforeReceivingVoucher.Equals(input.OrdersBeforeReceivingVoucher))
                ) && 
                (
                    this.PercentDiscountAmount == input.PercentDiscountAmount ||
                    (this.PercentDiscountAmount != null &&
                    this.PercentDiscountAmount.Equals(input.PercentDiscountAmount))
                ) && 
                (
                    this.MaxDiscount == input.MaxDiscount ||
                    (this.MaxDiscount != null &&
                    this.MaxDiscount.Equals(input.MaxDiscount))
                ) && 
                (
                    this.RoundingStrategy == input.RoundingStrategy ||
                    (this.RoundingStrategy != null &&
                    this.RoundingStrategy.Equals(input.RoundingStrategy))
                ) && 
                (
                    this.ShouldIncludeOrdersWithLoyaltyVoucher == input.ShouldIncludeOrdersWithLoyaltyVoucher ||
                    (this.ShouldIncludeOrdersWithLoyaltyVoucher != null &&
                    this.ShouldIncludeOrdersWithLoyaltyVoucher.Equals(input.ShouldIncludeOrdersWithLoyaltyVoucher))
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
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.ForceDiscount == input.ForceDiscount ||
                    (this.ForceDiscount != null &&
                    this.ForceDiscount.Equals(input.ForceDiscount))
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
                if (this.OrdersBeforeReceivingVoucher != null)
                    hashCode = hashCode * 59 + this.OrdersBeforeReceivingVoucher.GetHashCode();
                if (this.PercentDiscountAmount != null)
                    hashCode = hashCode * 59 + this.PercentDiscountAmount.GetHashCode();
                if (this.MaxDiscount != null)
                    hashCode = hashCode * 59 + this.MaxDiscount.GetHashCode();
                if (this.RoundingStrategy != null)
                    hashCode = hashCode * 59 + this.RoundingStrategy.GetHashCode();
                if (this.ShouldIncludeOrdersWithLoyaltyVoucher != null)
                    hashCode = hashCode * 59 + this.ShouldIncludeOrdersWithLoyaltyVoucher.GetHashCode();
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.ForceDiscount != null)
                    hashCode = hashCode * 59 + this.ForceDiscount.GetHashCode();
                return hashCode;
            }
        }
    }

}
