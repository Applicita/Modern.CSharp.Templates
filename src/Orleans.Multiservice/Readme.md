# MultiserviceName multiservice

## The multiservice pattern 
This solution follows the [Multiservice pattern for Microsoft Orleans](https://github.com/Applicita/Orleans.Multiservice#readme); it was generated with [Modern.CSharp.Templates 2.0.0](https://www.nuget.org/packages/Modern.CSharp.Templates/2.0.0) by this command:

`dotnet new mcs-orleans-multiservice --RootNamespace RootNamespacePrefix --Multiservice MultiserviceName --Logicalservice LogicalserviceName`

See the [pattern rules](https://github.com/Applicita/Orleans.Multiservice#pattern-rules) for how to structure code in this solution (this will be supported by automation in a later template version).

Use [`AddLogicalService.ps1 <name>`](AddLogicalService.ps1) to add more logical services to the solution.