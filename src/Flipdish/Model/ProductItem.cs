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
    /// Item
    /// </summary>
    [DataContract]
    public partial class ProductItem :  IEquatable<ProductItem>, IValidatableObject
    {
        /// <summary>
        /// Small | Medium | Large | HiddenImage  Affects the layout of the menu.
        /// </summary>
        /// <value>Small | Medium | Large | HiddenImage  Affects the layout of the menu.</value>
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
        /// Small | Medium | Large | HiddenImage  Affects the layout of the menu.
        /// </summary>
        /// <value>Small | Medium | Large | HiddenImage  Affects the layout of the menu.</value>
        [DataMember(Name="CellLayoutType", EmitDefaultValue=false)]
        public CellLayoutTypeEnum? CellLayoutType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductItem" /> class.
        /// </summary>
        /// <param name="productId">Product Id to the product to add as Menu Item (required).</param>
        /// <param name="cellLayoutType">Small | Medium | Large | HiddenImage  Affects the layout of the menu..</param>
        public ProductItem(string productId = default(string), CellLayoutTypeEnum? cellLayoutType = default(CellLayoutTypeEnum?))
        {
            // to ensure "productId" is required (not null)
            if (productId == null)
            {
                throw new InvalidDataException("productId is a required property for ProductItem and cannot be null");
            }
            else
            {
                this.ProductId = productId;
            }
            this.CellLayoutType = cellLayoutType;
        }
        
        /// <summary>
        /// Product Id to the product to add as Menu Item
        /// </summary>
        /// <value>Product Id to the product to add as Menu Item</value>
        [DataMember(Name="ProductId", EmitDefaultValue=false)]
        public string ProductId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductItem {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
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
            return this.Equals(input as ProductItem);
        }

        /// <summary>
        /// Returns true if ProductItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
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
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
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
            // ProductId (string) maxLength
            if(this.ProductId != null && this.ProductId.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductId, length must be less than 30.", new [] { "ProductId" });
            }

            // ProductId (string) minLength
            if(this.ProductId != null && this.ProductId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductId, length must be greater than 0.", new [] { "ProductId" });
            }

            yield break;
        }
    }

}