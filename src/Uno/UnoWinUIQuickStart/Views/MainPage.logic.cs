using Microsoft.UI.Xaml.Controls;

namespace UnoWinUIQuickStart.Views;

sealed partial class MainPage : Page, IBuildUI
{
    public MainPage() => BuildUI();

    public void BuildUI() => Build(this);
}
