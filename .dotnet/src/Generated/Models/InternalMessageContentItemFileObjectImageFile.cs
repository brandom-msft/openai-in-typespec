// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Assistants
{
    /// <summary> The MessageContentImageFileObjectImageFile. </summary>
    internal partial class InternalMessageContentItemFileObjectImageFile
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

        /// <summary> Initializes a new instance of <see cref="InternalMessageContentItemFileObjectImageFile"/>. </summary>
        /// <param name="fileId"> The [File](/docs/api-reference/files) ID of the image in the message content. Set `purpose="vision"` when uploading the File if you need to later display the file content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        public InternalMessageContentItemFileObjectImageFile(string fileId)
        {
            Argument.AssertNotNull(fileId, nameof(fileId));

            FileId = fileId;
        }

        /// <summary> Initializes a new instance of <see cref="InternalMessageContentItemFileObjectImageFile"/>. </summary>
        /// <param name="fileId"> The [File](/docs/api-reference/files) ID of the image in the message content. Set `purpose="vision"` when uploading the File if you need to later display the file content. </param>
        /// <param name="detail"> Specifies the detail level of the image if specified by the user. `low` uses fewer tokens, you can opt in to high resolution using `high`. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalMessageContentItemFileObjectImageFile(string fileId, string detail, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            Detail = detail;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalMessageContentItemFileObjectImageFile"/> for deserialization. </summary>
        internal InternalMessageContentItemFileObjectImageFile()
        {
        }

        /// <summary> The [File](/docs/api-reference/files) ID of the image in the message content. Set `purpose="vision"` when uploading the File if you need to later display the file content. </summary>
        public string FileId { get; set; }
    }
}

