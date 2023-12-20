namespace $namespacePrefix$.Presentation.Core;

partial class BasePage
{
    UIElement WrapUI(UIElement content) =>
        MonochromaticOverlayPresenter(
            content.UI,

            TextBlock(Span("Built with C# Markup "), Span("2").FontSize(18), Span(" for Uno"))
               .FontStyle().Italic()
               .Bottom() .HCenter()
        )  .SafeArea_Insets().All();

    Page WrapUI(Page page) => page
        .Background(ThemeResource.ApplicationPageBackgroundThemeBrush);
}
