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
    /// Application Configuration Summary  &lt;remarks&gt;Header information for display in lists, like list of apps&lt;/remarks&gt;
    /// </summary>
    [DataContract]
    public partial class AppConfigurationSummary :  IEquatable<AppConfigurationSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppConfigurationSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppConfigurationSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppConfigurationSummary" /> class.
        /// </summary>
        /// <param name="id">Application Configuration Public Id (required).</param>
        /// <param name="appId">Whitelabel App Id (required).</param>
        /// <param name="appStoreAppId">App Store App Id (required).</param>
        /// <param name="isEnabled">Is Enabled (required).</param>
        /// <param name="physicalRestaurants">List of restaurants (required).</param>
        public AppConfigurationSummary(string id = default(string), string appId = default(string), string appStoreAppId = default(string), bool? isEnabled = default(bool?), List<ConfiguredPhysicalRestaurant> physicalRestaurants = default(List<ConfiguredPhysicalRestaurant>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for AppConfigurationSummary and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "appId" is required (not null)
            if (appId == null)
            {
                throw new InvalidDataException("appId is a required property for AppConfigurationSummary and cannot be null");
            }
            else
            {
                this.AppId = appId;
            }
            // to ensure "appStoreAppId" is required (not null)
            if (appStoreAppId == null)
            {
                throw new InvalidDataException("appStoreAppId is a required property for AppConfigurationSummary and cannot be null");
            }
            else
            {
                this.AppStoreAppId = appStoreAppId;
            }
            // to ensure "isEnabled" is required (not null)
            if (isEnabled == null)
            {
                throw new InvalidDataException("isEnabled is a required property for AppConfigurationSummary and cannot be null");
            }
            else
            {
                this.IsEnabled = isEnabled;
            }
            // to ensure "physicalRestaurants" is required (not null)
            if (physicalRestaurants == null)
            {
                throw new InvalidDataException("physicalRestaurants is a required property for AppConfigurationSummary and cannot be null");
            }
            else
            {
                this.PhysicalRestaurants = physicalRestaurants;
            }
        }
        
        /// <summary>
        /// Application Configuration Public Id
        /// </summary>
        /// <value>Application Configuration Public Id</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Whitelabel App Id
        /// </summary>
        /// <value>Whitelabel App Id</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// App Store App Id
        /// </summary>
        /// <value>App Store App Id</value>
        [DataMember(Name="AppStoreAppId", EmitDefaultValue=false)]
        public string AppStoreAppId { get; set; }

        /// <summary>
        /// Is Enabled
        /// </summary>
        /// <value>Is Enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// List of restaurants
        /// </summary>
        /// <value>List of restaurants</value>
        [DataMember(Name="PhysicalRestaurants", EmitDefaultValue=false)]
        public List<ConfiguredPhysicalRestaurant> PhysicalRestaurants { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppConfigurationSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  AppStoreAppId: ").Append(AppStoreAppId).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  PhysicalRestaurants: ").Append(PhysicalRestaurants).Append("\n");
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
            return this.Equals(input as AppConfigurationSummary);
        }

        /// <summary>
        /// Returns true if AppConfigurationSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of AppConfigurationSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppConfigurationSummary input)
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
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.AppStoreAppId == input.AppStoreAppId ||
                    (this.AppStoreAppId != null &&
                    this.AppStoreAppId.Equals(input.AppStoreAppId))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.PhysicalRestaurants == input.PhysicalRestaurants ||
                    this.PhysicalRestaurants != null &&
                    this.PhysicalRestaurants.SequenceEqual(input.PhysicalRestaurants)
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppStoreAppId != null)
                    hashCode = hashCode * 59 + this.AppStoreAppId.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.PhysicalRestaurants != null)
                    hashCode = hashCode * 59 + this.PhysicalRestaurants.GetHashCode();
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
