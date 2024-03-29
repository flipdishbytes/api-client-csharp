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
    /// Defines a customer create model
    /// </summary>
    [DataContract]
    public partial class CustomerCreateModel :  IEquatable<CustomerCreateModel>
    {
        /// <summary>
        /// Customer AppType
        /// </summary>
        /// <value>Customer AppType</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AppTypeEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum Ios for value: Ios
            /// </summary>
            [EnumMember(Value = "Ios")]
            Ios = 2,
            
            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")]
            Android = 3,
            
            /// <summary>
            /// Enum Web for value: Web
            /// </summary>
            [EnumMember(Value = "Web")]
            Web = 4,
            
            /// <summary>
            /// Enum Kiosk for value: Kiosk
            /// </summary>
            [EnumMember(Value = "Kiosk")]
            Kiosk = 5,
            
            /// <summary>
            /// Enum Pos for value: Pos
            /// </summary>
            [EnumMember(Value = "Pos")]
            Pos = 6,
            
            /// <summary>
            /// Enum TelephoneCall for value: TelephoneCall
            /// </summary>
            [EnumMember(Value = "TelephoneCall")]
            TelephoneCall = 7,
            
            /// <summary>
            /// Enum Sms for value: Sms
            /// </summary>
            [EnumMember(Value = "Sms")]
            Sms = 8,
            
            /// <summary>
            /// Enum PwaAndroid for value: PwaAndroid
            /// </summary>
            [EnumMember(Value = "PwaAndroid")]
            PwaAndroid = 9,
            
            /// <summary>
            /// Enum PwaIos for value: PwaIos
            /// </summary>
            [EnumMember(Value = "PwaIos")]
            PwaIos = 10,
            
            /// <summary>
            /// Enum Google for value: Google
            /// </summary>
            [EnumMember(Value = "Google")]
            Google = 11
        }

        /// <summary>
        /// Customer AppType
        /// </summary>
        /// <value>Customer AppType</value>
        [DataMember(Name="AppType", EmitDefaultValue=false)]
        public AppTypeEnum? AppType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCreateModel" /> class.
        /// </summary>
        /// <param name="phoneNumber">Customer Phone Number.</param>
        /// <param name="appType">Customer AppType.</param>
        /// <param name="name">Customer Name.</param>
        public CustomerCreateModel(string phoneNumber = default(string), AppTypeEnum? appType = default(AppTypeEnum?), string name = default(string))
        {
            this.PhoneNumber = phoneNumber;
            this.AppType = appType;
            this.Name = name;
        }
        
        /// <summary>
        /// Customer Phone Number
        /// </summary>
        /// <value>Customer Phone Number</value>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }


        /// <summary>
        /// Customer Name
        /// </summary>
        /// <value>Customer Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerCreateModel {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  AppType: ").Append(AppType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as CustomerCreateModel);
        }

        /// <summary>
        /// Returns true if CustomerCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerCreateModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.AppType == input.AppType ||
                    (this.AppType != null &&
                    this.AppType.Equals(input.AppType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.AppType != null)
                    hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}
