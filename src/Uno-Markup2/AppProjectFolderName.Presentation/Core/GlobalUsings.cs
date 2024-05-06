// Non-Uno global usings that would be generated if ImplicitUsings was enabled in the project file:
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

#if(presentation == 'mvux')
global using Uno.Extensions.Reactive;

#endif
#if(presentation == 'mvvm')
// MVVM presentation pattern:
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;

#endif
// Uno navigation for use in models:
global using Uno.Extensions.Navigation;

// Markup extension methods:
global using CSharpMarkup.WinUI;
global using CSharpMarkup.WinUI.Uno.Extensions.Navigation;
global using CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit;
#if(presentation == 'mvux')
global using CSharpMarkup.WinUI.Uno.Extensions.Reactive;
#endif
global using CSharpMarkup.WinUI.Uno.Toolkit;
global using $namespacePrefix$.Presentation.Core;

// Markup helpers:
global using static CSharpMarkup.WinUI.Helpers;
global using static CSharpMarkup.WinUI.Uno.Extensions.Navigation.Helpers;
global using static CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit.Helpers;
#if(presentation == 'mvux')
global using static CSharpMarkup.WinUI.Uno.Extensions.Reactive.Helpers;
#endif
global using static CSharpMarkup.WinUI.Uno.Toolkit.Helpers;
global using static $namespacePrefix$.Presentation.Core.MarkupHelpers;

// Aliases for WinUI namespaces and types
// - Use to avoid including WinUI namespaces, which can cause ambiguities with the CSharpMarkup namespaces
// - Prefix namespaces and view type aliases with "UI"
global using UI = Microsoft.UI;
global using UIBindable = Microsoft.UI.Xaml.Data.BindableAttribute;
global using UIControls = Microsoft.UI.Xaml.Controls;
// - Non-view types, e.g. enums, don't need a UI prefix because they are not mirrored as types in the CSharpMarkup namespaces
global using BindingMode = Microsoft.UI.Xaml.Data.BindingMode;
global using Visibility = Microsoft.UI.Xaml.Visibility;
