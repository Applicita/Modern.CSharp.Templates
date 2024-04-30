namespace $namespacePrefix$.Presentation.Example;

public static class Routes
{
    public static void Register(IViewRegistry views, IRouteRegistry routes)
    {
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
