using Microsoft.UI.Xaml.Controls;

// The Blank Page C# Markup item template is documented at TODO

namespace UnoWinUIQuickStart.Views;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
sealed partial class MainPage : Page, IBuildUI
{
    public MainPage() => BuildUI();

    public void BuildUI()
    {
        Background = new UI.Media.SolidColorBrush(Microsoft.UI.Colors.Black);
        this.SetContent(Markup);
    }
}
