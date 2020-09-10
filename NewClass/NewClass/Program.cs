using System;
using System.Diagnostics.CodeAnalysis;

namespace NewClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter quizz score");
            int quizScore1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce mid score");
            int midScore = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce final score");
            int finScore = int.Parse(Console.ReadLine());

            int avg = (quizScore1 + midScore + finScore) / 3;

            if (avg >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (avg >= 70 && avg < 90) 
            {
                Console.WriteLine("Grade B");
            }

            else if (avg >= 50 && avg < 70)
            {
                Console.WriteLine("Grade C");
            }
        }    

    }

}
