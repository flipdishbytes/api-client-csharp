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
    /// Rest api error result
    /// </summary>
    [DataContract]
    public partial class RestApiErrorResult :  IEquatable<RestApiErrorResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiErrorResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestApiErrorResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiErrorResult" /> class.
        /// </summary>
        /// <param name="message">Error message (required).</param>
        /// <param name="errorCode">Error code.</param>
        /// <param name="stackTrace">Stack trace.</param>
        /// <param name="errors">List of errors grouped by field name.</param>
        public RestApiErrorResult(string message = default(string), int? errorCode = default(int?), string stackTrace = default(string), List<ValidationErrorResult> errors = default(List<ValidationErrorResult>))
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for RestApiErrorResult and cannot be null");
            }
            else
            {
                this.Message = message;
            }
            this.ErrorCode = errorCode;
            this.StackTrace = stackTrace;
            this.Errors = errors;
        }
        
        /// <summary>
        /// Error message
        /// </summary>
        /// <value>Error message</value>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Error code
        /// </summary>
        /// <value>Error code</value>
        [DataMember(Name="ErrorCode", EmitDefaultValue=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Stack trace
        /// </summary>
        /// <value>Stack trace</value>
        [DataMember(Name="StackTrace", EmitDefaultValue=false)]
        public string StackTrace { get; set; }

        /// <summary>
        /// List of errors grouped by field name
        /// </summary>
        /// <value>List of errors grouped by field name</value>
        [DataMember(Name="Errors", EmitDefaultValue=false)]
        public List<ValidationErrorResult> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestApiErrorResult {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as RestApiErrorResult);
        }

        /// <summary>
        /// Returns true if RestApiErrorResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RestApiErrorResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestApiErrorResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.StackTrace == input.StackTrace ||
                    (this.StackTrace != null &&
                    this.StackTrace.Equals(input.StackTrace))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.StackTrace != null)
                    hashCode = hashCode * 59 + this.StackTrace.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
