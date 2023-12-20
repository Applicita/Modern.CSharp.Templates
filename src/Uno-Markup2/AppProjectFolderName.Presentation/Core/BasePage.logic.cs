using Microsoft.UI.Xaml.Navigation;

namespace $namespacePrefix$.Presentation.Core;

public abstract partial class BasePage<TViewModel> : BasePage where TViewModel : class
{
    protected TViewModel? vm => DataContext as TViewModel;
}

public abstract partial class BasePage : UIControls.Page // We need to derive from the UI page instead of from the C# Markup 2 page, because instances of this class are created with new (by e.g. navigation), not with a C# Markup 2 helper.
{
    protected BasePage() => NavigationCacheMode = NavigationCacheMode.Required;

    new protected Page Content(UIElement content)
        => WrapUI(this.Content(
                overlayDevTools:
//-:cnd:noEmit
                #if DEBUG
                    true,
                #else
                    false,
                #endif
//-:cnd:noEmit
                WrapUI(content).UI
            ));
}
