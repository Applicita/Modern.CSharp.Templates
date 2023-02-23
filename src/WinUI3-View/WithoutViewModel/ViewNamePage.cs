using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;
// IMPORTANT: avoid using Microsoft.UI.Xaml objects in markup files; if necessary use the UI and Controls global namespace aliases for that
// See https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace ViewsNamespace;

partial class ViewNamePage
{
    public void BuildUI() => this.Content(
        Grid(
            TextBlock("ViewNamePage in C# Markup 2 says: Hello, world!") .Margin (20) .FontSize (30)
        )
    )  .Background (Black);
}
