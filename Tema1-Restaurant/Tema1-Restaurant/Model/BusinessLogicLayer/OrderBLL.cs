using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Restaurant.Model.BusinessLogicLayer
{
    internal class OrderBLL : BaseBLL
    {
        public List<Orders> GetAllOrders()
        {
            return context.Orders.ToList();
        }
        //gaseste comenzile
        public Orders GetOrder(int orderID)
        {
            return context.Orders.FirstOrDefault(e => e.OrderID == orderID);
        }
        //adauga comenzile
        public void AddOrder(Orders order)
        {
            context.Orders.Add(order); 
            context.SaveChanges();
        }
        public void ModifyOrder()
        {
            context.SaveChanges();
        }

        /* //salveaza modificarile facute
         public void SaveChanges(Orders orderToSave)
         {
             context.Orders.AddOrUpdate(orderToSave);
         }*/

        //sterge o comanda
        public void DeleteOrder(int orderId)
        {
            context.Orders.Remove(GetOrder(orderId));
            context.SaveChanges();
        }

        /*public int GetEmployeeID(string userName, string password)
        {
            //am retinute userul cu ce cautam si apoi am returnat angajatul cu id-ul respectiv
            Users user = context.Users.FirstOrDefault(u => u.Username == userName && u.Password == password);
            return context.Employee.FirstOrDefault(e => e.UserID == user.UserID).EmployeeID;
        }*/

        public Orders GetOrderFromTableID(int tableID)
        {
            //am retinute userul cu id ul cautat si apoi am returnat angajatul cu id-ul respectiv
            return context.Orders.FirstOrDefault(o => o.TableID == tableID);

        }


    }
}
