Start-Sleep -seconds 1 # Workaround to prevent exception from lock on dotnet.exe log file when nesting dotnet.exe invocations (log filename includes current time down to seconds)

$appProjectPath    = "AppProjectFolderName/AppProjectFolderName.csproj"
$markupProjectPath = "AppProjectFolderName.Presentation/AppProjectFolderName.Presentation.csproj"
$packageNames = @(
    "CSharpMarkup.WinUI",
    "CSharpMarkup.WinUI.Uno.Extensions.Navigation",
    "CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit",
#if(presentation == 'mvux')
    "CSharpMarkup.WinUI.Uno.Extensions.Reactive",
    "Uno.Extensions.Reactive.WinUI",
#endif
#if(presentation == 'mvvm')
    "CommunityToolkit.Mvvm",
    "PropertyChanged.Fody",
#endif
    "CSharpMarkup.WinUI.Uno.Toolkit"
)

$packageNames | Foreach-Object {
    dotnet add $markupProjectPath package $_ | Select-String -Pattern "warn|error|PackageReference for package"
}

dotnet add $appProjectPath reference $markupProjectPath

$message1 = " Congratulations! You can now use C# Markup 2 in AppProjectFolderName "
$message2 = " See AppProjectFolderName.Presentation/Readme.md for next steps "

$lineLength = [Math]::Max($message1.Length, $message2.Length)
write-host "".PadRight($lineLength) -ForegroundColor Black -BackgroundColor Green
write-host $message1.PadRight($lineLength) -ForegroundColor Black -BackgroundColor Green
write-host $message2.PadRight($lineLength) -ForegroundColor Black -BackgroundColor Green
write-host "".PadRight($lineLength) -ForegroundColor Black -BackgroundColor Green

# Delete this script file
Remove-Item "$PSCommandPath" -Force
