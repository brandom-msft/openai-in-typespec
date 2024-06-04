// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    internal partial class FinetuneCompletionRequestInput
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal FinetuneCompletionRequestInput()
        {
        }

        internal FinetuneCompletionRequestInput(string prompt, string completion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Prompt = prompt;
            Completion = completion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public string Prompt { get; }
        public string Completion { get; }
    }
}
