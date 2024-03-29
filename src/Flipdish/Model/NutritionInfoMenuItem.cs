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
    /// NutritionInfoMenuItem
    /// </summary>
    [DataContract]
    public partial class NutritionInfoMenuItem :  IEquatable<NutritionInfoMenuItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionInfoMenuItem" /> class.
        /// </summary>
        /// <param name="publicId">Menu item public id.</param>
        /// <param name="labels">List of Nutrition Info Labels for this menu item.</param>
        public NutritionInfoMenuItem(Guid? publicId = default(Guid?), List<NutritionInfoLabel> labels = default(List<NutritionInfoLabel>))
        {
            this.PublicId = publicId;
            this.Labels = labels;
        }
        
        /// <summary>
        /// Menu item public id
        /// </summary>
        /// <value>Menu item public id</value>
        [DataMember(Name="PublicId", EmitDefaultValue=false)]
        public Guid? PublicId { get; set; }

        /// <summary>
        /// List of Nutrition Info Labels for this menu item
        /// </summary>
        /// <value>List of Nutrition Info Labels for this menu item</value>
        [DataMember(Name="Labels", EmitDefaultValue=false)]
        public List<NutritionInfoLabel> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NutritionInfoMenuItem {\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
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
            return this.Equals(input as NutritionInfoMenuItem);
        }

        /// <summary>
        /// Returns true if NutritionInfoMenuItem instances are equal
        /// </summary>
        /// <param name="input">Instance of NutritionInfoMenuItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NutritionInfoMenuItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicId == input.PublicId ||
                    (this.PublicId != null &&
                    this.PublicId.Equals(input.PublicId))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
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
                if (this.PublicId != null)
                    hashCode = hashCode * 59 + this.PublicId.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                return hashCode;
            }
        }
    }

}
