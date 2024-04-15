using RootNamespacePrefix.Contracts.LogicalserviceNameContract;

namespace RootNamespacePrefix.Apis.LogicalserviceNameApi;

public class LogicalserviceNameEndpoints(IClusterClient orleans) : IEndpoints
{
    readonly IItemsGrain itemsGrain = orleans.GetGrain<IItemsGrain>("");

    public void Register(IEndpointRouteBuilder routeBuilder)
    {
        var group = routeBuilder.MapGroup("/LogicalserviceNameLower").WithTags("LogicalserviceName");
        _ = group.MapGet("items", GetItems);
    }

    /// <response code="200">All items are returned</response>
    public async Task<Ok<ImmutableArray<LogicalserviceNameItem>>> GetItems()
        => Ok(await itemsGrain.GetItems());
}
