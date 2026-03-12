using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFNavigation.Commands;
using WPFNavigation.Stores;
using WPFNavigation.Services;

namespace WPFNavigation.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand NavigateFirstViewCommand { get; }
        public ICommand NavigateSecondViewCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
           
            NavigationService navigateFirstService = new NavigationService(navigationStore, () => new FirstViewModel(navigationStore));
            NavigateFirstViewCommand = new NavigateCommand(navigateFirstService);

           
            NavigationService navigateSecondService = new NavigationService(navigationStore, () => new SecondViewModel(navigationStore));
            NavigateSecondViewCommand = new NavigateCommand(navigateSecondService);
        }
    }
}
