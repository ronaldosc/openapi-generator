// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Zebra
    /// </summary>
    public partial class Zebra : Dictionary<String, Object>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Zebra" /> class.
        /// </summary>
        /// <param name="className">className</param>
        /// <param name="type">type</param>
        [JsonConstructor]
        public Zebra(string className, TypeEnum type) : base()
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (type == null)
                throw new ArgumentNullException("type is a required property for Zebra and cannot be null.");

            if (className == null)
                throw new ArgumentNullException("className is a required property for Zebra and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            ClassName = className;
            Type = type;
        }

        /// <summary>
        /// Defines Type
        /// </summary>
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Plains for value: plains
            /// </summary>
            Plains = 1,

            /// <summary>
            /// Enum Mountain for value: mountain
            /// </summary>
            Mountain = 2,

            /// <summary>
            /// Enum Grevys for value: grevys
            /// </summary>
            Grevys = 3

        }

        /// <summary>
        /// Returns a TypeEnum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value == "plains")
                return TypeEnum.Plains;

            if (value == "mountain")
                return TypeEnum.Mountain;

            if (value == "grevys")
                return TypeEnum.Grevys;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns equivalent json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string TypeEnumToJsonValue(TypeEnum value)
        {
            if (value == TypeEnum.Plains)
                return "plains";

            if (value == TypeEnum.Mountain)
                return "mountain";

            if (value == TypeEnum.Grevys)
                return "grevys";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [JsonPropertyName("className")]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Zebra {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type Zebra
    /// </summary>
    public class ZebraJsonConverter : JsonConverter<Zebra>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Zebra Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string className = default;
            Zebra.TypeEnum type = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "className":
                            className = utf8JsonReader.GetString();
                            break;
                        case "type":
                            string typeRawValue = utf8JsonReader.GetString();
                            type = Zebra.TypeEnumFromString(typeRawValue);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new Zebra(className, type);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="zebra"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Zebra zebra, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("className", zebra.ClassName);
            var typeRawValue = Zebra.TypeEnumToJsonValue(zebra.Type);
            if (typeRawValue != null)
                writer.WriteString("type", typeRawValue);
            else
                writer.WriteNull("type");

            writer.WriteEndObject();
        }
    }
}
