using System;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog("Rex");
            rex.SayWoof();
            rex.Eat();


            Cat firstCat = new Cat("Murzik");
            firstCat.SayMeow();
            firstCat.Eat();
            

            Bird greatBird = new Bird("Eagle");
            greatBird.Chirip();
            greatBird.Eat();
            Console.ReadKey();
            
        }
    }
}
