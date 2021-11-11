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
    /// Product associated to a SimpleProduct
    /// </summary>
    [DataContract]
    public partial class ModifierGroupSubProduct :  IEquatable<ModifierGroupSubProduct>, IValidatableObject
    {
        /// <summary>
        /// Type of the SupProduct
        /// </summary>
        /// <value>Type of the SupProduct</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductTypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum SimpleProduct for value: SimpleProduct
            /// </summary>
            [EnumMember(Value = "SimpleProduct")]
            SimpleProduct = 2,
            
            /// <summary>
            /// Enum Modifier for value: Modifier
            /// </summary>
            [EnumMember(Value = "Modifier")]
            Modifier = 3,
            
            /// <summary>
            /// Enum ModifierGroup for value: ModifierGroup
            /// </summary>
            [EnumMember(Value = "ModifierGroup")]
            ModifierGroup = 4
        }

        /// <summary>
        /// Type of the SupProduct
        /// </summary>
        /// <value>Type of the SupProduct</value>
        [DataMember(Name="ProductType", EmitDefaultValue=false)]
        public ProductTypeEnum ProductType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifierGroupSubProduct" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModifierGroupSubProduct() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifierGroupSubProduct" /> class.
        /// </summary>
        /// <param name="preselectedQuantity">Quantity of the modifier that will be set when the parent product is placed in the basket.</param>
        /// <param name="productId">Identifier of the ProductId to use as SubProduct (required).</param>
        /// <param name="productType">Type of the SupProduct (required).</param>
        /// <param name="product">Details of the sub product.</param>
        public ModifierGroupSubProduct(int? preselectedQuantity = default(int?), string productId = default(string), ProductTypeEnum productType = default(ProductTypeEnum), Product product = default(Product))
        {
            // to ensure "productId" is required (not null)
            if (productId == null)
            {
                throw new InvalidDataException("productId is a required property for ModifierGroupSubProduct and cannot be null");
            }
            else
            {
                this.ProductId = productId;
            }
            // to ensure "productType" is required (not null)
            if (productType == null)
            {
                throw new InvalidDataException("productType is a required property for ModifierGroupSubProduct and cannot be null");
            }
            else
            {
                this.ProductType = productType;
            }
            this.PreselectedQuantity = preselectedQuantity;
            this.Product = product;
        }
        
        /// <summary>
        /// Quantity of the modifier that will be set when the parent product is placed in the basket
        /// </summary>
        /// <value>Quantity of the modifier that will be set when the parent product is placed in the basket</value>
        [DataMember(Name="PreselectedQuantity", EmitDefaultValue=false)]
        public int? PreselectedQuantity { get; set; }

        /// <summary>
        /// Identifier of the ProductId to use as SubProduct
        /// </summary>
        /// <value>Identifier of the ProductId to use as SubProduct</value>
        [DataMember(Name="ProductId", EmitDefaultValue=false)]
        public string ProductId { get; set; }


        /// <summary>
        /// Details of the sub product
        /// </summary>
        /// <value>Details of the sub product</value>
        [DataMember(Name="Product", EmitDefaultValue=false)]
        public Product Product { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifierGroupSubProduct {\n");
            sb.Append("  PreselectedQuantity: ").Append(PreselectedQuantity).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
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
            return this.Equals(input as ModifierGroupSubProduct);
        }

        /// <summary>
        /// Returns true if ModifierGroupSubProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifierGroupSubProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifierGroupSubProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreselectedQuantity == input.PreselectedQuantity ||
                    (this.PreselectedQuantity != null &&
                    this.PreselectedQuantity.Equals(input.PreselectedQuantity))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
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
                if (this.PreselectedQuantity != null)
                    hashCode = hashCode * 59 + this.PreselectedQuantity.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
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