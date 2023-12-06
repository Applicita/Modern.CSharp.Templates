namespace $namespacePrefix$.Presentation.Core;

public abstract partial class BaseUserControl<TViewModel> : BaseUserControl where TViewModel : class
{
    protected TViewModel? vm => DataContext as TViewModel;
}

public abstract partial class BaseUserControl : UIControls.UserControl // We need to derive from the UI control instead of from the C# Markup 2 control, because instances of this class are created with new (by e.g. navigation), not with a C# Markup 2 helper.
{
    new public UserControl Content(UI.Xaml.UIElement content)
        => CSharpMarkup.WinUI.Helpers.Content(this, content);
}
