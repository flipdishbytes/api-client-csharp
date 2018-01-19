/* 
 * Flipdish Open API
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
using PropertyChanged;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Flipdish.Client.SwaggerDateConverter;

namespace Flipdish.Model
{
    /// <summary>
    /// StoreAddress
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class StoreAddress :  IEquatable<StoreAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAddress" /> class.
        /// </summary>
        /// <param name="AddressId">AddressId.</param>
        /// <param name="Line1">Line1.</param>
        /// <param name="Postcode">Postcode.</param>
        /// <param name="City">City.</param>
        /// <param name="CountryCode">CountryCode.</param>
        /// <param name="DisplayForCustomer">DisplayForCustomer.</param>
        /// <param name="Coordinates">Coordinates.</param>
        public StoreAddress(int? AddressId = default(int?), string Line1 = default(string), string Postcode = default(string), string City = default(string), string CountryCode = default(string), string DisplayForCustomer = default(string), Coordinates Coordinates = default(Coordinates))
        {
            this.AddressId = AddressId;
            this.Line1 = Line1;
            this.Postcode = Postcode;
            this.City = City;
            this.CountryCode = CountryCode;
            this.DisplayForCustomer = DisplayForCustomer;
            this.Coordinates = Coordinates;
        }
        
        /// <summary>
        /// Gets or Sets AddressId
        /// </summary>
        [DataMember(Name="AddressId", EmitDefaultValue=false)]
        public int? AddressId { get; set; }

        /// <summary>
        /// Gets or Sets Line1
        /// </summary>
        [DataMember(Name="Line1", EmitDefaultValue=false)]
        public string Line1 { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name="Postcode", EmitDefaultValue=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets DisplayForCustomer
        /// </summary>
        [DataMember(Name="DisplayForCustomer", EmitDefaultValue=false)]
        public string DisplayForCustomer { get; set; }

        /// <summary>
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name="Coordinates", EmitDefaultValue=false)]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreAddress {\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DisplayForCustomer: ").Append(DisplayForCustomer).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as StoreAddress);
        }

        /// <summary>
        /// Returns true if StoreAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of StoreAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressId == other.AddressId ||
                    this.AddressId != null &&
                    this.AddressId.Equals(other.AddressId)
                ) && 
                (
                    this.Line1 == other.Line1 ||
                    this.Line1 != null &&
                    this.Line1.Equals(other.Line1)
                ) && 
                (
                    this.Postcode == other.Postcode ||
                    this.Postcode != null &&
                    this.Postcode.Equals(other.Postcode)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.DisplayForCustomer == other.DisplayForCustomer ||
                    this.DisplayForCustomer != null &&
                    this.DisplayForCustomer.Equals(other.DisplayForCustomer)
                ) && 
                (
                    this.Coordinates == other.Coordinates ||
                    this.Coordinates != null &&
                    this.Coordinates.Equals(other.Coordinates)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AddressId != null)
                    hash = hash * 59 + this.AddressId.GetHashCode();
                if (this.Line1 != null)
                    hash = hash * 59 + this.Line1.GetHashCode();
                if (this.Postcode != null)
                    hash = hash * 59 + this.Postcode.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.DisplayForCustomer != null)
                    hash = hash * 59 + this.DisplayForCustomer.GetHashCode();
                if (this.Coordinates != null)
                    hash = hash * 59 + this.Coordinates.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Trigger when a property changed
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            // NOTE: property changed is handled via "code weaving" using Fody.
            // Properties with setters are modified at compile time to notify of changes.
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // CountryCode (string) maxLength
            if(this.CountryCode != null && this.CountryCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 2.", new [] { "CountryCode" });
            }

            // CountryCode (string) minLength
            if(this.CountryCode != null && this.CountryCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be greater than 0.", new [] { "CountryCode" });
            }

            yield break;
        }
    }

}
