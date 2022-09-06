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
    /// Enroll a client device
    /// </summary>
    [DataContract]
    public partial class ClientDeviceEnroll :  IEquatable<ClientDeviceEnroll>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDeviceEnroll" /> class.
        /// </summary>
        /// <param name="deviceModel">Device model.</param>
        /// <param name="deviceId">Device Id.</param>
        /// <param name="deviceName">Device Name.</param>
        public ClientDeviceEnroll(string deviceModel = default(string), string deviceId = default(string), string deviceName = default(string))
        {
            this.DeviceModel = deviceModel;
            this.DeviceId = deviceId;
            this.DeviceName = deviceName;
        }
        
        /// <summary>
        /// Device model
        /// </summary>
        /// <value>Device model</value>
        [DataMember(Name="DeviceModel", EmitDefaultValue=false)]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Device Id
        /// </summary>
        /// <value>Device Id</value>
        [DataMember(Name="DeviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Device Name
        /// </summary>
        /// <value>Device Name</value>
        [DataMember(Name="DeviceName", EmitDefaultValue=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientDeviceEnroll {\n");
            sb.Append("  DeviceModel: ").Append(DeviceModel).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
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
            return this.Equals(input as ClientDeviceEnroll);
        }

        /// <summary>
        /// Returns true if ClientDeviceEnroll instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientDeviceEnroll to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientDeviceEnroll input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceModel == input.DeviceModel ||
                    (this.DeviceModel != null &&
                    this.DeviceModel.Equals(input.DeviceModel))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.DeviceName == input.DeviceName ||
                    (this.DeviceName != null &&
                    this.DeviceName.Equals(input.DeviceName))
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
                if (this.DeviceModel != null)
                    hashCode = hashCode * 59 + this.DeviceModel.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.DeviceName != null)
                    hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                return hashCode;
            }
        }
    }

}
