namespace $namespacePrefix$.Presentation.Example;

public partial class ShellModel
{
    readonly INavigator _navigator;

    public ShellModel(INavigator navigator)
    {
        _navigator = navigator;
        _ = Start();
    }

    public async Task Start() => await _navigator.NavigateViewModelAsync<BindableMainModel>(this);
}
