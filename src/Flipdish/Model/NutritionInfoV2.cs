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
    /// Menu Nutrition Information. Version 2 (localized).
    /// </summary>
    [DataContract]
    public partial class NutritionInfoV2 :  IEquatable<NutritionInfoV2>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionInfoV2" /> class.
        /// </summary>
        /// <param name="menuItems">List of menu item nutrition infos.</param>
        /// <param name="menuItemOptionSetItems">List of menu item option set nutrition infos.</param>
        /// <param name="imageBaseUrl">Base url for allergen images.</param>
        public NutritionInfoV2(List<NutritionInfoV2Item> menuItems = default(List<NutritionInfoV2Item>), List<NutritionInfoV2Item> menuItemOptionSetItems = default(List<NutritionInfoV2Item>), string imageBaseUrl = default(string))
        {
            this.MenuItems = menuItems;
            this.MenuItemOptionSetItems = menuItemOptionSetItems;
            this.ImageBaseUrl = imageBaseUrl;
        }
        
        /// <summary>
        /// List of menu item nutrition infos
        /// </summary>
        /// <value>List of menu item nutrition infos</value>
        [DataMember(Name="MenuItems", EmitDefaultValue=false)]
        public List<NutritionInfoV2Item> MenuItems { get; set; }

        /// <summary>
        /// List of menu item option set nutrition infos
        /// </summary>
        /// <value>List of menu item option set nutrition infos</value>
        [DataMember(Name="MenuItemOptionSetItems", EmitDefaultValue=false)]
        public List<NutritionInfoV2Item> MenuItemOptionSetItems { get; set; }

        /// <summary>
        /// Base url for allergen images
        /// </summary>
        /// <value>Base url for allergen images</value>
        [DataMember(Name="ImageBaseUrl", EmitDefaultValue=false)]
        public string ImageBaseUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NutritionInfoV2 {\n");
            sb.Append("  MenuItems: ").Append(MenuItems).Append("\n");
            sb.Append("  MenuItemOptionSetItems: ").Append(MenuItemOptionSetItems).Append("\n");
            sb.Append("  ImageBaseUrl: ").Append(ImageBaseUrl).Append("\n");
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
            return this.Equals(input as NutritionInfoV2);
        }

        /// <summary>
        /// Returns true if NutritionInfoV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of NutritionInfoV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NutritionInfoV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MenuItems == input.MenuItems ||
                    this.MenuItems != null &&
                    this.MenuItems.SequenceEqual(input.MenuItems)
                ) && 
                (
                    this.MenuItemOptionSetItems == input.MenuItemOptionSetItems ||
                    this.MenuItemOptionSetItems != null &&
                    this.MenuItemOptionSetItems.SequenceEqual(input.MenuItemOptionSetItems)
                ) && 
                (
                    this.ImageBaseUrl == input.ImageBaseUrl ||
                    (this.ImageBaseUrl != null &&
                    this.ImageBaseUrl.Equals(input.ImageBaseUrl))
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
                if (this.MenuItems != null)
                    hashCode = hashCode * 59 + this.MenuItems.GetHashCode();
                if (this.MenuItemOptionSetItems != null)
                    hashCode = hashCode * 59 + this.MenuItemOptionSetItems.GetHashCode();
                if (this.ImageBaseUrl != null)
                    hashCode = hashCode * 59 + this.ImageBaseUrl.GetHashCode();
                return hashCode;
            }
        }
    }

}
