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
    /// Ligthspeed store settings
    /// </summary>
    [DataContract]
    public partial class LightspeedSettings :  IEquatable<LightspeedSettings>, IValidatableObject
    {
        /// <summary>
        /// Which price to choose from Lightspeed menu
        /// </summary>
        /// <value>Which price to choose from Lightspeed menu</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriceTypeEnum
        {
            
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,
            
            /// <summary>
            /// Enum Takeaway for value: Takeaway
            /// </summary>
            [EnumMember(Value = "Takeaway")]
            Takeaway = 2,
            
            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 3
        }

        /// <summary>
        /// Which price to choose from Lightspeed menu
        /// </summary>
        /// <value>Which price to choose from Lightspeed menu</value>
        [DataMember(Name="PriceType", EmitDefaultValue=false)]
        public PriceTypeEnum? PriceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LightspeedSettings" /> class.
        /// </summary>
        /// <param name="companyId">Company Id.</param>
        /// <param name="useOAuth">Use OAuth for authentication.</param>
        /// <param name="enabled">Enabled.</param>
        /// <param name="estimatedMinutesForDelivery">Estimated minutes for delivery.</param>
        /// <param name="estimatedMinutesForCollection">Estimated minutes for collection.</param>
        /// <param name="geographicLocation">Geographic location (euc1, nae1, euw2, ....)).</param>
        /// <param name="establishment">Is the CompanyId an establishment (kind of the store of a group of store).</param>
        /// <param name="voucherId">The Lightspeed voucher identifier to map with our.</param>
        /// <param name="deliveryFeeId">The Lightspeed delivery fee identifier to map with our.</param>
        /// <param name="processingFeeId">The Lightspeed processing fee identifier to map with our.</param>
        /// <param name="priceType">Which price to choose from Lightspeed menu.</param>
        /// <param name="menuId">The menu id of the store.</param>
        /// <param name="collectionTableId">Collection Table ID to send orders.</param>
        /// <param name="deliveryTableId">Delivery Table ID to send orders.</param>
        /// <param name="collectionTableIds">Collection Table IDs to send orders to.</param>
        /// <param name="deliveryTableIds">Delivery Table IDs to send orders to.</param>
        /// <param name="useTaxInclusivePrices">Exclude tax.</param>
        /// <param name="skipStatusCheckAndAcceptOrderAfterSending">WARNING: only use this option if the Liteserver is not synchronizing within max 5 minutes with Lightspeed cloud!.</param>
        public LightspeedSettings(string companyId = default(string), bool? useOAuth = default(bool?), bool? enabled = default(bool?), int? estimatedMinutesForDelivery = default(int?), int? estimatedMinutesForCollection = default(int?), string geographicLocation = default(string), bool? establishment = default(bool?), string voucherId = default(string), string deliveryFeeId = default(string), string processingFeeId = default(string), PriceTypeEnum? priceType = default(PriceTypeEnum?), int? menuId = default(int?), int? collectionTableId = default(int?), int? deliveryTableId = default(int?), Dictionary<string, string> collectionTableIds = default(Dictionary<string, string>), Dictionary<string, string> deliveryTableIds = default(Dictionary<string, string>), bool? useTaxInclusivePrices = default(bool?), bool? skipStatusCheckAndAcceptOrderAfterSending = default(bool?))
        {
            this.CompanyId = companyId;
            this.UseOAuth = useOAuth;
            this.Enabled = enabled;
            this.EstimatedMinutesForDelivery = estimatedMinutesForDelivery;
            this.EstimatedMinutesForCollection = estimatedMinutesForCollection;
            this.GeographicLocation = geographicLocation;
            this.Establishment = establishment;
            this.VoucherId = voucherId;
            this.DeliveryFeeId = deliveryFeeId;
            this.ProcessingFeeId = processingFeeId;
            this.PriceType = priceType;
            this.MenuId = menuId;
            this.CollectionTableId = collectionTableId;
            this.DeliveryTableId = deliveryTableId;
            this.CollectionTableIds = collectionTableIds;
            this.DeliveryTableIds = deliveryTableIds;
            this.UseTaxInclusivePrices = useTaxInclusivePrices;
            this.SkipStatusCheckAndAcceptOrderAfterSending = skipStatusCheckAndAcceptOrderAfterSending;
        }
        
        /// <summary>
        /// Company Id
        /// </summary>
        /// <value>Company Id</value>
        [DataMember(Name="CompanyId", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Use OAuth for authentication
        /// </summary>
        /// <value>Use OAuth for authentication</value>
        [DataMember(Name="UseOAuth", EmitDefaultValue=false)]
        public bool? UseOAuth { get; set; }

        /// <summary>
        /// Enabled
        /// </summary>
        /// <value>Enabled</value>
        [DataMember(Name="Enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Estimated minutes for delivery
        /// </summary>
        /// <value>Estimated minutes for delivery</value>
        [DataMember(Name="EstimatedMinutesForDelivery", EmitDefaultValue=false)]
        public int? EstimatedMinutesForDelivery { get; set; }

        /// <summary>
        /// Estimated minutes for collection
        /// </summary>
        /// <value>Estimated minutes for collection</value>
        [DataMember(Name="EstimatedMinutesForCollection", EmitDefaultValue=false)]
        public int? EstimatedMinutesForCollection { get; set; }

        /// <summary>
        /// Geographic location (euc1, nae1, euw2, ....))
        /// </summary>
        /// <value>Geographic location (euc1, nae1, euw2, ....))</value>
        [DataMember(Name="GeographicLocation", EmitDefaultValue=false)]
        public string GeographicLocation { get; set; }

        /// <summary>
        /// Is the CompanyId an establishment (kind of the store of a group of store)
        /// </summary>
        /// <value>Is the CompanyId an establishment (kind of the store of a group of store)</value>
        [DataMember(Name="Establishment", EmitDefaultValue=false)]
        public bool? Establishment { get; set; }

        /// <summary>
        /// The Lightspeed voucher identifier to map with our
        /// </summary>
        /// <value>The Lightspeed voucher identifier to map with our</value>
        [DataMember(Name="VoucherId", EmitDefaultValue=false)]
        public string VoucherId { get; set; }

        /// <summary>
        /// The Lightspeed delivery fee identifier to map with our
        /// </summary>
        /// <value>The Lightspeed delivery fee identifier to map with our</value>
        [DataMember(Name="DeliveryFeeId", EmitDefaultValue=false)]
        public string DeliveryFeeId { get; set; }

        /// <summary>
        /// The Lightspeed processing fee identifier to map with our
        /// </summary>
        /// <value>The Lightspeed processing fee identifier to map with our</value>
        [DataMember(Name="ProcessingFeeId", EmitDefaultValue=false)]
        public string ProcessingFeeId { get; set; }


        /// <summary>
        /// The menu id of the store
        /// </summary>
        /// <value>The menu id of the store</value>
        [DataMember(Name="MenuId", EmitDefaultValue=false)]
        public int? MenuId { get; set; }

        /// <summary>
        /// Collection Table ID to send orders
        /// </summary>
        /// <value>Collection Table ID to send orders</value>
        [DataMember(Name="CollectionTableId", EmitDefaultValue=false)]
        public int? CollectionTableId { get; set; }

        /// <summary>
        /// Delivery Table ID to send orders
        /// </summary>
        /// <value>Delivery Table ID to send orders</value>
        [DataMember(Name="DeliveryTableId", EmitDefaultValue=false)]
        public int? DeliveryTableId { get; set; }

        /// <summary>
        /// Collection Table IDs to send orders to
        /// </summary>
        /// <value>Collection Table IDs to send orders to</value>
        [DataMember(Name="CollectionTableIds", EmitDefaultValue=false)]
        public Dictionary<string, string> CollectionTableIds { get; set; }

        /// <summary>
        /// Delivery Table IDs to send orders to
        /// </summary>
        /// <value>Delivery Table IDs to send orders to</value>
        [DataMember(Name="DeliveryTableIds", EmitDefaultValue=false)]
        public Dictionary<string, string> DeliveryTableIds { get; set; }

        /// <summary>
        /// Exclude tax
        /// </summary>
        /// <value>Exclude tax</value>
        [DataMember(Name="UseTaxInclusivePrices", EmitDefaultValue=false)]
        public bool? UseTaxInclusivePrices { get; set; }

        /// <summary>
        /// WARNING: only use this option if the Liteserver is not synchronizing within max 5 minutes with Lightspeed cloud!
        /// </summary>
        /// <value>WARNING: only use this option if the Liteserver is not synchronizing within max 5 minutes with Lightspeed cloud!</value>
        [DataMember(Name="SkipStatusCheckAndAcceptOrderAfterSending", EmitDefaultValue=false)]
        public bool? SkipStatusCheckAndAcceptOrderAfterSending { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LightspeedSettings {\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  UseOAuth: ").Append(UseOAuth).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  EstimatedMinutesForDelivery: ").Append(EstimatedMinutesForDelivery).Append("\n");
            sb.Append("  EstimatedMinutesForCollection: ").Append(EstimatedMinutesForCollection).Append("\n");
            sb.Append("  GeographicLocation: ").Append(GeographicLocation).Append("\n");
            sb.Append("  Establishment: ").Append(Establishment).Append("\n");
            sb.Append("  VoucherId: ").Append(VoucherId).Append("\n");
            sb.Append("  DeliveryFeeId: ").Append(DeliveryFeeId).Append("\n");
            sb.Append("  ProcessingFeeId: ").Append(ProcessingFeeId).Append("\n");
            sb.Append("  PriceType: ").Append(PriceType).Append("\n");
            sb.Append("  MenuId: ").Append(MenuId).Append("\n");
            sb.Append("  CollectionTableId: ").Append(CollectionTableId).Append("\n");
            sb.Append("  DeliveryTableId: ").Append(DeliveryTableId).Append("\n");
            sb.Append("  CollectionTableIds: ").Append(CollectionTableIds).Append("\n");
            sb.Append("  DeliveryTableIds: ").Append(DeliveryTableIds).Append("\n");
            sb.Append("  UseTaxInclusivePrices: ").Append(UseTaxInclusivePrices).Append("\n");
            sb.Append("  SkipStatusCheckAndAcceptOrderAfterSending: ").Append(SkipStatusCheckAndAcceptOrderAfterSending).Append("\n");
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
            return this.Equals(input as LightspeedSettings);
        }

        /// <summary>
        /// Returns true if LightspeedSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of LightspeedSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LightspeedSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.UseOAuth == input.UseOAuth ||
                    (this.UseOAuth != null &&
                    this.UseOAuth.Equals(input.UseOAuth))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.EstimatedMinutesForDelivery == input.EstimatedMinutesForDelivery ||
                    (this.EstimatedMinutesForDelivery != null &&
                    this.EstimatedMinutesForDelivery.Equals(input.EstimatedMinutesForDelivery))
                ) && 
                (
                    this.EstimatedMinutesForCollection == input.EstimatedMinutesForCollection ||
                    (this.EstimatedMinutesForCollection != null &&
                    this.EstimatedMinutesForCollection.Equals(input.EstimatedMinutesForCollection))
                ) && 
                (
                    this.GeographicLocation == input.GeographicLocation ||
                    (this.GeographicLocation != null &&
                    this.GeographicLocation.Equals(input.GeographicLocation))
                ) && 
                (
                    this.Establishment == input.Establishment ||
                    (this.Establishment != null &&
                    this.Establishment.Equals(input.Establishment))
                ) && 
                (
                    this.VoucherId == input.VoucherId ||
                    (this.VoucherId != null &&
                    this.VoucherId.Equals(input.VoucherId))
                ) && 
                (
                    this.DeliveryFeeId == input.DeliveryFeeId ||
                    (this.DeliveryFeeId != null &&
                    this.DeliveryFeeId.Equals(input.DeliveryFeeId))
                ) && 
                (
                    this.ProcessingFeeId == input.ProcessingFeeId ||
                    (this.ProcessingFeeId != null &&
                    this.ProcessingFeeId.Equals(input.ProcessingFeeId))
                ) && 
                (
                    this.PriceType == input.PriceType ||
                    (this.PriceType != null &&
                    this.PriceType.Equals(input.PriceType))
                ) && 
                (
                    this.MenuId == input.MenuId ||
                    (this.MenuId != null &&
                    this.MenuId.Equals(input.MenuId))
                ) && 
                (
                    this.CollectionTableId == input.CollectionTableId ||
                    (this.CollectionTableId != null &&
                    this.CollectionTableId.Equals(input.CollectionTableId))
                ) && 
                (
                    this.DeliveryTableId == input.DeliveryTableId ||
                    (this.DeliveryTableId != null &&
                    this.DeliveryTableId.Equals(input.DeliveryTableId))
                ) && 
                (
                    this.CollectionTableIds == input.CollectionTableIds ||
                    this.CollectionTableIds != null &&
                    this.CollectionTableIds.SequenceEqual(input.CollectionTableIds)
                ) && 
                (
                    this.DeliveryTableIds == input.DeliveryTableIds ||
                    this.DeliveryTableIds != null &&
                    this.DeliveryTableIds.SequenceEqual(input.DeliveryTableIds)
                ) && 
                (
                    this.UseTaxInclusivePrices == input.UseTaxInclusivePrices ||
                    (this.UseTaxInclusivePrices != null &&
                    this.UseTaxInclusivePrices.Equals(input.UseTaxInclusivePrices))
                ) && 
                (
                    this.SkipStatusCheckAndAcceptOrderAfterSending == input.SkipStatusCheckAndAcceptOrderAfterSending ||
                    (this.SkipStatusCheckAndAcceptOrderAfterSending != null &&
                    this.SkipStatusCheckAndAcceptOrderAfterSending.Equals(input.SkipStatusCheckAndAcceptOrderAfterSending))
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
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.UseOAuth != null)
                    hashCode = hashCode * 59 + this.UseOAuth.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.EstimatedMinutesForDelivery != null)
                    hashCode = hashCode * 59 + this.EstimatedMinutesForDelivery.GetHashCode();
                if (this.EstimatedMinutesForCollection != null)
                    hashCode = hashCode * 59 + this.EstimatedMinutesForCollection.GetHashCode();
                if (this.GeographicLocation != null)
                    hashCode = hashCode * 59 + this.GeographicLocation.GetHashCode();
                if (this.Establishment != null)
                    hashCode = hashCode * 59 + this.Establishment.GetHashCode();
                if (this.VoucherId != null)
                    hashCode = hashCode * 59 + this.VoucherId.GetHashCode();
                if (this.DeliveryFeeId != null)
                    hashCode = hashCode * 59 + this.DeliveryFeeId.GetHashCode();
                if (this.ProcessingFeeId != null)
                    hashCode = hashCode * 59 + this.ProcessingFeeId.GetHashCode();
                if (this.PriceType != null)
                    hashCode = hashCode * 59 + this.PriceType.GetHashCode();
                if (this.MenuId != null)
                    hashCode = hashCode * 59 + this.MenuId.GetHashCode();
                if (this.CollectionTableId != null)
                    hashCode = hashCode * 59 + this.CollectionTableId.GetHashCode();
                if (this.DeliveryTableId != null)
                    hashCode = hashCode * 59 + this.DeliveryTableId.GetHashCode();
                if (this.CollectionTableIds != null)
                    hashCode = hashCode * 59 + this.CollectionTableIds.GetHashCode();
                if (this.DeliveryTableIds != null)
                    hashCode = hashCode * 59 + this.DeliveryTableIds.GetHashCode();
                if (this.UseTaxInclusivePrices != null)
                    hashCode = hashCode * 59 + this.UseTaxInclusivePrices.GetHashCode();
                if (this.SkipStatusCheckAndAcceptOrderAfterSending != null)
                    hashCode = hashCode * 59 + this.SkipStatusCheckAndAcceptOrderAfterSending.GetHashCode();
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
