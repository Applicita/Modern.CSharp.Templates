using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;

namespace UnoWinUIQuickStart.Views;

sealed partial class MainPage
{
    static void Build(Page page) => page.Content(
        Grid(
            TextBlock("Hello, world from C# Markup!") .Margin (20) .FontSize (30)
        )
    )  .Background (Black);
}
