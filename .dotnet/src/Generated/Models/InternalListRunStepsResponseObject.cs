// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalListRunStepsResponseObject : IEquatable<InternalListRunStepsResponseObject>
    {
        private readonly string _value;

        public InternalListRunStepsResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        public static InternalListRunStepsResponseObject List { get; } = new InternalListRunStepsResponseObject(ListValue);
        public static bool operator ==(InternalListRunStepsResponseObject left, InternalListRunStepsResponseObject right) => left.Equals(right);
        public static bool operator !=(InternalListRunStepsResponseObject left, InternalListRunStepsResponseObject right) => !left.Equals(right);
        public static implicit operator InternalListRunStepsResponseObject(string value) => new InternalListRunStepsResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalListRunStepsResponseObject other && Equals(other);
        public bool Equals(InternalListRunStepsResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
