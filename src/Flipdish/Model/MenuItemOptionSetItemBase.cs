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
    /// Menu item option set item
    /// </summary>
    [DataContract]
    public partial class MenuItemOptionSetItemBase :  IEquatable<MenuItemOptionSetItemBase>, IValidatableObject
    {
        /// <summary>
        /// Small | Medium | Large  Affects the layout of the menu.
        /// </summary>
        /// <value>Small | Medium | Large  Affects the layout of the menu.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CellLayoutTypeEnum
        {
            
            /// <summary>
            /// Enum Small for value: Small
            /// </summary>
            [EnumMember(Value = "Small")]
            Small = 1,
            
            /// <summary>
            /// Enum Medium for value: Medium
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium = 2,
            
            /// <summary>
            /// Enum Large for value: Large
            /// </summary>
            [EnumMember(Value = "Large")]
            Large = 3
        }

        /// <summary>
        /// Small | Medium | Large  Affects the layout of the menu.
        /// </summary>
        /// <value>Small | Medium | Large  Affects the layout of the menu.</value>
        [DataMember(Name="cellLayoutType", EmitDefaultValue=false)]
        public CellLayoutTypeEnum? CellLayoutType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItemOptionSetItemBase" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Price">Price.</param>
        /// <param name="IsAvailable">Is available.</param>
        /// <param name="DisplayOrder">Display order. Displayed in ascending order..</param>
        /// <param name="CellLayoutType">Small | Medium | Large  Affects the layout of the menu..</param>
        public MenuItemOptionSetItemBase(string Name = default(string), double? Price = default(double?), bool? IsAvailable = default(bool?), int? DisplayOrder = default(int?), CellLayoutTypeEnum? CellLayoutType = default(CellLayoutTypeEnum?))
        {
            this.Name = Name;
            this.Price = Price;
            this.IsAvailable = IsAvailable;
            this.DisplayOrder = DisplayOrder;
            this.CellLayoutType = CellLayoutType;
        }
        
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        /// <value>Price</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Is available
        /// </summary>
        /// <value>Is available</value>
        [DataMember(Name="isAvailable", EmitDefaultValue=false)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Display order. Displayed in ascending order.
        /// </summary>
        /// <value>Display order. Displayed in ascending order.</value>
        [DataMember(Name="displayOrder", EmitDefaultValue=false)]
        public int? DisplayOrder { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuItemOptionSetItemBase {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  CellLayoutType: ").Append(CellLayoutType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as MenuItemOptionSetItemBase);
        }

        /// <summary>
        /// Returns true if MenuItemOptionSetItemBase instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuItemOptionSetItemBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuItemOptionSetItemBase input)
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
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.IsAvailable == input.IsAvailable ||
                    (this.IsAvailable != null &&
                    this.IsAvailable.Equals(input.IsAvailable))
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
                ) && 
                (
                    this.CellLayoutType == input.CellLayoutType ||
                    (this.CellLayoutType != null &&
                    this.CellLayoutType.Equals(input.CellLayoutType))
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
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.IsAvailable != null)
                    hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
                if (this.CellLayoutType != null)
                    hashCode = hashCode * 59 + this.CellLayoutType.GetHashCode();
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
