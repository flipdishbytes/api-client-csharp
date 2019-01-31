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
    /// Store Base
    /// </summary>
    [DataContract]
    public partial class StoreBase :  IEquatable<StoreBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreBase" /> class.
        /// </summary>
        /// <param name="phoneNumber">Phone number.</param>
        /// <param name="preOrderEnabled">True if the store accepts pre-orders.</param>
        /// <param name="takeOutEnabled">True if the store accepts take-out orders.</param>
        /// <param name="tableServiceEnabled">True if the store has table service.</param>
        /// <param name="dineInEnabled">True if the store accepts dine-in orders.</param>
        /// <param name="allowPreOrdersAndTableService">True if both pre-orders and talbe service can be enabled.</param>
        /// <param name="pickupEnabled">True if the store accepts pickup orders.</param>
        /// <param name="deliveryEnabled">True if the store accepts delivery orders.</param>
        /// <param name="cardOrderDeliveryEnabled">True if the store accepts card payment for delivery orders.</param>
        /// <param name="cashOrdersDeliveryEnabled">True if the store accepts cash payment for delivery orders.</param>
        /// <param name="cardOrdersPickupEnabled">True if the store accepts card payment for pickup orders.</param>
        /// <param name="cashOrdersPickupEnabled">True if the store accepts cash payment for pickup orders.</param>
        /// <param name="tipsEnabled">True if the store accepts tips.</param>
        /// <param name="automaticallyAcceptOrders">True if the stores orders are automatically accepted in Flipdish.</param>
        /// <param name="openForDelivery">True if the store is open for delivery.</param>
        /// <param name="openForPickup">True if the store is open for pickup.</param>
        /// <param name="minimumPickupOrderAmount">Minimum pickup order amount.</param>
        /// <param name="requireCustomerNameForPickup">True if customer name required for pickup orders.</param>
        /// <param name="gdprCustomerPhoneNumbers">Mask your customers phone numbers printed on receipts and reduce the amout of personally identifiable customer information that is exposed..</param>
        /// <param name="requireCustomerNameForDelivery">True if customer name required for delivery orders.</param>
        /// <param name="microsoftTimeZone">Microsoft Time Zone Index Values (https://msdn.microsoft.com/en-us/library/ms912391).</param>
        /// <param name="ianaTimeZone">IANA Time Zone (https://www.iana.org/time-zones).</param>
        /// <param name="etaInPickupConfirmationSmsEnabled">True if order confirmation sms includes estimated time when order will be ready for collection.</param>
        /// <param name="etaInDeliveryConfirmationSmsEnabled">True if order confirmation sms includes estimated time when order will delivered.</param>
        /// <param name="name">Name.</param>
        /// <param name="emailAddress">Email address (visible to customers).</param>
        /// <param name="staffLanguage">Staff Language (used for communcation with the staff)  Emails, Printouts etc.</param>
        public StoreBase(string phoneNumber = default(string), bool? preOrderEnabled = default(bool?), bool? takeOutEnabled = default(bool?), bool? tableServiceEnabled = default(bool?), bool? dineInEnabled = default(bool?), bool? allowPreOrdersAndTableService = default(bool?), bool? pickupEnabled = default(bool?), bool? deliveryEnabled = default(bool?), bool? cardOrderDeliveryEnabled = default(bool?), bool? cashOrdersDeliveryEnabled = default(bool?), bool? cardOrdersPickupEnabled = default(bool?), bool? cashOrdersPickupEnabled = default(bool?), bool? tipsEnabled = default(bool?), bool? automaticallyAcceptOrders = default(bool?), bool? openForDelivery = default(bool?), bool? openForPickup = default(bool?), double? minimumPickupOrderAmount = default(double?), bool? requireCustomerNameForPickup = default(bool?), bool? gdprCustomerPhoneNumbers = default(bool?), bool? requireCustomerNameForDelivery = default(bool?), string microsoftTimeZone = default(string), string ianaTimeZone = default(string), bool? etaInPickupConfirmationSmsEnabled = default(bool?), bool? etaInDeliveryConfirmationSmsEnabled = default(bool?), string name = default(string), string emailAddress = default(string), string staffLanguage = default(string))
        {
            this.PhoneNumber = phoneNumber;
            this.PreOrderEnabled = preOrderEnabled;
            this.TakeOutEnabled = takeOutEnabled;
            this.TableServiceEnabled = tableServiceEnabled;
            this.DineInEnabled = dineInEnabled;
            this.AllowPreOrdersAndTableService = allowPreOrdersAndTableService;
            this.PickupEnabled = pickupEnabled;
            this.DeliveryEnabled = deliveryEnabled;
            this.CardOrderDeliveryEnabled = cardOrderDeliveryEnabled;
            this.CashOrdersDeliveryEnabled = cashOrdersDeliveryEnabled;
            this.CardOrdersPickupEnabled = cardOrdersPickupEnabled;
            this.CashOrdersPickupEnabled = cashOrdersPickupEnabled;
            this.TipsEnabled = tipsEnabled;
            this.AutomaticallyAcceptOrders = automaticallyAcceptOrders;
            this.OpenForDelivery = openForDelivery;
            this.OpenForPickup = openForPickup;
            this.MinimumPickupOrderAmount = minimumPickupOrderAmount;
            this.RequireCustomerNameForPickup = requireCustomerNameForPickup;
            this.GdprCustomerPhoneNumbers = gdprCustomerPhoneNumbers;
            this.RequireCustomerNameForDelivery = requireCustomerNameForDelivery;
            this.MicrosoftTimeZone = microsoftTimeZone;
            this.IanaTimeZone = ianaTimeZone;
            this.EtaInPickupConfirmationSmsEnabled = etaInPickupConfirmationSmsEnabled;
            this.EtaInDeliveryConfirmationSmsEnabled = etaInDeliveryConfirmationSmsEnabled;
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.StaffLanguage = staffLanguage;
        }
        
        /// <summary>
        /// Phone number
        /// </summary>
        /// <value>Phone number</value>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// True if the store accepts pre-orders
        /// </summary>
        /// <value>True if the store accepts pre-orders</value>
        [DataMember(Name="PreOrderEnabled", EmitDefaultValue=false)]
        public bool? PreOrderEnabled { get; set; }

        /// <summary>
        /// True if the store accepts take-out orders
        /// </summary>
        /// <value>True if the store accepts take-out orders</value>
        [DataMember(Name="TakeOutEnabled", EmitDefaultValue=false)]
        public bool? TakeOutEnabled { get; set; }

        /// <summary>
        /// True if the store has table service
        /// </summary>
        /// <value>True if the store has table service</value>
        [DataMember(Name="TableServiceEnabled", EmitDefaultValue=false)]
        public bool? TableServiceEnabled { get; set; }

        /// <summary>
        /// True if the store accepts dine-in orders
        /// </summary>
        /// <value>True if the store accepts dine-in orders</value>
        [DataMember(Name="DineInEnabled", EmitDefaultValue=false)]
        public bool? DineInEnabled { get; set; }

        /// <summary>
        /// True if both pre-orders and talbe service can be enabled
        /// </summary>
        /// <value>True if both pre-orders and talbe service can be enabled</value>
        [DataMember(Name="AllowPreOrdersAndTableService", EmitDefaultValue=false)]
        public bool? AllowPreOrdersAndTableService { get; set; }

        /// <summary>
        /// True if the store accepts pickup orders
        /// </summary>
        /// <value>True if the store accepts pickup orders</value>
        [DataMember(Name="PickupEnabled", EmitDefaultValue=false)]
        public bool? PickupEnabled { get; set; }

        /// <summary>
        /// True if the store accepts delivery orders
        /// </summary>
        /// <value>True if the store accepts delivery orders</value>
        [DataMember(Name="DeliveryEnabled", EmitDefaultValue=false)]
        public bool? DeliveryEnabled { get; set; }

        /// <summary>
        /// True if the store accepts card payment for delivery orders
        /// </summary>
        /// <value>True if the store accepts card payment for delivery orders</value>
        [DataMember(Name="CardOrderDeliveryEnabled", EmitDefaultValue=false)]
        public bool? CardOrderDeliveryEnabled { get; set; }

        /// <summary>
        /// True if the store accepts cash payment for delivery orders
        /// </summary>
        /// <value>True if the store accepts cash payment for delivery orders</value>
        [DataMember(Name="CashOrdersDeliveryEnabled", EmitDefaultValue=false)]
        public bool? CashOrdersDeliveryEnabled { get; set; }

        /// <summary>
        /// True if the store accepts card payment for pickup orders
        /// </summary>
        /// <value>True if the store accepts card payment for pickup orders</value>
        [DataMember(Name="CardOrdersPickupEnabled", EmitDefaultValue=false)]
        public bool? CardOrdersPickupEnabled { get; set; }

        /// <summary>
        /// True if the store accepts cash payment for pickup orders
        /// </summary>
        /// <value>True if the store accepts cash payment for pickup orders</value>
        [DataMember(Name="CashOrdersPickupEnabled", EmitDefaultValue=false)]
        public bool? CashOrdersPickupEnabled { get; set; }

        /// <summary>
        /// True if the store accepts tips
        /// </summary>
        /// <value>True if the store accepts tips</value>
        [DataMember(Name="TipsEnabled", EmitDefaultValue=false)]
        public bool? TipsEnabled { get; set; }

        /// <summary>
        /// True if the stores orders are automatically accepted in Flipdish
        /// </summary>
        /// <value>True if the stores orders are automatically accepted in Flipdish</value>
        [DataMember(Name="AutomaticallyAcceptOrders", EmitDefaultValue=false)]
        public bool? AutomaticallyAcceptOrders { get; set; }

        /// <summary>
        /// True if the store is open for delivery
        /// </summary>
        /// <value>True if the store is open for delivery</value>
        [DataMember(Name="OpenForDelivery", EmitDefaultValue=false)]
        public bool? OpenForDelivery { get; set; }

        /// <summary>
        /// True if the store is open for pickup
        /// </summary>
        /// <value>True if the store is open for pickup</value>
        [DataMember(Name="OpenForPickup", EmitDefaultValue=false)]
        public bool? OpenForPickup { get; set; }

        /// <summary>
        /// Minimum pickup order amount
        /// </summary>
        /// <value>Minimum pickup order amount</value>
        [DataMember(Name="MinimumPickupOrderAmount", EmitDefaultValue=false)]
        public double? MinimumPickupOrderAmount { get; set; }

        /// <summary>
        /// True if customer name required for pickup orders
        /// </summary>
        /// <value>True if customer name required for pickup orders</value>
        [DataMember(Name="RequireCustomerNameForPickup", EmitDefaultValue=false)]
        public bool? RequireCustomerNameForPickup { get; set; }

        /// <summary>
        /// Mask your customers phone numbers printed on receipts and reduce the amout of personally identifiable customer information that is exposed.
        /// </summary>
        /// <value>Mask your customers phone numbers printed on receipts and reduce the amout of personally identifiable customer information that is exposed.</value>
        [DataMember(Name="GdprCustomerPhoneNumbers", EmitDefaultValue=false)]
        public bool? GdprCustomerPhoneNumbers { get; set; }

        /// <summary>
        /// True if customer name required for delivery orders
        /// </summary>
        /// <value>True if customer name required for delivery orders</value>
        [DataMember(Name="RequireCustomerNameForDelivery", EmitDefaultValue=false)]
        public bool? RequireCustomerNameForDelivery { get; set; }

        /// <summary>
        /// Microsoft Time Zone Index Values (https://msdn.microsoft.com/en-us/library/ms912391)
        /// </summary>
        /// <value>Microsoft Time Zone Index Values (https://msdn.microsoft.com/en-us/library/ms912391)</value>
        [DataMember(Name="MicrosoftTimeZone", EmitDefaultValue=false)]
        public string MicrosoftTimeZone { get; set; }

        /// <summary>
        /// IANA Time Zone (https://www.iana.org/time-zones)
        /// </summary>
        /// <value>IANA Time Zone (https://www.iana.org/time-zones)</value>
        [DataMember(Name="IanaTimeZone", EmitDefaultValue=false)]
        public string IanaTimeZone { get; set; }

        /// <summary>
        /// True if order confirmation sms includes estimated time when order will be ready for collection
        /// </summary>
        /// <value>True if order confirmation sms includes estimated time when order will be ready for collection</value>
        [DataMember(Name="EtaInPickupConfirmationSmsEnabled", EmitDefaultValue=false)]
        public bool? EtaInPickupConfirmationSmsEnabled { get; set; }

        /// <summary>
        /// True if order confirmation sms includes estimated time when order will delivered
        /// </summary>
        /// <value>True if order confirmation sms includes estimated time when order will delivered</value>
        [DataMember(Name="EtaInDeliveryConfirmationSmsEnabled", EmitDefaultValue=false)]
        public bool? EtaInDeliveryConfirmationSmsEnabled { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Email address (visible to customers)
        /// </summary>
        /// <value>Email address (visible to customers)</value>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Staff Language (used for communcation with the staff)  Emails, Printouts etc
        /// </summary>
        /// <value>Staff Language (used for communcation with the staff)  Emails, Printouts etc</value>
        [DataMember(Name="StaffLanguage", EmitDefaultValue=false)]
        public string StaffLanguage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreBase {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PreOrderEnabled: ").Append(PreOrderEnabled).Append("\n");
            sb.Append("  TakeOutEnabled: ").Append(TakeOutEnabled).Append("\n");
            sb.Append("  TableServiceEnabled: ").Append(TableServiceEnabled).Append("\n");
            sb.Append("  DineInEnabled: ").Append(DineInEnabled).Append("\n");
            sb.Append("  AllowPreOrdersAndTableService: ").Append(AllowPreOrdersAndTableService).Append("\n");
            sb.Append("  PickupEnabled: ").Append(PickupEnabled).Append("\n");
            sb.Append("  DeliveryEnabled: ").Append(DeliveryEnabled).Append("\n");
            sb.Append("  CardOrderDeliveryEnabled: ").Append(CardOrderDeliveryEnabled).Append("\n");
            sb.Append("  CashOrdersDeliveryEnabled: ").Append(CashOrdersDeliveryEnabled).Append("\n");
            sb.Append("  CardOrdersPickupEnabled: ").Append(CardOrdersPickupEnabled).Append("\n");
            sb.Append("  CashOrdersPickupEnabled: ").Append(CashOrdersPickupEnabled).Append("\n");
            sb.Append("  TipsEnabled: ").Append(TipsEnabled).Append("\n");
            sb.Append("  AutomaticallyAcceptOrders: ").Append(AutomaticallyAcceptOrders).Append("\n");
            sb.Append("  OpenForDelivery: ").Append(OpenForDelivery).Append("\n");
            sb.Append("  OpenForPickup: ").Append(OpenForPickup).Append("\n");
            sb.Append("  MinimumPickupOrderAmount: ").Append(MinimumPickupOrderAmount).Append("\n");
            sb.Append("  RequireCustomerNameForPickup: ").Append(RequireCustomerNameForPickup).Append("\n");
            sb.Append("  GdprCustomerPhoneNumbers: ").Append(GdprCustomerPhoneNumbers).Append("\n");
            sb.Append("  RequireCustomerNameForDelivery: ").Append(RequireCustomerNameForDelivery).Append("\n");
            sb.Append("  MicrosoftTimeZone: ").Append(MicrosoftTimeZone).Append("\n");
            sb.Append("  IanaTimeZone: ").Append(IanaTimeZone).Append("\n");
            sb.Append("  EtaInPickupConfirmationSmsEnabled: ").Append(EtaInPickupConfirmationSmsEnabled).Append("\n");
            sb.Append("  EtaInDeliveryConfirmationSmsEnabled: ").Append(EtaInDeliveryConfirmationSmsEnabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  StaffLanguage: ").Append(StaffLanguage).Append("\n");
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
            return this.Equals(input as StoreBase);
        }

        /// <summary>
        /// Returns true if StoreBase instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreBase input)
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
                    this.PreOrderEnabled == input.PreOrderEnabled ||
                    (this.PreOrderEnabled != null &&
                    this.PreOrderEnabled.Equals(input.PreOrderEnabled))
                ) && 
                (
                    this.TakeOutEnabled == input.TakeOutEnabled ||
                    (this.TakeOutEnabled != null &&
                    this.TakeOutEnabled.Equals(input.TakeOutEnabled))
                ) && 
                (
                    this.TableServiceEnabled == input.TableServiceEnabled ||
                    (this.TableServiceEnabled != null &&
                    this.TableServiceEnabled.Equals(input.TableServiceEnabled))
                ) && 
                (
                    this.DineInEnabled == input.DineInEnabled ||
                    (this.DineInEnabled != null &&
                    this.DineInEnabled.Equals(input.DineInEnabled))
                ) && 
                (
                    this.AllowPreOrdersAndTableService == input.AllowPreOrdersAndTableService ||
                    (this.AllowPreOrdersAndTableService != null &&
                    this.AllowPreOrdersAndTableService.Equals(input.AllowPreOrdersAndTableService))
                ) && 
                (
                    this.PickupEnabled == input.PickupEnabled ||
                    (this.PickupEnabled != null &&
                    this.PickupEnabled.Equals(input.PickupEnabled))
                ) && 
                (
                    this.DeliveryEnabled == input.DeliveryEnabled ||
                    (this.DeliveryEnabled != null &&
                    this.DeliveryEnabled.Equals(input.DeliveryEnabled))
                ) && 
                (
                    this.CardOrderDeliveryEnabled == input.CardOrderDeliveryEnabled ||
                    (this.CardOrderDeliveryEnabled != null &&
                    this.CardOrderDeliveryEnabled.Equals(input.CardOrderDeliveryEnabled))
                ) && 
                (
                    this.CashOrdersDeliveryEnabled == input.CashOrdersDeliveryEnabled ||
                    (this.CashOrdersDeliveryEnabled != null &&
                    this.CashOrdersDeliveryEnabled.Equals(input.CashOrdersDeliveryEnabled))
                ) && 
                (
                    this.CardOrdersPickupEnabled == input.CardOrdersPickupEnabled ||
                    (this.CardOrdersPickupEnabled != null &&
                    this.CardOrdersPickupEnabled.Equals(input.CardOrdersPickupEnabled))
                ) && 
                (
                    this.CashOrdersPickupEnabled == input.CashOrdersPickupEnabled ||
                    (this.CashOrdersPickupEnabled != null &&
                    this.CashOrdersPickupEnabled.Equals(input.CashOrdersPickupEnabled))
                ) && 
                (
                    this.TipsEnabled == input.TipsEnabled ||
                    (this.TipsEnabled != null &&
                    this.TipsEnabled.Equals(input.TipsEnabled))
                ) && 
                (
                    this.AutomaticallyAcceptOrders == input.AutomaticallyAcceptOrders ||
                    (this.AutomaticallyAcceptOrders != null &&
                    this.AutomaticallyAcceptOrders.Equals(input.AutomaticallyAcceptOrders))
                ) && 
                (
                    this.OpenForDelivery == input.OpenForDelivery ||
                    (this.OpenForDelivery != null &&
                    this.OpenForDelivery.Equals(input.OpenForDelivery))
                ) && 
                (
                    this.OpenForPickup == input.OpenForPickup ||
                    (this.OpenForPickup != null &&
                    this.OpenForPickup.Equals(input.OpenForPickup))
                ) && 
                (
                    this.MinimumPickupOrderAmount == input.MinimumPickupOrderAmount ||
                    (this.MinimumPickupOrderAmount != null &&
                    this.MinimumPickupOrderAmount.Equals(input.MinimumPickupOrderAmount))
                ) && 
                (
                    this.RequireCustomerNameForPickup == input.RequireCustomerNameForPickup ||
                    (this.RequireCustomerNameForPickup != null &&
                    this.RequireCustomerNameForPickup.Equals(input.RequireCustomerNameForPickup))
                ) && 
                (
                    this.GdprCustomerPhoneNumbers == input.GdprCustomerPhoneNumbers ||
                    (this.GdprCustomerPhoneNumbers != null &&
                    this.GdprCustomerPhoneNumbers.Equals(input.GdprCustomerPhoneNumbers))
                ) && 
                (
                    this.RequireCustomerNameForDelivery == input.RequireCustomerNameForDelivery ||
                    (this.RequireCustomerNameForDelivery != null &&
                    this.RequireCustomerNameForDelivery.Equals(input.RequireCustomerNameForDelivery))
                ) && 
                (
                    this.MicrosoftTimeZone == input.MicrosoftTimeZone ||
                    (this.MicrosoftTimeZone != null &&
                    this.MicrosoftTimeZone.Equals(input.MicrosoftTimeZone))
                ) && 
                (
                    this.IanaTimeZone == input.IanaTimeZone ||
                    (this.IanaTimeZone != null &&
                    this.IanaTimeZone.Equals(input.IanaTimeZone))
                ) && 
                (
                    this.EtaInPickupConfirmationSmsEnabled == input.EtaInPickupConfirmationSmsEnabled ||
                    (this.EtaInPickupConfirmationSmsEnabled != null &&
                    this.EtaInPickupConfirmationSmsEnabled.Equals(input.EtaInPickupConfirmationSmsEnabled))
                ) && 
                (
                    this.EtaInDeliveryConfirmationSmsEnabled == input.EtaInDeliveryConfirmationSmsEnabled ||
                    (this.EtaInDeliveryConfirmationSmsEnabled != null &&
                    this.EtaInDeliveryConfirmationSmsEnabled.Equals(input.EtaInDeliveryConfirmationSmsEnabled))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.StaffLanguage == input.StaffLanguage ||
                    (this.StaffLanguage != null &&
                    this.StaffLanguage.Equals(input.StaffLanguage))
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
                if (this.PreOrderEnabled != null)
                    hashCode = hashCode * 59 + this.PreOrderEnabled.GetHashCode();
                if (this.TakeOutEnabled != null)
                    hashCode = hashCode * 59 + this.TakeOutEnabled.GetHashCode();
                if (this.TableServiceEnabled != null)
                    hashCode = hashCode * 59 + this.TableServiceEnabled.GetHashCode();
                if (this.DineInEnabled != null)
                    hashCode = hashCode * 59 + this.DineInEnabled.GetHashCode();
                if (this.AllowPreOrdersAndTableService != null)
                    hashCode = hashCode * 59 + this.AllowPreOrdersAndTableService.GetHashCode();
                if (this.PickupEnabled != null)
                    hashCode = hashCode * 59 + this.PickupEnabled.GetHashCode();
                if (this.DeliveryEnabled != null)
                    hashCode = hashCode * 59 + this.DeliveryEnabled.GetHashCode();
                if (this.CardOrderDeliveryEnabled != null)
                    hashCode = hashCode * 59 + this.CardOrderDeliveryEnabled.GetHashCode();
                if (this.CashOrdersDeliveryEnabled != null)
                    hashCode = hashCode * 59 + this.CashOrdersDeliveryEnabled.GetHashCode();
                if (this.CardOrdersPickupEnabled != null)
                    hashCode = hashCode * 59 + this.CardOrdersPickupEnabled.GetHashCode();
                if (this.CashOrdersPickupEnabled != null)
                    hashCode = hashCode * 59 + this.CashOrdersPickupEnabled.GetHashCode();
                if (this.TipsEnabled != null)
                    hashCode = hashCode * 59 + this.TipsEnabled.GetHashCode();
                if (this.AutomaticallyAcceptOrders != null)
                    hashCode = hashCode * 59 + this.AutomaticallyAcceptOrders.GetHashCode();
                if (this.OpenForDelivery != null)
                    hashCode = hashCode * 59 + this.OpenForDelivery.GetHashCode();
                if (this.OpenForPickup != null)
                    hashCode = hashCode * 59 + this.OpenForPickup.GetHashCode();
                if (this.MinimumPickupOrderAmount != null)
                    hashCode = hashCode * 59 + this.MinimumPickupOrderAmount.GetHashCode();
                if (this.RequireCustomerNameForPickup != null)
                    hashCode = hashCode * 59 + this.RequireCustomerNameForPickup.GetHashCode();
                if (this.GdprCustomerPhoneNumbers != null)
                    hashCode = hashCode * 59 + this.GdprCustomerPhoneNumbers.GetHashCode();
                if (this.RequireCustomerNameForDelivery != null)
                    hashCode = hashCode * 59 + this.RequireCustomerNameForDelivery.GetHashCode();
                if (this.MicrosoftTimeZone != null)
                    hashCode = hashCode * 59 + this.MicrosoftTimeZone.GetHashCode();
                if (this.IanaTimeZone != null)
                    hashCode = hashCode * 59 + this.IanaTimeZone.GetHashCode();
                if (this.EtaInPickupConfirmationSmsEnabled != null)
                    hashCode = hashCode * 59 + this.EtaInPickupConfirmationSmsEnabled.GetHashCode();
                if (this.EtaInDeliveryConfirmationSmsEnabled != null)
                    hashCode = hashCode * 59 + this.EtaInDeliveryConfirmationSmsEnabled.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.StaffLanguage != null)
                    hashCode = hashCode * 59 + this.StaffLanguage.GetHashCode();
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
            // EmailAddress (string) maxLength
            if(this.EmailAddress != null && this.EmailAddress.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be less than 100.", new [] { "EmailAddress" });
            }

            // EmailAddress (string) minLength
            if(this.EmailAddress != null && this.EmailAddress.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be greater than 0.", new [] { "EmailAddress" });
            }

            yield break;
        }
    }

}
