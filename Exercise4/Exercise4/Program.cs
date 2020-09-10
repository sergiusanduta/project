using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Given an array a that contains only numbers in the range from 1 to a.length,
            find the first duplicate number for which the second occurrence has the minimal index.
            In other words, if there are more than 1 duplicated numbers, 
            return the number for which the second occurrence has a smaller index than the second occurrence of the other number does.
            If there are no such elements, return -1.
	        For a = [2, 1, 3, 5, 3, 2], the output should be firstDuplicate(a) = 3
             */

            int[] a = new int[] { 2, 1, 3, 5, 3, 2 };

            int firstDuplicateNumber = FirstDuplicate(a);
            Console.WriteLine(firstDuplicateNumber); // 3

            int[] b = new int[] { 2, 1, 3 };

            firstDuplicateNumber = FirstDuplicate(b);
            Console.WriteLine(firstDuplicateNumber); // -1

            Console.ReadKey();
        }

        private static int FirstDuplicate(int[] a)
        {
            HashSet<int> b = new HashSet<int>();
            foreach (var item in a)
            {
                bool isAdded = b.Add(item);

                if (!isAdded)
                {
                    return item;
                }
            }

            return -1;
        }
    }
}
