using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;

namespace UnoWinUIQuickStart;

partial class App
{
    static Frame Markup => Frame()
        .Resources(Styles.Implicit.Dictionary);
}
