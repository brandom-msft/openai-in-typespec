// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class MessageDeltaContentTextAnnotationsFilePathObjectFilePath
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal MessageDeltaContentTextAnnotationsFilePathObjectFilePath()
        {
        }

        internal MessageDeltaContentTextAnnotationsFilePathObjectFilePath(string fileId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public string FileId { get; }
    }
}
