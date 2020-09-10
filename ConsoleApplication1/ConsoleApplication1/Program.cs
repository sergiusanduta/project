            using System;
            using System.ComponentModel.DataAnnotations;
            using System.Diagnostics.CodeAnalysis;
            using System.Dynamic;
            using System.IO;
            using System.Net.Http.Headers;
            using System.Reflection.Emit;
            using System.Reflection.Metadata;
            using System.Runtime.CompilerServices;
            using System.Security.Cryptography.X509Certificates;

            namespace ConsoleApplication1
            {
            class Program
            {

            static void Main(string[]args)
            {
            for (int i = 1; i < 100; i++)
            {
            if (i % 3 == 0 && i % 2 == 0)
            {
                Console.WriteLine("FizzBuzz");

            }

            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }


            }

            }
            }
            }
