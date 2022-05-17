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
    /// StoreConfig
    /// </summary>
    [DataContract]
    public partial class StoreConfig :  IEquatable<StoreConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreConfig" /> class.
        /// </summary>
        /// <param name="pickupEnabled">True if the store accepts pickup orders.</param>
        /// <param name="bankAccountAttached">True if the store has a Bank Account attached.</param>
        /// <param name="menuAssigned">True if the store is assigned to a Menu.</param>
        /// <param name="hasFullAddress">True if the store has a valid Address.</param>
        /// <param name="pickupHours">True if the store has Pickup hours.</param>
        /// <param name="isPublished">Is the Store Published.</param>
        public StoreConfig(bool? pickupEnabled = default(bool?), bool? bankAccountAttached = default(bool?), bool? menuAssigned = default(bool?), bool? hasFullAddress = default(bool?), bool? pickupHours = default(bool?), bool? isPublished = default(bool?))
        {
            this.PickupEnabled = pickupEnabled;
            this.BankAccountAttached = bankAccountAttached;
            this.MenuAssigned = menuAssigned;
            this.HasFullAddress = hasFullAddress;
            this.PickupHours = pickupHours;
            this.IsPublished = isPublished;
        }
        
        /// <summary>
        /// True if the store accepts pickup orders
        /// </summary>
        /// <value>True if the store accepts pickup orders</value>
        [DataMember(Name="PickupEnabled", EmitDefaultValue=false)]
        public bool? PickupEnabled { get; set; }

        /// <summary>
        /// True if the store has a Bank Account attached
        /// </summary>
        /// <value>True if the store has a Bank Account attached</value>
        [DataMember(Name="BankAccountAttached", EmitDefaultValue=false)]
        public bool? BankAccountAttached { get; set; }

        /// <summary>
        /// True if the store is assigned to a Menu
        /// </summary>
        /// <value>True if the store is assigned to a Menu</value>
        [DataMember(Name="MenuAssigned", EmitDefaultValue=false)]
        public bool? MenuAssigned { get; set; }

        /// <summary>
        /// True if the store has a valid Address
        /// </summary>
        /// <value>True if the store has a valid Address</value>
        [DataMember(Name="HasFullAddress", EmitDefaultValue=false)]
        public bool? HasFullAddress { get; set; }

        /// <summary>
        /// True if the store has Pickup hours
        /// </summary>
        /// <value>True if the store has Pickup hours</value>
        [DataMember(Name="PickupHours", EmitDefaultValue=false)]
        public bool? PickupHours { get; set; }

        /// <summary>
        /// Is the Store Published
        /// </summary>
        /// <value>Is the Store Published</value>
        [DataMember(Name="IsPublished", EmitDefaultValue=false)]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreConfig {\n");
            sb.Append("  PickupEnabled: ").Append(PickupEnabled).Append("\n");
            sb.Append("  BankAccountAttached: ").Append(BankAccountAttached).Append("\n");
            sb.Append("  MenuAssigned: ").Append(MenuAssigned).Append("\n");
            sb.Append("  HasFullAddress: ").Append(HasFullAddress).Append("\n");
            sb.Append("  PickupHours: ").Append(PickupHours).Append("\n");
            sb.Append("  IsPublished: ").Append(IsPublished).Append("\n");
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
            return this.Equals(input as StoreConfig);
        }

        /// <summary>
        /// Returns true if StoreConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PickupEnabled == input.PickupEnabled ||
                    (this.PickupEnabled != null &&
                    this.PickupEnabled.Equals(input.PickupEnabled))
                ) && 
                (
                    this.BankAccountAttached == input.BankAccountAttached ||
                    (this.BankAccountAttached != null &&
                    this.BankAccountAttached.Equals(input.BankAccountAttached))
                ) && 
                (
                    this.MenuAssigned == input.MenuAssigned ||
                    (this.MenuAssigned != null &&
                    this.MenuAssigned.Equals(input.MenuAssigned))
                ) && 
                (
                    this.HasFullAddress == input.HasFullAddress ||
                    (this.HasFullAddress != null &&
                    this.HasFullAddress.Equals(input.HasFullAddress))
                ) && 
                (
                    this.PickupHours == input.PickupHours ||
                    (this.PickupHours != null &&
                    this.PickupHours.Equals(input.PickupHours))
                ) && 
                (
                    this.IsPublished == input.IsPublished ||
                    (this.IsPublished != null &&
                    this.IsPublished.Equals(input.IsPublished))
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
                if (this.PickupEnabled != null)
                    hashCode = hashCode * 59 + this.PickupEnabled.GetHashCode();
                if (this.BankAccountAttached != null)
                    hashCode = hashCode * 59 + this.BankAccountAttached.GetHashCode();
                if (this.MenuAssigned != null)
                    hashCode = hashCode * 59 + this.MenuAssigned.GetHashCode();
                if (this.HasFullAddress != null)
                    hashCode = hashCode * 59 + this.HasFullAddress.GetHashCode();
                if (this.PickupHours != null)
                    hashCode = hashCode * 59 + this.PickupHours.GetHashCode();
                if (this.IsPublished != null)
                    hashCode = hashCode * 59 + this.IsPublished.GetHashCode();
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