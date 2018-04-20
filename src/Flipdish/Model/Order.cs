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
    /// Order
    /// </summary>
    [DataContract]
    public partial class Order :  IEquatable<Order>, IValidatableObject
    {
        /// <summary>
        /// Delivery type
        /// </summary>
        /// <value>Delivery type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryTypeEnum
        {
            
            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 1,
            
            /// <summary>
            /// Enum Pickup for value: Pickup
            /// </summary>
            [EnumMember(Value = "Pickup")]
            Pickup = 2
        }

        /// <summary>
        /// Delivery type
        /// </summary>
        /// <value>Delivery type</value>
        [DataMember(Name="deliveryType", EmitDefaultValue=false)]
        public DeliveryTypeEnum? DeliveryType { get; set; }
        /// <summary>
        /// Pickup location type
        /// </summary>
        /// <value>Pickup location type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PickupLocationTypeEnum
        {
            
            /// <summary>
            /// Enum TakeOut for value: TakeOut
            /// </summary>
            [EnumMember(Value = "TakeOut")]
            TakeOut = 1,
            
            /// <summary>
            /// Enum TableService for value: TableService
            /// </summary>
            [EnumMember(Value = "TableService")]
            TableService = 2,
            
            /// <summary>
            /// Enum DineIn for value: DineIn
            /// </summary>
            [EnumMember(Value = "DineIn")]
            DineIn = 3
        }

        /// <summary>
        /// Pickup location type
        /// </summary>
        /// <value>Pickup location type</value>
        [DataMember(Name="pickupLocationType", EmitDefaultValue=false)]
        public PickupLocationTypeEnum? PickupLocationType { get; set; }
        /// <summary>
        /// Payment account type
        /// </summary>
        /// <value>Payment account type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentAccountTypeEnum
        {
            
            /// <summary>
            /// Enum Card for value: Card
            /// </summary>
            [EnumMember(Value = "Card")]
            Card = 1,
            
            /// <summary>
            /// Enum Cash for value: Cash
            /// </summary>
            [EnumMember(Value = "Cash")]
            Cash = 2
        }

        /// <summary>
        /// Payment account type
        /// </summary>
        /// <value>Payment account type</value>
        [DataMember(Name="paymentAccountType", EmitDefaultValue=false)]
        public PaymentAccountTypeEnum? PaymentAccountType { get; set; }
        /// <summary>
        /// Order state
        /// </summary>
        /// <value>Order state</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderStateEnum
        {
            
            /// <summary>
            /// Enum Created for value: Created
            /// </summary>
            [EnumMember(Value = "Created")]
            Created = 1,
            
            /// <summary>
            /// Enum PlacedCanBeCancelled for value: PlacedCanBeCancelled
            /// </summary>
            [EnumMember(Value = "PlacedCanBeCancelled")]
            PlacedCanBeCancelled = 2,
            
            /// <summary>
            /// Enum ReadyToProcess for value: ReadyToProcess
            /// </summary>
            [EnumMember(Value = "ReadyToProcess")]
            ReadyToProcess = 3,
            
            /// <summary>
            /// Enum AcceptedByRestaurant for value: AcceptedByRestaurant
            /// </summary>
            [EnumMember(Value = "AcceptedByRestaurant")]
            AcceptedByRestaurant = 4,
            
            /// <summary>
            /// Enum Dispatched for value: Dispatched
            /// </summary>
            [EnumMember(Value = "Dispatched")]
            Dispatched = 5,
            
            /// <summary>
            /// Enum Delivered for value: Delivered
            /// </summary>
            [EnumMember(Value = "Delivered")]
            Delivered = 6,
            
            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled = 7,
            
            /// <summary>
            /// Enum ManualReview for value: ManualReview
            /// </summary>
            [EnumMember(Value = "ManualReview")]
            ManualReview = 8,
            
            /// <summary>
            /// Enum RejectedByStore for value: RejectedByStore
            /// </summary>
            [EnumMember(Value = "RejectedByStore")]
            RejectedByStore = 9,
            
            /// <summary>
            /// Enum RejectedByFlipdish for value: RejectedByFlipdish
            /// </summary>
            [EnumMember(Value = "RejectedByFlipdish")]
            RejectedByFlipdish = 10,
            
            /// <summary>
            /// Enum RejectedAutomatically for value: RejectedAutomatically
            /// </summary>
            [EnumMember(Value = "RejectedAutomatically")]
            RejectedAutomatically = 11,
            
            /// <summary>
            /// Enum RejectedAfterBeingAccepted for value: RejectedAfterBeingAccepted
            /// </summary>
            [EnumMember(Value = "RejectedAfterBeingAccepted")]
            RejectedAfterBeingAccepted = 12,
            
            /// <summary>
            /// Enum AcceptedAndRefunded for value: AcceptedAndRefunded
            /// </summary>
            [EnumMember(Value = "AcceptedAndRefunded")]
            AcceptedAndRefunded = 13
        }

        /// <summary>
        /// Order state
        /// </summary>
        /// <value>Order state</value>
        [DataMember(Name="orderState", EmitDefaultValue=false)]
        public OrderStateEnum? OrderState { get; set; }
        /// <summary>
        /// Used app type
        /// </summary>
        /// <value>Used app type</value>
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
            PwaIos = 10
        }

        /// <summary>
        /// Used app type
        /// </summary>
        /// <value>Used app type</value>
        [DataMember(Name="appType", EmitDefaultValue=false)]
        public AppTypeEnum? AppType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="Store">Store summary.</param>
        /// <param name="Customer">Customer summary.</param>
        /// <param name="Voucher">Voucher summary.</param>
        /// <param name="Fees">Fee summary.</param>
        /// <param name="OrderItems">Ordered items.</param>
        /// <param name="DeliveryLocation">Delivery location for delivery orders.</param>
        /// <param name="CustomerLocation">Customer location.</param>
        /// <param name="OrderId">Order identifier.</param>
        /// <param name="DeliveryType">Delivery type.</param>
        /// <param name="PickupLocationType">Pickup location type.</param>
        /// <param name="TipAmount">Tip amount.</param>
        /// <param name="DeliveryAmount">Delivery amount.</param>
        /// <param name="OrderItemsAmount">Ordered items amount.</param>
        /// <param name="Amount">This is the sum of the OrderItemsAmount, DeliveryAmount, TipAmount and Voucher.Amount (which is usually negative) and OnlineOrderingFee for cash orders.  It does not include the OnlineOrderingFee in the case of card orders as this fee is charged by Flipdish directly to the customer..</param>
        /// <param name="ProcessingFee">This contains the online ordering processing fee. For card payments this is charged directly to the customer and for cash orders it is paid by the customer to the store. It is tax inclusive..</param>
        /// <param name="PaymentAccountType">Payment account type.</param>
        /// <param name="PaymentAccountDescription">Payment account description (like Visa ****2371 or Apple Pay. or Cash).</param>
        /// <param name="OrderState">Order state.</param>
        /// <param name="IsPreOrder">Is pre-order.</param>
        /// <param name="PlacedTime">Order placed time.</param>
        /// <param name="RequestedForTime">Order requested for.</param>
        /// <param name="ChefNote">Chef note.</param>
        /// <param name="AppType">Used app type.</param>
        /// <param name="UserRating">User rating.</param>
        public Order(StoreSummary Store = default(StoreSummary), CustomerSummary Customer = default(CustomerSummary), VoucherSummary Voucher = default(VoucherSummary), FeeSummary Fees = default(FeeSummary), List<OrderItem> OrderItems = default(List<OrderItem>), DeliveryLocation DeliveryLocation = default(DeliveryLocation), Coordinates CustomerLocation = default(Coordinates), int? OrderId = default(int?), DeliveryTypeEnum? DeliveryType = default(DeliveryTypeEnum?), PickupLocationTypeEnum? PickupLocationType = default(PickupLocationTypeEnum?), double? TipAmount = default(double?), double? DeliveryAmount = default(double?), double? OrderItemsAmount = default(double?), double? Amount = default(double?), double? ProcessingFee = default(double?), PaymentAccountTypeEnum? PaymentAccountType = default(PaymentAccountTypeEnum?), string PaymentAccountDescription = default(string), OrderStateEnum? OrderState = default(OrderStateEnum?), bool? IsPreOrder = default(bool?), DateTime? PlacedTime = default(DateTime?), DateTime? RequestedForTime = default(DateTime?), string ChefNote = default(string), AppTypeEnum? AppType = default(AppTypeEnum?), int? UserRating = default(int?))
        {
            this.Store = Store;
            this.Customer = Customer;
            this.Voucher = Voucher;
            this.Fees = Fees;
            this.OrderItems = OrderItems;
            this.DeliveryLocation = DeliveryLocation;
            this.CustomerLocation = CustomerLocation;
            this.OrderId = OrderId;
            this.DeliveryType = DeliveryType;
            this.PickupLocationType = PickupLocationType;
            this.TipAmount = TipAmount;
            this.DeliveryAmount = DeliveryAmount;
            this.OrderItemsAmount = OrderItemsAmount;
            this.Amount = Amount;
            this.ProcessingFee = ProcessingFee;
            this.PaymentAccountType = PaymentAccountType;
            this.PaymentAccountDescription = PaymentAccountDescription;
            this.OrderState = OrderState;
            this.IsPreOrder = IsPreOrder;
            this.PlacedTime = PlacedTime;
            this.RequestedForTime = RequestedForTime;
            this.ChefNote = ChefNote;
            this.AppType = AppType;
            this.UserRating = UserRating;
        }
        
        /// <summary>
        /// Store summary
        /// </summary>
        /// <value>Store summary</value>
        [DataMember(Name="store", EmitDefaultValue=false)]
        public StoreSummary Store { get; set; }

        /// <summary>
        /// Customer summary
        /// </summary>
        /// <value>Customer summary</value>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public CustomerSummary Customer { get; set; }

        /// <summary>
        /// Voucher summary
        /// </summary>
        /// <value>Voucher summary</value>
        [DataMember(Name="voucher", EmitDefaultValue=false)]
        public VoucherSummary Voucher { get; set; }

        /// <summary>
        /// Fee summary
        /// </summary>
        /// <value>Fee summary</value>
        [DataMember(Name="fees", EmitDefaultValue=false)]
        public FeeSummary Fees { get; set; }

        /// <summary>
        /// Ordered items
        /// </summary>
        /// <value>Ordered items</value>
        [DataMember(Name="orderItems", EmitDefaultValue=false)]
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// Delivery location for delivery orders
        /// </summary>
        /// <value>Delivery location for delivery orders</value>
        [DataMember(Name="deliveryLocation", EmitDefaultValue=false)]
        public DeliveryLocation DeliveryLocation { get; set; }

        /// <summary>
        /// Customer location
        /// </summary>
        /// <value>Customer location</value>
        [DataMember(Name="customerLocation", EmitDefaultValue=false)]
        public Coordinates CustomerLocation { get; set; }

        /// <summary>
        /// Order identifier
        /// </summary>
        /// <value>Order identifier</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public int? OrderId { get; set; }



        /// <summary>
        /// Tip amount
        /// </summary>
        /// <value>Tip amount</value>
        [DataMember(Name="tipAmount", EmitDefaultValue=false)]
        public double? TipAmount { get; set; }

        /// <summary>
        /// Delivery amount
        /// </summary>
        /// <value>Delivery amount</value>
        [DataMember(Name="deliveryAmount", EmitDefaultValue=false)]
        public double? DeliveryAmount { get; set; }

        /// <summary>
        /// Ordered items amount
        /// </summary>
        /// <value>Ordered items amount</value>
        [DataMember(Name="orderItemsAmount", EmitDefaultValue=false)]
        public double? OrderItemsAmount { get; set; }

        /// <summary>
        /// This is the sum of the OrderItemsAmount, DeliveryAmount, TipAmount and Voucher.Amount (which is usually negative) and OnlineOrderingFee for cash orders.  It does not include the OnlineOrderingFee in the case of card orders as this fee is charged by Flipdish directly to the customer.
        /// </summary>
        /// <value>This is the sum of the OrderItemsAmount, DeliveryAmount, TipAmount and Voucher.Amount (which is usually negative) and OnlineOrderingFee for cash orders.  It does not include the OnlineOrderingFee in the case of card orders as this fee is charged by Flipdish directly to the customer.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// This contains the online ordering processing fee. For card payments this is charged directly to the customer and for cash orders it is paid by the customer to the store. It is tax inclusive.
        /// </summary>
        /// <value>This contains the online ordering processing fee. For card payments this is charged directly to the customer and for cash orders it is paid by the customer to the store. It is tax inclusive.</value>
        [DataMember(Name="processingFee", EmitDefaultValue=false)]
        public double? ProcessingFee { get; set; }


        /// <summary>
        /// Payment account description (like Visa ****2371 or Apple Pay. or Cash)
        /// </summary>
        /// <value>Payment account description (like Visa ****2371 or Apple Pay. or Cash)</value>
        [DataMember(Name="paymentAccountDescription", EmitDefaultValue=false)]
        public string PaymentAccountDescription { get; set; }


        /// <summary>
        /// Is pre-order
        /// </summary>
        /// <value>Is pre-order</value>
        [DataMember(Name="isPreOrder", EmitDefaultValue=false)]
        public bool? IsPreOrder { get; set; }

        /// <summary>
        /// Order placed time
        /// </summary>
        /// <value>Order placed time</value>
        [DataMember(Name="placedTime", EmitDefaultValue=false)]
        public DateTime? PlacedTime { get; set; }

        /// <summary>
        /// Order requested for
        /// </summary>
        /// <value>Order requested for</value>
        [DataMember(Name="requestedForTime", EmitDefaultValue=false)]
        public DateTime? RequestedForTime { get; set; }

        /// <summary>
        /// Chef note
        /// </summary>
        /// <value>Chef note</value>
        [DataMember(Name="chefNote", EmitDefaultValue=false)]
        public string ChefNote { get; set; }


        /// <summary>
        /// User rating
        /// </summary>
        /// <value>User rating</value>
        [DataMember(Name="userRating", EmitDefaultValue=false)]
        public int? UserRating { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Voucher: ").Append(Voucher).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  OrderItems: ").Append(OrderItems).Append("\n");
            sb.Append("  DeliveryLocation: ").Append(DeliveryLocation).Append("\n");
            sb.Append("  CustomerLocation: ").Append(CustomerLocation).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  DeliveryType: ").Append(DeliveryType).Append("\n");
            sb.Append("  PickupLocationType: ").Append(PickupLocationType).Append("\n");
            sb.Append("  TipAmount: ").Append(TipAmount).Append("\n");
            sb.Append("  DeliveryAmount: ").Append(DeliveryAmount).Append("\n");
            sb.Append("  OrderItemsAmount: ").Append(OrderItemsAmount).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ProcessingFee: ").Append(ProcessingFee).Append("\n");
            sb.Append("  PaymentAccountType: ").Append(PaymentAccountType).Append("\n");
            sb.Append("  PaymentAccountDescription: ").Append(PaymentAccountDescription).Append("\n");
            sb.Append("  OrderState: ").Append(OrderState).Append("\n");
            sb.Append("  IsPreOrder: ").Append(IsPreOrder).Append("\n");
            sb.Append("  PlacedTime: ").Append(PlacedTime).Append("\n");
            sb.Append("  RequestedForTime: ").Append(RequestedForTime).Append("\n");
            sb.Append("  ChefNote: ").Append(ChefNote).Append("\n");
            sb.Append("  AppType: ").Append(AppType).Append("\n");
            sb.Append("  UserRating: ").Append(UserRating).Append("\n");
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
            return this.Equals(input as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="input">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.Voucher == input.Voucher ||
                    (this.Voucher != null &&
                    this.Voucher.Equals(input.Voucher))
                ) && 
                (
                    this.Fees == input.Fees ||
                    (this.Fees != null &&
                    this.Fees.Equals(input.Fees))
                ) && 
                (
                    this.OrderItems == input.OrderItems ||
                    this.OrderItems != null &&
                    this.OrderItems.SequenceEqual(input.OrderItems)
                ) && 
                (
                    this.DeliveryLocation == input.DeliveryLocation ||
                    (this.DeliveryLocation != null &&
                    this.DeliveryLocation.Equals(input.DeliveryLocation))
                ) && 
                (
                    this.CustomerLocation == input.CustomerLocation ||
                    (this.CustomerLocation != null &&
                    this.CustomerLocation.Equals(input.CustomerLocation))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.DeliveryType == input.DeliveryType ||
                    (this.DeliveryType != null &&
                    this.DeliveryType.Equals(input.DeliveryType))
                ) && 
                (
                    this.PickupLocationType == input.PickupLocationType ||
                    (this.PickupLocationType != null &&
                    this.PickupLocationType.Equals(input.PickupLocationType))
                ) && 
                (
                    this.TipAmount == input.TipAmount ||
                    (this.TipAmount != null &&
                    this.TipAmount.Equals(input.TipAmount))
                ) && 
                (
                    this.DeliveryAmount == input.DeliveryAmount ||
                    (this.DeliveryAmount != null &&
                    this.DeliveryAmount.Equals(input.DeliveryAmount))
                ) && 
                (
                    this.OrderItemsAmount == input.OrderItemsAmount ||
                    (this.OrderItemsAmount != null &&
                    this.OrderItemsAmount.Equals(input.OrderItemsAmount))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ProcessingFee == input.ProcessingFee ||
                    (this.ProcessingFee != null &&
                    this.ProcessingFee.Equals(input.ProcessingFee))
                ) && 
                (
                    this.PaymentAccountType == input.PaymentAccountType ||
                    (this.PaymentAccountType != null &&
                    this.PaymentAccountType.Equals(input.PaymentAccountType))
                ) && 
                (
                    this.PaymentAccountDescription == input.PaymentAccountDescription ||
                    (this.PaymentAccountDescription != null &&
                    this.PaymentAccountDescription.Equals(input.PaymentAccountDescription))
                ) && 
                (
                    this.OrderState == input.OrderState ||
                    (this.OrderState != null &&
                    this.OrderState.Equals(input.OrderState))
                ) && 
                (
                    this.IsPreOrder == input.IsPreOrder ||
                    (this.IsPreOrder != null &&
                    this.IsPreOrder.Equals(input.IsPreOrder))
                ) && 
                (
                    this.PlacedTime == input.PlacedTime ||
                    (this.PlacedTime != null &&
                    this.PlacedTime.Equals(input.PlacedTime))
                ) && 
                (
                    this.RequestedForTime == input.RequestedForTime ||
                    (this.RequestedForTime != null &&
                    this.RequestedForTime.Equals(input.RequestedForTime))
                ) && 
                (
                    this.ChefNote == input.ChefNote ||
                    (this.ChefNote != null &&
                    this.ChefNote.Equals(input.ChefNote))
                ) && 
                (
                    this.AppType == input.AppType ||
                    (this.AppType != null &&
                    this.AppType.Equals(input.AppType))
                ) && 
                (
                    this.UserRating == input.UserRating ||
                    (this.UserRating != null &&
                    this.UserRating.Equals(input.UserRating))
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
                if (this.Store != null)
                    hashCode = hashCode * 59 + this.Store.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Voucher != null)
                    hashCode = hashCode * 59 + this.Voucher.GetHashCode();
                if (this.Fees != null)
                    hashCode = hashCode * 59 + this.Fees.GetHashCode();
                if (this.OrderItems != null)
                    hashCode = hashCode * 59 + this.OrderItems.GetHashCode();
                if (this.DeliveryLocation != null)
                    hashCode = hashCode * 59 + this.DeliveryLocation.GetHashCode();
                if (this.CustomerLocation != null)
                    hashCode = hashCode * 59 + this.CustomerLocation.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.DeliveryType != null)
                    hashCode = hashCode * 59 + this.DeliveryType.GetHashCode();
                if (this.PickupLocationType != null)
                    hashCode = hashCode * 59 + this.PickupLocationType.GetHashCode();
                if (this.TipAmount != null)
                    hashCode = hashCode * 59 + this.TipAmount.GetHashCode();
                if (this.DeliveryAmount != null)
                    hashCode = hashCode * 59 + this.DeliveryAmount.GetHashCode();
                if (this.OrderItemsAmount != null)
                    hashCode = hashCode * 59 + this.OrderItemsAmount.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ProcessingFee != null)
                    hashCode = hashCode * 59 + this.ProcessingFee.GetHashCode();
                if (this.PaymentAccountType != null)
                    hashCode = hashCode * 59 + this.PaymentAccountType.GetHashCode();
                if (this.PaymentAccountDescription != null)
                    hashCode = hashCode * 59 + this.PaymentAccountDescription.GetHashCode();
                if (this.OrderState != null)
                    hashCode = hashCode * 59 + this.OrderState.GetHashCode();
                if (this.IsPreOrder != null)
                    hashCode = hashCode * 59 + this.IsPreOrder.GetHashCode();
                if (this.PlacedTime != null)
                    hashCode = hashCode * 59 + this.PlacedTime.GetHashCode();
                if (this.RequestedForTime != null)
                    hashCode = hashCode * 59 + this.RequestedForTime.GetHashCode();
                if (this.ChefNote != null)
                    hashCode = hashCode * 59 + this.ChefNote.GetHashCode();
                if (this.AppType != null)
                    hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.UserRating != null)
                    hashCode = hashCode * 59 + this.UserRating.GetHashCode();
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
