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
    /// Card reader registration request
    /// </summary>
    [DataContract]
    public partial class CardReaderRegistrationRequest :  IEquatable<CardReaderRegistrationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardReaderRegistrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardReaderRegistrationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardReaderRegistrationRequest" /> class.
        /// </summary>
        /// <param name="registrationCode">The reader registration code (required).</param>
        /// <param name="kioskDeviceId">The kiosk device id.</param>
        public CardReaderRegistrationRequest(string registrationCode = default(string), string kioskDeviceId = default(string))
        {
            // to ensure "registrationCode" is required (not null)
            if (registrationCode == null)
            {
                throw new InvalidDataException("registrationCode is a required property for CardReaderRegistrationRequest and cannot be null");
            }
            else
            {
                this.RegistrationCode = registrationCode;
            }
            this.KioskDeviceId = kioskDeviceId;
        }
        
        /// <summary>
        /// The reader registration code
        /// </summary>
        /// <value>The reader registration code</value>
        [DataMember(Name="RegistrationCode", EmitDefaultValue=false)]
        public string RegistrationCode { get; set; }

        /// <summary>
        /// The kiosk device id
        /// </summary>
        /// <value>The kiosk device id</value>
        [DataMember(Name="KioskDeviceId", EmitDefaultValue=false)]
        public string KioskDeviceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardReaderRegistrationRequest {\n");
            sb.Append("  RegistrationCode: ").Append(RegistrationCode).Append("\n");
            sb.Append("  KioskDeviceId: ").Append(KioskDeviceId).Append("\n");
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
            return this.Equals(input as CardReaderRegistrationRequest);
        }

        /// <summary>
        /// Returns true if CardReaderRegistrationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CardReaderRegistrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardReaderRegistrationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RegistrationCode == input.RegistrationCode ||
                    (this.RegistrationCode != null &&
                    this.RegistrationCode.Equals(input.RegistrationCode))
                ) && 
                (
                    this.KioskDeviceId == input.KioskDeviceId ||
                    (this.KioskDeviceId != null &&
                    this.KioskDeviceId.Equals(input.KioskDeviceId))
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
                if (this.RegistrationCode != null)
                    hashCode = hashCode * 59 + this.RegistrationCode.GetHashCode();
                if (this.KioskDeviceId != null)
                    hashCode = hashCode * 59 + this.KioskDeviceId.GetHashCode();
                return hashCode;
            }
        }
    }

}
