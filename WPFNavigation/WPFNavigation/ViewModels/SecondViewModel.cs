using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFNavigation.Commands;
using WPFNavigation.Stores;
using WPFNavigation.Services;

namespace WPFNavigation.ViewModels
{
    public class SecondViewModel : BaseViewModel
    {
      
        public ICommand NavigateToHomeCommand { get; }

      
        public SecondViewModel(NavigationStore navigationStore)
        {
            
            NavigationService navigateHomeService = new NavigationService(navigationStore, () => new HomeViewModel(navigationStore));

          
            NavigateToHomeCommand = new NavigateCommand(navigateHomeService);
        }
    }
}