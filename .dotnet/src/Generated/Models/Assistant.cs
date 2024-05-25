// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Assistants
{
    public partial class Assistant
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal Assistant(string id, DateTimeOffset createdAt, string name, string description, string model, string instructions, IEnumerable<ToolDefinition> tools, IReadOnlyDictionary<string, string> metadata)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(model, nameof(model));
            Argument.AssertNotNull(tools, nameof(tools));

            Id = id;
            CreatedAt = createdAt;
            Name = name;
            Description = description;
            Model = model;
            Instructions = instructions;
            Tools = tools.ToList();
            Metadata = metadata;
        }

        /// <summary> Initializes a new instance of <see cref="Assistant"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="object"> The object type, which is always `assistant`. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the assistant was created. </param>
        /// <param name="name"> The name of the assistant. The maximum length is 256 characters. </param>
        /// <param name="description"> The description of the assistant. The maximum length is 512 characters. </param>
        /// <param name="model"> ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them. </param>
        /// <param name="instructions"> The system instructions that the assistant uses. The maximum length is 256,000 characters. </param>
        /// <param name="tools">
        /// A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types `code_interpreter`, `file_search`, or `function`.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CodeInterpreterToolDefinition"/>, <see cref="FileSearchToolDefinition"/> and <see cref="FunctionToolDefinition"/>.
        /// </param>
        /// <param name="toolResources"> A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs. </param>
        /// <param name="metadata"> Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </param>
        /// <param name="temperature"> What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. </param>
        /// <param name="nucleusSamplingFactor">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or temperature but not both.
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Assistant(string id, InternalAssistantObjectObject @object, DateTimeOffset createdAt, string name, string description, string model, string instructions, IReadOnlyList<ToolDefinition> tools, ToolResources toolResources, IReadOnlyDictionary<string, string> metadata, float? temperature, float? nucleusSamplingFactor, AssistantResponseFormat responseFormat, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            Name = name;
            Description = description;
            Model = model;
            Instructions = instructions;
            Tools = tools;
            ToolResources = toolResources;
            Metadata = metadata;
            Temperature = temperature;
            NucleusSamplingFactor = nucleusSamplingFactor;
            ResponseFormat = responseFormat;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal Assistant()
        {
        }

        public string Id { get; }

        public DateTimeOffset CreatedAt { get; }
        public string Name { get; }
        public string Description { get; }
        public string Model { get; }
        public string Instructions { get; }
        public IReadOnlyList<ToolDefinition> Tools { get; }
        public ToolResources ToolResources { get; }
        public IReadOnlyDictionary<string, string> Metadata { get; }
        public float? Temperature { get; }
    }
}
