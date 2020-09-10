using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;

namespace Practice
{
    public delegate void PressKeyEventHandler();

    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyA = null;
        public event PressKeyEventHandler PressKeyB = null;

        public void PressKeyAEvent()
        {
            if(PressKeyA != null)
            {
                PressKeyA.Invoke();
            }
        }
        public void PressKeyBEvent()
        {
            if(PressKeyB != null)
            {
                PressKeyB.Invoke();
            }
        }
        public void Start()
        {
            while (true)
            {
                string s =  Console.ReadLine();
                
                switch (s)
                {
                    case "A"  :
                    case "a":
                        PressKeyA();
                        break;
                    case "B":
                    case "b":
                        PressKeyB();
                        break;
                    case "exit":
                        goto Exit;

                    default:
                        Console.WriteLine("Doesn't execute current request {0}" , s);
                        break;
                }
            }
            Exit:
            Console.WriteLine("Exit");
        }
    }


    class Program
    {
        static private void PressKeyA_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("    X    ");
            Console.WriteLine("   X X   ");
            Console.WriteLine("  X   X  ");
            Console.WriteLine(" XXXXXXX ");
            Console.WriteLine("X       X");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
        }




        static private void PressKeyB_Handler()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("XXXX  ");
            Console.WriteLine("X   X ");
            Console.WriteLine("XXXXX ");
            Console.WriteLine("X    X");
            Console.WriteLine("XXXXX ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        

        static void Main(string[] args)
        {
            Keyboard instance = new Keyboard();
            instance.PressKeyA += new PressKeyEventHandler(PressKeyA_Handler);
            instance.PressKeyB += PressKeyB_Handler;

            instance.Start();

        }
    }
}
