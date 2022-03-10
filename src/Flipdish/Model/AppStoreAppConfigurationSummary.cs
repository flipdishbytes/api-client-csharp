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
    /// App store app configuration summary information
    /// </summary>
    [DataContract]
    public partial class AppStoreAppConfigurationSummary :  IEquatable<AppStoreAppConfigurationSummary>, IValidatableObject
    {
        /// <summary>
        /// Configuration type
        /// </summary>
        /// <value>Configuration type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConfigurationTypeEnum
        {
            
            /// <summary>
            /// Enum ExternalLink for value: ExternalLink
            /// </summary>
            [EnumMember(Value = "ExternalLink")]
            ExternalLink = 1,
            
            /// <summary>
            /// Enum FlipdishHosted for value: FlipdishHosted
            /// </summary>
            [EnumMember(Value = "FlipdishHosted")]
            FlipdishHosted = 2
        }

        /// <summary>
        /// Configuration type
        /// </summary>
        /// <value>Configuration type</value>
        [DataMember(Name="ConfigurationType", EmitDefaultValue=false)]
        public ConfigurationTypeEnum? ConfigurationType { get; set; }
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
        /// Initializes a new instance of the <see cref="AppStoreAppConfigurationSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppStoreAppConfigurationSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreAppConfigurationSummary" /> class.
        /// </summary>
        /// <param name="id">Unique App store app configuration id (required).</param>
        /// <param name="appId">App Id (required).</param>
        /// <param name="isEnabled">Is enabled (required).</param>
        /// <param name="physicalRestaurants">List of stores (required).</param>
        /// <param name="configurationType">Configuration type.</param>
        /// <param name="storeSelectorType">Store selector type.</param>
        /// <param name="appStoreAppId">Unique App store app id (required).</param>
        /// <param name="name">Name of Appstore app (required).</param>
        /// <param name="description">Description (required).</param>
        /// <param name="logo">Logo.</param>
        /// <param name="developerName">Developer name.</param>
        public AppStoreAppConfigurationSummary(string id = default(string), string appId = default(string), bool? isEnabled = default(bool?), List<ConfiguredPhysicalRestaurant> physicalRestaurants = default(List<ConfiguredPhysicalRestaurant>), ConfigurationTypeEnum? configurationType = default(ConfigurationTypeEnum?), StoreSelectorTypeEnum? storeSelectorType = default(StoreSelectorTypeEnum?), string appStoreAppId = default(string), string name = default(string), string description = default(string), string logo = default(string), string developerName = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for AppStoreAppConfigurationSummary and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "appId" is required (not null)
            if (appId == null)
            {
                throw new InvalidDataException("appId is a required property for AppStoreAppConfigurationSummary and cannot be null");
            }
            else
            {
                this.AppId = appId;
            }
            // to ensure "isEnabled" is required (not null)
            if (isEnabled == null)
            {
                throw new InvalidDataException("isEnabled is a required property for AppStoreAppConfigurationSummary and cannot be null");
            }
            else
            {
                this.IsEnabled = isEnabled;
            }
            // to ensure "physicalRestaurants" is required (not null)
            if (physicalRestaurants == null)
            {
                throw new InvalidDataException("physicalRestaurants is a required property for AppStoreAppConfigurationSummary and cannot be null");
            }
            else
            {
                this.PhysicalRestaurants = physicalRestaurants;
            }
            // to ensure "appStoreAppId" is required (not null)
            if (appStoreAppId == null)
            {
                throw new InvalidDataException("appStoreAppId is a required property for AppStoreAppConfigurationSummary and cannot be null");
            }
            else
            {
                this.AppStoreAppId = appStoreAppId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AppStoreAppConfigurationSummary and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for AppStoreAppConfigurationSummary and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            this.ConfigurationType = configurationType;
            this.StoreSelectorType = storeSelectorType;
            this.Logo = logo;
            this.DeveloperName = developerName;
        }
        
        /// <summary>
        /// Unique App store app configuration id
        /// </summary>
        /// <value>Unique App store app configuration id</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// App Id
        /// </summary>
        /// <value>App Id</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Is enabled
        /// </summary>
        /// <value>Is enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// List of stores
        /// </summary>
        /// <value>List of stores</value>
        [DataMember(Name="PhysicalRestaurants", EmitDefaultValue=false)]
        public List<ConfiguredPhysicalRestaurant> PhysicalRestaurants { get; set; }



        /// <summary>
        /// Unique App store app id
        /// </summary>
        /// <value>Unique App store app id</value>
        [DataMember(Name="AppStoreAppId", EmitDefaultValue=false)]
        public string AppStoreAppId { get; set; }

        /// <summary>
        /// Name of Appstore app
        /// </summary>
        /// <value>Name of Appstore app</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Logo
        /// </summary>
        /// <value>Logo</value>
        [DataMember(Name="Logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// Developer name
        /// </summary>
        /// <value>Developer name</value>
        [DataMember(Name="DeveloperName", EmitDefaultValue=false)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppStoreAppConfigurationSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  PhysicalRestaurants: ").Append(PhysicalRestaurants).Append("\n");
            sb.Append("  ConfigurationType: ").Append(ConfigurationType).Append("\n");
            sb.Append("  StoreSelectorType: ").Append(StoreSelectorType).Append("\n");
            sb.Append("  AppStoreAppId: ").Append(AppStoreAppId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  DeveloperName: ").Append(DeveloperName).Append("\n");
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
            return this.Equals(input as AppStoreAppConfigurationSummary);
        }

        /// <summary>
        /// Returns true if AppStoreAppConfigurationSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreAppConfigurationSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreAppConfigurationSummary input)
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
                    this.ConfigurationType == input.ConfigurationType ||
                    (this.ConfigurationType != null &&
                    this.ConfigurationType.Equals(input.ConfigurationType))
                ) && 
                (
                    this.StoreSelectorType == input.StoreSelectorType ||
                    (this.StoreSelectorType != null &&
                    this.StoreSelectorType.Equals(input.StoreSelectorType))
                ) && 
                (
                    this.AppStoreAppId == input.AppStoreAppId ||
                    (this.AppStoreAppId != null &&
                    this.AppStoreAppId.Equals(input.AppStoreAppId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.DeveloperName == input.DeveloperName ||
                    (this.DeveloperName != null &&
                    this.DeveloperName.Equals(input.DeveloperName))
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
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.PhysicalRestaurants != null)
                    hashCode = hashCode * 59 + this.PhysicalRestaurants.GetHashCode();
                if (this.ConfigurationType != null)
                    hashCode = hashCode * 59 + this.ConfigurationType.GetHashCode();
                if (this.StoreSelectorType != null)
                    hashCode = hashCode * 59 + this.StoreSelectorType.GetHashCode();
                if (this.AppStoreAppId != null)
                    hashCode = hashCode * 59 + this.AppStoreAppId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.DeveloperName != null)
                    hashCode = hashCode * 59 + this.DeveloperName.GetHashCode();
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
