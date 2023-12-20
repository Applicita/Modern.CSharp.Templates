namespace $namespace$;

[UIBindable]
public sealed partial class ViewNamePage : BasePage, IBuildUI
{
    public record Parameters(string Name);

    UIControls.TextBlock? messageTextBlock;

    public ViewNamePage()
    {
        BuildUI();
        messageTextBlock!.Text = "NJoy concise C# Markup 2 for Uno Platform";
    }
}
