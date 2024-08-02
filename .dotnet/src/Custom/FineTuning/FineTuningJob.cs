using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.FineTuning;

[CodeGenModel("FineTuningJob")]
public partial class FineTuningJob
{
    internal static FineTuningJob FromResponse(PipelineResponse pipelineResponse)
    {
        using var document = JsonDocument.Parse(pipelineResponse.Content);
        return DeserializeFineTuningJob(document.RootElement);
    }

    public FineTuningJobStatus Status { get; }

    public string Object { get; }

    public FineTuningJobHyperparameters? Hyperparameters { get; set; } 
    internal IReadOnlyList<InternalFineTuningIntegration> Integrations { get; }

}