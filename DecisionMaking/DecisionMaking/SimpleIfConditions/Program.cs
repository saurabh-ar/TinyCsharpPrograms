using System;

namespace SimpleIfConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string userInput = "";

            userInput = Console.ReadLine();

            try
            {
                i = int.Parse(userInput);
                if (i < 30)
                {
                    Console.WriteLine("its less than 30 degree celcius");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadKey();
        }
    }
}
