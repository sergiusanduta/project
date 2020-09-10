using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    class String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number");
            var number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            var number2 = Convert.ToInt32(Console.ReadLine());

            if (number>number2)
            {
                Console.WriteLine("First number is bigger than second");

            }
            else if (number < number2)
            {
                Console.WriteLine("Second number is bigger than first");
            }
            else
                Console.WriteLine("Your numbers are equal");
        }

    }
}
