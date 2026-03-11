using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFNavigation.Commands;
using WPFNavigation.Stores;

namespace WPFNavigation.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {
        public ICommand NavigateToHomeCommand { get; }

        public FirstViewModel(NavigationStore navigationStore)
        {
            NavigateToHomeCommand = new NavigateToHomeCommand(navigationStore);
        }
    }
}
