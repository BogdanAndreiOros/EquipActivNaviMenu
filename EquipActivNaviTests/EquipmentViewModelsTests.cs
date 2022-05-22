using MainView.DataProviders;
using MainView.Models;
using MainView.ViewModels;
using Moq;
using System;
using System.Linq;
using Xunit;

namespace EquipActivNaviTests
{
    public class EquipmentViewModelsTests
    {

        [Fact]
        public void Initialize_WhenDataProvider_IsNotInstantiated_LeavesActivityItemsEmpty()
        {
            var equipments = new EquipmentViewModel();

            equipments.Initialize();

            Assert.Empty(equipments.EquipmentItems);
        }


        [Fact]
        public void GetCategoryItems_ReturnsAllItems_FromDataProviderMethod()
        {
            Mock<EquipmentDataProvider> MockActivityDataProvider = new Mock<EquipmentDataProvider>();
            EquipmentViewModel equipmentViewModel = new(MockActivityDataProvider.Object);


            equipmentViewModel.GetCategoryItems();
            var nrOfDataEntriesFromViewModelMethod = equipmentViewModel.EquipmentItems.Count();

            var equipmentItems = MockActivityDataProvider.Object.GetMockData();
            var nrOfDataEntriesFromDataProviderMethod = equipmentItems.Count();


            Assert.Equal(nrOfDataEntriesFromDataProviderMethod, nrOfDataEntriesFromViewModelMethod);

        }

        [Fact]
        public void GetCategoryItems_Returns_WhenActivityItems_IsNotEmpty()
        {

            EquipmentViewModel equipments = new();


            equipments.EquipmentItems.Add(new Equipment());
            equipments.GetCategoryItems();


            Assert.Single(equipments.EquipmentItems);
        }

        [Fact]
        public void GetEquipmentTypes_ReturnsAllTypesFoundInEnumeration()
        {
            Mock<EquipmentDataProvider> MockActivityDataProvider = new Mock<EquipmentDataProvider>();
            EquipmentViewModel equipmentViewModel = new(MockActivityDataProvider.Object);

            var equipmentTypes = equipmentViewModel.GetEquipmentTypes();

            foreach (MainView.Models.Type type in Enum.GetValues(typeof(MainView.Models.Type)))
            {
                Assert.Contains<MainView.Models.Type>(type, equipmentTypes);
            }
        }
    }
}
