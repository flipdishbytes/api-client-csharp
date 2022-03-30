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
    /// Update App store app configuration
    /// </summary>
    [DataContract]
    public partial class UpdateAppStoreAppConfiguration :  IEquatable<UpdateAppStoreAppConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppStoreAppConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAppStoreAppConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppStoreAppConfiguration" /> class.
        /// </summary>
        /// <param name="isEnabled">Is enabled (required).</param>
        /// <param name="physicalRestaurants">Stores id&#39;s.</param>
        /// <param name="settings">Settings.</param>
        public UpdateAppStoreAppConfiguration(bool? isEnabled = default(bool?), List<int?> physicalRestaurants = default(List<int?>), List<Setting> settings = default(List<Setting>))
        {
            // to ensure "isEnabled" is required (not null)
            if (isEnabled == null)
            {
                throw new InvalidDataException("isEnabled is a required property for UpdateAppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.IsEnabled = isEnabled;
            }
            this.PhysicalRestaurants = physicalRestaurants;
            this.Settings = settings;
        }
        
        /// <summary>
        /// Is enabled
        /// </summary>
        /// <value>Is enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Stores id&#39;s
        /// </summary>
        /// <value>Stores id&#39;s</value>
        [DataMember(Name="PhysicalRestaurants", EmitDefaultValue=false)]
        public List<int?> PhysicalRestaurants { get; set; }

        /// <summary>
        /// Settings
        /// </summary>
        /// <value>Settings</value>
        [DataMember(Name="Settings", EmitDefaultValue=false)]
        public List<Setting> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAppStoreAppConfiguration {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  PhysicalRestaurants: ").Append(PhysicalRestaurants).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as UpdateAppStoreAppConfiguration);
        }

        /// <summary>
        /// Returns true if UpdateAppStoreAppConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAppStoreAppConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAppStoreAppConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.PhysicalRestaurants == input.PhysicalRestaurants ||
                    this.PhysicalRestaurants != null &&
                    this.PhysicalRestaurants.SequenceEqual(input.PhysicalRestaurants)
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
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
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.PhysicalRestaurants != null)
                    hashCode = hashCode * 59 + this.PhysicalRestaurants.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
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