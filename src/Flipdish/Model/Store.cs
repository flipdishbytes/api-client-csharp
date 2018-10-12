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
    /// Store
    /// </summary>
    [DataContract]
    public partial class Store :  IEquatable<Store>, IValidatableObject
    {
        /// <summary>
        /// Printout layout
        /// </summary>
        /// <value>Printout layout</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrintoutLayoutTypeEnum
        {
            
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,
            
            /// <summary>
            /// Enum Centra for value: Centra
            /// </summary>
            [EnumMember(Value = "Centra")]
            Centra = 2
        }

        /// <summary>
        /// Printout layout
        /// </summary>
        /// <value>Printout layout</value>
        [DataMember(Name="PrintoutLayoutType", EmitDefaultValue=false)]
        public PrintoutLayoutTypeEnum? PrintoutLayoutType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Store" /> class.
        /// </summary>
        /// <param name="StoreId">Store identifier.</param>
        /// <param name="Address">Store address.</param>
        /// <param name="DeliveryFeeAreas">Delivery fee areas.</param>
        /// <param name="ApmPhoneNumber">Automated Phone Marketing number.</param>
        /// <param name="PickupHours">Pickup hours.</param>
        /// <param name="DeliveryHours">Delivery hours.</param>
        /// <param name="MenuId">Menu identifier.</param>
        /// <param name="OrderConfirmationMessageOverrideDelivery">Overridden confirmation message for delivery orders.</param>
        /// <param name="OrderConfirmationMessageOverridePickup">Overridden confirmation message for pickup orders.</param>
        /// <param name="PrintoutLayoutType">Printout layout.</param>
        /// <param name="StoreNotes">Store notes.</param>
        /// <param name="PhoneNumber">Phone number.</param>
        /// <param name="PreOrderEnabled">True if the store accepts pre-orders.</param>
        /// <param name="TakeOutEnabled">True if the store accepts take-out orders.</param>
        /// <param name="TableServiceEnabled">True if the store has table service.</param>
        /// <param name="DineInEnabled">True if the store accepts dine-in orders.</param>
        /// <param name="AllowPreOrdersAndTableService">True if both pre-orders and talbe service can be enabled.</param>
        /// <param name="PickupEnabled">True if the store accepts pickup orders.</param>
        /// <param name="DeliveryEnabled">True if the store accepts delivery orders.</param>
        /// <param name="CardOrderDeliveryEnabled">True if the store accepts card payment for delivery orders.</param>
        /// <param name="CashOrdersDeliveryEnabled">True if the store accepts cash payment for delivery orders.</param>
        /// <param name="CardOrdersPickupEnabled">True if the store accepts card payment for pickup orders.</param>
        /// <param name="CashOrdersPickupEnabled">True if the store accepts cash payment for pickup orders.</param>
        /// <param name="TipsEnabled">True if the store accepts tips.</param>
        /// <param name="AutomaticallyAcceptOrders">True if the stores orders are automatically accepted in Flipdish.</param>
        /// <param name="OpenForDelivery">True if the store is open for delivery.</param>
        /// <param name="OpenForPickup">True if the store is open for pickup.</param>
        /// <param name="MinimumPickupOrderAmount">Minimum pickup order amount.</param>
        /// <param name="RequireCustomerNameForPickup">True if customer name required for pickup orders.</param>
        /// <param name="RequireCustomerNameForDelivery">True if customer name required for delivery orders.</param>
        /// <param name="MicrosoftTimeZone">Microsoft Time Zone Index Values (https://msdn.microsoft.com/en-us/library/ms912391).</param>
        /// <param name="IanaTimeZone">IANA Time Zone (https://www.iana.org/time-zones).</param>
        /// <param name="Name">Name.</param>
        /// <param name="EmailAddress">Email address (visible to customers).</param>
        /// <param name="StaffLanguage">Staff Language (used for communcation with the staff)  Emails, Printouts etc.</param>
        public Store(int? StoreId = default(int?), StoreAddress Address = default(StoreAddress), List<DeliveryFeeArea> DeliveryFeeAreas = default(List<DeliveryFeeArea>), string ApmPhoneNumber = default(string), List<BusinessHoursPeriod> PickupHours = default(List<BusinessHoursPeriod>), List<BusinessHoursPeriod> DeliveryHours = default(List<BusinessHoursPeriod>), int? MenuId = default(int?), string OrderConfirmationMessageOverrideDelivery = default(string), string OrderConfirmationMessageOverridePickup = default(string), PrintoutLayoutTypeEnum? PrintoutLayoutType = default(PrintoutLayoutTypeEnum?), List<StoreNote> StoreNotes = default(List<StoreNote>), string PhoneNumber = default(string), bool? PreOrderEnabled = default(bool?), bool? TakeOutEnabled = default(bool?), bool? TableServiceEnabled = default(bool?), bool? DineInEnabled = default(bool?), bool? AllowPreOrdersAndTableService = default(bool?), bool? PickupEnabled = default(bool?), bool? DeliveryEnabled = default(bool?), bool? CardOrderDeliveryEnabled = default(bool?), bool? CashOrdersDeliveryEnabled = default(bool?), bool? CardOrdersPickupEnabled = default(bool?), bool? CashOrdersPickupEnabled = default(bool?), bool? TipsEnabled = default(bool?), bool? AutomaticallyAcceptOrders = default(bool?), bool? OpenForDelivery = default(bool?), bool? OpenForPickup = default(bool?), double? MinimumPickupOrderAmount = default(double?), bool? RequireCustomerNameForPickup = default(bool?), bool? RequireCustomerNameForDelivery = default(bool?), string MicrosoftTimeZone = default(string), string IanaTimeZone = default(string), string Name = default(string), string EmailAddress = default(string), string StaffLanguage = default(string))
        {
            this.StoreId = StoreId;
            this.Address = Address;
            this.DeliveryFeeAreas = DeliveryFeeAreas;
            this.ApmPhoneNumber = ApmPhoneNumber;
            this.PickupHours = PickupHours;
            this.DeliveryHours = DeliveryHours;
            this.MenuId = MenuId;
            this.OrderConfirmationMessageOverrideDelivery = OrderConfirmationMessageOverrideDelivery;
            this.OrderConfirmationMessageOverridePickup = OrderConfirmationMessageOverridePickup;
            this.PrintoutLayoutType = PrintoutLayoutType;
            this.StoreNotes = StoreNotes;
            this.PhoneNumber = PhoneNumber;
            this.PreOrderEnabled = PreOrderEnabled;
            this.TakeOutEnabled = TakeOutEnabled;
            this.TableServiceEnabled = TableServiceEnabled;
            this.DineInEnabled = DineInEnabled;
            this.AllowPreOrdersAndTableService = AllowPreOrdersAndTableService;
            this.PickupEnabled = PickupEnabled;
            this.DeliveryEnabled = DeliveryEnabled;
            this.CardOrderDeliveryEnabled = CardOrderDeliveryEnabled;
            this.CashOrdersDeliveryEnabled = CashOrdersDeliveryEnabled;
            this.CardOrdersPickupEnabled = CardOrdersPickupEnabled;
            this.CashOrdersPickupEnabled = CashOrdersPickupEnabled;
            this.TipsEnabled = TipsEnabled;
            this.AutomaticallyAcceptOrders = AutomaticallyAcceptOrders;
            this.OpenForDelivery = OpenForDelivery;
            this.OpenForPickup = OpenForPickup;
            this.MinimumPickupOrderAmount = MinimumPickupOrderAmount;
            this.RequireCustomerNameForPickup = RequireCustomerNameForPickup;
            this.RequireCustomerNameForDelivery = RequireCustomerNameForDelivery;
            this.MicrosoftTimeZone = MicrosoftTimeZone;
            this.IanaTimeZone = IanaTimeZone;
            this.Name = Name;
            this.EmailAddress = EmailAddress;
            this.StaffLanguage = StaffLanguage;
        }
        
        /// <summary>
        /// Store identifier
        /// </summary>
        /// <value>Store identifier</value>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public int? StoreId { get; set; }

        /// <summary>
        /// Store address
        /// </summary>
        /// <value>Store address</value>
        [DataMember(Name="Address", EmitDefaultValue=false)]
        public StoreAddress Address { get; set; }

        /// <summary>
        /// Delivery fee areas
        /// </summary>
        /// <value>Delivery fee areas</value>
        [DataMember(Name="DeliveryFeeAreas", EmitDefaultValue=false)]
        public List<DeliveryFeeArea> DeliveryFeeAreas { get; set; }

        /// <summary>
        /// Automated Phone Marketing number
        /// </summary>
        /// <value>Automated Phone Marketing number</value>
        [DataMember(Name="ApmPhoneNumber", EmitDefaultValue=false)]
        public string ApmPhoneNumber { get; set; }

        /// <summary>
        /// Pickup hours
        /// </summary>
        /// <value>Pickup hours</value>
        [DataMember(Name="PickupHours", EmitDefaultValue=false)]
        public List<BusinessHoursPeriod> PickupHours { get; set; }

        /// <summary>
        /// Delivery hours
        /// </summary>
        /// <value>Delivery hours</value>
        [DataMember(Name="DeliveryHours", EmitDefaultValue=false)]
        public List<BusinessHoursPeriod> DeliveryHours { get; set; }

        /// <summary>
        /// Menu identifier
        /// </summary>
        /// <value>Menu identifier</value>
        [DataMember(Name="MenuId", EmitDefaultValue=false)]
        public int? MenuId { get; set; }

        /// <summary>
        /// Overridden confirmation message for delivery orders
        /// </summary>
        /// <value>Overridden confirmation message for delivery orders</value>
        [DataMember(Name="OrderConfirmationMessageOverrideDelivery", EmitDefaultValue=false)]
        public string OrderConfirmationMessageOverrideDelivery { get; set; }

        /// <summary>
        /// Overridden confirmation message for pickup orders
        /// </summary>
        /// <value>Overridden confirmation message for pickup orders</value>
        [DataMember(Name="OrderConfirmationMessageOverridePickup", EmitDefaultValue=false)]
        public string OrderConfirmationMessageOverridePickup { get; set; }


        /// <summary>
        /// Store notes
        /// </summary>
        /// <value>Store notes</value>
        [DataMember(Name="StoreNotes", EmitDefaultValue=false)]
        public List<StoreNote> StoreNotes { get; set; }

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
            sb.Append("class Store {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  DeliveryFeeAreas: ").Append(DeliveryFeeAreas).Append("\n");
            sb.Append("  ApmPhoneNumber: ").Append(ApmPhoneNumber).Append("\n");
            sb.Append("  PickupHours: ").Append(PickupHours).Append("\n");
            sb.Append("  DeliveryHours: ").Append(DeliveryHours).Append("\n");
            sb.Append("  MenuId: ").Append(MenuId).Append("\n");
            sb.Append("  OrderConfirmationMessageOverrideDelivery: ").Append(OrderConfirmationMessageOverrideDelivery).Append("\n");
            sb.Append("  OrderConfirmationMessageOverridePickup: ").Append(OrderConfirmationMessageOverridePickup).Append("\n");
            sb.Append("  PrintoutLayoutType: ").Append(PrintoutLayoutType).Append("\n");
            sb.Append("  StoreNotes: ").Append(StoreNotes).Append("\n");
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
            sb.Append("  RequireCustomerNameForDelivery: ").Append(RequireCustomerNameForDelivery).Append("\n");
            sb.Append("  MicrosoftTimeZone: ").Append(MicrosoftTimeZone).Append("\n");
            sb.Append("  IanaTimeZone: ").Append(IanaTimeZone).Append("\n");
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
            return this.Equals(input as Store);
        }

        /// <summary>
        /// Returns true if Store instances are equal
        /// </summary>
        /// <param name="input">Instance of Store to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Store input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.DeliveryFeeAreas == input.DeliveryFeeAreas ||
                    this.DeliveryFeeAreas != null &&
                    this.DeliveryFeeAreas.SequenceEqual(input.DeliveryFeeAreas)
                ) && 
                (
                    this.ApmPhoneNumber == input.ApmPhoneNumber ||
                    (this.ApmPhoneNumber != null &&
                    this.ApmPhoneNumber.Equals(input.ApmPhoneNumber))
                ) && 
                (
                    this.PickupHours == input.PickupHours ||
                    this.PickupHours != null &&
                    this.PickupHours.SequenceEqual(input.PickupHours)
                ) && 
                (
                    this.DeliveryHours == input.DeliveryHours ||
                    this.DeliveryHours != null &&
                    this.DeliveryHours.SequenceEqual(input.DeliveryHours)
                ) && 
                (
                    this.MenuId == input.MenuId ||
                    (this.MenuId != null &&
                    this.MenuId.Equals(input.MenuId))
                ) && 
                (
                    this.OrderConfirmationMessageOverrideDelivery == input.OrderConfirmationMessageOverrideDelivery ||
                    (this.OrderConfirmationMessageOverrideDelivery != null &&
                    this.OrderConfirmationMessageOverrideDelivery.Equals(input.OrderConfirmationMessageOverrideDelivery))
                ) && 
                (
                    this.OrderConfirmationMessageOverridePickup == input.OrderConfirmationMessageOverridePickup ||
                    (this.OrderConfirmationMessageOverridePickup != null &&
                    this.OrderConfirmationMessageOverridePickup.Equals(input.OrderConfirmationMessageOverridePickup))
                ) && 
                (
                    this.PrintoutLayoutType == input.PrintoutLayoutType ||
                    (this.PrintoutLayoutType != null &&
                    this.PrintoutLayoutType.Equals(input.PrintoutLayoutType))
                ) && 
                (
                    this.StoreNotes == input.StoreNotes ||
                    this.StoreNotes != null &&
                    this.StoreNotes.SequenceEqual(input.StoreNotes)
                ) && 
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.DeliveryFeeAreas != null)
                    hashCode = hashCode * 59 + this.DeliveryFeeAreas.GetHashCode();
                if (this.ApmPhoneNumber != null)
                    hashCode = hashCode * 59 + this.ApmPhoneNumber.GetHashCode();
                if (this.PickupHours != null)
                    hashCode = hashCode * 59 + this.PickupHours.GetHashCode();
                if (this.DeliveryHours != null)
                    hashCode = hashCode * 59 + this.DeliveryHours.GetHashCode();
                if (this.MenuId != null)
                    hashCode = hashCode * 59 + this.MenuId.GetHashCode();
                if (this.OrderConfirmationMessageOverrideDelivery != null)
                    hashCode = hashCode * 59 + this.OrderConfirmationMessageOverrideDelivery.GetHashCode();
                if (this.OrderConfirmationMessageOverridePickup != null)
                    hashCode = hashCode * 59 + this.OrderConfirmationMessageOverridePickup.GetHashCode();
                if (this.PrintoutLayoutType != null)
                    hashCode = hashCode * 59 + this.PrintoutLayoutType.GetHashCode();
                if (this.StoreNotes != null)
                    hashCode = hashCode * 59 + this.StoreNotes.GetHashCode();
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
                if (this.RequireCustomerNameForDelivery != null)
                    hashCode = hashCode * 59 + this.RequireCustomerNameForDelivery.GetHashCode();
                if (this.MicrosoftTimeZone != null)
                    hashCode = hashCode * 59 + this.MicrosoftTimeZone.GetHashCode();
                if (this.IanaTimeZone != null)
                    hashCode = hashCode * 59 + this.IanaTimeZone.GetHashCode();
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
