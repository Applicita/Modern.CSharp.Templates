namespace $namespacePrefix$.Presentation.Example;

partial class MainPage
{
    public void BuildUI() => Content (
        Grid (
            Rows(Auto, Star, Auto),

            NavigationBar()
               .Assign(out navigationBar),
 
            StackPanel (
                TextBox(PlaceholderText: "Enter your name:")
                   .Assign(out nameTextBox),

                Button("Go to Second Page")
                   .AutomationProperties_AutomationId("SecondPageButton")
                   .Assign(out gotoSecondButton)
            )  .Grid_Row(1) .Center() .Spacing(16),

            ExampleFooter() .Grid_Row(2)
        )
    );
}
