using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GeographyDemo.UI
{
    class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Func<object, bool> canExecute;
        private Action<object> execute;
        public DelegateCommand(Func<object, bool> canExecute, Action<object> execute)
        {
            this.canExecute = canExecute;
            this.execute = execute;
        }
        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            if(execute != null)
            {
                execute(parameter);
            }
        }

        public void RaiseCanExecuteChanged()
        {
            var canExecuteChanged = CanExecuteChanged;
            //take a reference to avoid threading issues (unsubscribe between checking and calling)
            if(canExecuteChanged != null)
            {
                canExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
