using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListDIctionaryHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> Valiusa = new Dictionary<int, string>();
            //Valiusa.Add(2, "Sergiu");
            //Valiusa.Add(3, "Dorian");
            //Valiusa.Add(1, "Melissa");

            //if (Valiusa.ContainsKey(3) ==true)
            //{
            //    Console.WriteLine("Key is found");
            //}

            //else
            //{
            //    Console.WriteLine("Key is not found");
            //}


            //if (Valiusa.ContainsValue("Alexandra")==true)
            //{
            //    Console.WriteLine("The values is found");
            //}

            //else
            //{
            //    Console.WriteLine("The Value is not found");
            //}



           
            ///
            //List<int> odd = new List<int>();
            //for (int i = 0; i <5; i++)
            //{
            //    odd.Add(2 * i + 1);
            //}

            //foreach (var i in odd)
            //{
            //    Console.WriteLine(i);
            //}


            Stack myStack = new Stack();
            myStack.Push("Hello World");
            myStack.Push(3);
            myStack.Clear();
            

            Console.WriteLine("This is stack :" +myStack.Count);
            Console.ReadKey();

            
        }
    }
           
}
