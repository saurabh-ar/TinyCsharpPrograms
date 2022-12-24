using System;

namespace validateUserInputDatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userDatatypeInputToInt = 0;

            Console.WriteLine("Enter a value: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Select the Data type to validate the input you have entered.");
            Console.WriteLine("Press 1 for String\nPress 2 for Integer\nPress 3 for Boolean");
            Console.WriteLine("Enter your response below : ");
            string userDatatypeInput = Console.ReadLine();

            if (int.Parse(userDatatypeInput) == 1)
            {
                userDatatypeInputToInt = 1;
            }
            else if (int.Parse(userDatatypeInput) == 2)
            {
                userDatatypeInputToInt = 2;
            }
            else if (int.Parse(userDatatypeInput) == 3)
            {
                userDatatypeInputToInt = 3;
            }

            switch (userDatatypeInputToInt)
            {
                case 2:
                    Console.WriteLine("You have entered a value: {0}", userInput);
                    if (int.TryParse(userInput, out _))
                    {
                        Console.WriteLine("It is a valid: Integer");
                    }
                    else
                    {
                        Console.WriteLine("It is a invalid: Integer");
                    }
                    break;

                case 3:
                    Console.WriteLine("You have entered a value: {0}", userInput);
                    if (bool.TryParse(userInput, out _))
                        Console.WriteLine("It is a valid: Boolean");
                    else
                        Console.WriteLine("It is a invalid: Boolean");
                    break;
                // Since you cannot parse to string...if the previous statements came up false -> IT's STRING Type.
                case 1:
                    Console.WriteLine("You have entered a value: {0}", userInput);
                    if ((!bool.TryParse(userInput, out _)) && (!int.TryParse(userInput, out _)))
                    {
                        Console.WriteLine("It is a valid: String");
                    }
                    else
                    {
                        Console.WriteLine("It is a invalid: String");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
