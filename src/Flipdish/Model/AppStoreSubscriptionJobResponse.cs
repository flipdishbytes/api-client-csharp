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
    /// AppStoreSubscriptionJobResponse
    /// </summary>
    [DataContract]
    public partial class AppStoreSubscriptionJobResponse :  IEquatable<AppStoreSubscriptionJobResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreSubscriptionJobResponse" /> class.
        /// </summary>
        /// <param name="subscriptionChangeJobId">subscriptionChangeJobId.</param>
        public AppStoreSubscriptionJobResponse(string subscriptionChangeJobId = default(string))
        {
            this.SubscriptionChangeJobId = subscriptionChangeJobId;
        }
        
        /// <summary>
        /// Gets or Sets SubscriptionChangeJobId
        /// </summary>
        [DataMember(Name="SubscriptionChangeJobId", EmitDefaultValue=false)]
        public string SubscriptionChangeJobId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppStoreSubscriptionJobResponse {\n");
            sb.Append("  SubscriptionChangeJobId: ").Append(SubscriptionChangeJobId).Append("\n");
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
            return this.Equals(input as AppStoreSubscriptionJobResponse);
        }

        /// <summary>
        /// Returns true if AppStoreSubscriptionJobResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreSubscriptionJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreSubscriptionJobResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubscriptionChangeJobId == input.SubscriptionChangeJobId ||
                    (this.SubscriptionChangeJobId != null &&
                    this.SubscriptionChangeJobId.Equals(input.SubscriptionChangeJobId))
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
                if (this.SubscriptionChangeJobId != null)
                    hashCode = hashCode * 59 + this.SubscriptionChangeJobId.GetHashCode();
                return hashCode;
            }
        }
    }

}
