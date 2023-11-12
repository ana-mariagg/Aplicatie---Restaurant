using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Restaurant.ViewModels
{
    //implementeaza interfata
    internal class BaseVM:INotifyPropertyChanged
    {
        //face legatura dintre View Interfata si View Model

            public event PropertyChangedEventHandler PropertyChanged;
        
        //cand se modifica ceva in view, se actualizeaza
            public void NotifyPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        
    }
}
