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
    /// AcceptInvitationResult
    /// </summary>
    [DataContract]
    public partial class AcceptInvitationResult :  IEquatable<AcceptInvitationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptInvitationResult" /> class.
        /// </summary>
        /// <param name="isNewUser">Bool indicating if the user accepting the invitation is a new user.</param>
        /// <param name="invitedEmailAddress">The email address that was invited..</param>
        public AcceptInvitationResult(bool? isNewUser = default(bool?), string invitedEmailAddress = default(string))
        {
            this.IsNewUser = isNewUser;
            this.InvitedEmailAddress = invitedEmailAddress;
        }
        
        /// <summary>
        /// Bool indicating if the user accepting the invitation is a new user
        /// </summary>
        /// <value>Bool indicating if the user accepting the invitation is a new user</value>
        [DataMember(Name="IsNewUser", EmitDefaultValue=false)]
        public bool? IsNewUser { get; set; }

        /// <summary>
        /// The email address that was invited.
        /// </summary>
        /// <value>The email address that was invited.</value>
        [DataMember(Name="InvitedEmailAddress", EmitDefaultValue=false)]
        public string InvitedEmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcceptInvitationResult {\n");
            sb.Append("  IsNewUser: ").Append(IsNewUser).Append("\n");
            sb.Append("  InvitedEmailAddress: ").Append(InvitedEmailAddress).Append("\n");
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
            return this.Equals(input as AcceptInvitationResult);
        }

        /// <summary>
        /// Returns true if AcceptInvitationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AcceptInvitationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcceptInvitationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsNewUser == input.IsNewUser ||
                    (this.IsNewUser != null &&
                    this.IsNewUser.Equals(input.IsNewUser))
                ) && 
                (
                    this.InvitedEmailAddress == input.InvitedEmailAddress ||
                    (this.InvitedEmailAddress != null &&
                    this.InvitedEmailAddress.Equals(input.InvitedEmailAddress))
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
                if (this.IsNewUser != null)
                    hashCode = hashCode * 59 + this.IsNewUser.GetHashCode();
                if (this.InvitedEmailAddress != null)
                    hashCode = hashCode * 59 + this.InvitedEmailAddress.GetHashCode();
                return hashCode;
            }
        }
    }

}