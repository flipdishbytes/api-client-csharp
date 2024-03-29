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
    /// Reject
    /// </summary>
    [DataContract]
    public partial class Reject :  IEquatable<Reject>
    {
        /// <summary>
        /// Reject reason.
        /// </summary>
        /// <value>Reject reason.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RejectReasonEnum
        {
            
            /// <summary>
            /// Enum TooBusy for value: TooBusy
            /// </summary>
            [EnumMember(Value = "TooBusy")]
            TooBusy = 1,
            
            /// <summary>
            /// Enum FoodUnavailable for value: FoodUnavailable
            /// </summary>
            [EnumMember(Value = "FoodUnavailable")]
            FoodUnavailable = 2,
            
            /// <summary>
            /// Enum UnableToDeliver for value: UnableToDeliver
            /// </summary>
            [EnumMember(Value = "UnableToDeliver")]
            UnableToDeliver = 3,
            
            /// <summary>
            /// Enum UnknownAddress for value: UnknownAddress
            /// </summary>
            [EnumMember(Value = "UnknownAddress")]
            UnknownAddress = 4,
            
            /// <summary>
            /// Enum UnknownReason for value: UnknownReason
            /// </summary>
            [EnumMember(Value = "UnknownReason")]
            UnknownReason = 5,
            
            /// <summary>
            /// Enum TooSoon for value: TooSoon
            /// </summary>
            [EnumMember(Value = "TooSoon")]
            TooSoon = 6,
            
            /// <summary>
            /// Enum TimeUnavailable for value: TimeUnavailable
            /// </summary>
            [EnumMember(Value = "TimeUnavailable")]
            TimeUnavailable = 7,
            
            /// <summary>
            /// Enum DontDeliverToArea for value: DontDeliverToArea
            /// </summary>
            [EnumMember(Value = "DontDeliverToArea")]
            DontDeliverToArea = 8,
            
            /// <summary>
            /// Enum StoreUncontactable for value: StoreUncontactable
            /// </summary>
            [EnumMember(Value = "StoreUncontactable")]
            StoreUncontactable = 9
        }

        /// <summary>
        /// Reject reason.
        /// </summary>
        /// <value>Reject reason.</value>
        [DataMember(Name="RejectReason", EmitDefaultValue=false)]
        public RejectReasonEnum RejectReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Reject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Reject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Reject" /> class.
        /// </summary>
        /// <param name="rejectReason">Reject reason. (required).</param>
        /// <param name="doNotNotifyCustomer">Notify customer. The server will not send and SMS to the customer if the value is true..</param>
        public Reject(RejectReasonEnum rejectReason = default(RejectReasonEnum), bool? doNotNotifyCustomer = default(bool?))
        {
            // to ensure "rejectReason" is required (not null)
            if (rejectReason == null)
            {
                throw new InvalidDataException("rejectReason is a required property for Reject and cannot be null");
            }
            else
            {
                this.RejectReason = rejectReason;
            }
            this.DoNotNotifyCustomer = doNotNotifyCustomer;
        }
        

        /// <summary>
        /// Notify customer. The server will not send and SMS to the customer if the value is true.
        /// </summary>
        /// <value>Notify customer. The server will not send and SMS to the customer if the value is true.</value>
        [DataMember(Name="DoNotNotifyCustomer", EmitDefaultValue=false)]
        public bool? DoNotNotifyCustomer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reject {\n");
            sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
            sb.Append("  DoNotNotifyCustomer: ").Append(DoNotNotifyCustomer).Append("\n");
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
            return this.Equals(input as Reject);
        }

        /// <summary>
        /// Returns true if Reject instances are equal
        /// </summary>
        /// <param name="input">Instance of Reject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RejectReason == input.RejectReason ||
                    (this.RejectReason != null &&
                    this.RejectReason.Equals(input.RejectReason))
                ) && 
                (
                    this.DoNotNotifyCustomer == input.DoNotNotifyCustomer ||
                    (this.DoNotNotifyCustomer != null &&
                    this.DoNotNotifyCustomer.Equals(input.DoNotNotifyCustomer))
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
                if (this.RejectReason != null)
                    hashCode = hashCode * 59 + this.RejectReason.GetHashCode();
                if (this.DoNotNotifyCustomer != null)
                    hashCode = hashCode * 59 + this.DoNotNotifyCustomer.GetHashCode();
                return hashCode;
            }
        }
    }

}
