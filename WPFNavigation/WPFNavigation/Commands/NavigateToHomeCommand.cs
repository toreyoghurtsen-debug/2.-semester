using System;
using System.Windows.Input;
using WPFNavigation.Stores;
using WPFNavigation.ViewModels;

namespace WPFNavigation.Commands
{
    public class NavigateToHomeCommand : ICommand
    {
        private readonly NavigationStore _navigationStore;

        public NavigateToHomeCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
           
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);
        }

        public event EventHandler? CanExecuteChanged;
    }
}