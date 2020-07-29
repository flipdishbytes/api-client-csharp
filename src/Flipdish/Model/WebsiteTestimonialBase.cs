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
    /// Represents a testimonial base
    /// </summary>
    [DataContract]
    public partial class WebsiteTestimonialBase :  IEquatable<WebsiteTestimonialBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteTestimonialBase" /> class.
        /// </summary>
        /// <param name="author">Author of the testimonial.</param>
        /// <param name="message">Message of the testimonial.</param>
        public WebsiteTestimonialBase(string author = default(string), string message = default(string))
        {
            this.Author = author;
            this.Message = message;
        }
        
        /// <summary>
        /// Author of the testimonial
        /// </summary>
        /// <value>Author of the testimonial</value>
        [DataMember(Name="Author", EmitDefaultValue=false)]
        public string Author { get; set; }

        /// <summary>
        /// Message of the testimonial
        /// </summary>
        /// <value>Message of the testimonial</value>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebsiteTestimonialBase {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as WebsiteTestimonialBase);
        }

        /// <summary>
        /// Returns true if WebsiteTestimonialBase instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsiteTestimonialBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsiteTestimonialBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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