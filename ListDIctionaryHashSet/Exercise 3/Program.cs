using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrom("eye")); // true
            Console.WriteLine(IsPalindrom("anna")); // true
            Console.WriteLine(IsPalindrom("zxzc")); // false
            Console.ReadKey();
        }

        static bool IsPalindrom(string input) // eye
        {
            char[] arr = input.ToCharArray(); // ['e', 'y' 'e']
            char[] copyArr = new char[arr.Length]; // ['', '', ''] 

            int counter = 0;
            for (int i = arr.Length-1; i >= 0; i--)
            {
                copyArr[counter] = arr[i];
                counter++;
            }
            // copyArr = ['e', 'y', 'e'];
            string reversedInput = new string(copyArr); // ['e', 'y', 'e']  -> "eye"

            return input == reversedInput;
        }
    }
}
