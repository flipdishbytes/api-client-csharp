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
    /// Rest api result
    /// </summary>
    [DataContract]
    public partial class RestApiResultPayoutReport3Details :  IEquatable<RestApiResultPayoutReport3Details>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiResultPayoutReport3Details" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestApiResultPayoutReport3Details() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiResultPayoutReport3Details" /> class.
        /// </summary>
        /// <param name="data">Generic data object. (required).</param>
        public RestApiResultPayoutReport3Details(PayoutReport3Details data = default(PayoutReport3Details))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for RestApiResultPayoutReport3Details and cannot be null");
            }
            else
            {
                this.Data = data;
            }
        }
        
        /// <summary>
        /// Generic data object.
        /// </summary>
        /// <value>Generic data object.</value>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public PayoutReport3Details Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestApiResultPayoutReport3Details {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as RestApiResultPayoutReport3Details);
        }

        /// <summary>
        /// Returns true if RestApiResultPayoutReport3Details instances are equal
        /// </summary>
        /// <param name="input">Instance of RestApiResultPayoutReport3Details to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestApiResultPayoutReport3Details input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }
    }

}
