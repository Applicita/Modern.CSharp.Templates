using Microsoft.UI.Xaml.Controls;

namespace UnoWinUIQuickStart.Views;

[UI.Data.Bindable]
public sealed partial class MainPage : Page, IBuildUI
{
    public MainPage() => BuildUI();
}
