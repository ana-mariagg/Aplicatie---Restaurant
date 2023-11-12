using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Restaurant.Model;

namespace Tema1_Restaurant.ViewModels
{
    internal class EmployeeVM:BaseVM
    {
        private string userID;
        private string firstName;
        private string lastName;

        public EmployeeVM(string userID, string firstName, string lastName)
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
    }
}
