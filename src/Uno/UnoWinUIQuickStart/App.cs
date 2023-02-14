using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;

namespace UnoWinUIQuickStart;

partial class App
{
    static Frame RootFrame => Frame()
        .Resources (Implicit.Dictionary);
}
