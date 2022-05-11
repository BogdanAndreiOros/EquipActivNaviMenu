using MainView.Commands;
using System.Windows;

namespace MainView.ViewModels
{
    public class CategorySelectorViewModel
    {

        public DelegateCommand SwitchTableToActivitiesCommand { get; }
        public DelegateCommand SwitchTableToEquipmentCommand { get; }

        private void SwitchTableToActivities(object? parameter)
        {
            MessageBox.Show("Called switch to activities tab");
        }

        private void SwitchTableToEquipment(object? parameter)
        {
            MessageBox.Show("Called switch to activities tab");
        }

        public CategorySelectorViewModel()
        {
            SwitchTableToActivitiesCommand = new DelegateCommand(SwitchTableToActivities);
            SwitchTableToEquipmentCommand = new DelegateCommand(SwitchTableToEquipment);
        }
    }
}
