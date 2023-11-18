# Welcome to C# Markup 2 for Uno Platform

This C# Markup 2 project was created with the command:

```bat
dotnet new mcs-uno-markup2 --AppProjectName AppProjectFolderName --AppRootNamespace NamespacePrefix --DotNetVersion DotNetMonikerVersion
```

The `mcs-uno-markup2` template used came from NuGet `Modern.CSharp.Templates` version 1.4.2

## Test the Markup project

To start working with the Markup project, follow these steps:

1. Copy all `<TargetFrameworks ... />` elements from your Uno application project file to your markup project file; they should be identical
   (by default the markup project targets all platforms supported by Uno).

   **TIP** If you get a lot of green squiggles while editing the Uno application project's `.cs` files, ensure that the Uno application project contains this property setting (it is already in the Markup project):
   ```xml
    <PropertyGroup>
        <!-- Prevent false positives for warning CA1416; see https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1416 -->
        <GenerateAssemblyInfo>true</GenerateAssemblyInfo>
    </PropertyGroup>
   ```

2. By default the Markup project uses the Uno extensions for [MVUX](https://platform.uno/docs/articles/external/uno.extensions/doc/Overview/Mvux/Overview.html) and [navigation](https://platform.uno/docs/articles/external/uno.extensions/doc/Overview/Navigation/NavigationOverview.html). If you made different choices in the [Uno Platform Solution Template Wizard](https://platform.uno/docs/articles/get-started-vs-2022.html#install-the-solution-templates), or made changes afterwards, remove any unused NuGet packages from the Markup project (the `CSharpMarkup.WinUI.Uno.*` package names correspond 1 on 1 with `Uno.*` package names).

3. To quickly try out the `ExamplePage`, add it to your navigation.
   
   If you are using `Uno.Extensions.Navigation`, you can do this by adding these lines in `App.cs`:
   
   At the top:
   ```csharp
   using NamespacePrefix.Markup;
   ```

   In the `RegisterRoutes` method:
   ```csharp
    views.Register(
        //...
        new DataViewMap<ExamplePage, ExampleModel, string>() // Add this line
    );
   ```

   And finally add these lines in an existing model to navigate to the `ExamplePage`:
   ```csharp
   using NamespacePrefix.Markup;
   ```
   ...
   ```csharp
    await _navigator.NavigateViewModelAsync<ExampleModel>(this, data: "Hello World from C# Markup 2!");
   ```

## Add more pages
Initially the `ExamplePage` serves as a template. Once you have your own pages, you can use those as templates and remove the `Example*.cs` files.
1. Copy, paste and rename `ExamplePage.cs`; your IDE should include `ExamplePage.logic.cs` automatically.
2. Manually rename the `ExamplePage` class in the copied files (automatic rename would rename the class in the original files as well).

## Hot Reload - Automatic & Manual
Enjoy the fastest and most stable C# Hot Reload, with automatic UI updates, by debugging the **Unpackaged** Windows target. This is a good reason to keep the Windows target even if you don't deploy it.

The template contains code to overlay a 🔥 button in debug builds. This button lets you manually trigger a page rebuild, for cases where the IDE reports that C# hot reload succeeded but the UI does not update automatically.

## More info
See the [Readme in the GitHub CSharpForMarkup repo](https://github.com/VincentH-Net/CSharpForMarkup#c-markup-2) for an overview of features, usage examples and best practices

NJoy *concise* C# Markup 2 - the next-gen C# Markup for Uno!
