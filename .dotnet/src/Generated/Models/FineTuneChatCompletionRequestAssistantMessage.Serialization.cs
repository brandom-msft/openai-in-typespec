// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class FineTuneChatCompletionRequestAssistantMessage : IJsonModel<FineTuneChatCompletionRequestAssistantMessage>
    {
        void IJsonModel<FineTuneChatCompletionRequestAssistantMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuneChatCompletionRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FineTuneChatCompletionRequestAssistantMessage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Content))
            {
                if (Content != null)
                {
                    writer.WritePropertyName("content"u8);
                    writer.WriteStringValue(Content);
                }
                else
                {
                    writer.WriteNull("content");
                }
            }
            writer.WritePropertyName("role"u8);
            writer.WriteStringValue(Role);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(FunctionCall))
            {
                if (FunctionCall != null)
                {
                    writer.WritePropertyName("function_call"u8);
                    writer.WriteObjectValue(FunctionCall, options);
                }
                else
                {
                    writer.WriteNull("function_call");
                }
            }
            if (Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteStringValue(Weight);
            }
            if (true && _serializedAdditionalRawData != null)
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

        FineTuneChatCompletionRequestAssistantMessage IJsonModel<FineTuneChatCompletionRequestAssistantMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuneChatCompletionRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FineTuneChatCompletionRequestAssistantMessage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFineTuneChatCompletionRequestAssistantMessage(document.RootElement, options);
        }

        internal static FineTuneChatCompletionRequestAssistantMessage DeserializeFineTuneChatCompletionRequestAssistantMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string content = default;
            string role = default;
            string name = default;
            FineTuneChatCompletionRequestAssistantMessageFunctionCall functionCall = default;
            string weight = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        content = null;
                        continue;
                    }
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("function_call"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        functionCall = null;
                        continue;
                    }
                    functionCall = FineTuneChatCompletionRequestAssistantMessageFunctionCall.DeserializeFineTuneChatCompletionRequestAssistantMessageFunctionCall(property.Value, options);
                    continue;
                }
                if (property.NameEquals("weight"u8))
                {
                    weight = property.Value.GetString();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FineTuneChatCompletionRequestAssistantMessage(
                content,
                role,
                name,
                functionCall,
                weight,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FineTuneChatCompletionRequestAssistantMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuneChatCompletionRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FineTuneChatCompletionRequestAssistantMessage)} does not support writing '{options.Format}' format.");
            }
        }

        FineTuneChatCompletionRequestAssistantMessage IPersistableModel<FineTuneChatCompletionRequestAssistantMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FineTuneChatCompletionRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFineTuneChatCompletionRequestAssistantMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FineTuneChatCompletionRequestAssistantMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FineTuneChatCompletionRequestAssistantMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static FineTuneChatCompletionRequestAssistantMessage FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFineTuneChatCompletionRequestAssistantMessage(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
