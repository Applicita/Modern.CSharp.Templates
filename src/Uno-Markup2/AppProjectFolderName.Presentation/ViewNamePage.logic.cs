namespace InnoWvate.UnoAppCTest.Markup;

[UIBindable]
public sealed partial class ExamplePage : BasePage<BindableExampleModel>, IBuildUI
{
    public ExamplePage() => BuildUI();
}
