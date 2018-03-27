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
    /// UserEventInfo
    /// </summary>
    [DataContract]
    public partial class UserEventInfo :  IEquatable<UserEventInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventInfo" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="UserPhoneNumber">UserPhoneNumber.</param>
        /// <param name="UserEmail">UserEmail.</param>
        public UserEventInfo(int? UserId = default(int?), string UserName = default(string), string UserPhoneNumber = default(string), string UserEmail = default(string))
        {
            this.UserId = UserId;
            this.UserName = UserName;
            this.UserPhoneNumber = UserPhoneNumber;
            this.UserEmail = UserEmail;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets UserPhoneNumber
        /// </summary>
        [DataMember(Name="userPhoneNumber", EmitDefaultValue=false)]
        public string UserPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets UserEmail
        /// </summary>
        [DataMember(Name="userEmail", EmitDefaultValue=false)]
        public string UserEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserEventInfo {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserPhoneNumber: ").Append(UserPhoneNumber).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
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
            return this.Equals(input as UserEventInfo);
        }

        /// <summary>
        /// Returns true if UserEventInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of UserEventInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserEventInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.UserPhoneNumber == input.UserPhoneNumber ||
                    (this.UserPhoneNumber != null &&
                    this.UserPhoneNumber.Equals(input.UserPhoneNumber))
                ) && 
                (
                    this.UserEmail == input.UserEmail ||
                    (this.UserEmail != null &&
                    this.UserEmail.Equals(input.UserEmail))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserPhoneNumber != null)
                    hashCode = hashCode * 59 + this.UserPhoneNumber.GetHashCode();
                if (this.UserEmail != null)
                    hashCode = hashCode * 59 + this.UserEmail.GetHashCode();
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
