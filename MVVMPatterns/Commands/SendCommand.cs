using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMPatterns.Commands
{
    public class SendCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action _action;
        string _message;

        public SendCommand(Action action)
        {
            _action = action;
  
        }

        public bool CanExecute(object parameter)
        {
            
            return true;
        }
        public void Execute(object parameter)
        {
            _action.Invoke();
        }
    }
}
