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
    /// RestApiEventSearchPaginationResult
    /// </summary>
    [DataContract]
    public partial class RestApiEventSearchPaginationResult :  IEquatable<RestApiEventSearchPaginationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiEventSearchPaginationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestApiEventSearchPaginationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiEventSearchPaginationResult" /> class.
        /// </summary>
        /// <param name="data">Event results (required).</param>
        /// <param name="page">Current page index (required).</param>
        /// <param name="limit">Current page size (required).</param>
        /// <param name="totalRecordCount">Total record count (required).</param>
        public RestApiEventSearchPaginationResult(EventSearchResult data = default(EventSearchResult), int? page = default(int?), int? limit = default(int?), int? totalRecordCount = default(int?))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for RestApiEventSearchPaginationResult and cannot be null");
            }
            else
            {
                this.Data = data;
            }
            // to ensure "page" is required (not null)
            if (page == null)
            {
                throw new InvalidDataException("page is a required property for RestApiEventSearchPaginationResult and cannot be null");
            }
            else
            {
                this.Page = page;
            }
            // to ensure "limit" is required (not null)
            if (limit == null)
            {
                throw new InvalidDataException("limit is a required property for RestApiEventSearchPaginationResult and cannot be null");
            }
            else
            {
                this.Limit = limit;
            }
            // to ensure "totalRecordCount" is required (not null)
            if (totalRecordCount == null)
            {
                throw new InvalidDataException("totalRecordCount is a required property for RestApiEventSearchPaginationResult and cannot be null");
            }
            else
            {
                this.TotalRecordCount = totalRecordCount;
            }
        }
        
        /// <summary>
        /// Event results
        /// </summary>
        /// <value>Event results</value>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public EventSearchResult Data { get; set; }

        /// <summary>
        /// Current page index
        /// </summary>
        /// <value>Current page index</value>
        [DataMember(Name="Page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// Current page size
        /// </summary>
        /// <value>Current page size</value>
        [DataMember(Name="Limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Total record count
        /// </summary>
        /// <value>Total record count</value>
        [DataMember(Name="TotalRecordCount", EmitDefaultValue=false)]
        public int? TotalRecordCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestApiEventSearchPaginationResult {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  TotalRecordCount: ").Append(TotalRecordCount).Append("\n");
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
            return this.Equals(input as RestApiEventSearchPaginationResult);
        }

        /// <summary>
        /// Returns true if RestApiEventSearchPaginationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RestApiEventSearchPaginationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestApiEventSearchPaginationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
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
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.TotalRecordCount != null)
                    hashCode = hashCode * 59 + this.TotalRecordCount.GetHashCode();
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
