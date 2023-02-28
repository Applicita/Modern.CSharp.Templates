//-:cnd:noEmit
using Microsoft.UI.Xaml;

namespace UnoWinUIQuickStart.Wasm;

public sealed class Program
{
    static int Main(string[] _)
    {
        Application.Start(_ => { var __ = new AppHead(); });

        return 0;
    }
}
