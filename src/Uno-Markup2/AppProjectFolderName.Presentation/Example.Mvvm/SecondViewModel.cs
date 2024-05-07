namespace $namespacePrefix$.Presentation.Example;

public partial class SecondViewModel(Entity entity) : BaseViewModel
{
    [ObservableProperty] Entity entity = entity;
}

public record Entity(string Name);
