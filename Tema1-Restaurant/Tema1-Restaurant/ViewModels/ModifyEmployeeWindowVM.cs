using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Restaurant.Commands;
using GalaSoft;
using System.Windows.Input;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace Tema1_Restaurant.ViewModels
{
    internal class ModifyEmployeeWindowVM : BaseVM
    {
        private string userID;
        private string firstName;
        private string lastName;

        public ModifyEmployeeWindowVM()
        {
            Messenger.Default.Register<EmployeeVM>(this, (ReceivedEmployee) =>
            {
                UserID= ReceivedEmployee.UserID;
                FirstName= ReceivedEmployee.FirstName;
                LastName= ReceivedEmployee.LastName;
            });
           // Messenger.Default.Unregister<EmployeeVM>(this);
        }
        public ModifyEmployeeWindowVM(string userID, string firstName, string lastName)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
        }

        public string UserID
        {
            get { return userID; }
            set
            {
                userID = value;
                NotifyPropertyChanged("UserID");
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                NotifyPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                NotifyPropertyChanged("LastName");
            }
        }

        private ICommand modifyEmployeeCommand;
        public ICommand ModifyEmployeeCommand
        {
            get
            {
                if (modifyEmployeeCommand == null)
                {
                    modifyEmployeeCommand = new RelayCommand(ModifyEmployee);
                }
                return modifyEmployeeCommand;
            }
        }
        private void ModifyEmployee(object param)
        {
            EmployeeVM employee = new EmployeeVM(UserID, FirstName, LastName);
            Messenger.Default.Send(employee);
            if (param is Window window)
            {
                window.Close();
            }
        }

    }
}
