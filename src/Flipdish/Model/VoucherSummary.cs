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
    /// Voucher Summary
    /// </summary>
    [DataContract]
    public partial class VoucherSummary :  IEquatable<VoucherSummary>
    {
        /// <summary>
        /// Voucher Status
        /// </summary>
        /// <value>Voucher Status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Valid for value: Valid
            /// </summary>
            [EnumMember(Value = "Valid")]
            Valid = 1,
            
            /// <summary>
            /// Enum NotYetValid for value: NotYetValid
            /// </summary>
            [EnumMember(Value = "NotYetValid")]
            NotYetValid = 2,
            
            /// <summary>
            /// Enum Expired for value: Expired
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired = 3,
            
            /// <summary>
            /// Enum Used for value: Used
            /// </summary>
            [EnumMember(Value = "Used")]
            Used = 4,
            
            /// <summary>
            /// Enum Disabled for value: Disabled
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled = 5
        }

        /// <summary>
        /// Voucher Status
        /// </summary>
        /// <value>Voucher Status</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
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
            CreditNote = 4,
            
            /// <summary>
            /// Enum FreeDelivery for value: FreeDelivery
            /// </summary>
            [EnumMember(Value = "FreeDelivery")]
            FreeDelivery = 5
        }

        /// <summary>
        /// Voucher Type
        /// </summary>
        /// <value>Voucher Type</value>
        [DataMember(Name="VoucherType", EmitDefaultValue=false)]
        public VoucherTypeEnum? VoucherType { get; set; }
        /// <summary>
        /// Voucher Sub Type
        /// </summary>
        /// <value>Voucher Sub Type</value>
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
        /// Voucher Sub Type
        /// </summary>
        /// <value>Voucher Sub Type</value>
        [DataMember(Name="VoucherSubType", EmitDefaultValue=false)]
        public VoucherSubTypeEnum? VoucherSubType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherSummary" /> class.
        /// </summary>
        /// <param name="voucherId">Voucher Id.</param>
        /// <param name="code">Voucher Code.</param>
        /// <param name="status">Voucher Status.</param>
        /// <param name="voucherType">Voucher Type.</param>
        /// <param name="voucherSubType">Voucher Sub Type.</param>
        /// <param name="description">Voucher Description (Visible on printout).</param>
        /// <param name="isEnabled">Is voucher enabled.</param>
        public VoucherSummary(int? voucherId = default(int?), string code = default(string), StatusEnum? status = default(StatusEnum?), VoucherTypeEnum? voucherType = default(VoucherTypeEnum?), VoucherSubTypeEnum? voucherSubType = default(VoucherSubTypeEnum?), string description = default(string), bool? isEnabled = default(bool?))
        {
            this.VoucherId = voucherId;
            this.Code = code;
            this.Status = status;
            this.VoucherType = voucherType;
            this.VoucherSubType = voucherSubType;
            this.Description = description;
            this.IsEnabled = isEnabled;
        }
        
        /// <summary>
        /// Voucher Id
        /// </summary>
        /// <value>Voucher Id</value>
        [DataMember(Name="VoucherId", EmitDefaultValue=false)]
        public int? VoucherId { get; set; }

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
        /// Is voucher enabled
        /// </summary>
        /// <value>Is voucher enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoucherSummary {\n");
            sb.Append("  VoucherId: ").Append(VoucherId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  VoucherType: ").Append(VoucherType).Append("\n");
            sb.Append("  VoucherSubType: ").Append(VoucherSubType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
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
            return this.Equals(input as VoucherSummary);
        }

        /// <summary>
        /// Returns true if VoucherSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherSummary input)
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.VoucherType == input.VoucherType ||
                    (this.VoucherType != null &&
                    this.VoucherType.Equals(input.VoucherType))
                ) && 
                (
                    this.VoucherSubType == input.VoucherSubType ||
                    (this.VoucherSubType != null &&
                    this.VoucherSubType.Equals(input.VoucherSubType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VoucherType != null)
                    hashCode = hashCode * 59 + this.VoucherType.GetHashCode();
                if (this.VoucherSubType != null)
                    hashCode = hashCode * 59 + this.VoucherSubType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                return hashCode;
            }
        }
    }

}
