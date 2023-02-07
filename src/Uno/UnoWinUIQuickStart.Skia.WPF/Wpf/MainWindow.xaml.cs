//-:cnd:noEmit
using System.Windows;

namespace UnoWinUIQuickStart.WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        root.Content = new Uno.UI.Skia.Platform.WpfHost(Dispatcher, () => new AppHead());
    }
}
