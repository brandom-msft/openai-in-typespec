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
    internal partial class UnknownAzureChatDataSourceAuthenticationOptions : IUtf8JsonSerializable, IJsonModel<AzureChatDataSourceAuthenticationOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureChatDataSourceAuthenticationOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureChatDataSourceAuthenticationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatDataSourceAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatDataSourceAuthenticationOptions)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
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

        AzureChatDataSourceAuthenticationOptions IJsonModel<AzureChatDataSourceAuthenticationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatDataSourceAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatDataSourceAuthenticationOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureChatDataSourceAuthenticationOptions(document.RootElement, options);
        }

        internal static UnknownAzureChatDataSourceAuthenticationOptions DeserializeUnknownAzureChatDataSourceAuthenticationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownAzureChatDataSourceAuthenticationOptions(type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureChatDataSourceAuthenticationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatDataSourceAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureChatDataSourceAuthenticationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        AzureChatDataSourceAuthenticationOptions IPersistableModel<AzureChatDataSourceAuthenticationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatDataSourceAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureChatDataSourceAuthenticationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureChatDataSourceAuthenticationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureChatDataSourceAuthenticationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new UnknownAzureChatDataSourceAuthenticationOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnknownAzureChatDataSourceAuthenticationOptions(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<AzureChatDataSourceAuthenticationOptions>(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
