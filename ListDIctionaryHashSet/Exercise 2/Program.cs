using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             2.Implement an algorithm to determine if a string has all unique characters
             */

            Console.WriteLine(HasOnlyUniqueChars("zxz")); // false
            Console.WriteLine(HasOnlyUniqueChars("abca")); // false
           Console.WriteLine(HasOnlyUniqueChars("abcd")); // true
            Console.WriteLine(HasOnlyUniqueChars("zxc")); // true
            Console.ReadLine();
        }
        private static bool HasOnlyUniqueChars(string word)
        {
            HashSet<char> sample = new HashSet<char>();
            foreach (char item in word)
            {
                bool adevarat = sample.Add(item);
             
                if (adevarat == false)
                {
                    return false;
                }
            }
       
            return true;
        }

    }
}
