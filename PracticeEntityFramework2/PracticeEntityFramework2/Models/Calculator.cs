using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEntityFramework2.Models
{
    class Point
    {
        public int PointA { get; set; }
        public int PointB { get; set; }
    }

    class Calculator
    {
        public int Sum(int a , int b)
        {
            return a + b;
        }
    }
}
