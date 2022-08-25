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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Job Delivery
    /// </summary>
    [DataContract]
    public partial class JobDelivery :  IEquatable<JobDelivery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobDelivery" /> class.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="status">Status.</param>
        /// <param name="pickedAt">Picked At.</param>
        /// <param name="deliveredAt">Delivered At.</param>
        /// <param name="trackingUrl">Tracking Url.</param>
        /// <param name="clientReference">Client Reference.</param>
        /// <param name="packageDescription">Package Description.</param>
        /// <param name="packageType">Package Type.</param>
        /// <param name="pickup">Pickup.</param>
        /// <param name="dropoff">Dropoff.</param>
        /// <param name="eta">Eta.</param>
        /// <param name="cancellation">Cancellation.</param>
        /// <param name="proof">Proof.</param>
        public JobDelivery(int? id = default(int?), string status = default(string), string pickedAt = default(string), string deliveredAt = default(string), string trackingUrl = default(string), string clientReference = default(string), string packageDescription = default(string), string packageType = default(string), JobDeliveryDetail pickup = default(JobDeliveryDetail), JobDeliveryDetail dropoff = default(JobDeliveryDetail), JobEta eta = default(JobEta), JobCancellation cancellation = default(JobCancellation), JobProof proof = default(JobProof))
        {
            this.Id = id;
            this.Status = status;
            this.PickedAt = pickedAt;
            this.DeliveredAt = deliveredAt;
            this.TrackingUrl = trackingUrl;
            this.ClientReference = clientReference;
            this.PackageDescription = packageDescription;
            this.PackageType = packageType;
            this.Pickup = pickup;
            this.Dropoff = dropoff;
            this.Eta = eta;
            this.Cancellation = cancellation;
            this.Proof = proof;
        }
        
        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Picked At
        /// </summary>
        /// <value>Picked At</value>
        [DataMember(Name="PickedAt", EmitDefaultValue=false)]
        public string PickedAt { get; set; }

        /// <summary>
        /// Delivered At
        /// </summary>
        /// <value>Delivered At</value>
        [DataMember(Name="DeliveredAt", EmitDefaultValue=false)]
        public string DeliveredAt { get; set; }

        /// <summary>
        /// Tracking Url
        /// </summary>
        /// <value>Tracking Url</value>
        [DataMember(Name="TrackingUrl", EmitDefaultValue=false)]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Client Reference
        /// </summary>
        /// <value>Client Reference</value>
        [DataMember(Name="ClientReference", EmitDefaultValue=false)]
        public string ClientReference { get; set; }

        /// <summary>
        /// Package Description
        /// </summary>
        /// <value>Package Description</value>
        [DataMember(Name="PackageDescription", EmitDefaultValue=false)]
        public string PackageDescription { get; set; }

        /// <summary>
        /// Package Type
        /// </summary>
        /// <value>Package Type</value>
        [DataMember(Name="PackageType", EmitDefaultValue=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// Pickup
        /// </summary>
        /// <value>Pickup</value>
        [DataMember(Name="Pickup", EmitDefaultValue=false)]
        public JobDeliveryDetail Pickup { get; set; }

        /// <summary>
        /// Dropoff
        /// </summary>
        /// <value>Dropoff</value>
        [DataMember(Name="Dropoff", EmitDefaultValue=false)]
        public JobDeliveryDetail Dropoff { get; set; }

        /// <summary>
        /// Eta
        /// </summary>
        /// <value>Eta</value>
        [DataMember(Name="Eta", EmitDefaultValue=false)]
        public JobEta Eta { get; set; }

        /// <summary>
        /// Cancellation
        /// </summary>
        /// <value>Cancellation</value>
        [DataMember(Name="Cancellation", EmitDefaultValue=false)]
        public JobCancellation Cancellation { get; set; }

        /// <summary>
        /// Proof
        /// </summary>
        /// <value>Proof</value>
        [DataMember(Name="Proof", EmitDefaultValue=false)]
        public JobProof Proof { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobDelivery {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PickedAt: ").Append(PickedAt).Append("\n");
            sb.Append("  DeliveredAt: ").Append(DeliveredAt).Append("\n");
            sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
            sb.Append("  ClientReference: ").Append(ClientReference).Append("\n");
            sb.Append("  PackageDescription: ").Append(PackageDescription).Append("\n");
            sb.Append("  PackageType: ").Append(PackageType).Append("\n");
            sb.Append("  Pickup: ").Append(Pickup).Append("\n");
            sb.Append("  Dropoff: ").Append(Dropoff).Append("\n");
            sb.Append("  Eta: ").Append(Eta).Append("\n");
            sb.Append("  Cancellation: ").Append(Cancellation).Append("\n");
            sb.Append("  Proof: ").Append(Proof).Append("\n");
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
            return this.Equals(input as JobDelivery);
        }

        /// <summary>
        /// Returns true if JobDelivery instances are equal
        /// </summary>
        /// <param name="input">Instance of JobDelivery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobDelivery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PickedAt == input.PickedAt ||
                    (this.PickedAt != null &&
                    this.PickedAt.Equals(input.PickedAt))
                ) && 
                (
                    this.DeliveredAt == input.DeliveredAt ||
                    (this.DeliveredAt != null &&
                    this.DeliveredAt.Equals(input.DeliveredAt))
                ) && 
                (
                    this.TrackingUrl == input.TrackingUrl ||
                    (this.TrackingUrl != null &&
                    this.TrackingUrl.Equals(input.TrackingUrl))
                ) && 
                (
                    this.ClientReference == input.ClientReference ||
                    (this.ClientReference != null &&
                    this.ClientReference.Equals(input.ClientReference))
                ) && 
                (
                    this.PackageDescription == input.PackageDescription ||
                    (this.PackageDescription != null &&
                    this.PackageDescription.Equals(input.PackageDescription))
                ) && 
                (
                    this.PackageType == input.PackageType ||
                    (this.PackageType != null &&
                    this.PackageType.Equals(input.PackageType))
                ) && 
                (
                    this.Pickup == input.Pickup ||
                    (this.Pickup != null &&
                    this.Pickup.Equals(input.Pickup))
                ) && 
                (
                    this.Dropoff == input.Dropoff ||
                    (this.Dropoff != null &&
                    this.Dropoff.Equals(input.Dropoff))
                ) && 
                (
                    this.Eta == input.Eta ||
                    (this.Eta != null &&
                    this.Eta.Equals(input.Eta))
                ) && 
                (
                    this.Cancellation == input.Cancellation ||
                    (this.Cancellation != null &&
                    this.Cancellation.Equals(input.Cancellation))
                ) && 
                (
                    this.Proof == input.Proof ||
                    (this.Proof != null &&
                    this.Proof.Equals(input.Proof))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PickedAt != null)
                    hashCode = hashCode * 59 + this.PickedAt.GetHashCode();
                if (this.DeliveredAt != null)
                    hashCode = hashCode * 59 + this.DeliveredAt.GetHashCode();
                if (this.TrackingUrl != null)
                    hashCode = hashCode * 59 + this.TrackingUrl.GetHashCode();
                if (this.ClientReference != null)
                    hashCode = hashCode * 59 + this.ClientReference.GetHashCode();
                if (this.PackageDescription != null)
                    hashCode = hashCode * 59 + this.PackageDescription.GetHashCode();
                if (this.PackageType != null)
                    hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.Pickup != null)
                    hashCode = hashCode * 59 + this.Pickup.GetHashCode();
                if (this.Dropoff != null)
                    hashCode = hashCode * 59 + this.Dropoff.GetHashCode();
                if (this.Eta != null)
                    hashCode = hashCode * 59 + this.Eta.GetHashCode();
                if (this.Cancellation != null)
                    hashCode = hashCode * 59 + this.Cancellation.GetHashCode();
                if (this.Proof != null)
                    hashCode = hashCode * 59 + this.Proof.GetHashCode();
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
