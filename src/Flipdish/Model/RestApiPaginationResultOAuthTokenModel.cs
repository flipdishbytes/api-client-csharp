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
    /// RestApiPaginationResultOAuthTokenModel
    /// </summary>
    [DataContract]
    public partial class RestApiPaginationResultOAuthTokenModel :  IEquatable<RestApiPaginationResultOAuthTokenModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiPaginationResultOAuthTokenModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestApiPaginationResultOAuthTokenModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiPaginationResultOAuthTokenModel" /> class.
        /// </summary>
        /// <param name="Page">Page (required).</param>
        /// <param name="Limit">Limit (required).</param>
        /// <param name="TotalRecordCount">TotalRecordCount (required).</param>
        /// <param name="Data">Data (required).</param>
        public RestApiPaginationResultOAuthTokenModel(int? Page = default(int?), int? Limit = default(int?), int? TotalRecordCount = default(int?), List<OAuthTokenModel> Data = default(List<OAuthTokenModel>))
        {
            // to ensure "Page" is required (not null)
            if (Page == null)
            {
                throw new InvalidDataException("Page is a required property for RestApiPaginationResultOAuthTokenModel and cannot be null");
            }
            else
            {
                this.Page = Page;
            }
            // to ensure "Limit" is required (not null)
            if (Limit == null)
            {
                throw new InvalidDataException("Limit is a required property for RestApiPaginationResultOAuthTokenModel and cannot be null");
            }
            else
            {
                this.Limit = Limit;
            }
            // to ensure "TotalRecordCount" is required (not null)
            if (TotalRecordCount == null)
            {
                throw new InvalidDataException("TotalRecordCount is a required property for RestApiPaginationResultOAuthTokenModel and cannot be null");
            }
            else
            {
                this.TotalRecordCount = TotalRecordCount;
            }
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for RestApiPaginationResultOAuthTokenModel and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
        }
        
        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or Sets TotalRecordCount
        /// </summary>
        [DataMember(Name="totalRecordCount", EmitDefaultValue=false)]
        public int? TotalRecordCount { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<OAuthTokenModel> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestApiPaginationResultOAuthTokenModel {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  TotalRecordCount: ").Append(TotalRecordCount).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as RestApiPaginationResultOAuthTokenModel);
        }

        /// <summary>
        /// Returns true if RestApiPaginationResultOAuthTokenModel instances are equal
        /// </summary>
        /// <param name="input">Instance of RestApiPaginationResultOAuthTokenModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestApiPaginationResultOAuthTokenModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.TotalRecordCount == input.TotalRecordCount ||
                    (this.TotalRecordCount != null &&
                    this.TotalRecordCount.Equals(input.TotalRecordCount))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.TotalRecordCount != null)
                    hashCode = hashCode * 59 + this.TotalRecordCount.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
