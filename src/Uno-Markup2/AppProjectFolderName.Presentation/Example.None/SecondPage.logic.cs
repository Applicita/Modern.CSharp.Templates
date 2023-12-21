namespace $namespacePrefix$.Presentation.Example;

[UIBindable]
public sealed partial class SecondPage : BasePage, IBuildUI
{
    public record Parameters(string Name);

    UIControls.TextBlock? nameTextBlock;

    public SecondPage()
    {
        BuildUI();
        DataContextChanged += (_, _) => nameTextBlock!.Text = (DataContext as Parameters)?.Name;
    }
}
