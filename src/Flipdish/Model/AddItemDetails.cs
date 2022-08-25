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
    /// Add item details
    /// </summary>
    [DataContract]
    public partial class AddItemDetails :  IEquatable<AddItemDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddItemDetails" /> class.
        /// </summary>
        /// <param name="promotionalItemId">Promotional Item Id.</param>
        /// <param name="promotionalItemName">Promotional Item Name.</param>
        public AddItemDetails(int? promotionalItemId = default(int?), string promotionalItemName = default(string))
        {
            this.PromotionalItemId = promotionalItemId;
            this.PromotionalItemName = promotionalItemName;
        }
        
        /// <summary>
        /// Promotional Item Id
        /// </summary>
        /// <value>Promotional Item Id</value>
        [DataMember(Name="PromotionalItemId", EmitDefaultValue=false)]
        public int? PromotionalItemId { get; set; }

        /// <summary>
        /// Promotional Item Name
        /// </summary>
        /// <value>Promotional Item Name</value>
        [DataMember(Name="PromotionalItemName", EmitDefaultValue=false)]
        public string PromotionalItemName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddItemDetails {\n");
            sb.Append("  PromotionalItemId: ").Append(PromotionalItemId).Append("\n");
            sb.Append("  PromotionalItemName: ").Append(PromotionalItemName).Append("\n");
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
            return this.Equals(input as AddItemDetails);
        }

        /// <summary>
        /// Returns true if AddItemDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AddItemDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddItemDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PromotionalItemId == input.PromotionalItemId ||
                    (this.PromotionalItemId != null &&
                    this.PromotionalItemId.Equals(input.PromotionalItemId))
                ) && 
                (
                    this.PromotionalItemName == input.PromotionalItemName ||
                    (this.PromotionalItemName != null &&
                    this.PromotionalItemName.Equals(input.PromotionalItemName))
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
                if (this.PromotionalItemId != null)
                    hashCode = hashCode * 59 + this.PromotionalItemId.GetHashCode();
                if (this.PromotionalItemName != null)
                    hashCode = hashCode * 59 + this.PromotionalItemName.GetHashCode();
                return hashCode;
            }
        }
    }

}
