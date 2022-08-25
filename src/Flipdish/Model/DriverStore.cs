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
    /// DriverStore
    /// </summary>
    [DataContract]
    public partial class DriverStore :  IEquatable<DriverStore>
    {
        /// <summary>
        /// Presence
        /// </summary>
        /// <value>Presence</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PresenceEnum
        {
            
            /// <summary>
            /// Enum Offline for value: Offline
            /// </summary>
            [EnumMember(Value = "Offline")]
            Offline = 1,
            
            /// <summary>
            /// Enum Online for value: Online
            /// </summary>
            [EnumMember(Value = "Online")]
            Online = 2
        }

        /// <summary>
        /// Presence
        /// </summary>
        /// <value>Presence</value>
        [DataMember(Name="Presence", EmitDefaultValue=false)]
        public PresenceEnum? Presence { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DriverStore" /> class.
        /// </summary>
        /// <param name="storeId">Store identifier.</param>
        /// <param name="storeName">Store name.</param>
        /// <param name="presence">Presence.</param>
        public DriverStore(int? storeId = default(int?), string storeName = default(string), PresenceEnum? presence = default(PresenceEnum?))
        {
            this.StoreId = storeId;
            this.StoreName = storeName;
            this.Presence = presence;
        }
        
        /// <summary>
        /// Store identifier
        /// </summary>
        /// <value>Store identifier</value>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public int? StoreId { get; set; }

        /// <summary>
        /// Store name
        /// </summary>
        /// <value>Store name</value>
        [DataMember(Name="StoreName", EmitDefaultValue=false)]
        public string StoreName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DriverStore {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
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
            return this.Equals(input as DriverStore);
        }

        /// <summary>
        /// Returns true if DriverStore instances are equal
        /// </summary>
        /// <param name="input">Instance of DriverStore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DriverStore input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
                ) && 
                (
                    this.Presence == input.Presence ||
                    (this.Presence != null &&
                    this.Presence.Equals(input.Presence))
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.StoreName != null)
                    hashCode = hashCode * 59 + this.StoreName.GetHashCode();
                if (this.Presence != null)
                    hashCode = hashCode * 59 + this.Presence.GetHashCode();
                return hashCode;
            }
        }
    }

}
