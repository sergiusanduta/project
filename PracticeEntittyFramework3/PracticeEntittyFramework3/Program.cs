using PracticeEntittyFramework3.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PracticeEntittyFramework3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CarsEntities db = new CarsEntities())
            {
                List<Car> cars = db.Cars.Include(c => c.Model.Make).ToList();
                foreach (Car item in cars)
                {
                    Console.WriteLine(item.Model.Model1 +" " + item.Model.Make.Make1 + " " + item.Price);
                }
                
            }
            Console.ReadKey();
                
            // BMW X5 RED $14000 2000

        }
    }
}
