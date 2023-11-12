using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Windows.Documents;
using Tema1_Restaurant.Model;
using Tema1_Restaurant.Commands;
using GalaSoft;

namespace Tema1_Restaurant.ViewModels
{
    internal class ModifyDiningTableWindowVM : BaseVM
    {
        private string tableID;
        private string employeeID;
        private string tableNumber;
        private string aviableSeats;
        private string occupiedSeats;

        public ModifyDiningTableWindowVM()
        {
            Messenger.Default.Register<DiningTableVM>(this, (ReceivedTable) =>
            {
                EmployeeID = ReceivedTable.EmployeeID;
                TableNumber = ReceivedTable.TableNumber;
                AviableSeats = ReceivedTable.AviableSeats;
                OccupiedSeats = ReceivedTable.OccupiedSeats;
            });
        }
        public ModifyDiningTableWindowVM(string tableID, string employeeID, string tableNumber, string aviableSeats,
       string occupiedSeats)
        {
            TableID = tableID;
            EmployeeID = employeeID;
            TableNumber = tableNumber;
            AviableSeats = aviableSeats;
            OccupiedSeats = occupiedSeats;
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

        public string EmployeeID
        {
            get { return employeeID; }
            set
            {
                employeeID = value;
                NotifyPropertyChanged("EmployeeID");
            }
        }
        public string TableNumber
        {
            get { return tableNumber; }
            set
            {
                tableNumber = value;
                NotifyPropertyChanged("TableNumber");
            }
        }
        public string AviableSeats
        {
            get { return aviableSeats; }
            set
            {
                aviableSeats = value;
                NotifyPropertyChanged("AviableSeats");
            }
        }
        public string OccupiedSeats
        {
            get { return occupiedSeats; }
            set
            {
                occupiedSeats = value;
                NotifyPropertyChanged("OccupiedSeats");
            }
        }

        private ICommand modifyDiningTableCommand;
        public ICommand ModifyDiningTableCommand
        {
            get
            {
                if (modifyDiningTableCommand == null)
                {
                    modifyDiningTableCommand = new RelayCommand(ModifyDiningTable);
                }
                return modifyDiningTableCommand;
            }
        }
        private void ModifyDiningTable(object param)
        {
            DiningTableVM table = new DiningTableVM(TableID, EmployeeID, TableNumber, AviableSeats, OccupiedSeats);
            Messenger.Default.Send(table);
            if (param is Window window)
            {
                window.Close();
            }
        }
    }
}
