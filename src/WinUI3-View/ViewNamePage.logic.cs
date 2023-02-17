using Microsoft.UI.Xaml.Controls;
// IMPORTANT: do NOT use CSharpMarkup.WinUI objects in this UI logic file; only use them in C# markup files
// See https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace ViewsNamespace;

[UI.Data.Bindable]
public sealed partial class ViewNamePage : Page, IBuildUI
{
    public ViewNamePage() => BuildUI();
}
