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
    /// Driver
    /// </summary>
    [DataContract]
    public partial class Driver :  IEquatable<Driver>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Driver" /> class.
        /// </summary>
        /// <param name="userId">User Id.</param>
        /// <param name="userName">User Name.</param>
        /// <param name="userPhoneNumber">User Phone Number.</param>
        /// <param name="stores">stores.</param>
        /// <param name="profileImageUrl">Profile image url.</param>
        /// <param name="driverKey">Driver Key.</param>
        public Driver(int? userId = default(int?), string userName = default(string), string userPhoneNumber = default(string), List<DriverStore> stores = default(List<DriverStore>), string profileImageUrl = default(string), string driverKey = default(string))
        {
            this.UserId = userId;
            this.UserName = userName;
            this.UserPhoneNumber = userPhoneNumber;
            this.Stores = stores;
            this.ProfileImageUrl = profileImageUrl;
            this.DriverKey = driverKey;
        }
        
        /// <summary>
        /// User Id
        /// </summary>
        /// <value>User Id</value>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        /// <value>User Name</value>
        [DataMember(Name="UserName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// User Phone Number
        /// </summary>
        /// <value>User Phone Number</value>
        [DataMember(Name="UserPhoneNumber", EmitDefaultValue=false)]
        public string UserPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Stores
        /// </summary>
        [DataMember(Name="Stores", EmitDefaultValue=false)]
        public List<DriverStore> Stores { get; set; }

        /// <summary>
        /// Profile image url
        /// </summary>
        /// <value>Profile image url</value>
        [DataMember(Name="ProfileImageUrl", EmitDefaultValue=false)]
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// Driver Key
        /// </summary>
        /// <value>Driver Key</value>
        [DataMember(Name="DriverKey", EmitDefaultValue=false)]
        public string DriverKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Driver {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserPhoneNumber: ").Append(UserPhoneNumber).Append("\n");
            sb.Append("  Stores: ").Append(Stores).Append("\n");
            sb.Append("  ProfileImageUrl: ").Append(ProfileImageUrl).Append("\n");
            sb.Append("  DriverKey: ").Append(DriverKey).Append("\n");
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
            return this.Equals(input as Driver);
        }

        /// <summary>
        /// Returns true if Driver instances are equal
        /// </summary>
        /// <param name="input">Instance of Driver to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Driver input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.UserPhoneNumber == input.UserPhoneNumber ||
                    (this.UserPhoneNumber != null &&
                    this.UserPhoneNumber.Equals(input.UserPhoneNumber))
                ) && 
                (
                    this.Stores == input.Stores ||
                    this.Stores != null &&
                    this.Stores.SequenceEqual(input.Stores)
                ) && 
                (
                    this.ProfileImageUrl == input.ProfileImageUrl ||
                    (this.ProfileImageUrl != null &&
                    this.ProfileImageUrl.Equals(input.ProfileImageUrl))
                ) && 
                (
                    this.DriverKey == input.DriverKey ||
                    (this.DriverKey != null &&
                    this.DriverKey.Equals(input.DriverKey))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserPhoneNumber != null)
                    hashCode = hashCode * 59 + this.UserPhoneNumber.GetHashCode();
                if (this.Stores != null)
                    hashCode = hashCode * 59 + this.Stores.GetHashCode();
                if (this.ProfileImageUrl != null)
                    hashCode = hashCode * 59 + this.ProfileImageUrl.GetHashCode();
                if (this.DriverKey != null)
                    hashCode = hashCode * 59 + this.DriverKey.GetHashCode();
                return hashCode;
            }
        }
    }

}
