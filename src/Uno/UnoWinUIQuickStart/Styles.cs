using CSharpMarkup.WinUI;
using Controls = Microsoft.UI.Xaml.Controls;
using static Microsoft.UI.Colors;

namespace UnoWinUIQuickStart;

public static class Styles
{
    public static class Implicit
    {
        static UI.ResourceDictionary? dictionary;
        static Style<TextBlock>? textBlocks;

        public static UI.ResourceDictionary Dictionary => dictionary ??= CreateResourceDictionary(
            TextBlocks
        );

        public static Style<TextBlock> TextBlocks => textBlocks ??= new(
            (Controls.TextBlock.ForegroundProperty, White)
        );

        static ResourceDictionary CreateResourceDictionary(params UI.Style[] styles)
        {
            var resources = new UI.ResourceDictionary();
            foreach (var style in styles) resources.Add(style.TargetType, style);
            return resources;
        }
    }
}
