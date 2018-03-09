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
    /// FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem
    /// </summary>
    [DataContract]
    public partial class FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem :  IEquatable<FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem" /> class.
        /// </summary>
        /// <param name="Data">Data (required).</param>
        public FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem(List<FlipdishPublicModelsV1MenusMenuSectionItem> Data = default(List<FlipdishPublicModelsV1MenusMenuSectionItem>))
        {
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<FlipdishPublicModelsV1MenusMenuSectionItem> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem {\n");
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
            return this.Equals(obj as FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem);
        }

        /// <summary>
        /// Returns true if FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem instances are equal
        /// </summary>
        /// <param name="other">Instance of FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1MenusMenuSectionItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                return hash;
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
