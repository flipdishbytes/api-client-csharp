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
    /// Job Delivery Detail
    /// </summary>
    [DataContract]
    public partial class JobDeliveryDetail :  IEquatable<JobDeliveryDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobDeliveryDetail" /> class.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="latitude">Latitude.</param>
        /// <param name="longitude">Longitude.</param>
        /// <param name="comment">Comment.</param>
        /// <param name="address">Address.</param>
        /// <param name="contact">Contact.</param>
        public JobDeliveryDetail(int? id = default(int?), double? latitude = default(double?), double? longitude = default(double?), string comment = default(string), JobAddress address = default(JobAddress), JobContact contact = default(JobContact))
        {
            this.Id = id;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Comment = comment;
            this.Address = address;
            this.Contact = contact;
        }
        
        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Latitude
        /// </summary>
        /// <value>Latitude</value>
        [DataMember(Name="Latitude", EmitDefaultValue=false)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        /// <value>Longitude</value>
        [DataMember(Name="Longitude", EmitDefaultValue=false)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        /// <value>Comment</value>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        /// <value>Address</value>
        [DataMember(Name="Address", EmitDefaultValue=false)]
        public JobAddress Address { get; set; }

        /// <summary>
        /// Contact
        /// </summary>
        /// <value>Contact</value>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public JobContact Contact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobDeliveryDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
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
            return this.Equals(input as JobDeliveryDetail);
        }

        /// <summary>
        /// Returns true if JobDeliveryDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of JobDeliveryDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobDeliveryDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
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
