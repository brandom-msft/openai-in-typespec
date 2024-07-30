// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI.Chat;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuneChatCompletionRequestAssistantMessage : IJsonModel<InternalFineTuneChatCompletionRequestAssistantMessage>
    {
        void IJsonModel<InternalFineTuneChatCompletionRequestAssistantMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFineTuneChatCompletionRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFineTuneChatCompletionRequestAssistantMessage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("name") != true && Optional.IsDefined(ParticipantName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(ParticipantName);
            }
            if (SerializedAdditionalRawData?.ContainsKey("tool_calls") != true && Optional.IsCollectionDefined(ToolCalls))
            {
                writer.WritePropertyName("tool_calls"u8);
                writer.WriteStartArray();
                foreach (var item in ToolCalls)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("function_call") != true && Optional.IsDefined(FunctionCall))
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
            if (SerializedAdditionalRawData?.ContainsKey("role") != true)
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role);
            }
            if (SerializedAdditionalRawData?.ContainsKey("content") != true && Optional.IsCollectionDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                SerializeContentValue(writer, options);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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

        InternalFineTuneChatCompletionRequestAssistantMessage IJsonModel<InternalFineTuneChatCompletionRequestAssistantMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFineTuneChatCompletionRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFineTuneChatCompletionRequestAssistantMessage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalFineTuneChatCompletionRequestAssistantMessage(document.RootElement, options);
        }

        internal static InternalFineTuneChatCompletionRequestAssistantMessage DeserializeInternalFineTuneChatCompletionRequestAssistantMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<ChatToolCall> toolCalls = default;
            ChatFunctionCall functionCall = default;
            string role = default;
            IList<ChatMessageContentPart> content = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tool_calls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChatToolCall> array = new List<ChatToolCall>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatToolCall.DeserializeChatToolCall(item, options));
                    }
                    toolCalls = array;
                    continue;
                }
                if (property.NameEquals("function_call"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        functionCall = null;
                        continue;
                    }
                    functionCall = ChatFunctionCall.DeserializeChatFunctionCall(property.Value, options);
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    DeserializeContentValue(property, ref content);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalFineTuneChatCompletionRequestAssistantMessage(
                role,
                content ?? new ChangeTrackingList<ChatMessageContentPart>(),
                serializedAdditionalRawData,
                name,
                toolCalls ?? new ChangeTrackingList<ChatToolCall>(),
                functionCall);
        }

        BinaryData IPersistableModel<InternalFineTuneChatCompletionRequestAssistantMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFineTuneChatCompletionRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalFineTuneChatCompletionRequestAssistantMessage)} does not support writing '{options.Format}' format.");
            }
        }

        InternalFineTuneChatCompletionRequestAssistantMessage IPersistableModel<InternalFineTuneChatCompletionRequestAssistantMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFineTuneChatCompletionRequestAssistantMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalFineTuneChatCompletionRequestAssistantMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalFineTuneChatCompletionRequestAssistantMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalFineTuneChatCompletionRequestAssistantMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new InternalFineTuneChatCompletionRequestAssistantMessage FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalFineTuneChatCompletionRequestAssistantMessage(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
