using MainView.Models;
using System;
using System.Collections.Generic;

using Type = MainView.Models.Type;

namespace MainView.DataProviders
{
    public class EquipmentDataProvider : IDataProvider<Equipment>
    {
        public IEnumerable<Equipment> GetMockData()
        {
            return new List<Equipment>
            {
                 new Equipment {LastModifiedOn = new System.DateOnly(2022,10,4), CreatedBy = "Johnny", CreatedOn = new System.DateOnly(2022,1,1), 
                               Id = Guid.NewGuid().ToString(), Name = "Paddle", Quantity = 52, Type = Type.WaterSports },

                 new Equipment {LastModifiedOn = new System.DateOnly(2015,12,11), CreatedBy = "Bobby", CreatedOn = new System.DateOnly(2012,6,6),
                               Id = Guid.NewGuid().ToString(), Name = "Football", Quantity = 168, Type = Type.BallSports },

                 new Equipment {LastModifiedOn = new System.DateOnly(2022,5,15), CreatedBy = "Charlotte", CreatedOn = new System.DateOnly(2021,4,18),
                               Id = Guid.NewGuid().ToString(), Name = "FitBand", Quantity = 900, Type = Type.Accesories },

                 new Equipment {LastModifiedOn = new System.DateOnly(2010,6,5), CreatedBy = "Nancy", CreatedOn = new System.DateOnly(2005,10,9),
                               Id = Guid.NewGuid().ToString(), Name = "Protein Bar", Quantity =12, Type = Type.Others },

                 new Equipment {LastModifiedOn = new System.DateOnly(2020,11,23), CreatedBy = "Sarah", CreatedOn = new System.DateOnly(2020,11,22),
                               Id = Guid.NewGuid().ToString(), Name = "Tennis Shirt", Quantity = 3, Type = Type.Clothes },

                 new Equipment {LastModifiedOn = new System.DateOnly(2022,1,25), CreatedBy = "Johnny", CreatedOn = new System.DateOnly(2009,2,26),
                               Id = Guid.NewGuid().ToString(), Name = "Basketball", Quantity = 362, Type = Type.BallSports }
            };
        }        
    }
}
