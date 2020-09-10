using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        private string _name;

        public Animal(string qwerty)
        {
            _name = qwerty;
        }

        public void Eat()
        {
            Console.WriteLine(string.Format("{0} is eating", _name));
        }
    }
}
