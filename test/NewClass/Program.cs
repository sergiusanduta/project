using System;

namespace NewClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Q to exit");

            bool runApp = true;
            
            while (runApp)
            {
                try
                {
                    Console.WriteLine("Please enter a number");
                    string input = Console.ReadLine();
                    if (input.ToUpper() == "Q")
                    {
                        runApp = false;
                    }
                    else
                    {
                        int number = Convert.ToInt32(input);

                        if (number > 0)
                        {
                            Console.WriteLine("The {0} is positive", number);
                        }
                        
                        else if (number < 0)
                        {
                            Console.WriteLine("The {0} is negative", number);
                        }
                        else
                        {
                            Console.WriteLine("The {0} is neutru  ", number);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                } 
                finally
                {
                }
            
            }
        }    
    }    
}
