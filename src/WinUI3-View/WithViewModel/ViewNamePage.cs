﻿using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;
// IMPORTANT: avoid Microsoft.UI.Xaml namespace usings in markup files; see https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace ViewsNamespace;

partial class ViewNamePage
{
    public void BuildUI() => this.Content(
        Grid(
            Button() .Center()
           .Bind (vm.IncrementCountCommand)
           .Content().Bind (vm.CountMessage)
        )
    )  .Background(Black);
}
