// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace OpenAI.Chat
{
    /// <summary> A chat completion message generated by the model. </summary>
    internal partial class InternalChatCompletionResponseMessage
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary>
        /// Gets the dictionary containing additional raw data to serialize.
        /// </summary>
        /// <remarks>
        /// NOTE: This mechanism added for subclients pending availability of a C# language feature.
        ///       It is subject to change and not intended for stable use.
        /// </remarks>
        [Experimental("OPENAI002")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public IDictionary<string, BinaryData> SerializedAdditionalRawData
            => _serializedAdditionalRawData ??= new ChangeTrackingDictionary<string, BinaryData>();

        /// <summary> Initializes a new instance of <see cref="InternalChatCompletionResponseMessage"/>. </summary>
        /// <param name="content"> The contents of the message. </param>
        /// <param name="toolCalls"></param>
        /// <param name="role"> The role of the author of this message. </param>
        /// <param name="functionCall"> Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalChatCompletionResponseMessage(IReadOnlyList<ChatMessageContentPart> content, IReadOnlyList<ChatToolCall> toolCalls, ChatMessageRole role, ChatFunctionCall functionCall, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            ToolCalls = toolCalls;
            Role = role;
            FunctionCall = functionCall;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalChatCompletionResponseMessage"/> for deserialization. </summary>
        internal InternalChatCompletionResponseMessage()
        {
        }
        /// <summary> Gets the tool calls. </summary>
        public IReadOnlyList<ChatToolCall> ToolCalls { get; }
    }
}

