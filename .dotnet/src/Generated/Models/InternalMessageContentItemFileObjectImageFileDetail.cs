// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    /// <summary> Enum for detail in InternalMessageContentItemFileObjectImageFile. </summary>
    internal readonly partial struct InternalMessageContentItemFileObjectImageFileDetail : IEquatable<InternalMessageContentItemFileObjectImageFileDetail>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternalMessageContentItemFileObjectImageFileDetail"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalMessageContentItemFileObjectImageFileDetail(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";
        private const string LowValue = "low";
        private const string HighValue = "high";

        /// <summary> auto. </summary>
        public static InternalMessageContentItemFileObjectImageFileDetail Auto { get; } = new InternalMessageContentItemFileObjectImageFileDetail(AutoValue);
        /// <summary> low. </summary>
        public static InternalMessageContentItemFileObjectImageFileDetail Low { get; } = new InternalMessageContentItemFileObjectImageFileDetail(LowValue);
        /// <summary> high. </summary>
        public static InternalMessageContentItemFileObjectImageFileDetail High { get; } = new InternalMessageContentItemFileObjectImageFileDetail(HighValue);
        /// <summary> Determines if two <see cref="InternalMessageContentItemFileObjectImageFileDetail"/> values are the same. </summary>
        public static bool operator ==(InternalMessageContentItemFileObjectImageFileDetail left, InternalMessageContentItemFileObjectImageFileDetail right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternalMessageContentItemFileObjectImageFileDetail"/> values are not the same. </summary>
        public static bool operator !=(InternalMessageContentItemFileObjectImageFileDetail left, InternalMessageContentItemFileObjectImageFileDetail right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternalMessageContentItemFileObjectImageFileDetail"/>. </summary>
        public static implicit operator InternalMessageContentItemFileObjectImageFileDetail(string value) => new InternalMessageContentItemFileObjectImageFileDetail(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalMessageContentItemFileObjectImageFileDetail other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternalMessageContentItemFileObjectImageFileDetail other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
