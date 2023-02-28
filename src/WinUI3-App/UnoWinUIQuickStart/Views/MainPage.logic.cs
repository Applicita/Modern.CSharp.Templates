// IMPORTANT: do not use CSharpMarkup.WinUI objects in this UI logic file; only use them in C# markup files. 
// using Microsoft.UI.Xaml.Controls here is fine; see https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace UnoWinUIQuickStart.Views;

[UI.Data.Bindable]
public sealed partial class MainPage : BasePage, IBuildUI
{
    public MainPage() => BuildUI();
}
