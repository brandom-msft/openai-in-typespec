// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Assistants
{
    /// <summary> Represents a run step delta i.e. any changed fields on a run step during streaming. </summary>
    internal partial class InternalRunStepDelta
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

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDelta"/>. </summary>
        /// <param name="id"> The identifier of the run step, which can be referenced in API endpoints. </param>
        /// <param name="delta"> The delta containing the fields that have changed on the run step. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="delta"/> is null. </exception>
        internal InternalRunStepDelta(string id, InternalRunStepDeltaObjectDelta delta)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(delta, nameof(delta));

            Id = id;
            Delta = delta;
        }

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDelta"/>. </summary>
        /// <param name="id"> The identifier of the run step, which can be referenced in API endpoints. </param>
        /// <param name="object"> The object type, which is always `thread.run.step.delta`. </param>
        /// <param name="delta"> The delta containing the fields that have changed on the run step. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalRunStepDelta(string id, object @object, InternalRunStepDeltaObjectDelta delta, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            Delta = delta;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalRunStepDelta"/> for deserialization. </summary>
        internal InternalRunStepDelta()
        {
        }

        /// <summary> The identifier of the run step, which can be referenced in API endpoints. </summary>
        public string Id { get; }

        /// <summary> The delta containing the fields that have changed on the run step. </summary>
        public InternalRunStepDeltaObjectDelta Delta { get; }
    }
}

