using System.Windows;
using System.Windows.Input;

namespace wpfEventRoute
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lbLogs.Items.Add($"sender={sender}\ne.Source={e.Source}");
        }
    }
}