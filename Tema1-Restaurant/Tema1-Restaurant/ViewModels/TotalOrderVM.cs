using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tema1_Restaurant.Model;
using Tema1_Restaurant.Commands;
using GalaSoft;
using System.Windows;

namespace Tema1_Restaurant.ViewModels
{
    internal class TotalOrderVM:BaseVM
    {
        private  EmployeeVM e;
        private  DiningTableVM dt;
        private  OrdersVM o ;

        public TotalOrderVM()
        {
            Messenger.Default.Register<EmployeeVM>(this, (ReceivedEmployee) =>
            {
                e = ReceivedEmployee;
            });
            // Messenger.Default.Unregister<EmployeeVM>(this);
        }

        private ICommand totalOrderCommand;
        public ICommand TotalOrderCommand
        {
            get
            {
                if (totalOrderCommand == null)
                {
                    totalOrderCommand = new RelayCommand(TotalOrder);
                }
                return totalOrderCommand;
            }
        }
        private void TotalOrder(object param)
        {
            EmployeeVM employee = new EmployeeVM(e.UserID,e.FirstName,e.LastName);
            Messenger.Default.Send(employee);
            if (param is Window window)
            {
                window.Close();
            }
        }
    }
}
