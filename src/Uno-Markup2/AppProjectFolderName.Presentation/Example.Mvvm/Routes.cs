namespace $namespacePrefix$.Presentation.Example;

public static class Routes
{
    public static void Register(IViewRegistry views, IRouteRegistry routes)
    {
        // Note that we use the generated Bindable model types here as a workaround for https://github.com/unoplatform/uno.extensions/issues/924#issuecomment-1822337527
        views.Register(
            new ViewMap(ViewModel: typeof(ShellViewModel)),
            new ViewMap<MainPage, MainViewModel>(),
            new DataViewMap<SecondPage, SecondViewModel, Entity>()
        );

        routes.Register(
            new RouteMap("", View: views.FindByViewModel<ShellViewModel>(),
                Nested: new RouteMap[]
                {
                    new RouteMap("Main", View: views.FindByViewModel<MainViewModel>()),
                    new RouteMap("Second", View: views.FindByViewModel<SecondViewModel>())
                }
            )
        );
    }
}
