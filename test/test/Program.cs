using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Transactions;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number between 1 and 12");
        var number = Convert.ToInt32 (Console.ReadLine());

       

        switch (number)
        {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("February");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("Octomber");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("Your number is invalid");
                break;
        }

    }

}    