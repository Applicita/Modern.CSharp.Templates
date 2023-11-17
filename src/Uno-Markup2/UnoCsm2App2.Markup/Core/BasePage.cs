using Microsoft.UI.Xaml.Navigation;

namespace UnoCsm2App2.Markup.Core;

public abstract partial class BasePage<TViewModel> : BasePage where TViewModel : class
{
    protected TViewModel? vm => DataContext as TViewModel;
}

public abstract partial class BasePage : UIControls.Page
{
    public BasePage()
    {
        NavigationCacheMode = NavigationCacheMode.Required;
    }

    new public BasePage Content(UI.Xaml.UIElement content)
    {
#if DEBUG
        _ = this.Content(overlayDevTools: true, content: content);
#else
        _ = this.Content(overlayDevTools: false, content: content);
#endif
        return this;
    }
}
