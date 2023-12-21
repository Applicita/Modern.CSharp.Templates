namespace $namespacePrefix$.Presentation.Example;

public static class Routes
{
    public static void Register(IViewRegistry views, IRouteRegistry routes)
    {
        views.Register(
            new ViewMap<Shell>(),
            new ViewMap<MainPage>(),
            new DataViewMap<SecondPage, SecondPage.Parameters, string>()
        );

        routes.Register(
            new RouteMap("", View: views.FindByView<Shell>(),
                Nested: new RouteMap[]
                {
                    new RouteMap("Main", View: views.FindByView<MainPage>()),
                    new RouteMap("Second", View: views.FindByView<SecondPage>()),
                }
            )
        );
    }
}
