// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using OpenAI.Assistants;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateAssistantRequestToolResourcesFileSearchVectorStoreCreationHelpers. </summary>
    internal partial class CreateAssistantRequestToolResourcesFileSearchVectorStoreCreationHelpers
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

        /// <summary> Initializes a new instance of <see cref="CreateAssistantRequestToolResourcesFileSearchVectorStoreCreationHelpers"/>. </summary>
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreCreationHelpers()
        {
            VectorStores = new ChangeTrackingList<VectorStoreCreationHelper>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateAssistantRequestToolResourcesFileSearchVectorStoreCreationHelpers"/>. </summary>
        /// <param name="vectorStores">
        /// A helper to create a [vector store](/docs/api-reference/vector-stores/object) with
        /// file_ids and attach it to this assistant. There can be a maximum of 1 vector store
        /// attached to the assistant.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateAssistantRequestToolResourcesFileSearchVectorStoreCreationHelpers(IList<VectorStoreCreationHelper> vectorStores, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VectorStores = vectorStores;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// A helper to create a [vector store](/docs/api-reference/vector-stores/object) with
        /// file_ids and attach it to this assistant. There can be a maximum of 1 vector store
        /// attached to the assistant.
        /// </summary>
        public IList<VectorStoreCreationHelper> VectorStores { get; }
    }
}

