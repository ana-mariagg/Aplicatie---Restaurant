using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Restaurant.ViewModels
{
    internal class UserVM:BaseVM
    {
        
            private string userName;
            private string userPassw;
            private string userRole;

            public UserVM(string userName, string userPassw, string userRole)
            {
                UserName = userName;
                UserPassw = userPassw;
                UserRole = userRole;
            }

            public string UserName
            {
                get { return userName; }
                set
                {
                    userName = value;
                    NotifyPropertyChanged("UserName");
                }
            }

            public string UserPassw
            {
                 get { return userPassw; }
                 set
                 {
                     userPassw = value;
                     NotifyPropertyChanged("UserPassw");
                  }
            }

            public string UserRole
            {
                get { return userRole; }
                set
                {
                    userRole = value;
                    NotifyPropertyChanged("UserRole");
                }
            }
        
    }
}
