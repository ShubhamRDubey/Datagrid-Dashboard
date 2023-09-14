using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Datagrid_Dashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        
        private bool IsMaximised = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
              if (IsMaximised)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 100;

                    IsMaximised = false;
                }
              else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximised = true;
                }
            }
        }
    }
}
