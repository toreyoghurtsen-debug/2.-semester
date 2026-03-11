using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFNavigation.Stores;
using WPFNavigation.ViewModels;

namespace WPFNavigation.Commands
{
    public class NavigateToSecondViewCommand : ICommand
    {
        private readonly NavigationStore _navigationStore;

        public NavigateToSecondViewCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
        
            _navigationStore.CurrentViewModel = new SecondViewModel(_navigationStore);
        }

        public event EventHandler? CanExecuteChanged;
    }
}