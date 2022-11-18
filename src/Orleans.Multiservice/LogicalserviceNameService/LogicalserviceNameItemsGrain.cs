namespace RootNamespacePrefix.LogicalserviceNameService;

sealed class LogicalserviceNameItemsGrain : Grain, IItemsGrain
{
    public Task<ImmutableArray<LogicalserviceNameItem>> GetItems() => Task.FromResult((new LogicalserviceNameItem[] { new (1, "Item 1"), new(2, "Item 2") }).ToImmutableArray());
}
