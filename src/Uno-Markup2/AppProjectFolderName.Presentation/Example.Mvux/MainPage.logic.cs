namespace $namespacePrefix$.Presentation.CsMarkup2Example;

[UIBindable]
public sealed partial class MainPage : BasePage<BindableMainModel>, IBuildUI
{
    public MainPage() => BuildUI();
}
