// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The AzureChatDataSourceEndpointVectorizationSource. </summary>
    public partial class AzureChatDataSourceEndpointVectorizationSource : AzureChatDataSourceVectorizationSource
    {
        /// <summary> Initializes a new instance of <see cref="AzureChatDataSourceEndpointVectorizationSource"/>. </summary>
        /// <param name="endpoint"></param>
        /// <param name="authentication">
        /// Please note <see cref="AzureChatDataSourceAuthenticationOptions"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureChatDataSourceApiKeyAuthenticationOptions"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="authentication"/> is null. </exception>
        internal AzureChatDataSourceEndpointVectorizationSource(Uri endpoint, AzureChatDataSourceAuthenticationOptions authentication)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(authentication, nameof(authentication));

            Type = "endpoint";
            Endpoint = endpoint;
            Authentication = authentication;
        }

        /// <summary> Initializes a new instance of <see cref="AzureChatDataSourceEndpointVectorizationSource"/>. </summary>
        /// <param name="type"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="endpoint"></param>
        /// <param name="authentication">
        /// Please note <see cref="AzureChatDataSourceAuthenticationOptions"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureChatDataSourceApiKeyAuthenticationOptions"/>.
        /// </param>
        internal AzureChatDataSourceEndpointVectorizationSource(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, Uri endpoint, AzureChatDataSourceAuthenticationOptions authentication) : base(type, serializedAdditionalRawData)
        {
            Endpoint = endpoint;
            Authentication = authentication;
        }

        /// <summary> Initializes a new instance of <see cref="AzureChatDataSourceEndpointVectorizationSource"/> for deserialization. </summary>
        internal AzureChatDataSourceEndpointVectorizationSource()
        {
        }

        /// <summary> Gets the endpoint. </summary>
        public Uri Endpoint { get; }
        /// <summary>
        /// Gets the authentication
        /// Please note <see cref="AzureChatDataSourceAuthenticationOptions"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureChatDataSourceApiKeyAuthenticationOptions"/>.
        /// </summary>
        public AzureChatDataSourceAuthenticationOptions Authentication { get; }
    }
}
