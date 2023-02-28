Start-Sleep -seconds 1 # Workaround to prevent exception from lock on dotnet.exe log file when nesting dotnet.exe invocations (log filename includes current time down to seconds)

$solutionfolder = Split-Path -Path "$PSCommandPath" -Parent
dotnet new mcs-editorconfig -o "$solutionfolder" --skipmanualinstructions

Remove-Item "$PSCommandPath" -Force