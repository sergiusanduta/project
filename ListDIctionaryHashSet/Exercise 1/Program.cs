using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        /*
         List,
         Dictionary,
         HashSet,
         Stack,
         Queue
         */
        static void Main(string[] args)
        {
            /*
             1.Write a program in C#  to display the characters and 
            frequency of character from giving string.
             */

            DisplayCharsAndFrequence("abacba"); // a: 3, b: 2 , c: 1
            Console.ReadKey();
        }

         
        private static void DisplayCharsAndFrequence(string v)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();

            foreach (char letter in v)
            {
                if (d.ContainsKey(letter))
                {
                    char dictionaryKey = letter;
                    int valueAtIndex = d[dictionaryKey];
                    d[dictionaryKey] = valueAtIndex + 1;
                }
                else
                    d.Add(letter, 1);
            }
        }
    }
}
