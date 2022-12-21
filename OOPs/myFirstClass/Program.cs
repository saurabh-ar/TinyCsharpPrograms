using System;

namespace myFirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the following details : ");
            Human saurabh = new Human("A R", "Saurabh", "black", 32);
            saurabh.IntroduceYourself();
        }
    }
}
