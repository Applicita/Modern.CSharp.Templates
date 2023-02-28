﻿//-:cnd:noEmit
#if DEBUG
using System.Linq;
#endif
using CommunityToolkit.Mvvm.Input;
using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;

namespace UnoWinUIQuickStart.Core;

static class MarkupExtensions
{
    public static UIElement HotReloadOverlay(this Frame rootFrame)
    {
#if !DEBUG
        return rootFrame;
#else
        const string viewsNamespace = "UnoWinUIQuickStart.Views.";
        var frame = rootFrame.UI;
        System.Collections.Generic.Dictionary<string, Type> buildablePageTypes = new();

        return MonochromaticOverlayPresenter(
            rootFrame,

            HStack(
                ComboBox() .MinWidth (150) .Invoke(Initialize),
                Button("\U0001F525") .Command(new RelayCommand(() => (UI.Application.Current as IBuildUI)?.BuildUI()))
                // TODO: Remove hot reload button after MS fixes MetadataUpdateHandler attribute for .NET hot reload in all target platforms
            )  .Top() .Right(),

            TextBlock("Built with C# Markup 2") .FontSize(16) .FontStyle().Italic() .Foreground(Gold)
               .Bottom() .HCenter()
        );

        void Initialize(Controls.ComboBox pageSelector)
        {
            var pageTypes = typeof(MarkupExtensions).Assembly.GetTypes().Where(t =>
                (t.FullName?.StartsWith(viewsNamespace, StringComparison.Ordinal) == true)
                && t.GetInterface(nameof(IBuildUI)) is not null);

            buildablePageTypes.Clear();
            pageSelector.Items.Clear();
            foreach (var pageType in pageTypes)
            {
                string name = PageName(pageType);
                buildablePageTypes.Add(name, pageType);
                pageSelector.Items.Add(name);
                if (frame?.CurrentSourcePageType == pageType)
                    pageSelector.SelectedItem = name;
            }

            if (frame is not null)
                frame.Navigated += (s, e) => pageSelector.SelectedItem = PageName(frame!.CurrentSourcePageType);

            pageSelector.SelectionChanged += PageSelector_SelectionChanged;
        }

        string PageName(Type pageType)
        {
            string? fullName = pageType.FullName;
            if (fullName?.StartsWith(viewsNamespace, StringComparison.Ordinal) != true)
                return string.Empty;

            return fullName[viewsNamespace.Length..];
        }

        void PageSelector_SelectionChanged(object sender, Controls.SelectionChangedEventArgs e)
        {
            string? name = e.AddedItems.SingleOrDefault()?.ToString();
            if (frame is null || name is null) return;

            var pageType = buildablePageTypes[name];

            if (frame.CurrentSourcePageType == pageType) return;

            if (frame.BackStack.Any(entry => entry.SourcePageType == pageType))
            {
                while (frame.CurrentSourcePageType != pageType && frame.CanGoBack)
                    frame.GoBack(new UI.Media.Animation.SuppressNavigationTransitionInfo());
                return;
            }

            if (frame.ForwardStack.Any(entry => entry.SourcePageType == pageType))
            {
                while (frame.CurrentSourcePageType != pageType && frame.CanGoForward)
                    frame.GoForward();
                return;
            }

            frame.Navigate(pageType);
        }
#endif
    }
}
