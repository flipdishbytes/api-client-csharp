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
    /// AppStoreAppEntitlements
    /// </summary>
    [DataContract]
    public partial class AppStoreAppEntitlements :  IEquatable<AppStoreAppEntitlements>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreAppEntitlements" /> class.
        /// </summary>
        /// <param name="entitlementQuantity">entitlementQuantity.</param>
        /// <param name="currentUsage">currentUsage.</param>
        public AppStoreAppEntitlements(int? entitlementQuantity = default(int?), int? currentUsage = default(int?))
        {
            this.EntitlementQuantity = entitlementQuantity;
            this.CurrentUsage = currentUsage;
        }
        
        /// <summary>
        /// Gets or Sets EntitlementQuantity
        /// </summary>
        [DataMember(Name="EntitlementQuantity", EmitDefaultValue=false)]
        public int? EntitlementQuantity { get; set; }

        /// <summary>
        /// Gets or Sets CurrentUsage
        /// </summary>
        [DataMember(Name="CurrentUsage", EmitDefaultValue=false)]
        public int? CurrentUsage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppStoreAppEntitlements {\n");
            sb.Append("  EntitlementQuantity: ").Append(EntitlementQuantity).Append("\n");
            sb.Append("  CurrentUsage: ").Append(CurrentUsage).Append("\n");
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
            return this.Equals(input as AppStoreAppEntitlements);
        }

        /// <summary>
        /// Returns true if AppStoreAppEntitlements instances are equal
        /// </summary>
        /// <param name="input">Instance of AppStoreAppEntitlements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreAppEntitlements input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntitlementQuantity == input.EntitlementQuantity ||
                    (this.EntitlementQuantity != null &&
                    this.EntitlementQuantity.Equals(input.EntitlementQuantity))
                ) && 
                (
                    this.CurrentUsage == input.CurrentUsage ||
                    (this.CurrentUsage != null &&
                    this.CurrentUsage.Equals(input.CurrentUsage))
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
                if (this.EntitlementQuantity != null)
                    hashCode = hashCode * 59 + this.EntitlementQuantity.GetHashCode();
                if (this.CurrentUsage != null)
                    hashCode = hashCode * 59 + this.CurrentUsage.GetHashCode();
                return hashCode;
            }
        }
    }

}
