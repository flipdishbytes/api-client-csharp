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
    /// Home statitstics
    /// </summary>
    [DataContract]
    public partial class HomeStatistics :  IEquatable<HomeStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomeStatistics" /> class.
        /// </summary>
        /// <param name="totalMoneySaved">Money saved.</param>
        public HomeStatistics(List<CurrencyData> totalMoneySaved = default(List<CurrencyData>))
        {
            this.TotalMoneySaved = totalMoneySaved;
        }
        
        /// <summary>
        /// Money saved
        /// </summary>
        /// <value>Money saved</value>
        [DataMember(Name="TotalMoneySaved", EmitDefaultValue=false)]
        public List<CurrencyData> TotalMoneySaved { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HomeStatistics {\n");
            sb.Append("  TotalMoneySaved: ").Append(TotalMoneySaved).Append("\n");
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
            return this.Equals(input as HomeStatistics);
        }

        /// <summary>
        /// Returns true if HomeStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of HomeStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HomeStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalMoneySaved == input.TotalMoneySaved ||
                    this.TotalMoneySaved != null &&
                    this.TotalMoneySaved.SequenceEqual(input.TotalMoneySaved)
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
                if (this.TotalMoneySaved != null)
                    hashCode = hashCode * 59 + this.TotalMoneySaved.GetHashCode();
                return hashCode;
            }
        }
    }

}
