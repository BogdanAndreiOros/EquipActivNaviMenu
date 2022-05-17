using MainView.DataProviders;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using MainView.ViewModels;
using MainView.Models;

namespace MainView
{
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<MainWindow>();

            services.AddTransient<MainViewModel>();

            services.AddTransient<HomeViewModel>();
            services.AddTransient<EquipmentViewModel>();
            services.AddTransient<ActivityViewModel>();

            services.AddTransient<IDataProvider<Activity>, ActivityDataProvider>();
            services.AddTransient<IDataProvider<Equipment>,EquipmentDataProvider>();

        }

        public App()
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow?.Show();
        }
    }
}
