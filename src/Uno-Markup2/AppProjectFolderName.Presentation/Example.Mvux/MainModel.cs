using Microsoft.Extensions.Localization;

namespace $namespacePrefix$.Presentation.Example;

public partial record MainModel(IStringLocalizer localizer, INavigator navigator)
{
    public string? Title { get; } = $"Main primary - {localizer["ApplicationName"]}";

    public IState<string> Name => State<string>.Value(this, () => string.Empty);

    public async Task GoToSecond()
    {
        var name = await Name;
        await navigator.NavigateViewModelAsync<BindableSecondModel>(this, data: new Entity(name!));
    }
}
