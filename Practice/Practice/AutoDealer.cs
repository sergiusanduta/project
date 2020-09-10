using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class AutoDealer
      {
        public List<Car> MyNewCars { get; set; }
       
        public AutoDealer()
        {
            MyNewCars = new List<Car>();
        }
      
        public void AddCar(Car car)
        {
            MyNewCars.Add(car); 
        }

        public List<Car> GetCars()
        {
            return MyNewCars;
        }
    }
}
