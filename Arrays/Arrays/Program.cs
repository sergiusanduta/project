using System;
using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework
            // Find max number, find min number
            int[] numbers = new int[] { 1, 2, 4, 5, 67, 89, 90 };


            // data types, classes, methods //


            /////
            ///

            //int[] winters = new int[10];
            // for (int i = 0; i < 10; i++)
            //{
            //    winters[i] = i + 100;
            //    Console.WriteLine(winters[i]);
            //}

            //int[] winner = new int[3] { 10, 2, 5 };
            //foreach (int i in winner)
            //{
            //    Console.WriteLine(i);
            //}
            //for(int i=winner.Length-1; i<winner.Length; i--)
            //{
            //    Console.WriteLine( winner[i]);
            //}












            //Write a program in C# Sharp to store elements in an array and print it. 
            //                 Test Data:
            //Input 10 elements in the array:
            //                 numbers[0] = 1
            //                 numbers[1] = 2


            //int[] numbers = new int[10];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i + 1;
            //    Console.WriteLine(numbers[i]);
            //}


            ///*
            // Write a program in C# Sharp to read a number of values in an array and display it in reverse order.
            //Test Data :
            //Input the number of elements to store in the array :3
            //Input 3 number of elements in the array :
            //element - 0 : 2
            //element - 1 : 5
            //element - 2 : 7
            //Expected Output:
            //The values store into the array are:
            //2 5 7
            //The values store into the array in reverse are :
            //7 5 2

            //int[] numbers = new int[3] { 2, 5, 7 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine("The value store into the array are:  " + i);
            //}

            //for (int i = numbers.Length - 1; i >=0; i--)
            //{


            //    Console.WriteLine("The value store into the array in reverse are: " + numbers[i]);
            //}

            //*/

            //
            // Write a program in C# Sharp to find the sum of all elements of the array. 
            //Test Data :
            //Input the number of elements to be stored in the array :3
            //Input 3 elements in the array :
            //element - 0 : 2
            //element - 1 : 5
            //element - 2 : 8
            //Expected Output :
            //Sum of all elements stored in the array is : 15



            //int[] numbers = new int[3] { 2, 5, 8 };
            //int totalSum = 0;

            ////foreach (int number in numbers)
            ////{
            ////    totalSum = totalSum + number;
            ////}

            //for (int  i = 0;  i < numbers.Length;  i++)
            //{
            //    totalSum = totalSum + numbers[i];
            //}
            //Console.WriteLine(totalSum);



            // Write a program in C# Sharp to copy the elements one array into another array. 
            //  Test Data :
            //Input the number of elements to be stored in the array :3
            //Input 3 elements in the array :
            //element - 0 : 15
            //element - 1 : 10
            //element - 2 : 12
            //Expected Output:
            //The elements stored in the first array are :
            //15 10 12
            //The elements copied into the second array are :
            //15 10 12

            int[] nums = new int[] { 15, 10, 12 };
            int[] copyArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                copyArray[i] = nums[i];
                WriteWithColor(copyArray[i].ToString(), ConsoleColor.Red);
                WriteWithColor(copyArray[i].ToString(), ConsoleColor.Yellow);
                WriteWithColor(copyArray[i].ToString(), ConsoleColor.Blue);
            }

            Console.ReadKey();
        }

        public static void WriteWithColor(string word, ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.WriteLine(word);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}








//int[] original = new int[] { 15, 10, 12 };
//int[] copyoforiginal = getcopy(original);
//console.readkey();

//}

//private static int[] getcopy(int[] original)
//{
//    throw new notimplementedexception();
//}

//private static int getsum(int[] mynumbers)
//{
//    throw new notimplementedexception();

