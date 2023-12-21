namespace $namespace$;

[UIBindable]
public sealed partial class ViewNamePage : BasePage, IBuildUI
{
    public record Parameters(string Name);

    UIControls.TextBlock? messageTextBlock;

    public ViewNamePage()
    {
        BuildUI();
        messageTextBlock!.Text = "Hello from C# Markup 2 - the concise, next-gen C# Markup for Uno!";
    }
}
