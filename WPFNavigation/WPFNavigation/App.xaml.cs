using System.Configuration;
using System.Data;
using System.Windows;
using WPFNavigation.Stores;
using WPFNavigation.ViewModels;

namespace WPFNavigation
{
    public partial class App : Application
    {
        
        private NavigationStore _navigationStore;

   
        protected override void OnStartup(StartupEventArgs e)
        {
            
            _navigationStore = new NavigationStore();

        
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);

           
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}