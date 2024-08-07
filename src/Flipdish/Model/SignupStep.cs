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
    /// SignupStep
    /// </summary>
    [DataContract]
    public partial class SignupStep :  IEquatable<SignupStep>
    {
        /// <summary>
        /// Action needs to take
        /// </summary>
        /// <value>Action needs to take</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Question for value: Question
            /// </summary>
            [EnumMember(Value = "Question")]
            Question = 1,
            
            /// <summary>
            /// Enum StoreLocation for value: StoreLocation
            /// </summary>
            [EnumMember(Value = "StoreLocation")]
            StoreLocation = 2,
            
            /// <summary>
            /// Enum PaymentSubscription for value: PaymentSubscription
            /// </summary>
            [EnumMember(Value = "PaymentSubscription")]
            PaymentSubscription = 3,
            
            /// <summary>
            /// Enum StoreName for value: StoreName
            /// </summary>
            [EnumMember(Value = "StoreName")]
            StoreName = 4
        }

        /// <summary>
        /// Action needs to take
        /// </summary>
        /// <value>Action needs to take</value>
        [DataMember(Name="Action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignupStep" /> class.
        /// </summary>
        /// <param name="action">Action needs to take.</param>
        /// <param name="question">Question in case Action &#x3D;&#x3D; Question.</param>
        /// <param name="predefinedAnswers">Predefined answer in case Action &#x3D;&#x3D; Question.</param>
        public SignupStep(ActionEnum? action = default(ActionEnum?), string question = default(string), List<PredefinedAnswer> predefinedAnswers = default(List<PredefinedAnswer>))
        {
            this.Action = action;
            this.Question = question;
            this.PredefinedAnswers = predefinedAnswers;
        }
        

        /// <summary>
        /// Question in case Action &#x3D;&#x3D; Question
        /// </summary>
        /// <value>Question in case Action &#x3D;&#x3D; Question</value>
        [DataMember(Name="Question", EmitDefaultValue=false)]
        public string Question { get; set; }

        /// <summary>
        /// Predefined answer in case Action &#x3D;&#x3D; Question
        /// </summary>
        /// <value>Predefined answer in case Action &#x3D;&#x3D; Question</value>
        [DataMember(Name="PredefinedAnswers", EmitDefaultValue=false)]
        public List<PredefinedAnswer> PredefinedAnswers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignupStep {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
            sb.Append("  PredefinedAnswers: ").Append(PredefinedAnswers).Append("\n");
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
            return this.Equals(input as SignupStep);
        }

        /// <summary>
        /// Returns true if SignupStep instances are equal
        /// </summary>
        /// <param name="input">Instance of SignupStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignupStep input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Question == input.Question ||
                    (this.Question != null &&
                    this.Question.Equals(input.Question))
                ) && 
                (
                    this.PredefinedAnswers == input.PredefinedAnswers ||
                    this.PredefinedAnswers != null &&
                    this.PredefinedAnswers.SequenceEqual(input.PredefinedAnswers)
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Question != null)
                    hashCode = hashCode * 59 + this.Question.GetHashCode();
                if (this.PredefinedAnswers != null)
                    hashCode = hashCode * 59 + this.PredefinedAnswers.GetHashCode();
                return hashCode;
            }
        }
    }

}
