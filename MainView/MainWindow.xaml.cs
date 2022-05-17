using MainView.ViewModels;
using System.Windows;

namespace MainView
{

    public partial class MainWindow : Window
    {
        public MainViewModel viewModel { get; }

        public MainWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();
            viewModel = mainViewModel;
            DataContext = viewModel;    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }     
    }
}
