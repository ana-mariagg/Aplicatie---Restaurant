using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Restaurant.Commands;
using Tema1_Restaurant.Model;
using Tema1_Restaurant.Model.BusinessLogicLayer;
using Tema1_Restaurant.Views;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Tema1_Restaurant.ViewModels
{
    internal class AdminWindowVM : BaseVM
    {
        private DiningTableBLL diningTableBLL = new DiningTableBLL();
        private EmployeeBLL employeeBLL = new EmployeeBLL();
        private OrderBLL orderBLL = new OrderBLL(); 
        private ProductBLL productBLL = new ProductBLL();   
        private UserBLL userBLL = new UserBLL();
        private object currentItem;

        public object CurrentItem
        {
            get { return currentItem; }
            set
            {
                currentItem = value;
                NotifyPropertyChanged("CurrentItem");
            }
        }

        //e o colectie de obiecte (fie angajati, fie mese, orice) care poate sa fie observata; cand se modifica cv se notifica automat in view
        public ObservableCollection<object> CurrentList { get; set; }
        public AdminWindowVM() { CurrentList = new ObservableCollection<object>(); }




        //-------------------------------------------------------------------------------------------------------
        //OSPATARI

        //ca sa putem viziona ospatarii

        //VIEW ----------------------------------------------------

        private ICommand viewEmployeesCommand;
        public ICommand ViewEmployeesCommand
        {
            get
            {
                if (viewEmployeesCommand == null)
                {
                    viewEmployeesCommand = new RelayCommand(ViewEmployees);
                }
                return viewEmployeesCommand;
            }
        }

        private void ViewEmployees (object param)
        {
            List<Employee> employees =employeeBLL.GetAllEmployees();
            List<EmployeeVM> employeesVM = new List<EmployeeVM>();
            foreach(Employee employee in employees)
            {
                employeesVM.Add(new EmployeeVM(employee.UserID.ToString(), employee.FirstName, employee.LastName));
            }
            CurrentList=new ObservableCollection<object>(employeesVM);
            NotifyPropertyChanged(nameof(CurrentList));
        }

        //ADD ----------------------------------------------------

        private ICommand addEmployeesCommand;
        public ICommand AddEmployeesCommand
        {
            get
            {
                if (addEmployeesCommand == null)
                {
                    addEmployeesCommand = new RelayCommand(AddEmployee);
                }
                return addEmployeesCommand;
            }
        }

        private void AddEmployee(object param)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            Messenger.Default.Register<EmployeeVM>(this, (employeeVM) =>
            {
                Employee employee = new Employee();
                employee.UserID = int.Parse(employeeVM.UserID);
                employee.FirstName = employeeVM.FirstName;
                employee.LastName = employeeVM.LastName;
                CurrentList.Add(employeeVM);
                employeeBLL.AddEmployee(employee);
            });
            addEmployeeWindow.ShowDialog();
            //inchide "cutiuta postala"
            Messenger.Default.Unregister<EmployeeVM>(this);
        }

        //MODIFY ----------------------------------------------------

        private void ModifyEmployee (object param)
        {
            ModifyEmployeeWindow modifyEmployeeWindow = new ModifyEmployeeWindow();
            Messenger.Default.Send<EmployeeVM>(CurrentItem as EmployeeVM);
            Messenger.Default.Register<EmployeeVM>(this, (employeeVM) =>
            {
                CurrentItem= employeeVM;
                Employee oldEmployee= employeeBLL.GetEmployeeFromUserID(int.Parse(employeeVM.UserID));
                oldEmployee.UserID = int.Parse(employeeVM.UserID);
                oldEmployee.FirstName = employeeVM.FirstName;
                oldEmployee.LastName = employeeVM.LastName;
                employeeBLL.ModifyEmployee();
            });
            modifyEmployeeWindow.ShowDialog();
            //inchide "cutiuta postala"
            Messenger.Default.Unregister<EmployeeVM>(this);

            //NotifyPropertyChanged("CurrentItem");
            ViewEmployees(null);
        }

        private ICommand modifyEmployeesCommand;
        public ICommand ModifyEmployeesCommand
        {
            get
            {
                if (modifyEmployeesCommand == null)
                {
                    modifyEmployeesCommand = new RelayCommand(ModifyEmployee);
                }
                return modifyEmployeesCommand;
            }
        }


        //DELETE ----------------------------------------------------

        private void DeleteEmployee(object param)
        {
            Employee oldEmployee = employeeBLL.GetEmployeeFromUserID(int.Parse((CurrentItem as EmployeeVM).UserID));
            employeeBLL.DeleteEmployee(oldEmployee.EmployeeID);

            //NotifyPropertyChanged("CurrentItem");
            ViewEmployees(null);
        }


        private ICommand deleteEmployeesCommand;
        public ICommand DeleteEmployeesCommand
        {
            get
            {
                if (deleteEmployeesCommand == null)
                {
                    deleteEmployeesCommand = new RelayCommand(DeleteEmployee);
                }
                return deleteEmployeesCommand;
            }
        }




        //---------------------------------------------------------------------------------------------------------------------------
        //PRODUSE

        //ca sa putem viziona produsele

        //VIEW ----------------------------------------------------

        private ICommand viewProductsCommand;
        public ICommand ViewProductsCommand
        {
            get
            {
                if (viewProductsCommand == null)
                {
                    viewProductsCommand = new RelayCommand(ViewProducts);
                }
                return viewProductsCommand;
            }
        }
        private void ViewProducts(object param)
        {
            List<Product> products = productBLL.GetAllProducts();
            List<ProductVM> productsVM = new List<ProductVM>();
            foreach (Product product in products)
            {
                productsVM.Add(new ProductVM(product.ProductID.ToString(), product.Name,product.Price.ToString(),product.IsAvailable.ToString())); 
            }
            CurrentList = new ObservableCollection<object>(productsVM);
            NotifyPropertyChanged(nameof(CurrentList));
        }

        //ADD ----------------------------------------------------

        private ICommand addProductsCommand;
        public ICommand AddProductsCommand
        {
            get
            {
                if (addProductsCommand == null)
                {
                    addProductsCommand = new RelayCommand(AddProduct);
                }
                return addProductsCommand;
            }
        }
        private void AddProduct(object param)
        {
            AddProductWindow addProductWindow = new AddProductWindow();
            Messenger.Default.Register<ProductVM>(this, (productVM) =>
            {
                Product product = new Product();
                product.Name = productVM.ProductName;
                product.Price = decimal.Parse(productVM.ProductPrice);
                product.IsAvailable = bool.Parse(productVM.ProductIsAviable);
                CurrentList.Add(productVM);
                productBLL.AddProduct(product);
            });
            addProductWindow.ShowDialog();
            //inchide "cutiuta postala"
            Messenger.Default.Unregister<ProductVM>(this);

        }

        //MODIFY ----------------------------------------------------

        private void ModifyProduct(object param)
        {
            ModifyProductWindow modifyProductWindow = new ModifyProductWindow();
            Messenger.Default.Send<ProductVM>(CurrentItem as ProductVM);
            Messenger.Default.Register<ProductVM>(this, (productVM) =>
            {
                //CurrentItem = productVM;

                Product oldProduct = productBLL.GetProductName((CurrentItem as ProductVM).ProductName);
                oldProduct.Name = productVM.ProductName;
                oldProduct.Price = decimal.Parse(productVM.ProductPrice);
                oldProduct.IsAvailable = bool.Parse(productVM.ProductIsAviable);
                productBLL.ModifyProduct();
            });
            modifyProductWindow.ShowDialog();
            //inchide "cutiuta postala"
            Messenger.Default.Unregister<ProductVM>(this);

            //NotifyPropertyChanged("CurrentItem");
            ViewProducts(null);
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

        //DELETE ----------------------------------------------------

        private void DeleteProducts(object param)
        {
            Product oldProduct = productBLL.GetProductID(int.Parse((CurrentItem as ProductVM).ProductID));
            productBLL.DeleteProduct(oldProduct.ProductID);

            //NotifyPropertyChanged("CurrentItem");
            ViewProducts(null);
        }

        private ICommand deleteProductsCommand;
        public ICommand DeleteProductsCommand
        {
            get
            {
                if (deleteProductsCommand == null)
                {
                    deleteProductsCommand = new RelayCommand(DeleteProducts);
                }
                return deleteProductsCommand;
            }
        }






        //---------------------------------------------------------------------------------------------------------------------------
        //MESE

        //ca sa putem viziona mesele

        //VIEW ----------------------------------------------------

        private ICommand viewDiningTablesCommand;
        public ICommand ViewDiningTablesCommand
        {
            get
            {
                if (viewDiningTablesCommand == null)
                {
                    viewDiningTablesCommand = new RelayCommand(ViewDiningTables);
                }
                return viewDiningTablesCommand;
            }
        }
        private void ViewDiningTables(object param)
        {
            List<DiningTable> diningTables = diningTableBLL.GetAllDiningTables();
            List<DiningTableVM> diningTablesVM = new List<DiningTableVM>();
            foreach (DiningTable diningTable in diningTables)
            {
                diningTablesVM.Add(new DiningTableVM(diningTable.TableID.ToString(), diningTable.EmployeeID.ToString(), diningTable.TableNumber.ToString(), diningTable.AvailableSeats.ToString(), diningTable.OccupiedSeats.ToString()));
            }
            CurrentList = new ObservableCollection<object>(diningTablesVM);
            NotifyPropertyChanged(nameof(CurrentList));
        }

        //ADD ----------------------------------------------------

        private ICommand addDiningTablesCommand;
        public ICommand AddDiningTablesCommand
        {
            get
            {
                if (addDiningTablesCommand == null)
                {
                    addDiningTablesCommand = new RelayCommand(AddDiningTable);
                }
                return addDiningTablesCommand;
            }
        }
        private void AddDiningTable(object param)
        {
            AddDiningTableWindow addDiningTableWindow = new AddDiningTableWindow();
            Messenger.Default.Register<DiningTableVM>(this, (diningTableVM) =>
            {
                DiningTable diningTable = new DiningTable();
                diningTable.EmployeeID=int.Parse(diningTableVM.EmployeeID);
                diningTable.TableNumber = int.Parse(diningTableVM.TableNumber);
                diningTable.AvailableSeats = int.Parse(diningTableVM.AviableSeats);
                diningTable.OccupiedSeats = int.Parse(diningTableVM.OccupiedSeats);
                CurrentList.Add(diningTableVM);
                diningTableBLL.AddDiningTable(diningTable);
            });
            addDiningTableWindow.ShowDialog();
            //inchide "cutiuta postala"
            Messenger.Default.Unregister<DiningTableVM>(this);
        }

        //MODIFY ----------------------------------------------------

        private void ModifyDiningTable(object param)
        {
            ModifyDiningTableWindow modifyDiningTableWindow = new ModifyDiningTableWindow();
            Messenger.Default.Send<DiningTableVM>(CurrentItem as DiningTableVM);
            Messenger.Default.Register<DiningTableVM>(this, (diningTableVM) =>
            {
                //CurrentItem = diningTableVM;
                DiningTable oldDiningTable = diningTableBLL.GetDiningTableNumber(int.Parse((CurrentItem as DiningTableVM).TableNumber));
                oldDiningTable.EmployeeID=int.Parse(diningTableVM.EmployeeID);
                oldDiningTable.TableNumber = int.Parse(diningTableVM.TableNumber);
                oldDiningTable.AvailableSeats = int.Parse(diningTableVM.AviableSeats);
                oldDiningTable.OccupiedSeats = int.Parse(diningTableVM.OccupiedSeats);
                diningTableBLL.ModifyDiningTable();
            });
            modifyDiningTableWindow.ShowDialog();
            //inchide "cutiuta postala"
            Messenger.Default.Unregister<DiningTableVM>(this);

            //NotifyPropertyChanged("CurrentItem");
            ViewDiningTables(null);
        }


        private ICommand modifyDiningTablesCommand;
        public ICommand ModifyDiningTablesCommand
        {
            get
            {
                if (modifyDiningTablesCommand == null)
                {
                    modifyDiningTablesCommand = new RelayCommand(ModifyDiningTable);
                }
                return modifyDiningTablesCommand;
            }
        }

        //DELETE ----------------------------------------------------

        private void DeleteDiningTables(object param)
        {
            DiningTable oldDiningTable = diningTableBLL.GetDiningTableNumber(int.Parse((CurrentItem as DiningTableVM).TableNumber));
            diningTableBLL.DeleteDiningTable(oldDiningTable.TableID);

            //NotifyPropertyChanged("CurrentItem");
            ViewDiningTables(null);
        }

        private ICommand deleteDiningTablesCommand;
        public ICommand DeleteDiningTablesCommand
        {
            get
            {
                if (deleteDiningTablesCommand == null)
                {
                    deleteDiningTablesCommand = new RelayCommand(DeleteDiningTables);
                }
                return deleteDiningTablesCommand;
            }
        }




        //---------------------------------------------------------------------------------------------------------------------------
        //COMENZI

        //ca sa putem viziona mesele

        //VIEW ----------------------------------------------------

        private ICommand viewOrdersCommand;
        public ICommand ViewOrdersCommand
        {
            get
            {
                if (viewOrdersCommand == null)
                {
                    viewOrdersCommand = new RelayCommand(ViewOrders);
                }
                return viewOrdersCommand;
            }
        }
        private void ViewOrders(object param)
        {
            List<Orders> orders = orderBLL.GetAllOrders();
            List<OrdersVM> diningTablesVM = new List<OrdersVM>();
            foreach (Orders order in orders)
            {
                diningTablesVM.Add(new OrdersVM(order.OrderID.ToString(),order.TableID.ToString(), order.Status,order.TotalCost.ToString(),order.OrderDate.Value));
            }
            CurrentList = new ObservableCollection<object>(diningTablesVM);
            NotifyPropertyChanged(nameof(CurrentList));
        }

        //ADD ----------------------------------------------------

        private ICommand addOrdersCommand;
        public ICommand AddOrdersCommand
        {
            get
            {
                if (addOrdersCommand == null)
                {
                    addOrdersCommand = new RelayCommand(AddOrder);
                }
                return addOrdersCommand;
            }
        }
        private void AddOrder(object param)
        {
            AddOrderWindow addOrderWindow = new AddOrderWindow();
            Messenger.Default.Register<OrdersVM>(this, (ordersVM) =>
            {
                Orders orders = new Orders();
                orders.TableID = int.Parse(ordersVM.TableID);
                orders.Status=ordersVM.Status;
                orders.TotalCost=decimal.Parse(ordersVM.TotalCost);
                orders.OrderDate=ordersVM.OrderTime;
                CurrentList.Add(ordersVM);
                orderBLL.AddOrder(orders);
            });
            addOrderWindow.ShowDialog();
            //inchide "cutiuta postala"
            Messenger.Default.Unregister<OrdersVM>(this);
        }

        //MODIFY ----------------------------------------------------

        private void ModifyOrder(object param)
        {
            ModifyOrderWindow modifyOrderWindow = new ModifyOrderWindow();
            Messenger.Default.Send<OrdersVM>(CurrentItem as OrdersVM);
            Messenger.Default.Register<OrdersVM>(this, (ordersVM) =>
            {
                CurrentItem = ordersVM;
                Orders oldOrder = orderBLL.GetOrderFromTableID(int.Parse(ordersVM.TableID));
                oldOrder.TableID = int.Parse(ordersVM.TableID);
                oldOrder.Status = ordersVM.Status;
                oldOrder.TotalCost = decimal.Parse(ordersVM.TotalCost);
                oldOrder.OrderDate=ordersVM.OrderTime;
                orderBLL.ModifyOrder();
            });
            modifyOrderWindow.ShowDialog();
            //inchide "cutiuta postala"
            Messenger.Default.Unregister<OrdersVM>(this);

            //NotifyPropertyChanged("CurrentItem");
            ViewEmployees(null);
        }

        private ICommand modifyOrderCommand;
        public ICommand ModifyOrderCommand
        {
            get
            {
                if (modifyOrderCommand == null)
                {
                    modifyOrderCommand = new RelayCommand(ModifyOrder);
                }
                return modifyOrderCommand;
            }
        }

        //DELETE ----------------------------------------------------

        private void DeleteOrder(object param)
        {
            Orders oldOrder = orderBLL.GetOrderFromTableID(int.Parse((CurrentItem as OrdersVM).TableID));
            orderBLL.DeleteOrder(oldOrder.OrderID);

            //NotifyPropertyChanged("CurrentItem");
            ViewEmployees(null);
        }


        private ICommand deleteOrderCommand;
        public ICommand DeleteOrderCommand
        {
            get
            {
                if (deleteOrderCommand == null)
                {
                    deleteOrderCommand = new RelayCommand(DeleteOrder);
                }
                return deleteOrderCommand;
            }
        }


        //CALCUL RAPORT TOTAL

        /*private void ViewDiningTables(object param)
        {
            List<DiningTable> diningTables = diningTableBLL.GetAllDiningTables();
            List<DiningTableVM> diningTablesVM = new List<DiningTableVM>();
            foreach (DiningTable diningTable in diningTables)
            {
                diningTablesVM.Add(new DiningTableVM(diningTable.TableID.ToString(), diningTable.EmployeeID.ToString(), diningTable.TableNumber.ToString(), diningTable.AvailableSeats.ToString(), diningTable.OccupiedSeats.ToString()));
            }
            CurrentList = new ObservableCollection<object>(diningTablesVM);
            NotifyPropertyChanged(nameof(CurrentList));
        }*/
        private void TotalRaport(object param)
        {
           // TotalRaportWindow totalOrderWindow = new TotalRaportWindow();
            Messenger.Default.Send<EmployeeVM>(CurrentItem as EmployeeVM);
            Messenger.Default.Register<SumVM>(this, (employeeVM) =>
            {
                List<decimal?> sume = new List<decimal?>();

                CurrentItem = employeeVM;

                decimal? sum = 0;
                //private readonly EmployeeBLL employeeBLL = new EmployeeBLL();

                int employeeId = employeeBLL.GetEmployeeIDSimple();
                List<DiningTable> diningTables = diningTableBLL.GetAllDiningTables();
                List<Orders> orders = orderBLL.GetAllOrders();

                string s = "Paid";
                foreach (DiningTable diningTable in diningTables)
                {
                    if (diningTable.EmployeeID == employeeId)
                    {
                        foreach(Orders order in orders)
                        {
                            if (order.TableID==diningTable.TableID && string.Compare(order.Status,s)==1)
                            {
                                sum += order.TotalCost;
                            }
                        }
                    }
                }
                List<SumVM> summVM = new List<SumVM>();

                SumVM summ = new SumVM("", "", "Total", sum.ToString()) ;
                summVM.Add(summ);
                CurrentList.Add(summ);
                
                CurrentList = new ObservableCollection<object>(summVM);
                NotifyPropertyChanged(nameof(CurrentList));

            });

            

            //totalOrderWindow.ShowDialog();
            //inchide "cutiuta postala"
            Messenger.Default.Unregister<TotalOrderVM>(this);

            //NotifyPropertyChanged("CurrentItem");
           // ViewEmployees(null);
        }

        private ICommand totalOrderCommand;
        public ICommand TotalOrderCommand
        {
            get
            {
                if (totalOrderCommand == null)
                {
                    totalOrderCommand = new RelayCommand(TotalRaport);
                }
                return totalOrderCommand;
            }
        }

    }
}
