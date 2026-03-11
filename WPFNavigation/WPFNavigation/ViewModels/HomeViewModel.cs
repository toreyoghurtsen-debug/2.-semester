using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFNavigation.Commands;
using WPFNavigation.Stores;

namespace WPFNavigation.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand NavigateToFirstViewCommand { get; }
        public ICommand NavigateToSecondViewCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateToFirstViewCommand = new NavigateToFirstViewCommand(navigationStore);
         
            NavigateToSecondViewCommand = new NavigateToSecondViewCommand(navigationStore);
        }
    }
}
