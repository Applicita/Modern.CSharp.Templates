namespace $namespacePrefix$.Presentation.Example;

[UIBindable]
public sealed partial class SecondPage : BasePage<BindableSecondModel>, IBuildUI
{
    public SecondPage() => BuildUI();
}
