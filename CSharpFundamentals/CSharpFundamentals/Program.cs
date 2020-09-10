using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Text;

namespace CSharpFundamentals // are used to organize and provide a level of separation of codes//
{
    ///Class is the code that defines the characteristics of an object; it contains methods, fields, events //
   class Cars     
    {           
               // Field is a variable of any type that is declared directly in a class or struct//
        string color = "red";
        string model;
        int year;
        int maxSpeed = 300;

             //Method- are used to perform certain actions and they defines how an object of a class behave //
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        static void Main(string[] args)


        {  
            ///Object - is a block of memory that contain code and data/// 
            Cars BMW = new Cars();
            BMW.fullThrottle();     // Call the method  


            //Arrays are used to store multiple values in a single variable//



            









            //var numbers = new List<int>() {1,2,3,4 };
            //numbers.Add(1);
            //numbers.AddRange(new int[3] {5,6,7 });

            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            //Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            //Console.WriteLine("Count: " + numbers.Count);



            //for(var i=0; i<numbers.Count; i++)
            //{
            //    if (numbers[i] == 1)
            //        numbers.Remove(numbers[i]);
            //}
            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //numbers.Clear();
            //Console.WriteLine("Count: " + numbers.Count );
        }

    }
}
