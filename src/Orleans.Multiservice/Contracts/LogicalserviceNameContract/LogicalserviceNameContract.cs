namespace RootNamespacePrefix.Contracts.LogicalserviceNameContract;

public interface IItemsGrain : IGrainWithStringKey
{
    Task<ImmutableArray<LogicalserviceNameItem>> GetItems();
}

[GenerateSerializer, Immutable]
public record LogicalserviceNameItem(int Id, string Name);
