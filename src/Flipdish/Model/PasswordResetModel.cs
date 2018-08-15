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
    /// Password reset model
    /// </summary>
    [DataContract]
    public partial class PasswordResetModel :  IEquatable<PasswordResetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordResetModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordResetModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordResetModel" /> class.
        /// </summary>
        /// <param name="Email">Email address.</param>
        /// <param name="Password">Password (required).</param>
        /// <param name="PasswordConfirmation">Password confirmation (required).</param>
        /// <param name="Token">Password reset token.</param>
        public PasswordResetModel(string Email = default(string), string Password = default(string), string PasswordConfirmation = default(string), string Token = default(string))
        {
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for PasswordResetModel and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            // to ensure "PasswordConfirmation" is required (not null)
            if (PasswordConfirmation == null)
            {
                throw new InvalidDataException("PasswordConfirmation is a required property for PasswordResetModel and cannot be null");
            }
            else
            {
                this.PasswordConfirmation = PasswordConfirmation;
            }
            this.Email = Email;
            this.Token = Token;
        }
        
        /// <summary>
        /// Email address
        /// </summary>
        /// <value>Email address</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// <value>Password</value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Password confirmation
        /// </summary>
        /// <value>Password confirmation</value>
        [DataMember(Name="PasswordConfirmation", EmitDefaultValue=false)]
        public string PasswordConfirmation { get; set; }

        /// <summary>
        /// Password reset token
        /// </summary>
        /// <value>Password reset token</value>
        [DataMember(Name="Token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordResetModel {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PasswordConfirmation: ").Append(PasswordConfirmation).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as PasswordResetModel);
        }

        /// <summary>
        /// Returns true if PasswordResetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordResetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordResetModel input)
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
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PasswordConfirmation == input.PasswordConfirmation ||
                    (this.PasswordConfirmation != null &&
                    this.PasswordConfirmation.Equals(input.PasswordConfirmation))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PasswordConfirmation != null)
                    hashCode = hashCode * 59 + this.PasswordConfirmation.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
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
