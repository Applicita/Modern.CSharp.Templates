# Modern.CSharp.Templates - Editorconfig

Settings for C# 10 code formatting, style, naming style and analysis.
Promotes conciseness, readability and leveraging the latest language features.

Noteworthy: the naming styles do *not* allow an underscore prefix for private fields.

Usage:
1) Ensure that the template is installed:<br />`dotnet new -install Modern.CSharp.Templates`
2) On the command line, in the folder where you want to add the editorconfig, type:<br />`dotnet new mcs-editorconfig`

It is recommended to include below settings are in all `.csproj` files that are in or below the folder where you create the `.editorconfig` file:
```xml
  <PropertyGroup>
    <Nullable>enable</Nullable>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    <EnforceCodeStyleInBuild>true</EnforceCodeStyleInBuild>
  </PropertyGroup>
```

The rationale for non-default settings is documented in the `.editorconfig` [file](src/Editorconfig/.editorconfig) itself