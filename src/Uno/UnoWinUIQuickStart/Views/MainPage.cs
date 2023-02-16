using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;
// IMPORTANT: avoid using Microsoft.UI.Xaml objects in markup files; if necessary use the UI and Controls global namespace aliases for that
// See https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace UnoWinUIQuickStart.Views;

partial class MainPage
{
    public void BuildUI() => this.Content(
        Grid(
            TextBlock("Hello, world from C# Markup!") .Margin (20) .FontSize (30)
            new UI.
        )
    )  .Background (Black);
}
