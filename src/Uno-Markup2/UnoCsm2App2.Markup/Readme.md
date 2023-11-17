# Welcome to C# Markup 2 for Uno Platform

This project was created with the command:

`dotnet new mcs-uno-markup2 --AppRootNamespace UnoCsm2App2`

The `AppRootNamespace` should be set to the root namespace of your existing Uno application project (the project that contains `App.cs`)

## Get the Markup project working

To get the project working, follow these steps:
1. Copy all `<TargetFrameworks ... />` elements from your Uno application project to your markup project; they need to be identical.
2. The Markup project aligns with the default choices in the [Uno Platform Solution Template Wizard](https://platform.uno/docs/articles/get-started-vs-2022.html#install-the-solution-templates). If you made different choices or made changes afterwards, you can remove unused NuGet packages from the Markup project (the `CSharpMarkup.WinUI.Uno.*` package names correspond 1 on 1 with `Uno.*` package names).
3. To quickly try out the `ExamplePage`, add it to your navigation.
   
   If you are using `Uno.Extensions.Navigation`, you can do this by adding these lines in `App.cs`:
   
   At the top:
   ```csharp
   using UnoCsm2App2.Markup;
   ```

   In the `RegisterRoutes` method:
   ```csharp
    views.Register(
        //...
        new DataViewMap<ExamplePage, ExampleModel, string>() // Add this line
    );
   ```

   And finally add this line in an existing model to navigate to the ExamplePage:
   ```csharp
    await _navigator.NavigateViewModelAsync<ExampleModel>(this, data: "Hello World from C# Markup 2!");
   ```

## Add more pages
Initially the `ExamplePage` serves as a template. Once you have your own pages, you can use those as templates and remove the `Example*.cs` files.
1. Copy, paste and rename `ExamplePage.cs`; your IDE should include `ExamplePage.logic.cs` automatically.
2. Manually rename the `ExamplePage` class in the copied files (automatic rename would rename the class in the original files as well).

## Hot Reload - automatic / manual with devtools overlay
You can experience the fastest and most stable automatic C# Hot Reload by debugging the **Unpackaged** Windows target.
For cases where the IDE reports that C# hot reload succeeded but the UI does not update automatically, you can set the `` flag in 

## More info
See the [Readme in the GitHub CSharpForMarkup repo](https://github.com/VincentH-Net/CSharpForMarkup#c-markup-2) for an overview of features, usage examples and best practices

NJoy *concise* C# Markup 2 for Uno!
