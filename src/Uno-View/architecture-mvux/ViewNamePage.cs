namespace NamespacePrefix.Presentation;

partial class ViewNamePage
{
    public void BuildUI() => Content (
        Grid (
            Rows(Auto, Star),

            NavigationBar("C# Markup 2 for Uno ViewNamePage")
               .MainCommand (
                   AppBarButton() .Icon(Icon("Icons/back"))
                ),
 
            StackPanel (
                TextBlock() .Bind(vm?.Text),

                Button("To Example B").BindCommand(vm?.GoToExampleB)

            )  .Grid_Row(1) .Margin(8) .Center()

        )  .Background(ThemeResource.ApplicationPageBackgroundThemeBrush)
    );
}
