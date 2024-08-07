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
    /// PayoutReport3PayoutOrder
    /// </summary>
    [DataContract]
    public partial class PayoutReport3PayoutOrder :  IEquatable<PayoutReport3PayoutOrder>
    {
        /// <summary>
        /// Defines OrderType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderTypeEnum
        {
            
            /// <summary>
            /// Enum Cash for value: Cash
            /// </summary>
            [EnumMember(Value = "Cash")]
            Cash = 1,
            
            /// <summary>
            /// Enum Card for value: Card
            /// </summary>
            [EnumMember(Value = "Card")]
            Card = 2
        }

        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name="OrderType", EmitDefaultValue=false)]
        public OrderTypeEnum? OrderType { get; set; }
        /// <summary>
        /// Defines OrderCurrency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderCurrencyEnum
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
        /// Gets or Sets OrderCurrency
        /// </summary>
        [DataMember(Name="OrderCurrency", EmitDefaultValue=false)]
        public OrderCurrencyEnum? OrderCurrency { get; set; }
        /// <summary>
        /// Defines RefundChargebackType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RefundChargebackTypeEnum
        {
            
            /// <summary>
            /// Enum Refund for value: Refund
            /// </summary>
            [EnumMember(Value = "Refund")]
            Refund = 1,
            
            /// <summary>
            /// Enum Chargeback for value: Chargeback
            /// </summary>
            [EnumMember(Value = "Chargeback")]
            Chargeback = 2
        }

        /// <summary>
        /// Gets or Sets RefundChargebackType
        /// </summary>
        [DataMember(Name="RefundChargebackType", EmitDefaultValue=false)]
        public RefundChargebackTypeEnum? RefundChargebackType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutReport3PayoutOrder" /> class.
        /// </summary>
        /// <param name="orderId">orderId.</param>
        /// <param name="orderDate">orderDate.</param>
        /// <param name="storeId">storeId.</param>
        /// <param name="storeName">storeName.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="sales">sales.</param>
        /// <param name="salesTax">salesTax.</param>
        /// <param name="deliveryCharges">deliveryCharges.</param>
        /// <param name="tips">tips.</param>
        /// <param name="voucher">voucher.</param>
        /// <param name="orderCurrency">orderCurrency.</param>
        /// <param name="refundChargebackType">refundChargebackType.</param>
        public PayoutReport3PayoutOrder(int? orderId = default(int?), DateTime? orderDate = default(DateTime?), int? storeId = default(int?), string storeName = default(string), OrderTypeEnum? orderType = default(OrderTypeEnum?), double? sales = default(double?), double? salesTax = default(double?), double? deliveryCharges = default(double?), double? tips = default(double?), double? voucher = default(double?), OrderCurrencyEnum? orderCurrency = default(OrderCurrencyEnum?), RefundChargebackTypeEnum? refundChargebackType = default(RefundChargebackTypeEnum?))
        {
            this.OrderId = orderId;
            this.OrderDate = orderDate;
            this.StoreId = storeId;
            this.StoreName = storeName;
            this.OrderType = orderType;
            this.Sales = sales;
            this.SalesTax = salesTax;
            this.DeliveryCharges = deliveryCharges;
            this.Tips = tips;
            this.Voucher = voucher;
            this.OrderCurrency = orderCurrency;
            this.RefundChargebackType = refundChargebackType;
        }
        
        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="OrderId", EmitDefaultValue=false)]
        public int? OrderId { get; set; }

        /// <summary>
        /// Gets or Sets OrderDate
        /// </summary>
        [DataMember(Name="OrderDate", EmitDefaultValue=false)]
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public int? StoreId { get; set; }

        /// <summary>
        /// Gets or Sets StoreName
        /// </summary>
        [DataMember(Name="StoreName", EmitDefaultValue=false)]
        public string StoreName { get; set; }


        /// <summary>
        /// Gets or Sets Sales
        /// </summary>
        [DataMember(Name="Sales", EmitDefaultValue=false)]
        public double? Sales { get; set; }

        /// <summary>
        /// Gets or Sets SalesTax
        /// </summary>
        [DataMember(Name="SalesTax", EmitDefaultValue=false)]
        public double? SalesTax { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryCharges
        /// </summary>
        [DataMember(Name="DeliveryCharges", EmitDefaultValue=false)]
        public double? DeliveryCharges { get; set; }

        /// <summary>
        /// Gets or Sets Tips
        /// </summary>
        [DataMember(Name="Tips", EmitDefaultValue=false)]
        public double? Tips { get; set; }

        /// <summary>
        /// Gets or Sets Voucher
        /// </summary>
        [DataMember(Name="Voucher", EmitDefaultValue=false)]
        public double? Voucher { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutReport3PayoutOrder {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  Sales: ").Append(Sales).Append("\n");
            sb.Append("  SalesTax: ").Append(SalesTax).Append("\n");
            sb.Append("  DeliveryCharges: ").Append(DeliveryCharges).Append("\n");
            sb.Append("  Tips: ").Append(Tips).Append("\n");
            sb.Append("  Voucher: ").Append(Voucher).Append("\n");
            sb.Append("  OrderCurrency: ").Append(OrderCurrency).Append("\n");
            sb.Append("  RefundChargebackType: ").Append(RefundChargebackType).Append("\n");
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
            return this.Equals(input as PayoutReport3PayoutOrder);
        }

        /// <summary>
        /// Returns true if PayoutReport3PayoutOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutReport3PayoutOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutReport3PayoutOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OrderDate == input.OrderDate ||
                    (this.OrderDate != null &&
                    this.OrderDate.Equals(input.OrderDate))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && 
                (
                    this.Sales == input.Sales ||
                    (this.Sales != null &&
                    this.Sales.Equals(input.Sales))
                ) && 
                (
                    this.SalesTax == input.SalesTax ||
                    (this.SalesTax != null &&
                    this.SalesTax.Equals(input.SalesTax))
                ) && 
                (
                    this.DeliveryCharges == input.DeliveryCharges ||
                    (this.DeliveryCharges != null &&
                    this.DeliveryCharges.Equals(input.DeliveryCharges))
                ) && 
                (
                    this.Tips == input.Tips ||
                    (this.Tips != null &&
                    this.Tips.Equals(input.Tips))
                ) && 
                (
                    this.Voucher == input.Voucher ||
                    (this.Voucher != null &&
                    this.Voucher.Equals(input.Voucher))
                ) && 
                (
                    this.OrderCurrency == input.OrderCurrency ||
                    (this.OrderCurrency != null &&
                    this.OrderCurrency.Equals(input.OrderCurrency))
                ) && 
                (
                    this.RefundChargebackType == input.RefundChargebackType ||
                    (this.RefundChargebackType != null &&
                    this.RefundChargebackType.Equals(input.RefundChargebackType))
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
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OrderDate != null)
                    hashCode = hashCode * 59 + this.OrderDate.GetHashCode();
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.StoreName != null)
                    hashCode = hashCode * 59 + this.StoreName.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.Sales != null)
                    hashCode = hashCode * 59 + this.Sales.GetHashCode();
                if (this.SalesTax != null)
                    hashCode = hashCode * 59 + this.SalesTax.GetHashCode();
                if (this.DeliveryCharges != null)
                    hashCode = hashCode * 59 + this.DeliveryCharges.GetHashCode();
                if (this.Tips != null)
                    hashCode = hashCode * 59 + this.Tips.GetHashCode();
                if (this.Voucher != null)
                    hashCode = hashCode * 59 + this.Voucher.GetHashCode();
                if (this.OrderCurrency != null)
                    hashCode = hashCode * 59 + this.OrderCurrency.GetHashCode();
                if (this.RefundChargebackType != null)
                    hashCode = hashCode * 59 + this.RefundChargebackType.GetHashCode();
                return hashCode;
            }
        }
    }

}
