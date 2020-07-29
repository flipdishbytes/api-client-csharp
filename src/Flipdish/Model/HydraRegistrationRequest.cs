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
    /// Hydra registration result
    /// </summary>
    [DataContract]
    public partial class HydraRegistrationRequest :  IEquatable<HydraRegistrationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraRegistrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HydraRegistrationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraRegistrationRequest" /> class.
        /// </summary>
        /// <param name="storeIds">Stores to assign the hydra (required).</param>
        /// <param name="deviceName">Hydra device name (required).</param>
        /// <param name="pinCode">6 digit PIN code (not starting with zero)..</param>
        public HydraRegistrationRequest(List<int?> storeIds = default(List<int?>), string deviceName = default(string), int? pinCode = default(int?))
        {
            // to ensure "storeIds" is required (not null)
            if (storeIds == null)
            {
                throw new InvalidDataException("storeIds is a required property for HydraRegistrationRequest and cannot be null");
            }
            else
            {
                this.StoreIds = storeIds;
            }
            // to ensure "deviceName" is required (not null)
            if (deviceName == null)
            {
                throw new InvalidDataException("deviceName is a required property for HydraRegistrationRequest and cannot be null");
            }
            else
            {
                this.DeviceName = deviceName;
            }
            this.PinCode = pinCode;
        }
        
        /// <summary>
        /// Stores to assign the hydra
        /// </summary>
        /// <value>Stores to assign the hydra</value>
        [DataMember(Name="StoreIds", EmitDefaultValue=false)]
        public List<int?> StoreIds { get; set; }

        /// <summary>
        /// Hydra device name
        /// </summary>
        /// <value>Hydra device name</value>
        [DataMember(Name="DeviceName", EmitDefaultValue=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// 6 digit PIN code (not starting with zero).
        /// </summary>
        /// <value>6 digit PIN code (not starting with zero).</value>
        [DataMember(Name="PinCode", EmitDefaultValue=false)]
        public int? PinCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HydraRegistrationRequest {\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  PinCode: ").Append(PinCode).Append("\n");
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
            return this.Equals(input as HydraRegistrationRequest);
        }

        /// <summary>
        /// Returns true if HydraRegistrationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of HydraRegistrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HydraRegistrationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
                ) && 
                (
                    this.DeviceName == input.DeviceName ||
                    (this.DeviceName != null &&
                    this.DeviceName.Equals(input.DeviceName))
                ) && 
                (
                    this.PinCode == input.PinCode ||
                    (this.PinCode != null &&
                    this.PinCode.Equals(input.PinCode))
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
                if (this.StoreIds != null)
                    hashCode = hashCode * 59 + this.StoreIds.GetHashCode();
                if (this.DeviceName != null)
                    hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.PinCode != null)
                    hashCode = hashCode * 59 + this.PinCode.GetHashCode();
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
            // PinCode (int?) maximum
            if(this.PinCode > (int?)999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PinCode, must be a value less than or equal to 999999.", new [] { "PinCode" });
            }

            // PinCode (int?) minimum
            if(this.PinCode < (int?)100000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PinCode, must be a value greater than or equal to 100000.", new [] { "PinCode" });
            }

            yield break;
        }
    }

}
