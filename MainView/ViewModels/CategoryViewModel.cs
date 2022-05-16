using MainView.DataProviders;
using MainView.Models;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using MainView.Commands;
using System.Text;
using System.Windows;
using System.Xml;
using MainView.UILogic;

namespace MainView.ViewModels
{
    public class CategoryViewModel : ViewModelBase
    {

        public CategorySelectorViewModel selectorViewModel { get; }

        private readonly IDataProvider<Equipment> equipmentDataProvider;
        private readonly IDataProvider<Activity> activityDataProvider;


        public string BoxText { get; set; } = new string("this is the initial text");

        public ObservableCollection<Equipment> EquipmentItems { get; set; } = new();
        public ObservableCollection<Activity> ActivityItems { get; set; } = new();  

        public DelegateCommand AddCommand { get; }
        public DelegateCommand NavigateToHomeViewCommand { get; }
 
        public CategoryViewModel(IDataProvider<Activity> ActivitydataProvider, IDataProvider<Equipment> EquipmentDataProvider)
        {
            selectorViewModel = new CategorySelectorViewModel();
            equipmentDataProvider = EquipmentDataProvider;
            activityDataProvider = ActivitydataProvider;
            GetCategoryItems();
            AddCommand = new DelegateCommand(Add);
        }

        public void GetCategoryItems()
        {
            if (EquipmentItems.Any() && ActivityItems.Any())
               return;

            var EquipItems = equipmentDataProvider.GetMockData();
            var ActivItems = activityDataProvider.GetMockData();

            if (EquipItems is not null && ActivItems is not null)
            {
                foreach (var item in EquipItems)
                    EquipmentItems.Add(item);
                foreach (var item in ActivItems)
                    ActivityItems.Add(item);
            }
            
        }

        private void Add(object? parameter)
        {
            //MessageBox.Show("Command Works");
            //MessageBox.Show(BoxText);

            var equipment = new Equipment();

            EquipmentItems.Add(equipment);         
        }
    }
}
