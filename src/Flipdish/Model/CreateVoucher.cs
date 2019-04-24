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
    public partial class CreateVoucher :  IEquatable<CreateVoucher>, IValidatableObject
    {
        /// <summary>
        /// Voucher Type
        /// </summary>
        /// <value>Voucher Type</value>
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
        /// Voucher Type
        /// </summary>
        /// <value>Voucher Type</value>
        [DataMember(Name="VoucherType", EmitDefaultValue=false)]
        public VoucherTypeEnum? VoucherType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoucher" /> class.
        /// </summary>
        /// <param name="voucherType">Voucher Type.</param>
        /// <param name="stores">Stores that this voucher applies to.</param>
        /// <param name="addItemDetails">Add item details.</param>
        /// <param name="creditNoteDetails">Credit note details.</param>
        /// <param name="lumpDiscountDetails">Lump discount details.</param>
        /// <param name="percentDiscountDetails">Percent discount details.</param>
        /// <param name="code">Voucher Code.</param>
        /// <param name="description">Voucher Description (Visible on printout).</param>
        /// <param name="validOnOrdersOver">Valid on orders on or above.</param>
        /// <param name="takesPriority">Takes priority.</param>
        /// <param name="isEnabled">Is voucher enabled.</param>
        /// <param name="isAutomaticallyApplied">Is voucher automatically applied.</param>
        /// <param name="includeDeliveryFee">Include delivery fees.</param>
        /// <param name="isValidForDeliveryOrders">Valid for delivery orders.</param>
        /// <param name="isValidForPickupOrders">Valid for pickup orders.</param>
        /// <param name="isValidForOrdersPayedOnline">Valid for orders payed online.</param>
        /// <param name="isValidForOrdersPayedByCash">Valid for orders payed in cash.</param>
        /// <param name="isValidForFirstOrderOnly">Valid only on the first order by the customer.</param>
        /// <param name="isValidOncePerCustomer">Valid once per customer.</param>
        /// <param name="isValidOnlyOnce">Valid only once, by any customer (once used cannot be used again by any other customer).</param>
        /// <param name="startDate">Voucher Starts On (Time in UTC).</param>
        /// <param name="expiryDate">Voucher Expires On (Time in UTC).</param>
        public CreateVoucher(VoucherTypeEnum? voucherType = default(VoucherTypeEnum?), List<int?> stores = default(List<int?>), AddItemDetails addItemDetails = default(AddItemDetails), CreditNoteDetails creditNoteDetails = default(CreditNoteDetails), LumpDiscountDetails lumpDiscountDetails = default(LumpDiscountDetails), PercentDiscountDetails percentDiscountDetails = default(PercentDiscountDetails), string code = default(string), string description = default(string), double? validOnOrdersOver = default(double?), bool? takesPriority = default(bool?), bool? isEnabled = default(bool?), bool? isAutomaticallyApplied = default(bool?), bool? includeDeliveryFee = default(bool?), bool? isValidForDeliveryOrders = default(bool?), bool? isValidForPickupOrders = default(bool?), bool? isValidForOrdersPayedOnline = default(bool?), bool? isValidForOrdersPayedByCash = default(bool?), bool? isValidForFirstOrderOnly = default(bool?), bool? isValidOncePerCustomer = default(bool?), bool? isValidOnlyOnce = default(bool?), DateTime? startDate = default(DateTime?), DateTime? expiryDate = default(DateTime?))
        {
            this.VoucherType = voucherType;
            this.Stores = stores;
            this.AddItemDetails = addItemDetails;
            this.CreditNoteDetails = creditNoteDetails;
            this.LumpDiscountDetails = lumpDiscountDetails;
            this.PercentDiscountDetails = percentDiscountDetails;
            this.Code = code;
            this.Description = description;
            this.ValidOnOrdersOver = validOnOrdersOver;
            this.TakesPriority = takesPriority;
            this.IsEnabled = isEnabled;
            this.IsAutomaticallyApplied = isAutomaticallyApplied;
            this.IncludeDeliveryFee = includeDeliveryFee;
            this.IsValidForDeliveryOrders = isValidForDeliveryOrders;
            this.IsValidForPickupOrders = isValidForPickupOrders;
            this.IsValidForOrdersPayedOnline = isValidForOrdersPayedOnline;
            this.IsValidForOrdersPayedByCash = isValidForOrdersPayedByCash;
            this.IsValidForFirstOrderOnly = isValidForFirstOrderOnly;
            this.IsValidOncePerCustomer = isValidOncePerCustomer;
            this.IsValidOnlyOnce = isValidOnlyOnce;
            this.StartDate = startDate;
            this.ExpiryDate = expiryDate;
        }
        

        /// <summary>
        /// Stores that this voucher applies to
        /// </summary>
        /// <value>Stores that this voucher applies to</value>
        [DataMember(Name="Stores", EmitDefaultValue=false)]
        public List<int?> Stores { get; set; }

        /// <summary>
        /// Add item details
        /// </summary>
        /// <value>Add item details</value>
        [DataMember(Name="AddItemDetails", EmitDefaultValue=false)]
        public AddItemDetails AddItemDetails { get; set; }

        /// <summary>
        /// Credit note details
        /// </summary>
        /// <value>Credit note details</value>
        [DataMember(Name="CreditNoteDetails", EmitDefaultValue=false)]
        public CreditNoteDetails CreditNoteDetails { get; set; }

        /// <summary>
        /// Lump discount details
        /// </summary>
        /// <value>Lump discount details</value>
        [DataMember(Name="LumpDiscountDetails", EmitDefaultValue=false)]
        public LumpDiscountDetails LumpDiscountDetails { get; set; }

        /// <summary>
        /// Percent discount details
        /// </summary>
        /// <value>Percent discount details</value>
        [DataMember(Name="PercentDiscountDetails", EmitDefaultValue=false)]
        public PercentDiscountDetails PercentDiscountDetails { get; set; }

        /// <summary>
        /// Voucher Code
        /// </summary>
        /// <value>Voucher Code</value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Voucher Description (Visible on printout)
        /// </summary>
        /// <value>Voucher Description (Visible on printout)</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Valid on orders on or above
        /// </summary>
        /// <value>Valid on orders on or above</value>
        [DataMember(Name="ValidOnOrdersOver", EmitDefaultValue=false)]
        public double? ValidOnOrdersOver { get; set; }

        /// <summary>
        /// Takes priority
        /// </summary>
        /// <value>Takes priority</value>
        [DataMember(Name="TakesPriority", EmitDefaultValue=false)]
        public bool? TakesPriority { get; set; }

        /// <summary>
        /// Is voucher enabled
        /// </summary>
        /// <value>Is voucher enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Is voucher automatically applied
        /// </summary>
        /// <value>Is voucher automatically applied</value>
        [DataMember(Name="IsAutomaticallyApplied", EmitDefaultValue=false)]
        public bool? IsAutomaticallyApplied { get; set; }

        /// <summary>
        /// Include delivery fees
        /// </summary>
        /// <value>Include delivery fees</value>
        [DataMember(Name="IncludeDeliveryFee", EmitDefaultValue=false)]
        public bool? IncludeDeliveryFee { get; set; }

        /// <summary>
        /// Valid for delivery orders
        /// </summary>
        /// <value>Valid for delivery orders</value>
        [DataMember(Name="IsValidForDeliveryOrders", EmitDefaultValue=false)]
        public bool? IsValidForDeliveryOrders { get; set; }

        /// <summary>
        /// Valid for pickup orders
        /// </summary>
        /// <value>Valid for pickup orders</value>
        [DataMember(Name="IsValidForPickupOrders", EmitDefaultValue=false)]
        public bool? IsValidForPickupOrders { get; set; }

        /// <summary>
        /// Valid for orders payed online
        /// </summary>
        /// <value>Valid for orders payed online</value>
        [DataMember(Name="IsValidForOrdersPayedOnline", EmitDefaultValue=false)]
        public bool? IsValidForOrdersPayedOnline { get; set; }

        /// <summary>
        /// Valid for orders payed in cash
        /// </summary>
        /// <value>Valid for orders payed in cash</value>
        [DataMember(Name="IsValidForOrdersPayedByCash", EmitDefaultValue=false)]
        public bool? IsValidForOrdersPayedByCash { get; set; }

        /// <summary>
        /// Valid only on the first order by the customer
        /// </summary>
        /// <value>Valid only on the first order by the customer</value>
        [DataMember(Name="IsValidForFirstOrderOnly", EmitDefaultValue=false)]
        public bool? IsValidForFirstOrderOnly { get; set; }

        /// <summary>
        /// Valid once per customer
        /// </summary>
        /// <value>Valid once per customer</value>
        [DataMember(Name="IsValidOncePerCustomer", EmitDefaultValue=false)]
        public bool? IsValidOncePerCustomer { get; set; }

        /// <summary>
        /// Valid only once, by any customer (once used cannot be used again by any other customer)
        /// </summary>
        /// <value>Valid only once, by any customer (once used cannot be used again by any other customer)</value>
        [DataMember(Name="IsValidOnlyOnce", EmitDefaultValue=false)]
        public bool? IsValidOnlyOnce { get; set; }

        /// <summary>
        /// Voucher Starts On (Time in UTC)
        /// </summary>
        /// <value>Voucher Starts On (Time in UTC)</value>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Voucher Expires On (Time in UTC)
        /// </summary>
        /// <value>Voucher Expires On (Time in UTC)</value>
        [DataMember(Name="ExpiryDate", EmitDefaultValue=false)]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVoucher {\n");
            sb.Append("  VoucherType: ").Append(VoucherType).Append("\n");
            sb.Append("  Stores: ").Append(Stores).Append("\n");
            sb.Append("  AddItemDetails: ").Append(AddItemDetails).Append("\n");
            sb.Append("  CreditNoteDetails: ").Append(CreditNoteDetails).Append("\n");
            sb.Append("  LumpDiscountDetails: ").Append(LumpDiscountDetails).Append("\n");
            sb.Append("  PercentDiscountDetails: ").Append(PercentDiscountDetails).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ValidOnOrdersOver: ").Append(ValidOnOrdersOver).Append("\n");
            sb.Append("  TakesPriority: ").Append(TakesPriority).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsAutomaticallyApplied: ").Append(IsAutomaticallyApplied).Append("\n");
            sb.Append("  IncludeDeliveryFee: ").Append(IncludeDeliveryFee).Append("\n");
            sb.Append("  IsValidForDeliveryOrders: ").Append(IsValidForDeliveryOrders).Append("\n");
            sb.Append("  IsValidForPickupOrders: ").Append(IsValidForPickupOrders).Append("\n");
            sb.Append("  IsValidForOrdersPayedOnline: ").Append(IsValidForOrdersPayedOnline).Append("\n");
            sb.Append("  IsValidForOrdersPayedByCash: ").Append(IsValidForOrdersPayedByCash).Append("\n");
            sb.Append("  IsValidForFirstOrderOnly: ").Append(IsValidForFirstOrderOnly).Append("\n");
            sb.Append("  IsValidOncePerCustomer: ").Append(IsValidOncePerCustomer).Append("\n");
            sb.Append("  IsValidOnlyOnce: ").Append(IsValidOnlyOnce).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
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
            return this.Equals(input as CreateVoucher);
        }

        /// <summary>
        /// Returns true if CreateVoucher instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateVoucher to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateVoucher input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VoucherType == input.VoucherType ||
                    (this.VoucherType != null &&
                    this.VoucherType.Equals(input.VoucherType))
                ) && 
                (
                    this.Stores == input.Stores ||
                    this.Stores != null &&
                    this.Stores.SequenceEqual(input.Stores)
                ) && 
                (
                    this.AddItemDetails == input.AddItemDetails ||
                    (this.AddItemDetails != null &&
                    this.AddItemDetails.Equals(input.AddItemDetails))
                ) && 
                (
                    this.CreditNoteDetails == input.CreditNoteDetails ||
                    (this.CreditNoteDetails != null &&
                    this.CreditNoteDetails.Equals(input.CreditNoteDetails))
                ) && 
                (
                    this.LumpDiscountDetails == input.LumpDiscountDetails ||
                    (this.LumpDiscountDetails != null &&
                    this.LumpDiscountDetails.Equals(input.LumpDiscountDetails))
                ) && 
                (
                    this.PercentDiscountDetails == input.PercentDiscountDetails ||
                    (this.PercentDiscountDetails != null &&
                    this.PercentDiscountDetails.Equals(input.PercentDiscountDetails))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ValidOnOrdersOver == input.ValidOnOrdersOver ||
                    (this.ValidOnOrdersOver != null &&
                    this.ValidOnOrdersOver.Equals(input.ValidOnOrdersOver))
                ) && 
                (
                    this.TakesPriority == input.TakesPriority ||
                    (this.TakesPriority != null &&
                    this.TakesPriority.Equals(input.TakesPriority))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.IsAutomaticallyApplied == input.IsAutomaticallyApplied ||
                    (this.IsAutomaticallyApplied != null &&
                    this.IsAutomaticallyApplied.Equals(input.IsAutomaticallyApplied))
                ) && 
                (
                    this.IncludeDeliveryFee == input.IncludeDeliveryFee ||
                    (this.IncludeDeliveryFee != null &&
                    this.IncludeDeliveryFee.Equals(input.IncludeDeliveryFee))
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
                    this.IsValidForOrdersPayedOnline == input.IsValidForOrdersPayedOnline ||
                    (this.IsValidForOrdersPayedOnline != null &&
                    this.IsValidForOrdersPayedOnline.Equals(input.IsValidForOrdersPayedOnline))
                ) && 
                (
                    this.IsValidForOrdersPayedByCash == input.IsValidForOrdersPayedByCash ||
                    (this.IsValidForOrdersPayedByCash != null &&
                    this.IsValidForOrdersPayedByCash.Equals(input.IsValidForOrdersPayedByCash))
                ) && 
                (
                    this.IsValidForFirstOrderOnly == input.IsValidForFirstOrderOnly ||
                    (this.IsValidForFirstOrderOnly != null &&
                    this.IsValidForFirstOrderOnly.Equals(input.IsValidForFirstOrderOnly))
                ) && 
                (
                    this.IsValidOncePerCustomer == input.IsValidOncePerCustomer ||
                    (this.IsValidOncePerCustomer != null &&
                    this.IsValidOncePerCustomer.Equals(input.IsValidOncePerCustomer))
                ) && 
                (
                    this.IsValidOnlyOnce == input.IsValidOnlyOnce ||
                    (this.IsValidOnlyOnce != null &&
                    this.IsValidOnlyOnce.Equals(input.IsValidOnlyOnce))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
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
                if (this.VoucherType != null)
                    hashCode = hashCode * 59 + this.VoucherType.GetHashCode();
                if (this.Stores != null)
                    hashCode = hashCode * 59 + this.Stores.GetHashCode();
                if (this.AddItemDetails != null)
                    hashCode = hashCode * 59 + this.AddItemDetails.GetHashCode();
                if (this.CreditNoteDetails != null)
                    hashCode = hashCode * 59 + this.CreditNoteDetails.GetHashCode();
                if (this.LumpDiscountDetails != null)
                    hashCode = hashCode * 59 + this.LumpDiscountDetails.GetHashCode();
                if (this.PercentDiscountDetails != null)
                    hashCode = hashCode * 59 + this.PercentDiscountDetails.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ValidOnOrdersOver != null)
                    hashCode = hashCode * 59 + this.ValidOnOrdersOver.GetHashCode();
                if (this.TakesPriority != null)
                    hashCode = hashCode * 59 + this.TakesPriority.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.IsAutomaticallyApplied != null)
                    hashCode = hashCode * 59 + this.IsAutomaticallyApplied.GetHashCode();
                if (this.IncludeDeliveryFee != null)
                    hashCode = hashCode * 59 + this.IncludeDeliveryFee.GetHashCode();
                if (this.IsValidForDeliveryOrders != null)
                    hashCode = hashCode * 59 + this.IsValidForDeliveryOrders.GetHashCode();
                if (this.IsValidForPickupOrders != null)
                    hashCode = hashCode * 59 + this.IsValidForPickupOrders.GetHashCode();
                if (this.IsValidForOrdersPayedOnline != null)
                    hashCode = hashCode * 59 + this.IsValidForOrdersPayedOnline.GetHashCode();
                if (this.IsValidForOrdersPayedByCash != null)
                    hashCode = hashCode * 59 + this.IsValidForOrdersPayedByCash.GetHashCode();
                if (this.IsValidForFirstOrderOnly != null)
                    hashCode = hashCode * 59 + this.IsValidForFirstOrderOnly.GetHashCode();
                if (this.IsValidOncePerCustomer != null)
                    hashCode = hashCode * 59 + this.IsValidOncePerCustomer.GetHashCode();
                if (this.IsValidOnlyOnce != null)
                    hashCode = hashCode * 59 + this.IsValidOnlyOnce.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
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
