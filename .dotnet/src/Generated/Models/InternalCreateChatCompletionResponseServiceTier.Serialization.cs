// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Chat
{
    internal static partial class InternalCreateChatCompletionResponseServiceTierExtensions
    {
        public static string ToSerialString(this InternalCreateChatCompletionResponseServiceTier value) => value switch
        {
            InternalCreateChatCompletionResponseServiceTier.Scale => "scale",
            InternalCreateChatCompletionResponseServiceTier.Default => "default",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InternalCreateChatCompletionResponseServiceTier value.")
        };

        public static InternalCreateChatCompletionResponseServiceTier ToInternalCreateChatCompletionResponseServiceTier(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "scale")) return InternalCreateChatCompletionResponseServiceTier.Scale;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "default")) return InternalCreateChatCompletionResponseServiceTier.Default;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InternalCreateChatCompletionResponseServiceTier value.");
        }
    }
}
