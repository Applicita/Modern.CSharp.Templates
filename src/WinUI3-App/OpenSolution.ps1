$solutionfolder = Split-Path -Path "$PSCommandPath" -Parent
$solutionpath = Join-Path -Path $solutionfolder -ChildPath "UnoWinUIQuickStart.sln"
& "$solutionpath"

Remove-Item "$PSCommandPath" -Force