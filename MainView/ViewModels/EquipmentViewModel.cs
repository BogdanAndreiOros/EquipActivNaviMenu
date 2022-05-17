using MainView.Commands;
using MainView.DataProviders;
using MainView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MainView.ViewModels
{
    public  class EquipmentViewModel : ViewModelBase
    {
        #region Storage
        private readonly IDataProvider<Equipment> equipmentDataProvider;
        public ObservableCollection<Equipment> EquipmentItems { get; set; } = new();
        #endregion

        #region PopupWindow 
        private EquipmentItemAdderWindow equipmentItemAdderWindow { get; set; }
        #endregion

        #region Commands
        public DelegateCommand ConfirmNewItemCommand { get; }
        public DelegateCommand AddCommand { get; }
        #endregion

        #region Helper Methods
        public void GetCategoryItems()
        {
            if (EquipmentItems.Any())
                return;
            var EquipItems = equipmentDataProvider.GetMockData(); 

            if (EquipItems is not null)
            {
                foreach (var item in EquipItems)
                    EquipmentItems.Add(item);
            }
        }

        public List<Models.Type> GetEquipmentTypes()
        {
            var equipmentTypes = new List<Models.Type>();
            foreach (Models.Type type in Enum.GetValues(typeof(Models.Type)))
            {
                equipmentTypes.Add(type);
            }

            return equipmentTypes;
        }
        #endregion
        #region Constructor

        public EquipmentViewModel(IDataProvider<Equipment> EquipmentDataProvider)
        {
            equipmentDataProvider = EquipmentDataProvider;
            GetCategoryItems();
            AddCommand = new DelegateCommand(Add);
            ConfirmNewItemCommand = new DelegateCommand(ConfirmNewItem);

        }
        #endregion

        #region Command Methods
        private void Add(object? parameter)
        {       
            equipmentItemAdderWindow =  new EquipmentItemAdderWindow();
            equipmentItemAdderWindow.ConfirmationButton.Command = ConfirmNewItemCommand;
            equipmentItemAdderWindow.Show();          
            equipmentItemAdderWindow.TypeComboBox.ItemsSource = GetEquipmentTypes();
        }

        private void ConfirmNewItem(object? parameter)
        {
            var equipment = new Equipment();

            equipment.Name = equipmentItemAdderWindow.NameTextBox.Text.ToString();
            equipment.CreatedBy = equipmentItemAdderWindow.CreatedByTextBox.Text.ToString();
            equipment.Id = Guid.NewGuid().ToString();
            equipment.CreatedOn = DateOnly.FromDateTime(DateTime.Now);
            equipment.Quantity = Int32.Parse(equipmentItemAdderWindow.QuantityTextBox.Text);
            equipment.Type = (Models.Type)equipmentItemAdderWindow.TypeComboBox.SelectedItem;
            equipment.LastModifiedOn = DateOnly.FromDateTime(DateTime.Now);

            EquipmentItems.Add(equipment);
            equipmentItemAdderWindow.Close();
        }
        #endregion
    }
}
