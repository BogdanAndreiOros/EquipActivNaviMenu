using MainView.Commands;
using MainView.UILogic;
using System.Windows;

namespace MainView.ViewModels
{
    public class CategorySelectorViewModel
    {
        public GridTableSwapper currentTable { get; set; } = new();

        public DelegateCommand SwitchTableToActivitiesCommand { get; }
        public DelegateCommand SwitchTableToEquipmentCommand { get; }

        public CategorySelectorViewModel()
        {
            SwitchTableToActivitiesCommand = new DelegateCommand(SwitchTableToActivities);
            SwitchTableToEquipmentCommand = new DelegateCommand(SwitchTableToEquipment);
        }
        private void SwitchTableToActivities(object? parameter)
        {
            currentTable.SwapGridToActivityTable();
            MessageBox.Show(" Activity index:"+currentTable.ActivityGridIndex.ToString()+" Equipment index:" + currentTable.EquipmentGridIndex.ToString());
        }

        private void SwitchTableToEquipment(object? parameter)
        {
            currentTable.SwapGridToEquipmentTable();
            MessageBox.Show(" Activity index:" + currentTable.ActivityGridIndex.ToString() + " Equipment index:" + currentTable.EquipmentGridIndex.ToString());
        }

    }
}
