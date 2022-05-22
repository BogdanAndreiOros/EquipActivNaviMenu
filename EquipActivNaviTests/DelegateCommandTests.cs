using MainView.Commands;
using Moq;
using System;
using Xunit;

namespace EquipActivNaviTests
{
    public class DelegateCommandTests
    {


        [Fact]
        public void CanExecute_IfNull_Returns_Null()
        {
            Mock<Action<object?>> MockAction = new Mock<Action<object?>>();
            Mock<object?> MockObject = new Mock<object?>(); 
            DelegateCommand MockDelegate = new DelegateCommand(MockAction.Object);


            var canExecuteIfNull = MockDelegate.CanExecute(MockObject);


            Assert.True(canExecuteIfNull == true);
        }


        [Fact]
        public void CanExecute_ReturnsFalse_IfcanExecute_IsFalse()
        {
            Mock<Action<object?>> MockAction = new Mock<Action<object?>>();
            Mock<object?> MockObject = new Mock<object?>();
            Mock<Func<object, bool>> MockFunc = new Mock<Func<object, bool>>();
            DelegateCommand MockDelegate = new DelegateCommand(MockAction.Object, MockFunc.Object);


            var canExecuteIfNull = MockDelegate.CanExecute(null);


            Assert.True(canExecuteIfNull == false);
        }    
       
    }
}