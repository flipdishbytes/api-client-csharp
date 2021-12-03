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
    /// Information to create a reference to a {Flipdish.PublicModels.V1.Catalog.Items.CatalogItem}
    /// </summary>
    [DataContract]
    public partial class CreateCatalogItemReference :  IEquatable<CreateCatalogItemReference>, IValidatableObject
    {
        /// <summary>
        /// Type of the SupProduct
        /// </summary>
        /// <value>Type of the SupProduct</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ItemTypeEnum
        {
            
            /// <summary>
            /// Enum Product for value: Product
            /// </summary>
            [EnumMember(Value = "Product")]
            Product = 1,
            
            /// <summary>
            /// Enum Modifier for value: Modifier
            /// </summary>
            [EnumMember(Value = "Modifier")]
            Modifier = 2
        }

        /// <summary>
        /// Type of the SupProduct
        /// </summary>
        /// <value>Type of the SupProduct</value>
        [DataMember(Name="ItemType", EmitDefaultValue=false)]
        public ItemTypeEnum ItemType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCatalogItemReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCatalogItemReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCatalogItemReference" /> class.
        /// </summary>
        /// <param name="catalogItemId">Identifier of the CatalogItemId to use as SubProduct (required).</param>
        /// <param name="itemType">Type of the SupProduct (required).</param>
        /// <param name="preselectedQuantity">Quantity of the modifier that will be set when the parent product is placed in the basket.</param>
        public CreateCatalogItemReference(string catalogItemId = default(string), ItemTypeEnum itemType = default(ItemTypeEnum), int? preselectedQuantity = default(int?))
        {
            // to ensure "catalogItemId" is required (not null)
            if (catalogItemId == null)
            {
                throw new InvalidDataException("catalogItemId is a required property for CreateCatalogItemReference and cannot be null");
            }
            else
            {
                this.CatalogItemId = catalogItemId;
            }
            // to ensure "itemType" is required (not null)
            if (itemType == null)
            {
                throw new InvalidDataException("itemType is a required property for CreateCatalogItemReference and cannot be null");
            }
            else
            {
                this.ItemType = itemType;
            }
            this.PreselectedQuantity = preselectedQuantity;
        }
        
        /// <summary>
        /// Identifier of the CatalogItemId to use as SubProduct
        /// </summary>
        /// <value>Identifier of the CatalogItemId to use as SubProduct</value>
        [DataMember(Name="CatalogItemId", EmitDefaultValue=false)]
        public string CatalogItemId { get; set; }


        /// <summary>
        /// Quantity of the modifier that will be set when the parent product is placed in the basket
        /// </summary>
        /// <value>Quantity of the modifier that will be set when the parent product is placed in the basket</value>
        [DataMember(Name="PreselectedQuantity", EmitDefaultValue=false)]
        public int? PreselectedQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCatalogItemReference {\n");
            sb.Append("  CatalogItemId: ").Append(CatalogItemId).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  PreselectedQuantity: ").Append(PreselectedQuantity).Append("\n");
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
            return this.Equals(input as CreateCatalogItemReference);
        }

        /// <summary>
        /// Returns true if CreateCatalogItemReference instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCatalogItemReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCatalogItemReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CatalogItemId == input.CatalogItemId ||
                    (this.CatalogItemId != null &&
                    this.CatalogItemId.Equals(input.CatalogItemId))
                ) && 
                (
                    this.ItemType == input.ItemType ||
                    (this.ItemType != null &&
                    this.ItemType.Equals(input.ItemType))
                ) && 
                (
                    this.PreselectedQuantity == input.PreselectedQuantity ||
                    (this.PreselectedQuantity != null &&
                    this.PreselectedQuantity.Equals(input.PreselectedQuantity))
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
                if (this.CatalogItemId != null)
                    hashCode = hashCode * 59 + this.CatalogItemId.GetHashCode();
                if (this.ItemType != null)
                    hashCode = hashCode * 59 + this.ItemType.GetHashCode();
                if (this.PreselectedQuantity != null)
                    hashCode = hashCode * 59 + this.PreselectedQuantity.GetHashCode();
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
            // CatalogItemId (string) maxLength
            if(this.CatalogItemId != null && this.CatalogItemId.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CatalogItemId, length must be less than 30.", new [] { "CatalogItemId" });
            }

            // CatalogItemId (string) minLength
            if(this.CatalogItemId != null && this.CatalogItemId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CatalogItemId, length must be greater than 0.", new [] { "CatalogItemId" });
            }

            yield break;
        }
    }

}
