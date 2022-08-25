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
    /// Metafield Definition
    /// </summary>
    [DataContract]
    public partial class MetafieldDefinition :  IEquatable<MetafieldDefinition>, IValidatableObject
    {
        /// <summary>
        /// The Metafield will extend the specified {Flipdish.PublicModels.V1.Metafields.MetafieldDefinitionBase.OwnerEntity}
        /// </summary>
        /// <value>The Metafield will extend the specified {Flipdish.PublicModels.V1.Metafields.MetafieldDefinitionBase.OwnerEntity}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OwnerEntityEnum
        {
            
            /// <summary>
            /// Enum CatalogItem for value: CatalogItem
            /// </summary>
            [EnumMember(Value = "CatalogItem")]
            CatalogItem = 1,
            
            /// <summary>
            /// Enum CatalogGroup for value: CatalogGroup
            /// </summary>
            [EnumMember(Value = "CatalogGroup")]
            CatalogGroup = 2,
            
            /// <summary>
            /// Enum Menu for value: Menu
            /// </summary>
            [EnumMember(Value = "Menu")]
            Menu = 3
        }

        /// <summary>
        /// The Metafield will extend the specified {Flipdish.PublicModels.V1.Metafields.MetafieldDefinitionBase.OwnerEntity}
        /// </summary>
        /// <value>The Metafield will extend the specified {Flipdish.PublicModels.V1.Metafields.MetafieldDefinitionBase.OwnerEntity}</value>
        [DataMember(Name="OwnerEntity", EmitDefaultValue=false)]
        public OwnerEntityEnum? OwnerEntity { get; set; }
        /// <summary>
        /// The excepted type for the Value field
        /// </summary>
        /// <value>The excepted type for the Value field</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum
        {
            
            /// <summary>
            /// Enum Json for value: Json
            /// </summary>
            [EnumMember(Value = "Json")]
            Json = 1,
            
            /// <summary>
            /// Enum SingleLineString for value: SingleLineString
            /// </summary>
            [EnumMember(Value = "SingleLineString")]
            SingleLineString = 2,
            
            /// <summary>
            /// Enum MultiLineString for value: MultiLineString
            /// </summary>
            [EnumMember(Value = "MultiLineString")]
            MultiLineString = 3
        }

        /// <summary>
        /// The excepted type for the Value field
        /// </summary>
        /// <value>The excepted type for the Value field</value>
        [DataMember(Name="ValueType", EmitDefaultValue=false)]
        public ValueTypeEnum? ValueType { get; set; }
        /// <summary>
        /// Defines Behaviors
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BehaviorsEnum
        {
            
            /// <summary>
            /// Enum SendToOrder for value: SendToOrder
            /// </summary>
            [EnumMember(Value = "SendToOrder")]
            SendToOrder = 1,
            
            /// <summary>
            /// Enum SendToMenu for value: SendToMenu
            /// </summary>
            [EnumMember(Value = "SendToMenu")]
            SendToMenu = 2
        }


        /// <summary>
        /// Enable Metafield Behaviors
        /// </summary>
        /// <value>Enable Metafield Behaviors</value>
        [DataMember(Name="Behaviors", EmitDefaultValue=false)]
        public List<BehaviorsEnum> Behaviors { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetafieldDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetafieldDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetafieldDefinition" /> class.
        /// </summary>
        /// <param name="isReadOnly">Indicates if a definition can be edited or not.</param>
        /// <param name="ownerEntity">The Metafield will extend the specified {Flipdish.PublicModels.V1.Metafields.MetafieldDefinitionBase.OwnerEntity}.</param>
        /// <param name="key">Key of the metafield.  The key must have two parts, separated by a dot. The first part acts as a category, for organizational purposes.  The parts can be composed of lowercase letters, numbers, hyphen and underscore (required).</param>
        /// <param name="valueType">The excepted type for the Value field.</param>
        /// <param name="name">Field Name (required).</param>
        /// <param name="description">Field Description.</param>
        /// <param name="behaviors">Enable Metafield Behaviors.</param>
        /// <param name="metafieldDefinitionRecommendationId">Metafield Recommendation Id.</param>
        public MetafieldDefinition(bool? isReadOnly = default(bool?), OwnerEntityEnum? ownerEntity = default(OwnerEntityEnum?), string key = default(string), ValueTypeEnum? valueType = default(ValueTypeEnum?), string name = default(string), string description = default(string), List<BehaviorsEnum> behaviors = default(List<BehaviorsEnum>), int? metafieldDefinitionRecommendationId = default(int?))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for MetafieldDefinition and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for MetafieldDefinition and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.IsReadOnly = isReadOnly;
            this.OwnerEntity = ownerEntity;
            this.ValueType = valueType;
            this.Description = description;
            this.Behaviors = behaviors;
            this.MetafieldDefinitionRecommendationId = metafieldDefinitionRecommendationId;
        }
        
        /// <summary>
        /// Indicates if a definition can be edited or not
        /// </summary>
        /// <value>Indicates if a definition can be edited or not</value>
        [DataMember(Name="IsReadOnly", EmitDefaultValue=false)]
        public bool? IsReadOnly { get; set; }


        /// <summary>
        /// Key of the metafield.  The key must have two parts, separated by a dot. The first part acts as a category, for organizational purposes.  The parts can be composed of lowercase letters, numbers, hyphen and underscore
        /// </summary>
        /// <value>Key of the metafield.  The key must have two parts, separated by a dot. The first part acts as a category, for organizational purposes.  The parts can be composed of lowercase letters, numbers, hyphen and underscore</value>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public string Key { get; set; }


        /// <summary>
        /// Field Name
        /// </summary>
        /// <value>Field Name</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Field Description
        /// </summary>
        /// <value>Field Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Metafield Recommendation Id
        /// </summary>
        /// <value>Metafield Recommendation Id</value>
        [DataMember(Name="MetafieldDefinitionRecommendationId", EmitDefaultValue=false)]
        public int? MetafieldDefinitionRecommendationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetafieldDefinition {\n");
            sb.Append("  IsReadOnly: ").Append(IsReadOnly).Append("\n");
            sb.Append("  OwnerEntity: ").Append(OwnerEntity).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
            sb.Append("  MetafieldDefinitionRecommendationId: ").Append(MetafieldDefinitionRecommendationId).Append("\n");
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
            return this.Equals(input as MetafieldDefinition);
        }

        /// <summary>
        /// Returns true if MetafieldDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of MetafieldDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetafieldDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsReadOnly == input.IsReadOnly ||
                    (this.IsReadOnly != null &&
                    this.IsReadOnly.Equals(input.IsReadOnly))
                ) && 
                (
                    this.OwnerEntity == input.OwnerEntity ||
                    (this.OwnerEntity != null &&
                    this.OwnerEntity.Equals(input.OwnerEntity))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Behaviors == input.Behaviors ||
                    this.Behaviors != null &&
                    this.Behaviors.SequenceEqual(input.Behaviors)
                ) && 
                (
                    this.MetafieldDefinitionRecommendationId == input.MetafieldDefinitionRecommendationId ||
                    (this.MetafieldDefinitionRecommendationId != null &&
                    this.MetafieldDefinitionRecommendationId.Equals(input.MetafieldDefinitionRecommendationId))
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
                if (this.IsReadOnly != null)
                    hashCode = hashCode * 59 + this.IsReadOnly.GetHashCode();
                if (this.OwnerEntity != null)
                    hashCode = hashCode * 59 + this.OwnerEntity.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Behaviors != null)
                    hashCode = hashCode * 59 + this.Behaviors.GetHashCode();
                if (this.MetafieldDefinitionRecommendationId != null)
                    hashCode = hashCode * 59 + this.MetafieldDefinitionRecommendationId.GetHashCode();
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
