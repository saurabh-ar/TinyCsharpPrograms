using System;

namespace TakeTwoInputsToAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNumberInput, secondNumberInput;
            Console.WriteLine("Enter First Number");
            firstNumberInput = Console.ReadLine();

            Console.WriteLine("Enter Second Number");
            secondNumberInput = Console.ReadLine();
            Console.WriteLine("Sum of the Numbers is");

            Console.WriteLine(Sum(firstNumberInput, secondNumberInput));
        }
        public static int Sum(string num1, string num2) { 
            int number1 = int.Parse(num1);
            int number2 = int.Parse(num2);
            return number1+ number2;
        }
    }
}
