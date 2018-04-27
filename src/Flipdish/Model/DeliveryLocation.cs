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
    /// Delivery location
    /// </summary>
    [DataContract]
    public partial class DeliveryLocation :  IEquatable<DeliveryLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryLocation" /> class.
        /// </summary>
        /// <param name="Coordinates">Geo cordinate.</param>
        /// <param name="Building">Building.</param>
        /// <param name="Street">Street.</param>
        /// <param name="Town">Town.</param>
        /// <param name="PostCode">Post code.</param>
        /// <param name="DeliveryInstructions">Delivery instructions.</param>
        /// <param name="PrettyAddressString">Formatted, pretty address string.</param>
        public DeliveryLocation(Coordinates Coordinates = default(Coordinates), string Building = default(string), string Street = default(string), string Town = default(string), string PostCode = default(string), string DeliveryInstructions = default(string), string PrettyAddressString = default(string))
        {
            this.Coordinates = Coordinates;
            this.Building = Building;
            this.Street = Street;
            this.Town = Town;
            this.PostCode = PostCode;
            this.DeliveryInstructions = DeliveryInstructions;
            this.PrettyAddressString = PrettyAddressString;
        }
        
        /// <summary>
        /// Geo cordinate
        /// </summary>
        /// <value>Geo cordinate</value>
        [DataMember(Name="Coordinates", EmitDefaultValue=false)]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Building
        /// </summary>
        /// <value>Building</value>
        [DataMember(Name="Building", EmitDefaultValue=false)]
        public string Building { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        /// <value>Street</value>
        [DataMember(Name="Street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// Town
        /// </summary>
        /// <value>Town</value>
        [DataMember(Name="Town", EmitDefaultValue=false)]
        public string Town { get; set; }

        /// <summary>
        /// Post code
        /// </summary>
        /// <value>Post code</value>
        [DataMember(Name="PostCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }

        /// <summary>
        /// Delivery instructions
        /// </summary>
        /// <value>Delivery instructions</value>
        [DataMember(Name="DeliveryInstructions", EmitDefaultValue=false)]
        public string DeliveryInstructions { get; set; }

        /// <summary>
        /// Formatted, pretty address string
        /// </summary>
        /// <value>Formatted, pretty address string</value>
        [DataMember(Name="PrettyAddressString", EmitDefaultValue=false)]
        public string PrettyAddressString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryLocation {\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("  Building: ").Append(Building).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Town: ").Append(Town).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  DeliveryInstructions: ").Append(DeliveryInstructions).Append("\n");
            sb.Append("  PrettyAddressString: ").Append(PrettyAddressString).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeliveryLocation);
        }

        /// <summary>
        /// Returns true if DeliveryLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Coordinates == input.Coordinates ||
                    (this.Coordinates != null &&
                    this.Coordinates.Equals(input.Coordinates))
                ) && 
                (
                    this.Building == input.Building ||
                    (this.Building != null &&
                    this.Building.Equals(input.Building))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.Town == input.Town ||
                    (this.Town != null &&
                    this.Town.Equals(input.Town))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.DeliveryInstructions == input.DeliveryInstructions ||
                    (this.DeliveryInstructions != null &&
                    this.DeliveryInstructions.Equals(input.DeliveryInstructions))
                ) && 
                (
                    this.PrettyAddressString == input.PrettyAddressString ||
                    (this.PrettyAddressString != null &&
                    this.PrettyAddressString.Equals(input.PrettyAddressString))
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
                if (this.Coordinates != null)
                    hashCode = hashCode * 59 + this.Coordinates.GetHashCode();
                if (this.Building != null)
                    hashCode = hashCode * 59 + this.Building.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.Town != null)
                    hashCode = hashCode * 59 + this.Town.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.DeliveryInstructions != null)
                    hashCode = hashCode * 59 + this.DeliveryInstructions.GetHashCode();
                if (this.PrettyAddressString != null)
                    hashCode = hashCode * 59 + this.PrettyAddressString.GetHashCode();
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
