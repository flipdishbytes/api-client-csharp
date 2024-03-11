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
    /// Represents information about a Stripe connected account associated with a bank account
    /// </summary>
    [DataContract]
    public partial class StripeConnectedAccountInfo :  IEquatable<StripeConnectedAccountInfo>
    {
        /// <summary>
        /// Stripe connected account status
        /// </summary>
        /// <value>Stripe connected account status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountStatusEnum
        {
            
            /// <summary>
            /// Enum Disabled for value: Disabled
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled = 1,
            
            /// <summary>
            /// Enum Enabled for value: Enabled
            /// </summary>
            [EnumMember(Value = "Enabled")]
            Enabled = 2,
            
            /// <summary>
            /// Enum AdditionalInformationRequired for value: AdditionalInformationRequired
            /// </summary>
            [EnumMember(Value = "AdditionalInformationRequired")]
            AdditionalInformationRequired = 3,
            
            /// <summary>
            /// Enum PendingVerification for value: PendingVerification
            /// </summary>
            [EnumMember(Value = "PendingVerification")]
            PendingVerification = 4,
            
            /// <summary>
            /// Enum Unverified for value: Unverified
            /// </summary>
            [EnumMember(Value = "Unverified")]
            Unverified = 5,
            
            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 6,
            
            /// <summary>
            /// Enum UpdateExternalAccount for value: UpdateExternalAccount
            /// </summary>
            [EnumMember(Value = "UpdateExternalAccount")]
            UpdateExternalAccount = 7
        }

        /// <summary>
        /// Stripe connected account status
        /// </summary>
        /// <value>Stripe connected account status</value>
        [DataMember(Name="AccountStatus", EmitDefaultValue=false)]
        public AccountStatusEnum? AccountStatus { get; set; }
        /// <summary>
        /// Current status of the Card Payment capability of the account
        /// </summary>
        /// <value>Current status of the Card Payment capability of the account</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardPaymentStatusEnum
        {
            
            /// <summary>
            /// Enum Inactive for value: Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive = 1,
            
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 2,
            
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 3,
            
            /// <summary>
            /// Enum Unrequested for value: Unrequested
            /// </summary>
            [EnumMember(Value = "Unrequested")]
            Unrequested = 4
        }

        /// <summary>
        /// Current status of the Card Payment capability of the account
        /// </summary>
        /// <value>Current status of the Card Payment capability of the account</value>
        [DataMember(Name="CardPaymentStatus", EmitDefaultValue=false)]
        public CardPaymentStatusEnum? CardPaymentStatus { get; set; }
        /// <summary>
        /// Payouts Schedule Interval
        /// </summary>
        /// <value>Payouts Schedule Interval</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PayoutScheduleIntervalEnum
        {
            
            /// <summary>
            /// Enum Manual for value: Manual
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual = 1,
            
            /// <summary>
            /// Enum Daily for value: Daily
            /// </summary>
            [EnumMember(Value = "Daily")]
            Daily = 2,
            
            /// <summary>
            /// Enum Weekly for value: Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            Weekly = 3,
            
            /// <summary>
            /// Enum Monthly for value: Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            Monthly = 4
        }

        /// <summary>
        /// Payouts Schedule Interval
        /// </summary>
        /// <value>Payouts Schedule Interval</value>
        [DataMember(Name="PayoutScheduleInterval", EmitDefaultValue=false)]
        public PayoutScheduleIntervalEnum? PayoutScheduleInterval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeConnectedAccountInfo" /> class.
        /// </summary>
        /// <param name="accountStatus">Stripe connected account status.</param>
        /// <param name="stripeId">Stripe connected account id.</param>
        /// <param name="cardPaymentStatus">Current status of the Card Payment capability of the account.</param>
        /// <param name="payoutScheduleInterval">Payouts Schedule Interval.</param>
        /// <param name="payoutsEnabled">Payouts Enabled status.</param>
        /// <param name="payoutsPaused">Flag indicating if payouts are paused.</param>
        /// <param name="paymentsEnabled">Flag indicating if payments are enabled.</param>
        public StripeConnectedAccountInfo(AccountStatusEnum? accountStatus = default(AccountStatusEnum?), string stripeId = default(string), CardPaymentStatusEnum? cardPaymentStatus = default(CardPaymentStatusEnum?), PayoutScheduleIntervalEnum? payoutScheduleInterval = default(PayoutScheduleIntervalEnum?), bool? payoutsEnabled = default(bool?), bool? payoutsPaused = default(bool?), bool? paymentsEnabled = default(bool?))
        {
            this.AccountStatus = accountStatus;
            this.StripeId = stripeId;
            this.CardPaymentStatus = cardPaymentStatus;
            this.PayoutScheduleInterval = payoutScheduleInterval;
            this.PayoutsEnabled = payoutsEnabled;
            this.PayoutsPaused = payoutsPaused;
            this.PaymentsEnabled = paymentsEnabled;
        }
        

        /// <summary>
        /// Stripe connected account id
        /// </summary>
        /// <value>Stripe connected account id</value>
        [DataMember(Name="StripeId", EmitDefaultValue=false)]
        public string StripeId { get; set; }



        /// <summary>
        /// Payouts Enabled status
        /// </summary>
        /// <value>Payouts Enabled status</value>
        [DataMember(Name="PayoutsEnabled", EmitDefaultValue=false)]
        public bool? PayoutsEnabled { get; set; }

        /// <summary>
        /// Flag indicating if payouts are paused
        /// </summary>
        /// <value>Flag indicating if payouts are paused</value>
        [DataMember(Name="PayoutsPaused", EmitDefaultValue=false)]
        public bool? PayoutsPaused { get; set; }

        /// <summary>
        /// Flag indicating if payments are enabled
        /// </summary>
        /// <value>Flag indicating if payments are enabled</value>
        [DataMember(Name="PaymentsEnabled", EmitDefaultValue=false)]
        public bool? PaymentsEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StripeConnectedAccountInfo {\n");
            sb.Append("  AccountStatus: ").Append(AccountStatus).Append("\n");
            sb.Append("  StripeId: ").Append(StripeId).Append("\n");
            sb.Append("  CardPaymentStatus: ").Append(CardPaymentStatus).Append("\n");
            sb.Append("  PayoutScheduleInterval: ").Append(PayoutScheduleInterval).Append("\n");
            sb.Append("  PayoutsEnabled: ").Append(PayoutsEnabled).Append("\n");
            sb.Append("  PayoutsPaused: ").Append(PayoutsPaused).Append("\n");
            sb.Append("  PaymentsEnabled: ").Append(PaymentsEnabled).Append("\n");
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
            return this.Equals(input as StripeConnectedAccountInfo);
        }

        /// <summary>
        /// Returns true if StripeConnectedAccountInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of StripeConnectedAccountInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripeConnectedAccountInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountStatus == input.AccountStatus ||
                    (this.AccountStatus != null &&
                    this.AccountStatus.Equals(input.AccountStatus))
                ) && 
                (
                    this.StripeId == input.StripeId ||
                    (this.StripeId != null &&
                    this.StripeId.Equals(input.StripeId))
                ) && 
                (
                    this.CardPaymentStatus == input.CardPaymentStatus ||
                    (this.CardPaymentStatus != null &&
                    this.CardPaymentStatus.Equals(input.CardPaymentStatus))
                ) && 
                (
                    this.PayoutScheduleInterval == input.PayoutScheduleInterval ||
                    (this.PayoutScheduleInterval != null &&
                    this.PayoutScheduleInterval.Equals(input.PayoutScheduleInterval))
                ) && 
                (
                    this.PayoutsEnabled == input.PayoutsEnabled ||
                    (this.PayoutsEnabled != null &&
                    this.PayoutsEnabled.Equals(input.PayoutsEnabled))
                ) && 
                (
                    this.PayoutsPaused == input.PayoutsPaused ||
                    (this.PayoutsPaused != null &&
                    this.PayoutsPaused.Equals(input.PayoutsPaused))
                ) && 
                (
                    this.PaymentsEnabled == input.PaymentsEnabled ||
                    (this.PaymentsEnabled != null &&
                    this.PaymentsEnabled.Equals(input.PaymentsEnabled))
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
                if (this.AccountStatus != null)
                    hashCode = hashCode * 59 + this.AccountStatus.GetHashCode();
                if (this.StripeId != null)
                    hashCode = hashCode * 59 + this.StripeId.GetHashCode();
                if (this.CardPaymentStatus != null)
                    hashCode = hashCode * 59 + this.CardPaymentStatus.GetHashCode();
                if (this.PayoutScheduleInterval != null)
                    hashCode = hashCode * 59 + this.PayoutScheduleInterval.GetHashCode();
                if (this.PayoutsEnabled != null)
                    hashCode = hashCode * 59 + this.PayoutsEnabled.GetHashCode();
                if (this.PayoutsPaused != null)
                    hashCode = hashCode * 59 + this.PayoutsPaused.GetHashCode();
                if (this.PaymentsEnabled != null)
                    hashCode = hashCode * 59 + this.PaymentsEnabled.GetHashCode();
                return hashCode;
            }
        }
    }

}
