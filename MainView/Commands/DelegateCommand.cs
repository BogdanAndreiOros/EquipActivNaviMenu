using MainView.ViewModels;
using System;
using System.Windows.Input;

namespace MainView.Commands
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object?> _execute;
        private readonly Func<object, bool>? _canExecute;

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;
        

        public void Execute(object? parameter)
        {

            _execute.Invoke(parameter);
        }

        public DelegateCommand(Action<object?> execute)
        {
            ArgumentNullException.ThrowIfNull(execute);
            _execute = execute;
        }
    }
}
