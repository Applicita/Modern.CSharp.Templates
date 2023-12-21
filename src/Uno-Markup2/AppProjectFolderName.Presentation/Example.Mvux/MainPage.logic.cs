namespace $namespacePrefix$.Presentation.Example;

[UIBindable]
public sealed partial class MainPage : BasePage<BindableMainModel>, IBuildUI
{
    public MainPage() => BuildUI();
}
