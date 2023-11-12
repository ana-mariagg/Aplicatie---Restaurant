using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Restaurant.ViewModels;


namespace Tema1_Restaurant.Model.BusinessLogicLayer
{
    internal class ProductBLL : BaseBLL
    {
        public List<Product> GetAllProducts()
        {
            return context.Product.ToList();
        }
        //gaseste produsele
        public Product GetProduct(int productID)
        {
            return context.Product.FirstOrDefault(p => p.ProductID == productID);

        }
        //adauga produsele
        public void AddProduct(Product product)
        {
            context.Product.Add(product);
            context.SaveChanges();
        }
        public void ModifyProduct()
        {
            context.SaveChanges();
        }

        /* //salveaza modificarile facute
         public void SaveChanges(Product productToSave)
         {
             context.Product.AddOrUpdate(productToSave);
         }*/

        //sterge un produs
        public void DeleteProduct(int productId)
        {
            context.Product.Remove(GetProduct(productId));
            context.SaveChanges();
        }

        /*public int GetProductID(string userName, string password)
        {
            //am retinute userul cu ce cautam si apoi am returnat angajatul cu id-ul respectiv
            Users user = context.Users.FirstOrDefault(u => u.Username == userName && u.Password == password);
            return context.Employee.FirstOrDefault(e => e.UserID == user.UserID).EmployeeID;
        }*/

        public Product GetProductID(int productID)
        {
            //am retinute userul cu id ul cautat si apoi am returnat angajatul cu id-ul respectiv
            return context.Product.FirstOrDefault(p => p.ProductID == productID);

        }

        public Product GetProductName(string productName)
        {
            //am retinute userul cu id ul cautat si apoi am returnat angajatul cu id-ul respectiv
            return context.Product.FirstOrDefault(p => p.Name == productName);

        }
    }
}
