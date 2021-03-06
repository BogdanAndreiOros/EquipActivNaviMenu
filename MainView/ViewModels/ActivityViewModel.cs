using MainView.DataProviders;
using MainView.Models;
using System.Linq;
using System.Collections.ObjectModel;
using MainView.Commands;
using System;

namespace MainView.ViewModels
{
    public class ActivityViewModel : ViewModelBase
    {
        #region Storage
        private readonly IDataProvider<Activity> activityDataProvider;
        public ObservableCollection<Activity> ActivityItems { get; set; } = new();
        #endregion

        #region PopupWindow 
        public ActivityItemAdderWindow activityItemAdderWindow { get; set; }
        #endregion

        #region Commands
        public DelegateCommand AddCommand { get; }
        public DelegateCommand ConfirmNewItemCommand { get; }
        #endregion

        #region Constructors

        public ActivityViewModel() 
        {
        }

        public ActivityViewModel(IDataProvider<Activity> ActivitydataProvider)
        {
           
            activityDataProvider = ActivitydataProvider;
            AddCommand = new DelegateCommand(Add);
            ConfirmNewItemCommand = new DelegateCommand(ConfirmNewItem);
        }
        #endregion

        #region Helper Methods

        public override void Initialize()
        {
            if (isInitialized == false)
            {
                isInitialized = true;
                GetCategoryItems();
            }
        }

        public void GetCategoryItems()
        {
            if (this.ActivityItems.Any())
               return;
          
            var ActivityItems = activityDataProvider?.GetMockData();
           
            if (ActivityItems is not null)
            {
                foreach (var item in ActivityItems)
                    this.ActivityItems.Add(item);
            }   
        }
        #endregion

        #region Command Methods
        private void Add(object? parameter) 
        {          
            activityItemAdderWindow = new ActivityItemAdderWindow();
            activityItemAdderWindow.Show();
            activityItemAdderWindow.ConfirmationButton.Command = ConfirmNewItemCommand;
        }

        private void ConfirmNewItem(object? parameter) 
        {
            var activity = new Activity();

            activity.Name = activityItemAdderWindow.NameTextBox.Text.ToString();
            activity.CreatedBy = activityItemAdderWindow.CreatedByTextBox.Text.ToString();
            activity.Id = Guid.NewGuid().ToString();
            activity.CreatedOn = DateOnly.FromDateTime( DateTime.Now);
            activity.LastModifiedOn = DateOnly.FromDateTime(DateTime.Now);

            ActivityItems.Add(activity);
            activityItemAdderWindow.Close();
        }


        #endregion
    }
}
