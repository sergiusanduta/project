using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = input.Length-1; i > input.Length/2; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
