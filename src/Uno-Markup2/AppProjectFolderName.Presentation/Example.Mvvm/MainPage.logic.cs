namespace $namespacePrefix$.Presentation.Example;

[UIBindable]
public sealed partial class MainPage : BasePage<MainViewModel>, IBuildUI
{
    public MainPage() => BuildUI();
}
