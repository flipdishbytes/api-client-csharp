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
    /// GoogleAddressComponent
    /// </summary>
    [DataContract]
    public partial class GoogleAddressComponent :  IEquatable<GoogleAddressComponent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAddressComponent" /> class.
        /// </summary>
        /// <param name="longName">longName.</param>
        /// <param name="shortName">shortName.</param>
        /// <param name="types">types.</param>
        public GoogleAddressComponent(string longName = default(string), string shortName = default(string), List<string> types = default(List<string>))
        {
            this.Long_name = longName;
            this.Short_name = shortName;
            this.Types = types;
        }
        
        /// <summary>
        /// Gets or Sets Long_name
        /// </summary>
        [DataMember(Name="Long_name", EmitDefaultValue=false)]
        public string Long_name { get; set; }

        /// <summary>
        /// Gets or Sets Short_name
        /// </summary>
        [DataMember(Name="Short_name", EmitDefaultValue=false)]
        public string Short_name { get; set; }

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name="Types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleAddressComponent {\n");
            sb.Append("  Long_name: ").Append(Long_name).Append("\n");
            sb.Append("  Short_name: ").Append(Short_name).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return this.Equals(input as GoogleAddressComponent);
        }

        /// <summary>
        /// Returns true if GoogleAddressComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of GoogleAddressComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleAddressComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Long_name == input.Long_name ||
                    (this.Long_name != null &&
                    this.Long_name.Equals(input.Long_name))
                ) && 
                (
                    this.Short_name == input.Short_name ||
                    (this.Short_name != null &&
                    this.Short_name.Equals(input.Short_name))
                ) && 
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(input.Types)
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
                if (this.Long_name != null)
                    hashCode = hashCode * 59 + this.Long_name.GetHashCode();
                if (this.Short_name != null)
                    hashCode = hashCode * 59 + this.Short_name.GetHashCode();
                if (this.Types != null)
                    hashCode = hashCode * 59 + this.Types.GetHashCode();
                return hashCode;
            }
        }
    }

}
