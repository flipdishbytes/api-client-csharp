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
    /// Menu item option set
    /// </summary>
    [DataContract]
    public partial class MenuItemOptionSet :  IEquatable<MenuItemOptionSet>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="MenuItemOptionSet" /> class.
        /// </summary>
        /// <param name="menuItemOptionSetId">Menu item option set identifier.</param>
        /// <param name="imageUrl">Image url.</param>
        /// <param name="menuItemOptionSetItems">Option set items.</param>
        /// <param name="publicId">Permanent reference to the item..</param>
        /// <param name="productId">Product Id when the OptionSet is associated to a Product.</param>
        /// <param name="name">Menu item option set name.</param>
        /// <param name="isMasterOptionSet">Is master option set. This can affect the layout of the options in the menu displayed to the customer. Usually it is true if the option could be considerd a standalone item as opposed to an addition (\&quot;with ketchup\&quot;) or modifier (\&quot;large\&quot;)..</param>
        /// <param name="displayOrder">Display order. Displayed in ascending order..</param>
        /// <param name="minSelectCount">Minimum items must be selected.</param>
        /// <param name="maxSelectCount">Maximum number of items can be selected.</param>
        /// <param name="cellLayoutType">Small | Medium | Large  Affects the layout of the menu..</param>
        public MenuItemOptionSet(int? menuItemOptionSetId = default(int?), string imageUrl = default(string), List<MenuItemOptionSetItem> menuItemOptionSetItems = default(List<MenuItemOptionSetItem>), Guid? publicId = default(Guid?), string productId = default(string), string name = default(string), bool? isMasterOptionSet = default(bool?), int? displayOrder = default(int?), int? minSelectCount = default(int?), int? maxSelectCount = default(int?), CellLayoutTypeEnum? cellLayoutType = default(CellLayoutTypeEnum?))
        {
            this.MenuItemOptionSetId = menuItemOptionSetId;
            this.ImageUrl = imageUrl;
            this.MenuItemOptionSetItems = menuItemOptionSetItems;
            this.PublicId = publicId;
            this.ProductId = productId;
            this.Name = name;
            this.IsMasterOptionSet = isMasterOptionSet;
            this.DisplayOrder = displayOrder;
            this.MinSelectCount = minSelectCount;
            this.MaxSelectCount = maxSelectCount;
            this.CellLayoutType = cellLayoutType;
        }
        
        /// <summary>
        /// Menu item option set identifier
        /// </summary>
        /// <value>Menu item option set identifier</value>
        [DataMember(Name="MenuItemOptionSetId", EmitDefaultValue=false)]
        public int? MenuItemOptionSetId { get; set; }

        /// <summary>
        /// Image url
        /// </summary>
        /// <value>Image url</value>
        [DataMember(Name="ImageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Option set items
        /// </summary>
        /// <value>Option set items</value>
        [DataMember(Name="MenuItemOptionSetItems", EmitDefaultValue=false)]
        public List<MenuItemOptionSetItem> MenuItemOptionSetItems { get; set; }

        /// <summary>
        /// Permanent reference to the item.
        /// </summary>
        /// <value>Permanent reference to the item.</value>
        [DataMember(Name="PublicId", EmitDefaultValue=false)]
        public Guid? PublicId { get; set; }

        /// <summary>
        /// Product Id when the OptionSet is associated to a Product
        /// </summary>
        /// <value>Product Id when the OptionSet is associated to a Product</value>
        [DataMember(Name="ProductId", EmitDefaultValue=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Menu item option set name
        /// </summary>
        /// <value>Menu item option set name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Is master option set. This can affect the layout of the options in the menu displayed to the customer. Usually it is true if the option could be considerd a standalone item as opposed to an addition (\&quot;with ketchup\&quot;) or modifier (\&quot;large\&quot;).
        /// </summary>
        /// <value>Is master option set. This can affect the layout of the options in the menu displayed to the customer. Usually it is true if the option could be considerd a standalone item as opposed to an addition (\&quot;with ketchup\&quot;) or modifier (\&quot;large\&quot;).</value>
        [DataMember(Name="IsMasterOptionSet", EmitDefaultValue=false)]
        public bool? IsMasterOptionSet { get; set; }

        /// <summary>
        /// Display order. Displayed in ascending order.
        /// </summary>
        /// <value>Display order. Displayed in ascending order.</value>
        [DataMember(Name="DisplayOrder", EmitDefaultValue=false)]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Minimum items must be selected
        /// </summary>
        /// <value>Minimum items must be selected</value>
        [DataMember(Name="MinSelectCount", EmitDefaultValue=false)]
        public int? MinSelectCount { get; set; }

        /// <summary>
        /// Maximum number of items can be selected
        /// </summary>
        /// <value>Maximum number of items can be selected</value>
        [DataMember(Name="MaxSelectCount", EmitDefaultValue=false)]
        public int? MaxSelectCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuItemOptionSet {\n");
            sb.Append("  MenuItemOptionSetId: ").Append(MenuItemOptionSetId).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  MenuItemOptionSetItems: ").Append(MenuItemOptionSetItems).Append("\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsMasterOptionSet: ").Append(IsMasterOptionSet).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  MinSelectCount: ").Append(MinSelectCount).Append("\n");
            sb.Append("  MaxSelectCount: ").Append(MaxSelectCount).Append("\n");
            sb.Append("  CellLayoutType: ").Append(CellLayoutType).Append("\n");
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
            return this.Equals(input as MenuItemOptionSet);
        }

        /// <summary>
        /// Returns true if MenuItemOptionSet instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuItemOptionSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuItemOptionSet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MenuItemOptionSetId == input.MenuItemOptionSetId ||
                    (this.MenuItemOptionSetId != null &&
                    this.MenuItemOptionSetId.Equals(input.MenuItemOptionSetId))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.MenuItemOptionSetItems == input.MenuItemOptionSetItems ||
                    this.MenuItemOptionSetItems != null &&
                    this.MenuItemOptionSetItems.SequenceEqual(input.MenuItemOptionSetItems)
                ) && 
                (
                    this.PublicId == input.PublicId ||
                    (this.PublicId != null &&
                    this.PublicId.Equals(input.PublicId))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsMasterOptionSet == input.IsMasterOptionSet ||
                    (this.IsMasterOptionSet != null &&
                    this.IsMasterOptionSet.Equals(input.IsMasterOptionSet))
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
                ) && 
                (
                    this.MinSelectCount == input.MinSelectCount ||
                    (this.MinSelectCount != null &&
                    this.MinSelectCount.Equals(input.MinSelectCount))
                ) && 
                (
                    this.MaxSelectCount == input.MaxSelectCount ||
                    (this.MaxSelectCount != null &&
                    this.MaxSelectCount.Equals(input.MaxSelectCount))
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
                if (this.MenuItemOptionSetId != null)
                    hashCode = hashCode * 59 + this.MenuItemOptionSetId.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.MenuItemOptionSetItems != null)
                    hashCode = hashCode * 59 + this.MenuItemOptionSetItems.GetHashCode();
                if (this.PublicId != null)
                    hashCode = hashCode * 59 + this.PublicId.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsMasterOptionSet != null)
                    hashCode = hashCode * 59 + this.IsMasterOptionSet.GetHashCode();
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
                if (this.MinSelectCount != null)
                    hashCode = hashCode * 59 + this.MinSelectCount.GetHashCode();
                if (this.MaxSelectCount != null)
                    hashCode = hashCode * 59 + this.MaxSelectCount.GetHashCode();
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
