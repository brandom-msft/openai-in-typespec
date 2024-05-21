﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using OpenAI;
using OpenAI.Chat;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace Azure.AI.OpenAI.Chat;

internal partial class AzureChatClient : ChatClient
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ClientResult CompleteChat(BinaryContent content, RequestOptions options = null)
    {
        using PipelineMessage message = CreateCompleteChatRequestMessage(content, options);
        PipelineResponse response = Pipeline.ProcessMessage(message, options);
        _ = TryReplaceResponseStreamWithClonedElement(
            response,
            "sdk_content_filter_response",
            ("choices", JsonValueKind.Array),
            ("content_filter_results", JsonValueKind.Object));
        return ClientResult.FromResponse(response);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override async Task<ClientResult> CompleteChatAsync(BinaryContent content, RequestOptions options = null)
    {
        using PipelineMessage message = CreateCompleteChatRequestMessage(content, options);
        PipelineResponse response = await Pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false);
        return ClientResult.FromResponse(response);
    }

    private PipelineMessage CreateCompleteChatRequestMessage(
        BinaryContent content,
        RequestOptions options = null,
        bool? bufferResponse = true)
            => new AzureOpenAIPipelineMessageBuilder(Pipeline, _endpoint, _apiVersion, _deploymentName)
                .WithPath("chat", "completions")
                .WithMethod("POST")
                .WithContent(content, "application/json")
                .WithAccept("application/json")
                .WithResponseContentBuffering(bufferResponse)
                .WithOptions(options)
                .Build();

    private static bool TryReplaceResponseStreamWithClonedElement(
        PipelineResponse inputResponse,
        string destinationName,
        params (string valueName, JsonValueKind valueKind)[] path)
    {
        using JsonDocument inputDocument = JsonDocument.Parse(inputResponse.ContentStream);
        JsonElement element = inputDocument.RootElement;
        foreach ((string valueName, JsonValueKind valueKind) in path)
        {
            if (!element.TryGetProperty(valueName, out element) || element.ValueKind != valueKind)
            {
                return false;
            }
            if (element.ValueKind == JsonValueKind.Array)
            {
                if (element.GetArrayLength() == 0)
                {
                    return false;
                }
                element = element[0];
            }
        }
        MemoryStream newStream = new();
        Utf8JsonWriter writer = new(newStream);
        writer.WriteStartObject();
        foreach (JsonProperty property in inputDocument.RootElement.EnumerateObject())
        {
            writer.WritePropertyName(property.Name);
            writer.WriteRawValue(property.Value.GetRawText());
        }
        writer.WritePropertyName(destinationName);
        writer.WriteRawValue(element.GetRawText());
        writer.WriteEndObject();
        writer.Flush();
        newStream.Position = 0;
        Stream oldStream = inputResponse.ContentStream;
        inputResponse.ContentStream = newStream;
        oldStream.Dispose();
        return true;
    }
}
