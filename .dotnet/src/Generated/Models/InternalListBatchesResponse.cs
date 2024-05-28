// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Batch
{
    internal partial class InternalListBatchesResponse
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalListBatchesResponse(IEnumerable<InternalBatchJob> data, bool hasMore)
        {
            Argument.AssertNotNull(data, nameof(data));

            Data = data.ToList();
            HasMore = hasMore;
        }

        internal InternalListBatchesResponse(IReadOnlyList<InternalBatchJob> data, string firstId, string lastId, bool hasMore, InternalListBatchesResponseObject @object, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Data = data;
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
            Object = @object;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalListBatchesResponse()
        {
        }

        public IReadOnlyList<InternalBatchJob> Data { get; }
        public string FirstId { get; }
        public string LastId { get; }
        public bool HasMore { get; }
        public InternalListBatchesResponseObject Object { get; } = InternalListBatchesResponseObject.List;
    }
}
