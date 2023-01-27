using System;

namespace AbstractClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");

            Square square1 = new Square();
            square1.Length = 8;
            square1.Volume();
            Console.WriteLine("-----------");

        }
    }
}
