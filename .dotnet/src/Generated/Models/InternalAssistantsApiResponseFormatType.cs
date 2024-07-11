// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalAssistantsApiResponseFormatType : IEquatable<InternalAssistantsApiResponseFormatType>
    {
        private readonly string _value;

        public InternalAssistantsApiResponseFormatType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";
        private const string JsonObjectValue = "json_object";

        public static InternalAssistantsApiResponseFormatType Text { get; } = new InternalAssistantsApiResponseFormatType(TextValue);
        public static InternalAssistantsApiResponseFormatType JsonObject { get; } = new InternalAssistantsApiResponseFormatType(JsonObjectValue);
        public static bool operator ==(InternalAssistantsApiResponseFormatType left, InternalAssistantsApiResponseFormatType right) => left.Equals(right);
        public static bool operator !=(InternalAssistantsApiResponseFormatType left, InternalAssistantsApiResponseFormatType right) => !left.Equals(right);
        public static implicit operator InternalAssistantsApiResponseFormatType(string value) => new InternalAssistantsApiResponseFormatType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalAssistantsApiResponseFormatType other && Equals(other);
        public bool Equals(InternalAssistantsApiResponseFormatType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
