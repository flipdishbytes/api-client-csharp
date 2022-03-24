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
    /// Create App store app
    /// </summary>
    [DataContract]
    public partial class CreateAppStoreApp :  IEquatable<CreateAppStoreApp>, IValidatableObject
    {
        /// <summary>
        /// Configuration type  &lt;example&gt;External link&lt;/example&gt;&lt;example&gt;Flipdish hosted&lt;/example&gt;
        /// </summary>
        /// <value>Configuration type  &lt;example&gt;External link&lt;/example&gt;&lt;example&gt;Flipdish hosted&lt;/example&gt;</value>
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
        /// Configuration type  &lt;example&gt;External link&lt;/example&gt;&lt;example&gt;Flipdish hosted&lt;/example&gt;
        /// </summary>
        /// <value>Configuration type  &lt;example&gt;External link&lt;/example&gt;&lt;example&gt;Flipdish hosted&lt;/example&gt;</value>
        [DataMember(Name="ConfigurationType", EmitDefaultValue=false)]
        public ConfigurationTypeEnum ConfigurationType { get; set; }
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
        public StoreSelectorTypeEnum StoreSelectorType { get; set; }
        /// <summary>
        /// Teammate app access level
        /// </summary>
        /// <value>Teammate app access level</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TeammateAppAccessLevelEnum
        {
            
            /// <summary>
            /// Enum Owner for value: Owner
            /// </summary>
            [EnumMember(Value = "Owner")]
            Owner = 1,
            
            /// <summary>
            /// Enum StoreOwner for value: StoreOwner
            /// </summary>
            [EnumMember(Value = "StoreOwner")]
            StoreOwner = 2,
            
            /// <summary>
            /// Enum ManagedOwner for value: ManagedOwner
            /// </summary>
            [EnumMember(Value = "ManagedOwner")]
            ManagedOwner = 3,
            
            /// <summary>
            /// Enum Integrator for value: Integrator
            /// </summary>
            [EnumMember(Value = "Integrator")]
            Integrator = 4,
            
            /// <summary>
            /// Enum StoreManager for value: StoreManager
            /// </summary>
            [EnumMember(Value = "StoreManager")]
            StoreManager = 5,
            
            /// <summary>
            /// Enum StoreStaff for value: StoreStaff
            /// </summary>
            [EnumMember(Value = "StoreStaff")]
            StoreStaff = 6,
            
            /// <summary>
            /// Enum StoreReadOnlyAccess for value: StoreReadOnlyAccess
            /// </summary>
            [EnumMember(Value = "StoreReadOnlyAccess")]
            StoreReadOnlyAccess = 7,
            
            /// <summary>
            /// Enum FinanceManger for value: FinanceManger
            /// </summary>
            [EnumMember(Value = "FinanceManger")]
            FinanceManger = 8
        }

        /// <summary>
        /// Teammate app access level
        /// </summary>
        /// <value>Teammate app access level</value>
        [DataMember(Name="TeammateAppAccessLevel", EmitDefaultValue=false)]
        public TeammateAppAccessLevelEnum? TeammateAppAccessLevel { get; set; }
        /// <summary>
        /// Permissions type
        /// </summary>
        /// <value>Permissions type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionsTypeEnum
        {
            
            /// <summary>
            /// Enum Teammate for value: Teammate
            /// </summary>
            [EnumMember(Value = "Teammate")]
            Teammate = 1
        }

        /// <summary>
        /// Permissions type
        /// </summary>
        /// <value>Permissions type</value>
        [DataMember(Name="PermissionsType", EmitDefaultValue=false)]
        public PermissionsTypeEnum PermissionsType { get; set; }
        /// <summary>
        /// Defines Tags
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TagsEnum
        {
            
            /// <summary>
            /// Enum PointOfSale for value: PointOfSale
            /// </summary>
            [EnumMember(Value = "PointOfSale")]
            PointOfSale = 1,
            
            /// <summary>
            /// Enum DeliveryAndLogistics for value: DeliveryAndLogistics
            /// </summary>
            [EnumMember(Value = "DeliveryAndLogistics")]
            DeliveryAndLogistics = 2,
            
            /// <summary>
            /// Enum CRM for value: CRM
            /// </summary>
            [EnumMember(Value = "CRM")]
            CRM = 3,
            
            /// <summary>
            /// Enum GiftCard for value: GiftCard
            /// </summary>
            [EnumMember(Value = "GiftCard")]
            GiftCard = 4,
            
            /// <summary>
            /// Enum Accounting for value: Accounting
            /// </summary>
            [EnumMember(Value = "Accounting")]
            Accounting = 5,
            
            /// <summary>
            /// Enum LoyaltyAndMarketing for value: LoyaltyAndMarketing
            /// </summary>
            [EnumMember(Value = "LoyaltyAndMarketing")]
            LoyaltyAndMarketing = 6,
            
            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 7
        }


        /// <summary>
        /// Tags
        /// </summary>
        /// <value>Tags</value>
        [DataMember(Name="Tags", EmitDefaultValue=false)]
        public List<TagsEnum> Tags { get; set; }
        /// <summary>
        /// Defines Regions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RegionsEnum
        {
            
            /// <summary>
            /// Enum GB for value: GB
            /// </summary>
            [EnumMember(Value = "GB")]
            GB = 1,
            
            /// <summary>
            /// Enum IE for value: IE
            /// </summary>
            [EnumMember(Value = "IE")]
            IE = 2,
            
            /// <summary>
            /// Enum FR for value: FR
            /// </summary>
            [EnumMember(Value = "FR")]
            FR = 3,
            
            /// <summary>
            /// Enum ES for value: ES
            /// </summary>
            [EnumMember(Value = "ES")]
            ES = 4,
            
            /// <summary>
            /// Enum PT for value: PT
            /// </summary>
            [EnumMember(Value = "PT")]
            PT = 5,
            
            /// <summary>
            /// Enum IT for value: IT
            /// </summary>
            [EnumMember(Value = "IT")]
            IT = 6,
            
            /// <summary>
            /// Enum DE for value: DE
            /// </summary>
            [EnumMember(Value = "DE")]
            DE = 7,
            
            /// <summary>
            /// Enum PL for value: PL
            /// </summary>
            [EnumMember(Value = "PL")]
            PL = 8,
            
            /// <summary>
            /// Enum BE for value: BE
            /// </summary>
            [EnumMember(Value = "BE")]
            BE = 9,
            
            /// <summary>
            /// Enum LU for value: LU
            /// </summary>
            [EnumMember(Value = "LU")]
            LU = 10,
            
            /// <summary>
            /// Enum NL for value: NL
            /// </summary>
            [EnumMember(Value = "NL")]
            NL = 11,
            
            /// <summary>
            /// Enum US for value: US
            /// </summary>
            [EnumMember(Value = "US")]
            US = 12,
            
            /// <summary>
            /// Enum CA for value: CA
            /// </summary>
            [EnumMember(Value = "CA")]
            CA = 13,
            
            /// <summary>
            /// Enum BG for value: BG
            /// </summary>
            [EnumMember(Value = "BG")]
            BG = 14,
            
            /// <summary>
            /// Enum MX for value: MX
            /// </summary>
            [EnumMember(Value = "MX")]
            MX = 15,
            
            /// <summary>
            /// Enum AU for value: AU
            /// </summary>
            [EnumMember(Value = "AU")]
            AU = 16,
            
            /// <summary>
            /// Enum NZ for value: NZ
            /// </summary>
            [EnumMember(Value = "NZ")]
            NZ = 17
        }


        /// <summary>
        /// Regions
        /// </summary>
        /// <value>Regions</value>
        [DataMember(Name="Regions", EmitDefaultValue=false)]
        public List<RegionsEnum> Regions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppStoreApp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAppStoreApp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppStoreApp" /> class.
        /// </summary>
        /// <param name="details">Details (required).</param>
        /// <param name="configurationType">Configuration type  &lt;example&gt;External link&lt;/example&gt;&lt;example&gt;Flipdish hosted&lt;/example&gt; (required).</param>
        /// <param name="storeSelectorType">Store selector type (required).</param>
        /// <param name="fieldGroups">Field groups.</param>
        /// <param name="setupInstructions">Setup instructions.</param>
        /// <param name="externalSetupLink">External setup link.</param>
        /// <param name="oAuthAppId">OAuth app id (required).</param>
        /// <param name="teammateAppAccessLevel">Teammate app access level.</param>
        /// <param name="permissionsType">Permissions type (required).</param>
        /// <param name="name">Name (required).</param>
        /// <param name="description">Description (required).</param>
        /// <param name="isEnabled">Is application enabled.</param>
        /// <param name="tags">Tags (required).</param>
        /// <param name="regions">Regions (required).</param>
        /// <param name="developerName">Developer Name.</param>
        public CreateAppStoreApp(string details = default(string), ConfigurationTypeEnum configurationType = default(ConfigurationTypeEnum), StoreSelectorTypeEnum storeSelectorType = default(StoreSelectorTypeEnum), List<FieldGroup> fieldGroups = default(List<FieldGroup>), string setupInstructions = default(string), string externalSetupLink = default(string), string oAuthAppId = default(string), TeammateAppAccessLevelEnum? teammateAppAccessLevel = default(TeammateAppAccessLevelEnum?), PermissionsTypeEnum permissionsType = default(PermissionsTypeEnum), string name = default(string), string description = default(string), bool? isEnabled = default(bool?), List<TagsEnum> tags = default(List<TagsEnum>), List<RegionsEnum> regions = default(List<RegionsEnum>), string developerName = default(string))
        {
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new InvalidDataException("details is a required property for CreateAppStoreApp and cannot be null");
            }
            else
            {
                this.Details = details;
            }
            // to ensure "configurationType" is required (not null)
            if (configurationType == null)
            {
                throw new InvalidDataException("configurationType is a required property for CreateAppStoreApp and cannot be null");
            }
            else
            {
                this.ConfigurationType = configurationType;
            }
            // to ensure "storeSelectorType" is required (not null)
            if (storeSelectorType == null)
            {
                throw new InvalidDataException("storeSelectorType is a required property for CreateAppStoreApp and cannot be null");
            }
            else
            {
                this.StoreSelectorType = storeSelectorType;
            }
            // to ensure "oAuthAppId" is required (not null)
            if (oAuthAppId == null)
            {
                throw new InvalidDataException("oAuthAppId is a required property for CreateAppStoreApp and cannot be null");
            }
            else
            {
                this.OAuthAppId = oAuthAppId;
            }
            // to ensure "permissionsType" is required (not null)
            if (permissionsType == null)
            {
                throw new InvalidDataException("permissionsType is a required property for CreateAppStoreApp and cannot be null");
            }
            else
            {
                this.PermissionsType = permissionsType;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateAppStoreApp and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for CreateAppStoreApp and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for CreateAppStoreApp and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }
            // to ensure "regions" is required (not null)
            if (regions == null)
            {
                throw new InvalidDataException("regions is a required property for CreateAppStoreApp and cannot be null");
            }
            else
            {
                this.Regions = regions;
            }
            this.FieldGroups = fieldGroups;
            this.SetupInstructions = setupInstructions;
            this.ExternalSetupLink = externalSetupLink;
            this.TeammateAppAccessLevel = teammateAppAccessLevel;
            this.IsEnabled = isEnabled;
            this.DeveloperName = developerName;
        }
        
        /// <summary>
        /// Details
        /// </summary>
        /// <value>Details</value>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public string Details { get; set; }



        /// <summary>
        /// Field groups
        /// </summary>
        /// <value>Field groups</value>
        [DataMember(Name="FieldGroups", EmitDefaultValue=false)]
        public List<FieldGroup> FieldGroups { get; set; }

        /// <summary>
        /// Setup instructions
        /// </summary>
        /// <value>Setup instructions</value>
        [DataMember(Name="SetupInstructions", EmitDefaultValue=false)]
        public string SetupInstructions { get; set; }

        /// <summary>
        /// External setup link
        /// </summary>
        /// <value>External setup link</value>
        [DataMember(Name="ExternalSetupLink", EmitDefaultValue=false)]
        public string ExternalSetupLink { get; set; }

        /// <summary>
        /// OAuth app id
        /// </summary>
        /// <value>OAuth app id</value>
        [DataMember(Name="OAuthAppId", EmitDefaultValue=false)]
        public string OAuthAppId { get; set; }



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
        /// Is application enabled
        /// </summary>
        /// <value>Is application enabled</value>
        [DataMember(Name="IsEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }



        /// <summary>
        /// Developer Name
        /// </summary>
        /// <value>Developer Name</value>
        [DataMember(Name="DeveloperName", EmitDefaultValue=false)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAppStoreApp {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  ConfigurationType: ").Append(ConfigurationType).Append("\n");
            sb.Append("  StoreSelectorType: ").Append(StoreSelectorType).Append("\n");
            sb.Append("  FieldGroups: ").Append(FieldGroups).Append("\n");
            sb.Append("  SetupInstructions: ").Append(SetupInstructions).Append("\n");
            sb.Append("  ExternalSetupLink: ").Append(ExternalSetupLink).Append("\n");
            sb.Append("  OAuthAppId: ").Append(OAuthAppId).Append("\n");
            sb.Append("  TeammateAppAccessLevel: ").Append(TeammateAppAccessLevel).Append("\n");
            sb.Append("  PermissionsType: ").Append(PermissionsType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Regions: ").Append(Regions).Append("\n");
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
            return this.Equals(input as CreateAppStoreApp);
        }

        /// <summary>
        /// Returns true if CreateAppStoreApp instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAppStoreApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAppStoreApp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                    this.FieldGroups == input.FieldGroups ||
                    this.FieldGroups != null &&
                    this.FieldGroups.SequenceEqual(input.FieldGroups)
                ) && 
                (
                    this.SetupInstructions == input.SetupInstructions ||
                    (this.SetupInstructions != null &&
                    this.SetupInstructions.Equals(input.SetupInstructions))
                ) && 
                (
                    this.ExternalSetupLink == input.ExternalSetupLink ||
                    (this.ExternalSetupLink != null &&
                    this.ExternalSetupLink.Equals(input.ExternalSetupLink))
                ) && 
                (
                    this.OAuthAppId == input.OAuthAppId ||
                    (this.OAuthAppId != null &&
                    this.OAuthAppId.Equals(input.OAuthAppId))
                ) && 
                (
                    this.TeammateAppAccessLevel == input.TeammateAppAccessLevel ||
                    (this.TeammateAppAccessLevel != null &&
                    this.TeammateAppAccessLevel.Equals(input.TeammateAppAccessLevel))
                ) && 
                (
                    this.PermissionsType == input.PermissionsType ||
                    (this.PermissionsType != null &&
                    this.PermissionsType.Equals(input.PermissionsType))
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
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.ConfigurationType != null)
                    hashCode = hashCode * 59 + this.ConfigurationType.GetHashCode();
                if (this.StoreSelectorType != null)
                    hashCode = hashCode * 59 + this.StoreSelectorType.GetHashCode();
                if (this.FieldGroups != null)
                    hashCode = hashCode * 59 + this.FieldGroups.GetHashCode();
                if (this.SetupInstructions != null)
                    hashCode = hashCode * 59 + this.SetupInstructions.GetHashCode();
                if (this.ExternalSetupLink != null)
                    hashCode = hashCode * 59 + this.ExternalSetupLink.GetHashCode();
                if (this.OAuthAppId != null)
                    hashCode = hashCode * 59 + this.OAuthAppId.GetHashCode();
                if (this.TeammateAppAccessLevel != null)
                    hashCode = hashCode * 59 + this.TeammateAppAccessLevel.GetHashCode();
                if (this.PermissionsType != null)
                    hashCode = hashCode * 59 + this.PermissionsType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Regions != null)
                    hashCode = hashCode * 59 + this.Regions.GetHashCode();
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
