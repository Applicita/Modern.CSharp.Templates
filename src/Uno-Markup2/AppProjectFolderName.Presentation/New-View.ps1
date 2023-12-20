# Tip: to use in Visual Studio: 
# 1) In solution explorer, right-click the AppProjectFolderName.Presentation project and select "Open in Terminal"
# 2) In the terminal window, type "new" + TAB to expand to ".\New-View.ps1", followed by the view name

Param(
    [Parameter(Mandatory, HelpMessage="The view name ('Page' suffix will be added)")]
    [string]
    $Name,

    [Parameter(HelpMessage="Select the update pattern to use for this view")]
    [ValidateSet("none", "mvvm", "mvux")]
    [string]$Presentation = "$architecture$"
)
#if(tfm == 'net7.0')
dotnet new mcs-uno-view -n $Name --namespace $namespacePrefix$.Presentation --presentation $Presentation --csharpversion 11
#else
dotnet new mcs-uno-view -n $Name --namespace $namespacePrefix$.Presentation --presentation $Presentation
#endif
