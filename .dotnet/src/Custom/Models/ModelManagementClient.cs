using OpenAI.ClientShared.Internal;
using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.ComponentModel;
using System.Threading.Tasks;

namespace OpenAI.ModelManagement;

/// <summary>
///     The service client for OpenAI model operations.
/// </summary>
public partial class ModelManagementClient
{
    private readonly OpenAIClientConnector _clientConnector;
    private Internal.ModelsOps Shim => _clientConnector.InternalClient.GetModelsOpsClient();

    /// <summary>
    /// Initializes a new instance of <see cref="ModelManagementClient"/>, used for model operation requests. 
    /// </summary>
    /// <remarks>
    /// <para>
    ///     If an endpoint is not provided, the client will use the <c>OPENAI_ENDPOINT</c> environment variable if it
    ///     defined and otherwise use the default OpenAI v1 endpoint.
    /// </para>
    /// <para>
    ///    If an authentication credential is not defined, the client use the <c>OPENAI_API_KEY</c> environment variable
    ///    if it is defined.
    /// </para>
    /// </remarks>
    /// <param name="endpoint">The connection endpoint to use.</param>
    /// <param name="credential">The API key used to authenticate with the service endpoint.</param>
    /// <param name="options">Additional options to customize the client.</param>
    public ModelManagementClient(Uri endpoint, ApiKeyCredential credential, OpenAIClientOptions options = null)
    {
        _clientConnector = new("none", endpoint, credential, options);
    }

    /// <summary>
    /// Initializes a new instance of <see cref="ModelManagementClient"/>, used for model operation requests. 
    /// </summary>
    /// <remarks>
    /// <para>
    ///     If an endpoint is not provided, the client will use the <c>OPENAI_ENDPOINT</c> environment variable if it
    ///     defined and otherwise use the default OpenAI v1 endpoint.
    /// </para>
    /// <para>
    ///    If an authentication credential is not defined, the client use the <c>OPENAI_API_KEY</c> environment variable
    ///    if it is defined.
    /// </para>
    /// </remarks>
    /// <param name="endpoint">The connection endpoint to use.</param>
    /// <param name="options">Additional options to customize the client.</param>
    public ModelManagementClient(Uri endpoint, OpenAIClientOptions options = null)
        : this(endpoint, credential: null, options)
    { }

    /// <summary>
    /// Initializes a new instance of <see cref="ModelManagementClient"/>, used for model operation requests. 
    /// </summary>
    /// <remarks>
    /// <para>
    ///     If an endpoint is not provided, the client will use the <c>OPENAI_ENDPOINT</c> environment variable if it
    ///     defined and otherwise use the default OpenAI v1 endpoint.
    /// </para>
    /// <para>
    ///    If an authentication credential is not defined, the client use the <c>OPENAI_API_KEY</c> environment variable
    ///    if it is defined.
    /// </para>
    /// </remarks>
    /// <param name="credential">The API key used to authenticate with the service endpoint.</param>
    /// <param name="options">Additional options to customize the client.</param>
    public ModelManagementClient(ApiKeyCredential credential, OpenAIClientOptions options = null)
        : this(endpoint: null, credential, options)
    { }

    /// <summary>
    /// Initializes a new instance of <see cref="ModelManagementClient"/>, used for model operation requests. 
    /// </summary>
    /// <remarks>
    /// <para>
    ///     If an endpoint is not provided, the client will use the <c>OPENAI_ENDPOINT</c> environment variable if it
    ///     defined and otherwise use the default OpenAI v1 endpoint.
    /// </para>
    /// <para>
    ///    If an authentication credential is not defined, the client use the <c>OPENAI_API_KEY</c> environment variable
    ///    if it is defined.
    /// </para>
    /// </remarks>
    /// <param name="options">Additional options to customize the client.</param>
    public ModelManagementClient(OpenAIClientOptions options = null)
        : this(endpoint: null, credential: null, options)
    { }

    public virtual ClientResult<ModelDetails> GetModelInfo(string modelId)
    {
        ClientResult<Internal.Models.Model> internalResult = Shim.Retrieve(modelId);
        return ClientResult.FromValue(new ModelDetails(internalResult.Value), internalResult.GetRawResponse());
    }

    public virtual async Task<ClientResult<ModelDetails>> GetModelInfoAsync(string modelId)
    {
        ClientResult<Internal.Models.Model> internalResult = await Shim.RetrieveAsync(modelId).ConfigureAwait(false);
        return ClientResult.FromValue(new ModelDetails(internalResult.Value), internalResult.GetRawResponse());
    }

    /// <inheritdoc cref="Internal.ModelsOps.Retrieve(string, RequestOptions)"/>
    public virtual ClientResult GetModelInfo(string modelId, RequestOptions options)
        => Shim.Retrieve(modelId, options);

    /// <inheritdoc cref="Internal.ModelsOps.RetrieveAsync(string, RequestOptions)"/>
    public virtual async Task<ClientResult> GetModelInfoAsync(string modelId, RequestOptions options)
        => await Shim.RetrieveAsync(modelId, options).ConfigureAwait(false);

    public virtual ClientResult<ModelDetailCollection> GetModels()
    {
        ClientResult<Internal.Models.ListModelsResponse> internalResult = Shim.GetModels();
        OptionalList<ModelDetails> modelEntries = [];
        foreach (Internal.Models.Model internalModel in internalResult.Value.Data)
        {
            modelEntries.Add(new(internalModel));
        }
        return ClientResult.FromValue(new ModelDetailCollection(modelEntries), internalResult.GetRawResponse());
    }

    public virtual async Task<ClientResult<ModelDetailCollection>> GetModelsAsync()
    {
        ClientResult<Internal.Models.ListModelsResponse> internalResult
            = await Shim.GetModelsAsync().ConfigureAwait(false);
        OptionalList<ModelDetails> modelEntries = [];
        foreach (Internal.Models.Model internalModel in internalResult.Value.Data)
        {
            modelEntries.Add(new(internalModel));
        }
        return ClientResult.FromValue(new ModelDetailCollection(modelEntries), internalResult.GetRawResponse());
    }

    /// <inheritdoc cref="Internal.ModelsOps.GetModels(RequestOptions)"/>
    public virtual ClientResult GetModels(RequestOptions options)
        => Shim.GetModels(options);

    /// <inheritdoc cref="Internal.ModelsOps.GetModelsAsync(RequestOptions)"/>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual async Task<ClientResult> GetModelsAsync(RequestOptions options)
        => await Shim.GetModelsAsync(options).ConfigureAwait(false);

    public virtual ClientResult<bool> DeleteModel(string modelId)
    {
        ClientResult<Internal.Models.DeleteModelResponse> internalResult = Shim.Delete(modelId);
        return ClientResult.FromValue(internalResult.Value.Deleted, internalResult.GetRawResponse());
    }

    public virtual async Task<ClientResult<bool>> DeleteModelAsync(string modelId)
    {
        ClientResult<Internal.Models.DeleteModelResponse> internalResult
            = await Shim.DeleteAsync(modelId).ConfigureAwait(false);
        return ClientResult.FromValue(internalResult.Value.Deleted, internalResult.GetRawResponse());
    }

    /// <inheritdoc cref="Internal.ModelsOps.Delete(string, RequestOptions)"/>
    public virtual ClientResult DeleteModel(string modelId, RequestOptions options)
        => Shim.Delete(modelId, options);

    /// <inheritdoc cref="Internal.ModelsOps.DeleteAsync(string, RequestOptions)"/>
    public virtual async Task<ClientResult> DeleteModelAsync(string modelId, RequestOptions options)
        => await Shim.DeleteAsync(modelId, options).ConfigureAwait(false);
}
