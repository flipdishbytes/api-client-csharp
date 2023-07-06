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
    /// Basic attributes for creating an account
    /// </summary>
    [DataContract]
    public partial class CreateBasicAccountModel :  IEquatable<CreateBasicAccountModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBasicAccountModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateBasicAccountModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBasicAccountModel" /> class.
        /// </summary>
        /// <param name="storeName">Store name (required).</param>
        /// <param name="languageId">LanguageId.</param>
        /// <param name="opportunityId">Salesforce Opportunity ID.</param>
        public CreateBasicAccountModel(string storeName = default(string), string languageId = default(string), string opportunityId = default(string))
        {
            // to ensure "storeName" is required (not null)
            if (storeName == null)
            {
                throw new InvalidDataException("storeName is a required property for CreateBasicAccountModel and cannot be null");
            }
            else
            {
                this.StoreName = storeName;
            }
            this.LanguageId = languageId;
            this.OpportunityId = opportunityId;
        }
        
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
        /// Salesforce Opportunity ID
        /// </summary>
        /// <value>Salesforce Opportunity ID</value>
        [DataMember(Name="OpportunityId", EmitDefaultValue=false)]
        public string OpportunityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBasicAccountModel {\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  OpportunityId: ").Append(OpportunityId).Append("\n");
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
            return this.Equals(input as CreateBasicAccountModel);
        }

        /// <summary>
        /// Returns true if CreateBasicAccountModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateBasicAccountModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateBasicAccountModel input)
        {
            if (input == null)
                return false;

            return 
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
                    this.OpportunityId == input.OpportunityId ||
                    (this.OpportunityId != null &&
                    this.OpportunityId.Equals(input.OpportunityId))
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
                if (this.StoreName != null)
                    hashCode = hashCode * 59 + this.StoreName.GetHashCode();
                if (this.LanguageId != null)
                    hashCode = hashCode * 59 + this.LanguageId.GetHashCode();
                if (this.OpportunityId != null)
                    hashCode = hashCode * 59 + this.OpportunityId.GetHashCode();
                return hashCode;
            }
        }
    }

}
