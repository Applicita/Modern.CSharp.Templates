# <img src="src/CSharp-Toolkit-Icon.png" alt="C# Toolkit" width="64px" /> Modern.CSharp.Templates - Editorconfig

Settings for C# 11 code formatting, style, naming style and analysis.
Promotes conciseness, readability and leveraging the latest language features.
(can also be used with C# 10)

Noteworthy: the naming styles do *not* allow an underscore prefix for private fields.

Usage:
1) On the command line, ensure that the template is installed:
    ```
    dotnet new install Modern.CSharp.Templates
    ```
    (above is .NET 7 syntax; on .NET 6 use `--install`)

2) in the folder where you want to add the editorconfig, type:
    ```
    dotnet new mcs-editorconfig
    ```

It is recommended to include below settings are in all `.csproj` files that are in or below the folder where you create the `.editorconfig` file:
```xml
  <PropertyGroup>
    <Nullable>enable</Nullable>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    <AnalysisLevel>preview-All</AnalysisLevel>
    <EnforceCodeStyleInBuild>true</EnforceCodeStyleInBuild>
  </PropertyGroup>
```

The rationale for non-default settings is documented in the `.editorconfig` [file](src/Editorconfig/.editorconfig) itself