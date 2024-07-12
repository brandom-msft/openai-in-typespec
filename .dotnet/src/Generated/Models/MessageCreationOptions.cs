// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Assistants
{
    public partial class MessageCreationOptions
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal MessageCreationOptions(MessageRole role, IList<MessageContent> content, IList<MessageCreationAttachment> attachments, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Role = role;
            Content = content;
            Attachments = attachments;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        public IList<MessageCreationAttachment> Attachments { get; init; }
        public IDictionary<string, string> Metadata { get; init; }
    }
}
