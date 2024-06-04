// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    internal readonly partial struct StaticChunkingStrategyResponseParamType : IEquatable<StaticChunkingStrategyResponseParamType>
    {
        private readonly string _value;

        public StaticChunkingStrategyResponseParamType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StaticValue = "static";

        public static StaticChunkingStrategyResponseParamType Static { get; } = new StaticChunkingStrategyResponseParamType(StaticValue);
        public static bool operator ==(StaticChunkingStrategyResponseParamType left, StaticChunkingStrategyResponseParamType right) => left.Equals(right);
        public static bool operator !=(StaticChunkingStrategyResponseParamType left, StaticChunkingStrategyResponseParamType right) => !left.Equals(right);
        public static implicit operator StaticChunkingStrategyResponseParamType(string value) => new StaticChunkingStrategyResponseParamType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StaticChunkingStrategyResponseParamType other && Equals(other);
        public bool Equals(StaticChunkingStrategyResponseParamType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
