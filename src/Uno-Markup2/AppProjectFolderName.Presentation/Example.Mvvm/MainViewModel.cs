using Microsoft.Extensions.Localization;

namespace $namespacePrefix$.Presentation.Example;

public partial class MainViewModel : ObservableObject
{
    INavigator _navigator;

    public MainViewModel(
        IStringLocalizer localizer,
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Main";
        Title += $" - {localizer["ApplicationName"]}";
    }

    public string? Title { get; }

    public string? Name { get; set; }

    // Example of a calculated property - these are automatically updated by PropertyChanged.Fody
    public string ButtonText => "Go to Second Page " + (string.IsNullOrWhiteSpace(Name) ? "anonymously" : $"as {Name}");

    [RelayCommand]
    async Task GoToSecond()
    {
        await _navigator.NavigateViewModelAsync<SecondViewModel>(this, data: new Entity(Name ?? ""));
    }
}
