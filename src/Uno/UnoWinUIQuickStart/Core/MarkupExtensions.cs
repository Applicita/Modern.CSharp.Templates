using CommunityToolkit.Mvvm.Input;
using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;

namespace UnoWinUIQuickStart.Core;

static class MarkupExtensions
{
    // TODO: Replace with MetadataUpdateHandler attribute after that works for .NET hot reload in WinUI
    public static void SetContent(this UI.Controls.Page page, UIElement content) => page.Content =
    #if DEBUG && !(WINDOWS || HAS_UNO_WASM) // Windows has Ctrl+S support to refresh the page, WASM hot reload breaks the page redraw
        System.Diagnostics.Debugger.IsAttached
        ? Grid(
            content.UI,

            Button("\U0001F525") .Top().Right() .Command(new RelayCommand(() => (UI.Application.Current as IBuildUI)?.BuildUI()))
          ).UI
        : content.UI;
    #else
      content.UI;
    #endif
}
