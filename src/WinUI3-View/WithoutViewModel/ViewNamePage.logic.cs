// IMPORTANT: do not use CSharpMarkup.WinUI objects in this UI logic file; only use them in C# markup files. 
// using Microsoft.UI.Xaml.Controls here is fine; see https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace ViewsNamespace;

[UI.Data.Bindable]
public sealed partial class ViewNamePage : BasePage, IBuildUI
{
    public ViewNamePage() => BuildUI();
}
