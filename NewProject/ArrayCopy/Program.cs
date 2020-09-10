using System;
using System.Collections.Generic;
using System.Globalization;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 2, 5, 1, 19, 16, 23, 7, 9 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < 10)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            ////}

            //int[] num = new int[] { 3, 5, 6, 7, 9,14, 55 };
            //int[] newarray = new int[6];

            // num.CopyTo(newarray, 1);



            //foreach (int v in newarray)
            //{
            //    Console.WriteLine(v); 
            //}

            var number = new[] { "Ally", "Bishop", "Billy" };
            var array = new string[4];

            number.CopyTo(array, 1);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
