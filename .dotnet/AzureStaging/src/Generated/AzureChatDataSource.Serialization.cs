// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.AI.OpenAI.Chat
{
    [PersistableModelProxy(typeof(InternalUnknownAzureChatDataSource))]
    public partial class AzureChatDataSource : IJsonModel<AzureChatDataSource>
    {
        void IJsonModel<AzureChatDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatDataSource)} does not support writing '{format}' format.");
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

        AzureChatDataSource IJsonModel<AzureChatDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatDataSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureChatDataSource(document.RootElement, options);
        }

        internal static AzureChatDataSource DeserializeAzureChatDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "azure_ml_index": return AzureMachineLearningIndexChatDataSource.DeserializeAzureMachineLearningIndexChatDataSource(element, options);
                    case "azure_search": return AzureSearchChatDataSource.DeserializeAzureSearchChatDataSource(element, options);
                    case "AzureCosmosDB": return AzureCosmosDBChatDataSource.DeserializeAzureCosmosDBChatDataSource(element, options);
                    case "elasticsearch": return ElasticsearchChatDataSource.DeserializeElasticsearchChatDataSource(element, options);
                    case "pinecone": return PineconeChatDataSource.DeserializePineconeChatDataSource(element, options);
                }
            }
            return InternalUnknownAzureChatDataSource.DeserializeInternalUnknownAzureChatDataSource(element, options);
        }

        BinaryData IPersistableModel<AzureChatDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureChatDataSource)} does not support writing '{options.Format}' format.");
            }
        }

        AzureChatDataSource IPersistableModel<AzureChatDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureChatDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureChatDataSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureChatDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static AzureChatDataSource FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureChatDataSource(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
