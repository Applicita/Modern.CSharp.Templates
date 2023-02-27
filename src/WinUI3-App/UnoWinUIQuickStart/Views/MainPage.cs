using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;
// IMPORTANT: avoid Microsoft.UI.Xaml namespace usings in markup files; see https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace UnoWinUIQuickStart.Views;

partial class MainPage
{
    public void BuildUI() => this.Content(
        Grid(
            TextBlock("🎉MainPage🎉") .Center()
        )
    )  .Background (Black);
}
