using System;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Please enter the sign or type Q to exit: ");
                string sign = Console.ReadLine();

                if(sign == "Q")
                {
                    exit = true;
                    continue;
                }

                Console.WriteLine("Please enter the first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = 0;

                //if(sign == "+")
                //{
                //    result = num1 + num2;
                //} else if(sign == "-")
                //{
                //    result = num1 - num2;
                //} else if(sign == "*")
                //{
                //    result = num1 * num2;
                //} else if(sign == "/")
                //{
                //    result = num1 / num2;
                //} else
                //{
                //    Console.WriteLine("Wrong operation");
                //}

                switch (sign)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Wrong operation");
                        break;
                }

                Console.WriteLine("Result: " + result); // "Result: 543"
            }
        }
    }
}
