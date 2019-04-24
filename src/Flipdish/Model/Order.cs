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
        [DataMember(Name="DeliveryType", EmitDefaultValue=false)]
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
        [DataMember(Name="PickupLocationType", EmitDefaultValue=false)]
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
            Cash = 2,
            
            /// <summary>
            /// Enum Ideal for value: Ideal
            /// </summary>
            [EnumMember(Value = "Ideal")]
            Ideal = 3,
            
            /// <summary>
            /// Enum Bancontact for value: Bancontact
            /// </summary>
            [EnumMember(Value = "Bancontact")]
            Bancontact = 4,
            
            /// <summary>
            /// Enum Giropay for value: Giropay
            /// </summary>
            [EnumMember(Value = "Giropay")]
            Giropay = 5,
            
            /// <summary>
            /// Enum Eps for value: Eps
            /// </summary>
            [EnumMember(Value = "Eps")]
            Eps = 6
        }

        /// <summary>
        /// Payment account type
        /// </summary>
        /// <value>Payment account type</value>
        [DataMember(Name="PaymentAccountType", EmitDefaultValue=false)]
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
        [DataMember(Name="OrderState", EmitDefaultValue=false)]
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
        [DataMember(Name="AppType", EmitDefaultValue=false)]
        public AppTypeEnum? AppType { get; set; }
        /// <summary>
        /// Status of the payment
        /// </summary>
        /// <value>Status of the payment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentStatusEnum
        {
            
            /// <summary>
            /// Enum Paid for value: Paid
            /// </summary>
            [EnumMember(Value = "Paid")]
            Paid = 1,
            
            /// <summary>
            /// Enum Unpaid for value: Unpaid
            /// </summary>
            [EnumMember(Value = "Unpaid")]
            Unpaid = 2,
            
            /// <summary>
            /// Enum Refunded for value: Refunded
            /// </summary>
            [EnumMember(Value = "Refunded")]
            Refunded = 3,
            
            /// <summary>
            /// Enum PartiallyRefunded for value: PartiallyRefunded
            /// </summary>
            [EnumMember(Value = "PartiallyRefunded")]
            PartiallyRefunded = 4,
            
            /// <summary>
            /// Enum Disputed for value: Disputed
            /// </summary>
            [EnumMember(Value = "Disputed")]
            Disputed = 5
        }

        /// <summary>
        /// Status of the payment
        /// </summary>
        /// <value>Status of the payment</value>
        [DataMember(Name="PaymentStatus", EmitDefaultValue=false)]
        public PaymentStatusEnum? PaymentStatus { get; set; }
        /// <summary>
        /// Rejection reason. Can have value if the order is rejected.
        /// </summary>
        /// <value>Rejection reason. Can have value if the order is rejected.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RejectionReasonEnum
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
        /// Rejection reason. Can have value if the order is rejected.
        /// </summary>
        /// <value>Rejection reason. Can have value if the order is rejected.</value>
        [DataMember(Name="RejectionReason", EmitDefaultValue=false)]
        public RejectionReasonEnum? RejectionReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="store">Store summary.</param>
        /// <param name="customer">Customer summary.</param>
        /// <param name="voucher">Voucher summary.</param>
        /// <param name="fees">Fee summary.</param>
        /// <param name="orderItems">Ordered items.</param>
        /// <param name="deliveryLocation">Delivery location for delivery orders.</param>
        /// <param name="customerLocation">Customer location.</param>
        /// <param name="orderId">Order identifier.</param>
        /// <param name="deliveryType">Delivery type.</param>
        /// <param name="pickupLocationType">Pickup location type.</param>
        /// <param name="tipAmount">Tip amount.</param>
        /// <param name="deliveryAmount">Delivery amount.</param>
        /// <param name="orderItemsAmount">Ordered items amount.</param>
        /// <param name="amount">This is the sum of the OrderItemsAmount, DeliveryAmount, TipAmount and Voucher.Amount (which is usually negative) and OnlineOrderingFee for cash orders.  It does not include the OnlineOrderingFee in the case of card orders as this fee is charged by Flipdish directly to the customer..</param>
        /// <param name="processingFee">This contains the online ordering processing fee. For card payments this is charged directly to the customer and for cash orders it is paid by the customer to the store. It is tax inclusive..</param>
        /// <param name="paymentAccountType">Payment account type.</param>
        /// <param name="paymentAccountDescription">Payment account description (like Visa ****2371 or Apple Pay. or Cash).</param>
        /// <param name="orderState">Order state.</param>
        /// <param name="isPreOrder">Is pre-order.</param>
        /// <param name="placedTime">Order placed time.</param>
        /// <param name="requestedForTime">Order requested for.</param>
        /// <param name="chefNote">Chef note.</param>
        /// <param name="appType">Used app type.</param>
        /// <param name="userRating">User rating.</param>
        /// <param name="paymentStatus">Status of the payment.</param>
        /// <param name="rejectionReason">Rejection reason. Can have value if the order is rejected..</param>
        /// <param name="refundedAmount">Amount refunded to customer..</param>
        public Order(StoreSummary store = default(StoreSummary), CustomerSummary customer = default(CustomerSummary), OrderVoucherSummary voucher = default(OrderVoucherSummary), FeeSummary fees = default(FeeSummary), List<OrderItem> orderItems = default(List<OrderItem>), DeliveryLocation deliveryLocation = default(DeliveryLocation), Coordinates customerLocation = default(Coordinates), int? orderId = default(int?), DeliveryTypeEnum? deliveryType = default(DeliveryTypeEnum?), PickupLocationTypeEnum? pickupLocationType = default(PickupLocationTypeEnum?), double? tipAmount = default(double?), double? deliveryAmount = default(double?), double? orderItemsAmount = default(double?), double? amount = default(double?), double? processingFee = default(double?), PaymentAccountTypeEnum? paymentAccountType = default(PaymentAccountTypeEnum?), string paymentAccountDescription = default(string), OrderStateEnum? orderState = default(OrderStateEnum?), bool? isPreOrder = default(bool?), DateTime? placedTime = default(DateTime?), DateTime? requestedForTime = default(DateTime?), string chefNote = default(string), AppTypeEnum? appType = default(AppTypeEnum?), int? userRating = default(int?), PaymentStatusEnum? paymentStatus = default(PaymentStatusEnum?), RejectionReasonEnum? rejectionReason = default(RejectionReasonEnum?), double? refundedAmount = default(double?))
        {
            this.Store = store;
            this.Customer = customer;
            this.Voucher = voucher;
            this.Fees = fees;
            this.OrderItems = orderItems;
            this.DeliveryLocation = deliveryLocation;
            this.CustomerLocation = customerLocation;
            this.OrderId = orderId;
            this.DeliveryType = deliveryType;
            this.PickupLocationType = pickupLocationType;
            this.TipAmount = tipAmount;
            this.DeliveryAmount = deliveryAmount;
            this.OrderItemsAmount = orderItemsAmount;
            this.Amount = amount;
            this.ProcessingFee = processingFee;
            this.PaymentAccountType = paymentAccountType;
            this.PaymentAccountDescription = paymentAccountDescription;
            this.OrderState = orderState;
            this.IsPreOrder = isPreOrder;
            this.PlacedTime = placedTime;
            this.RequestedForTime = requestedForTime;
            this.ChefNote = chefNote;
            this.AppType = appType;
            this.UserRating = userRating;
            this.PaymentStatus = paymentStatus;
            this.RejectionReason = rejectionReason;
            this.RefundedAmount = refundedAmount;
        }
        
        /// <summary>
        /// Store summary
        /// </summary>
        /// <value>Store summary</value>
        [DataMember(Name="Store", EmitDefaultValue=false)]
        public StoreSummary Store { get; set; }

        /// <summary>
        /// Customer summary
        /// </summary>
        /// <value>Customer summary</value>
        [DataMember(Name="Customer", EmitDefaultValue=false)]
        public CustomerSummary Customer { get; set; }

        /// <summary>
        /// Voucher summary
        /// </summary>
        /// <value>Voucher summary</value>
        [DataMember(Name="Voucher", EmitDefaultValue=false)]
        public OrderVoucherSummary Voucher { get; set; }

        /// <summary>
        /// Fee summary
        /// </summary>
        /// <value>Fee summary</value>
        [DataMember(Name="Fees", EmitDefaultValue=false)]
        public FeeSummary Fees { get; set; }

        /// <summary>
        /// Ordered items
        /// </summary>
        /// <value>Ordered items</value>
        [DataMember(Name="OrderItems", EmitDefaultValue=false)]
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// Delivery location for delivery orders
        /// </summary>
        /// <value>Delivery location for delivery orders</value>
        [DataMember(Name="DeliveryLocation", EmitDefaultValue=false)]
        public DeliveryLocation DeliveryLocation { get; set; }

        /// <summary>
        /// Customer location
        /// </summary>
        /// <value>Customer location</value>
        [DataMember(Name="CustomerLocation", EmitDefaultValue=false)]
        public Coordinates CustomerLocation { get; set; }

        /// <summary>
        /// Order identifier
        /// </summary>
        /// <value>Order identifier</value>
        [DataMember(Name="OrderId", EmitDefaultValue=false)]
        public int? OrderId { get; set; }



        /// <summary>
        /// Tip amount
        /// </summary>
        /// <value>Tip amount</value>
        [DataMember(Name="TipAmount", EmitDefaultValue=false)]
        public double? TipAmount { get; set; }

        /// <summary>
        /// Delivery amount
        /// </summary>
        /// <value>Delivery amount</value>
        [DataMember(Name="DeliveryAmount", EmitDefaultValue=false)]
        public double? DeliveryAmount { get; set; }

        /// <summary>
        /// Ordered items amount
        /// </summary>
        /// <value>Ordered items amount</value>
        [DataMember(Name="OrderItemsAmount", EmitDefaultValue=false)]
        public double? OrderItemsAmount { get; set; }

        /// <summary>
        /// This is the sum of the OrderItemsAmount, DeliveryAmount, TipAmount and Voucher.Amount (which is usually negative) and OnlineOrderingFee for cash orders.  It does not include the OnlineOrderingFee in the case of card orders as this fee is charged by Flipdish directly to the customer.
        /// </summary>
        /// <value>This is the sum of the OrderItemsAmount, DeliveryAmount, TipAmount and Voucher.Amount (which is usually negative) and OnlineOrderingFee for cash orders.  It does not include the OnlineOrderingFee in the case of card orders as this fee is charged by Flipdish directly to the customer.</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// This contains the online ordering processing fee. For card payments this is charged directly to the customer and for cash orders it is paid by the customer to the store. It is tax inclusive.
        /// </summary>
        /// <value>This contains the online ordering processing fee. For card payments this is charged directly to the customer and for cash orders it is paid by the customer to the store. It is tax inclusive.</value>
        [DataMember(Name="ProcessingFee", EmitDefaultValue=false)]
        public double? ProcessingFee { get; set; }


        /// <summary>
        /// Payment account description (like Visa ****2371 or Apple Pay. or Cash)
        /// </summary>
        /// <value>Payment account description (like Visa ****2371 or Apple Pay. or Cash)</value>
        [DataMember(Name="PaymentAccountDescription", EmitDefaultValue=false)]
        public string PaymentAccountDescription { get; set; }


        /// <summary>
        /// Is pre-order
        /// </summary>
        /// <value>Is pre-order</value>
        [DataMember(Name="IsPreOrder", EmitDefaultValue=false)]
        public bool? IsPreOrder { get; set; }

        /// <summary>
        /// Order placed time
        /// </summary>
        /// <value>Order placed time</value>
        [DataMember(Name="PlacedTime", EmitDefaultValue=false)]
        public DateTime? PlacedTime { get; set; }

        /// <summary>
        /// Order requested for
        /// </summary>
        /// <value>Order requested for</value>
        [DataMember(Name="RequestedForTime", EmitDefaultValue=false)]
        public DateTime? RequestedForTime { get; set; }

        /// <summary>
        /// Chef note
        /// </summary>
        /// <value>Chef note</value>
        [DataMember(Name="ChefNote", EmitDefaultValue=false)]
        public string ChefNote { get; set; }


        /// <summary>
        /// User rating
        /// </summary>
        /// <value>User rating</value>
        [DataMember(Name="UserRating", EmitDefaultValue=false)]
        public int? UserRating { get; set; }



        /// <summary>
        /// Amount refunded to customer.
        /// </summary>
        /// <value>Amount refunded to customer.</value>
        [DataMember(Name="RefundedAmount", EmitDefaultValue=false)]
        public double? RefundedAmount { get; set; }

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
            sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
            sb.Append("  RejectionReason: ").Append(RejectionReason).Append("\n");
            sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
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
                ) && 
                (
                    this.PaymentStatus == input.PaymentStatus ||
                    (this.PaymentStatus != null &&
                    this.PaymentStatus.Equals(input.PaymentStatus))
                ) && 
                (
                    this.RejectionReason == input.RejectionReason ||
                    (this.RejectionReason != null &&
                    this.RejectionReason.Equals(input.RejectionReason))
                ) && 
                (
                    this.RefundedAmount == input.RefundedAmount ||
                    (this.RefundedAmount != null &&
                    this.RefundedAmount.Equals(input.RefundedAmount))
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
                if (this.PaymentStatus != null)
                    hashCode = hashCode * 59 + this.PaymentStatus.GetHashCode();
                if (this.RejectionReason != null)
                    hashCode = hashCode * 59 + this.RejectionReason.GetHashCode();
                if (this.RefundedAmount != null)
                    hashCode = hashCode * 59 + this.RefundedAmount.GetHashCode();
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
