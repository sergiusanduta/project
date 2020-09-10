using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public class Dog : Animal 
    {
        public Dog(string dogName) : base(dogName)
        {
        }


        public void SayWoof()
        {
            Console.WriteLine("Woof woof");
        }
    }
}
