using System;

namespace myFirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human saurabh = new Human();
            saurabh.age = 32;
            saurabh.name = "A R Saurabh";

            saurabh.speak("Hey there, Whats up?");
        }
    }
}
