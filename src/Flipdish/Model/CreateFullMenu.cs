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
    /// Create menu object
    /// </summary>
    [DataContract]
    public partial class CreateFullMenu :  IEquatable<CreateFullMenu>
    {
        /// <summary>
        /// Menu section behaviour
        /// </summary>
        /// <value>Menu section behaviour</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MenuSectionBehaviourEnum
        {
            
            /// <summary>
            /// Enum ExpandSingle for value: ExpandSingle
            /// </summary>
            [EnumMember(Value = "ExpandSingle")]
            ExpandSingle = 1,
            
            /// <summary>
            /// Enum ExpandMultiple for value: ExpandMultiple
            /// </summary>
            [EnumMember(Value = "ExpandMultiple")]
            ExpandMultiple = 2
        }

        /// <summary>
        /// Menu section behaviour
        /// </summary>
        /// <value>Menu section behaviour</value>
        [DataMember(Name="MenuSectionBehaviour", EmitDefaultValue=false)]
        public MenuSectionBehaviourEnum? MenuSectionBehaviour { get; set; }
        /// <summary>
        /// Tax type
        /// </summary>
        /// <value>Tax type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaxTypeEnum
        {
            
            /// <summary>
            /// Enum IncludedInBasePrice for value: IncludedInBasePrice
            /// </summary>
            [EnumMember(Value = "IncludedInBasePrice")]
            IncludedInBasePrice = 1,
            
            /// <summary>
            /// Enum ExcludedFromBasePrice for value: ExcludedFromBasePrice
            /// </summary>
            [EnumMember(Value = "ExcludedFromBasePrice")]
            ExcludedFromBasePrice = 2
        }

        /// <summary>
        /// Tax type
        /// </summary>
        /// <value>Tax type</value>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public TaxTypeEnum? TaxType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFullMenu" /> class.
        /// </summary>
        /// <param name="name">Name of Menu, only shown in portal.</param>
        /// <param name="imageUrl">Image url.</param>
        /// <param name="menuSections">Menu sections (starters, main etc).</param>
        /// <param name="taxRates">Menu tax rates.</param>
        /// <param name="displaySectionLinks">Display menu section link on UI.</param>
        /// <param name="menuSectionBehaviour">Menu section behaviour.</param>
        /// <param name="taxType">Tax type.</param>
        /// <param name="isIntegrated">Flag to indicate if the menu is integrated (contains metadata).</param>
        public CreateFullMenu(string name = default(string), string imageUrl = default(string), List<CreateFullMenuSection> menuSections = default(List<CreateFullMenuSection>), List<CreateMenuTaxRate> taxRates = default(List<CreateMenuTaxRate>), bool? displaySectionLinks = default(bool?), MenuSectionBehaviourEnum? menuSectionBehaviour = default(MenuSectionBehaviourEnum?), TaxTypeEnum? taxType = default(TaxTypeEnum?), bool? isIntegrated = default(bool?))
        {
            this.Name = name;
            this.ImageUrl = imageUrl;
            this.MenuSections = menuSections;
            this.TaxRates = taxRates;
            this.DisplaySectionLinks = displaySectionLinks;
            this.MenuSectionBehaviour = menuSectionBehaviour;
            this.TaxType = taxType;
            this.IsIntegrated = isIntegrated;
        }
        
        /// <summary>
        /// Name of Menu, only shown in portal
        /// </summary>
        /// <value>Name of Menu, only shown in portal</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Image url
        /// </summary>
        /// <value>Image url</value>
        [DataMember(Name="ImageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Menu sections (starters, main etc)
        /// </summary>
        /// <value>Menu sections (starters, main etc)</value>
        [DataMember(Name="MenuSections", EmitDefaultValue=false)]
        public List<CreateFullMenuSection> MenuSections { get; set; }

        /// <summary>
        /// Menu tax rates
        /// </summary>
        /// <value>Menu tax rates</value>
        [DataMember(Name="TaxRates", EmitDefaultValue=false)]
        public List<CreateMenuTaxRate> TaxRates { get; set; }

        /// <summary>
        /// Display menu section link on UI
        /// </summary>
        /// <value>Display menu section link on UI</value>
        [DataMember(Name="DisplaySectionLinks", EmitDefaultValue=false)]
        public bool? DisplaySectionLinks { get; set; }



        /// <summary>
        /// Flag to indicate if the menu is integrated (contains metadata)
        /// </summary>
        /// <value>Flag to indicate if the menu is integrated (contains metadata)</value>
        [DataMember(Name="IsIntegrated", EmitDefaultValue=false)]
        public bool? IsIntegrated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFullMenu {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  MenuSections: ").Append(MenuSections).Append("\n");
            sb.Append("  TaxRates: ").Append(TaxRates).Append("\n");
            sb.Append("  DisplaySectionLinks: ").Append(DisplaySectionLinks).Append("\n");
            sb.Append("  MenuSectionBehaviour: ").Append(MenuSectionBehaviour).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  IsIntegrated: ").Append(IsIntegrated).Append("\n");
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
            return this.Equals(input as CreateFullMenu);
        }

        /// <summary>
        /// Returns true if CreateFullMenu instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFullMenu to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFullMenu input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.MenuSections == input.MenuSections ||
                    this.MenuSections != null &&
                    this.MenuSections.SequenceEqual(input.MenuSections)
                ) && 
                (
                    this.TaxRates == input.TaxRates ||
                    this.TaxRates != null &&
                    this.TaxRates.SequenceEqual(input.TaxRates)
                ) && 
                (
                    this.DisplaySectionLinks == input.DisplaySectionLinks ||
                    (this.DisplaySectionLinks != null &&
                    this.DisplaySectionLinks.Equals(input.DisplaySectionLinks))
                ) && 
                (
                    this.MenuSectionBehaviour == input.MenuSectionBehaviour ||
                    (this.MenuSectionBehaviour != null &&
                    this.MenuSectionBehaviour.Equals(input.MenuSectionBehaviour))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
                ) && 
                (
                    this.IsIntegrated == input.IsIntegrated ||
                    (this.IsIntegrated != null &&
                    this.IsIntegrated.Equals(input.IsIntegrated))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.MenuSections != null)
                    hashCode = hashCode * 59 + this.MenuSections.GetHashCode();
                if (this.TaxRates != null)
                    hashCode = hashCode * 59 + this.TaxRates.GetHashCode();
                if (this.DisplaySectionLinks != null)
                    hashCode = hashCode * 59 + this.DisplaySectionLinks.GetHashCode();
                if (this.MenuSectionBehaviour != null)
                    hashCode = hashCode * 59 + this.MenuSectionBehaviour.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
                if (this.IsIntegrated != null)
                    hashCode = hashCode * 59 + this.IsIntegrated.GetHashCode();
                return hashCode;
            }
        }
    }

}
