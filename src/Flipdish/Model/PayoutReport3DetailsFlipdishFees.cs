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
    /// PayoutReport3DetailsFlipdishFees
    /// </summary>
    [DataContract]
    public partial class PayoutReport3DetailsFlipdishFees :  IEquatable<PayoutReport3DetailsFlipdishFees>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutReport3DetailsFlipdishFees" /> class.
        /// </summary>
        /// <param name="webAndAppCash">webAndAppCash.</param>
        /// <param name="webAndAppCashRevenueIncludingTips">webAndAppCashRevenueIncludingTips.</param>
        /// <param name="webAndAppCard">webAndAppCard.</param>
        /// <param name="webAndAppCardRevenueIncludingTips">webAndAppCardRevenueIncludingTips.</param>
        /// <param name="kioskCash">kioskCash.</param>
        /// <param name="kioskCashRevenue">kioskCashRevenue.</param>
        /// <param name="kioskCard">kioskCard.</param>
        /// <param name="kioskCardRevenue">kioskCardRevenue.</param>
        /// <param name="qropCash">qropCash.</param>
        /// <param name="qropCashRevenue">qropCashRevenue.</param>
        /// <param name="qropCard">qropCard.</param>
        /// <param name="qropCardRevenue">qropCardRevenue.</param>
        /// <param name="posCard">posCard.</param>
        /// <param name="posCardRevenue">posCardRevenue.</param>
        /// <param name="posCardOnFlipdishOrders">posCardOnFlipdishOrders.</param>
        /// <param name="otherIntegrationFees">otherIntegrationFees.</param>
        /// <param name="otherIntegrationTips">otherIntegrationTips.</param>
        /// <param name="refundedFeesOnRefundedSales">refundedFeesOnRefundedSales.</param>
        /// <param name="vat">vat.</param>
        /// <param name="refundedFeesOnPosSales">refundedFeesOnPosSales.</param>
        /// <param name="total">total.</param>
        /// <param name="thirdPartyIntegrationFeesAndTips">thirdPartyIntegrationFeesAndTips.</param>
        /// <param name="webAndAppCardOnXOrders">webAndAppCardOnXOrders.</param>
        /// <param name="webAndAppCashOnXOrders">webAndAppCashOnXOrders.</param>
        /// <param name="kioskCardOnXOrders">kioskCardOnXOrders.</param>
        /// <param name="kioskCashOnXOrders">kioskCashOnXOrders.</param>
        /// <param name="qropCardOnXOrders">qropCardOnXOrders.</param>
        /// <param name="qropCashOnXOrders">qropCashOnXOrders.</param>
        /// <param name="posCardOnXOrders">posCardOnXOrders.</param>
        public PayoutReport3DetailsFlipdishFees(double? webAndAppCash = default(double?), double? webAndAppCashRevenueIncludingTips = default(double?), double? webAndAppCard = default(double?), double? webAndAppCardRevenueIncludingTips = default(double?), double? kioskCash = default(double?), double? kioskCashRevenue = default(double?), double? kioskCard = default(double?), double? kioskCardRevenue = default(double?), double? qropCash = default(double?), double? qropCashRevenue = default(double?), double? qropCard = default(double?), double? qropCardRevenue = default(double?), double? posCard = default(double?), double? posCardRevenue = default(double?), double? posCardOnFlipdishOrders = default(double?), double? otherIntegrationFees = default(double?), double? otherIntegrationTips = default(double?), double? refundedFeesOnRefundedSales = default(double?), double? vat = default(double?), double? refundedFeesOnPosSales = default(double?), double? total = default(double?), double? thirdPartyIntegrationFeesAndTips = default(double?), int? webAndAppCardOnXOrders = default(int?), int? webAndAppCashOnXOrders = default(int?), int? kioskCardOnXOrders = default(int?), int? kioskCashOnXOrders = default(int?), int? qropCardOnXOrders = default(int?), int? qropCashOnXOrders = default(int?), int? posCardOnXOrders = default(int?))
        {
            this.WebAndAppCash = webAndAppCash;
            this.WebAndAppCashRevenueIncludingTips = webAndAppCashRevenueIncludingTips;
            this.WebAndAppCard = webAndAppCard;
            this.WebAndAppCardRevenueIncludingTips = webAndAppCardRevenueIncludingTips;
            this.KioskCash = kioskCash;
            this.KioskCashRevenue = kioskCashRevenue;
            this.KioskCard = kioskCard;
            this.KioskCardRevenue = kioskCardRevenue;
            this.QropCash = qropCash;
            this.QropCashRevenue = qropCashRevenue;
            this.QropCard = qropCard;
            this.QropCardRevenue = qropCardRevenue;
            this.PosCard = posCard;
            this.PosCardRevenue = posCardRevenue;
            this.PosCardOnFlipdishOrders = posCardOnFlipdishOrders;
            this.OtherIntegrationFees = otherIntegrationFees;
            this.OtherIntegrationTips = otherIntegrationTips;
            this.RefundedFeesOnRefundedSales = refundedFeesOnRefundedSales;
            this.Vat = vat;
            this.RefundedFeesOnPosSales = refundedFeesOnPosSales;
            this.Total = total;
            this.ThirdPartyIntegrationFeesAndTips = thirdPartyIntegrationFeesAndTips;
            this.WebAndAppCardOnXOrders = webAndAppCardOnXOrders;
            this.WebAndAppCashOnXOrders = webAndAppCashOnXOrders;
            this.KioskCardOnXOrders = kioskCardOnXOrders;
            this.KioskCashOnXOrders = kioskCashOnXOrders;
            this.QropCardOnXOrders = qropCardOnXOrders;
            this.QropCashOnXOrders = qropCashOnXOrders;
            this.PosCardOnXOrders = posCardOnXOrders;
        }
        
        /// <summary>
        /// Gets or Sets WebAndAppCash
        /// </summary>
        [DataMember(Name="WebAndAppCash", EmitDefaultValue=false)]
        public double? WebAndAppCash { get; set; }

        /// <summary>
        /// Gets or Sets WebAndAppCashRevenueIncludingTips
        /// </summary>
        [DataMember(Name="WebAndAppCashRevenueIncludingTips", EmitDefaultValue=false)]
        public double? WebAndAppCashRevenueIncludingTips { get; set; }

        /// <summary>
        /// Gets or Sets WebAndAppCard
        /// </summary>
        [DataMember(Name="WebAndAppCard", EmitDefaultValue=false)]
        public double? WebAndAppCard { get; set; }

        /// <summary>
        /// Gets or Sets WebAndAppCardRevenueIncludingTips
        /// </summary>
        [DataMember(Name="WebAndAppCardRevenueIncludingTips", EmitDefaultValue=false)]
        public double? WebAndAppCardRevenueIncludingTips { get; set; }

        /// <summary>
        /// Gets or Sets KioskCash
        /// </summary>
        [DataMember(Name="KioskCash", EmitDefaultValue=false)]
        public double? KioskCash { get; set; }

        /// <summary>
        /// Gets or Sets KioskCashRevenue
        /// </summary>
        [DataMember(Name="KioskCashRevenue", EmitDefaultValue=false)]
        public double? KioskCashRevenue { get; set; }

        /// <summary>
        /// Gets or Sets KioskCard
        /// </summary>
        [DataMember(Name="KioskCard", EmitDefaultValue=false)]
        public double? KioskCard { get; set; }

        /// <summary>
        /// Gets or Sets KioskCardRevenue
        /// </summary>
        [DataMember(Name="KioskCardRevenue", EmitDefaultValue=false)]
        public double? KioskCardRevenue { get; set; }

        /// <summary>
        /// Gets or Sets QropCash
        /// </summary>
        [DataMember(Name="QropCash", EmitDefaultValue=false)]
        public double? QropCash { get; set; }

        /// <summary>
        /// Gets or Sets QropCashRevenue
        /// </summary>
        [DataMember(Name="QropCashRevenue", EmitDefaultValue=false)]
        public double? QropCashRevenue { get; set; }

        /// <summary>
        /// Gets or Sets QropCard
        /// </summary>
        [DataMember(Name="QropCard", EmitDefaultValue=false)]
        public double? QropCard { get; set; }

        /// <summary>
        /// Gets or Sets QropCardRevenue
        /// </summary>
        [DataMember(Name="QropCardRevenue", EmitDefaultValue=false)]
        public double? QropCardRevenue { get; set; }

        /// <summary>
        /// Gets or Sets PosCard
        /// </summary>
        [DataMember(Name="PosCard", EmitDefaultValue=false)]
        public double? PosCard { get; set; }

        /// <summary>
        /// Gets or Sets PosCardRevenue
        /// </summary>
        [DataMember(Name="PosCardRevenue", EmitDefaultValue=false)]
        public double? PosCardRevenue { get; set; }

        /// <summary>
        /// Gets or Sets PosCardOnFlipdishOrders
        /// </summary>
        [DataMember(Name="PosCardOnFlipdishOrders", EmitDefaultValue=false)]
        public double? PosCardOnFlipdishOrders { get; set; }

        /// <summary>
        /// Gets or Sets OtherIntegrationFees
        /// </summary>
        [DataMember(Name="OtherIntegrationFees", EmitDefaultValue=false)]
        public double? OtherIntegrationFees { get; set; }

        /// <summary>
        /// Gets or Sets OtherIntegrationTips
        /// </summary>
        [DataMember(Name="OtherIntegrationTips", EmitDefaultValue=false)]
        public double? OtherIntegrationTips { get; set; }

        /// <summary>
        /// Gets or Sets RefundedFeesOnRefundedSales
        /// </summary>
        [DataMember(Name="RefundedFeesOnRefundedSales", EmitDefaultValue=false)]
        public double? RefundedFeesOnRefundedSales { get; set; }

        /// <summary>
        /// Gets or Sets Vat
        /// </summary>
        [DataMember(Name="Vat", EmitDefaultValue=false)]
        public double? Vat { get; set; }

        /// <summary>
        /// Gets or Sets RefundedFeesOnPosSales
        /// </summary>
        [DataMember(Name="RefundedFeesOnPosSales", EmitDefaultValue=false)]
        public double? RefundedFeesOnPosSales { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public double? Total { get; set; }

        /// <summary>
        /// Gets or Sets ThirdPartyIntegrationFeesAndTips
        /// </summary>
        [DataMember(Name="ThirdPartyIntegrationFeesAndTips", EmitDefaultValue=false)]
        public double? ThirdPartyIntegrationFeesAndTips { get; set; }

        /// <summary>
        /// Gets or Sets WebAndAppCardOnXOrders
        /// </summary>
        [DataMember(Name="WebAndAppCardOnXOrders", EmitDefaultValue=false)]
        public int? WebAndAppCardOnXOrders { get; set; }

        /// <summary>
        /// Gets or Sets WebAndAppCashOnXOrders
        /// </summary>
        [DataMember(Name="WebAndAppCashOnXOrders", EmitDefaultValue=false)]
        public int? WebAndAppCashOnXOrders { get; set; }

        /// <summary>
        /// Gets or Sets KioskCardOnXOrders
        /// </summary>
        [DataMember(Name="KioskCardOnXOrders", EmitDefaultValue=false)]
        public int? KioskCardOnXOrders { get; set; }

        /// <summary>
        /// Gets or Sets KioskCashOnXOrders
        /// </summary>
        [DataMember(Name="KioskCashOnXOrders", EmitDefaultValue=false)]
        public int? KioskCashOnXOrders { get; set; }

        /// <summary>
        /// Gets or Sets QropCardOnXOrders
        /// </summary>
        [DataMember(Name="QropCardOnXOrders", EmitDefaultValue=false)]
        public int? QropCardOnXOrders { get; set; }

        /// <summary>
        /// Gets or Sets QropCashOnXOrders
        /// </summary>
        [DataMember(Name="QropCashOnXOrders", EmitDefaultValue=false)]
        public int? QropCashOnXOrders { get; set; }

        /// <summary>
        /// Gets or Sets PosCardOnXOrders
        /// </summary>
        [DataMember(Name="PosCardOnXOrders", EmitDefaultValue=false)]
        public int? PosCardOnXOrders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutReport3DetailsFlipdishFees {\n");
            sb.Append("  WebAndAppCash: ").Append(WebAndAppCash).Append("\n");
            sb.Append("  WebAndAppCashRevenueIncludingTips: ").Append(WebAndAppCashRevenueIncludingTips).Append("\n");
            sb.Append("  WebAndAppCard: ").Append(WebAndAppCard).Append("\n");
            sb.Append("  WebAndAppCardRevenueIncludingTips: ").Append(WebAndAppCardRevenueIncludingTips).Append("\n");
            sb.Append("  KioskCash: ").Append(KioskCash).Append("\n");
            sb.Append("  KioskCashRevenue: ").Append(KioskCashRevenue).Append("\n");
            sb.Append("  KioskCard: ").Append(KioskCard).Append("\n");
            sb.Append("  KioskCardRevenue: ").Append(KioskCardRevenue).Append("\n");
            sb.Append("  QropCash: ").Append(QropCash).Append("\n");
            sb.Append("  QropCashRevenue: ").Append(QropCashRevenue).Append("\n");
            sb.Append("  QropCard: ").Append(QropCard).Append("\n");
            sb.Append("  QropCardRevenue: ").Append(QropCardRevenue).Append("\n");
            sb.Append("  PosCard: ").Append(PosCard).Append("\n");
            sb.Append("  PosCardRevenue: ").Append(PosCardRevenue).Append("\n");
            sb.Append("  PosCardOnFlipdishOrders: ").Append(PosCardOnFlipdishOrders).Append("\n");
            sb.Append("  OtherIntegrationFees: ").Append(OtherIntegrationFees).Append("\n");
            sb.Append("  OtherIntegrationTips: ").Append(OtherIntegrationTips).Append("\n");
            sb.Append("  RefundedFeesOnRefundedSales: ").Append(RefundedFeesOnRefundedSales).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  RefundedFeesOnPosSales: ").Append(RefundedFeesOnPosSales).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  ThirdPartyIntegrationFeesAndTips: ").Append(ThirdPartyIntegrationFeesAndTips).Append("\n");
            sb.Append("  WebAndAppCardOnXOrders: ").Append(WebAndAppCardOnXOrders).Append("\n");
            sb.Append("  WebAndAppCashOnXOrders: ").Append(WebAndAppCashOnXOrders).Append("\n");
            sb.Append("  KioskCardOnXOrders: ").Append(KioskCardOnXOrders).Append("\n");
            sb.Append("  KioskCashOnXOrders: ").Append(KioskCashOnXOrders).Append("\n");
            sb.Append("  QropCardOnXOrders: ").Append(QropCardOnXOrders).Append("\n");
            sb.Append("  QropCashOnXOrders: ").Append(QropCashOnXOrders).Append("\n");
            sb.Append("  PosCardOnXOrders: ").Append(PosCardOnXOrders).Append("\n");
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
            return this.Equals(input as PayoutReport3DetailsFlipdishFees);
        }

        /// <summary>
        /// Returns true if PayoutReport3DetailsFlipdishFees instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutReport3DetailsFlipdishFees to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutReport3DetailsFlipdishFees input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WebAndAppCash == input.WebAndAppCash ||
                    (this.WebAndAppCash != null &&
                    this.WebAndAppCash.Equals(input.WebAndAppCash))
                ) && 
                (
                    this.WebAndAppCashRevenueIncludingTips == input.WebAndAppCashRevenueIncludingTips ||
                    (this.WebAndAppCashRevenueIncludingTips != null &&
                    this.WebAndAppCashRevenueIncludingTips.Equals(input.WebAndAppCashRevenueIncludingTips))
                ) && 
                (
                    this.WebAndAppCard == input.WebAndAppCard ||
                    (this.WebAndAppCard != null &&
                    this.WebAndAppCard.Equals(input.WebAndAppCard))
                ) && 
                (
                    this.WebAndAppCardRevenueIncludingTips == input.WebAndAppCardRevenueIncludingTips ||
                    (this.WebAndAppCardRevenueIncludingTips != null &&
                    this.WebAndAppCardRevenueIncludingTips.Equals(input.WebAndAppCardRevenueIncludingTips))
                ) && 
                (
                    this.KioskCash == input.KioskCash ||
                    (this.KioskCash != null &&
                    this.KioskCash.Equals(input.KioskCash))
                ) && 
                (
                    this.KioskCashRevenue == input.KioskCashRevenue ||
                    (this.KioskCashRevenue != null &&
                    this.KioskCashRevenue.Equals(input.KioskCashRevenue))
                ) && 
                (
                    this.KioskCard == input.KioskCard ||
                    (this.KioskCard != null &&
                    this.KioskCard.Equals(input.KioskCard))
                ) && 
                (
                    this.KioskCardRevenue == input.KioskCardRevenue ||
                    (this.KioskCardRevenue != null &&
                    this.KioskCardRevenue.Equals(input.KioskCardRevenue))
                ) && 
                (
                    this.QropCash == input.QropCash ||
                    (this.QropCash != null &&
                    this.QropCash.Equals(input.QropCash))
                ) && 
                (
                    this.QropCashRevenue == input.QropCashRevenue ||
                    (this.QropCashRevenue != null &&
                    this.QropCashRevenue.Equals(input.QropCashRevenue))
                ) && 
                (
                    this.QropCard == input.QropCard ||
                    (this.QropCard != null &&
                    this.QropCard.Equals(input.QropCard))
                ) && 
                (
                    this.QropCardRevenue == input.QropCardRevenue ||
                    (this.QropCardRevenue != null &&
                    this.QropCardRevenue.Equals(input.QropCardRevenue))
                ) && 
                (
                    this.PosCard == input.PosCard ||
                    (this.PosCard != null &&
                    this.PosCard.Equals(input.PosCard))
                ) && 
                (
                    this.PosCardRevenue == input.PosCardRevenue ||
                    (this.PosCardRevenue != null &&
                    this.PosCardRevenue.Equals(input.PosCardRevenue))
                ) && 
                (
                    this.PosCardOnFlipdishOrders == input.PosCardOnFlipdishOrders ||
                    (this.PosCardOnFlipdishOrders != null &&
                    this.PosCardOnFlipdishOrders.Equals(input.PosCardOnFlipdishOrders))
                ) && 
                (
                    this.OtherIntegrationFees == input.OtherIntegrationFees ||
                    (this.OtherIntegrationFees != null &&
                    this.OtherIntegrationFees.Equals(input.OtherIntegrationFees))
                ) && 
                (
                    this.OtherIntegrationTips == input.OtherIntegrationTips ||
                    (this.OtherIntegrationTips != null &&
                    this.OtherIntegrationTips.Equals(input.OtherIntegrationTips))
                ) && 
                (
                    this.RefundedFeesOnRefundedSales == input.RefundedFeesOnRefundedSales ||
                    (this.RefundedFeesOnRefundedSales != null &&
                    this.RefundedFeesOnRefundedSales.Equals(input.RefundedFeesOnRefundedSales))
                ) && 
                (
                    this.Vat == input.Vat ||
                    (this.Vat != null &&
                    this.Vat.Equals(input.Vat))
                ) && 
                (
                    this.RefundedFeesOnPosSales == input.RefundedFeesOnPosSales ||
                    (this.RefundedFeesOnPosSales != null &&
                    this.RefundedFeesOnPosSales.Equals(input.RefundedFeesOnPosSales))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.ThirdPartyIntegrationFeesAndTips == input.ThirdPartyIntegrationFeesAndTips ||
                    (this.ThirdPartyIntegrationFeesAndTips != null &&
                    this.ThirdPartyIntegrationFeesAndTips.Equals(input.ThirdPartyIntegrationFeesAndTips))
                ) && 
                (
                    this.WebAndAppCardOnXOrders == input.WebAndAppCardOnXOrders ||
                    (this.WebAndAppCardOnXOrders != null &&
                    this.WebAndAppCardOnXOrders.Equals(input.WebAndAppCardOnXOrders))
                ) && 
                (
                    this.WebAndAppCashOnXOrders == input.WebAndAppCashOnXOrders ||
                    (this.WebAndAppCashOnXOrders != null &&
                    this.WebAndAppCashOnXOrders.Equals(input.WebAndAppCashOnXOrders))
                ) && 
                (
                    this.KioskCardOnXOrders == input.KioskCardOnXOrders ||
                    (this.KioskCardOnXOrders != null &&
                    this.KioskCardOnXOrders.Equals(input.KioskCardOnXOrders))
                ) && 
                (
                    this.KioskCashOnXOrders == input.KioskCashOnXOrders ||
                    (this.KioskCashOnXOrders != null &&
                    this.KioskCashOnXOrders.Equals(input.KioskCashOnXOrders))
                ) && 
                (
                    this.QropCardOnXOrders == input.QropCardOnXOrders ||
                    (this.QropCardOnXOrders != null &&
                    this.QropCardOnXOrders.Equals(input.QropCardOnXOrders))
                ) && 
                (
                    this.QropCashOnXOrders == input.QropCashOnXOrders ||
                    (this.QropCashOnXOrders != null &&
                    this.QropCashOnXOrders.Equals(input.QropCashOnXOrders))
                ) && 
                (
                    this.PosCardOnXOrders == input.PosCardOnXOrders ||
                    (this.PosCardOnXOrders != null &&
                    this.PosCardOnXOrders.Equals(input.PosCardOnXOrders))
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
                if (this.WebAndAppCash != null)
                    hashCode = hashCode * 59 + this.WebAndAppCash.GetHashCode();
                if (this.WebAndAppCashRevenueIncludingTips != null)
                    hashCode = hashCode * 59 + this.WebAndAppCashRevenueIncludingTips.GetHashCode();
                if (this.WebAndAppCard != null)
                    hashCode = hashCode * 59 + this.WebAndAppCard.GetHashCode();
                if (this.WebAndAppCardRevenueIncludingTips != null)
                    hashCode = hashCode * 59 + this.WebAndAppCardRevenueIncludingTips.GetHashCode();
                if (this.KioskCash != null)
                    hashCode = hashCode * 59 + this.KioskCash.GetHashCode();
                if (this.KioskCashRevenue != null)
                    hashCode = hashCode * 59 + this.KioskCashRevenue.GetHashCode();
                if (this.KioskCard != null)
                    hashCode = hashCode * 59 + this.KioskCard.GetHashCode();
                if (this.KioskCardRevenue != null)
                    hashCode = hashCode * 59 + this.KioskCardRevenue.GetHashCode();
                if (this.QropCash != null)
                    hashCode = hashCode * 59 + this.QropCash.GetHashCode();
                if (this.QropCashRevenue != null)
                    hashCode = hashCode * 59 + this.QropCashRevenue.GetHashCode();
                if (this.QropCard != null)
                    hashCode = hashCode * 59 + this.QropCard.GetHashCode();
                if (this.QropCardRevenue != null)
                    hashCode = hashCode * 59 + this.QropCardRevenue.GetHashCode();
                if (this.PosCard != null)
                    hashCode = hashCode * 59 + this.PosCard.GetHashCode();
                if (this.PosCardRevenue != null)
                    hashCode = hashCode * 59 + this.PosCardRevenue.GetHashCode();
                if (this.PosCardOnFlipdishOrders != null)
                    hashCode = hashCode * 59 + this.PosCardOnFlipdishOrders.GetHashCode();
                if (this.OtherIntegrationFees != null)
                    hashCode = hashCode * 59 + this.OtherIntegrationFees.GetHashCode();
                if (this.OtherIntegrationTips != null)
                    hashCode = hashCode * 59 + this.OtherIntegrationTips.GetHashCode();
                if (this.RefundedFeesOnRefundedSales != null)
                    hashCode = hashCode * 59 + this.RefundedFeesOnRefundedSales.GetHashCode();
                if (this.Vat != null)
                    hashCode = hashCode * 59 + this.Vat.GetHashCode();
                if (this.RefundedFeesOnPosSales != null)
                    hashCode = hashCode * 59 + this.RefundedFeesOnPosSales.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.ThirdPartyIntegrationFeesAndTips != null)
                    hashCode = hashCode * 59 + this.ThirdPartyIntegrationFeesAndTips.GetHashCode();
                if (this.WebAndAppCardOnXOrders != null)
                    hashCode = hashCode * 59 + this.WebAndAppCardOnXOrders.GetHashCode();
                if (this.WebAndAppCashOnXOrders != null)
                    hashCode = hashCode * 59 + this.WebAndAppCashOnXOrders.GetHashCode();
                if (this.KioskCardOnXOrders != null)
                    hashCode = hashCode * 59 + this.KioskCardOnXOrders.GetHashCode();
                if (this.KioskCashOnXOrders != null)
                    hashCode = hashCode * 59 + this.KioskCashOnXOrders.GetHashCode();
                if (this.QropCardOnXOrders != null)
                    hashCode = hashCode * 59 + this.QropCardOnXOrders.GetHashCode();
                if (this.QropCashOnXOrders != null)
                    hashCode = hashCode * 59 + this.QropCashOnXOrders.GetHashCode();
                if (this.PosCardOnXOrders != null)
                    hashCode = hashCode * 59 + this.PosCardOnXOrders.GetHashCode();
                return hashCode;
            }
        }
    }

}
