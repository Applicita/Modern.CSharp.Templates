using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;

namespace $namespacePrefix$.Presentation.CsMarkup2Example;

[UIBindable]
public sealed partial class MainPage : BasePage, IBuildUI
{
    Uno.Toolkit.UI.NavigationBar? navigationBar;
    UIControls.TextBox? nameTextBox;
    UIControls.Button? gotoSecondButton;

    public MainPage()
    {
        BuildUI();

        Loaded += (s, e) =>
        {
            var localizer = this.FindServiceProvider()?.GetService<IStringLocalizer>();
            navigationBar!.Content = $"Main - {localizer?["ApplicationName"]}";
        };

        gotoSecondButton!.Click += async (_, _) =>
            await this.Navigator()!.NavigateViewAsync<SecondPage>(this, data: nameTextBox?.Text);
    }
}
