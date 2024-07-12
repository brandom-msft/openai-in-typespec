// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreCreationHelpers
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        public InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreCreationHelpers()
        {
            VectorStores = new ChangeTrackingList<VectorStoreCreationHelper>();
        }

        internal InternalCreateAssistantRequestToolResourcesFileSearchVectorStoreCreationHelpers(IList<VectorStoreCreationHelper> vectorStores, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VectorStores = vectorStores;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public IList<VectorStoreCreationHelper> VectorStores { get; init; }
    }
}
