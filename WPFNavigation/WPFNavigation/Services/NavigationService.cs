using System;
using System.Collections.Generic;
using System.Text;
using WPFNavigation.ViewModels;
using WPFNavigation.Stores;
using WPFNavigation.Commands;
using WPFNavigation.Views;
using System.Windows.Input;

namespace WPFNavigation.Services
{
   public class NavigationService
   {
        private readonly NavigationStore _navigationStore;
        private readonly Func<BaseViewModel> _viewModelFactory;

        public NavigationService(NavigationStore navigationStore, Func<BaseViewModel> viewModelFactory)
        {
            _navigationStore = navigationStore;
            _viewModelFactory = viewModelFactory;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _viewModelFactory();
        }
    
    }
}
