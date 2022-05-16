using MainView.ViewModels;
using System;
using System.Windows.Input;

namespace MainView.Commands
{
    public class DelegateCommand : ICommand
    {

        private readonly Action<object?> execute;
        private readonly Func<object, bool>? canExecute;

        public DelegateCommand(Action<object?> execute, Func<object,bool> canExecute = null)
        {
            ArgumentNullException.ThrowIfNull(execute);
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object? parameter)
        { 
            execute.Invoke(parameter);
        }

    }
}
