using System;
using System.Collections.Generic;

namespace Practice
{ 
    class Program
    {
        static void Main(string[] args)
        { 




            Car m = new Car();
            m.Make = "Mercedes";
            m.Model = "Benz";
            m.Price = 5006;


            Car b = new Car();
            b.Make = "BMW";
            b.Model = "7S";
            b.Price = 1000;

            Car c = new Car();
            c.Make = "Audi";
            c.Model = "A6";
            c.Price = 7000;

            AutoDealer ad = new AutoDealer();
            ad.AddCar(m);
            ad.AddCar(b);
            ad.AddCar(c);

            List<Car> autoDealerCars = ad.GetCars();

            foreach (Car qwerty in autoDealerCars)
            {
                Console.WriteLine(qwerty.Make + " " + qwerty.Model + "  :" + qwerty.Price);
            }

            Console.ReadKey();










        }

    }
}
