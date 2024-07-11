// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    public readonly partial struct RunStepErrorCode : IEquatable<RunStepErrorCode>
    {
        private readonly string _value;

        public RunStepErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServerErrorValue = "server_error";
        private const string RateLimitExceededValue = "rate_limit_exceeded";

        public static RunStepErrorCode ServerError { get; } = new RunStepErrorCode(ServerErrorValue);
        public static RunStepErrorCode RateLimitExceeded { get; } = new RunStepErrorCode(RateLimitExceededValue);
        public static bool operator ==(RunStepErrorCode left, RunStepErrorCode right) => left.Equals(right);
        public static bool operator !=(RunStepErrorCode left, RunStepErrorCode right) => !left.Equals(right);
        public static implicit operator RunStepErrorCode(string value) => new RunStepErrorCode(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunStepErrorCode other && Equals(other);
        public bool Equals(RunStepErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
