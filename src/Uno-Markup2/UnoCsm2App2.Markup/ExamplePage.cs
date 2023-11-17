namespace UnoCsm2App2.Markup;

partial class ExamplePage
{
    public void BuildUI() => this.Content(
        Grid (
            Rows(Auto, Star),

            NavigationBar("C# Markup 2 for Uno ExamplePage")
               .MainCommand(AppBarButton().Icon(Icon("Icons/back"))),
 
            StackPanel (
                TextBlock() .Bind(vm?.Text)
            )  .Grid_Row(1) .Margin(8) .Center()

        )  .Background(ThemeResource.ApplicationPageBackgroundThemeBrush)
    );
}
