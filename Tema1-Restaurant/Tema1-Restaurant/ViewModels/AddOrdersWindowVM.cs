using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Tema1_Restaurant.Model;
using Tema1_Restaurant.Commands;
using GalaSoft;

namespace Tema1_Restaurant.ViewModels
{
    internal class AddOrdersWindowVM:BaseVM
    {
        private string orderID;
        private string tableID;
        private string status;
        private string totalCost;
        private DateTime orderTime;

        public AddOrdersWindowVM()
        {

        }
        public AddOrdersWindowVM(string orderID, string tableID, string status, string totalCost, DateTime orderTime)
        {
            OrderID = orderID;
            TableID = tableID;
            Status = status;
            TotalCost = totalCost;
            OrderTime = orderTime;
        }

        public string OrderID
        {
            get { return orderID; }
            set
            {
                orderID = value;
                NotifyPropertyChanged("OrderID");
            }
        }
        public string TableID
        {
            get { return tableID; }
            set
            {
                tableID = value;
                NotifyPropertyChanged("TableID");
            }
        }
        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                NotifyPropertyChanged("Status");
            }
        }
        public string TotalCost
        {
            get { return totalCost; }
            set
            {
                totalCost = value;
                NotifyPropertyChanged("Totalost");
            }
        }

        public DateTime OrderTime
        {
            get { return orderTime; }
            set
            {
                orderTime = value;
                NotifyPropertyChanged("OrderTime");
            }
        }

        private ICommand addOrdersCommand;
        public ICommand AddOrdersCommand
        {
            get
            {
                if (addOrdersCommand == null)
                {
                    addOrdersCommand = new RelayCommand(AddOrders);
                }
                return addOrdersCommand;
            }
        }

        
        private void AddOrders(object param)
        {
            OrdersVM order = new OrdersVM(OrderID, TableID, Status, TotalCost, OrderTime);
            Messenger.Default.Send(order);
            if (param is Window window)
            {
                window.Close();
            }
        }
    }
}
