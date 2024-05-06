Start-Sleep -seconds 1 # Workaround to prevent exception from lock on dotnet.exe log file when nesting dotnet.exe invocations (log filename includes current time down to seconds)

$appProjectPath    = "AppProjectFolderName/AppProjectFolderName.csproj"
$markupProjectPath = "AppProjectFolderName.Presentation/AppProjectFolderName.Presentation.csproj"

$packages = @(
    @{Name="CSharpMarkup.WinUI"},
    @{Name="CSharpMarkup.WinUI.Uno.Extensions.Navigation"},
    @{Name="CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit"},
#if(presentation == 'mvux')
    @{Name="CSharpMarkup.WinUI.Uno.Extensions.Reactive"},
    @{Name="Uno.Extensions.Reactive.WinUI"; Version="4.1.14"},
    # The Uno.Extensions.Reactive.WinUI version is aligned to the version that is implicitly referenced by the uno.sdk version that is used in dotnet new unoapp
#endif
#if(presentation == 'mvvm')
    @{Name="CommunityToolkit.Mvvm"},
#endif
    @{Name="CSharpMarkup.WinUI.Uno.Toolkit"}
)

$packages | Foreach-Object {
    if ($_.Version -eq $null) 
    { 
        dotnet add $markupProjectPath package $_.Name | Select-String -Pattern "warn|error|PackageReference for package"
    } else { 
        dotnet add $markupProjectPath package $_.Name --version $($_.Version) | Select-String -Pattern "warn|error|PackageReference for package"
    }
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
