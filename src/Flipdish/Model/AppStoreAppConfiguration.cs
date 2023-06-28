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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Flipdish.Client.SwaggerDateConverter;

namespace Flipdish.Model
{
    /// <summary>
    /// App store app configurations
    /// </summary>
    [DataContract]
    public partial class AppStoreAppConfiguration :  IEquatable<AppStoreAppConfiguration>
    {
        /// <summary>
        /// Application verification status
        /// </summary>
        /// <value>Application verification status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerificationStatusEnum
        {
            
            /// <summary>
            /// Enum Draft for value: Draft
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft = 1,
            
            /// <summary>
            /// Enum Submitted for value: Submitted
            /// </summary>
            [EnumMember(Value = "Submitted")]
            Submitted = 2,
            
            /// <summary>
            /// Enum Verified for value: Verified
            /// </summary>
            [EnumMember(Value = "Verified")]
            Verified = 3
        }

        /// <summary>
        /// Application verification status
        /// </summary>
        /// <value>Application verification status</value>
        [DataMember(Name="VerificationStatus", EmitDefaultValue=false)]
        public VerificationStatusEnum VerificationStatus { get; set; }
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
        /// Defines Categories
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoriesEnum
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
        /// Categories
        /// </summary>
        /// <value>Categories</value>
        [DataMember(Name="Categories", EmitDefaultValue=false)]
        public List<CategoriesEnum> Categories { get; set; }
        /// <summary>
        /// Defines Countries
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CountriesEnum
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
        /// Countries
        /// </summary>
        /// <value>Countries</value>
        [DataMember(Name="Countries", EmitDefaultValue=false)]
        public List<CountriesEnum> Countries { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreAppConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppStoreAppConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreAppConfiguration" /> class.
        /// </summary>
        /// <param name="id">Unique App store app configuration id (required).</param>
        /// <param name="appId">App id (required).</param>
        /// <param name="appStoreAppId">App store app id (required).</param>
        /// <param name="isEnabled">Is enabled (required).</param>
        /// <param name="storeIds">Stores id&#39;s.</param>
        /// <param name="settings">Settings.</param>
        /// <param name="verificationStatus">Application verification status (required).</param>
        /// <param name="logo">Logo.</param>
        /// <param name="oAuthAppId">OAuth App identifier (required).</param>
        /// <param name="_internal">Internal (required).</param>
        /// <param name="details">Details (required).</param>
        /// <param name="configurationType">Configuration type  &lt;example&gt;External link&lt;/example&gt;&lt;example&gt;Flipdish hosted&lt;/example&gt; (required).</param>
        /// <param name="storeSelectorType">Store selector type (required).</param>
        /// <param name="fieldGroups">Field groups.</param>
        /// <param name="setupInstructions">Setup instructions.</param>
        /// <param name="externalSetupLink">External setup link.</param>
        /// <param name="teammateAppAccessLevel">Teammate app access level.</param>
        /// <param name="permissionsType">Permissions type (required).</param>
        /// <param name="support">Support information.</param>
        /// <param name="externalFunctionActionUrl">Action URL for external functions, used for handling Portal configuration action buttons.</param>
        /// <param name="externalFunctionSignatureKey">Signing key for external function action calls.</param>
        /// <param name="isPaid">Is Paid.</param>
        /// <param name="name">Name (required).</param>
        /// <param name="description">Description (required).</param>
        /// <param name="categories">Categories (required).</param>
        /// <param name="countries">Countries (required).</param>
        /// <param name="developerName">Developer Name.</param>
        public AppStoreAppConfiguration(string id = default(string), string appId = default(string), string appStoreAppId = default(string), bool? isEnabled = default(bool?), List<int?> storeIds = default(List<int?>), List<Setting> settings = default(List<Setting>), VerificationStatusEnum verificationStatus = default(VerificationStatusEnum), string logo = default(string), string oAuthAppId = default(string), bool? _internal = default(bool?), string details = default(string), ConfigurationTypeEnum configurationType = default(ConfigurationTypeEnum), StoreSelectorTypeEnum storeSelectorType = default(StoreSelectorTypeEnum), List<FieldGroup> fieldGroups = default(List<FieldGroup>), string setupInstructions = default(string), string externalSetupLink = default(string), TeammateAppAccessLevelEnum? teammateAppAccessLevel = default(TeammateAppAccessLevelEnum?), PermissionsTypeEnum permissionsType = default(PermissionsTypeEnum), AppStoreAppSupportInfo support = default(AppStoreAppSupportInfo), string externalFunctionActionUrl = default(string), string externalFunctionSignatureKey = default(string), bool? isPaid = default(bool?), string name = default(string), string description = default(string), List<CategoriesEnum> categories = default(List<CategoriesEnum>), List<CountriesEnum> countries = default(List<CountriesEnum>), string developerName = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "appId" is required (not null)
            if (appId == null)
            {
                throw new InvalidDataException("appId is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.AppId = appId;
            }
            // to ensure "appStoreAppId" is required (not null)
            if (appStoreAppId == null)
            {
                throw new InvalidDataException("appStoreAppId is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.AppStoreAppId = appStoreAppId;
            }
            // to ensure "isEnabled" is required (not null)
            if (isEnabled == null)
            {
                throw new InvalidDataException("isEnabled is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.IsEnabled = isEnabled;
            }
            // to ensure "verificationStatus" is required (not null)
            if (verificationStatus == null)
            {
                throw new InvalidDataException("verificationStatus is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.VerificationStatus = verificationStatus;
            }
            // to ensure "oAuthAppId" is required (not null)
            if (oAuthAppId == null)
            {
                throw new InvalidDataException("oAuthAppId is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.OAuthAppId = oAuthAppId;
            }
            // to ensure "_internal" is required (not null)
            if (_internal == null)
            {
                throw new InvalidDataException("_internal is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.Internal = _internal;
            }
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new InvalidDataException("details is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.Details = details;
            }
            // to ensure "configurationType" is required (not null)
            if (configurationType == null)
            {
                throw new InvalidDataException("configurationType is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.ConfigurationType = configurationType;
            }
            // to ensure "storeSelectorType" is required (not null)
            if (storeSelectorType == null)
            {
                throw new InvalidDataException("storeSelectorType is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.StoreSelectorType = storeSelectorType;
            }
            // to ensure "permissionsType" is required (not null)
            if (permissionsType == null)
            {
                throw new InvalidDataException("permissionsType is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.PermissionsType = permissionsType;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new InvalidDataException("categories is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.Categories = categories;
            }
            // to ensure "countries" is required (not null)
            if (countries == null)
            {
                throw new InvalidDataException("countries is a required property for AppStoreAppConfiguration and cannot be null");
            }
            else
            {
                this.Countries = countries;
            }
            this.StoreIds = storeIds;
            this.Settings = settings;
            this.Logo = logo;
            this.FieldGroups = fieldGroups;
            this.SetupInstructions = setupInstructions;
            this.ExternalSetupLink = externalSetupLink;
            this.TeammateAppAccessLevel = teammateAppAccessLevel;
            this.Support = support;
            this.ExternalFunctionActionUrl = externalFunctionActionUrl;
            this.ExternalFunctionSignatureKey = externalFunctionSignatureKey;
            this.IsPaid = isPaid;
            this.DeveloperName = developerName;
        }
        
        /// <summary>
        /// Unique App store app configuration id
        /// </summary>
        /// <value>Unique App store app configuration id</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// App id
        /// </summary>
        /// <value>App id</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// App store app id
        /// </summary>
        /// <value>App store app id</value>
        [DataMember(Name="AppStoreAppId", EmitDefaultValue=false)]
        public string AppStoreAppId { get; set; }

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
        [DataMember(Name="StoreIds", EmitDefaultValue=false)]
        public List<int?> StoreIds { get; set; }

        /// <summary>
        /// Settings
        /// </summary>
        /// <value>Settings</value>
        [DataMember(Name="Settings", EmitDefaultValue=false)]
        public List<Setting> Settings { get; set; }


        /// <summary>
        /// Logo
        /// </summary>
        /// <value>Logo</value>
        [DataMember(Name="Logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// OAuth App identifier
        /// </summary>
        /// <value>OAuth App identifier</value>
        [DataMember(Name="OAuthAppId", EmitDefaultValue=false)]
        public string OAuthAppId { get; set; }

        /// <summary>
        /// Internal
        /// </summary>
        /// <value>Internal</value>
        [DataMember(Name="Internal", EmitDefaultValue=false)]
        public bool? Internal { get; set; }

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
        /// Support information
        /// </summary>
        /// <value>Support information</value>
        [DataMember(Name="Support", EmitDefaultValue=false)]
        public AppStoreAppSupportInfo Support { get; set; }

        /// <summary>
        /// Action URL for external functions, used for handling Portal configuration action buttons
        /// </summary>
        /// <value>Action URL for external functions, used for handling Portal configuration action buttons</value>
        [DataMember(Name="ExternalFunctionActionUrl", EmitDefaultValue=false)]
        public string ExternalFunctionActionUrl { get; set; }

        /// <summary>
        /// Signing key for external function action calls
        /// </summary>
        /// <value>Signing key for external function action calls</value>
        [DataMember(Name="ExternalFunctionSignatureKey", EmitDefaultValue=false)]
        public string ExternalFunctionSignatureKey { get; set; }

        /// <summary>
        /// Is Paid
        /// </summary>
        /// <value>Is Paid</value>
        [DataMember(Name="IsPaid", EmitDefaultValue=false)]
        public bool? IsPaid { get; set; }

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
            sb.Append("class AppStoreAppConfiguration {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  AppStoreAppId: ").Append(AppStoreAppId).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  OAuthAppId: ").Append(OAuthAppId).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  ConfigurationType: ").Append(ConfigurationType).Append("\n");
            sb.Append("  StoreSelectorType: ").Append(StoreSelectorType).Append("\n");
            sb.Append("  FieldGroups: ").Append(FieldGroups).Append("\n");
            sb.Append("  SetupInstructions: ").Append(SetupInstructions).Append("\n");
            sb.Append("  ExternalSetupLink: ").Append(ExternalSetupLink).Append("\n");
            sb.Append("  TeammateAppAccessLevel: ").Append(TeammateAppAccessLevel).Append("\n");
            sb.Append("  PermissionsType: ").Append(PermissionsType).Append("\n");
            sb.Append("  Support: ").Append(Support).Append("\n");
            sb.Append("  ExternalFunctionActionUrl: ").Append(ExternalFunctionActionUrl).Append("\n");
            sb.Append("  ExternalFunctionSignatureKey: ").Append(ExternalFunctionSignatureKey).Append("\n");
            sb.Append("  IsPaid: ").Append(IsPaid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
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
            return this.Equals(input as AppStoreAppConfiguration);
        }

        /// <summary>
        /// Returns true if AppStoreAppConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreAppConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreAppConfiguration input)
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
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
                ) && 
                (
                    this.VerificationStatus == input.VerificationStatus ||
                    (this.VerificationStatus != null &&
                    this.VerificationStatus.Equals(input.VerificationStatus))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.OAuthAppId == input.OAuthAppId ||
                    (this.OAuthAppId != null &&
                    this.OAuthAppId.Equals(input.OAuthAppId))
                ) && 
                (
                    this.Internal == input.Internal ||
                    (this.Internal != null &&
                    this.Internal.Equals(input.Internal))
                ) && 
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
                    this.Support == input.Support ||
                    (this.Support != null &&
                    this.Support.Equals(input.Support))
                ) && 
                (
                    this.ExternalFunctionActionUrl == input.ExternalFunctionActionUrl ||
                    (this.ExternalFunctionActionUrl != null &&
                    this.ExternalFunctionActionUrl.Equals(input.ExternalFunctionActionUrl))
                ) && 
                (
                    this.ExternalFunctionSignatureKey == input.ExternalFunctionSignatureKey ||
                    (this.ExternalFunctionSignatureKey != null &&
                    this.ExternalFunctionSignatureKey.Equals(input.ExternalFunctionSignatureKey))
                ) && 
                (
                    this.IsPaid == input.IsPaid ||
                    (this.IsPaid != null &&
                    this.IsPaid.Equals(input.IsPaid))
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
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Countries == input.Countries ||
                    this.Countries != null &&
                    this.Countries.SequenceEqual(input.Countries)
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
                if (this.AppStoreAppId != null)
                    hashCode = hashCode * 59 + this.AppStoreAppId.GetHashCode();
                if (this.IsEnabled != null)
                    hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.StoreIds != null)
                    hashCode = hashCode * 59 + this.StoreIds.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                if (this.VerificationStatus != null)
                    hashCode = hashCode * 59 + this.VerificationStatus.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.OAuthAppId != null)
                    hashCode = hashCode * 59 + this.OAuthAppId.GetHashCode();
                if (this.Internal != null)
                    hashCode = hashCode * 59 + this.Internal.GetHashCode();
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
                if (this.TeammateAppAccessLevel != null)
                    hashCode = hashCode * 59 + this.TeammateAppAccessLevel.GetHashCode();
                if (this.PermissionsType != null)
                    hashCode = hashCode * 59 + this.PermissionsType.GetHashCode();
                if (this.Support != null)
                    hashCode = hashCode * 59 + this.Support.GetHashCode();
                if (this.ExternalFunctionActionUrl != null)
                    hashCode = hashCode * 59 + this.ExternalFunctionActionUrl.GetHashCode();
                if (this.ExternalFunctionSignatureKey != null)
                    hashCode = hashCode * 59 + this.ExternalFunctionSignatureKey.GetHashCode();
                if (this.IsPaid != null)
                    hashCode = hashCode * 59 + this.IsPaid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Countries != null)
                    hashCode = hashCode * 59 + this.Countries.GetHashCode();
                if (this.DeveloperName != null)
                    hashCode = hashCode * 59 + this.DeveloperName.GetHashCode();
                return hashCode;
            }
        }
    }

}
