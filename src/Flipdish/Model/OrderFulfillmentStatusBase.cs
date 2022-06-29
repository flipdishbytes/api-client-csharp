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
    /// Fulfillment Status Information
    /// </summary>
    [DataContract]
    public partial class OrderFulfillmentStatusBase :  IEquatable<OrderFulfillmentStatusBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFulfillmentStatusBase" /> class.
        /// </summary>
        /// <param name="statusId">Fulfillment Status Id.</param>
        /// <param name="statusName">Fulfillment Status Name.</param>
        /// <param name="icon">Status Icon.</param>
        public OrderFulfillmentStatusBase(string statusId = default(string), string statusName = default(string), string icon = default(string))
        {
            this.StatusId = statusId;
            this.StatusName = statusName;
            this.Icon = icon;
        }
        
        /// <summary>
        /// Fulfillment Status Id
        /// </summary>
        /// <value>Fulfillment Status Id</value>
        [DataMember(Name="StatusId", EmitDefaultValue=false)]
        public string StatusId { get; set; }

        /// <summary>
        /// Fulfillment Status Name
        /// </summary>
        /// <value>Fulfillment Status Name</value>
        [DataMember(Name="StatusName", EmitDefaultValue=false)]
        public string StatusName { get; set; }

        /// <summary>
        /// Status Icon
        /// </summary>
        /// <value>Status Icon</value>
        [DataMember(Name="Icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderFulfillmentStatusBase {\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  StatusName: ").Append(StatusName).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
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
            return this.Equals(input as OrderFulfillmentStatusBase);
        }

        /// <summary>
        /// Returns true if OrderFulfillmentStatusBase instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderFulfillmentStatusBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFulfillmentStatusBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatusId == input.StatusId ||
                    (this.StatusId != null &&
                    this.StatusId.Equals(input.StatusId))
                ) && 
                (
                    this.StatusName == input.StatusName ||
                    (this.StatusName != null &&
                    this.StatusName.Equals(input.StatusName))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
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
                if (this.StatusId != null)
                    hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                if (this.StatusName != null)
                    hashCode = hashCode * 59 + this.StatusName.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
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
