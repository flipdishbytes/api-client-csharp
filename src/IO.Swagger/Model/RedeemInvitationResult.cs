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
    /// RedeemInvitationResult
    /// </summary>
    [DataContract]
    public partial class RedeemInvitationResult :  IEquatable<RedeemInvitationResult>, IValidatableObject
    {
        /// <summary>
        /// Invitation status
        /// </summary>
        /// <value>Invitation status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InvitationStatusEnum
        {
            
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 1,
            
            /// <summary>
            /// Enum Accepted for value: Accepted
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted = 2,
            
            /// <summary>
            /// Enum Expired for value: Expired
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired = 3
        }

        /// <summary>
        /// Invitation status
        /// </summary>
        /// <value>Invitation status</value>
        [DataMember(Name="InvitationStatus", EmitDefaultValue=false)]
        public InvitationStatusEnum? InvitationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RedeemInvitationResult" /> class.
        /// </summary>
        /// <param name="appId">Access level is for this App.</param>
        /// <param name="invitationStatus">Invitation status.</param>
        public RedeemInvitationResult(string appId = default(string), InvitationStatusEnum? invitationStatus = default(InvitationStatusEnum?))
        {
            this.AppId = appId;
            this.InvitationStatus = invitationStatus;
        }
        
        /// <summary>
        /// Access level is for this App
        /// </summary>
        /// <value>Access level is for this App</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedeemInvitationResult {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  InvitationStatus: ").Append(InvitationStatus).Append("\n");
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
            return this.Equals(input as RedeemInvitationResult);
        }

        /// <summary>
        /// Returns true if RedeemInvitationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RedeemInvitationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedeemInvitationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.InvitationStatus == input.InvitationStatus ||
                    (this.InvitationStatus != null &&
                    this.InvitationStatus.Equals(input.InvitationStatus))
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.InvitationStatus != null)
                    hashCode = hashCode * 59 + this.InvitationStatus.GetHashCode();
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
