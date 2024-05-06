namespace $namespacePrefix$.Presentation.Example;

public partial class SecondViewModel(Entity entity) : BaseViewModel
{
    public Entity Entity => entity;
}

public record Entity(string Name);
