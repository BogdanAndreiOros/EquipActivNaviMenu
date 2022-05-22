using System.ComponentModel;

namespace MainView.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public bool isInitialized = false;
        public abstract void Initialize();

    }
}
