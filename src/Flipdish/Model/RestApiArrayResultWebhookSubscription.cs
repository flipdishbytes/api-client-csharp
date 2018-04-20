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
    /// Rest api array result
    /// </summary>
    [DataContract]
    public partial class RestApiArrayResultWebhookSubscription :  IEquatable<RestApiArrayResultWebhookSubscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiArrayResultWebhookSubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestApiArrayResultWebhookSubscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiArrayResultWebhookSubscription" /> class.
        /// </summary>
        /// <param name="Data">Generic data object. (required).</param>
        public RestApiArrayResultWebhookSubscription(List<WebhookSubscription> Data = default(List<WebhookSubscription>))
        {
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for RestApiArrayResultWebhookSubscription and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
        }
        
        /// <summary>
        /// Generic data object.
        /// </summary>
        /// <value>Generic data object.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<WebhookSubscription> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestApiArrayResultWebhookSubscription {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as RestApiArrayResultWebhookSubscription);
        }

        /// <summary>
        /// Returns true if RestApiArrayResultWebhookSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of RestApiArrayResultWebhookSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestApiArrayResultWebhookSubscription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
