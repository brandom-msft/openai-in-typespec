// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary> Represents a data source configuration that will use an Azure Search resource. </summary>
    public partial class AzureSearchChatDataSource : AzureChatDataSource
    {
        /// <summary> Initializes a new instance of <see cref="AzureSearchChatDataSource"/>. </summary>
        /// <param name="internalParameters"> The parameter information to control the use of the Azure Search data source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="internalParameters"/> is null. </exception>
        internal AzureSearchChatDataSource(InternalAzureSearchChatDataSourceParameters internalParameters)
        {
            Argument.AssertNotNull(internalParameters, nameof(internalParameters));

            Type = "azure_search";
            InternalParameters = internalParameters;
        }

        /// <summary> Initializes a new instance of <see cref="AzureSearchChatDataSource"/>. </summary>
        /// <param name="type"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalParameters"> The parameter information to control the use of the Azure Search data source. </param>
        internal AzureSearchChatDataSource(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalAzureSearchChatDataSourceParameters internalParameters) : base(type, serializedAdditionalRawData)
        {
            InternalParameters = internalParameters;
        }
    }
}
