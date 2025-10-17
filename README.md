# FluentUIMauiNullReferenceException

Project illustrating a `NullReferenceException` when using FluentUI components in a .NET MAUI application.
Uses package FluentIcons.Maui version 1.1.312.
When adding a button with a SymbolImageSource as ImageSource throws a `NullReferenceException` when the Xaml gets loaded at runtime.
Note that the exception does not occur if you add the SymbolImageSource in code, only when adding it in XAML.

## Steps to Reproduce
There are 2 MAUI apps in the solution.
FluentUIMauiNullReferenceExceptions : if you run this on Windows Machine, it will throw a `NullReferenceException` when loading the XAML.
WorkingWhenAddingICode : here the SymbolImageSource is added in code, and this works fine.

## Exception Details
Object reference not set to an instance of an object.

Stack trace:
   at Microsoft.Maui.Controls.Xaml.ApplyPropertiesVisitor.ProvideValue(Object& value, ElementNode node, Object source, XmlName propertyName)
   at Microsoft.Maui.Controls.Xaml.ApplyPropertiesVisitor.Visit(ElementNode node, INode parentNode)
   at Microsoft.Maui.Controls.Xaml.ElementNode.Accept(IXamlNodeVisitor visitor, INode parentNode)
   at Microsoft.Maui.Controls.Xaml.ElementNode.Accept(IXamlNodeVisitor visitor, INode parentNode)
   at Microsoft.Maui.Controls.Xaml.ElementNode.Accept(IXamlNodeVisitor visitor, INode parentNode)
   at Microsoft.Maui.Controls.Xaml.RootNode.Accept(IXamlNodeVisitor visitor, INode parentNode)
   at Microsoft.Maui.Controls.Xaml.XamlLoader.Visit(RootNode rootnode, HydrationContext visitorContext, Boolean useDesignProperties)
   at Microsoft.Maui.Controls.Xaml.XamlLoader.Load(Object view, String xaml, Assembly rootAssembly, Boolean useDesignProperties)
   at Microsoft.Maui.Controls.Xaml.XamlLoader.Load(Object view, String xaml, Boolean useDesignProperties)
   at Microsoft.Maui.Controls.Xaml.XamlLoader.Load(Object view, Type callingType)
   at Microsoft.Maui.Controls.Xaml.Extensions.LoadFromXaml[TXaml](TXaml view, Type callingType)
   at FluentUIMauiNullReferenceExceptions.MainPage.InitializeComponent() in C:\Users\stefan\source\repos\FluentUIMauiNullReferenceException\FluentUIMauiNullReferenceExceptions\obj\Debug\net9.0-windows10.0.19041.0\win10-x64\Microsoft.Maui.Controls.SourceGen\Microsoft.Maui.Controls.SourceGen.CodeBehindGenerator\MainPage.xaml.sg.cs:line 23
