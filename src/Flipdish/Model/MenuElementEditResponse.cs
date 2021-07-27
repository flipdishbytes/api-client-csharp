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
    /// Response with any menu elements that had issues being hidden/shown
    /// </summary>
    [DataContract]
    public partial class MenuElementEditResponse :  IEquatable<MenuElementEditResponse>, IValidatableObject
    {
        /// <summary>
        /// Type of menu element
        /// </summary>
        /// <value>Type of menu element</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MenuElementTypeEnum
        {
            
            /// <summary>
            /// Enum Item for value: Item
            /// </summary>
            [EnumMember(Value = "Item")]
            Item = 1,
            
            /// <summary>
            /// Enum OptionSetItem for value: OptionSetItem
            /// </summary>
            [EnumMember(Value = "OptionSetItem")]
            OptionSetItem = 2
        }

        /// <summary>
        /// Type of menu element
        /// </summary>
        /// <value>Type of menu element</value>
        [DataMember(Name="MenuElementType", EmitDefaultValue=false)]
        public MenuElementTypeEnum? MenuElementType { get; set; }
        /// <summary>
        /// Validation message for menu element issue
        /// </summary>
        /// <value>Validation message for menu element issue</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidationCodeEnum
        {
            
            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 1,
            
            /// <summary>
            /// Enum MinimumCountViolation for value: MinimumCountViolation
            /// </summary>
            [EnumMember(Value = "MinimumCountViolation")]
            MinimumCountViolation = 2,
            
            /// <summary>
            /// Enum MasterOptionSetViolation for value: MasterOptionSetViolation
            /// </summary>
            [EnumMember(Value = "MasterOptionSetViolation")]
            MasterOptionSetViolation = 3,
            
            /// <summary>
            /// Enum IncorrectElementTypeInMenu for value: IncorrectElementTypeInMenu
            /// </summary>
            [EnumMember(Value = "IncorrectElementTypeInMenu")]
            IncorrectElementTypeInMenu = 4,
            
            /// <summary>
            /// Enum DBFailed for value: DBFailed
            /// </summary>
            [EnumMember(Value = "DBFailed")]
            DBFailed = 5
        }

        /// <summary>
        /// Validation message for menu element issue
        /// </summary>
        /// <value>Validation message for menu element issue</value>
        [DataMember(Name="ValidationCode", EmitDefaultValue=false)]
        public ValidationCodeEnum? ValidationCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuElementEditResponse" /> class.
        /// </summary>
        /// <param name="sectionName">Section name.</param>
        /// <param name="itemName">Item name.</param>
        /// <param name="optionSetName">Option Set name.</param>
        /// <param name="optionSetItemName">Element name.</param>
        /// <param name="menuElementId">Holds the information for the A and CNAME Records of a domain..</param>
        /// <param name="menuElementType">Type of menu element.</param>
        /// <param name="validationCode">Validation message for menu element issue.</param>
        public MenuElementEditResponse(string sectionName = default(string), string itemName = default(string), string optionSetName = default(string), string optionSetItemName = default(string), int? menuElementId = default(int?), MenuElementTypeEnum? menuElementType = default(MenuElementTypeEnum?), ValidationCodeEnum? validationCode = default(ValidationCodeEnum?))
        {
            this.SectionName = sectionName;
            this.ItemName = itemName;
            this.OptionSetName = optionSetName;
            this.OptionSetItemName = optionSetItemName;
            this.MenuElementId = menuElementId;
            this.MenuElementType = menuElementType;
            this.ValidationCode = validationCode;
        }
        
        /// <summary>
        /// Section name
        /// </summary>
        /// <value>Section name</value>
        [DataMember(Name="SectionName", EmitDefaultValue=false)]
        public string SectionName { get; set; }

        /// <summary>
        /// Item name
        /// </summary>
        /// <value>Item name</value>
        [DataMember(Name="ItemName", EmitDefaultValue=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// Option Set name
        /// </summary>
        /// <value>Option Set name</value>
        [DataMember(Name="OptionSetName", EmitDefaultValue=false)]
        public string OptionSetName { get; set; }

        /// <summary>
        /// Element name
        /// </summary>
        /// <value>Element name</value>
        [DataMember(Name="OptionSetItemName", EmitDefaultValue=false)]
        public string OptionSetItemName { get; set; }

        /// <summary>
        /// Holds the information for the A and CNAME Records of a domain.
        /// </summary>
        /// <value>Holds the information for the A and CNAME Records of a domain.</value>
        [DataMember(Name="MenuElementId", EmitDefaultValue=false)]
        public int? MenuElementId { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuElementEditResponse {\n");
            sb.Append("  SectionName: ").Append(SectionName).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  OptionSetName: ").Append(OptionSetName).Append("\n");
            sb.Append("  OptionSetItemName: ").Append(OptionSetItemName).Append("\n");
            sb.Append("  MenuElementId: ").Append(MenuElementId).Append("\n");
            sb.Append("  MenuElementType: ").Append(MenuElementType).Append("\n");
            sb.Append("  ValidationCode: ").Append(ValidationCode).Append("\n");
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
            return this.Equals(input as MenuElementEditResponse);
        }

        /// <summary>
        /// Returns true if MenuElementEditResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuElementEditResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuElementEditResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SectionName == input.SectionName ||
                    (this.SectionName != null &&
                    this.SectionName.Equals(input.SectionName))
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) && 
                (
                    this.OptionSetName == input.OptionSetName ||
                    (this.OptionSetName != null &&
                    this.OptionSetName.Equals(input.OptionSetName))
                ) && 
                (
                    this.OptionSetItemName == input.OptionSetItemName ||
                    (this.OptionSetItemName != null &&
                    this.OptionSetItemName.Equals(input.OptionSetItemName))
                ) && 
                (
                    this.MenuElementId == input.MenuElementId ||
                    (this.MenuElementId != null &&
                    this.MenuElementId.Equals(input.MenuElementId))
                ) && 
                (
                    this.MenuElementType == input.MenuElementType ||
                    (this.MenuElementType != null &&
                    this.MenuElementType.Equals(input.MenuElementType))
                ) && 
                (
                    this.ValidationCode == input.ValidationCode ||
                    (this.ValidationCode != null &&
                    this.ValidationCode.Equals(input.ValidationCode))
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
                if (this.SectionName != null)
                    hashCode = hashCode * 59 + this.SectionName.GetHashCode();
                if (this.ItemName != null)
                    hashCode = hashCode * 59 + this.ItemName.GetHashCode();
                if (this.OptionSetName != null)
                    hashCode = hashCode * 59 + this.OptionSetName.GetHashCode();
                if (this.OptionSetItemName != null)
                    hashCode = hashCode * 59 + this.OptionSetItemName.GetHashCode();
                if (this.MenuElementId != null)
                    hashCode = hashCode * 59 + this.MenuElementId.GetHashCode();
                if (this.MenuElementType != null)
                    hashCode = hashCode * 59 + this.MenuElementType.GetHashCode();
                if (this.ValidationCode != null)
                    hashCode = hashCode * 59 + this.ValidationCode.GetHashCode();
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
