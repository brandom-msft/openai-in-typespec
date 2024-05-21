// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Assistants
{
    /// <summary> The RunStepDetailsMessageCreationObjectMessageCreation. </summary>
    internal partial class InternalRunStepDetailsMessageCreationObjectMessageCreation
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

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDetailsMessageCreationObjectMessageCreation"/>. </summary>
        /// <param name="messageId"> The ID of the message that was created by this run step. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/> is null. </exception>
        internal InternalRunStepDetailsMessageCreationObjectMessageCreation(string messageId)
        {
            Argument.AssertNotNull(messageId, nameof(messageId));

            MessageId = messageId;
        }

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDetailsMessageCreationObjectMessageCreation"/>. </summary>
        /// <param name="messageId"> The ID of the message that was created by this run step. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalRunStepDetailsMessageCreationObjectMessageCreation(string messageId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MessageId = messageId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDetailsMessageCreationObjectMessageCreation"/> for deserialization. </summary>
        internal InternalRunStepDetailsMessageCreationObjectMessageCreation()
        {
        }

        /// <summary> The ID of the message that was created by this run step. </summary>
        public string MessageId { get; }
    }
}

