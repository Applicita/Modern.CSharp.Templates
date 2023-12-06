// Include markup extension methods:
global using CSharpMarkup.WinUI;
global using CSharpMarkup.WinUI.Uno.Extensions.Navigation;
global using CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit;
global using CSharpMarkup.WinUI.Uno.Extensions.Reactive;
global using CSharpMarkup.WinUI.Uno.Toolkit;
global using $namespacePrefix$.Presentation.Core;

// Include markup helpers:
global using static CSharpMarkup.WinUI.Helpers;
global using static CSharpMarkup.WinUI.Uno.Extensions.Navigation.Helpers;
global using static CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit.Helpers;
global using static CSharpMarkup.WinUI.Uno.Extensions.Reactive.Helpers;
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
