using MainView.DataProviders;
using MainView.ViewModels;
using System.Windows;

namespace MainView
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }     
    }
}
