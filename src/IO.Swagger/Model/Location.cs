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
    /// Location to deliver to
    /// </summary>
    [DataContract]
    public partial class Location :  IEquatable<Location>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="addressLine1">Line 1 of the address.</param>
        /// <param name="addressLine2">Line 2 of the address.</param>
        /// <param name="formattedAddress">Formatted Address.</param>
        /// <param name="postalCode">Postal / Zip Code.</param>
        /// <param name="city">City to deliver to.</param>
        /// <param name="coordinates">Coordinates to deliver to.</param>
        /// <param name="notes">Notes for delivery.</param>
        public Location(string addressLine1 = default(string), string addressLine2 = default(string), string formattedAddress = default(string), string postalCode = default(string), string city = default(string), Coordinates coordinates = default(Coordinates), string notes = default(string))
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.FormattedAddress = formattedAddress;
            this.PostalCode = postalCode;
            this.City = city;
            this.Coordinates = coordinates;
            this.Notes = notes;
        }
        
        /// <summary>
        /// Line 1 of the address
        /// </summary>
        /// <value>Line 1 of the address</value>
        [DataMember(Name="AddressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Line 2 of the address
        /// </summary>
        /// <value>Line 2 of the address</value>
        [DataMember(Name="AddressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Formatted Address
        /// </summary>
        /// <value>Formatted Address</value>
        [DataMember(Name="FormattedAddress", EmitDefaultValue=false)]
        public string FormattedAddress { get; set; }

        /// <summary>
        /// Postal / Zip Code
        /// </summary>
        /// <value>Postal / Zip Code</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// City to deliver to
        /// </summary>
        /// <value>City to deliver to</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Coordinates to deliver to
        /// </summary>
        /// <value>Coordinates to deliver to</value>
        [DataMember(Name="Coordinates", EmitDefaultValue=false)]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Notes for delivery
        /// </summary>
        /// <value>Notes for delivery</value>
        [DataMember(Name="Notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  FormattedAddress: ").Append(FormattedAddress).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="input">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.FormattedAddress == input.FormattedAddress ||
                    (this.FormattedAddress != null &&
                    this.FormattedAddress.Equals(input.FormattedAddress))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Coordinates == input.Coordinates ||
                    (this.Coordinates != null &&
                    this.Coordinates.Equals(input.Coordinates))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.FormattedAddress != null)
                    hashCode = hashCode * 59 + this.FormattedAddress.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Coordinates != null)
                    hashCode = hashCode * 59 + this.Coordinates.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
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
