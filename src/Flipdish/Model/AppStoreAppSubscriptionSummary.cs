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
    /// AppStoreAppSubscriptionSummary
    /// </summary>
    [DataContract]
    public partial class AppStoreAppSubscriptionSummary :  IEquatable<AppStoreAppSubscriptionSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreAppSubscriptionSummary" /> class.
        /// </summary>
        /// <param name="totalSubscriptions">totalSubscriptions.</param>
        /// <param name="usedSubscriptions">usedSubscriptions.</param>
        /// <param name="subscriptionAccountIsSetupForClient">subscriptionAccountIsSetupForClient.</param>
        /// <param name="subscriptionAccounts">subscriptionAccounts.</param>
        public AppStoreAppSubscriptionSummary(int? totalSubscriptions = default(int?), int? usedSubscriptions = default(int?), bool? subscriptionAccountIsSetupForClient = default(bool?), List<AppStoreAppSubscriptionAccount> subscriptionAccounts = default(List<AppStoreAppSubscriptionAccount>))
        {
            this.TotalSubscriptions = totalSubscriptions;
            this.UsedSubscriptions = usedSubscriptions;
            this.SubscriptionAccountIsSetupForClient = subscriptionAccountIsSetupForClient;
            this.SubscriptionAccounts = subscriptionAccounts;
        }
        
        /// <summary>
        /// Gets or Sets TotalSubscriptions
        /// </summary>
        [DataMember(Name="TotalSubscriptions", EmitDefaultValue=false)]
        public int? TotalSubscriptions { get; set; }

        /// <summary>
        /// Gets or Sets UsedSubscriptions
        /// </summary>
        [DataMember(Name="UsedSubscriptions", EmitDefaultValue=false)]
        public int? UsedSubscriptions { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionAccountIsSetupForClient
        /// </summary>
        [DataMember(Name="SubscriptionAccountIsSetupForClient", EmitDefaultValue=false)]
        public bool? SubscriptionAccountIsSetupForClient { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionAccounts
        /// </summary>
        [DataMember(Name="SubscriptionAccounts", EmitDefaultValue=false)]
        public List<AppStoreAppSubscriptionAccount> SubscriptionAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppStoreAppSubscriptionSummary {\n");
            sb.Append("  TotalSubscriptions: ").Append(TotalSubscriptions).Append("\n");
            sb.Append("  UsedSubscriptions: ").Append(UsedSubscriptions).Append("\n");
            sb.Append("  SubscriptionAccountIsSetupForClient: ").Append(SubscriptionAccountIsSetupForClient).Append("\n");
            sb.Append("  SubscriptionAccounts: ").Append(SubscriptionAccounts).Append("\n");
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
            return this.Equals(input as AppStoreAppSubscriptionSummary);
        }

        /// <summary>
        /// Returns true if AppStoreAppSubscriptionSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreAppSubscriptionSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreAppSubscriptionSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalSubscriptions == input.TotalSubscriptions ||
                    (this.TotalSubscriptions != null &&
                    this.TotalSubscriptions.Equals(input.TotalSubscriptions))
                ) && 
                (
                    this.UsedSubscriptions == input.UsedSubscriptions ||
                    (this.UsedSubscriptions != null &&
                    this.UsedSubscriptions.Equals(input.UsedSubscriptions))
                ) && 
                (
                    this.SubscriptionAccountIsSetupForClient == input.SubscriptionAccountIsSetupForClient ||
                    (this.SubscriptionAccountIsSetupForClient != null &&
                    this.SubscriptionAccountIsSetupForClient.Equals(input.SubscriptionAccountIsSetupForClient))
                ) && 
                (
                    this.SubscriptionAccounts == input.SubscriptionAccounts ||
                    this.SubscriptionAccounts != null &&
                    this.SubscriptionAccounts.SequenceEqual(input.SubscriptionAccounts)
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
                if (this.TotalSubscriptions != null)
                    hashCode = hashCode * 59 + this.TotalSubscriptions.GetHashCode();
                if (this.UsedSubscriptions != null)
                    hashCode = hashCode * 59 + this.UsedSubscriptions.GetHashCode();
                if (this.SubscriptionAccountIsSetupForClient != null)
                    hashCode = hashCode * 59 + this.SubscriptionAccountIsSetupForClient.GetHashCode();
                if (this.SubscriptionAccounts != null)
                    hashCode = hashCode * 59 + this.SubscriptionAccounts.GetHashCode();
                return hashCode;
            }
        }
    }

}
