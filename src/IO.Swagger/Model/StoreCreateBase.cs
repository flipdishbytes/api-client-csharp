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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Store Create Base
    /// </summary>
    [DataContract]
    public partial class StoreCreateBase :  IEquatable<StoreCreateBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreCreateBase" /> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="emailAddress">Email address (visible to customers).</param>
        /// <param name="staffLanguage">Staff Language (used for communication with the staff)  Emails, Printouts etc.</param>
        public StoreCreateBase(string name = default(string), string emailAddress = default(string), string staffLanguage = default(string))
        {
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.StaffLanguage = staffLanguage;
        }
        
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Email address (visible to customers)
        /// </summary>
        /// <value>Email address (visible to customers)</value>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Staff Language (used for communication with the staff)  Emails, Printouts etc
        /// </summary>
        /// <value>Staff Language (used for communication with the staff)  Emails, Printouts etc</value>
        [DataMember(Name="StaffLanguage", EmitDefaultValue=false)]
        public string StaffLanguage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreCreateBase {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  StaffLanguage: ").Append(StaffLanguage).Append("\n");
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
            return this.Equals(input as StoreCreateBase);
        }

        /// <summary>
        /// Returns true if StoreCreateBase instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreCreateBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreCreateBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.StaffLanguage == input.StaffLanguage ||
                    (this.StaffLanguage != null &&
                    this.StaffLanguage.Equals(input.StaffLanguage))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.StaffLanguage != null)
                    hashCode = hashCode * 59 + this.StaffLanguage.GetHashCode();
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
            // EmailAddress (string) maxLength
            if(this.EmailAddress != null && this.EmailAddress.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be less than 100.", new [] { "EmailAddress" });
            }

            // EmailAddress (string) minLength
            if(this.EmailAddress != null && this.EmailAddress.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be greater than 0.", new [] { "EmailAddress" });
            }

            yield break;
        }
    }

}
