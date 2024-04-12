// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class RunStepDetailsMessageCreationObjectMessageCreation : IJsonModel<RunStepDetailsMessageCreationObjectMessageCreation>
    {
        void IJsonModel<RunStepDetailsMessageCreationObjectMessageCreation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDetailsMessageCreationObjectMessageCreation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepDetailsMessageCreationObjectMessageCreation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("message_id"u8);
            writer.WriteStringValue(MessageId);
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

        RunStepDetailsMessageCreationObjectMessageCreation IJsonModel<RunStepDetailsMessageCreationObjectMessageCreation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDetailsMessageCreationObjectMessageCreation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepDetailsMessageCreationObjectMessageCreation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStepDetailsMessageCreationObjectMessageCreation(document.RootElement, options);
        }

        internal static RunStepDetailsMessageCreationObjectMessageCreation DeserializeRunStepDetailsMessageCreationObjectMessageCreation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string messageId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message_id"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RunStepDetailsMessageCreationObjectMessageCreation(messageId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunStepDetailsMessageCreationObjectMessageCreation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDetailsMessageCreationObjectMessageCreation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunStepDetailsMessageCreationObjectMessageCreation)} does not support writing '{options.Format}' format.");
            }
        }

        RunStepDetailsMessageCreationObjectMessageCreation IPersistableModel<RunStepDetailsMessageCreationObjectMessageCreation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDetailsMessageCreationObjectMessageCreation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunStepDetailsMessageCreationObjectMessageCreation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStepDetailsMessageCreationObjectMessageCreation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStepDetailsMessageCreationObjectMessageCreation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static RunStepDetailsMessageCreationObjectMessageCreation FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRunStepDetailsMessageCreationObjectMessageCreation(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual BinaryContent ToBinaryBody()
        {
            return BinaryContent.Create(this, new ModelReaderWriterOptions("W"));
        }
    }
}
