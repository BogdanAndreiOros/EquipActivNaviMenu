using System.ComponentModel;

namespace MainView.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public abstract void GetCategoryItems();
    }
}
