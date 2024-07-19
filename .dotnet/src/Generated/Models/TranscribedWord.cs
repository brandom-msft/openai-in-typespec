// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Audio
{
    public readonly partial struct TranscribedWord
    {
        internal readonly IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal TranscribedWord(string word, TimeSpan start, TimeSpan end)
        {
            Argument.AssertNotNull(word, nameof(word));

            Word = word;
            Start = start;
            End = end;
        }

        internal TranscribedWord(string word, TimeSpan start, TimeSpan end, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Word = word;
            Start = start;
            End = end;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public TranscribedWord()
        {
        }

        public string Word { get; }
        public TimeSpan Start { get; }
        public TimeSpan End { get; }
    }
}
