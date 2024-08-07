// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuningJobHyperparameters
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalFineTuningJobHyperparameters(BinaryData batchSize, BinaryData learningRateMultiplier, BinaryData nEpochs)
        {
            Argument.AssertNotNull(batchSize, nameof(batchSize));
            Argument.AssertNotNull(learningRateMultiplier, nameof(learningRateMultiplier));
            Argument.AssertNotNull(nEpochs, nameof(nEpochs));

            BatchSize = batchSize;
            LearningRateMultiplier = learningRateMultiplier;
            NEpochs = nEpochs;
        }

        internal InternalFineTuningJobHyperparameters(BinaryData batchSize, BinaryData learningRateMultiplier, BinaryData nEpochs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BatchSize = batchSize;
            LearningRateMultiplier = learningRateMultiplier;
            NEpochs = nEpochs;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalFineTuningJobHyperparameters()
        {
        }

        public BinaryData BatchSize { get; }
        public BinaryData LearningRateMultiplier { get; }
        public BinaryData NEpochs { get; }
    }
}
