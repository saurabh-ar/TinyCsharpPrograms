using System;

namespace UsingTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int parsedValue;
            int number;


            Console.WriteLine("Enter a Value to Parse as Int :");
            userInput= Console.ReadLine();

            int.TryParse(userInput, out parsedValue);
            Console.WriteLine(parsedValue);
            Console.WriteLine("Parsed Value Type" + parsedValue.GetType());
            Console.WriteLine(int.TryParse(userInput, out parsedValue));
            while (userInput == "" || userInput == null)
            {
                Console.WriteLine("Please Enter a VALID Value to Parse as Int :");
                userInput = Console.ReadLine();
            }

            if (int.TryParse(userInput, out parsedValue))
            {
                number = parsedValue;
                Console.WriteLine(number + " <-- is the Parsed Value.");
            }
            else
            {
                number = 0;
                Console.WriteLine("You donot have entered a value has 0 is getting assigned");
            }

        }
    }
}
