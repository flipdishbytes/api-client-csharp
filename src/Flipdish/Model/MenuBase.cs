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
    /// Menu base
    /// </summary>
    [DataContract]
    public partial class MenuBase :  IEquatable<MenuBase>
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
        /// Initializes a new instance of the <see cref="MenuBase" /> class.
        /// </summary>
        /// <param name="displaySectionLinks">Display menu section link on UI.</param>
        /// <param name="menuSectionBehaviour">Menu section behaviour.</param>
        /// <param name="taxType">Tax type.</param>
        /// <param name="isIntegrated">Flag to indicate if the menu is integrated (contains metadata).</param>
        public MenuBase(bool? displaySectionLinks = default(bool?), MenuSectionBehaviourEnum? menuSectionBehaviour = default(MenuSectionBehaviourEnum?), TaxTypeEnum? taxType = default(TaxTypeEnum?), bool? isIntegrated = default(bool?))
        {
            this.DisplaySectionLinks = displaySectionLinks;
            this.MenuSectionBehaviour = menuSectionBehaviour;
            this.TaxType = taxType;
            this.IsIntegrated = isIntegrated;
        }
        
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
            sb.Append("class MenuBase {\n");
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
            return this.Equals(input as MenuBase);
        }

        /// <summary>
        /// Returns true if MenuBase instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuBase input)
        {
            if (input == null)
                return false;

            return 
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
