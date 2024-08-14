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
    /// Rest api result
    /// </summary>
    [DataContract]
    public partial class RestApiResultAcceptInvitationResult :  IEquatable<RestApiResultAcceptInvitationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiResultAcceptInvitationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestApiResultAcceptInvitationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiResultAcceptInvitationResult" /> class.
        /// </summary>
        /// <param name="data">Generic data object. (required).</param>
        public RestApiResultAcceptInvitationResult(AcceptInvitationResult data = default(AcceptInvitationResult))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for RestApiResultAcceptInvitationResult and cannot be null");
            }
            else
            {
                this.Data = data;
            }
        }
        
        /// <summary>
        /// Generic data object.
        /// </summary>
        /// <value>Generic data object.</value>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public AcceptInvitationResult Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestApiResultAcceptInvitationResult {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as RestApiResultAcceptInvitationResult);
        }

        /// <summary>
        /// Returns true if RestApiResultAcceptInvitationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RestApiResultAcceptInvitationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestApiResultAcceptInvitationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }
    }

}
