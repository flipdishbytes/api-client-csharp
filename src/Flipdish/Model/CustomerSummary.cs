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
    /// Customer summary
    /// </summary>
    [DataContract]
    public partial class CustomerSummary :  IEquatable<CustomerSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSummary" /> class.
        /// </summary>
        /// <param name="id">Customer identifier.</param>
        /// <param name="name">Customer name.</param>
        /// <param name="emailAddress">Customer email address.</param>
        /// <param name="phoneNumberLocalFormat">Customer local phone number.</param>
        /// <param name="phoneNumber">Customer phone number.</param>
        public CustomerSummary(int? id = default(int?), string name = default(string), string emailAddress = default(string), string phoneNumberLocalFormat = default(string), string phoneNumber = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.PhoneNumberLocalFormat = phoneNumberLocalFormat;
            this.PhoneNumber = phoneNumber;
        }
        
        /// <summary>
        /// Customer identifier
        /// </summary>
        /// <value>Customer identifier</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Customer name
        /// </summary>
        /// <value>Customer name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Customer email address
        /// </summary>
        /// <value>Customer email address</value>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Customer local phone number
        /// </summary>
        /// <value>Customer local phone number</value>
        [DataMember(Name="PhoneNumberLocalFormat", EmitDefaultValue=false)]
        public string PhoneNumberLocalFormat { get; set; }

        /// <summary>
        /// Customer phone number
        /// </summary>
        /// <value>Customer phone number</value>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  PhoneNumberLocalFormat: ").Append(PhoneNumberLocalFormat).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as CustomerSummary);
        }

        /// <summary>
        /// Returns true if CustomerSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerSummary input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.PhoneNumberLocalFormat == input.PhoneNumberLocalFormat ||
                    (this.PhoneNumberLocalFormat != null &&
                    this.PhoneNumberLocalFormat.Equals(input.PhoneNumberLocalFormat))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.PhoneNumberLocalFormat != null)
                    hashCode = hashCode * 59 + this.PhoneNumberLocalFormat.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                return hashCode;
            }
        }
    }

}
