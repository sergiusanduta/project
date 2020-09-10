using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public class Cat : Animal
    {
        public Cat(string catName) : base(catName)
        {
        }

        public void SayMeow()
        {
            Console.WriteLine("Meow");
        }
    }
}
