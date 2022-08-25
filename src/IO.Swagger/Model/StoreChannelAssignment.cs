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
    /// Represents a store that is assigned to a Sales Channel
    /// </summary>
    [DataContract]
    public partial class StoreChannelAssignment :  IEquatable<StoreChannelAssignment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreChannelAssignment" /> class.
        /// </summary>
        /// <param name="channelId">Channel ID.</param>
        /// <param name="storeId">Store ID.</param>
        /// <param name="storeName">Store Name.</param>
        public StoreChannelAssignment(int? channelId = default(int?), int? storeId = default(int?), string storeName = default(string))
        {
            this.ChannelId = channelId;
            this.StoreId = storeId;
            this.StoreName = storeName;
        }
        
        /// <summary>
        /// Channel ID
        /// </summary>
        /// <value>Channel ID</value>
        [DataMember(Name="ChannelId", EmitDefaultValue=false)]
        public int? ChannelId { get; set; }

        /// <summary>
        /// Store ID
        /// </summary>
        /// <value>Store ID</value>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public int? StoreId { get; set; }

        /// <summary>
        /// Store Name
        /// </summary>
        /// <value>Store Name</value>
        [DataMember(Name="StoreName", EmitDefaultValue=false)]
        public string StoreName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreChannelAssignment {\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
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
            return this.Equals(input as StoreChannelAssignment);
        }

        /// <summary>
        /// Returns true if StoreChannelAssignment instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreChannelAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreChannelAssignment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
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
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.StoreName != null)
                    hashCode = hashCode * 59 + this.StoreName.GetHashCode();
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
