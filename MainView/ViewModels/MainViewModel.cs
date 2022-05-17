using MainView.Commands;
using MainView.Core;
using MainView.DataProviders;
using System.Windows.Input;

namespace MainView.ViewModels
{
    class MainViewModel : ObservableObject
    {
        #region ViewModels

        public HomeViewModel _homeViewModel { get; }
        public ActivityViewModel _activityViewModel { get; }
        public EquipmentViewModel _equipmentViewModel { get; }

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
        public DelegateCommand ToEquipmentViewCommand { get; }
        public DelegateCommand ToActivityViewCommand { get; }

        #endregion

        #region Constructors

        public MainViewModel()
        {
            _homeViewModel = new HomeViewModel();

            _activityViewModel = new ActivityViewModel(new ActivityDataProvider());

            _equipmentViewModel = new EquipmentViewModel(new EquipmentDataProvider());

            CurrentViewModel = _homeViewModel;

            ToHomeViewCommand = new DelegateCommand(o => { CurrentViewModel = _homeViewModel; });
            ToEquipmentViewCommand = new DelegateCommand(o => { CurrentViewModel = _equipmentViewModel; }); 
            ToActivityViewCommand = new DelegateCommand(o => { CurrentViewModel = _activityViewModel; });
        }

        #endregion      
    }
}
