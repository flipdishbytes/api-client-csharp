/* 
 * Flipdish Open API
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
using PropertyChanged;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Flipdish.Client.SwaggerDateConverter;

namespace Flipdish.Model
{
    /// <summary>
    /// RestApiPaginationResultStore
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class RestApiPaginationResultStore :  IEquatable<RestApiPaginationResultStore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiPaginationResultStore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestApiPaginationResultStore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiPaginationResultStore" /> class.
        /// </summary>
        /// <param name="Page">Page (required).</param>
        /// <param name="Limit">Limit (required).</param>
        /// <param name="TotalRecordCount">TotalRecordCount (required).</param>
        /// <param name="Data">Data (required).</param>
        public RestApiPaginationResultStore(int? Page = default(int?), int? Limit = default(int?), int? TotalRecordCount = default(int?), List<Store> Data = default(List<Store>))
        {
            // to ensure "Page" is required (not null)
            if (Page == null)
            {
                throw new InvalidDataException("Page is a required property for RestApiPaginationResultStore and cannot be null");
            }
            else
            {
                this.Page = Page;
            }
            // to ensure "Limit" is required (not null)
            if (Limit == null)
            {
                throw new InvalidDataException("Limit is a required property for RestApiPaginationResultStore and cannot be null");
            }
            else
            {
                this.Limit = Limit;
            }
            // to ensure "TotalRecordCount" is required (not null)
            if (TotalRecordCount == null)
            {
                throw new InvalidDataException("TotalRecordCount is a required property for RestApiPaginationResultStore and cannot be null");
            }
            else
            {
                this.TotalRecordCount = TotalRecordCount;
            }
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for RestApiPaginationResultStore and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
        }
        
        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="Page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="Limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or Sets TotalRecordCount
        /// </summary>
        [DataMember(Name="TotalRecordCount", EmitDefaultValue=false)]
        public int? TotalRecordCount { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public List<Store> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestApiPaginationResultStore {\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RestApiPaginationResultStore);
        }

        /// <summary>
        /// Returns true if RestApiPaginationResultStore instances are equal
        /// </summary>
        /// <param name="other">Instance of RestApiPaginationResultStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestApiPaginationResultStore other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.TotalRecordCount == other.TotalRecordCount ||
                    this.TotalRecordCount != null &&
                    this.TotalRecordCount.Equals(other.TotalRecordCount)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.TotalRecordCount != null)
                    hash = hash * 59 + this.TotalRecordCount.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Trigger when a property changed
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            // NOTE: property changed is handled via "code weaving" using Fody.
            // Properties with setters are modified at compile time to notify of changes.
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
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
