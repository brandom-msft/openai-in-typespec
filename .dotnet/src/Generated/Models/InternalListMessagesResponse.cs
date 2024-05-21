// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using OpenAI.Models;

namespace OpenAI.Assistants
{
    /// <summary> The ListMessagesResponse. </summary>
    internal partial class InternalListMessagesResponse
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

        /// <summary> Initializes a new instance of <see cref="InternalListMessagesResponse"/>. </summary>
        /// <param name="data"></param>
        /// <param name="firstId"></param>
        /// <param name="lastId"></param>
        /// <param name="hasMore"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/>, <paramref name="firstId"/> or <paramref name="lastId"/> is null. </exception>
        internal InternalListMessagesResponse(IEnumerable<ThreadMessage> data, string firstId, string lastId, bool hasMore)
        {
            Argument.AssertNotNull(data, nameof(data));
            Argument.AssertNotNull(firstId, nameof(firstId));
            Argument.AssertNotNull(lastId, nameof(lastId));

            Data = data.ToList();
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
        }

        /// <summary> Initializes a new instance of <see cref="InternalListMessagesResponse"/>. </summary>
        /// <param name="object"></param>
        /// <param name="data"></param>
        /// <param name="firstId"></param>
        /// <param name="lastId"></param>
        /// <param name="hasMore"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalListMessagesResponse(object @object, IReadOnlyList<ThreadMessage> data, string firstId, string lastId, bool hasMore, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Object = @object;
            Data = data;
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalListMessagesResponse"/> for deserialization. </summary>
        internal InternalListMessagesResponse()
        {
        }

        /// <summary> Gets the data. </summary>
        public IReadOnlyList<ThreadMessage> Data { get; }
        /// <summary> Gets the first id. </summary>
        public string FirstId { get; }
        /// <summary> Gets the last id. </summary>
        public string LastId { get; }
        /// <summary> Gets the has more. </summary>
        public bool HasMore { get; }
    }
}

