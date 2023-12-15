namespace $namespacePrefix$.Presentation.CsMarkup2Example;

[UIBindable]
public sealed partial class Shell : BaseUserControl, IContentControlProvider, IBuildUI
{
    public Shell() => BuildUI();

    public UIControls.ContentControl ContentControl { get; private set; } = null!;
}
