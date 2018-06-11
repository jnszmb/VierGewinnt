using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    class UserCommands : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<Object> action;
        public UserCommands(Action<object> action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter != null)
            {
                action(parameter);
            }
            else
            {
                action("Hallo Welt");
            }
        }
    }
}
