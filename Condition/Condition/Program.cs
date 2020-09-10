using System;
using System.Dynamic;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = "Hello ";

            Console.WriteLine("Insert your login");
            string login = Console.ReadLine();

            @string = (login == "Admin") ? "Administrator" : "Usser";
            Console.WriteLine(@string);

        }
    }
}
