using System;

namespace FirstPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("BMW Default Constructor");
            BMW bmw1= new BMW();
            BMW bmw2= new BMW(2000,"red", "D-Class","BMW");
            bmw1.showDetails();

            Console.WriteLine("BMW Paametertized Constructor");
            bmw2.showDetails();
        }
    }
}