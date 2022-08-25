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
    /// Response
    /// </summary>
    [DataContract]
    public partial class Response :  IEquatable<Response>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        /// <param name="stores">stores.</param>
        public Response(List<StoreItemHeader> stores = default(List<StoreItemHeader>))
        {
            this.Stores = stores;
        }
        
        /// <summary>
        /// Gets or Sets Stores
        /// </summary>
        [DataMember(Name="Stores", EmitDefaultValue=false)]
        public List<StoreItemHeader> Stores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Response {\n");
            sb.Append("  Stores: ").Append(Stores).Append("\n");
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
            return this.Equals(input as Response);
        }

        /// <summary>
        /// Returns true if Response instances are equal
        /// </summary>
        /// <param name="input">Instance of Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stores == input.Stores ||
                    this.Stores != null &&
                    this.Stores.SequenceEqual(input.Stores)
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
                if (this.Stores != null)
                    hashCode = hashCode * 59 + this.Stores.GetHashCode();
                return hashCode;
            }
        }
    }

}
