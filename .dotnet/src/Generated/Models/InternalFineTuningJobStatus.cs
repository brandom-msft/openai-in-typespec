// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.FineTuning
{
    internal readonly partial struct InternalFineTuningJobStatus : IEquatable<InternalFineTuningJobStatus>
    {
        private readonly string _value;

        public InternalFineTuningJobStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValidatingFilesValue = "validating_files";
        private const string QueuedValue = "queued";
        private const string RunningValue = "running";
        private const string SucceededValue = "succeeded";
        private const string FailedValue = "failed";
        private const string CancelledValue = "cancelled";

        public static InternalFineTuningJobStatus ValidatingFiles { get; } = new InternalFineTuningJobStatus(ValidatingFilesValue);
        public static InternalFineTuningJobStatus Queued { get; } = new InternalFineTuningJobStatus(QueuedValue);
        public static InternalFineTuningJobStatus Running { get; } = new InternalFineTuningJobStatus(RunningValue);
        public static InternalFineTuningJobStatus Succeeded { get; } = new InternalFineTuningJobStatus(SucceededValue);
        public static InternalFineTuningJobStatus Failed { get; } = new InternalFineTuningJobStatus(FailedValue);
        public static InternalFineTuningJobStatus Cancelled { get; } = new InternalFineTuningJobStatus(CancelledValue);
        public static bool operator ==(InternalFineTuningJobStatus left, InternalFineTuningJobStatus right) => left.Equals(right);
        public static bool operator !=(InternalFineTuningJobStatus left, InternalFineTuningJobStatus right) => !left.Equals(right);
        public static implicit operator InternalFineTuningJobStatus(string value) => new InternalFineTuningJobStatus(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalFineTuningJobStatus other && Equals(other);
        public bool Equals(InternalFineTuningJobStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
