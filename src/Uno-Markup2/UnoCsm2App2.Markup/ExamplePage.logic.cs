namespace UnoCsm2App2.Markup;

[UIBindable]
public sealed partial class ExamplePage : BasePage<ExampleModel>, IBuildUI
{
    public ExamplePage() => BuildUI();
}
