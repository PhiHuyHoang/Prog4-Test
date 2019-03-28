using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace prog4_zh1_rep_1.VM
{
    class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        Action<object> toExecute;

        public RelayCommand(Action<object> toExecute)
        {
            this.toExecute = toExecute;
        }

        public void Execute(object parameter)
        {
            toExecute?.Invoke(parameter);
        }
    }
}
