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
    /// Change password model
    /// </summary>
    [DataContract]
    public partial class ChangePasswordModel :  IEquatable<ChangePasswordModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordModel" /> class.
        /// </summary>
        /// <param name="OldPassword">Old password.</param>
        /// <param name="NewPassword">New password.</param>
        /// <param name="PasswordConfirmation">Password confirmation.</param>
        public ChangePasswordModel(string OldPassword = default(string), string NewPassword = default(string), string PasswordConfirmation = default(string))
        {
            this.OldPassword = OldPassword;
            this.NewPassword = NewPassword;
            this.PasswordConfirmation = PasswordConfirmation;
        }
        
        /// <summary>
        /// Old password
        /// </summary>
        /// <value>Old password</value>
        [DataMember(Name="OldPassword", EmitDefaultValue=false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// New password
        /// </summary>
        /// <value>New password</value>
        [DataMember(Name="NewPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// Password confirmation
        /// </summary>
        /// <value>Password confirmation</value>
        [DataMember(Name="PasswordConfirmation", EmitDefaultValue=false)]
        public string PasswordConfirmation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePasswordModel {\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  PasswordConfirmation: ").Append(PasswordConfirmation).Append("\n");
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
            return this.Equals(input as ChangePasswordModel);
        }

        /// <summary>
        /// Returns true if ChangePasswordModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangePasswordModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePasswordModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldPassword == input.OldPassword ||
                    (this.OldPassword != null &&
                    this.OldPassword.Equals(input.OldPassword))
                ) && 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.PasswordConfirmation == input.PasswordConfirmation ||
                    (this.PasswordConfirmation != null &&
                    this.PasswordConfirmation.Equals(input.PasswordConfirmation))
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
                if (this.OldPassword != null)
                    hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                if (this.PasswordConfirmation != null)
                    hashCode = hashCode * 59 + this.PasswordConfirmation.GetHashCode();
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
