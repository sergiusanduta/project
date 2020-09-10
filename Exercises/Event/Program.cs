using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Event
{
    class Program
    {

        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Valisa");

            foreach (var lis in list)
            {

            Console.WriteLine(lis);
            }
        }

    }
}