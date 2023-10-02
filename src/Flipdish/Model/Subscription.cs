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
    /// Subscription
    /// </summary>
    [DataContract]
    public partial class Subscription :  IEquatable<Subscription>
    {
        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Incomplete for value: Incomplete
            /// </summary>
            [EnumMember(Value = "Incomplete")]
            Incomplete = 1,
            
            /// <summary>
            /// Enum IncompleteExpired for value: IncompleteExpired
            /// </summary>
            [EnumMember(Value = "IncompleteExpired")]
            IncompleteExpired = 2,
            
            /// <summary>
            /// Enum Trialing for value: Trialing
            /// </summary>
            [EnumMember(Value = "Trialing")]
            Trialing = 3,
            
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 4,
            
            /// <summary>
            /// Enum PastDue for value: PastDue
            /// </summary>
            [EnumMember(Value = "PastDue")]
            PastDue = 5,
            
            /// <summary>
            /// Enum Canceled for value: Canceled
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled = 6,
            
            /// <summary>
            /// Enum Unpaid for value: Unpaid
            /// </summary>
            [EnumMember(Value = "Unpaid")]
            Unpaid = 7
        }

        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyEnum
        {
            
            /// <summary>
            /// Enum EUR for value: EUR
            /// </summary>
            [EnumMember(Value = "EUR")]
            EUR = 1,
            
            /// <summary>
            /// Enum USD for value: USD
            /// </summary>
            [EnumMember(Value = "USD")]
            USD = 2,
            
            /// <summary>
            /// Enum GBP for value: GBP
            /// </summary>
            [EnumMember(Value = "GBP")]
            GBP = 3,
            
            /// <summary>
            /// Enum CAD for value: CAD
            /// </summary>
            [EnumMember(Value = "CAD")]
            CAD = 4,
            
            /// <summary>
            /// Enum AUD for value: AUD
            /// </summary>
            [EnumMember(Value = "AUD")]
            AUD = 5,
            
            /// <summary>
            /// Enum DJF for value: DJF
            /// </summary>
            [EnumMember(Value = "DJF")]
            DJF = 6,
            
            /// <summary>
            /// Enum ZAR for value: ZAR
            /// </summary>
            [EnumMember(Value = "ZAR")]
            ZAR = 7,
            
            /// <summary>
            /// Enum ETB for value: ETB
            /// </summary>
            [EnumMember(Value = "ETB")]
            ETB = 8,
            
            /// <summary>
            /// Enum AED for value: AED
            /// </summary>
            [EnumMember(Value = "AED")]
            AED = 9,
            
            /// <summary>
            /// Enum BHD for value: BHD
            /// </summary>
            [EnumMember(Value = "BHD")]
            BHD = 10,
            
            /// <summary>
            /// Enum DZD for value: DZD
            /// </summary>
            [EnumMember(Value = "DZD")]
            DZD = 11,
            
            /// <summary>
            /// Enum EGP for value: EGP
            /// </summary>
            [EnumMember(Value = "EGP")]
            EGP = 12,
            
            /// <summary>
            /// Enum IQD for value: IQD
            /// </summary>
            [EnumMember(Value = "IQD")]
            IQD = 13,
            
            /// <summary>
            /// Enum JOD for value: JOD
            /// </summary>
            [EnumMember(Value = "JOD")]
            JOD = 14,
            
            /// <summary>
            /// Enum KWD for value: KWD
            /// </summary>
            [EnumMember(Value = "KWD")]
            KWD = 15,
            
            /// <summary>
            /// Enum LBP for value: LBP
            /// </summary>
            [EnumMember(Value = "LBP")]
            LBP = 16,
            
            /// <summary>
            /// Enum LYD for value: LYD
            /// </summary>
            [EnumMember(Value = "LYD")]
            LYD = 17,
            
            /// <summary>
            /// Enum MAD for value: MAD
            /// </summary>
            [EnumMember(Value = "MAD")]
            MAD = 18,
            
            /// <summary>
            /// Enum OMR for value: OMR
            /// </summary>
            [EnumMember(Value = "OMR")]
            OMR = 19,
            
            /// <summary>
            /// Enum QAR for value: QAR
            /// </summary>
            [EnumMember(Value = "QAR")]
            QAR = 20,
            
            /// <summary>
            /// Enum SAR for value: SAR
            /// </summary>
            [EnumMember(Value = "SAR")]
            SAR = 21,
            
            /// <summary>
            /// Enum SYP for value: SYP
            /// </summary>
            [EnumMember(Value = "SYP")]
            SYP = 22,
            
            /// <summary>
            /// Enum TND for value: TND
            /// </summary>
            [EnumMember(Value = "TND")]
            TND = 23,
            
            /// <summary>
            /// Enum YER for value: YER
            /// </summary>
            [EnumMember(Value = "YER")]
            YER = 24,
            
            /// <summary>
            /// Enum CLP for value: CLP
            /// </summary>
            [EnumMember(Value = "CLP")]
            CLP = 25,
            
            /// <summary>
            /// Enum INR for value: INR
            /// </summary>
            [EnumMember(Value = "INR")]
            INR = 26,
            
            /// <summary>
            /// Enum AZN for value: AZN
            /// </summary>
            [EnumMember(Value = "AZN")]
            AZN = 27,
            
            /// <summary>
            /// Enum RUB for value: RUB
            /// </summary>
            [EnumMember(Value = "RUB")]
            RUB = 28,
            
            /// <summary>
            /// Enum BYN for value: BYN
            /// </summary>
            [EnumMember(Value = "BYN")]
            BYN = 29,
            
            /// <summary>
            /// Enum BGN for value: BGN
            /// </summary>
            [EnumMember(Value = "BGN")]
            BGN = 30,
            
            /// <summary>
            /// Enum NGN for value: NGN
            /// </summary>
            [EnumMember(Value = "NGN")]
            NGN = 31,
            
            /// <summary>
            /// Enum BDT for value: BDT
            /// </summary>
            [EnumMember(Value = "BDT")]
            BDT = 32,
            
            /// <summary>
            /// Enum CNY for value: CNY
            /// </summary>
            [EnumMember(Value = "CNY")]
            CNY = 33,
            
            /// <summary>
            /// Enum BAM for value: BAM
            /// </summary>
            [EnumMember(Value = "BAM")]
            BAM = 34,
            
            /// <summary>
            /// Enum CZK for value: CZK
            /// </summary>
            [EnumMember(Value = "CZK")]
            CZK = 35,
            
            /// <summary>
            /// Enum DKK for value: DKK
            /// </summary>
            [EnumMember(Value = "DKK")]
            DKK = 36,
            
            /// <summary>
            /// Enum CHF for value: CHF
            /// </summary>
            [EnumMember(Value = "CHF")]
            CHF = 37,
            
            /// <summary>
            /// Enum MVR for value: MVR
            /// </summary>
            [EnumMember(Value = "MVR")]
            MVR = 38,
            
            /// <summary>
            /// Enum BTN for value: BTN
            /// </summary>
            [EnumMember(Value = "BTN")]
            BTN = 39,
            
            /// <summary>
            /// Enum XCD for value: XCD
            /// </summary>
            [EnumMember(Value = "XCD")]
            XCD = 40,
            
            /// <summary>
            /// Enum BZD for value: BZD
            /// </summary>
            [EnumMember(Value = "BZD")]
            BZD = 41,
            
            /// <summary>
            /// Enum HKD for value: HKD
            /// </summary>
            [EnumMember(Value = "HKD")]
            HKD = 42,
            
            /// <summary>
            /// Enum IDR for value: IDR
            /// </summary>
            [EnumMember(Value = "IDR")]
            IDR = 43,
            
            /// <summary>
            /// Enum JMD for value: JMD
            /// </summary>
            [EnumMember(Value = "JMD")]
            JMD = 44,
            
            /// <summary>
            /// Enum MYR for value: MYR
            /// </summary>
            [EnumMember(Value = "MYR")]
            MYR = 45,
            
            /// <summary>
            /// Enum NZD for value: NZD
            /// </summary>
            [EnumMember(Value = "NZD")]
            NZD = 46,
            
            /// <summary>
            /// Enum PHP for value: PHP
            /// </summary>
            [EnumMember(Value = "PHP")]
            PHP = 47,
            
            /// <summary>
            /// Enum SGD for value: SGD
            /// </summary>
            [EnumMember(Value = "SGD")]
            SGD = 48,
            
            /// <summary>
            /// Enum TTD for value: TTD
            /// </summary>
            [EnumMember(Value = "TTD")]
            TTD = 49,
            
            /// <summary>
            /// Enum XDR for value: XDR
            /// </summary>
            [EnumMember(Value = "XDR")]
            XDR = 50,
            
            /// <summary>
            /// Enum ARS for value: ARS
            /// </summary>
            [EnumMember(Value = "ARS")]
            ARS = 51,
            
            /// <summary>
            /// Enum BOB for value: BOB
            /// </summary>
            [EnumMember(Value = "BOB")]
            BOB = 52,
            
            /// <summary>
            /// Enum COP for value: COP
            /// </summary>
            [EnumMember(Value = "COP")]
            COP = 53,
            
            /// <summary>
            /// Enum CRC for value: CRC
            /// </summary>
            [EnumMember(Value = "CRC")]
            CRC = 54,
            
            /// <summary>
            /// Enum CUP for value: CUP
            /// </summary>
            [EnumMember(Value = "CUP")]
            CUP = 55,
            
            /// <summary>
            /// Enum DOP for value: DOP
            /// </summary>
            [EnumMember(Value = "DOP")]
            DOP = 56,
            
            /// <summary>
            /// Enum GTQ for value: GTQ
            /// </summary>
            [EnumMember(Value = "GTQ")]
            GTQ = 57,
            
            /// <summary>
            /// Enum HNL for value: HNL
            /// </summary>
            [EnumMember(Value = "HNL")]
            HNL = 58,
            
            /// <summary>
            /// Enum MXN for value: MXN
            /// </summary>
            [EnumMember(Value = "MXN")]
            MXN = 59,
            
            /// <summary>
            /// Enum NIO for value: NIO
            /// </summary>
            [EnumMember(Value = "NIO")]
            NIO = 60,
            
            /// <summary>
            /// Enum PAB for value: PAB
            /// </summary>
            [EnumMember(Value = "PAB")]
            PAB = 61,
            
            /// <summary>
            /// Enum PEN for value: PEN
            /// </summary>
            [EnumMember(Value = "PEN")]
            PEN = 62,
            
            /// <summary>
            /// Enum PYG for value: PYG
            /// </summary>
            [EnumMember(Value = "PYG")]
            PYG = 63,
            
            /// <summary>
            /// Enum UYU for value: UYU
            /// </summary>
            [EnumMember(Value = "UYU")]
            UYU = 64,
            
            /// <summary>
            /// Enum VEF for value: VEF
            /// </summary>
            [EnumMember(Value = "VEF")]
            VEF = 65,
            
            /// <summary>
            /// Enum IRR for value: IRR
            /// </summary>
            [EnumMember(Value = "IRR")]
            IRR = 66,
            
            /// <summary>
            /// Enum XOF for value: XOF
            /// </summary>
            [EnumMember(Value = "XOF")]
            XOF = 67,
            
            /// <summary>
            /// Enum CDF for value: CDF
            /// </summary>
            [EnumMember(Value = "CDF")]
            CDF = 68,
            
            /// <summary>
            /// Enum XAF for value: XAF
            /// </summary>
            [EnumMember(Value = "XAF")]
            XAF = 69,
            
            /// <summary>
            /// Enum HTG for value: HTG
            /// </summary>
            [EnumMember(Value = "HTG")]
            HTG = 70,
            
            /// <summary>
            /// Enum ILS for value: ILS
            /// </summary>
            [EnumMember(Value = "ILS")]
            ILS = 71,
            
            /// <summary>
            /// Enum HRK for value: HRK
            /// </summary>
            [EnumMember(Value = "HRK")]
            HRK = 72,
            
            /// <summary>
            /// Enum HUF for value: HUF
            /// </summary>
            [EnumMember(Value = "HUF")]
            HUF = 73,
            
            /// <summary>
            /// Enum AMD for value: AMD
            /// </summary>
            [EnumMember(Value = "AMD")]
            AMD = 74,
            
            /// <summary>
            /// Enum ISK for value: ISK
            /// </summary>
            [EnumMember(Value = "ISK")]
            ISK = 75,
            
            /// <summary>
            /// Enum JPY for value: JPY
            /// </summary>
            [EnumMember(Value = "JPY")]
            JPY = 76,
            
            /// <summary>
            /// Enum GEL for value: GEL
            /// </summary>
            [EnumMember(Value = "GEL")]
            GEL = 77,
            
            /// <summary>
            /// Enum KZT for value: KZT
            /// </summary>
            [EnumMember(Value = "KZT")]
            KZT = 78,
            
            /// <summary>
            /// Enum KHR for value: KHR
            /// </summary>
            [EnumMember(Value = "KHR")]
            KHR = 79,
            
            /// <summary>
            /// Enum KRW for value: KRW
            /// </summary>
            [EnumMember(Value = "KRW")]
            KRW = 80,
            
            /// <summary>
            /// Enum KGS for value: KGS
            /// </summary>
            [EnumMember(Value = "KGS")]
            KGS = 81,
            
            /// <summary>
            /// Enum LAK for value: LAK
            /// </summary>
            [EnumMember(Value = "LAK")]
            LAK = 82,
            
            /// <summary>
            /// Enum MKD for value: MKD
            /// </summary>
            [EnumMember(Value = "MKD")]
            MKD = 83,
            
            /// <summary>
            /// Enum MNT for value: MNT
            /// </summary>
            [EnumMember(Value = "MNT")]
            MNT = 84,
            
            /// <summary>
            /// Enum BND for value: BND
            /// </summary>
            [EnumMember(Value = "BND")]
            BND = 85,
            
            /// <summary>
            /// Enum MMK for value: MMK
            /// </summary>
            [EnumMember(Value = "MMK")]
            MMK = 86,
            
            /// <summary>
            /// Enum NOK for value: NOK
            /// </summary>
            [EnumMember(Value = "NOK")]
            NOK = 87,
            
            /// <summary>
            /// Enum NPR for value: NPR
            /// </summary>
            [EnumMember(Value = "NPR")]
            NPR = 88,
            
            /// <summary>
            /// Enum PKR for value: PKR
            /// </summary>
            [EnumMember(Value = "PKR")]
            PKR = 89,
            
            /// <summary>
            /// Enum PLN for value: PLN
            /// </summary>
            [EnumMember(Value = "PLN")]
            PLN = 90,
            
            /// <summary>
            /// Enum AFN for value: AFN
            /// </summary>
            [EnumMember(Value = "AFN")]
            AFN = 91,
            
            /// <summary>
            /// Enum BRL for value: BRL
            /// </summary>
            [EnumMember(Value = "BRL")]
            BRL = 92,
            
            /// <summary>
            /// Enum MDL for value: MDL
            /// </summary>
            [EnumMember(Value = "MDL")]
            MDL = 93,
            
            /// <summary>
            /// Enum RON for value: RON
            /// </summary>
            [EnumMember(Value = "RON")]
            RON = 94,
            
            /// <summary>
            /// Enum RWF for value: RWF
            /// </summary>
            [EnumMember(Value = "RWF")]
            RWF = 95,
            
            /// <summary>
            /// Enum SEK for value: SEK
            /// </summary>
            [EnumMember(Value = "SEK")]
            SEK = 96,
            
            /// <summary>
            /// Enum LKR for value: LKR
            /// </summary>
            [EnumMember(Value = "LKR")]
            LKR = 97,
            
            /// <summary>
            /// Enum SOS for value: SOS
            /// </summary>
            [EnumMember(Value = "SOS")]
            SOS = 98,
            
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL = 99,
            
            /// <summary>
            /// Enum RSD for value: RSD
            /// </summary>
            [EnumMember(Value = "RSD")]
            RSD = 100,
            
            /// <summary>
            /// Enum KES for value: KES
            /// </summary>
            [EnumMember(Value = "KES")]
            KES = 101,
            
            /// <summary>
            /// Enum TJS for value: TJS
            /// </summary>
            [EnumMember(Value = "TJS")]
            TJS = 102,
            
            /// <summary>
            /// Enum THB for value: THB
            /// </summary>
            [EnumMember(Value = "THB")]
            THB = 103,
            
            /// <summary>
            /// Enum ERN for value: ERN
            /// </summary>
            [EnumMember(Value = "ERN")]
            ERN = 104,
            
            /// <summary>
            /// Enum TMT for value: TMT
            /// </summary>
            [EnumMember(Value = "TMT")]
            TMT = 105,
            
            /// <summary>
            /// Enum BWP for value: BWP
            /// </summary>
            [EnumMember(Value = "BWP")]
            BWP = 106,
            
            /// <summary>
            /// Enum TRY for value: TRY
            /// </summary>
            [EnumMember(Value = "TRY")]
            TRY = 107,
            
            /// <summary>
            /// Enum UAH for value: UAH
            /// </summary>
            [EnumMember(Value = "UAH")]
            UAH = 108,
            
            /// <summary>
            /// Enum UZS for value: UZS
            /// </summary>
            [EnumMember(Value = "UZS")]
            UZS = 109,
            
            /// <summary>
            /// Enum VND for value: VND
            /// </summary>
            [EnumMember(Value = "VND")]
            VND = 110,
            
            /// <summary>
            /// Enum MOP for value: MOP
            /// </summary>
            [EnumMember(Value = "MOP")]
            MOP = 111,
            
            /// <summary>
            /// Enum TWD for value: TWD
            /// </summary>
            [EnumMember(Value = "TWD")]
            TWD = 112,
            
            /// <summary>
            /// Enum BMD for value: BMD
            /// </summary>
            [EnumMember(Value = "BMD")]
            BMD = 113
        }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="Currency", EmitDefaultValue=false)]
        public CurrencyEnum Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Subscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="products">Products (required).</param>
        /// <param name="nextInvoiceAmount">Next invoice amount.</param>
        /// <param name="nextInvoiceBillingDate">Next invoice billing date.</param>
        /// <param name="upcomingInvoiceItems">Upcoming invoice items.</param>
        /// <param name="upcomingInvoiceDiscounts">Upcoming invoice discounts.</param>
        /// <param name="upcomingInvoice">Upcoming invoice.</param>
        /// <param name="subscriptionId">The subscription identifier (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="status">Status (required).</param>
        /// <param name="currency">Currency (required).</param>
        /// <param name="user">User (required).</param>
        /// <param name="defaultPaymentDescription">Default payment description.</param>
        /// <param name="cancellationRequestDate">Cancellation Date.</param>
        /// <param name="cancellationDate">Cancel Date.</param>
        public Subscription(List<SubscriptionProduct> products = default(List<SubscriptionProduct>), double? nextInvoiceAmount = default(double?), DateTime? nextInvoiceBillingDate = default(DateTime?), List<InvoiceItem> upcomingInvoiceItems = default(List<InvoiceItem>), List<InvoiceDiscount> upcomingInvoiceDiscounts = default(List<InvoiceDiscount>), UpcomingInvoice upcomingInvoice = default(UpcomingInvoice), string subscriptionId = default(string), string name = default(string), StatusEnum status = default(StatusEnum), CurrencyEnum currency = default(CurrencyEnum), string user = default(string), string defaultPaymentDescription = default(string), DateTime? cancellationRequestDate = default(DateTime?), DateTime? cancellationDate = default(DateTime?))
        {
            // to ensure "products" is required (not null)
            if (products == null)
            {
                throw new InvalidDataException("products is a required property for Subscription and cannot be null");
            }
            else
            {
                this.Products = products;
            }
            // to ensure "subscriptionId" is required (not null)
            if (subscriptionId == null)
            {
                throw new InvalidDataException("subscriptionId is a required property for Subscription and cannot be null");
            }
            else
            {
                this.SubscriptionId = subscriptionId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Subscription and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for Subscription and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for Subscription and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for Subscription and cannot be null");
            }
            else
            {
                this.User = user;
            }
            this.NextInvoiceAmount = nextInvoiceAmount;
            this.NextInvoiceBillingDate = nextInvoiceBillingDate;
            this.UpcomingInvoiceItems = upcomingInvoiceItems;
            this.UpcomingInvoiceDiscounts = upcomingInvoiceDiscounts;
            this.UpcomingInvoice = upcomingInvoice;
            this.DefaultPaymentDescription = defaultPaymentDescription;
            this.CancellationRequestDate = cancellationRequestDate;
            this.CancellationDate = cancellationDate;
        }
        
        /// <summary>
        /// Products
        /// </summary>
        /// <value>Products</value>
        [DataMember(Name="Products", EmitDefaultValue=false)]
        public List<SubscriptionProduct> Products { get; set; }

        /// <summary>
        /// Next invoice amount
        /// </summary>
        /// <value>Next invoice amount</value>
        [DataMember(Name="NextInvoiceAmount", EmitDefaultValue=false)]
        public double? NextInvoiceAmount { get; set; }

        /// <summary>
        /// Next invoice billing date
        /// </summary>
        /// <value>Next invoice billing date</value>
        [DataMember(Name="NextInvoiceBillingDate", EmitDefaultValue=false)]
        public DateTime? NextInvoiceBillingDate { get; set; }

        /// <summary>
        /// Upcoming invoice items
        /// </summary>
        /// <value>Upcoming invoice items</value>
        [DataMember(Name="UpcomingInvoiceItems", EmitDefaultValue=false)]
        public List<InvoiceItem> UpcomingInvoiceItems { get; set; }

        /// <summary>
        /// Upcoming invoice discounts
        /// </summary>
        /// <value>Upcoming invoice discounts</value>
        [DataMember(Name="UpcomingInvoiceDiscounts", EmitDefaultValue=false)]
        public List<InvoiceDiscount> UpcomingInvoiceDiscounts { get; set; }

        /// <summary>
        /// Upcoming invoice
        /// </summary>
        /// <value>Upcoming invoice</value>
        [DataMember(Name="UpcomingInvoice", EmitDefaultValue=false)]
        public UpcomingInvoice UpcomingInvoice { get; set; }

        /// <summary>
        /// The subscription identifier
        /// </summary>
        /// <value>The subscription identifier</value>
        [DataMember(Name="SubscriptionId", EmitDefaultValue=false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// User
        /// </summary>
        /// <value>User</value>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// Default payment description
        /// </summary>
        /// <value>Default payment description</value>
        [DataMember(Name="DefaultPaymentDescription", EmitDefaultValue=false)]
        public string DefaultPaymentDescription { get; set; }

        /// <summary>
        /// Cancellation Date
        /// </summary>
        /// <value>Cancellation Date</value>
        [DataMember(Name="CancellationRequestDate", EmitDefaultValue=false)]
        public DateTime? CancellationRequestDate { get; set; }

        /// <summary>
        /// Cancel Date
        /// </summary>
        /// <value>Cancel Date</value>
        [DataMember(Name="CancellationDate", EmitDefaultValue=false)]
        public DateTime? CancellationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  NextInvoiceAmount: ").Append(NextInvoiceAmount).Append("\n");
            sb.Append("  NextInvoiceBillingDate: ").Append(NextInvoiceBillingDate).Append("\n");
            sb.Append("  UpcomingInvoiceItems: ").Append(UpcomingInvoiceItems).Append("\n");
            sb.Append("  UpcomingInvoiceDiscounts: ").Append(UpcomingInvoiceDiscounts).Append("\n");
            sb.Append("  UpcomingInvoice: ").Append(UpcomingInvoice).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  DefaultPaymentDescription: ").Append(DefaultPaymentDescription).Append("\n");
            sb.Append("  CancellationRequestDate: ").Append(CancellationRequestDate).Append("\n");
            sb.Append("  CancellationDate: ").Append(CancellationDate).Append("\n");
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
                    this.Products == input.Products ||
                    this.Products != null &&
                    this.Products.SequenceEqual(input.Products)
                ) && 
                (
                    this.NextInvoiceAmount == input.NextInvoiceAmount ||
                    (this.NextInvoiceAmount != null &&
                    this.NextInvoiceAmount.Equals(input.NextInvoiceAmount))
                ) && 
                (
                    this.NextInvoiceBillingDate == input.NextInvoiceBillingDate ||
                    (this.NextInvoiceBillingDate != null &&
                    this.NextInvoiceBillingDate.Equals(input.NextInvoiceBillingDate))
                ) && 
                (
                    this.UpcomingInvoiceItems == input.UpcomingInvoiceItems ||
                    this.UpcomingInvoiceItems != null &&
                    this.UpcomingInvoiceItems.SequenceEqual(input.UpcomingInvoiceItems)
                ) && 
                (
                    this.UpcomingInvoiceDiscounts == input.UpcomingInvoiceDiscounts ||
                    this.UpcomingInvoiceDiscounts != null &&
                    this.UpcomingInvoiceDiscounts.SequenceEqual(input.UpcomingInvoiceDiscounts)
                ) && 
                (
                    this.UpcomingInvoice == input.UpcomingInvoice ||
                    (this.UpcomingInvoice != null &&
                    this.UpcomingInvoice.Equals(input.UpcomingInvoice))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.DefaultPaymentDescription == input.DefaultPaymentDescription ||
                    (this.DefaultPaymentDescription != null &&
                    this.DefaultPaymentDescription.Equals(input.DefaultPaymentDescription))
                ) && 
                (
                    this.CancellationRequestDate == input.CancellationRequestDate ||
                    (this.CancellationRequestDate != null &&
                    this.CancellationRequestDate.Equals(input.CancellationRequestDate))
                ) && 
                (
                    this.CancellationDate == input.CancellationDate ||
                    (this.CancellationDate != null &&
                    this.CancellationDate.Equals(input.CancellationDate))
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
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
                if (this.NextInvoiceAmount != null)
                    hashCode = hashCode * 59 + this.NextInvoiceAmount.GetHashCode();
                if (this.NextInvoiceBillingDate != null)
                    hashCode = hashCode * 59 + this.NextInvoiceBillingDate.GetHashCode();
                if (this.UpcomingInvoiceItems != null)
                    hashCode = hashCode * 59 + this.UpcomingInvoiceItems.GetHashCode();
                if (this.UpcomingInvoiceDiscounts != null)
                    hashCode = hashCode * 59 + this.UpcomingInvoiceDiscounts.GetHashCode();
                if (this.UpcomingInvoice != null)
                    hashCode = hashCode * 59 + this.UpcomingInvoice.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.DefaultPaymentDescription != null)
                    hashCode = hashCode * 59 + this.DefaultPaymentDescription.GetHashCode();
                if (this.CancellationRequestDate != null)
                    hashCode = hashCode * 59 + this.CancellationRequestDate.GetHashCode();
                if (this.CancellationDate != null)
                    hashCode = hashCode * 59 + this.CancellationDate.GetHashCode();
                return hashCode;
            }
        }
    }

}
