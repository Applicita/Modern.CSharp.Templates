# <img src="src/CSharp-Toolkit-Icon.png" alt="C# Toolkit" width="64px" /> Modern.CSharp.Templates
A toolkit of modern [dotnet new templates](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new) for C# 10, .NET 6 and Microsoft Orleans 4

Templates:
- Editorconfig [doc](Editorconfig.md)
- Orleans.Results [doc](https://github.com/Applicita/Orleans.Results)

To install, type this on the command line:
```
dotnet new --install Modern.CSharp.Templates
```

[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Modern.CSharp.Templates?color=gold&label=NuGet:%20Modern.CSharp.Templates&style=plastic)](https://www.nuget.org/packages/Modern.CSharp.Templates)

More templates are coming (in Aug-Sept 2022):
- Orleans.Multitenant (separate grain state storage and grain/stream communication per tenant)
- Orleans.Multiservice (use a single Orleans service with multiple logical services inside it as an alternative to separate microservices)