﻿namespace $namespacePrefix$.Presentation.Example;

partial class MainPage
{
    public void BuildUI() => Content (
        Grid (
            Rows(Auto, Star, Auto),

            NavigationBar() .Content().Bind(vm?.Title),
 
            StackPanel (
                TextBox(PlaceholderText: "Enter your name:")
                   .Bind(vm?.Name, mode: BindingMode.TwoWay, updateSourceTrigger: UI.Xaml.Data.UpdateSourceTrigger.PropertyChanged),

                Button()
                   .Content().Bind(vm?.ButtonText)
                   .AutomationProperties_AutomationId("SecondPageButton")
                   .BindCommand(vm?.GoToSecondCommand)
            )  .Grid_Row(1) .Center() .Spacing(16),

            ExampleFooter() .Grid_Row(2)
        )
    );
}
