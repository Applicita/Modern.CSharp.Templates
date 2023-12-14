namespace $namespacePrefix$.Presentation.CsMarkup2Example;

partial class MainPage
{
    public void BuildUI() => Content (
        Grid (
            Rows(Auto, Star),

            NavigationBar() .Content().Bind(vm?.Title),
 
            StackPanel (
                TextBox(PlaceholderText: "Enter your name:")
                   .Bind(vm?.Name, mode: BindingMode.TwoWay),

                Button("Go to Second Page")
                   .AutomationProperties_AutomationId("SecondPageButton")
                   .BindCommand(vm?.GoToSecondCommand)
            )  .Grid_Row(1) .Center() .Spacing(16)
        )  .SafeArea_Insets().All()
    )  .Background(ThemeResource.ApplicationPageBackgroundThemeBrush);
}
