namespace $namespacePrefix$.Presentation.CsMarkup2Example;

#if(tfm == 'net7.0')
public partial class SecondViewModel
{
    public Entity Entity { get; set; }

    public SecondViewModel(Entity entity) => Entity = entity;
}
#else
public partial class SecondViewModel(Entity Entity);
#endif

public record Entity(string Name);
