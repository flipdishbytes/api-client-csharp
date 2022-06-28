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
    /// App store app configuration header information
    /// </summary>
    [DataContract]
    public partial class FulfillmentStatesConfigurationSummary :  IEquatable<FulfillmentStatesConfigurationSummary>, IValidatableObject
    {
        /// <summary>
        /// Store selector type
        /// </summary>
        /// <value>Store selector type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StoreSelectorTypeEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Single for value: Single
            /// </summary>
            [EnumMember(Value = "Single")]
            Single = 2,
            
            /// <summary>
            /// Enum Multiple for value: Multiple
            /// </summary>
            [EnumMember(Value = "Multiple")]
            Multiple = 3
        }

        /// <summary>
        /// Store selector type
        /// </summary>
        /// <value>Store selector type</value>
        [DataMember(Name="StoreSelectorType", EmitDefaultValue=false)]
        public StoreSelectorTypeEnum? StoreSelectorType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentStatesConfigurationSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FulfillmentStatesConfigurationSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentStatesConfigurationSummary" /> class.
        /// </summary>
        /// <param name="appId">AppId (required).</param>
        /// <param name="configurationUid">Configuration Uid.</param>
        /// <param name="storeSelectorType">Store selector type.</param>
        /// <param name="stores">Stores.</param>
        public FulfillmentStatesConfigurationSummary(string appId = default(string), string configurationUid = default(string), StoreSelectorTypeEnum? storeSelectorType = default(StoreSelectorTypeEnum?), List<FulfillmentStatesConfiguredStore> stores = default(List<FulfillmentStatesConfiguredStore>))
        {
            // to ensure "appId" is required (not null)
            if (appId == null)
            {
                throw new InvalidDataException("appId is a required property for FulfillmentStatesConfigurationSummary and cannot be null");
            }
            else
            {
                this.AppId = appId;
            }
            this.ConfigurationUid = configurationUid;
            this.StoreSelectorType = storeSelectorType;
            this.Stores = stores;
        }
        
        /// <summary>
        /// AppId
        /// </summary>
        /// <value>AppId</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Configuration Uid
        /// </summary>
        /// <value>Configuration Uid</value>
        [DataMember(Name="ConfigurationUid", EmitDefaultValue=false)]
        public string ConfigurationUid { get; set; }


        /// <summary>
        /// Stores
        /// </summary>
        /// <value>Stores</value>
        [DataMember(Name="Stores", EmitDefaultValue=false)]
        public List<FulfillmentStatesConfiguredStore> Stores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentStatesConfigurationSummary {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  ConfigurationUid: ").Append(ConfigurationUid).Append("\n");
            sb.Append("  StoreSelectorType: ").Append(StoreSelectorType).Append("\n");
            sb.Append("  Stores: ").Append(Stores).Append("\n");
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
            return this.Equals(input as FulfillmentStatesConfigurationSummary);
        }

        /// <summary>
        /// Returns true if FulfillmentStatesConfigurationSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentStatesConfigurationSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentStatesConfigurationSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.ConfigurationUid == input.ConfigurationUid ||
                    (this.ConfigurationUid != null &&
                    this.ConfigurationUid.Equals(input.ConfigurationUid))
                ) && 
                (
                    this.StoreSelectorType == input.StoreSelectorType ||
                    (this.StoreSelectorType != null &&
                    this.StoreSelectorType.Equals(input.StoreSelectorType))
                ) && 
                (
                    this.Stores == input.Stores ||
                    this.Stores != null &&
                    this.Stores.SequenceEqual(input.Stores)
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.ConfigurationUid != null)
                    hashCode = hashCode * 59 + this.ConfigurationUid.GetHashCode();
                if (this.StoreSelectorType != null)
                    hashCode = hashCode * 59 + this.StoreSelectorType.GetHashCode();
                if (this.Stores != null)
                    hashCode = hashCode * 59 + this.Stores.GetHashCode();
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
