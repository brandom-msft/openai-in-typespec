// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The MessageContentTextObject_type. </summary>
    internal readonly partial struct MessageContentTextObjectType : IEquatable<MessageContentTextObjectType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageContentTextObjectType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageContentTextObjectType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";

        /// <summary> text. </summary>
        public static MessageContentTextObjectType Text { get; } = new MessageContentTextObjectType(TextValue);
        /// <summary> Determines if two <see cref="MessageContentTextObjectType"/> values are the same. </summary>
        public static bool operator ==(MessageContentTextObjectType left, MessageContentTextObjectType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageContentTextObjectType"/> values are not the same. </summary>
        public static bool operator !=(MessageContentTextObjectType left, MessageContentTextObjectType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MessageContentTextObjectType"/>. </summary>
        public static implicit operator MessageContentTextObjectType(string value) => new MessageContentTextObjectType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageContentTextObjectType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageContentTextObjectType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
