namespace UnoCsm2App2.Markup.Core;

static class MarkupExtensions
{
    // Add any application-specific Markup extensions here
}

static class MarkupHelpers
{
    internal static UIControls.BitmapIcon Icon(string appAsset) => BitmapIcon(UriSource: new Uri($"ms-appx:///UnoCsm2App2/Assets/{appAsset}.png"));

    internal static Image Image(string appAsset) => CSharpMarkup.WinUI.Helpers.Image(Source: BitmapImage(new Uri($"ms-appx:///UnoCsm2App2/Assets/{appAsset}.png")));

    // Add any application-specific Markup helpers here
}
