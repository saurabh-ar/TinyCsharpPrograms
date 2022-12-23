using System;

namespace learningProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);

            box.displayInfo();
            Console.ReadLine();
        }
    }
}
