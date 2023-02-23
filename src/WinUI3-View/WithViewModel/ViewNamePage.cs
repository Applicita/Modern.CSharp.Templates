using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;
// IMPORTANT: avoid using Microsoft.UI.Xaml objects in markup files; if necessary use the UI and Controls global namespace aliases for that
// See https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace ViewsNamespace;

partial class ViewNamePage
{
    public void BuildUI() => this.Content(
        Grid(
            Button() .Top() .FontSize (30) .Foreground (White)
            .Bind (vm.IncrementCountCommand)
            .Content().Bind (vm.CountMessage)
        )
    )  .Background (Black);
}
