using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Tema1_Restaurant.Model.BusinessLogicLayer;
using Tema1_Restaurant.Commands;
using Tema1_Restaurant.Model;
using Tema1_Restaurant.Views;
using GalaSoft.MvvmLight.Messaging;


namespace Tema1_Restaurant.ViewModels
{
    internal class LoginVM : BaseVM
    {
        //nu se pot modifica pentru ca nu trebuie
        private readonly UserBLL userBLL = new UserBLL();
        private readonly EmployeeBLL employeeBLL = new EmployeeBLL();

        private string username;
        private string password;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                NotifyPropertyChanged("Username");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
        }

        private ICommand loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (loginCommand == null)
                {
                    loginCommand = new RelayCommand(Login);
                }
                return loginCommand;
            }

        }

        //trimite fereastra curenta ca parametru ca sa o putem inchide
        public void Login(object param)
        {
            Users User = userBLL.Login(Username, Password);
            if (User != null)
            {
                if (User.Role == "Administrator")
                {
                    //creaza o fereastra noua
                    AdminWindow adminWindow = new AdminWindow();
                    //inchide pe cea veche
                    (param as Window).Close();
                    //deschide si afiseaza fereastra noua
                    adminWindow.ShowDialog();
                }
                else if (User.Role == "Waiter")
                {
                    EmployeeWindow employeeWindow = new EmployeeWindow();
                    int employeeId = employeeBLL.GetEmployeeID(Username,Password);
                    //trimitem datele despre un employee intre ViewModels
                    Messenger.Default.Send(employeeId);
                    (param as Window).Close();
                    employeeWindow.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
        }
    }
}
