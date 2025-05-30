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
    /// Rest api pagination result
    /// </summary>
    [DataContract]
    public partial class RestApiPaginationResultRestaurant :  IEquatable<RestApiPaginationResultRestaurant>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiPaginationResultRestaurant" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestApiPaginationResultRestaurant() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiPaginationResultRestaurant" /> class.
        /// </summary>
        /// <param name="page">Current page index (required).</param>
        /// <param name="limit">Current page size (required).</param>
        /// <param name="totalRecordCount">Total record count (required).</param>
        /// <param name="data">Generic data object. (required).</param>
        public RestApiPaginationResultRestaurant(int? page = default(int?), int? limit = default(int?), int? totalRecordCount = default(int?), List<Restaurant> data = default(List<Restaurant>))
        {
            // to ensure "page" is required (not null)
            if (page == null)
            {
                throw new InvalidDataException("page is a required property for RestApiPaginationResultRestaurant and cannot be null");
            }
            else
            {
                this.Page = page;
            }
            // to ensure "limit" is required (not null)
            if (limit == null)
            {
                throw new InvalidDataException("limit is a required property for RestApiPaginationResultRestaurant and cannot be null");
            }
            else
            {
                this.Limit = limit;
            }
            // to ensure "totalRecordCount" is required (not null)
            if (totalRecordCount == null)
            {
                throw new InvalidDataException("totalRecordCount is a required property for RestApiPaginationResultRestaurant and cannot be null");
            }
            else
            {
                this.TotalRecordCount = totalRecordCount;
            }
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for RestApiPaginationResultRestaurant and cannot be null");
            }
            else
            {
                this.Data = data;
            }
        }
        
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
        /// Generic data object.
        /// </summary>
        /// <value>Generic data object.</value>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public List<Restaurant> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestApiPaginationResultRestaurant {\n");
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
            return this.Equals(input as RestApiPaginationResultRestaurant);
        }

        /// <summary>
        /// Returns true if RestApiPaginationResultRestaurant instances are equal
        /// </summary>
        /// <param name="input">Instance of RestApiPaginationResultRestaurant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestApiPaginationResultRestaurant input)
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
    }

}
