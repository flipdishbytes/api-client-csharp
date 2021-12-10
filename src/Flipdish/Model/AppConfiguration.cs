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
    /// AppConfiguration
    /// </summary>
    [DataContract]
    public partial class AppConfiguration :  IEquatable<AppConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppConfiguration" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="physicalRestaurants">physicalRestaurants.</param>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="settings">settings.</param>
        public AppConfiguration(string id = default(string), List<int?> physicalRestaurants = default(List<int?>), bool? isEnabled = default(bool?), List<AppConfigurationSetting> settings = default(List<AppConfigurationSetting>))
        {
            this.Id = id;
            this.PhysicalRestaurants = physicalRestaurants;
            this.IsEnabled = isEnabled;
            this.Settings = settings;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalRestaurants
        /// </summary>
        [DataMember(Name="PhysicalRestaurants", EmitDefaultValue=false)]
        public List<int?> PhysicalRestaurants { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="Settings", EmitDefaultValue=false)]
        public List<AppConfigurationSetting> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppConfiguration {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PhysicalRestaurants: ").Append(PhysicalRestaurants).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
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
            return this.Equals(input as AppConfiguration);
        }

        /// <summary>
        /// Returns true if AppConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of AppConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PhysicalRestaurants == input.PhysicalRestaurants ||
                    this.PhysicalRestaurants != null &&
                    this.PhysicalRestaurants.SequenceEqual(input.PhysicalRestaurants)
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PhysicalRestaurants != null)
                    hashCode = hashCode * 59 + this.PhysicalRestaurants.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
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
