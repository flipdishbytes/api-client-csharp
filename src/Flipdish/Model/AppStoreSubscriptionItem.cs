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
    /// AppStoreSubscriptionItem
    /// </summary>
    [DataContract]
    public partial class AppStoreSubscriptionItem :  IEquatable<AppStoreSubscriptionItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreSubscriptionItem" /> class.
        /// </summary>
        /// <param name="externalSubscriptionId">externalSubscriptionId.</param>
        /// <param name="storeIds">storeIds.</param>
        /// <param name="userId">userId.</param>
        /// <param name="userEmail">userEmail.</param>
        /// <param name="status">status.</param>
        /// <param name="subscriptionChangeJobId">subscriptionChangeJobId.</param>
        public AppStoreSubscriptionItem(string externalSubscriptionId = default(string), List<int?> storeIds = default(List<int?>), int? userId = default(int?), string userEmail = default(string), string status = default(string), string subscriptionChangeJobId = default(string))
        {
            this.ExternalSubscriptionId = externalSubscriptionId;
            this.StoreIds = storeIds;
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.Status = status;
            this.SubscriptionChangeJobId = subscriptionChangeJobId;
        }
        
        /// <summary>
        /// Gets or Sets ExternalSubscriptionId
        /// </summary>
        [DataMember(Name="ExternalSubscriptionId", EmitDefaultValue=false)]
        public string ExternalSubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets StoreIds
        /// </summary>
        [DataMember(Name="StoreIds", EmitDefaultValue=false)]
        public List<int?> StoreIds { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserEmail
        /// </summary>
        [DataMember(Name="UserEmail", EmitDefaultValue=false)]
        public string UserEmail { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

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
            sb.Append("class AppStoreSubscriptionItem {\n");
            sb.Append("  ExternalSubscriptionId: ").Append(ExternalSubscriptionId).Append("\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AppStoreSubscriptionItem);
        }

        /// <summary>
        /// Returns true if AppStoreSubscriptionItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreSubscriptionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreSubscriptionItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalSubscriptionId == input.ExternalSubscriptionId ||
                    (this.ExternalSubscriptionId != null &&
                    this.ExternalSubscriptionId.Equals(input.ExternalSubscriptionId))
                ) && 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserEmail == input.UserEmail ||
                    (this.UserEmail != null &&
                    this.UserEmail.Equals(input.UserEmail))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
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
                if (this.ExternalSubscriptionId != null)
                    hashCode = hashCode * 59 + this.ExternalSubscriptionId.GetHashCode();
                if (this.StoreIds != null)
                    hashCode = hashCode * 59 + this.StoreIds.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserEmail != null)
                    hashCode = hashCode * 59 + this.UserEmail.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubscriptionChangeJobId != null)
                    hashCode = hashCode * 59 + this.SubscriptionChangeJobId.GetHashCode();
                return hashCode;
            }
        }
    }

}
