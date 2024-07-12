// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        public InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences()
        {
            VectorStoreIds = new ChangeTrackingList<string>();
        }

        internal InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences(IList<string> vectorStoreIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VectorStoreIds = vectorStoreIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public IList<string> VectorStoreIds { get; init; }
    }
}
