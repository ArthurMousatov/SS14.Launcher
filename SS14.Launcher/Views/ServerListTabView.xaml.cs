using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SS14.Launcher.Views
 {
     public class ServerListTabView : UserControl
     {
         public ServerListTabView()
         {
             InitializeComponent();
         }

         private void InitializeComponent()
         {
             AvaloniaXamlLoader.Load(this);
         }
     }
 }