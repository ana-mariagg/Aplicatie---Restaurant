using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Restaurant.ViewModels
{
    internal class SumVM:BaseVM
    {
        private string firstName;
        private string lastName;
        private string reportType;
        private string suma;

        public SumVM( string firstName, string lastName, string reportType, string suma)
        {
            
            FirstName = firstName;
            LastName = lastName;
            ReportType = reportType;
            Suma = suma;    

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
        public string ReportType
        {
            get { return reportType; }
            set
            {
                reportType = value;
                NotifyPropertyChanged("ReportType");
            }
        }
        public string Suma
        {
            get { return suma; }
            set
            {
                suma = value;
                NotifyPropertyChanged("Suma");
            }
        }
    }
}
