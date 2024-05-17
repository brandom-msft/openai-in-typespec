// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class AzureChatSearchDataSourceParameters : IUtf8JsonSerializable, IJsonModel<AzureChatSearchDataSourceParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureChatSearchDataSourceParameters>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureChatSearchDataSourceParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatSearchDataSourceParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatSearchDataSourceParameters)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Authentication);
#else
                using (JsonDocument document = JsonDocument.Parse(Authentication))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(TopNDocuments))
            {
                writer.WritePropertyName("top_n_documents"u8);
                writer.WriteNumberValue(TopNDocuments.Value);
            }
            if (Optional.IsDefined(InScope))
            {
                writer.WritePropertyName("in_scope"u8);
                writer.WriteBooleanValue(InScope.Value);
            }
            if (Optional.IsDefined(Strictness))
            {
                writer.WritePropertyName("strictness"u8);
                writer.WriteNumberValue(Strictness.Value);
            }
            if (Optional.IsDefined(RoleInformation))
            {
                writer.WritePropertyName("role_information"u8);
                writer.WriteStringValue(RoleInformation);
            }
            writer.WritePropertyName("endpoint"u8);
            writer.WriteStringValue(Endpoint.AbsoluteUri);
            writer.WritePropertyName("index_name"u8);
            writer.WriteStringValue(IndexName);
            if (Optional.IsDefined(FieldsMapping))
            {
                writer.WritePropertyName("fields_mapping"u8);
                writer.WriteObjectValue(FieldsMapping, options);
            }
            if (Optional.IsDefined(QueryType))
            {
                writer.WritePropertyName("query_type"u8);
                writer.WriteStringValue(QueryType);
            }
            if (Optional.IsDefined(SemanticConfiguration))
            {
                writer.WritePropertyName("semantic_configuration"u8);
                writer.WriteStringValue(SemanticConfiguration);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            writer.WritePropertyName("embedding_dependency"u8);
            writer.WriteObjectValue(EmbeddingDependency, options);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AzureChatSearchDataSourceParameters IJsonModel<AzureChatSearchDataSourceParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatSearchDataSourceParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatSearchDataSourceParameters)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureChatSearchDataSourceParameters(document.RootElement, options);
        }

        internal static AzureChatSearchDataSourceParameters DeserializeAzureChatSearchDataSourceParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData authentication = default;
            int? topNDocuments = default;
            bool? inScope = default;
            int? strictness = default;
            string roleInformation = default;
            Uri endpoint = default;
            string indexName = default;
            AzureChatSearchDataSourceParametersFieldsMapping fieldsMapping = default;
            string queryType = default;
            string semanticConfiguration = default;
            string filter = default;
            AzureChatDataSourceVectorizationSource embeddingDependency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authentication = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("top_n_documents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topNDocuments = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("in_scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inScope = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("strictness"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    strictness = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("role_information"u8))
                {
                    roleInformation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("index_name"u8))
                {
                    indexName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fields_mapping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fieldsMapping = AzureChatSearchDataSourceParametersFieldsMapping.DeserializeAzureChatSearchDataSourceParametersFieldsMapping(property.Value, options);
                    continue;
                }
                if (property.NameEquals("query_type"u8))
                {
                    queryType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("semantic_configuration"u8))
                {
                    semanticConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("embedding_dependency"u8))
                {
                    embeddingDependency = AzureChatDataSourceVectorizationSource.DeserializeAzureChatDataSourceVectorizationSource(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureChatSearchDataSourceParameters(
                authentication,
                topNDocuments,
                inScope,
                strictness,
                roleInformation,
                endpoint,
                indexName,
                fieldsMapping,
                queryType,
                semanticConfiguration,
                filter,
                embeddingDependency,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureChatSearchDataSourceParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatSearchDataSourceParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureChatSearchDataSourceParameters)} does not support writing '{options.Format}' format.");
            }
        }

        AzureChatSearchDataSourceParameters IPersistableModel<AzureChatSearchDataSourceParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatSearchDataSourceParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureChatSearchDataSourceParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureChatSearchDataSourceParameters)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureChatSearchDataSourceParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AzureChatSearchDataSourceParameters FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureChatSearchDataSourceParameters(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
