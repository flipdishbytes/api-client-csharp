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
    /// CreatePayGreenConfigurationRequest
    /// </summary>
    [DataContract]
    public partial class CreatePayGreenConfigurationRequest :  IEquatable<CreatePayGreenConfigurationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePayGreenConfigurationRequest" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="payGreenId">payGreenId.</param>
        /// <param name="payGreenPrivateKey">payGreenPrivateKey.</param>
        /// <param name="assignedStores">assignedStores.</param>
        public CreatePayGreenConfigurationRequest(string name = default(string), string payGreenId = default(string), string payGreenPrivateKey = default(string), List<int?> assignedStores = default(List<int?>))
        {
            this.Name = name;
            this.PayGreenId = payGreenId;
            this.PayGreenPrivateKey = payGreenPrivateKey;
            this.AssignedStores = assignedStores;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PayGreenId
        /// </summary>
        [DataMember(Name="PayGreenId", EmitDefaultValue=false)]
        public string PayGreenId { get; set; }

        /// <summary>
        /// Gets or Sets PayGreenPrivateKey
        /// </summary>
        [DataMember(Name="PayGreenPrivateKey", EmitDefaultValue=false)]
        public string PayGreenPrivateKey { get; set; }

        /// <summary>
        /// Gets or Sets AssignedStores
        /// </summary>
        [DataMember(Name="AssignedStores", EmitDefaultValue=false)]
        public List<int?> AssignedStores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePayGreenConfigurationRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PayGreenId: ").Append(PayGreenId).Append("\n");
            sb.Append("  PayGreenPrivateKey: ").Append(PayGreenPrivateKey).Append("\n");
            sb.Append("  AssignedStores: ").Append(AssignedStores).Append("\n");
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
            return this.Equals(input as CreatePayGreenConfigurationRequest);
        }

        /// <summary>
        /// Returns true if CreatePayGreenConfigurationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePayGreenConfigurationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePayGreenConfigurationRequest input)
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
                    this.PayGreenId == input.PayGreenId ||
                    (this.PayGreenId != null &&
                    this.PayGreenId.Equals(input.PayGreenId))
                ) && 
                (
                    this.PayGreenPrivateKey == input.PayGreenPrivateKey ||
                    (this.PayGreenPrivateKey != null &&
                    this.PayGreenPrivateKey.Equals(input.PayGreenPrivateKey))
                ) && 
                (
                    this.AssignedStores == input.AssignedStores ||
                    this.AssignedStores != null &&
                    this.AssignedStores.SequenceEqual(input.AssignedStores)
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
                if (this.PayGreenId != null)
                    hashCode = hashCode * 59 + this.PayGreenId.GetHashCode();
                if (this.PayGreenPrivateKey != null)
                    hashCode = hashCode * 59 + this.PayGreenPrivateKey.GetHashCode();
                if (this.AssignedStores != null)
                    hashCode = hashCode * 59 + this.AssignedStores.GetHashCode();
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
