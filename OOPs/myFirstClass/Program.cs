using System;

namespace myFirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Different Constructors ");
            
            Human saurabh = new Human("A R", "Saurabh", "black", 32);
            saurabh.IntroduceYourself();

            Human vivek = new Human("A R", "Vivek", "black");
            vivek.IntroduceYourself();

            Human suresh = new Human("Suresh", "Dua");
            suresh.IntroduceYourself();

        }
    }
}
