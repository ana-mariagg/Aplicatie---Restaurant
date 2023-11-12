using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Restaurant.Model.BusinessLogicLayer
{
    internal class DiningTableBLL :BaseBLL
    {
        public List<DiningTable> GetAllDiningTables()
        {
            return context.DiningTable.ToList();
        }
        //gaseste mesele
        public DiningTable GetDiningTable(int diningTableID)
        {
            return context.DiningTable.FirstOrDefault(dt => dt.TableID == diningTableID);
        }
        //adauga mesele
        public void AddDiningTable(DiningTable diningTable)
        {
            context.DiningTable.Add(diningTable);
            context.SaveChanges();
        }

        public void ModifyDiningTable()
        {
            context.SaveChanges();
        }

        /* //salveaza modificarile facute
         public void SaveChanges(DiningTable diningTableToSave)
         {
             context.DiningTable.AddOrUpdate(diningTableToSave);
         }*/

        //sterge o masa
        public void DeleteDiningTable(int diningTableId)
        {
            context.DiningTable.Remove(GetDiningTable(diningTableId));
            context.SaveChanges();
        }

        public DiningTable GetDiningTableNumber(int tableNumber)
        {
            //am retinute userul cu id ul cautat si apoi am returnat angajatul cu id-ul respectiv
            return context.DiningTable.FirstOrDefault(dt => dt.TableNumber == tableNumber);

        }

        public DiningTable GetEmployeeFromTableId(int employeeID)
        {
            //am retinute userul cu id ul cautat si apoi am returnat angajatul cu id-ul respectiv
            return context.DiningTable.FirstOrDefault(e => e.EmployeeID == employeeID);

        }

        /* public int GetDiningTableID(string userName, string password)
         {
             //am retinute userul cu ce cautam si apoi am returnat angajatul cu id-ul respectiv
             Users user = context.Users.FirstOrDefault(u => u.Username == userName && u.Password == password);
             return context.Employee.FirstOrDefault(e => e.UserID == user.UserID).EmployeeID;
         }*/
    }
}
