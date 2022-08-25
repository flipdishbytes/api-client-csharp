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
    /// Describes a channel store mapping
    /// </summary>
    [DataContract]
    public partial class ChannelStoreMapping :  IEquatable<ChannelStoreMapping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelStoreMapping" /> class.
        /// </summary>
        /// <param name="storeId">storeId.</param>
        /// <param name="channelStoreId">channelStoreId.</param>
        public ChannelStoreMapping(int? storeId = default(int?), string channelStoreId = default(string))
        {
            this.StoreId = storeId;
            this.ChannelStoreId = channelStoreId;
        }
        
        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public int? StoreId { get; set; }

        /// <summary>
        /// Gets or Sets ChannelStoreId
        /// </summary>
        [DataMember(Name="ChannelStoreId", EmitDefaultValue=false)]
        public string ChannelStoreId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelStoreMapping {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  ChannelStoreId: ").Append(ChannelStoreId).Append("\n");
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
            return this.Equals(input as ChannelStoreMapping);
        }

        /// <summary>
        /// Returns true if ChannelStoreMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelStoreMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelStoreMapping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.ChannelStoreId == input.ChannelStoreId ||
                    (this.ChannelStoreId != null &&
                    this.ChannelStoreId.Equals(input.ChannelStoreId))
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.ChannelStoreId != null)
                    hashCode = hashCode * 59 + this.ChannelStoreId.GetHashCode();
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
