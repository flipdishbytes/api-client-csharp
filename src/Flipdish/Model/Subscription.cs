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
    /// Subscription
    /// </summary>
    [DataContract]
    public partial class Subscription :  IEquatable<Subscription>, IValidatableObject
    {
        /// <summary>
        /// Status of the subscription (TrialPeriod, Ongoing, Unpaid, Canceled)
        /// </summary>
        /// <value>Status of the subscription (TrialPeriod, Ongoing, Unpaid, Canceled)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum TrialPeriod for value: TrialPeriod
            /// </summary>
            [EnumMember(Value = "TrialPeriod")]
            TrialPeriod = 1,
            
            /// <summary>
            /// Enum Ongoing for value: Ongoing
            /// </summary>
            [EnumMember(Value = "Ongoing")]
            Ongoing = 2,
            
            /// <summary>
            /// Enum Unpaid for value: Unpaid
            /// </summary>
            [EnumMember(Value = "Unpaid")]
            Unpaid = 3,
            
            /// <summary>
            /// Enum Canceled for value: Canceled
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled = 4
        }

        /// <summary>
        /// Status of the subscription (TrialPeriod, Ongoing, Unpaid, Canceled)
        /// </summary>
        /// <value>Status of the subscription (TrialPeriod, Ongoing, Unpaid, Canceled)</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="SubscriptionId">The subscription identifier.</param>
        /// <param name="StartDate">Starting date of the subscription.</param>
        /// <param name="Status">Status of the subscription (TrialPeriod, Ongoing, Unpaid, Canceled).</param>
        /// <param name="UserId">Flipdish user identifier.</param>
        /// <param name="SubscriptionPlan">Subscription Plan.</param>
        /// <param name="Card">Card.</param>
        /// <param name="AppId">App name Id of the subscription.</param>
        /// <param name="VatNumber">Last 4 digits of the card.</param>
        /// <param name="VatCountryCode">Expiry date of the card.</param>
        /// <param name="Quantity">Number of physical restaurants.</param>
        /// <param name="SubscriptionPlanId">Subscription plan identifier.</param>
        public Subscription(int? SubscriptionId = default(int?), DateTime? StartDate = default(DateTime?), StatusEnum? Status = default(StatusEnum?), int? UserId = default(int?), SubscriptionPlan SubscriptionPlan = default(SubscriptionPlan), Card Card = default(Card), string AppId = default(string), string VatNumber = default(string), string VatCountryCode = default(string), int? Quantity = default(int?), int? SubscriptionPlanId = default(int?))
        {
            this.SubscriptionId = SubscriptionId;
            this.StartDate = StartDate;
            this.Status = Status;
            this.UserId = UserId;
            this.SubscriptionPlan = SubscriptionPlan;
            this.Card = Card;
            this.AppId = AppId;
            this.VatNumber = VatNumber;
            this.VatCountryCode = VatCountryCode;
            this.Quantity = Quantity;
            this.SubscriptionPlanId = SubscriptionPlanId;
        }
        
        /// <summary>
        /// The subscription identifier
        /// </summary>
        /// <value>The subscription identifier</value>
        [DataMember(Name="SubscriptionId", EmitDefaultValue=false)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Starting date of the subscription
        /// </summary>
        /// <value>Starting date of the subscription</value>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }


        /// <summary>
        /// Flipdish user identifier
        /// </summary>
        /// <value>Flipdish user identifier</value>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Subscription Plan
        /// </summary>
        /// <value>Subscription Plan</value>
        [DataMember(Name="SubscriptionPlan", EmitDefaultValue=false)]
        public SubscriptionPlan SubscriptionPlan { get; set; }

        /// <summary>
        /// Card
        /// </summary>
        /// <value>Card</value>
        [DataMember(Name="Card", EmitDefaultValue=false)]
        public Card Card { get; set; }

        /// <summary>
        /// App name Id of the subscription
        /// </summary>
        /// <value>App name Id of the subscription</value>
        [DataMember(Name="AppId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Last 4 digits of the card
        /// </summary>
        /// <value>Last 4 digits of the card</value>
        [DataMember(Name="VatNumber", EmitDefaultValue=false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Expiry date of the card
        /// </summary>
        /// <value>Expiry date of the card</value>
        [DataMember(Name="VatCountryCode", EmitDefaultValue=false)]
        public string VatCountryCode { get; set; }

        /// <summary>
        /// Number of physical restaurants
        /// </summary>
        /// <value>Number of physical restaurants</value>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Subscription plan identifier
        /// </summary>
        /// <value>Subscription plan identifier</value>
        [DataMember(Name="SubscriptionPlanId", EmitDefaultValue=false)]
        public int? SubscriptionPlanId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  SubscriptionPlan: ").Append(SubscriptionPlan).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("  VatCountryCode: ").Append(VatCountryCode).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SubscriptionPlanId: ").Append(SubscriptionPlanId).Append("\n");
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
            return this.Equals(input as Subscription);
        }

        /// <summary>
        /// Returns true if Subscription instances are equal
        /// </summary>
        /// <param name="input">Instance of Subscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.SubscriptionPlan == input.SubscriptionPlan ||
                    (this.SubscriptionPlan != null &&
                    this.SubscriptionPlan.Equals(input.SubscriptionPlan))
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
                ) && 
                (
                    this.VatCountryCode == input.VatCountryCode ||
                    (this.VatCountryCode != null &&
                    this.VatCountryCode.Equals(input.VatCountryCode))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.SubscriptionPlanId == input.SubscriptionPlanId ||
                    (this.SubscriptionPlanId != null &&
                    this.SubscriptionPlanId.Equals(input.SubscriptionPlanId))
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
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.SubscriptionPlan != null)
                    hashCode = hashCode * 59 + this.SubscriptionPlan.GetHashCode();
                if (this.Card != null)
                    hashCode = hashCode * 59 + this.Card.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.VatNumber != null)
                    hashCode = hashCode * 59 + this.VatNumber.GetHashCode();
                if (this.VatCountryCode != null)
                    hashCode = hashCode * 59 + this.VatCountryCode.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.SubscriptionPlanId != null)
                    hashCode = hashCode * 59 + this.SubscriptionPlanId.GetHashCode();
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
