using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Find the square of each number in an array [1…10]; [1,2,3,4,5] -> [1, 4, 9, 16, 25]
             */
            int[] numbers = Enumerable.Range(1, 10).ToArray(); // [1, 2, 3, 4, 5]
            int[] numbersquare = new int[numbers.Length];      // [0, 0, 0, 0, 0] -> [1, 4, 9, 16, 25];
                                                                
            for (int i = 0; i < numbers.Length; i++)
            {
                int result = numbers[i] * numbers[i];

                numbersquare[i] = result;
            }
        }    
    }
}
