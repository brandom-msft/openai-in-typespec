// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Chat
{
    internal readonly partial struct InternalChatCompletionResponseMessageRole : IEquatable<InternalChatCompletionResponseMessageRole>
    {
        private readonly string _value;

        public InternalChatCompletionResponseMessageRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssistantValue = "assistant";

        public static InternalChatCompletionResponseMessageRole Assistant { get; } = new InternalChatCompletionResponseMessageRole(AssistantValue);
        public static bool operator ==(InternalChatCompletionResponseMessageRole left, InternalChatCompletionResponseMessageRole right) => left.Equals(right);
        public static bool operator !=(InternalChatCompletionResponseMessageRole left, InternalChatCompletionResponseMessageRole right) => !left.Equals(right);
        public static implicit operator InternalChatCompletionResponseMessageRole(string value) => new InternalChatCompletionResponseMessageRole(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalChatCompletionResponseMessageRole other && Equals(other);
        public bool Equals(InternalChatCompletionResponseMessageRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
