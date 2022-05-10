using MainView.DataProviders;
using MainView.ViewModels;
using System.Windows;

namespace MainView
{

    public partial class MainWindow : Window
    {
        private readonly CategoryViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new CategoryViewModel(new ActivityDataProvider());
            viewModel.GetCategoryItems();
            DataContext = viewModel;
        }


        /*public MainWindow(CategoryViewModel model)
        {
           InitializeComponent();
           viewModel = model;
           DataContext = viewModel;
        }*/
    }
}
