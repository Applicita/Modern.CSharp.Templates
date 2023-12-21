namespace $namespacePrefix$.Presentation.Example;

[UIBindable]
public sealed partial class SecondPage : BasePage<SecondViewModel>, IBuildUI
{
    public SecondPage() => BuildUI();
}
