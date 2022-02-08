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
    public partial class MenuItemOptionSetItem :  IEquatable<MenuItemOptionSetItem>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="MenuItemOptionSetItem" /> class.
        /// </summary>
        /// <param name="menuItemOptionSetItemId">Menu item option set item identifier.</param>
        /// <param name="publicId">Permanent reference to the item..</param>
        /// <param name="metadata">List of metadata.</param>
        /// <param name="nextMenuItemOptionSetId">if null, next option set is next. if -1, this is the final option set.</param>
        /// <param name="productId">Product Id when the OptionSet is associated to a Product.</param>
        /// <param name="taxRateName">Tax rate name.</param>
        /// <param name="taxRateId">taxRateId.</param>
        /// <param name="taxValue">taxValue.</param>
        /// <param name="name">Name.</param>
        /// <param name="price">Price.</param>
        /// <param name="isAvailable">Is available.</param>
        /// <param name="displayOrder">Display order. Displayed in ascending order..</param>
        /// <param name="cellLayoutType">Small | Medium | Large  Affects the layout of the menu..</param>
        /// <param name="imageUrl">Image url.</param>
        public MenuItemOptionSetItem(int? menuItemOptionSetItemId = default(int?), Guid? publicId = default(Guid?), List<CreateMetadata> metadata = default(List<CreateMetadata>), int? nextMenuItemOptionSetId = default(int?), string productId = default(string), string taxRateName = default(string), int? taxRateId = default(int?), double? taxValue = default(double?), string name = default(string), double? price = default(double?), bool? isAvailable = default(bool?), int? displayOrder = default(int?), CellLayoutTypeEnum? cellLayoutType = default(CellLayoutTypeEnum?), string imageUrl = default(string))
        {
            this.MenuItemOptionSetItemId = menuItemOptionSetItemId;
            this.PublicId = publicId;
            this.Metadata = metadata;
            this.NextMenuItemOptionSetId = nextMenuItemOptionSetId;
            this.ProductId = productId;
            this.TaxRateName = taxRateName;
            this.TaxRateId = taxRateId;
            this.TaxValue = taxValue;
            this.Name = name;
            this.Price = price;
            this.IsAvailable = isAvailable;
            this.DisplayOrder = displayOrder;
            this.CellLayoutType = cellLayoutType;
            this.ImageUrl = imageUrl;
        }
        
        /// <summary>
        /// Menu item option set item identifier
        /// </summary>
        /// <value>Menu item option set item identifier</value>
        [DataMember(Name="MenuItemOptionSetItemId", EmitDefaultValue=false)]
        public int? MenuItemOptionSetItemId { get; set; }

        /// <summary>
        /// Permanent reference to the item.
        /// </summary>
        /// <value>Permanent reference to the item.</value>
        [DataMember(Name="PublicId", EmitDefaultValue=false)]
        public Guid? PublicId { get; set; }

        /// <summary>
        /// List of metadata
        /// </summary>
        /// <value>List of metadata</value>
        [DataMember(Name="Metadata", EmitDefaultValue=false)]
        public List<CreateMetadata> Metadata { get; set; }

        /// <summary>
        /// if null, next option set is next. if -1, this is the final option set
        /// </summary>
        /// <value>if null, next option set is next. if -1, this is the final option set</value>
        [DataMember(Name="NextMenuItemOptionSetId", EmitDefaultValue=false)]
        public int? NextMenuItemOptionSetId { get; set; }

        /// <summary>
        /// Product Id when the OptionSet is associated to a Product
        /// </summary>
        /// <value>Product Id when the OptionSet is associated to a Product</value>
        [DataMember(Name="ProductId", EmitDefaultValue=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Tax rate name
        /// </summary>
        /// <value>Tax rate name</value>
        [DataMember(Name="TaxRateName", EmitDefaultValue=false)]
        public string TaxRateName { get; set; }

        /// <summary>
        /// Gets or Sets TaxRateId
        /// </summary>
        [DataMember(Name="TaxRateId", EmitDefaultValue=false)]
        public int? TaxRateId { get; set; }

        /// <summary>
        /// Gets or Sets TaxValue
        /// </summary>
        [DataMember(Name="TaxValue", EmitDefaultValue=false)]
        public double? TaxValue { get; set; }

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
            sb.Append("class MenuItemOptionSetItem {\n");
            sb.Append("  MenuItemOptionSetItemId: ").Append(MenuItemOptionSetItemId).Append("\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  NextMenuItemOptionSetId: ").Append(NextMenuItemOptionSetId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  TaxRateName: ").Append(TaxRateName).Append("\n");
            sb.Append("  TaxRateId: ").Append(TaxRateId).Append("\n");
            sb.Append("  TaxValue: ").Append(TaxValue).Append("\n");
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
            return this.Equals(input as MenuItemOptionSetItem);
        }

        /// <summary>
        /// Returns true if MenuItemOptionSetItem instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuItemOptionSetItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuItemOptionSetItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MenuItemOptionSetItemId == input.MenuItemOptionSetItemId ||
                    (this.MenuItemOptionSetItemId != null &&
                    this.MenuItemOptionSetItemId.Equals(input.MenuItemOptionSetItemId))
                ) && 
                (
                    this.PublicId == input.PublicId ||
                    (this.PublicId != null &&
                    this.PublicId.Equals(input.PublicId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.NextMenuItemOptionSetId == input.NextMenuItemOptionSetId ||
                    (this.NextMenuItemOptionSetId != null &&
                    this.NextMenuItemOptionSetId.Equals(input.NextMenuItemOptionSetId))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.TaxRateName == input.TaxRateName ||
                    (this.TaxRateName != null &&
                    this.TaxRateName.Equals(input.TaxRateName))
                ) && 
                (
                    this.TaxRateId == input.TaxRateId ||
                    (this.TaxRateId != null &&
                    this.TaxRateId.Equals(input.TaxRateId))
                ) && 
                (
                    this.TaxValue == input.TaxValue ||
                    (this.TaxValue != null &&
                    this.TaxValue.Equals(input.TaxValue))
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
                if (this.MenuItemOptionSetItemId != null)
                    hashCode = hashCode * 59 + this.MenuItemOptionSetItemId.GetHashCode();
                if (this.PublicId != null)
                    hashCode = hashCode * 59 + this.PublicId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.NextMenuItemOptionSetId != null)
                    hashCode = hashCode * 59 + this.NextMenuItemOptionSetId.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.TaxRateName != null)
                    hashCode = hashCode * 59 + this.TaxRateName.GetHashCode();
                if (this.TaxRateId != null)
                    hashCode = hashCode * 59 + this.TaxRateId.GetHashCode();
                if (this.TaxValue != null)
                    hashCode = hashCode * 59 + this.TaxValue.GetHashCode();
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
