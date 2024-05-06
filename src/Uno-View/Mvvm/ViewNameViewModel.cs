namespace $namespace$;

public partial class ViewNameViewModel(string message = "NJoy concise C# Markup 2 for Uno Platform") : BaseViewModel
{
    [ObservableProperty] string message = message;
}
