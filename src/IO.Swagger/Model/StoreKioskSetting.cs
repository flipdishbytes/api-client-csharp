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
    /// Store Kiosk Settings
    /// </summary>
    [DataContract]
    public partial class StoreKioskSetting :  IEquatable<StoreKioskSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreKioskSetting" /> class.
        /// </summary>
        /// <param name="kioskSettingId">Kiosk setting id.</param>
        /// <param name="kioskName">Store kiosk name.</param>
        /// <param name="requireCustomerName">Require customer name flag.</param>
        /// <param name="requireCustomerPhoneNumber">Require customer phone number flag.</param>
        /// <param name="requestCustomerPhoneNumber">Request customer phone number flag (Option to Skip).</param>
        /// <param name="requestTableNumber">Request table number flag.</param>
        /// <param name="offerDineInOrTakeawayOption">Offer Dine-In/Takeaway option flag.</param>
        /// <param name="physicalRestaurantId">Physical restaurant id.</param>
        /// <param name="hydraConfigId">Hydra config id.</param>
        public StoreKioskSetting(int? kioskSettingId = default(int?), string kioskName = default(string), bool? requireCustomerName = default(bool?), bool? requireCustomerPhoneNumber = default(bool?), bool? requestCustomerPhoneNumber = default(bool?), bool? requestTableNumber = default(bool?), bool? offerDineInOrTakeawayOption = default(bool?), int? physicalRestaurantId = default(int?), int? hydraConfigId = default(int?))
        {
            this.KioskSettingId = kioskSettingId;
            this.KioskName = kioskName;
            this.RequireCustomerName = requireCustomerName;
            this.RequireCustomerPhoneNumber = requireCustomerPhoneNumber;
            this.RequestCustomerPhoneNumber = requestCustomerPhoneNumber;
            this.RequestTableNumber = requestTableNumber;
            this.OfferDineInOrTakeawayOption = offerDineInOrTakeawayOption;
            this.PhysicalRestaurantId = physicalRestaurantId;
            this.HydraConfigId = hydraConfigId;
        }
        
        /// <summary>
        /// Kiosk setting id
        /// </summary>
        /// <value>Kiosk setting id</value>
        [DataMember(Name="KioskSettingId", EmitDefaultValue=false)]
        public int? KioskSettingId { get; set; }

        /// <summary>
        /// Store kiosk name
        /// </summary>
        /// <value>Store kiosk name</value>
        [DataMember(Name="KioskName", EmitDefaultValue=false)]
        public string KioskName { get; set; }

        /// <summary>
        /// Require customer name flag
        /// </summary>
        /// <value>Require customer name flag</value>
        [DataMember(Name="RequireCustomerName", EmitDefaultValue=false)]
        public bool? RequireCustomerName { get; set; }

        /// <summary>
        /// Require customer phone number flag
        /// </summary>
        /// <value>Require customer phone number flag</value>
        [DataMember(Name="RequireCustomerPhoneNumber", EmitDefaultValue=false)]
        public bool? RequireCustomerPhoneNumber { get; set; }

        /// <summary>
        /// Request customer phone number flag (Option to Skip)
        /// </summary>
        /// <value>Request customer phone number flag (Option to Skip)</value>
        [DataMember(Name="RequestCustomerPhoneNumber", EmitDefaultValue=false)]
        public bool? RequestCustomerPhoneNumber { get; set; }

        /// <summary>
        /// Request table number flag
        /// </summary>
        /// <value>Request table number flag</value>
        [DataMember(Name="RequestTableNumber", EmitDefaultValue=false)]
        public bool? RequestTableNumber { get; set; }

        /// <summary>
        /// Offer Dine-In/Takeaway option flag
        /// </summary>
        /// <value>Offer Dine-In/Takeaway option flag</value>
        [DataMember(Name="OfferDineInOrTakeawayOption", EmitDefaultValue=false)]
        public bool? OfferDineInOrTakeawayOption { get; set; }

        /// <summary>
        /// Physical restaurant id
        /// </summary>
        /// <value>Physical restaurant id</value>
        [DataMember(Name="PhysicalRestaurantId", EmitDefaultValue=false)]
        public int? PhysicalRestaurantId { get; set; }

        /// <summary>
        /// Hydra config id
        /// </summary>
        /// <value>Hydra config id</value>
        [DataMember(Name="HydraConfigId", EmitDefaultValue=false)]
        public int? HydraConfigId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreKioskSetting {\n");
            sb.Append("  KioskSettingId: ").Append(KioskSettingId).Append("\n");
            sb.Append("  KioskName: ").Append(KioskName).Append("\n");
            sb.Append("  RequireCustomerName: ").Append(RequireCustomerName).Append("\n");
            sb.Append("  RequireCustomerPhoneNumber: ").Append(RequireCustomerPhoneNumber).Append("\n");
            sb.Append("  RequestCustomerPhoneNumber: ").Append(RequestCustomerPhoneNumber).Append("\n");
            sb.Append("  RequestTableNumber: ").Append(RequestTableNumber).Append("\n");
            sb.Append("  OfferDineInOrTakeawayOption: ").Append(OfferDineInOrTakeawayOption).Append("\n");
            sb.Append("  PhysicalRestaurantId: ").Append(PhysicalRestaurantId).Append("\n");
            sb.Append("  HydraConfigId: ").Append(HydraConfigId).Append("\n");
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
            return this.Equals(input as StoreKioskSetting);
        }

        /// <summary>
        /// Returns true if StoreKioskSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreKioskSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreKioskSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KioskSettingId == input.KioskSettingId ||
                    (this.KioskSettingId != null &&
                    this.KioskSettingId.Equals(input.KioskSettingId))
                ) && 
                (
                    this.KioskName == input.KioskName ||
                    (this.KioskName != null &&
                    this.KioskName.Equals(input.KioskName))
                ) && 
                (
                    this.RequireCustomerName == input.RequireCustomerName ||
                    (this.RequireCustomerName != null &&
                    this.RequireCustomerName.Equals(input.RequireCustomerName))
                ) && 
                (
                    this.RequireCustomerPhoneNumber == input.RequireCustomerPhoneNumber ||
                    (this.RequireCustomerPhoneNumber != null &&
                    this.RequireCustomerPhoneNumber.Equals(input.RequireCustomerPhoneNumber))
                ) && 
                (
                    this.RequestCustomerPhoneNumber == input.RequestCustomerPhoneNumber ||
                    (this.RequestCustomerPhoneNumber != null &&
                    this.RequestCustomerPhoneNumber.Equals(input.RequestCustomerPhoneNumber))
                ) && 
                (
                    this.RequestTableNumber == input.RequestTableNumber ||
                    (this.RequestTableNumber != null &&
                    this.RequestTableNumber.Equals(input.RequestTableNumber))
                ) && 
                (
                    this.OfferDineInOrTakeawayOption == input.OfferDineInOrTakeawayOption ||
                    (this.OfferDineInOrTakeawayOption != null &&
                    this.OfferDineInOrTakeawayOption.Equals(input.OfferDineInOrTakeawayOption))
                ) && 
                (
                    this.PhysicalRestaurantId == input.PhysicalRestaurantId ||
                    (this.PhysicalRestaurantId != null &&
                    this.PhysicalRestaurantId.Equals(input.PhysicalRestaurantId))
                ) && 
                (
                    this.HydraConfigId == input.HydraConfigId ||
                    (this.HydraConfigId != null &&
                    this.HydraConfigId.Equals(input.HydraConfigId))
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
                if (this.KioskSettingId != null)
                    hashCode = hashCode * 59 + this.KioskSettingId.GetHashCode();
                if (this.KioskName != null)
                    hashCode = hashCode * 59 + this.KioskName.GetHashCode();
                if (this.RequireCustomerName != null)
                    hashCode = hashCode * 59 + this.RequireCustomerName.GetHashCode();
                if (this.RequireCustomerPhoneNumber != null)
                    hashCode = hashCode * 59 + this.RequireCustomerPhoneNumber.GetHashCode();
                if (this.RequestCustomerPhoneNumber != null)
                    hashCode = hashCode * 59 + this.RequestCustomerPhoneNumber.GetHashCode();
                if (this.RequestTableNumber != null)
                    hashCode = hashCode * 59 + this.RequestTableNumber.GetHashCode();
                if (this.OfferDineInOrTakeawayOption != null)
                    hashCode = hashCode * 59 + this.OfferDineInOrTakeawayOption.GetHashCode();
                if (this.PhysicalRestaurantId != null)
                    hashCode = hashCode * 59 + this.PhysicalRestaurantId.GetHashCode();
                if (this.HydraConfigId != null)
                    hashCode = hashCode * 59 + this.HydraConfigId.GetHashCode();
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
