using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Entity_Framework
{
    
    class Program
    {
        static void Main(string[] args)
        {
            using (StoreContext db = new StoreContext())
            {
                Product book = new Product();
                book.IsActive = true;
                book.Name = "Sun";
                book.DateCreated = DateTime.Now;

                db.Products.Add(book);
                db.SaveChanges();

                Product phone = new Product();
                phone.IsActive = true;
                phone.Name = "Iphone";
                phone.DateCreated = DateTime.Now;

                db.Products.Add(phone);
                db.SaveChanges();

                Product camera = new Product();
                camera.IsActive = true;
                camera.Name = "CANON";
                camera.DateCreated = DateTime.Now;

                db.Products.Add(camera);
                db.SaveChanges();

                Order firstOrder = new Order();
                firstOrder.IsActive = true;
                firstOrder.DateCreated = DateTime.Now;
                firstOrder.OrderNumber = "Q23M";
                firstOrder.Products.Add(phone);
                firstOrder.Products.Add(camera);

                Order secondOrder = new Order();
                secondOrder.IsActive = true;
                secondOrder.DateCreated = DateTime.Now;
                secondOrder.OrderNumber = "A445OP";
                secondOrder.Products.Add(book);

                db.Orders.Add(secondOrder);


                db.Orders.Add(firstOrder);

                Order thirdOrder = new Order();
                thirdOrder.IsActive = true;
                thirdOrder.DateCreated = DateTime.Now;
                thirdOrder.OrderNumber = "ABC";
                thirdOrder.Products.Add(book);
                thirdOrder.Products.Add(camera);

                db.Orders.Add(thirdOrder);

                db.SaveChanges();


            }
        }
    }
}
