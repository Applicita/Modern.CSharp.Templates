namespace $namespacePrefix$.Presentation.Core;

static class MarkupExtensions
{
    // Add any application-specific Markup extensions here
}

static class MarkupHelpers
{
    internal static UIControls.BitmapIcon Icon(string appAsset) => BitmapIcon(UriSource: new Uri($"ms-appx:///AppProjectFolderName/Assets/{appAsset}.png"));

    internal static Image Image(string appAsset) => CSharpMarkup.WinUI.Helpers.Image(Source: BitmapImage(new Uri($"ms-appx:///AppProjectFolderName/Assets/{appAsset}.png")));

    internal static TextBlock ExampleFooter() => TextBlock(
        Span("Built with C# Markup "), Span("2") .FontSize(18), Span(" for Uno")
    )  .FontStyle().Italic()
       .Bottom() .HCenter();

    // Add more application-specific Markup helpers here
}
