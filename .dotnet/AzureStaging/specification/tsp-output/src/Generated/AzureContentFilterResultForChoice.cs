// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The AzureContentFilterResultForChoice. </summary>
    public partial class AzureContentFilterResultForChoice
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

        /// <summary> Initializes a new instance of <see cref="AzureContentFilterResultForChoice"/>. </summary>
        internal AzureContentFilterResultForChoice()
        {
            CustomBlocklists = new ChangeTrackingList<AzureContentFilterBlocklistIdResult>();
            Error = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureContentFilterResultForChoice"/>. </summary>
        /// <param name="sexual"></param>
        /// <param name="violence"></param>
        /// <param name="hate"></param>
        /// <param name="selfHarm"></param>
        /// <param name="profanity"></param>
        /// <param name="customBlocklists"></param>
        /// <param name="error">
        /// Describes an error returned if the content filtering system is
        /// down or otherwise unable to complete the operation in time.
        /// </param>
        /// <param name="protectedMaterialText"></param>
        /// <param name="protectedMaterialCode"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureContentFilterResultForChoice(AzureContentFilterResult sexual, AzureContentFilterResult violence, AzureContentFilterResult hate, AzureContentFilterResult selfHarm, AzureContentFilterDetectionResult profanity, IReadOnlyList<AzureContentFilterBlocklistIdResult> customBlocklists, IReadOnlyDictionary<string, BinaryData> error, AzureContentFilterDetectionResult protectedMaterialText, AzureContentFilterCitedDetectionResult protectedMaterialCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sexual = sexual;
            Violence = violence;
            Hate = hate;
            SelfHarm = selfHarm;
            Profanity = profanity;
            CustomBlocklists = customBlocklists;
            Error = error;
            ProtectedMaterialText = protectedMaterialText;
            ProtectedMaterialCode = protectedMaterialCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the sexual. </summary>
        public AzureContentFilterResult Sexual { get; }
        /// <summary> Gets the violence. </summary>
        public AzureContentFilterResult Violence { get; }
        /// <summary> Gets the hate. </summary>
        public AzureContentFilterResult Hate { get; }
        /// <summary> Gets the self harm. </summary>
        public AzureContentFilterResult SelfHarm { get; }
        /// <summary> Gets the profanity. </summary>
        public AzureContentFilterDetectionResult Profanity { get; }
        /// <summary> Gets the custom blocklists. </summary>
        public IReadOnlyList<AzureContentFilterBlocklistIdResult> CustomBlocklists { get; }
        /// <summary>
        /// Describes an error returned if the content filtering system is
        /// down or otherwise unable to complete the operation in time.
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
        public IReadOnlyDictionary<string, BinaryData> Error { get; }
        /// <summary> Gets the protected material text. </summary>
        public AzureContentFilterDetectionResult ProtectedMaterialText { get; }
        /// <summary> Gets the protected material code. </summary>
        public AzureContentFilterCitedDetectionResult ProtectedMaterialCode { get; }
    }
}
