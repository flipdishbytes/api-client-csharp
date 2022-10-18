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
    /// RequestPasswordResetModel
    /// </summary>
    [DataContract]
    public partial class RequestPasswordResetModel :  IEquatable<RequestPasswordResetModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPasswordResetModel" /> class.
        /// </summary>
        /// <param name="email">Email address.</param>
        /// <param name="recaptchaToken">Google Recaptcha Token.</param>
        public RequestPasswordResetModel(string email = default(string), string recaptchaToken = default(string))
        {
            this.Email = email;
            this.RecaptchaToken = recaptchaToken;
        }
        
        /// <summary>
        /// Email address
        /// </summary>
        /// <value>Email address</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Google Recaptcha Token
        /// </summary>
        /// <value>Google Recaptcha Token</value>
        [DataMember(Name="RecaptchaToken", EmitDefaultValue=false)]
        public string RecaptchaToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestPasswordResetModel {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  RecaptchaToken: ").Append(RecaptchaToken).Append("\n");
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
            return this.Equals(input as RequestPasswordResetModel);
        }

        /// <summary>
        /// Returns true if RequestPasswordResetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestPasswordResetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestPasswordResetModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.RecaptchaToken == input.RecaptchaToken ||
                    (this.RecaptchaToken != null &&
                    this.RecaptchaToken.Equals(input.RecaptchaToken))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.RecaptchaToken != null)
                    hashCode = hashCode * 59 + this.RecaptchaToken.GetHashCode();
                return hashCode;
            }
        }
    }

}
