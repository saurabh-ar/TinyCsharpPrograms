using System;

namespace LearningTryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Learn Try Catch Finally!");
            Console.WriteLine("Please enter the input.");

            string userStringInput = Console.ReadLine();

            try
            {
                int userIntInput = int.Parse(userStringInput);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value too large or too large Excpetion");
            }
            catch (Exception)
            {
                Console.WriteLine("General Excpetion");
            }
            finally
            {
                // Generally used to close File/DB connection etc
                Console.WriteLine("This will run no matter what");
            }

            // Prevent window from closing
            Console.ReadKey();
        }
    }
}
