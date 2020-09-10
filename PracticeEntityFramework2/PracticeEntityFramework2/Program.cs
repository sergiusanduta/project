using PracticeEntityFramework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PracticeEntityFramework2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CustomersContext cc = new CustomersContext())
            {
                ////Supplier s = new Supplier()
                ////{
                ////    CompanyName = "Ebay",
                ////    ContactName = "Ebay INC",
                ////    ContactTitle = "Abc",
                ////    Phone = "543543543"
                ////};

                ////cc.Suppliers.Add(s);

                ////cc.SaveChanges();

                ////Product p = new Product()
                ////{
                ////    IsDiscontinued = false,
                ////    Package = "123",
                ////    ProductName = "Phone",
                ////    UnitPrice = 50,
                ////    SupplierId = s.Id
                ////};


                //////s.Products.Add(p);
                ////cc.Products.Add(p);

                ////cc.SaveChanges();
                ///

                // Ebay :
                // 1) Phone
                // 2) ProdusuX

                //Supplier ebay = cc.Suppliers.Include(s => s.Products).FirstOrDefault(s => s.CompanyName == "Ebay");
                ////  List<Product> products = cc.Products.Where(c => c.SupplierId == ebay.Id).ToList();
                //Console.WriteLine(ebay.CompanyName);

                //for (int i = 0; i < ebay.Products.Count; i++)
                //{

                //    Console.WriteLine(i + 1 + ") " + ebay.Products[i].ProductName);
                //}

                // Apple sold by: Ebay
               
                Product apple = cc.Products.Include (c => c.Supplier).FirstOrDefault(c => c.ProductName == "Apple");
                //Supplier ebay = cc.Suppliers.FirstOrDefault(c => c.Id == apple.SupplierId);
                Console.WriteLine(apple.ProductName + "  Sold by  " + apple.Supplier.CompanyName);

                Console.ReadKey();
            }

        }
    }
}
