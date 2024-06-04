// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    internal readonly partial struct FineTuneChatCompletionRequestAssistantMessageRole : IEquatable<FineTuneChatCompletionRequestAssistantMessageRole>
    {
        private readonly string _value;

        public FineTuneChatCompletionRequestAssistantMessageRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssistantValue = "assistant";

        public static FineTuneChatCompletionRequestAssistantMessageRole Assistant { get; } = new FineTuneChatCompletionRequestAssistantMessageRole(AssistantValue);
        public static bool operator ==(FineTuneChatCompletionRequestAssistantMessageRole left, FineTuneChatCompletionRequestAssistantMessageRole right) => left.Equals(right);
        public static bool operator !=(FineTuneChatCompletionRequestAssistantMessageRole left, FineTuneChatCompletionRequestAssistantMessageRole right) => !left.Equals(right);
        public static implicit operator FineTuneChatCompletionRequestAssistantMessageRole(string value) => new FineTuneChatCompletionRequestAssistantMessageRole(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FineTuneChatCompletionRequestAssistantMessageRole other && Equals(other);
        public bool Equals(FineTuneChatCompletionRequestAssistantMessageRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
