﻿namespace $namespacePrefix$.Presentation.Example;

partial class SecondPage
{
    public void BuildUI() => Content (
        Grid (
            NavigationBar("Second Page")
               .MainCommand(
                   AppBarButton() .Icon(Icon("Images/back"))
               ),

            TextBlock()
               .Bind(vm?.Entity.Name)
               .Center(),

            ExampleFooter()
        )
    );
}
