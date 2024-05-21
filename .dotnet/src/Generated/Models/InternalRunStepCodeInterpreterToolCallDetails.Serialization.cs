// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepCodeInterpreterToolCallDetails : IJsonModel<InternalRunStepCodeInterpreterToolCallDetails>
    {
        void IJsonModel<InternalRunStepCodeInterpreterToolCallDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepCodeInterpreterToolCallDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("code_interpreter"u8);
            writer.WriteObjectValue<InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter>(_codeInterpreter, options);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
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

        InternalRunStepCodeInterpreterToolCallDetails IJsonModel<InternalRunStepCodeInterpreterToolCallDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepCodeInterpreterToolCallDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepCodeInterpreterToolCallDetails(document.RootElement, options);
        }

        internal static InternalRunStepCodeInterpreterToolCallDetails DeserializeInternalRunStepCodeInterpreterToolCallDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter codeInterpreter = default;
            string type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("code_interpreter"u8))
                {
                    codeInterpreter = InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter.DeserializeInternalRunStepDetailsToolCallsCodeObjectCodeInterpreter(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalRunStepCodeInterpreterToolCallDetails(type, serializedAdditionalRawData, id, codeInterpreter);
        }

        BinaryData IPersistableModel<InternalRunStepCodeInterpreterToolCallDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepCodeInterpreterToolCallDetails)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepCodeInterpreterToolCallDetails IPersistableModel<InternalRunStepCodeInterpreterToolCallDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepCodeInterpreterToolCallDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalRunStepCodeInterpreterToolCallDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepCodeInterpreterToolCallDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepCodeInterpreterToolCallDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static new InternalRunStepCodeInterpreterToolCallDetails FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRunStepCodeInterpreterToolCallDetails(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}

