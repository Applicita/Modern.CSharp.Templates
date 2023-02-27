﻿using CSharpMarkup.WinUI;
// IMPORTANT: avoid using Microsoft.UI.Xaml objects in markup files; if necessary use the UI and Controls global namespace aliases for that
// See https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace UnoWinUIQuickStart;

public static class Styles
{
    public static void ClearStyles() => Implicit.ClearStyles();

    // Explicit styles go here - they can follow the same pattern as implicit styles below.
    // Since Styles is a global static using, you can then e.g. do: Button("<") .Style(HeaderButton)

    // Note:
    // - You can use XAML styles in C# Markup - no need to translate existing XAML styles to C#.
    // - Consider using native C# reuse mechanisms, such as builder functions or classes, instead of C# WinUI styles;
    //   WinUI styles are a primary reuse mechanism in XAML, but C# has more developer friendly alternatives

    public static class Implicit
    {
        static UI.ResourceDictionary? dictionary;
        static Style<Button>? buttons;
        static Style<TextBlock>? textBlocks;

        public static UI.ResourceDictionary Dictionary => dictionary ??= CreateResourceDictionary(
            Buttons, TextBlocks
        );

        public static Style<Button> Buttons => buttons ??= new(
            (Controls.Control.ForegroundProperty, White),
            (Controls.Control.FontSizeProperty, 24)
        );

        public static Style<TextBlock> TextBlocks => textBlocks ??= new(
            (Controls.TextBlock.ForegroundProperty, White),
            (Controls.TextBlock.FontSizeProperty, 24)
        );

        internal static void ClearStyles()
        {
            dictionary = null;
            buttons = null;
            textBlocks = null;
        }

        static ResourceDictionary CreateResourceDictionary(params UI.Style[] styles)
        {
            var resources = new UI.ResourceDictionary();
            foreach (var style in styles) resources.Add(style.TargetType, style);
            return resources;
        }
    }
}
