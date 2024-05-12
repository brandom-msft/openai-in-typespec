// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    /// <summary> The ChatCompletionTokenLogprob. </summary>
    public partial class ChatTokenLogProbabilityInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChatTokenLogProbabilityInfo"/>. </summary>
        /// <param name="token"> The token. </param>
        /// <param name="logProbability"> The log probability of this token, if it is within the top 20 most likely tokens. Otherwise, the value `-9999.0` is used to signify that the token is very unlikely. </param>
        /// <param name="utf8ByteValues"> A list of integers representing the UTF-8 bytes representation of the token. Useful in instances where characters are represented by multiple tokens and their byte representations must be combined to generate the correct text representation. Can be `null` if there is no bytes representation for the token. </param>
        /// <param name="topLogProbabilities"> List of the most likely tokens and their log probability, at this token position. In rare cases, there may be fewer than the number of requested `top_logprobs` returned. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="token"/> or <paramref name="topLogProbabilities"/> is null. </exception>
        internal ChatTokenLogProbabilityInfo(string token, float logProbability, IEnumerable<int> utf8ByteValues, IEnumerable<ChatTokenTopLogProbabilityInfo> topLogProbabilities)
        {
            Argument.AssertNotNull(token, nameof(token));
            Argument.AssertNotNull(topLogProbabilities, nameof(topLogProbabilities));

            Token = token;
            LogProbability = logProbability;
            Utf8ByteValues = utf8ByteValues?.ToList();
            TopLogProbabilities = topLogProbabilities.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ChatTokenLogProbabilityInfo"/>. </summary>
        /// <param name="token"> The token. </param>
        /// <param name="logProbability"> The log probability of this token, if it is within the top 20 most likely tokens. Otherwise, the value `-9999.0` is used to signify that the token is very unlikely. </param>
        /// <param name="utf8ByteValues"> A list of integers representing the UTF-8 bytes representation of the token. Useful in instances where characters are represented by multiple tokens and their byte representations must be combined to generate the correct text representation. Can be `null` if there is no bytes representation for the token. </param>
        /// <param name="topLogProbabilities"> List of the most likely tokens and their log probability, at this token position. In rare cases, there may be fewer than the number of requested `top_logprobs` returned. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatTokenLogProbabilityInfo(string token, float logProbability, IReadOnlyList<int> utf8ByteValues, IReadOnlyList<ChatTokenTopLogProbabilityInfo> topLogProbabilities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Token = token;
            LogProbability = logProbability;
            Utf8ByteValues = utf8ByteValues;
            TopLogProbabilities = topLogProbabilities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatTokenLogProbabilityInfo"/> for deserialization. </summary>
        internal ChatTokenLogProbabilityInfo()
        {
        }

        /// <summary> The token. </summary>
        public string Token { get; }
    }
}
