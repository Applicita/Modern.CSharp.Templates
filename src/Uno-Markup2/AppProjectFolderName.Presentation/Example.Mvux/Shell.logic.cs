namespace $namespacePrefix$.Presentation.Example;

[UIBindable]
public sealed partial class Shell : BaseUserControl<ShellModel>, IContentControlProvider, IBuildUI
{
    public Shell() => BuildUI();

    public UIControls.ContentControl ContentControl { get; private set; } = null!;
}
