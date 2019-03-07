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
    /// Account details
    /// </summary>
    [DataContract]
    public partial class AccountDetail :  IEquatable<AccountDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetail" /> class.
        /// </summary>
        /// <param name="email">Email.</param>
        /// <param name="signupSteps">Signup steps.</param>
        /// <param name="isVerified">Is account email verified.</param>
        /// <param name="isSelfServeUser">is the account a Self Server.</param>
        /// <param name="name">Name.</param>
        /// <param name="language">Language Id.</param>
        /// <param name="timeZoneInfoId">Time Zone Info Id.</param>
        /// <param name="displayTimesInUserLocalTimeZone">Display the time in time zone local to the user.</param>
        public AccountDetail(string email = default(string), List<SignupStep> signupSteps = default(List<SignupStep>), bool? isVerified = default(bool?), bool? isSelfServeUser = default(bool?), string name = default(string), string language = default(string), string timeZoneInfoId = default(string), bool? displayTimesInUserLocalTimeZone = default(bool?))
        {
            this.Email = email;
            this.SignupSteps = signupSteps;
            this.IsVerified = isVerified;
            this.IsSelfServeUser = isSelfServeUser;
            this.Name = name;
            this.Language = language;
            this.TimeZoneInfoId = timeZoneInfoId;
            this.DisplayTimesInUserLocalTimeZone = displayTimesInUserLocalTimeZone;
        }
        
        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Signup steps
        /// </summary>
        /// <value>Signup steps</value>
        [DataMember(Name="SignupSteps", EmitDefaultValue=false)]
        public List<SignupStep> SignupSteps { get; set; }

        /// <summary>
        /// Is account email verified
        /// </summary>
        /// <value>Is account email verified</value>
        [DataMember(Name="IsVerified", EmitDefaultValue=false)]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// is the account a Self Server
        /// </summary>
        /// <value>is the account a Self Server</value>
        [DataMember(Name="IsSelfServeUser", EmitDefaultValue=false)]
        public bool? IsSelfServeUser { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Language Id
        /// </summary>
        /// <value>Language Id</value>
        [DataMember(Name="Language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Time Zone Info Id
        /// </summary>
        /// <value>Time Zone Info Id</value>
        [DataMember(Name="TimeZoneInfoId", EmitDefaultValue=false)]
        public string TimeZoneInfoId { get; set; }

        /// <summary>
        /// Display the time in time zone local to the user
        /// </summary>
        /// <value>Display the time in time zone local to the user</value>
        [DataMember(Name="DisplayTimesInUserLocalTimeZone", EmitDefaultValue=false)]
        public bool? DisplayTimesInUserLocalTimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountDetail {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  SignupSteps: ").Append(SignupSteps).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
            sb.Append("  IsSelfServeUser: ").Append(IsSelfServeUser).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  TimeZoneInfoId: ").Append(TimeZoneInfoId).Append("\n");
            sb.Append("  DisplayTimesInUserLocalTimeZone: ").Append(DisplayTimesInUserLocalTimeZone).Append("\n");
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
            return this.Equals(input as AccountDetail);
        }

        /// <summary>
        /// Returns true if AccountDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountDetail input)
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
                    this.SignupSteps == input.SignupSteps ||
                    this.SignupSteps != null &&
                    this.SignupSteps.SequenceEqual(input.SignupSteps)
                ) && 
                (
                    this.IsVerified == input.IsVerified ||
                    (this.IsVerified != null &&
                    this.IsVerified.Equals(input.IsVerified))
                ) && 
                (
                    this.IsSelfServeUser == input.IsSelfServeUser ||
                    (this.IsSelfServeUser != null &&
                    this.IsSelfServeUser.Equals(input.IsSelfServeUser))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.TimeZoneInfoId == input.TimeZoneInfoId ||
                    (this.TimeZoneInfoId != null &&
                    this.TimeZoneInfoId.Equals(input.TimeZoneInfoId))
                ) && 
                (
                    this.DisplayTimesInUserLocalTimeZone == input.DisplayTimesInUserLocalTimeZone ||
                    (this.DisplayTimesInUserLocalTimeZone != null &&
                    this.DisplayTimesInUserLocalTimeZone.Equals(input.DisplayTimesInUserLocalTimeZone))
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
                if (this.SignupSteps != null)
                    hashCode = hashCode * 59 + this.SignupSteps.GetHashCode();
                if (this.IsVerified != null)
                    hashCode = hashCode * 59 + this.IsVerified.GetHashCode();
                if (this.IsSelfServeUser != null)
                    hashCode = hashCode * 59 + this.IsSelfServeUser.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.TimeZoneInfoId != null)
                    hashCode = hashCode * 59 + this.TimeZoneInfoId.GetHashCode();
                if (this.DisplayTimesInUserLocalTimeZone != null)
                    hashCode = hashCode * 59 + this.DisplayTimesInUserLocalTimeZone.GetHashCode();
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
