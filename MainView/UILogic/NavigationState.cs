using MainView.Commands;
using MainView.ViewModels;
using System;

namespace MainView.UILogic
{
    public class NavigationState
    {
        public ViewModelBase CurrentViewModel { get => currentViewModel; set { currentViewModel = value;
            } }

        private ViewModelBase currentViewModel;
        
    }  
}
