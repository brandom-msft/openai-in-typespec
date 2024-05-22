// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary> The AzureChatDataSourceEndpointVectorizationSource. </summary>
    internal partial class InternalAzureChatDataSourceEndpointVectorizationSource : DataSourceVectorizer
    {
        /// <summary> Initializes a new instance of <see cref="InternalAzureChatDataSourceEndpointVectorizationSource"/>. </summary>
        /// <param name="endpoint"></param>
        /// <param name="authentication">
        /// Please note <see cref="DataSourceAuthentication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes..
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="authentication"/> is null. </exception>
        internal InternalAzureChatDataSourceEndpointVectorizationSource(Uri endpoint, DataSourceAuthentication authentication)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(authentication, nameof(authentication));

            Type = "endpoint";
            Endpoint = endpoint;
            Authentication = authentication;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureChatDataSourceEndpointVectorizationSource"/>. </summary>
        /// <param name="type"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="endpoint"></param>
        /// <param name="authentication">
        /// Please note <see cref="DataSourceAuthentication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes..
        /// </param>
        /// <param name="dimensions"></param>
        internal InternalAzureChatDataSourceEndpointVectorizationSource(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, Uri endpoint, DataSourceAuthentication authentication, int? dimensions) : base(type, serializedAdditionalRawData)
        {
            Endpoint = endpoint;
            Authentication = authentication;
            Dimensions = dimensions;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureChatDataSourceEndpointVectorizationSource"/> for deserialization. </summary>
        internal InternalAzureChatDataSourceEndpointVectorizationSource()
        {
        }

        /// <summary> Gets the endpoint. </summary>
        internal Uri Endpoint { get; set; }
        /// <summary> Gets the dimensions. </summary>
        internal int? Dimensions { get; set; }
    }
}

