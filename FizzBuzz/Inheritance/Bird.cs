using System.Security.Authentication;

namespace Inheritance
{
    public class Bird : Animal 
    {
        public  Bird(string birdName) : base(birdName)
        {

        }
        public void Chirip()
        {
            System.Console.WriteLine("cirip");
        }
    }
}
