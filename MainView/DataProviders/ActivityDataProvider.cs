using MainView.Models;
using System;
using System.Collections.Generic;

namespace MainView.DataProviders
{
    public class ActivityDataProvider : IDataProvider<Activity>
    {
        public IEnumerable<Activity> GetMockData()
        {
            return new List<Activity>
            {
                new Activity{Name = "Paddleboarding", CreatedBy = "Sarah", CreatedOn = new System.DateOnly(2003,7,25),
                             Id = Guid.NewGuid().ToString(), LastModifiedOn = new System.DateOnly(2010,5,16)},

                 new Activity{Name = "Pilates", CreatedBy = "Johnn-y", CreatedOn = new System.DateOnly(2022,1,22),
                             Id = Guid.NewGuid().ToString(), LastModifiedOn = new System.DateOnly(2022,2,10)},

                 new Activity{Name = "Tennis", CreatedBy = "Charlotte", CreatedOn = new System.DateOnly(2018,6,18),
                             Id = Guid.NewGuid().ToString(), LastModifiedOn = new System.DateOnly(2019,5,16)},

                 new Activity{Name = "Boxing", CreatedBy = "Bobby", CreatedOn = new System.DateOnly(2010,11,2),
                             Id = Guid.NewGuid().ToString(), LastModifiedOn = new System.DateOnly(2011,1,12)},

                 new Activity{Name = "Soccer",CreatedBy = "Nancy", CreatedOn = new System.DateOnly(2002,12,1),
                             Id = Guid.NewGuid().ToString(), LastModifiedOn = new System.DateOnly(2012,1,12)},
            };
        }
    }
}
