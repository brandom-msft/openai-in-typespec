// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    /// <summary> Enum for detail in MessageDeltaContentImageFileObjectImageFile. </summary>
    internal readonly partial struct InternalMessageDeltaContentImageFileObjectImageFileDetail : IEquatable<InternalMessageDeltaContentImageFileObjectImageFileDetail>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternalMessageDeltaContentImageFileObjectImageFileDetail"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalMessageDeltaContentImageFileObjectImageFileDetail(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";
        private const string LowValue = "low";
        private const string HighValue = "high";

        /// <summary> auto. </summary>
        public static InternalMessageDeltaContentImageFileObjectImageFileDetail Auto { get; } = new InternalMessageDeltaContentImageFileObjectImageFileDetail(AutoValue);
        /// <summary> low. </summary>
        public static InternalMessageDeltaContentImageFileObjectImageFileDetail Low { get; } = new InternalMessageDeltaContentImageFileObjectImageFileDetail(LowValue);
        /// <summary> high. </summary>
        public static InternalMessageDeltaContentImageFileObjectImageFileDetail High { get; } = new InternalMessageDeltaContentImageFileObjectImageFileDetail(HighValue);
        /// <summary> Determines if two <see cref="InternalMessageDeltaContentImageFileObjectImageFileDetail"/> values are the same. </summary>
        public static bool operator ==(InternalMessageDeltaContentImageFileObjectImageFileDetail left, InternalMessageDeltaContentImageFileObjectImageFileDetail right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternalMessageDeltaContentImageFileObjectImageFileDetail"/> values are not the same. </summary>
        public static bool operator !=(InternalMessageDeltaContentImageFileObjectImageFileDetail left, InternalMessageDeltaContentImageFileObjectImageFileDetail right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternalMessageDeltaContentImageFileObjectImageFileDetail"/>. </summary>
        public static implicit operator InternalMessageDeltaContentImageFileObjectImageFileDetail(string value) => new InternalMessageDeltaContentImageFileObjectImageFileDetail(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalMessageDeltaContentImageFileObjectImageFileDetail other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternalMessageDeltaContentImageFileObjectImageFileDetail other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
