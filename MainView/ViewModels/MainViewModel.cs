using MainView.Commands;
using MainView.Core;
using MainView.DataProviders;
using System.Windows.Input;

namespace MainView.ViewModels
{
    public class MainViewModel : ObservableObject
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

        public DelegateCommand ToHomeViewCommand { get; private set; }
        public DelegateCommand ToEquipmentViewCommand { get; private set; }
        public DelegateCommand ToActivityViewCommand { get; private set; }

        #endregion

        #region Constructors

        public MainViewModel(HomeViewModel homeViewModel, ActivityViewModel activityViewModel, EquipmentViewModel equipmentViewModel)
        {
            CurrentViewModel =  _homeViewModel = homeViewModel; 

            _activityViewModel = activityViewModel;

            _equipmentViewModel = equipmentViewModel;

            SetUpDelegateCommands();
        }

        #endregion

        #region HelperMethods
        public void SetUpDelegateCommands()
        {
            ToHomeViewCommand = new DelegateCommand(o => { CurrentViewModel = _homeViewModel; });
            ToEquipmentViewCommand = new DelegateCommand(o => { CurrentViewModel = _equipmentViewModel; });
            ToActivityViewCommand = new DelegateCommand(o => { CurrentViewModel = _activityViewModel; });
        }
        #endregion
    }
}
