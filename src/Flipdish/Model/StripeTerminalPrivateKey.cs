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
    /// Stripe Terminal Private Key
    /// </summary>
    [DataContract]
    public partial class StripeTerminalPrivateKey :  IEquatable<StripeTerminalPrivateKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeTerminalPrivateKey" /> class.
        /// </summary>
        /// <param name="location">Registered location of the terminal.</param>
        /// <param name="secret">Secret used to pass to stripe to attach terminal.</param>
        public StripeTerminalPrivateKey(string location = default(string), string secret = default(string))
        {
            this.Location = location;
            this.Secret = secret;
        }
        
        /// <summary>
        /// Registered location of the terminal
        /// </summary>
        /// <value>Registered location of the terminal</value>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Secret used to pass to stripe to attach terminal
        /// </summary>
        /// <value>Secret used to pass to stripe to attach terminal</value>
        [DataMember(Name="Secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StripeTerminalPrivateKey {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
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
            return this.Equals(input as StripeTerminalPrivateKey);
        }

        /// <summary>
        /// Returns true if StripeTerminalPrivateKey instances are equal
        /// </summary>
        /// <param name="input">Instance of StripeTerminalPrivateKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripeTerminalPrivateKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
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
