// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary> The AzureChatDataSourceConnectionStringAuthenticationOptions. </summary>
    internal partial class InternalAzureChatDataSourceConnectionStringAuthenticationOptions : DataSourceAuthentication
    {
        /// <summary> Initializes a new instance of <see cref="InternalAzureChatDataSourceConnectionStringAuthenticationOptions"/>. </summary>
        /// <param name="connectionString"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        internal InternalAzureChatDataSourceConnectionStringAuthenticationOptions(string connectionString)
        {
            Argument.AssertNotNull(connectionString, nameof(connectionString));

            Type = "connection_string";
            ConnectionString = connectionString;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureChatDataSourceConnectionStringAuthenticationOptions"/>. </summary>
        /// <param name="type"> Discriminator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="connectionString"></param>
        internal InternalAzureChatDataSourceConnectionStringAuthenticationOptions(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, string connectionString) : base(type, serializedAdditionalRawData)
        {
            ConnectionString = connectionString;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureChatDataSourceConnectionStringAuthenticationOptions"/> for deserialization. </summary>
        internal InternalAzureChatDataSourceConnectionStringAuthenticationOptions()
        {
        }

        /// <summary> Gets the connection string. </summary>
        internal string ConnectionString { get; set; }
    }
}

