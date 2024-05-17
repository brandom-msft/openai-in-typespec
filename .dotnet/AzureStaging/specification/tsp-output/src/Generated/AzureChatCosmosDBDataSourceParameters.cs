// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The AzureChatCosmosDBDataSourceParameters. </summary>
    public partial class AzureChatCosmosDBDataSourceParameters
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

        /// <summary> Initializes a new instance of <see cref="AzureChatCosmosDBDataSourceParameters"/>. </summary>
        /// <param name="databaseName"></param>
        /// <param name="containerName"></param>
        /// <param name="indexName"></param>
        /// <param name="fieldsMapping"></param>
        /// <param name="embeddingDependency">
        /// Please note <see cref="AzureChatDataSourceVectorizationSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureChatDataSourceDeploymentNameVectorizationSource"/>, <see cref="AzureChatDataSourceEndpointVectorizationSource"/> and <see cref="AzureChatDataSourceModelIdVectorizationSource"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/>, <paramref name="containerName"/>, <paramref name="indexName"/>, <paramref name="fieldsMapping"/> or <paramref name="embeddingDependency"/> is null. </exception>
        internal AzureChatCosmosDBDataSourceParameters(string databaseName, string containerName, string indexName, AzureChatCosmosDBDataSourceParametersFieldsMapping fieldsMapping, AzureChatDataSourceVectorizationSource embeddingDependency)
        {
            Argument.AssertNotNull(databaseName, nameof(databaseName));
            Argument.AssertNotNull(containerName, nameof(containerName));
            Argument.AssertNotNull(indexName, nameof(indexName));
            Argument.AssertNotNull(fieldsMapping, nameof(fieldsMapping));
            Argument.AssertNotNull(embeddingDependency, nameof(embeddingDependency));

            DatabaseName = databaseName;
            ContainerName = containerName;
            IndexName = indexName;
            FieldsMapping = fieldsMapping;
            EmbeddingDependency = embeddingDependency;
        }

        /// <summary> Initializes a new instance of <see cref="AzureChatCosmosDBDataSourceParameters"/>. </summary>
        /// <param name="authentication"></param>
        /// <param name="topNDocuments"></param>
        /// <param name="inScope"></param>
        /// <param name="strictness"></param>
        /// <param name="roleInformation"></param>
        /// <param name="databaseName"></param>
        /// <param name="containerName"></param>
        /// <param name="indexName"></param>
        /// <param name="fieldsMapping"></param>
        /// <param name="embeddingDependency">
        /// Please note <see cref="AzureChatDataSourceVectorizationSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureChatDataSourceDeploymentNameVectorizationSource"/>, <see cref="AzureChatDataSourceEndpointVectorizationSource"/> and <see cref="AzureChatDataSourceModelIdVectorizationSource"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureChatCosmosDBDataSourceParameters(BinaryData authentication, int? topNDocuments, bool? inScope, int? strictness, string roleInformation, string databaseName, string containerName, string indexName, AzureChatCosmosDBDataSourceParametersFieldsMapping fieldsMapping, AzureChatDataSourceVectorizationSource embeddingDependency, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Authentication = authentication;
            TopNDocuments = topNDocuments;
            InScope = inScope;
            Strictness = strictness;
            RoleInformation = roleInformation;
            DatabaseName = databaseName;
            ContainerName = containerName;
            IndexName = indexName;
            FieldsMapping = fieldsMapping;
            EmbeddingDependency = embeddingDependency;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AzureChatCosmosDBDataSourceParameters"/> for deserialization. </summary>
        internal AzureChatCosmosDBDataSourceParameters()
        {
        }

        /// <summary>
        /// Gets the authentication
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Authentication { get; }
        /// <summary> Gets the top n documents. </summary>
        public int? TopNDocuments { get; }
        /// <summary> Gets the in scope. </summary>
        public bool? InScope { get; }
        /// <summary> Gets the strictness. </summary>
        public int? Strictness { get; }
        /// <summary> Gets the role information. </summary>
        public string RoleInformation { get; }
        /// <summary> Gets the database name. </summary>
        public string DatabaseName { get; }
        /// <summary> Gets the container name. </summary>
        public string ContainerName { get; }
        /// <summary> Gets the index name. </summary>
        public string IndexName { get; }
        /// <summary> Gets the fields mapping. </summary>
        public AzureChatCosmosDBDataSourceParametersFieldsMapping FieldsMapping { get; }
        /// <summary>
        /// Gets the embedding dependency
        /// Please note <see cref="AzureChatDataSourceVectorizationSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureChatDataSourceDeploymentNameVectorizationSource"/>, <see cref="AzureChatDataSourceEndpointVectorizationSource"/> and <see cref="AzureChatDataSourceModelIdVectorizationSource"/>.
        /// </summary>
        public AzureChatDataSourceVectorizationSource EmbeddingDependency { get; }
    }
}
