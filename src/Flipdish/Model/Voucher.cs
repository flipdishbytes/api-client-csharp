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
    /// Voucher
    /// </summary>
    [DataContract]
    public partial class Voucher :  IEquatable<Voucher>, IValidatableObject
    {
        /// <summary>
        /// Voucher type
        /// </summary>
        /// <value>Voucher type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VoucherTypeEnum
        {
            
            /// <summary>
            /// Enum PercentageDiscount for value: PercentageDiscount
            /// </summary>
            [EnumMember(Value = "PercentageDiscount")]
            PercentageDiscount = 1,
            
            /// <summary>
            /// Enum LumpDiscount for value: LumpDiscount
            /// </summary>
            [EnumMember(Value = "LumpDiscount")]
            LumpDiscount = 2,
            
            /// <summary>
            /// Enum AddItem for value: AddItem
            /// </summary>
            [EnumMember(Value = "AddItem")]
            AddItem = 3,
            
            /// <summary>
            /// Enum CreditNote for value: CreditNote
            /// </summary>
            [EnumMember(Value = "CreditNote")]
            CreditNote = 4
        }

        /// <summary>
        /// Voucher type
        /// </summary>
        /// <value>Voucher type</value>
        [DataMember(Name="VoucherType", EmitDefaultValue=false)]
        public VoucherTypeEnum? VoucherType { get; set; }
        /// <summary>
        /// Voucher subtype
        /// </summary>
        /// <value>Voucher subtype</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VoucherSubTypeEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum SignUp for value: SignUp
            /// </summary>
            [EnumMember(Value = "SignUp")]
            SignUp = 2,
            
            /// <summary>
            /// Enum Loyalty for value: Loyalty
            /// </summary>
            [EnumMember(Value = "Loyalty")]
            Loyalty = 3,
            
            /// <summary>
            /// Enum Loyalty25 for value: Loyalty25
            /// </summary>
            [EnumMember(Value = "Loyalty25")]
            Loyalty25 = 4,
            
            /// <summary>
            /// Enum Retention for value: Retention
            /// </summary>
            [EnumMember(Value = "Retention")]
            Retention = 5,
            
            /// <summary>
            /// Enum SecondaryRetention for value: SecondaryRetention
            /// </summary>
            [EnumMember(Value = "SecondaryRetention")]
            SecondaryRetention = 6,
            
            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 7
        }

        /// <summary>
        /// Voucher subtype
        /// </summary>
        /// <value>Voucher subtype</value>
        [DataMember(Name="VoucherSubType", EmitDefaultValue=false)]
        public VoucherSubTypeEnum? VoucherSubType { get; set; }
        /// <summary>
        /// Define who foots the bill for the voucher
        /// </summary>
        /// <value>Define who foots the bill for the voucher</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VoucherPayerEnum
        {
            
            /// <summary>
            /// Enum Flipdish for value: Flipdish
            /// </summary>
            [EnumMember(Value = "Flipdish")]
            Flipdish = 1,
            
            /// <summary>
            /// Enum Store for value: Store
            /// </summary>
            [EnumMember(Value = "Store")]
            Store = 2
        }

        /// <summary>
        /// Define who foots the bill for the voucher
        /// </summary>
        /// <value>Define who foots the bill for the voucher</value>
        [DataMember(Name="VoucherPayer", EmitDefaultValue=false)]
        public VoucherPayerEnum? VoucherPayer { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Voucher" /> class.
        /// </summary>
        /// <param name="VoucherId">Voucher identifier.</param>
        /// <param name="VoucherType">Voucher type.</param>
        /// <param name="IsEnabled">Is voucher enabled.</param>
        /// <param name="IsUsedUp">Is voucher used up.</param>
        /// <param name="VoucherSubType">Voucher subtype.</param>
        /// <param name="PublicDescription">Public description.</param>
        /// <param name="PrivateDescription">Private description.</param>
        /// <param name="ValidFrom">Valid from.</param>
        /// <param name="Expiry">Expiry.</param>
        /// <param name="VoucherPayer">Define who foots the bill for the voucher.</param>
        /// <param name="IsVisibleToStore">Define whether we show the fact that a voucher was applied to the restaurant.</param>
        /// <param name="IsReusable">Is reusable.</param>
        /// <param name="IsValidForDeliveryOrders">Is valid for delivery orders.</param>
        /// <param name="IsValidForPickupOrders">Is valid for pickup orders.</param>
        /// <param name="IsValidForCardOrders">Is valid for card orders.</param>
        /// <param name="IsValidForCashOrders">Is valid for cash orders.</param>
        /// <param name="IsValidForFirstOrderOnly">Is valid for first order only.</param>
        /// <param name="MinimumOrderAmount">Minimum order amount..</param>
        /// <param name="IsValidOncePerCustomer">Is valid once per customer.</param>
        /// <param name="AutoApply">Auto apply.</param>
        /// <param name="AutoApplyOrder">Auto apply order.  Lower numbers get applied first..</param>
        /// <param name="IncludeDeliveryFee">Include delivery fee.</param>
        /// <param name="Code">Voucher code.</param>
        public Voucher(int? VoucherId = default(int?), VoucherTypeEnum? VoucherType = default(VoucherTypeEnum?), bool? IsEnabled = default(bool?), bool? IsUsedUp = default(bool?), VoucherSubTypeEnum? VoucherSubType = default(VoucherSubTypeEnum?), string PublicDescription = default(string), string PrivateDescription = default(string), DateTime? ValidFrom = default(DateTime?), DateTime? Expiry = default(DateTime?), VoucherPayerEnum? VoucherPayer = default(VoucherPayerEnum?), bool? IsVisibleToStore = default(bool?), bool? IsReusable = default(bool?), bool? IsValidForDeliveryOrders = default(bool?), bool? IsValidForPickupOrders = default(bool?), bool? IsValidForCardOrders = default(bool?), bool? IsValidForCashOrders = default(bool?), bool? IsValidForFirstOrderOnly = default(bool?), double? MinimumOrderAmount = default(double?), bool? IsValidOncePerCustomer = default(bool?), bool? AutoApply = default(bool?), int? AutoApplyOrder = default(int?), bool? IncludeDeliveryFee = default(bool?), string Code = default(string))
        {
            this.VoucherId = VoucherId;
            this.VoucherType = VoucherType;
            this.IsEnabled = IsEnabled;
            this.IsUsedUp = IsUsedUp;
            this.VoucherSubType = VoucherSubType;
            this.PublicDescription = PublicDescription;
            this.PrivateDescription = PrivateDescription;
            this.ValidFrom = ValidFrom;
            this.Expiry = Expiry;
            this.VoucherPayer = VoucherPayer;
            this.IsVisibleToStore = IsVisibleToStore;
            this.IsReusable = IsReusable;
            this.IsValidForDeliveryOrders = IsValidForDeliveryOrders;
            this.IsValidForPickupOrders = IsValidForPickupOrders;
            this.IsValidForCardOrders = IsValidForCardOrders;
            this.IsValidForCashOrders = IsValidForCashOrders;
            this.IsValidForFirstOrderOnly = IsValidForFirstOrderOnly;
            this.MinimumOrderAmount = MinimumOrderAmount;
            this.IsValidOncePerCustomer = IsValidOncePerCustomer;
            this.AutoApply = AutoApply;
            this.AutoApplyOrder = AutoApplyOrder;
            this.IncludeDeliveryFee = IncludeDeliveryFee;
            this.Code = Code;
        }
        
        /// <summary>
        /// Voucher identifier
        /// </summary>
        /// <value>Voucher identifier</value>
        [DataMember(Name="VoucherId", EmitDefaultValue=false)]
        public int? VoucherId { get; set; }


        /// <summary>
        /// Is voucher enabled
        /// </summary>
        /// <value>Is voucher enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Is voucher used up
        /// </summary>
        /// <value>Is voucher used up</value>
        [DataMember(Name="IsUsedUp", EmitDefaultValue=false)]
        public bool? IsUsedUp { get; set; }


        /// <summary>
        /// Public description
        /// </summary>
        /// <value>Public description</value>
        [DataMember(Name="PublicDescription", EmitDefaultValue=false)]
        public string PublicDescription { get; set; }

        /// <summary>
        /// Private description
        /// </summary>
        /// <value>Private description</value>
        [DataMember(Name="PrivateDescription", EmitDefaultValue=false)]
        public string PrivateDescription { get; set; }

        /// <summary>
        /// Valid from
        /// </summary>
        /// <value>Valid from</value>
        [DataMember(Name="ValidFrom", EmitDefaultValue=false)]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// Expiry
        /// </summary>
        /// <value>Expiry</value>
        [DataMember(Name="Expiry", EmitDefaultValue=false)]
        public DateTime? Expiry { get; set; }


        /// <summary>
        /// Define whether we show the fact that a voucher was applied to the restaurant
        /// </summary>
        /// <value>Define whether we show the fact that a voucher was applied to the restaurant</value>
        [DataMember(Name="IsVisibleToStore", EmitDefaultValue=false)]
        public bool? IsVisibleToStore { get; set; }

        /// <summary>
        /// Is reusable
        /// </summary>
        /// <value>Is reusable</value>
        [DataMember(Name="IsReusable", EmitDefaultValue=false)]
        public bool? IsReusable { get; set; }

        /// <summary>
        /// Is valid for delivery orders
        /// </summary>
        /// <value>Is valid for delivery orders</value>
        [DataMember(Name="IsValidForDeliveryOrders", EmitDefaultValue=false)]
        public bool? IsValidForDeliveryOrders { get; set; }

        /// <summary>
        /// Is valid for pickup orders
        /// </summary>
        /// <value>Is valid for pickup orders</value>
        [DataMember(Name="IsValidForPickupOrders", EmitDefaultValue=false)]
        public bool? IsValidForPickupOrders { get; set; }

        /// <summary>
        /// Is valid for card orders
        /// </summary>
        /// <value>Is valid for card orders</value>
        [DataMember(Name="IsValidForCardOrders", EmitDefaultValue=false)]
        public bool? IsValidForCardOrders { get; set; }

        /// <summary>
        /// Is valid for cash orders
        /// </summary>
        /// <value>Is valid for cash orders</value>
        [DataMember(Name="IsValidForCashOrders", EmitDefaultValue=false)]
        public bool? IsValidForCashOrders { get; set; }

        /// <summary>
        /// Is valid for first order only
        /// </summary>
        /// <value>Is valid for first order only</value>
        [DataMember(Name="IsValidForFirstOrderOnly", EmitDefaultValue=false)]
        public bool? IsValidForFirstOrderOnly { get; set; }

        /// <summary>
        /// Minimum order amount.
        /// </summary>
        /// <value>Minimum order amount.</value>
        [DataMember(Name="MinimumOrderAmount", EmitDefaultValue=false)]
        public double? MinimumOrderAmount { get; set; }

        /// <summary>
        /// Is valid once per customer
        /// </summary>
        /// <value>Is valid once per customer</value>
        [DataMember(Name="IsValidOncePerCustomer", EmitDefaultValue=false)]
        public bool? IsValidOncePerCustomer { get; set; }

        /// <summary>
        /// Auto apply
        /// </summary>
        /// <value>Auto apply</value>
        [DataMember(Name="AutoApply", EmitDefaultValue=false)]
        public bool? AutoApply { get; set; }

        /// <summary>
        /// Auto apply order.  Lower numbers get applied first.
        /// </summary>
        /// <value>Auto apply order.  Lower numbers get applied first.</value>
        [DataMember(Name="AutoApplyOrder", EmitDefaultValue=false)]
        public int? AutoApplyOrder { get; set; }

        /// <summary>
        /// Include delivery fee
        /// </summary>
        /// <value>Include delivery fee</value>
        [DataMember(Name="IncludeDeliveryFee", EmitDefaultValue=false)]
        public bool? IncludeDeliveryFee { get; set; }

        /// <summary>
        /// Voucher code
        /// </summary>
        /// <value>Voucher code</value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Voucher {\n");
            sb.Append("  VoucherId: ").Append(VoucherId).Append("\n");
            sb.Append("  VoucherType: ").Append(VoucherType).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsUsedUp: ").Append(IsUsedUp).Append("\n");
            sb.Append("  VoucherSubType: ").Append(VoucherSubType).Append("\n");
            sb.Append("  PublicDescription: ").Append(PublicDescription).Append("\n");
            sb.Append("  PrivateDescription: ").Append(PrivateDescription).Append("\n");
            sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
            sb.Append("  VoucherPayer: ").Append(VoucherPayer).Append("\n");
            sb.Append("  IsVisibleToStore: ").Append(IsVisibleToStore).Append("\n");
            sb.Append("  IsReusable: ").Append(IsReusable).Append("\n");
            sb.Append("  IsValidForDeliveryOrders: ").Append(IsValidForDeliveryOrders).Append("\n");
            sb.Append("  IsValidForPickupOrders: ").Append(IsValidForPickupOrders).Append("\n");
            sb.Append("  IsValidForCardOrders: ").Append(IsValidForCardOrders).Append("\n");
            sb.Append("  IsValidForCashOrders: ").Append(IsValidForCashOrders).Append("\n");
            sb.Append("  IsValidForFirstOrderOnly: ").Append(IsValidForFirstOrderOnly).Append("\n");
            sb.Append("  MinimumOrderAmount: ").Append(MinimumOrderAmount).Append("\n");
            sb.Append("  IsValidOncePerCustomer: ").Append(IsValidOncePerCustomer).Append("\n");
            sb.Append("  AutoApply: ").Append(AutoApply).Append("\n");
            sb.Append("  AutoApplyOrder: ").Append(AutoApplyOrder).Append("\n");
            sb.Append("  IncludeDeliveryFee: ").Append(IncludeDeliveryFee).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as Voucher);
        }

        /// <summary>
        /// Returns true if Voucher instances are equal
        /// </summary>
        /// <param name="input">Instance of Voucher to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Voucher input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VoucherId == input.VoucherId ||
                    (this.VoucherId != null &&
                    this.VoucherId.Equals(input.VoucherId))
                ) && 
                (
                    this.VoucherType == input.VoucherType ||
                    (this.VoucherType != null &&
                    this.VoucherType.Equals(input.VoucherType))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.IsUsedUp == input.IsUsedUp ||
                    (this.IsUsedUp != null &&
                    this.IsUsedUp.Equals(input.IsUsedUp))
                ) && 
                (
                    this.VoucherSubType == input.VoucherSubType ||
                    (this.VoucherSubType != null &&
                    this.VoucherSubType.Equals(input.VoucherSubType))
                ) && 
                (
                    this.PublicDescription == input.PublicDescription ||
                    (this.PublicDescription != null &&
                    this.PublicDescription.Equals(input.PublicDescription))
                ) && 
                (
                    this.PrivateDescription == input.PrivateDescription ||
                    (this.PrivateDescription != null &&
                    this.PrivateDescription.Equals(input.PrivateDescription))
                ) && 
                (
                    this.ValidFrom == input.ValidFrom ||
                    (this.ValidFrom != null &&
                    this.ValidFrom.Equals(input.ValidFrom))
                ) && 
                (
                    this.Expiry == input.Expiry ||
                    (this.Expiry != null &&
                    this.Expiry.Equals(input.Expiry))
                ) && 
                (
                    this.VoucherPayer == input.VoucherPayer ||
                    (this.VoucherPayer != null &&
                    this.VoucherPayer.Equals(input.VoucherPayer))
                ) && 
                (
                    this.IsVisibleToStore == input.IsVisibleToStore ||
                    (this.IsVisibleToStore != null &&
                    this.IsVisibleToStore.Equals(input.IsVisibleToStore))
                ) && 
                (
                    this.IsReusable == input.IsReusable ||
                    (this.IsReusable != null &&
                    this.IsReusable.Equals(input.IsReusable))
                ) && 
                (
                    this.IsValidForDeliveryOrders == input.IsValidForDeliveryOrders ||
                    (this.IsValidForDeliveryOrders != null &&
                    this.IsValidForDeliveryOrders.Equals(input.IsValidForDeliveryOrders))
                ) && 
                (
                    this.IsValidForPickupOrders == input.IsValidForPickupOrders ||
                    (this.IsValidForPickupOrders != null &&
                    this.IsValidForPickupOrders.Equals(input.IsValidForPickupOrders))
                ) && 
                (
                    this.IsValidForCardOrders == input.IsValidForCardOrders ||
                    (this.IsValidForCardOrders != null &&
                    this.IsValidForCardOrders.Equals(input.IsValidForCardOrders))
                ) && 
                (
                    this.IsValidForCashOrders == input.IsValidForCashOrders ||
                    (this.IsValidForCashOrders != null &&
                    this.IsValidForCashOrders.Equals(input.IsValidForCashOrders))
                ) && 
                (
                    this.IsValidForFirstOrderOnly == input.IsValidForFirstOrderOnly ||
                    (this.IsValidForFirstOrderOnly != null &&
                    this.IsValidForFirstOrderOnly.Equals(input.IsValidForFirstOrderOnly))
                ) && 
                (
                    this.MinimumOrderAmount == input.MinimumOrderAmount ||
                    (this.MinimumOrderAmount != null &&
                    this.MinimumOrderAmount.Equals(input.MinimumOrderAmount))
                ) && 
                (
                    this.IsValidOncePerCustomer == input.IsValidOncePerCustomer ||
                    (this.IsValidOncePerCustomer != null &&
                    this.IsValidOncePerCustomer.Equals(input.IsValidOncePerCustomer))
                ) && 
                (
                    this.AutoApply == input.AutoApply ||
                    (this.AutoApply != null &&
                    this.AutoApply.Equals(input.AutoApply))
                ) && 
                (
                    this.AutoApplyOrder == input.AutoApplyOrder ||
                    (this.AutoApplyOrder != null &&
                    this.AutoApplyOrder.Equals(input.AutoApplyOrder))
                ) && 
                (
                    this.IncludeDeliveryFee == input.IncludeDeliveryFee ||
                    (this.IncludeDeliveryFee != null &&
                    this.IncludeDeliveryFee.Equals(input.IncludeDeliveryFee))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.VoucherId != null)
                    hashCode = hashCode * 59 + this.VoucherId.GetHashCode();
                if (this.VoucherType != null)
                    hashCode = hashCode * 59 + this.VoucherType.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.IsUsedUp != null)
                    hashCode = hashCode * 59 + this.IsUsedUp.GetHashCode();
                if (this.VoucherSubType != null)
                    hashCode = hashCode * 59 + this.VoucherSubType.GetHashCode();
                if (this.PublicDescription != null)
                    hashCode = hashCode * 59 + this.PublicDescription.GetHashCode();
                if (this.PrivateDescription != null)
                    hashCode = hashCode * 59 + this.PrivateDescription.GetHashCode();
                if (this.ValidFrom != null)
                    hashCode = hashCode * 59 + this.ValidFrom.GetHashCode();
                if (this.Expiry != null)
                    hashCode = hashCode * 59 + this.Expiry.GetHashCode();
                if (this.VoucherPayer != null)
                    hashCode = hashCode * 59 + this.VoucherPayer.GetHashCode();
                if (this.IsVisibleToStore != null)
                    hashCode = hashCode * 59 + this.IsVisibleToStore.GetHashCode();
                if (this.IsReusable != null)
                    hashCode = hashCode * 59 + this.IsReusable.GetHashCode();
                if (this.IsValidForDeliveryOrders != null)
                    hashCode = hashCode * 59 + this.IsValidForDeliveryOrders.GetHashCode();
                if (this.IsValidForPickupOrders != null)
                    hashCode = hashCode * 59 + this.IsValidForPickupOrders.GetHashCode();
                if (this.IsValidForCardOrders != null)
                    hashCode = hashCode * 59 + this.IsValidForCardOrders.GetHashCode();
                if (this.IsValidForCashOrders != null)
                    hashCode = hashCode * 59 + this.IsValidForCashOrders.GetHashCode();
                if (this.IsValidForFirstOrderOnly != null)
                    hashCode = hashCode * 59 + this.IsValidForFirstOrderOnly.GetHashCode();
                if (this.MinimumOrderAmount != null)
                    hashCode = hashCode * 59 + this.MinimumOrderAmount.GetHashCode();
                if (this.IsValidOncePerCustomer != null)
                    hashCode = hashCode * 59 + this.IsValidOncePerCustomer.GetHashCode();
                if (this.AutoApply != null)
                    hashCode = hashCode * 59 + this.AutoApply.GetHashCode();
                if (this.AutoApplyOrder != null)
                    hashCode = hashCode * 59 + this.AutoApplyOrder.GetHashCode();
                if (this.IncludeDeliveryFee != null)
                    hashCode = hashCode * 59 + this.IncludeDeliveryFee.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
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
            // PublicDescription (string) maxLength
            if(this.PublicDescription != null && this.PublicDescription.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublicDescription, length must be less than 500.", new [] { "PublicDescription" });
            }

            // PublicDescription (string) minLength
            if(this.PublicDescription != null && this.PublicDescription.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublicDescription, length must be greater than 0.", new [] { "PublicDescription" });
            }

            // PrivateDescription (string) maxLength
            if(this.PrivateDescription != null && this.PrivateDescription.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrivateDescription, length must be less than 500.", new [] { "PrivateDescription" });
            }

            // PrivateDescription (string) minLength
            if(this.PrivateDescription != null && this.PrivateDescription.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrivateDescription, length must be greater than 0.", new [] { "PrivateDescription" });
            }

            // Code (string) maxLength
            if(this.Code != null && this.Code.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 20.", new [] { "Code" });
            }

            // Code (string) minLength
            if(this.Code != null && this.Code.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 0.", new [] { "Code" });
            }

            yield break;
        }
    }

}
