using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SS14.Launcher.Views
{
    public class OptionsTabView : UserControl
    {
        public OptionsTabView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}