# Tip: To execute in Visual Studio: open View|Terminal, type "New" + TAB to expand to ".\New-View.ps1", followed by the view name
Param(
    [Parameter(Mandatory, HelpMessage="The view name ('Page' suffix will be added)")]
    [string]
    $Name
)
dotnet new mcs-winui3-view -n $Name -o UnoWinUIQuickStart\Views --namespace UnoWinUIQuickStart.Views
