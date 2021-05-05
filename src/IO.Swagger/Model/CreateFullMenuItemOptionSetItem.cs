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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Create menu item option set item
    /// </summary>
    [DataContract]
    public partial class CreateFullMenuItemOptionSetItem :  IEquatable<CreateFullMenuItemOptionSetItem>, IValidatableObject
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
            Large = 3,
            
            /// <summary>
            /// Enum HiddenImage for value: HiddenImage
            /// </summary>
            [EnumMember(Value = "HiddenImage")]
            HiddenImage = 4
        }

        /// <summary>
        /// Small | Medium | Large  Affects the layout of the menu.
        /// </summary>
        /// <value>Small | Medium | Large  Affects the layout of the menu.</value>
        [DataMember(Name="CellLayoutType", EmitDefaultValue=false)]
        public CellLayoutTypeEnum? CellLayoutType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFullMenuItemOptionSetItem" /> class.
        /// </summary>
        /// <param name="metadata">List of metadata.</param>
        /// <param name="taxRateName">Tax rate name.</param>
        /// <param name="name">Name.</param>
        /// <param name="price">Price.</param>
        /// <param name="isAvailable">Is available.</param>
        /// <param name="displayOrder">Display order. Displayed in ascending order..</param>
        /// <param name="cellLayoutType">Small | Medium | Large  Affects the layout of the menu..</param>
        /// <param name="imageUrl">Image url.</param>
        public CreateFullMenuItemOptionSetItem(List<CreateMetadata> metadata = default(List<CreateMetadata>), string taxRateName = default(string), string name = default(string), double? price = default(double?), bool? isAvailable = default(bool?), int? displayOrder = default(int?), CellLayoutTypeEnum? cellLayoutType = default(CellLayoutTypeEnum?), string imageUrl = default(string))
        {
            this.Metadata = metadata;
            this.TaxRateName = taxRateName;
            this.Name = name;
            this.Price = price;
            this.IsAvailable = isAvailable;
            this.DisplayOrder = displayOrder;
            this.CellLayoutType = cellLayoutType;
            this.ImageUrl = imageUrl;
        }
        
        /// <summary>
        /// List of metadata
        /// </summary>
        /// <value>List of metadata</value>
        [DataMember(Name="Metadata", EmitDefaultValue=false)]
        public List<CreateMetadata> Metadata { get; set; }

        /// <summary>
        /// Tax rate name
        /// </summary>
        /// <value>Tax rate name</value>
        [DataMember(Name="TaxRateName", EmitDefaultValue=false)]
        public string TaxRateName { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        /// <value>Price</value>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Is available
        /// </summary>
        /// <value>Is available</value>
        [DataMember(Name="IsAvailable", EmitDefaultValue=false)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Display order. Displayed in ascending order.
        /// </summary>
        /// <value>Display order. Displayed in ascending order.</value>
        [DataMember(Name="DisplayOrder", EmitDefaultValue=false)]
        public int? DisplayOrder { get; set; }


        /// <summary>
        /// Image url
        /// </summary>
        /// <value>Image url</value>
        [DataMember(Name="ImageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFullMenuItemOptionSetItem {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  TaxRateName: ").Append(TaxRateName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  CellLayoutType: ").Append(CellLayoutType).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
            return this.Equals(input as CreateFullMenuItemOptionSetItem);
        }

        /// <summary>
        /// Returns true if CreateFullMenuItemOptionSetItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFullMenuItemOptionSetItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFullMenuItemOptionSetItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.TaxRateName == input.TaxRateName ||
                    (this.TaxRateName != null &&
                    this.TaxRateName.Equals(input.TaxRateName))
                ) && 
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
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
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
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.TaxRateName != null)
                    hashCode = hashCode * 59 + this.TaxRateName.GetHashCode();
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
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
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
