using Microsoft.UI.Xaml.Controls;
// IMPORTANT: do NOT use CSharpMarkup.WinUI objects in this UI logic file; only use them in C# markup files
// See https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace UnoWinUIQuickStart.Views;

[UI.Data.Bindable]
public sealed partial class MainPage : Page, IBuildUI
{
    public MainPage() => BuildUI();
}
