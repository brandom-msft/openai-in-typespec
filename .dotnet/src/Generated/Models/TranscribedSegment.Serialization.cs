// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Audio
{
    public partial struct TranscribedSegment : IJsonModel<TranscribedSegment>, IJsonModel<object>
    {
        void IJsonModel<TranscribedSegment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranscribedSegment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranscribedSegment)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("id") != true)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id);
            }
            if (SerializedAdditionalRawData?.ContainsKey("seek") != true)
            {
                writer.WritePropertyName("seek"u8);
                writer.WriteNumberValue(SeekOffset);
            }
            if (SerializedAdditionalRawData?.ContainsKey("start") != true)
            {
                writer.WritePropertyName("start"u8);
                writer.WriteNumberValue(Convert.ToDouble(Start.ToString("s\\.FFF")));
            }
            if (SerializedAdditionalRawData?.ContainsKey("end") != true)
            {
                writer.WritePropertyName("end"u8);
                writer.WriteNumberValue(Convert.ToDouble(End.ToString("s\\.FFF")));
            }
            if (SerializedAdditionalRawData?.ContainsKey("text") != true)
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(Text);
            }
            if (SerializedAdditionalRawData?.ContainsKey("tokens") != true)
            {
                writer.WritePropertyName("tokens"u8);
                writer.WriteStartArray();
                foreach (var item in TokenIds)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("temperature") != true)
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature);
            }
            if (SerializedAdditionalRawData?.ContainsKey("avg_logprob") != true)
            {
                writer.WritePropertyName("avg_logprob"u8);
                writer.WriteNumberValue(AverageLogProbability);
            }
            if (SerializedAdditionalRawData?.ContainsKey("compression_ratio") != true)
            {
                writer.WritePropertyName("compression_ratio"u8);
                writer.WriteNumberValue(CompressionRatio);
            }
            if (SerializedAdditionalRawData?.ContainsKey("no_speech_prob") != true)
            {
                writer.WritePropertyName("no_speech_prob"u8);
                writer.WriteNumberValue(NoSpeechProbability);
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

        TranscribedSegment IJsonModel<TranscribedSegment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranscribedSegment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranscribedSegment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTranscribedSegment(document.RootElement, options);
        }

        void IJsonModel<object>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TranscribedSegment>)this).Write(writer, options);

        object IJsonModel<object>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TranscribedSegment>)this).Create(ref reader, options);

        internal static TranscribedSegment DeserializeTranscribedSegment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            int id = default;
            long seek = default;
            TimeSpan start = default;
            TimeSpan end = default;
            string text = default;
            IReadOnlyList<long> tokens = default;
            float temperature = default;
            double avgLogprob = default;
            float compressionRatio = default;
            double noSpeechProb = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("seek"u8))
                {
                    seek = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    start = TimeSpan.FromSeconds(property.Value.GetDouble());
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    end = TimeSpan.FromSeconds(property.Value.GetDouble());
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokens"u8))
                {
                    List<long> array = new List<long>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt64());
                    }
                    tokens = array;
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    temperature = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("avg_logprob"u8))
                {
                    avgLogprob = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("compression_ratio"u8))
                {
                    compressionRatio = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("no_speech_prob"u8))
                {
                    noSpeechProb = property.Value.GetDouble();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TranscribedSegment(
                id,
                seek,
                start,
                end,
                text,
                tokens,
                temperature,
                avgLogprob,
                compressionRatio,
                noSpeechProb,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TranscribedSegment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranscribedSegment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TranscribedSegment)} does not support writing '{options.Format}' format.");
            }
        }

        TranscribedSegment IPersistableModel<TranscribedSegment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranscribedSegment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTranscribedSegment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TranscribedSegment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TranscribedSegment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        BinaryData IPersistableModel<object>.Write(ModelReaderWriterOptions options) => ((IPersistableModel<TranscribedSegment>)this).Write(options);

        object IPersistableModel<object>.Create(BinaryData data, ModelReaderWriterOptions options) => ((IPersistableModel<TranscribedSegment>)this).Create(data, options);

        string IPersistableModel<object>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TranscribedSegment>)this).GetFormatFromOptions(options);

        internal static TranscribedSegment FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTranscribedSegment(document.RootElement);
        }

        internal BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
