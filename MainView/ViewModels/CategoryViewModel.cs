using MainView.DataProviders;
using MainView.Models;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace MainView.ViewModels
{
    public class CategoryViewModel : ViewModelBase
    {
        private readonly IDataProvider categoryDataProvider;

        public CategoryViewModel(IDataProvider dataProvider)
        {
            categoryDataProvider = dataProvider;
        }

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

        public override void GetCategoryItems()
        {

            //if (CategoryItems.Any())
              //  return;

            var items = categoryDataProvider.GetMockData();

            if (items is not null)
                foreach (var item in items)
                    CategoryItems.Add(item);
        }
    }
}
