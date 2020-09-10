using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Linq
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] numbers = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };

            IEnumerable<int> c = GetNumbersDivisibleByTwo(numbers);

            IEnumerable<int> b = Enumerable.Range(1, 70);

            IEnumerable<int> filtered = GetNumbersBetween25And50(b);


            IEnumerable<int> squares = GetSquareOfeachNumber(b);
            foreach (var n in squares)
            {
                Console.WriteLine(n);
            }
            

            string[] cities = { "Rome", "London", "Amsterdam", "Parris", "Los Angeles", "Luxembourg" };
            
            IEnumerable<string> g = GetCitiesThatStartsWithL(cities);

            foreach (string  s in g)
            {
                Console.WriteLine(s);
            }

            int[] number = { 1, 2, 3, 4 };
            var query = from x in number
                        where x % 2 == 0
                        select x * 2;

            foreach (var n in query)
            {
                Console.WriteLine(n);
            }
        }

       

            private static IEnumerable<string> GetCitiesThatStartsWithL(string[] cities)
            {
                var results = new List<string>();

                foreach (string v in cities)
                {
                    if (v[0] == 'L')
                    {
                        results.Add(v);
                    }
                }



                return results;
            }





            private static IEnumerable<int> GetSquareOfeachNumber(IEnumerable<int> b)
            {
                // 1 , 2 ,3 ,4 ,5 -> , 4, 9, 16, 25
                var nums = new List<int>();
                foreach (var n in b)
                {
                    int number = n * n;
                    nums.Add(number);
                }



                return nums;
            }


            private static IEnumerable<int> GetNumbersBetween25And50(IEnumerable<int> b)
            {
                //TODO : Return a new list of all numbese between 25 and 50
                var nums = new List<int>();

                foreach (int n in b)
                {
                    if (n >= 25 && n <= 50)
                    {
                        nums.Add(n);
                    }
                }


                return nums;
            }

            public static IEnumerable<int> GetNumbersDivisibleByTwo(int[] numbers)
            {
               var  nums = new List<int>();

                // return a list of numbers divisible by 2
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        nums.Add(numbers[i]);
                    }


                }
                return nums;
            }
    }
}
