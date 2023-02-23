using CommunityToolkit.Mvvm.Input;

namespace ViewsNamespace;

sealed partial class ViewNameViewModel : BaseViewModel
{
    int Count { get; set; }

    public string CountMessage =>
        "ViewNamePage in C# Markup 2 says: " + (Count == 0 ? "Tap me!" : $"Tapped {Count} time(s)");

    [RelayCommand]
    void IncrementCount() => Count++;
}
