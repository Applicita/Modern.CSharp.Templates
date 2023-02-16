﻿using CommunityToolkit.Mvvm.Input;
using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;

namespace UnoWinUIQuickStart.Core;

static class MarkupExtensions
{
    public static Page Content(this Controls.Page page, UI.UIElement content)
    {
        page.Content =
        // TODO: Remove hot reload button after MS fixes MetadataUpdateHandler attribute for .NET hot reload in all target platforms
        #if DEBUG && !WINDOWS // Windows has Ctrl+S support in this example to refresh the page, WASM hot reload breaks the page redraw
        System.Diagnostics.Debugger.IsAttached && System.Runtime.InteropServices.RuntimeInformation.OSArchitecture != System.Runtime.InteropServices.Architecture.Wasm
        ? Grid(
            content,
            Button("\U0001F525") .Top().Right() .Command(new RelayCommand(() => (UI.Application.Current as IBuildUI)?.BuildUI()))
          ).UI
        : content;
        #else
        content;
        #endif

        return page;
    }
}
