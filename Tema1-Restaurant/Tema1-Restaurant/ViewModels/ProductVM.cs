using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Restaurant.Model;

namespace Tema1_Restaurant.ViewModels
{
    internal class ProductVM : BaseVM
    {
        private string productID;
        private string name;
        private string price;
        private string isAviable;

        public ProductVM(string productID, string name, string price, string isAviable)
        {
            ProductID = productID;
            ProductName = name;
            ProductPrice = price;
            ProductIsAviable = isAviable;
        }

        public string ProductID
        {
            get { return productID; }
            set
            {
                productID = value;
                NotifyPropertyChanged("ProductID");
            }
        }

        public string ProductName
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("ProductName");
            }
        }
        public string ProductPrice
        {
            get { return price; }
            set
            {
                price = value;
                NotifyPropertyChanged("ProductPrice");
            }
        }
        public string ProductIsAviable
        {
            get { return isAviable; }
            set
            {
                isAviable = value;
                NotifyPropertyChanged("ProductIsAviable");
            }
        }
    }
}
