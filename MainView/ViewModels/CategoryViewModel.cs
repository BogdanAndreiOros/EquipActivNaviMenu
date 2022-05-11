using MainView.DataProviders;
using MainView.Models;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using MainView.Commands;
using System.Text;
using System.Windows;

namespace MainView.ViewModels
{
    public class CategoryViewModel : ViewModelBase
    {

        public CategorySelectorViewModel selectorViewModel { get; }
        private readonly IDataProvider categoryDataProvider;
        public DelegateCommand AddCommand { get; }


        public string BoxText { get; set; } = new string("this is the initial text");
        public ObservableCollection<ICategory> CategoryItems { get; set; } = new();
        public IEnumerable<ICategory> MockCategoryItems { get; set; } = new List<Equipment>
            {
                 new Equipment {LastModifiedOn = new System.DateOnly(2022,10,4), CreatedBy = "Johnny", CreatedOn = new System.DateOnly(2022,1,1),
                               Id = new System.Xml.UniqueId(), Name = "Paddle", Quantity = 52, Type = Type.WaterSports },

                 new Equipment {LastModifiedOn = new System.DateOnly(2015,12,11), CreatedBy = "Bobby", CreatedOn = new System.DateOnly(2012,6,6),
                               Id = new System.Xml.UniqueId(), Name = "Football", Quantity = 168, Type = Type.BallSports },

                 new Equipment {LastModifiedOn = new System.DateOnly(2022,5,15), CreatedBy = "Charlotte", CreatedOn = new System.DateOnly(2021,4,18),
                               Id = new System.Xml.UniqueId(), Name = "FitBand", Quantity = 52, Type = Type.Accesories },

                 new Equipment {LastModifiedOn = new System.DateOnly(2010,6,5), CreatedBy = "Nancy", CreatedOn = new System.DateOnly(2005,10,9),
                               Id = new System.Xml.UniqueId(), Name = "Protein Bar", Quantity = 52, Type = Type.Others },

                 new Equipment {LastModifiedOn = new System.DateOnly(2020,11,23), CreatedBy = "Sarah", CreatedOn = new System.DateOnly(2020,11,22),
                               Id = new System.Xml.UniqueId(), Name = "Tennis Shirt", Quantity = 52, Type = Type.Clothes },

                 new Equipment {LastModifiedOn = new System.DateOnly(2022,1,25), CreatedBy = "Johnny", CreatedOn = new System.DateOnly(2009,2,26),
                               Id = new System.Xml.UniqueId(), Name = "Basketball", Quantity = 52, Type = Type.BallSports }
            };

        public CategoryViewModel(IDataProvider dataProvider)
        {
            selectorViewModel = new CategorySelectorViewModel();
            categoryDataProvider = dataProvider;

            AddCommand = new DelegateCommand(Add);
        }
        public override void GetCategoryItems()
        {

            //if (CategoryItems.Any())
              //  return;

            var items = categoryDataProvider.GetMockData();

            if (items is not null)
                foreach (var item in items)
                    CategoryItems.Add(item);
        }

        private void Add(object? parameter)
        {
            BoxText = "Updated in the command";
            MessageBox.Show("Command Works");
            MessageBox.Show(BoxText);

            /* var item = parameter as ICategory;
             CategoryItems.Add(item);*/
           /* MockCategoryItems = MockCategoryItems.Append(new Equipment());
            MockCategoryItems = MockCategoryItems.Append(new Equipment());
            MockCategoryItems = MockCategoryItems.Append(new Equipment());
            MockCategoryItems = MockCategoryItems.Append(new Equipment());*/

        }
    }
}
