using System.Collections.Immutable;
using RootNamespacePrefix.Contracts.LogicalserviceNameContract;

namespace RootNamespacePrefix.Apis.LogicalserviceNameApi;

[Route("[controller]")]
[ApiController]
public class LogicalserviceNameController : ControllerBase
{
    readonly IItemsGrain itemsGrain;

    public LogicalserviceNameController(IClusterClient orleans)
        => itemsGrain = orleans.GetGrain<IItemsGrain>("");

    /// <response code="200">All items are returned</response>
    [HttpGet("items")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ImmutableArray<LogicalserviceNameItem>> GetProducts()
        => await itemsGrain.GetItems();
}
