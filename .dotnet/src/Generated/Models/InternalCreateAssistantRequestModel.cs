// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalCreateAssistantRequestModel : IEquatable<InternalCreateAssistantRequestModel>
    {
        private readonly string _value;

        public InternalCreateAssistantRequestModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Gpt4oValue = "gpt-4o";
        private const string Gpt4o20240806Value = "gpt-4o-2024-08-06";
        private const string Gpt4o20240513Value = "gpt-4o-2024-05-13";
        private const string Gpt4oMiniValue = "gpt-4o-mini";
        private const string Gpt4oMini20240718Value = "gpt-4o-mini-2024-07-18";
        private const string Gpt4TurboValue = "gpt-4-turbo";
        private const string Gpt4Turbo20240409Value = "gpt-4-turbo-2024-04-09";
        private const string Gpt40125PreviewValue = "gpt-4-0125-preview";
        private const string Gpt4TurboPreviewValue = "gpt-4-turbo-preview";
        private const string Gpt41106PreviewValue = "gpt-4-1106-preview";
        private const string Gpt4VisionPreviewValue = "gpt-4-vision-preview";
        private const string Gpt4Value = "gpt-4";
        private const string Gpt40314Value = "gpt-4-0314";
        private const string Gpt40613Value = "gpt-4-0613";
        private const string Gpt432kValue = "gpt-4-32k";
        private const string Gpt432k0314Value = "gpt-4-32k-0314";
        private const string Gpt432k0613Value = "gpt-4-32k-0613";
        private const string Gpt35TurboValue = "gpt-3.5-turbo";
        private const string Gpt35Turbo16kValue = "gpt-3.5-turbo-16k";
        private const string Gpt35Turbo0613Value = "gpt-3.5-turbo-0613";
        private const string Gpt35Turbo1106Value = "gpt-3.5-turbo-1106";
        private const string Gpt35Turbo0125Value = "gpt-3.5-turbo-0125";
        private const string Gpt35Turbo16k0613Value = "gpt-3.5-turbo-16k-0613";

        public static InternalCreateAssistantRequestModel Gpt4o { get; } = new InternalCreateAssistantRequestModel(Gpt4oValue);
        public static InternalCreateAssistantRequestModel Gpt4o20240806 { get; } = new InternalCreateAssistantRequestModel(Gpt4o20240806Value);
        public static InternalCreateAssistantRequestModel Gpt4o20240513 { get; } = new InternalCreateAssistantRequestModel(Gpt4o20240513Value);
        public static InternalCreateAssistantRequestModel Gpt4oMini { get; } = new InternalCreateAssistantRequestModel(Gpt4oMiniValue);
        public static InternalCreateAssistantRequestModel Gpt4oMini20240718 { get; } = new InternalCreateAssistantRequestModel(Gpt4oMini20240718Value);
        public static InternalCreateAssistantRequestModel Gpt4Turbo { get; } = new InternalCreateAssistantRequestModel(Gpt4TurboValue);
        public static InternalCreateAssistantRequestModel Gpt4Turbo20240409 { get; } = new InternalCreateAssistantRequestModel(Gpt4Turbo20240409Value);
        public static InternalCreateAssistantRequestModel Gpt40125Preview { get; } = new InternalCreateAssistantRequestModel(Gpt40125PreviewValue);
        public static InternalCreateAssistantRequestModel Gpt4TurboPreview { get; } = new InternalCreateAssistantRequestModel(Gpt4TurboPreviewValue);
        public static InternalCreateAssistantRequestModel Gpt41106Preview { get; } = new InternalCreateAssistantRequestModel(Gpt41106PreviewValue);
        public static InternalCreateAssistantRequestModel Gpt4VisionPreview { get; } = new InternalCreateAssistantRequestModel(Gpt4VisionPreviewValue);
        public static InternalCreateAssistantRequestModel Gpt4 { get; } = new InternalCreateAssistantRequestModel(Gpt4Value);
        public static InternalCreateAssistantRequestModel Gpt40314 { get; } = new InternalCreateAssistantRequestModel(Gpt40314Value);
        public static InternalCreateAssistantRequestModel Gpt40613 { get; } = new InternalCreateAssistantRequestModel(Gpt40613Value);
        public static InternalCreateAssistantRequestModel Gpt432k { get; } = new InternalCreateAssistantRequestModel(Gpt432kValue);
        public static InternalCreateAssistantRequestModel Gpt432k0314 { get; } = new InternalCreateAssistantRequestModel(Gpt432k0314Value);
        public static InternalCreateAssistantRequestModel Gpt432k0613 { get; } = new InternalCreateAssistantRequestModel(Gpt432k0613Value);
        public static InternalCreateAssistantRequestModel Gpt35Turbo { get; } = new InternalCreateAssistantRequestModel(Gpt35TurboValue);
        public static InternalCreateAssistantRequestModel Gpt35Turbo16k { get; } = new InternalCreateAssistantRequestModel(Gpt35Turbo16kValue);
        public static InternalCreateAssistantRequestModel Gpt35Turbo0613 { get; } = new InternalCreateAssistantRequestModel(Gpt35Turbo0613Value);
        public static InternalCreateAssistantRequestModel Gpt35Turbo1106 { get; } = new InternalCreateAssistantRequestModel(Gpt35Turbo1106Value);
        public static InternalCreateAssistantRequestModel Gpt35Turbo0125 { get; } = new InternalCreateAssistantRequestModel(Gpt35Turbo0125Value);
        public static InternalCreateAssistantRequestModel Gpt35Turbo16k0613 { get; } = new InternalCreateAssistantRequestModel(Gpt35Turbo16k0613Value);
        public static bool operator ==(InternalCreateAssistantRequestModel left, InternalCreateAssistantRequestModel right) => left.Equals(right);
        public static bool operator !=(InternalCreateAssistantRequestModel left, InternalCreateAssistantRequestModel right) => !left.Equals(right);
        public static implicit operator InternalCreateAssistantRequestModel(string value) => new InternalCreateAssistantRequestModel(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateAssistantRequestModel other && Equals(other);
        public bool Equals(InternalCreateAssistantRequestModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
