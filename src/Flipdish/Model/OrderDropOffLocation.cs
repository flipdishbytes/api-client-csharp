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
    /// OrderDropOffLocation
    /// </summary>
    [DataContract]
    public partial class OrderDropOffLocation :  IEquatable<OrderDropOffLocation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDropOffLocation" /> class.
        /// </summary>
        /// <param name="orderId">orderId.</param>
        /// <param name="locationName">locationName.</param>
        /// <param name="locationAreaName">locationAreaName.</param>
        /// <param name="locationId">locationId.</param>
        /// <param name="locationAreaId">locationAreaId.</param>
        /// <param name="externalLocationId">externalLocationId.</param>
        public OrderDropOffLocation(int? orderId = default(int?), string locationName = default(string), string locationAreaName = default(string), int? locationId = default(int?), int? locationAreaId = default(int?), string externalLocationId = default(string))
        {
            this.OrderId = orderId;
            this.LocationName = locationName;
            this.LocationAreaName = locationAreaName;
            this.LocationId = locationId;
            this.LocationAreaId = locationAreaId;
            this.ExternalLocationId = externalLocationId;
        }
        
        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="OrderId", EmitDefaultValue=false)]
        public int? OrderId { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name="LocationName", EmitDefaultValue=false)]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or Sets LocationAreaName
        /// </summary>
        [DataMember(Name="LocationAreaName", EmitDefaultValue=false)]
        public string LocationAreaName { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="LocationId", EmitDefaultValue=false)]
        public int? LocationId { get; set; }

        /// <summary>
        /// Gets or Sets LocationAreaId
        /// </summary>
        [DataMember(Name="LocationAreaId", EmitDefaultValue=false)]
        public int? LocationAreaId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalLocationId
        /// </summary>
        [DataMember(Name="ExternalLocationId", EmitDefaultValue=false)]
        public string ExternalLocationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderDropOffLocation {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  LocationAreaName: ").Append(LocationAreaName).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  LocationAreaId: ").Append(LocationAreaId).Append("\n");
            sb.Append("  ExternalLocationId: ").Append(ExternalLocationId).Append("\n");
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
            return this.Equals(input as OrderDropOffLocation);
        }

        /// <summary>
        /// Returns true if OrderDropOffLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderDropOffLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderDropOffLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && 
                (
                    this.LocationAreaName == input.LocationAreaName ||
                    (this.LocationAreaName != null &&
                    this.LocationAreaName.Equals(input.LocationAreaName))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.LocationAreaId == input.LocationAreaId ||
                    (this.LocationAreaId != null &&
                    this.LocationAreaId.Equals(input.LocationAreaId))
                ) && 
                (
                    this.ExternalLocationId == input.ExternalLocationId ||
                    (this.ExternalLocationId != null &&
                    this.ExternalLocationId.Equals(input.ExternalLocationId))
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
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.LocationAreaName != null)
                    hashCode = hashCode * 59 + this.LocationAreaName.GetHashCode();
                if (this.LocationId != null)
                    hashCode = hashCode * 59 + this.LocationId.GetHashCode();
                if (this.LocationAreaId != null)
                    hashCode = hashCode * 59 + this.LocationAreaId.GetHashCode();
                if (this.ExternalLocationId != null)
                    hashCode = hashCode * 59 + this.ExternalLocationId.GetHashCode();
                return hashCode;
            }
        }
    }

}
