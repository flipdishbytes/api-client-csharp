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
    /// NutritionInfoLabel
    /// </summary>
    [DataContract]
    public partial class NutritionInfoLabel :  IEquatable<NutritionInfoLabel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionInfoLabel" /> class.
        /// </summary>
        /// <param name="name">Name of the allergen / ingredient.</param>
        /// <param name="values">Optional list of values for the allergen / ingredient.</param>
        /// <param name="iconUrl">Url to the icon for the allergen / ingredient.</param>
        public NutritionInfoLabel(string name = default(string), List<string> values = default(List<string>), string iconUrl = default(string))
        {
            this.Name = name;
            this.Values = values;
            this.IconUrl = iconUrl;
        }
        
        /// <summary>
        /// Name of the allergen / ingredient
        /// </summary>
        /// <value>Name of the allergen / ingredient</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Optional list of values for the allergen / ingredient
        /// </summary>
        /// <value>Optional list of values for the allergen / ingredient</value>
        [DataMember(Name="Values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Url to the icon for the allergen / ingredient
        /// </summary>
        /// <value>Url to the icon for the allergen / ingredient</value>
        [DataMember(Name="IconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NutritionInfoLabel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
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
            return this.Equals(input as NutritionInfoLabel);
        }

        /// <summary>
        /// Returns true if NutritionInfoLabel instances are equal
        /// </summary>
        /// <param name="input">Instance of NutritionInfoLabel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NutritionInfoLabel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                return hashCode;
            }
        }
    }

}