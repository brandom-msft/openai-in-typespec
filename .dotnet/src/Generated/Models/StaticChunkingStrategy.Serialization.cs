// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class StaticChunkingStrategy : IJsonModel<StaticChunkingStrategy>
    {
        void IJsonModel<StaticChunkingStrategy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticChunkingStrategy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("max_chunk_size_tokens"u8);
            writer.WriteNumberValue(MaxChunkSizeTokens);
            writer.WritePropertyName("chunk_overlap_tokens"u8);
            writer.WriteNumberValue(ChunkOverlapTokens);
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

        StaticChunkingStrategy IJsonModel<StaticChunkingStrategy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticChunkingStrategy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticChunkingStrategy(document.RootElement, options);
        }

        internal static StaticChunkingStrategy DeserializeStaticChunkingStrategy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int maxChunkSizeTokens = default;
            int chunkOverlapTokens = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("max_chunk_size_tokens"u8))
                {
                    maxChunkSizeTokens = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("chunk_overlap_tokens"u8))
                {
                    chunkOverlapTokens = property.Value.GetInt32();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StaticChunkingStrategy(maxChunkSizeTokens, chunkOverlapTokens, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StaticChunkingStrategy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StaticChunkingStrategy)} does not support writing '{options.Format}' format.");
            }
        }

        StaticChunkingStrategy IPersistableModel<StaticChunkingStrategy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStaticChunkingStrategy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StaticChunkingStrategy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StaticChunkingStrategy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static StaticChunkingStrategy FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeStaticChunkingStrategy(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
