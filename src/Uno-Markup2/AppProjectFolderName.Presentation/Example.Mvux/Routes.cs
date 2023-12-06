namespace $namespacePrefix$.Presentation.CsMarkup2Example;

public static class Routes
{
    public static void Register(IViewRegistry views, IRouteRegistry routes)
    {
        // Note that we use the generated Bindable model types here as a workaround for https://github.com/unoplatform/uno.extensions/issues/924#issuecomment-1822337527
        views.Register(
            new ViewMap(ViewModel: typeof(BindableShellModel)),
            new ViewMap<MainPage, BindableMainModel>(),
            new DataViewMap<SecondPage, BindableSecondModel, Entity>()
        );

        routes.Register(
            new RouteMap("", View: views.FindByViewModel<BindableShellModel>(),
                Nested: new RouteMap[]
                {
                    new RouteMap("Main", View: views.FindByViewModel<BindableMainModel>()),
                    new RouteMap("Second", View: views.FindByViewModel<BindableSecondModel>())
                }
            )
        );
    }
}
