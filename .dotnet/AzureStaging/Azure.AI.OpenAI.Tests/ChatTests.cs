// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.Core;
using Azure.Identity;
using OpenAI.Chat;
using System.ClientModel;

namespace Azure.AI.OpenAI.Tests;

public class ChatTests
{
    [Test]
    public void HelloWorldChatWithTopLevelClient()
    {
        AzureOpenAIClient client = new();
        ChatClient chatClient = client.GetChatClient("gpt-35-turbo");
        ClientResult<ChatCompletion> chatCompletion = chatClient.CompleteChat("hello, world!");
        Assert.That(chatCompletion?.Value, Is.Not.Null);
    }

    [Test]
    public void HelloWorldChatWithTopLevelClientNoImplicitEnvironment()
    {
        string endpointFromEnvironment = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT");
        string keyFromEnvironment = Environment.GetEnvironmentVariable("AZURE_OPENAI_API_KEY");

        AzureOpenAIClient topLevelClient = new(new Uri(endpointFromEnvironment), new ApiKeyCredential(keyFromEnvironment));
        ChatClient chatClient = topLevelClient.GetChatClient("gpt-35-turbo");
        ChatCompletion chatCompletion = chatClient.CompleteChat("hello, world!");
        Assert.That(chatCompletion?.Content, Is.Not.Null);
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
            _ = chatClient.CompleteChat("oops, this won't work with that key!");
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
        string endpointFromEnvironment = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT");
        Uri endpoint = new(endpointFromEnvironment);
        TokenCredential credential = new DefaultAzureCredential();
        AzureOpenAIClient client = new(endpoint, credential);
        ChatClient chatClient = client.GetChatClient("gpt-35-turbo");
        ChatCompletion chatCompletion = chatClient.CompleteChat("Hello, world!");
        Assert.That(chatCompletion?.Content, Is.Not.Null);
        chatCompletion = chatClient.CompleteChat("Hello again, world!");
        Assert.That(chatCompletion?.Content, Is.Not.Null);
    }

    [Test]
    public void ContentFilterPromptError()
    {
        string prompt = "What's the best way to violently rob a bank in the most offensive way possible that would run afoul of content filter rules?";
        ChatClient client = GetTestClient();
        ChatCompletion chatCompletion = client.CompleteChat(prompt);
        Assert.That(chatCompletion, Is.Not.Null);

        ClientResult protocolResult = client.CompleteChat(
            BinaryContent.Create(BinaryData.FromObjectAsJson(new
            {
                messages = new dynamic[]
                {
                    new
                    {
                        role = "user",
                        content = prompt,
                    }
                }
            })));
        Assert.That(protocolResult, Is.Not.Null);
        dynamic dynamicResult = protocolResult.GetRawResponse().Content.ToDynamicFromJson();
        Assert.That(dynamicResult.choices, Is.Not.Null.Or.Empty);
        dynamic choice = dynamicResult.choices[0];
        Assert.That(choice.message?.content, Is.Not.Null);
    }

    private ChatClient GetTestClient(string deploymentName = null)
    {
        deploymentName ??= "gpt-35-turbo";
        AzureOpenAIClient client = new();
        return client.GetChatClient(deploymentName);
    }
}