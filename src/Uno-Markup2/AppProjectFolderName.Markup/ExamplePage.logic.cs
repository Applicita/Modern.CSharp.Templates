namespace NamespacePrefix.Markup;

[UIBindable]
public sealed partial class ExamplePage : BasePage<ExampleModel>, IBuildUI
{
    public ExamplePage() => BuildUI();
}
