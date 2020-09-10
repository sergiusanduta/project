using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Cars

{
    public class Cars
    {
        public string _make;
        public string _model;
        public int _year;
        public int _price;

        public Cars(string make, string model, int year, int price)
        {
            _make = make;
            _model = model;
            _year = year;
            _price = price;
        }
    }
}