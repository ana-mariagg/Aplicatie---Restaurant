using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tema1_Restaurant.Commands
{
    //paseaza mai departe datele
    internal class RelayCommand : ICommand //implementeaza functiile de execute si canexecute
    {
        private Action<object> execute;

        public event EventHandler CanExecuteChanged
        {
            add
            {
                //+=asociaza un handler la un eveniment
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                //-=sterge un handler de la un eveniment
                CommandManager.RequerySuggested -= value;
            }
        }

        public RelayCommand(Action<object> execute)
        {
            this.execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
