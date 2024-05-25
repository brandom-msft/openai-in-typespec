// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    /// <summary> The ListMessagesResponse_object. </summary>
    internal readonly partial struct InternalListMessagesResponseObject : IEquatable<InternalListMessagesResponseObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternalListMessagesResponseObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalListMessagesResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        /// <summary> list. </summary>
        public static InternalListMessagesResponseObject List { get; } = new InternalListMessagesResponseObject(ListValue);
        /// <summary> Determines if two <see cref="InternalListMessagesResponseObject"/> values are the same. </summary>
        public static bool operator ==(InternalListMessagesResponseObject left, InternalListMessagesResponseObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternalListMessagesResponseObject"/> values are not the same. </summary>
        public static bool operator !=(InternalListMessagesResponseObject left, InternalListMessagesResponseObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternalListMessagesResponseObject"/>. </summary>
        public static implicit operator InternalListMessagesResponseObject(string value) => new InternalListMessagesResponseObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalListMessagesResponseObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternalListMessagesResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
