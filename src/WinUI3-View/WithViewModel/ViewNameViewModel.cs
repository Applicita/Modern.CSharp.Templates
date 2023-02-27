using CommunityToolkit.Mvvm.Input;

namespace ViewsNamespace;

sealed partial class ViewNameViewModel : BaseViewModel
{
    int Count { get; set; }

    public string CountMessage => Count switch
    {
        0 => "👆Tap me👆",
        1 => "👆1 Tap👆",
        _ => $"👆{Count} Taps👆"
    };

    [RelayCommand]
    void IncrementCount() => Count++;
}
