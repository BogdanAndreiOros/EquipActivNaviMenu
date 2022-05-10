using MainView.Models;
using System.Collections.Generic;

namespace MainView.DataProviders
{
    public interface IDataProvider
    {
        IEnumerable<ICategory> GetMockData();
    }
}
