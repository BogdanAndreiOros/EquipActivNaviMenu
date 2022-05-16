using MainView.Commands;
using MainView.Core;
using MainView.DataProviders;
using MainView.UILogic;

namespace MainView.ViewModels
{
    class MainViewModel : ObservableObject
    {
        #region ViewModels

        public HomeViewModel _homeViewModel { get; }
        public CategoryViewModel _categoryViewModel { get; }

        private object _currentViewModel;

        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands

        public DelegateCommand ToHomeViewCommand { get; }
        public DelegateCommand ToCategoryViewCommand { get; }

        #endregion
        public MainViewModel()
        {
            _homeViewModel = new HomeViewModel();
            _categoryViewModel = new CategoryViewModel(new ActivityDataProvider(), new EquipmentDataProvider());

            CurrentViewModel = _homeViewModel;

            ToHomeViewCommand = new DelegateCommand(o => { CurrentViewModel = _homeViewModel; });
            ToCategoryViewCommand = new DelegateCommand(o => { CurrentViewModel = _categoryViewModel; }); 
        }
    }
}
