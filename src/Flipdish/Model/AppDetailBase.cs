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
    /// Application Detail Base  &lt;remarks&gt;Used for creating new apps&lt;/remarks&gt;
    /// </summary>
    [DataContract]
    public partial class AppDetailBase :  IEquatable<AppDetailBase>, IValidatableObject
    {
        /// <summary>
        /// Configuration Type  &lt;example&gt;ExternalLink&lt;/example&gt;&lt;example&gt;FlipdishHosted&lt;/example&gt;
        /// </summary>
        /// <value>Configuration Type  &lt;example&gt;ExternalLink&lt;/example&gt;&lt;example&gt;FlipdishHosted&lt;/example&gt;</value>
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
        /// Configuration Type  &lt;example&gt;ExternalLink&lt;/example&gt;&lt;example&gt;FlipdishHosted&lt;/example&gt;
        /// </summary>
        /// <value>Configuration Type  &lt;example&gt;ExternalLink&lt;/example&gt;&lt;example&gt;FlipdishHosted&lt;/example&gt;</value>
        [DataMember(Name="ConfigurationType", EmitDefaultValue=false)]
        public ConfigurationTypeEnum ConfigurationType { get; set; }
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
        public StoreSelectorTypeEnum StoreSelectorType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppDetailBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppDetailBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppDetailBase" /> class.
        /// </summary>
        /// <param name="configurationType">Configuration Type  &lt;example&gt;ExternalLink&lt;/example&gt;&lt;example&gt;FlipdishHosted&lt;/example&gt; (required).</param>
        /// <param name="storeSelectorType">Store Selector Type (required).</param>
        /// <param name="fieldGroups">Field Groups.</param>
        /// <param name="name">Name (required).</param>
        /// <param name="description">Description (required).</param>
        /// <param name="logo">Logo.</param>
        /// <param name="isEnabled">Is application enabled.</param>
        /// <param name="isVerified">Is application verified for use in the App Store.</param>
        /// <param name="tags">Tags (required).</param>
        /// <param name="regions">Regions (required).</param>
        public AppDetailBase(ConfigurationTypeEnum configurationType = default(ConfigurationTypeEnum), StoreSelectorTypeEnum storeSelectorType = default(StoreSelectorTypeEnum), List<FieldGroup> fieldGroups = default(List<FieldGroup>), string name = default(string), string description = default(string), string logo = default(string), bool? isEnabled = default(bool?), bool? isVerified = default(bool?), List<string> tags = default(List<string>), List<string> regions = default(List<string>))
        {
            // to ensure "configurationType" is required (not null)
            if (configurationType == null)
            {
                throw new InvalidDataException("configurationType is a required property for AppDetailBase and cannot be null");
            }
            else
            {
                this.ConfigurationType = configurationType;
            }
            // to ensure "storeSelectorType" is required (not null)
            if (storeSelectorType == null)
            {
                throw new InvalidDataException("storeSelectorType is a required property for AppDetailBase and cannot be null");
            }
            else
            {
                this.StoreSelectorType = storeSelectorType;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AppDetailBase and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for AppDetailBase and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for AppDetailBase and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }
            // to ensure "regions" is required (not null)
            if (regions == null)
            {
                throw new InvalidDataException("regions is a required property for AppDetailBase and cannot be null");
            }
            else
            {
                this.Regions = regions;
            }
            this.FieldGroups = fieldGroups;
            this.Logo = logo;
            this.IsEnabled = isEnabled;
            this.IsVerified = isVerified;
        }
        


        /// <summary>
        /// Field Groups
        /// </summary>
        /// <value>Field Groups</value>
        [DataMember(Name="FieldGroups", EmitDefaultValue=false)]
        public List<FieldGroup> FieldGroups { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
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
        /// Is application enabled
        /// </summary>
        /// <value>Is application enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Is application verified for use in the App Store
        /// </summary>
        /// <value>Is application verified for use in the App Store</value>
        [DataMember(Name="IsVerified", EmitDefaultValue=false)]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        /// <value>Tags</value>
        [DataMember(Name="Tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Regions
        /// </summary>
        /// <value>Regions</value>
        [DataMember(Name="Regions", EmitDefaultValue=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppDetailBase {\n");
            sb.Append("  ConfigurationType: ").Append(ConfigurationType).Append("\n");
            sb.Append("  StoreSelectorType: ").Append(StoreSelectorType).Append("\n");
            sb.Append("  FieldGroups: ").Append(FieldGroups).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Regions: ").Append(Regions).Append("\n");
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
            return this.Equals(input as AppDetailBase);
        }

        /// <summary>
        /// Returns true if AppDetailBase instances are equal
        /// </summary>
        /// <param name="input">Instance of AppDetailBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppDetailBase input)
        {
            if (input == null)
                return false;

            return 
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
                    this.FieldGroups == input.FieldGroups ||
                    this.FieldGroups != null &&
                    this.FieldGroups.SequenceEqual(input.FieldGroups)
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
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.IsVerified == input.IsVerified ||
                    (this.IsVerified != null &&
                    this.IsVerified.Equals(input.IsVerified))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Regions == input.Regions ||
                    this.Regions != null &&
                    this.Regions.SequenceEqual(input.Regions)
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
                if (this.ConfigurationType != null)
                    hashCode = hashCode * 59 + this.ConfigurationType.GetHashCode();
                if (this.StoreSelectorType != null)
                    hashCode = hashCode * 59 + this.StoreSelectorType.GetHashCode();
                if (this.FieldGroups != null)
                    hashCode = hashCode * 59 + this.FieldGroups.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.IsVerified != null)
                    hashCode = hashCode * 59 + this.IsVerified.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Regions != null)
                    hashCode = hashCode * 59 + this.Regions.GetHashCode();
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
