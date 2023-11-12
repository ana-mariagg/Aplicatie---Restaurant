using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Restaurant.Model.BusinessLogicLayer
{
    internal class EmployeeBLL : BaseBLL
    {
        public List<Employee> GetAllEmployees()
        {
            return context.Employee.ToList();
        }
        //gaseste angajatii
        public Employee GetEmployee(int employeeID)
        {
            return context.Employee.FirstOrDefault(e => e.EmployeeID == employeeID);
        }
        //adauga angajatii
        public void AddEmployee(Employee employee)
        {
            context.Employee.Add(employee);
            context.SaveChanges();
        }

        public void ModifyEmployee()
        {
            context.SaveChanges();
        }

        /* //salveaza modificarile facute
         public void SaveChanges(Employee employeeToSave)
         {
             context.Employee.AddOrUpdate(employeeToSave);
         }*/

        //sterge un angajat
        public void DeleteEmployee(int employeeId)
        {
            context.Employee.Remove(GetEmployee(employeeId));
            context.SaveChanges();
        }

        public int GetEmployeeID(string userName, string password)
        {
            //am retinute userul cu ce cautam si apoi am returnat angajatul cu id-ul respectiv
            Users user = context.Users.FirstOrDefault(u => u.Username == userName && u.Password == password);
            return context.Employee.FirstOrDefault(e => e.UserID == user.UserID).EmployeeID;
        }

        public int GetEmployeeIDSimple()
        {
            //am retinute userul cu ce cautam si apoi am returnat angajatul cu id-ul respectiv
            return context.Employee.FirstOrDefault().EmployeeID;
        }

        public Employee GetEmployeeFromUserID(int userID)
        {
            //am retinute userul cu id ul cautat si apoi am returnat angajatul cu id-ul respectiv
            return context.Employee.FirstOrDefault(e => e.UserID == userID);

        }

    }
}
