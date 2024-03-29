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
    /// Pending menu changes summaries
    /// </summary>
    [DataContract]
    public partial class PendingMenuChangesSummaries :  IEquatable<PendingMenuChangesSummaries>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingMenuChangesSummaries" /> class.
        /// </summary>
        /// <param name="menuId">Menu id.</param>
        /// <param name="totalPendingChanges">Sum of pending changes per menu id.</param>
        public PendingMenuChangesSummaries(int? menuId = default(int?), int? totalPendingChanges = default(int?))
        {
            this.MenuId = menuId;
            this.TotalPendingChanges = totalPendingChanges;
        }
        
        /// <summary>
        /// Menu id
        /// </summary>
        /// <value>Menu id</value>
        [DataMember(Name="MenuId", EmitDefaultValue=false)]
        public int? MenuId { get; set; }

        /// <summary>
        /// Sum of pending changes per menu id
        /// </summary>
        /// <value>Sum of pending changes per menu id</value>
        [DataMember(Name="TotalPendingChanges", EmitDefaultValue=false)]
        public int? TotalPendingChanges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PendingMenuChangesSummaries {\n");
            sb.Append("  MenuId: ").Append(MenuId).Append("\n");
            sb.Append("  TotalPendingChanges: ").Append(TotalPendingChanges).Append("\n");
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
            return this.Equals(input as PendingMenuChangesSummaries);
        }

        /// <summary>
        /// Returns true if PendingMenuChangesSummaries instances are equal
        /// </summary>
        /// <param name="input">Instance of PendingMenuChangesSummaries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PendingMenuChangesSummaries input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MenuId == input.MenuId ||
                    (this.MenuId != null &&
                    this.MenuId.Equals(input.MenuId))
                ) && 
                (
                    this.TotalPendingChanges == input.TotalPendingChanges ||
                    (this.TotalPendingChanges != null &&
                    this.TotalPendingChanges.Equals(input.TotalPendingChanges))
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
                if (this.MenuId != null)
                    hashCode = hashCode * 59 + this.MenuId.GetHashCode();
                if (this.TotalPendingChanges != null)
                    hashCode = hashCode * 59 + this.TotalPendingChanges.GetHashCode();
                return hashCode;
            }
        }
    }

}
