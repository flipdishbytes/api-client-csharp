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
    /// MenuNutritionInfoHeader
    /// </summary>
    [DataContract]
    public partial class MenuNutritionInfoHeader :  IEquatable<MenuNutritionInfoHeader>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuNutritionInfoHeader" /> class.
        /// </summary>
        /// <param name="menuId">Menu Id.</param>
        /// <param name="nutritionInfoVersionGuid">Nutrition information version guid (generated every time the nutrition information is updated).</param>
        /// <param name="absoluteUrl">Absolute URL of the nutrition information json file.</param>
        public MenuNutritionInfoHeader(int? menuId = default(int?), Guid? nutritionInfoVersionGuid = default(Guid?), string absoluteUrl = default(string))
        {
            this.MenuId = menuId;
            this.NutritionInfoVersionGuid = nutritionInfoVersionGuid;
            this.AbsoluteUrl = absoluteUrl;
        }
        
        /// <summary>
        /// Menu Id
        /// </summary>
        /// <value>Menu Id</value>
        [DataMember(Name="MenuId", EmitDefaultValue=false)]
        public int? MenuId { get; set; }

        /// <summary>
        /// Nutrition information version guid (generated every time the nutrition information is updated)
        /// </summary>
        /// <value>Nutrition information version guid (generated every time the nutrition information is updated)</value>
        [DataMember(Name="NutritionInfoVersionGuid", EmitDefaultValue=false)]
        public Guid? NutritionInfoVersionGuid { get; set; }

        /// <summary>
        /// Absolute URL of the nutrition information json file
        /// </summary>
        /// <value>Absolute URL of the nutrition information json file</value>
        [DataMember(Name="AbsoluteUrl", EmitDefaultValue=false)]
        public string AbsoluteUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuNutritionInfoHeader {\n");
            sb.Append("  MenuId: ").Append(MenuId).Append("\n");
            sb.Append("  NutritionInfoVersionGuid: ").Append(NutritionInfoVersionGuid).Append("\n");
            sb.Append("  AbsoluteUrl: ").Append(AbsoluteUrl).Append("\n");
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
            return this.Equals(input as MenuNutritionInfoHeader);
        }

        /// <summary>
        /// Returns true if MenuNutritionInfoHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuNutritionInfoHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuNutritionInfoHeader input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MenuId == input.MenuId ||
                    (this.MenuId != null &&
                    this.MenuId.Equals(input.MenuId))
                ) && 
                (
                    this.NutritionInfoVersionGuid == input.NutritionInfoVersionGuid ||
                    (this.NutritionInfoVersionGuid != null &&
                    this.NutritionInfoVersionGuid.Equals(input.NutritionInfoVersionGuid))
                ) && 
                (
                    this.AbsoluteUrl == input.AbsoluteUrl ||
                    (this.AbsoluteUrl != null &&
                    this.AbsoluteUrl.Equals(input.AbsoluteUrl))
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
                if (this.MenuId != null)
                    hashCode = hashCode * 59 + this.MenuId.GetHashCode();
                if (this.NutritionInfoVersionGuid != null)
                    hashCode = hashCode * 59 + this.NutritionInfoVersionGuid.GetHashCode();
                if (this.AbsoluteUrl != null)
                    hashCode = hashCode * 59 + this.AbsoluteUrl.GetHashCode();
                return hashCode;
            }
        }
    }

}
