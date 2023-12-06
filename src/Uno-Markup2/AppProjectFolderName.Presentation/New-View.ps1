# Tip: To execute in Visual Studio: open View|Terminal, type "New" + TAB to expand to ".\New-View.ps1", followed by the view name
Param(
    [Parameter(Mandatory, HelpMessage="The view name ('Page' suffix will be added)")]
    [string]
    $Name,

    [Parameter(HelpMessage="Select the update pattern to use for this view")]
    [ValidateSet("none", "mvvm", "mvux")]
    [string]$Presentation = "mvux"
)
dotnet new mcs-uno-view -n $Name --namespace $namespacePrefix$.Presentation --presentation $Presentation
