namespace RootNamespacePrefix.Contracts.LogicalserviceNameContract;

public interface IItemsGrain : IGrainWithStringKey
{
    Task<ImmutableArray<LogicalserviceNameItem>> GetItems();
}

[GenerateSerializer, Immutable]
public record LogicalserviceNameItem(
    [property: Id(0)] int Id,
    [property: Id(1)] string Name);
