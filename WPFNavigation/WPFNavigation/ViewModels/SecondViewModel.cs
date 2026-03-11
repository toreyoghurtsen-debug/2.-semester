using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFNavigation.Commands;
using WPFNavigation.Stores;

namespace WPFNavigation.ViewModels
{
    public class SecondViewModel : BaseViewModel
    {
      
        public ICommand NavigateToHomeCommand { get; }

      
        public SecondViewModel(NavigationStore navigationStore)
        {
          
            NavigateToHomeCommand = new NavigateToHomeCommand(navigationStore);
        }
    }
}