using MainView.DataProviders;
using MainView.Models;
using MainView.ViewModels;
using Moq;
using System.Linq;
using Xunit;

namespace EquipActivNaviTests
{

    public class ActivityViewModelsTests
    {  

       [Fact]
        public void Initialize_WhenDataProvider_IsNotInstantiated_LeavesActivityItemsEmpty()
        {
            var activities = new ActivityViewModel();

            activities.Initialize();

            Assert.Empty(activities.ActivityItems);
        }

        [Fact]
        public void GetCategoryItems_ReturnsAllItems_FromDataProviderMethod()
        {
            Mock<ActivityDataProvider> MockActivityDataProvider = new Mock<ActivityDataProvider>();
            ActivityViewModel activities = new(MockActivityDataProvider.Object);


            activities.GetCategoryItems();
            var nrOfDataEntriesFromViewModelMethod = activities.ActivityItems.Count();

            var ActivityItems = MockActivityDataProvider.Object.GetMockData();
            var nrOfDataEntriesFromDataProviderMethod = ActivityItems.Count();

            
            Assert.Equal(nrOfDataEntriesFromDataProviderMethod, nrOfDataEntriesFromViewModelMethod);

        }

        [Fact]
        public void GetCategoryItems_Returns_WhenActivityItems_IsNotEmpty()
        {

            ActivityViewModel activities = new();


            activities.ActivityItems.Add(new Activity());
            activities.GetCategoryItems();


            Assert.Single(activities.ActivityItems);        
        }
    }
}
