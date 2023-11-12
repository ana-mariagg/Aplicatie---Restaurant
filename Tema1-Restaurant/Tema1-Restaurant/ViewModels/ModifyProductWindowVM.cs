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
    internal class ModifyProductWindowVM : BaseVM
    {
        private string productID;
        private string name;
        private string price;
        private string isAviable;

        public ModifyProductWindowVM()
        {
            Messenger.Default.Register<ProductVM>(this, (ReceivedProduct) =>
            {
                ProductName = ReceivedProduct.ProductName;
                ProductPrice = ReceivedProduct.ProductPrice;
                ProductIsAviable = ReceivedProduct.ProductIsAviable;
            });
        }

        public ModifyProductWindowVM(string productID, string name, string price, string isAviable)
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

        private ICommand modifyProductCommand;
        public ICommand ModifyProductCommand
        {
            get
            {
                if (modifyProductCommand == null)
                {
                    modifyProductCommand = new RelayCommand(ModifyProduct);
                }
                return modifyProductCommand;
            }
        }
        private void ModifyProduct(object param)
        {
            ProductVM product = new ProductVM(ProductID, ProductName, ProductPrice, ProductIsAviable);
            Messenger.Default.Send(product);
            if (param is Window window)
            {
                window.Close();
            }
        }
    }
}
