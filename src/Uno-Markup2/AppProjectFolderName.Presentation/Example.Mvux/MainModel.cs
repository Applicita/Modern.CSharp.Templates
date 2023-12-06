using Microsoft.Extensions.Localization;

namespace $namespacePrefix$.Presentation.CsMarkup2Example;

public partial record MainModel
{
    INavigator _navigator;

    public MainModel(
        IStringLocalizer localizer,
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Main";
        Title += $" - {localizer["ApplicationName"]}";
    }

    public string? Title { get; }

    public IState<string> Name => State<string>.Value(this, () => string.Empty);

    public async Task GoToSecond()
    {
        var name = await Name;
        await _navigator.NavigateViewModelAsync<BindableSecondModel>(this, data: new Entity(name!));
    }
}
