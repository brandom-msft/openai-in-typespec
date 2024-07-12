// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalModifyThreadRequestToolResourcesFileSearch
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        public InternalModifyThreadRequestToolResourcesFileSearch()
        {
            VectorStoreIds = new ChangeTrackingList<string>();
        }

        internal InternalModifyThreadRequestToolResourcesFileSearch(IList<string> vectorStoreIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VectorStoreIds = vectorStoreIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public IList<string> VectorStoreIds { get; init; }
    }
}
