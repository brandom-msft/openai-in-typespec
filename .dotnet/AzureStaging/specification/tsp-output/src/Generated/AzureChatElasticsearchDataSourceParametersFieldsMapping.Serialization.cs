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
    public partial class AzureChatElasticsearchDataSourceParametersFieldsMapping : IUtf8JsonSerializable, IJsonModel<AzureChatElasticsearchDataSourceParametersFieldsMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureChatElasticsearchDataSourceParametersFieldsMapping>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureChatElasticsearchDataSourceParametersFieldsMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatElasticsearchDataSourceParametersFieldsMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatElasticsearchDataSourceParametersFieldsMapping)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TitleField))
            {
                writer.WritePropertyName("title_field"u8);
                writer.WriteStringValue(TitleField);
            }
            if (Optional.IsDefined(UrlField))
            {
                writer.WritePropertyName("url_field"u8);
                writer.WriteStringValue(UrlField);
            }
            if (Optional.IsDefined(FilepathField))
            {
                writer.WritePropertyName("filepath_field"u8);
                writer.WriteStringValue(FilepathField);
            }
            if (Optional.IsCollectionDefined(ContentFields))
            {
                writer.WritePropertyName("content_fields"u8);
                writer.WriteStartArray();
                foreach (var item in ContentFields)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContentFieldsSeparator))
            {
                writer.WritePropertyName("content_fields_separator"u8);
                writer.WriteStringValue(ContentFieldsSeparator);
            }
            if (Optional.IsCollectionDefined(VectorFields))
            {
                writer.WritePropertyName("vector_fields"u8);
                writer.WriteStartArray();
                foreach (var item in VectorFields)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        AzureChatElasticsearchDataSourceParametersFieldsMapping IJsonModel<AzureChatElasticsearchDataSourceParametersFieldsMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatElasticsearchDataSourceParametersFieldsMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatElasticsearchDataSourceParametersFieldsMapping)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureChatElasticsearchDataSourceParametersFieldsMapping(document.RootElement, options);
        }

        internal static AzureChatElasticsearchDataSourceParametersFieldsMapping DeserializeAzureChatElasticsearchDataSourceParametersFieldsMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string titleField = default;
            string urlField = default;
            string filepathField = default;
            IReadOnlyList<string> contentFields = default;
            string contentFieldsSeparator = default;
            IReadOnlyList<string> vectorFields = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title_field"u8))
                {
                    titleField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url_field"u8))
                {
                    urlField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filepath_field"u8))
                {
                    filepathField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content_fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contentFields = array;
                    continue;
                }
                if (property.NameEquals("content_fields_separator"u8))
                {
                    contentFieldsSeparator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vector_fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vectorFields = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureChatElasticsearchDataSourceParametersFieldsMapping(
                titleField,
                urlField,
                filepathField,
                contentFields ?? new ChangeTrackingList<string>(),
                contentFieldsSeparator,
                vectorFields ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureChatElasticsearchDataSourceParametersFieldsMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatElasticsearchDataSourceParametersFieldsMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureChatElasticsearchDataSourceParametersFieldsMapping)} does not support writing '{options.Format}' format.");
            }
        }

        AzureChatElasticsearchDataSourceParametersFieldsMapping IPersistableModel<AzureChatElasticsearchDataSourceParametersFieldsMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatElasticsearchDataSourceParametersFieldsMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureChatElasticsearchDataSourceParametersFieldsMapping(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureChatElasticsearchDataSourceParametersFieldsMapping)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureChatElasticsearchDataSourceParametersFieldsMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AzureChatElasticsearchDataSourceParametersFieldsMapping FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureChatElasticsearchDataSourceParametersFieldsMapping(document.RootElement);
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
