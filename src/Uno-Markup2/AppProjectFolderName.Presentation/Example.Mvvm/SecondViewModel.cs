namespace $namespacePrefix$.Presentation.Example;

#if(tfm == 'net7.0')
public partial class SecondViewModel
{
    public Entity Entity { get; set; }

    public SecondViewModel(Entity entity) => Entity = entity;
}
#else
public partial class SecondViewModel(Entity entity)
{
    public Entity Entity => entity;
}
#endif

public record Entity(string Name);
