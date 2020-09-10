using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace GetMax

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 93, 293, 45, 54, 34, 5, 3 };
            var max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);

        }
    }
} 
