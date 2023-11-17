Start-Sleep -seconds 1 # Workaround to prevent exception from lock on dotnet.exe log file when nesting dotnet.exe invocations (log filename includes current time down to seconds)

$outputFilter = "warn|error|PackageReference for package"
dotnet add UnoCsm2App2.Markup/UnoCsm2App2.Markup.csproj package CSharpMarkup.WinUI | Select-String -Pattern $outputFilter
dotnet add UnoCsm2App2.Markup/UnoCsm2App2.Markup.csproj package CSharpMarkup.WinUI.Uno.Extensions.Navigation | Select-String -Pattern $outputFilter
dotnet add UnoCsm2App2.Markup/UnoCsm2App2.Markup.csproj package CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit | Select-String -Pattern $outputFilter
dotnet add UnoCsm2App2.Markup/UnoCsm2App2.Markup.csproj package CSharpMarkup.WinUI.Uno.Extensions.Reactive | Select-String -Pattern $outputFilter
dotnet add UnoCsm2App2.Markup/UnoCsm2App2.Markup.csproj package CSharpMarkup.WinUI.Uno.Toolkit | Select-String -Pattern $outputFilter
dotnet add UnoCsm2App2.Markup/UnoCsm2App2.Markup.csproj package Uno.Extensions.Reactive.WinUI | Select-String -Pattern $outputFilter

dotnet add UnoCsm2App2/UnoCsm2App2.csproj reference UnoCsm2App2.Markup/UnoCsm2App2.Markup.csproj

write-host "IMPORTANT: See UnoCsm2App2.Markup/Readme.md for next steps" -ForegroundColor Black -BackgroundColor Yellow

# Delete this script file
Remove-Item "$PSCommandPath" -Force
