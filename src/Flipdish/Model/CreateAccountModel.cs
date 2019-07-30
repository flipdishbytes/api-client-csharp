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
    /// Create account model
    /// </summary>
    [DataContract]
    public partial class CreateAccountModel :  IEquatable<CreateAccountModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAccountModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountModel" /> class.
        /// </summary>
        /// <param name="email">Email addres (required).</param>
        /// <param name="storeName">Store name (required).</param>
        /// <param name="languageId">LanguageId.</param>
        /// <param name="rid">Referral ID.</param>
        /// <param name="cid">Campaign ID.</param>
        public CreateAccountModel(string email = default(string), string storeName = default(string), string languageId = default(string), int? rid = default(int?), string cid = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for CreateAccountModel and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "storeName" is required (not null)
            if (storeName == null)
            {
                throw new InvalidDataException("storeName is a required property for CreateAccountModel and cannot be null");
            }
            else
            {
                this.StoreName = storeName;
            }
            this.LanguageId = languageId;
            this.Rid = rid;
            this.Cid = cid;
        }
        
        /// <summary>
        /// Email addres
        /// </summary>
        /// <value>Email addres</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Store name
        /// </summary>
        /// <value>Store name</value>
        [DataMember(Name="StoreName", EmitDefaultValue=false)]
        public string StoreName { get; set; }

        /// <summary>
        /// LanguageId
        /// </summary>
        /// <value>LanguageId</value>
        [DataMember(Name="LanguageId", EmitDefaultValue=false)]
        public string LanguageId { get; set; }

        /// <summary>
        /// Referral ID
        /// </summary>
        /// <value>Referral ID</value>
        [DataMember(Name="Rid", EmitDefaultValue=false)]
        public int? Rid { get; set; }

        /// <summary>
        /// Campaign ID
        /// </summary>
        /// <value>Campaign ID</value>
        [DataMember(Name="Cid", EmitDefaultValue=false)]
        public string Cid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccountModel {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
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
            return this.Equals(input as CreateAccountModel);
        }

        /// <summary>
        /// Returns true if CreateAccountModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAccountModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAccountModel input)
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
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
                ) && 
                (
                    this.LanguageId == input.LanguageId ||
                    (this.LanguageId != null &&
                    this.LanguageId.Equals(input.LanguageId))
                ) && 
                (
                    this.Rid == input.Rid ||
                    (this.Rid != null &&
                    this.Rid.Equals(input.Rid))
                ) && 
                (
                    this.Cid == input.Cid ||
                    (this.Cid != null &&
                    this.Cid.Equals(input.Cid))
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
                if (this.StoreName != null)
                    hashCode = hashCode * 59 + this.StoreName.GetHashCode();
                if (this.LanguageId != null)
                    hashCode = hashCode * 59 + this.LanguageId.GetHashCode();
                if (this.Rid != null)
                    hashCode = hashCode * 59 + this.Rid.GetHashCode();
                if (this.Cid != null)
                    hashCode = hashCode * 59 + this.Cid.GetHashCode();
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
