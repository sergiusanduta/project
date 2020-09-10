   using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            string name = "Hello";
            byte nume = 255;
            sbyte nr = 2;
            char character = 'a';
            uint number = 2;
            bool conditions = true;
            long numul = 100;
            ulong numbers = 200;
            decimal unu = 2000000.7008m;
            float doi = 3.14f;
            double two = 20.20;


            int[] random = new int[] { 24, 4, 6, 8 };
            char[] litere = new char[] { 'c', 'g', 'h' };
            bool[] condition = new bool[] {true,false,true, false};

            var cities = new List<string>() { "London", "New York", "Chicago", "Dallas" };

            var dictionary = new Dictionary<char,int>();
            dictionary.Add('D', 4);
            dictionary.Add('F',6);

            var hashset = new HashSet<int>();
            hashset.Add(4);
            hashset.Add(5);
            ///doesn't add to HashSet
            hashset.Add(4);



            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine(cities[i]);
            }

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            foreach (int item in hashset)
            {
                Console.WriteLine(item);
            }

            int[] arr = hashset.ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // Key : value
            // D : 4 
            // F : 6


            foreach (KeyValuePair<char, int> data in dictionary)
            {
                Console.WriteLine("{0} : {1}", data.Key, data.Value);
            }

            
        }
    }
}
