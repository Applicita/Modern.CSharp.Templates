namespace $namespacePrefix$.Presentation.CsMarkup2Example;

[UIBindable]
public sealed partial class SecondPage : BasePage<BindableSecondModel>, IBuildUI
{
    public SecondPage() => BuildUI();
}
