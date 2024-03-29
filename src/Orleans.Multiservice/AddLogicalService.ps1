Param(
    [Parameter(Mandatory, HelpMessage="The name (without 'Service' suffix) of the logical service to add to the MultiserviceName multiservice solution in the current directory; used in the name of the new service project and in new namespaces + classes in the Apis and Contracts projects")]
    [string]
    $Name
)
dotnet new mcs-orleans-multiservice --RootNamespace RootNamespacePrefix -M . --Logicalservice $Name --allow-scripts Yes