namespace $namespacePrefix$.Presentation.CsMarkup2Example;

partial class MainPage
{
    public void BuildUI() => Content (
        Grid (
            Rows(Auto, Star),

            NavigationBar()
               .Assign(out navigationBar),
 
            StackPanel (
                TextBox(PlaceholderText: "Enter your name:")
                   .Assign(out nameTextBox),

                Button("Go to Second Page")
                   .AutomationProperties_AutomationId("SecondPageButton")
                   .Assign(out gotoSecondButton)
            ).Grid_Row(1) .Center() .Spacing(16)
        )  .SafeArea_Insets().All()
    )  .Background(ThemeResource.ApplicationPageBackgroundThemeBrush);
}
