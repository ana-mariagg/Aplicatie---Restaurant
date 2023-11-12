using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Restaurant.Model;

namespace Tema1_Restaurant.ViewModels
{
    internal class OrdersVM:BaseVM
    {
        private string orderID;
        private string tableID;
        private string status;
        private string totalCost;
        private DateTime orderTime;

        public OrdersVM(string orderID, string tableID, string status,string totalCost, DateTime orderTime)
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

    }
}
