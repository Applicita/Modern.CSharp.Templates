using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;

namespace UnoWinUIQuickStart.Views;

partial class MainPage
{
    public void BuildUI() => this.Content(
        Grid(
            TextBlock("Hello, world from C# Markup!") .Margin (20) .FontSize (30)
        )
    )  .Background (Black);
}
