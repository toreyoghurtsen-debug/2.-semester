using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPFNavigation.Stores;
using WPFNavigation.ViewModels;

namespace WPFNavigation.Commands
{
    public class NavigateToFirstViewCommand : ICommand
    {
        private readonly NavigationStore _navigationStore;

        public NavigateToFirstViewCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object? parameter)
        {
            
            _navigationStore.CurrentViewModel = new FirstViewModel(_navigationStore);
        }
    }

}
