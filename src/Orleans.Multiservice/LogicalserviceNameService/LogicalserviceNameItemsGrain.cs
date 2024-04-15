namespace RootNamespacePrefix.LogicalserviceNameService;

sealed class LogicalserviceNameItemsGrain : Grain, IItemsGrain
{
    public Task<ImmutableArray<LogicalserviceNameItem>> GetItems() => Task.FromResult<ImmutableArray<LogicalserviceNameItem>>(
        [new(1, "LogicalserviceName Item 1"), new(2, "LogicalserviceName Item 2")]
    );
}
