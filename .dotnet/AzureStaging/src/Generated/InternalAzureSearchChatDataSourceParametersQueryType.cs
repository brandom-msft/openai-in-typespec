// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> Enum for query_type in InternalAzureSearchChatDataSourceParameters. </summary>
    public readonly partial struct InternalAzureSearchChatDataSourceParametersQueryType : IEquatable<InternalAzureSearchChatDataSourceParametersQueryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternalAzureSearchChatDataSourceParametersQueryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalAzureSearchChatDataSourceParametersQueryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SimpleValue = "simple";
        private const string SemanticValue = "semantic";
        private const string VectorValue = "vector";
        private const string VectorSimpleHybridValue = "vector_simple_hybrid";
        private const string VectorSemanticHybridValue = "vector_semantic_hybrid";

        /// <summary> simple. </summary>
        internal static InternalAzureSearchChatDataSourceParametersQueryType Simple { get; set; } = new InternalAzureSearchChatDataSourceParametersQueryType(SimpleValue);
        /// <summary> semantic. </summary>
        internal static InternalAzureSearchChatDataSourceParametersQueryType Semantic { get; set; } = new InternalAzureSearchChatDataSourceParametersQueryType(SemanticValue);
        /// <summary> vector. </summary>
        internal static InternalAzureSearchChatDataSourceParametersQueryType Vector { get; set; } = new InternalAzureSearchChatDataSourceParametersQueryType(VectorValue);
        /// <summary> vector_simple_hybrid. </summary>
        internal static InternalAzureSearchChatDataSourceParametersQueryType VectorSimpleHybrid { get; set; } = new InternalAzureSearchChatDataSourceParametersQueryType(VectorSimpleHybridValue);
        /// <summary> vector_semantic_hybrid. </summary>
        internal static InternalAzureSearchChatDataSourceParametersQueryType VectorSemanticHybrid { get; set; } = new InternalAzureSearchChatDataSourceParametersQueryType(VectorSemanticHybridValue);
        /// <summary> Determines if two <see cref="InternalAzureSearchChatDataSourceParametersQueryType"/> values are the same. </summary>
        public static bool operator ==(InternalAzureSearchChatDataSourceParametersQueryType left, InternalAzureSearchChatDataSourceParametersQueryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternalAzureSearchChatDataSourceParametersQueryType"/> values are not the same. </summary>
        public static bool operator !=(InternalAzureSearchChatDataSourceParametersQueryType left, InternalAzureSearchChatDataSourceParametersQueryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternalAzureSearchChatDataSourceParametersQueryType"/>. </summary>
        public static implicit operator InternalAzureSearchChatDataSourceParametersQueryType(string value) => new InternalAzureSearchChatDataSourceParametersQueryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalAzureSearchChatDataSourceParametersQueryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternalAzureSearchChatDataSourceParametersQueryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

