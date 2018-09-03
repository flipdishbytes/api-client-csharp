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
    /// Job Cancellation
    /// </summary>
    [DataContract]
    public partial class JobCancellation :  IEquatable<JobCancellation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobCancellation" /> class.
        /// </summary>
        /// <param name="CanceledBy">Canceled By.</param>
        /// <param name="ReasonKey">Reason Key.</param>
        /// <param name="Comment">Comment.</param>
        public JobCancellation(string CanceledBy = default(string), string ReasonKey = default(string), string Comment = default(string))
        {
            this.CanceledBy = CanceledBy;
            this.ReasonKey = ReasonKey;
            this.Comment = Comment;
        }
        
        /// <summary>
        /// Canceled By
        /// </summary>
        /// <value>Canceled By</value>
        [DataMember(Name="CanceledBy", EmitDefaultValue=false)]
        public string CanceledBy { get; set; }

        /// <summary>
        /// Reason Key
        /// </summary>
        /// <value>Reason Key</value>
        [DataMember(Name="ReasonKey", EmitDefaultValue=false)]
        public string ReasonKey { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        /// <value>Comment</value>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobCancellation {\n");
            sb.Append("  CanceledBy: ").Append(CanceledBy).Append("\n");
            sb.Append("  ReasonKey: ").Append(ReasonKey).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(input as JobCancellation);
        }

        /// <summary>
        /// Returns true if JobCancellation instances are equal
        /// </summary>
        /// <param name="input">Instance of JobCancellation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobCancellation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanceledBy == input.CanceledBy ||
                    (this.CanceledBy != null &&
                    this.CanceledBy.Equals(input.CanceledBy))
                ) && 
                (
                    this.ReasonKey == input.ReasonKey ||
                    (this.ReasonKey != null &&
                    this.ReasonKey.Equals(input.ReasonKey))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.CanceledBy != null)
                    hashCode = hashCode * 59 + this.CanceledBy.GetHashCode();
                if (this.ReasonKey != null)
                    hashCode = hashCode * 59 + this.ReasonKey.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
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
