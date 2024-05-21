// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.AI.OpenAI.Chat;
using Azure.Core;
using Azure.Identity;
using OpenAI.Chat;
using System.ClientModel;
using System.ClientModel.Primitives;

namespace Azure.AI.OpenAI.Tests;

public class ChatTests : TestBase<ChatClient>
{
    [Test]
    public void HelloWorldChatWithTopLevelClient()
    {
        ChatClient chatClient = GetTestClient();
        ClientResult<ChatCompletion> chatCompletion = chatClient.CompleteChat([new UserChatMessage("hello, world!")]);
        Assert.That(chatCompletion?.Value, Is.Not.Null);
    }

    [Test]
    public void BadKeyGivesHelpfulError()
    {
        string endpointFromEnvironment = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT");
        Uri endpoint = new(endpointFromEnvironment);
        string mockKey = "not-a-valid-key-and-should-still-be-sanitized";
        ApiKeyCredential credential = new(mockKey);
        AzureOpenAIClient topLevelClient = new(endpoint, credential);
        ChatClient chatClient = topLevelClient.GetChatClient("gpt-35-turbo");
        Exception thrownException = null;
        try
        {
            _ = chatClient.CompleteChat([new UserChatMessage("oops, this won't work with that key!")]);
        }
        catch (Exception ex)
        {
            thrownException = ex;
        }
        Assert.That(thrownException, Is.InstanceOf<ClientResultException>());
        Assert.That(thrownException.Message, Does.Contain("invalid subscription key"));
        Assert.That(thrownException.Message, Does.Not.Contain(mockKey));
    }

    [Test]
    public void DefaultAzureCredentialWorks()
    {
        ChatClient chatClient = GetTestClient<TokenCredential>();
        ChatCompletion chatCompletion = chatClient.CompleteChat([ChatMessage.CreateUserMessage("Hello, world!")]);
        Assert.That(chatCompletion?.Content, Is.Not.Null);
        chatCompletion = chatClient.CompleteChat([ChatMessage.CreateUserMessage("Hello again, world!")]);
        Assert.That(chatCompletion?.Content, Is.Not.Null);
    }

    [Test]
    public void CanGetContentFilterResults()
    {
        ChatClient client = GetTestClient();
        ClientResult<ChatCompletion> chatCompletionResult = client.CompleteChat([ChatMessage.CreateUserMessage("Hello, world!")]);
        Console.WriteLine($"--- RESPONSE ---");
        Console.WriteLine(chatCompletionResult.GetRawResponse().Content.ToString());
        ChatCompletion chatCompletion = chatCompletionResult.Value;
#pragma warning disable OPENAI002
        ContentFilterResultForPrompt promptFilterResult = chatCompletion.GetPromptContentFilterResult();
        Assert.That(promptFilterResult, Is.Not.Null);
        Assert.That(promptFilterResult.Sexual?.Filtered, Is.False);
        Assert.That(promptFilterResult.Sexual?.Severity, Is.EqualTo(ContentFilterSeverity.Safe));
        ContentFilterResultForResponse responseFilterResult = chatCompletion.GetResponseContentFilterResult();
        Assert.That(responseFilterResult, Is.Not.Null);
        Assert.That(responseFilterResult.Hate?.Severity, Is.EqualTo(ContentFilterSeverity.Safe));
        Assert.That(responseFilterResult.ProtectedMaterialCode, Is.Null);
    }
#pragma warning restore

    [Test]
    [Category("Smoke")]
    public void DataSourceSerializationWorks()
    {
        AzureSearchChatDataSource source = new()
        {
            Endpoint = new Uri("https://some-search-resource.azure.com"),
            Authentication = DataSourceAuthentication.FromApiKey("test-api-key"),
            IndexName = "index-name-here",
            FieldMappings = new()
            {
                ContentFieldNames = { "hello" },
                TitleFieldName = "hi",
            },
            AllowPartialResult = true,
            QueryType = DataSourceQueryType.Simple,
            VectorizationSource = DataSourceVectorizer.FromEndpoint(
                new Uri("https://my-embedding.com"),
                DataSourceAuthentication.FromApiKey("embedding-api-key")),
        };
        dynamic serialized = ModelReaderWriter.Write(source).ToDynamicFromJson();
        Assert.That(serialized?.type?.ToString(), Is.EqualTo("azure_search"));
        Assert.That(serialized?.parameters?.authentication?.type?.ToString(), Is.EqualTo("api_key"));
        Assert.That(serialized?.parameters?.authentication?.key?.ToString(), Does.Contain("test"));
        Assert.That(serialized?.parameters?.index_name?.ToString(), Is.EqualTo("index-name-here"));
        Assert.That(serialized?.parameters?.fields_mapping?.content_fields?[0]?.ToString(), Is.EqualTo("hello"));
        Assert.That(serialized?.parameters?.fields_mapping?.title_field?.ToString(), Is.EqualTo("hi"));
        Assert.That(bool.TryParse(serialized?.parameters?.allow_partial_result?.ToString(), out bool parsed) && parsed == true);
        Assert.That(serialized?.parameters?.query_type?.ToString(), Is.EqualTo("simple"));
        Assert.That(serialized?.parameters?.embedding_dependency?.type?.ToString(), Is.EqualTo("endpoint"));
    }
}