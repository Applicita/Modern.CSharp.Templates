namespace $namespacePrefix$.Presentation.Example;

public partial class SecondViewModel(Entity entity)
{
    public Entity Entity => entity;
}

public record Entity(string Name);
