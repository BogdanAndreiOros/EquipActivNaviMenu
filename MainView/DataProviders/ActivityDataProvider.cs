using MainView.Models;
using System.Collections.Generic;
using System.Xml;

namespace MainView.DataProviders
{
    public class ActivityDataProvider : IDataProvider
    {
        public IEnumerable<ICategory> GetMockData()
        {
            return new List<Activity>
            {
                new Activity{Name = "Paddleboarding", CreatedBy = "Sarah", CreatedOn = new System.DateOnly(2002,12,1),
                             Id = new UniqueId(), LastModifiedOn = new System.DateOnly(2019,5,16)},

                 new Activity{Name = "Pilates", CreatedBy = "Johnn-y", CreatedOn = new System.DateOnly(2002,12,1),
                             Id = new UniqueId(), LastModifiedOn = new System.DateOnly(2019,5,16)},

                 new Activity{Name = "Tennis", CreatedBy = "Charlotte", CreatedOn = new System.DateOnly(2002,12,1),
                             Id = new UniqueId(), LastModifiedOn = new System.DateOnly(2019,5,16)},

                 new Activity{Name = "Boxing", CreatedBy = "Bobby", CreatedOn = new System.DateOnly(2002,12,1),
                             Id = new UniqueId(), LastModifiedOn = new System.DateOnly(2019,5,16)},

                 new Activity{Name = "Soccer",CreatedBy = "Nancy", CreatedOn = new System.DateOnly(2002,12,1),
                             Id = new UniqueId(), LastModifiedOn = new System.DateOnly(2019,5,16)},
            };
        }
    }
}
