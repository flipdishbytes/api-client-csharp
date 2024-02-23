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
    /// UpdateAppStoreSubscriptionRequest
    /// </summary>
    [DataContract]
    public partial class UpdateAppStoreSubscriptionRequest :  IEquatable<UpdateAppStoreSubscriptionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppStoreSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="storeIds">storeIds.</param>
        public UpdateAppStoreSubscriptionRequest(List<int?> storeIds = default(List<int?>))
        {
            this.StoreIds = storeIds;
        }
        
        /// <summary>
        /// Gets or Sets StoreIds
        /// </summary>
        [DataMember(Name="StoreIds", EmitDefaultValue=false)]
        public List<int?> StoreIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAppStoreSubscriptionRequest {\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
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
            return this.Equals(input as UpdateAppStoreSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if UpdateAppStoreSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAppStoreSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAppStoreSubscriptionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
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
                if (this.StoreIds != null)
                    hashCode = hashCode * 59 + this.StoreIds.GetHashCode();
                return hashCode;
            }
        }
    }

}
