Start-Sleep -seconds 1 # Workaround to prevent exception from lock on dotnet.exe log file when nesting dotnet.exe invocations (log filename includes current time down to seconds)
dotnet add Apis/Apis.csproj reference LogicalserviceNameService/LogicalserviceNameService.csproj

Write-Host "Use AddLogicalService.ps1 <name> to add more logical services" -ForegroundColor White -BackgroundColor DarkBlue
Remove-Item $PSCommandPath -Force
