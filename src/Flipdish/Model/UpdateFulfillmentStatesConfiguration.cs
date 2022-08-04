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
    /// Update fulfillment states configuration
    /// </summary>
    [DataContract]
    public partial class UpdateFulfillmentStatesConfiguration :  IEquatable<UpdateFulfillmentStatesConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Store Selector Type
        /// </summary>
        /// <value>Store Selector Type</value>
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
        /// Store Selector Type
        /// </summary>
        /// <value>Store Selector Type</value>
        [DataMember(Name="StoreSelectorType", EmitDefaultValue=false)]
        public StoreSelectorTypeEnum? StoreSelectorType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFulfillmentStatesConfiguration" /> class.
        /// </summary>
        /// <param name="storeIds">Stores id&#39;s.</param>
        /// <param name="storeSelectorType">Store Selector Type.</param>
        /// <param name="states">Settings.</param>
        /// <param name="name">Name.</param>
        public UpdateFulfillmentStatesConfiguration(List<int?> storeIds = default(List<int?>), StoreSelectorTypeEnum? storeSelectorType = default(StoreSelectorTypeEnum?), List<FulfillmentStatusConfigurationItem> states = default(List<FulfillmentStatusConfigurationItem>), string name = default(string))
        {
            this.StoreIds = storeIds;
            this.StoreSelectorType = storeSelectorType;
            this.States = states;
            this.Name = name;
        }
        
        /// <summary>
        /// Stores id&#39;s
        /// </summary>
        /// <value>Stores id&#39;s</value>
        [DataMember(Name="StoreIds", EmitDefaultValue=false)]
        public List<int?> StoreIds { get; set; }


        /// <summary>
        /// Settings
        /// </summary>
        /// <value>Settings</value>
        [DataMember(Name="States", EmitDefaultValue=false)]
        public List<FulfillmentStatusConfigurationItem> States { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFulfillmentStatesConfiguration {\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
            sb.Append("  StoreSelectorType: ").Append(StoreSelectorType).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as UpdateFulfillmentStatesConfiguration);
        }

        /// <summary>
        /// Returns true if UpdateFulfillmentStatesConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateFulfillmentStatesConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateFulfillmentStatesConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
                ) && 
                (
                    this.StoreSelectorType == input.StoreSelectorType ||
                    (this.StoreSelectorType != null &&
                    this.StoreSelectorType.Equals(input.StoreSelectorType))
                ) && 
                (
                    this.States == input.States ||
                    this.States != null &&
                    this.States.SequenceEqual(input.States)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.StoreIds != null)
                    hashCode = hashCode * 59 + this.StoreIds.GetHashCode();
                if (this.StoreSelectorType != null)
                    hashCode = hashCode * 59 + this.StoreSelectorType.GetHashCode();
                if (this.States != null)
                    hashCode = hashCode * 59 + this.States.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
