using System.Collections.Generic;

namespace MainView.DataProviders
{
    public interface IDataProvider<T> where T : class
    {
        IEnumerable<T> GetMockData();
    }
}
