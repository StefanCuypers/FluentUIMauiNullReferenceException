using FluentIcons.Maui;

namespace WorkingWhenAddingInCode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var fluentSrc = new SymbolImageSource
            {
                Symbol = FluentIcons.Common.Symbol.Dismiss
            };
            btn.ImageSource = fluentSrc;
        }

    }
}
