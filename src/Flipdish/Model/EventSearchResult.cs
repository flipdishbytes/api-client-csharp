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
    /// EventSearchResult
    /// </summary>
    [DataContract]
    public partial class EventSearchResult :  IEquatable<EventSearchResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventSearchResult" /> class.
        /// </summary>
        /// <param name="OrderAcceptedEvent">OrderAcceptedEvent.</param>
        /// <param name="OrderCreatedEvent">OrderCreatedEvent.</param>
        /// <param name="OrderRatingUpdatedEvent">OrderRatingUpdatedEvent.</param>
        /// <param name="OrderRefundedEvent">OrderRefundedEvent.</param>
        /// <param name="OrderRejectedEvent">OrderRejectedEvent.</param>
        /// <param name="OrderTipUpdatedEvent">OrderTipUpdatedEvent.</param>
        /// <param name="StoreCreatedEvent">StoreCreatedEvent.</param>
        /// <param name="StoreDeletedEvent">StoreDeletedEvent.</param>
        /// <param name="StoreDeliveryZoneUpdatedEvent">StoreDeliveryZoneUpdatedEvent.</param>
        /// <param name="StoreOpeningHoursUpdatedEvent">StoreOpeningHoursUpdatedEvent.</param>
        /// <param name="StoreUpdatedEvent">StoreUpdatedEvent.</param>
        /// <param name="MenuCreatedEvent">MenuCreatedEvent.</param>
        /// <param name="MenuUpdatedEvent">MenuUpdatedEvent.</param>
        /// <param name="CustomerCreatedEvent">CustomerCreatedEvent.</param>
        /// <param name="CustomerUpdatedEvent">CustomerUpdatedEvent.</param>
        public EventSearchResult(List<OrderAcceptedEvent> OrderAcceptedEvent = default(List<OrderAcceptedEvent>), List<OrderCreatedEvent> OrderCreatedEvent = default(List<OrderCreatedEvent>), List<OrderRatingUpdatedEvent> OrderRatingUpdatedEvent = default(List<OrderRatingUpdatedEvent>), List<OrderRefundedEvent> OrderRefundedEvent = default(List<OrderRefundedEvent>), List<OrderRejectedEvent> OrderRejectedEvent = default(List<OrderRejectedEvent>), List<OrderTipUpdatedEvent> OrderTipUpdatedEvent = default(List<OrderTipUpdatedEvent>), List<StoreCreatedEvent> StoreCreatedEvent = default(List<StoreCreatedEvent>), List<StoreDeletedEvent> StoreDeletedEvent = default(List<StoreDeletedEvent>), List<StoreDeliveryZoneUpdatedEvent> StoreDeliveryZoneUpdatedEvent = default(List<StoreDeliveryZoneUpdatedEvent>), List<StoreOpeningHoursUpdatedEvent> StoreOpeningHoursUpdatedEvent = default(List<StoreOpeningHoursUpdatedEvent>), List<StoreUpdatedEvent> StoreUpdatedEvent = default(List<StoreUpdatedEvent>), List<MenuCreatedEvent> MenuCreatedEvent = default(List<MenuCreatedEvent>), List<MenuUpdatedEvent> MenuUpdatedEvent = default(List<MenuUpdatedEvent>), List<CustomerCreatedEvent> CustomerCreatedEvent = default(List<CustomerCreatedEvent>), List<CustomerUpdatedEvent> CustomerUpdatedEvent = default(List<CustomerUpdatedEvent>))
        {
            this.OrderAcceptedEvent = OrderAcceptedEvent;
            this.OrderCreatedEvent = OrderCreatedEvent;
            this.OrderRatingUpdatedEvent = OrderRatingUpdatedEvent;
            this.OrderRefundedEvent = OrderRefundedEvent;
            this.OrderRejectedEvent = OrderRejectedEvent;
            this.OrderTipUpdatedEvent = OrderTipUpdatedEvent;
            this.StoreCreatedEvent = StoreCreatedEvent;
            this.StoreDeletedEvent = StoreDeletedEvent;
            this.StoreDeliveryZoneUpdatedEvent = StoreDeliveryZoneUpdatedEvent;
            this.StoreOpeningHoursUpdatedEvent = StoreOpeningHoursUpdatedEvent;
            this.StoreUpdatedEvent = StoreUpdatedEvent;
            this.MenuCreatedEvent = MenuCreatedEvent;
            this.MenuUpdatedEvent = MenuUpdatedEvent;
            this.CustomerCreatedEvent = CustomerCreatedEvent;
            this.CustomerUpdatedEvent = CustomerUpdatedEvent;
        }
        
        /// <summary>
        /// Gets or Sets OrderAcceptedEvent
        /// </summary>
        [DataMember(Name="orderAcceptedEvent", EmitDefaultValue=false)]
        public List<OrderAcceptedEvent> OrderAcceptedEvent { get; set; }

        /// <summary>
        /// Gets or Sets OrderCreatedEvent
        /// </summary>
        [DataMember(Name="orderCreatedEvent", EmitDefaultValue=false)]
        public List<OrderCreatedEvent> OrderCreatedEvent { get; set; }

        /// <summary>
        /// Gets or Sets OrderRatingUpdatedEvent
        /// </summary>
        [DataMember(Name="orderRatingUpdatedEvent", EmitDefaultValue=false)]
        public List<OrderRatingUpdatedEvent> OrderRatingUpdatedEvent { get; set; }

        /// <summary>
        /// Gets or Sets OrderRefundedEvent
        /// </summary>
        [DataMember(Name="orderRefundedEvent", EmitDefaultValue=false)]
        public List<OrderRefundedEvent> OrderRefundedEvent { get; set; }

        /// <summary>
        /// Gets or Sets OrderRejectedEvent
        /// </summary>
        [DataMember(Name="orderRejectedEvent", EmitDefaultValue=false)]
        public List<OrderRejectedEvent> OrderRejectedEvent { get; set; }

        /// <summary>
        /// Gets or Sets OrderTipUpdatedEvent
        /// </summary>
        [DataMember(Name="orderTipUpdatedEvent", EmitDefaultValue=false)]
        public List<OrderTipUpdatedEvent> OrderTipUpdatedEvent { get; set; }

        /// <summary>
        /// Gets or Sets StoreCreatedEvent
        /// </summary>
        [DataMember(Name="storeCreatedEvent", EmitDefaultValue=false)]
        public List<StoreCreatedEvent> StoreCreatedEvent { get; set; }

        /// <summary>
        /// Gets or Sets StoreDeletedEvent
        /// </summary>
        [DataMember(Name="storeDeletedEvent", EmitDefaultValue=false)]
        public List<StoreDeletedEvent> StoreDeletedEvent { get; set; }

        /// <summary>
        /// Gets or Sets StoreDeliveryZoneUpdatedEvent
        /// </summary>
        [DataMember(Name="storeDeliveryZoneUpdatedEvent", EmitDefaultValue=false)]
        public List<StoreDeliveryZoneUpdatedEvent> StoreDeliveryZoneUpdatedEvent { get; set; }

        /// <summary>
        /// Gets or Sets StoreOpeningHoursUpdatedEvent
        /// </summary>
        [DataMember(Name="storeOpeningHoursUpdatedEvent", EmitDefaultValue=false)]
        public List<StoreOpeningHoursUpdatedEvent> StoreOpeningHoursUpdatedEvent { get; set; }

        /// <summary>
        /// Gets or Sets StoreUpdatedEvent
        /// </summary>
        [DataMember(Name="storeUpdatedEvent", EmitDefaultValue=false)]
        public List<StoreUpdatedEvent> StoreUpdatedEvent { get; set; }

        /// <summary>
        /// Gets or Sets MenuCreatedEvent
        /// </summary>
        [DataMember(Name="menuCreatedEvent", EmitDefaultValue=false)]
        public List<MenuCreatedEvent> MenuCreatedEvent { get; set; }

        /// <summary>
        /// Gets or Sets MenuUpdatedEvent
        /// </summary>
        [DataMember(Name="menuUpdatedEvent", EmitDefaultValue=false)]
        public List<MenuUpdatedEvent> MenuUpdatedEvent { get; set; }

        /// <summary>
        /// Gets or Sets CustomerCreatedEvent
        /// </summary>
        [DataMember(Name="customerCreatedEvent", EmitDefaultValue=false)]
        public List<CustomerCreatedEvent> CustomerCreatedEvent { get; set; }

        /// <summary>
        /// Gets or Sets CustomerUpdatedEvent
        /// </summary>
        [DataMember(Name="customerUpdatedEvent", EmitDefaultValue=false)]
        public List<CustomerUpdatedEvent> CustomerUpdatedEvent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventSearchResult {\n");
            sb.Append("  OrderAcceptedEvent: ").Append(OrderAcceptedEvent).Append("\n");
            sb.Append("  OrderCreatedEvent: ").Append(OrderCreatedEvent).Append("\n");
            sb.Append("  OrderRatingUpdatedEvent: ").Append(OrderRatingUpdatedEvent).Append("\n");
            sb.Append("  OrderRefundedEvent: ").Append(OrderRefundedEvent).Append("\n");
            sb.Append("  OrderRejectedEvent: ").Append(OrderRejectedEvent).Append("\n");
            sb.Append("  OrderTipUpdatedEvent: ").Append(OrderTipUpdatedEvent).Append("\n");
            sb.Append("  StoreCreatedEvent: ").Append(StoreCreatedEvent).Append("\n");
            sb.Append("  StoreDeletedEvent: ").Append(StoreDeletedEvent).Append("\n");
            sb.Append("  StoreDeliveryZoneUpdatedEvent: ").Append(StoreDeliveryZoneUpdatedEvent).Append("\n");
            sb.Append("  StoreOpeningHoursUpdatedEvent: ").Append(StoreOpeningHoursUpdatedEvent).Append("\n");
            sb.Append("  StoreUpdatedEvent: ").Append(StoreUpdatedEvent).Append("\n");
            sb.Append("  MenuCreatedEvent: ").Append(MenuCreatedEvent).Append("\n");
            sb.Append("  MenuUpdatedEvent: ").Append(MenuUpdatedEvent).Append("\n");
            sb.Append("  CustomerCreatedEvent: ").Append(CustomerCreatedEvent).Append("\n");
            sb.Append("  CustomerUpdatedEvent: ").Append(CustomerUpdatedEvent).Append("\n");
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
            return this.Equals(input as EventSearchResult);
        }

        /// <summary>
        /// Returns true if EventSearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of EventSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventSearchResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderAcceptedEvent == input.OrderAcceptedEvent ||
                    this.OrderAcceptedEvent != null &&
                    this.OrderAcceptedEvent.SequenceEqual(input.OrderAcceptedEvent)
                ) && 
                (
                    this.OrderCreatedEvent == input.OrderCreatedEvent ||
                    this.OrderCreatedEvent != null &&
                    this.OrderCreatedEvent.SequenceEqual(input.OrderCreatedEvent)
                ) && 
                (
                    this.OrderRatingUpdatedEvent == input.OrderRatingUpdatedEvent ||
                    this.OrderRatingUpdatedEvent != null &&
                    this.OrderRatingUpdatedEvent.SequenceEqual(input.OrderRatingUpdatedEvent)
                ) && 
                (
                    this.OrderRefundedEvent == input.OrderRefundedEvent ||
                    this.OrderRefundedEvent != null &&
                    this.OrderRefundedEvent.SequenceEqual(input.OrderRefundedEvent)
                ) && 
                (
                    this.OrderRejectedEvent == input.OrderRejectedEvent ||
                    this.OrderRejectedEvent != null &&
                    this.OrderRejectedEvent.SequenceEqual(input.OrderRejectedEvent)
                ) && 
                (
                    this.OrderTipUpdatedEvent == input.OrderTipUpdatedEvent ||
                    this.OrderTipUpdatedEvent != null &&
                    this.OrderTipUpdatedEvent.SequenceEqual(input.OrderTipUpdatedEvent)
                ) && 
                (
                    this.StoreCreatedEvent == input.StoreCreatedEvent ||
                    this.StoreCreatedEvent != null &&
                    this.StoreCreatedEvent.SequenceEqual(input.StoreCreatedEvent)
                ) && 
                (
                    this.StoreDeletedEvent == input.StoreDeletedEvent ||
                    this.StoreDeletedEvent != null &&
                    this.StoreDeletedEvent.SequenceEqual(input.StoreDeletedEvent)
                ) && 
                (
                    this.StoreDeliveryZoneUpdatedEvent == input.StoreDeliveryZoneUpdatedEvent ||
                    this.StoreDeliveryZoneUpdatedEvent != null &&
                    this.StoreDeliveryZoneUpdatedEvent.SequenceEqual(input.StoreDeliveryZoneUpdatedEvent)
                ) && 
                (
                    this.StoreOpeningHoursUpdatedEvent == input.StoreOpeningHoursUpdatedEvent ||
                    this.StoreOpeningHoursUpdatedEvent != null &&
                    this.StoreOpeningHoursUpdatedEvent.SequenceEqual(input.StoreOpeningHoursUpdatedEvent)
                ) && 
                (
                    this.StoreUpdatedEvent == input.StoreUpdatedEvent ||
                    this.StoreUpdatedEvent != null &&
                    this.StoreUpdatedEvent.SequenceEqual(input.StoreUpdatedEvent)
                ) && 
                (
                    this.MenuCreatedEvent == input.MenuCreatedEvent ||
                    this.MenuCreatedEvent != null &&
                    this.MenuCreatedEvent.SequenceEqual(input.MenuCreatedEvent)
                ) && 
                (
                    this.MenuUpdatedEvent == input.MenuUpdatedEvent ||
                    this.MenuUpdatedEvent != null &&
                    this.MenuUpdatedEvent.SequenceEqual(input.MenuUpdatedEvent)
                ) && 
                (
                    this.CustomerCreatedEvent == input.CustomerCreatedEvent ||
                    this.CustomerCreatedEvent != null &&
                    this.CustomerCreatedEvent.SequenceEqual(input.CustomerCreatedEvent)
                ) && 
                (
                    this.CustomerUpdatedEvent == input.CustomerUpdatedEvent ||
                    this.CustomerUpdatedEvent != null &&
                    this.CustomerUpdatedEvent.SequenceEqual(input.CustomerUpdatedEvent)
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
                if (this.OrderAcceptedEvent != null)
                    hashCode = hashCode * 59 + this.OrderAcceptedEvent.GetHashCode();
                if (this.OrderCreatedEvent != null)
                    hashCode = hashCode * 59 + this.OrderCreatedEvent.GetHashCode();
                if (this.OrderRatingUpdatedEvent != null)
                    hashCode = hashCode * 59 + this.OrderRatingUpdatedEvent.GetHashCode();
                if (this.OrderRefundedEvent != null)
                    hashCode = hashCode * 59 + this.OrderRefundedEvent.GetHashCode();
                if (this.OrderRejectedEvent != null)
                    hashCode = hashCode * 59 + this.OrderRejectedEvent.GetHashCode();
                if (this.OrderTipUpdatedEvent != null)
                    hashCode = hashCode * 59 + this.OrderTipUpdatedEvent.GetHashCode();
                if (this.StoreCreatedEvent != null)
                    hashCode = hashCode * 59 + this.StoreCreatedEvent.GetHashCode();
                if (this.StoreDeletedEvent != null)
                    hashCode = hashCode * 59 + this.StoreDeletedEvent.GetHashCode();
                if (this.StoreDeliveryZoneUpdatedEvent != null)
                    hashCode = hashCode * 59 + this.StoreDeliveryZoneUpdatedEvent.GetHashCode();
                if (this.StoreOpeningHoursUpdatedEvent != null)
                    hashCode = hashCode * 59 + this.StoreOpeningHoursUpdatedEvent.GetHashCode();
                if (this.StoreUpdatedEvent != null)
                    hashCode = hashCode * 59 + this.StoreUpdatedEvent.GetHashCode();
                if (this.MenuCreatedEvent != null)
                    hashCode = hashCode * 59 + this.MenuCreatedEvent.GetHashCode();
                if (this.MenuUpdatedEvent != null)
                    hashCode = hashCode * 59 + this.MenuUpdatedEvent.GetHashCode();
                if (this.CustomerCreatedEvent != null)
                    hashCode = hashCode * 59 + this.CustomerCreatedEvent.GetHashCode();
                if (this.CustomerUpdatedEvent != null)
                    hashCode = hashCode * 59 + this.CustomerUpdatedEvent.GetHashCode();
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
