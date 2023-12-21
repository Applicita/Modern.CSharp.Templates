using Microsoft.UI.Xaml.Navigation;

namespace $namespacePrefix$.Presentation.Core;

public abstract partial class BasePage<TViewModel> : BasePage where TViewModel : class
{
    protected TViewModel? vm => DataContext as TViewModel;
}

// Because instances of this class are created with new instead of with a C# Markup 2 helper,
// derive this class from the UI type instead of from the C# Markup 2 type
public abstract partial class BasePage : UIControls.Page
{
//-:cnd:noEmit
    const bool ShowTools =
#if DEBUG
        true;
#else
        false;
#endif
//+:cnd:noEmit

    protected BasePage() => NavigationCacheMode = NavigationCacheMode.Required;
}
