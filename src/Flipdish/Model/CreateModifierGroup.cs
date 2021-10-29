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
    /// Information to create a Modifier Group
    /// </summary>
    [DataContract]
    public partial class CreateModifierGroup : CreateProduct,  IEquatable<CreateModifierGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModifierGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateModifierGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModifierGroup" /> class.
        /// </summary>
        /// <param name="subProducts">Collection of products associated with this product.</param>
        public CreateModifierGroup(List<ModifierGroupSubProduct> subProducts = default(List<ModifierGroupSubProduct>), string sku = default(string), string name = default(string), string description = default(string), double? price = default(double?), string discriminator = "CreateModifierGroup") : base(sku, name, description, price, discriminator)
        {
            this.subProducts = subProducts;
        }
        
        /// <summary>
        /// Collection of products associated with this product
        /// </summary>
        /// <value>Collection of products associated with this product</value>
        [DataMember(Name="subProducts", EmitDefaultValue=false)]
        public List<ModifierGroupSubProduct> subProducts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateModifierGroup {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  subProducts: ").Append(subProducts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as CreateModifierGroup);
        }

        /// <summary>
        /// Returns true if CreateModifierGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateModifierGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateModifierGroup input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.subProducts == input.subProducts ||
                    this.subProducts != null &&
                    this.subProducts.SequenceEqual(input.subProducts)
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
                int hashCode = base.GetHashCode();
                if (this.subProducts != null)
                    hashCode = hashCode * 59 + this.subProducts.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
