using Microsoft.Extensions.Localization;

namespace $namespacePrefix$.Presentation.Example;

public partial class MainViewModel(IStringLocalizer localizer, INavigator navigator) : BaseViewModel
{
    public string? Title { get; } = $"Main - {localizer["ApplicationName"]}";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ButtonText))]
    string? name;

    // Example of a calculated property
    public string ButtonText => "Go to Second Page " + (string.IsNullOrWhiteSpace(Name) ? "anonymously" : $"as {Name}");

    [RelayCommand]
    async Task GoToSecond()
    {
        await navigator.NavigateViewModelAsync<SecondViewModel>(this, data: new Entity(Name ?? ""));
    }
}
