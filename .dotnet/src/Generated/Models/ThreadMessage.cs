// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Assistants
{
    public partial class ThreadMessage
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal ThreadMessage(string id, DateTimeOffset createdAt, string threadId, MessageStatus status, MessageFailureDetails incompleteDetails, DateTimeOffset? completedAt, DateTimeOffset? incompleteAt, MessageRole role, IEnumerable<MessageContent> content, string assistantId, string runId, IEnumerable<MessageCreationAttachment> attachments, IReadOnlyDictionary<string, string> metadata)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(threadId, nameof(threadId));
            Argument.AssertNotNull(content, nameof(content));

            Id = id;
            CreatedAt = createdAt;
            ThreadId = threadId;
            Status = status;
            IncompleteDetails = incompleteDetails;
            CompletedAt = completedAt;
            IncompleteAt = incompleteAt;
            Role = role;
            Content = content.ToList();
            AssistantId = assistantId;
            RunId = runId;
            Attachments = attachments?.ToList();
            Metadata = metadata;
        }

        /// <summary> Initializes a new instance of <see cref="ThreadMessage"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="object"> The object type, which is always `thread.message`. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the message was created. </param>
        /// <param name="threadId"> The [thread](/docs/api-reference/threads) ID that this message belongs to. </param>
        /// <param name="status"> The status of the message, which can be either `in_progress`, `incomplete`, or `completed`. </param>
        /// <param name="incompleteDetails"> On an incomplete message, details about why the message is incomplete. </param>
        /// <param name="completedAt"> The Unix timestamp (in seconds) for when the message was completed. </param>
        /// <param name="incompleteAt"> The Unix timestamp (in seconds) for when the message was marked as incomplete. </param>
        /// <param name="role"> The entity that produced the message. One of `user` or `assistant`. </param>
        /// <param name="content"> The content of the message in array of text and/or images. </param>
        /// <param name="assistantId"> If applicable, the ID of the [assistant](/docs/api-reference/assistants) that authored this message. </param>
        /// <param name="runId"> The ID of the [run](/docs/api-reference/runs) associated with the creation of this message. Value is `null` when messages are created manually using the create message or create thread endpoints. </param>
        /// <param name="attachments"> A list of files attached to the message, and the tools they were added to. </param>
        /// <param name="metadata"> Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreadMessage(string id, InternalMessageObjectObject @object, DateTimeOffset createdAt, string threadId, MessageStatus status, MessageFailureDetails incompleteDetails, DateTimeOffset? completedAt, DateTimeOffset? incompleteAt, MessageRole role, IReadOnlyList<MessageContent> content, string assistantId, string runId, IReadOnlyList<MessageCreationAttachment> attachments, IReadOnlyDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            ThreadId = threadId;
            Status = status;
            IncompleteDetails = incompleteDetails;
            CompletedAt = completedAt;
            IncompleteAt = incompleteAt;
            Role = role;
            Content = content;
            AssistantId = assistantId;
            RunId = runId;
            Attachments = attachments;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal ThreadMessage()
        {
        }

        public string Id { get; }

        public DateTimeOffset CreatedAt { get; }
        public string ThreadId { get; }
        public MessageStatus Status { get; }
        public MessageFailureDetails IncompleteDetails { get; }
        public DateTimeOffset? CompletedAt { get; }
        public DateTimeOffset? IncompleteAt { get; }
        public IReadOnlyList<MessageContent> Content { get; }
        public string AssistantId { get; }
        public string RunId { get; }
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
