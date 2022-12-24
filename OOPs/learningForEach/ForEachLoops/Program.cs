using System;

namespace ForEachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array Declaration & Intialization
            string[] arr = new string[5];

            // Wrong Array Intialisation
            // arr = { "Me","Me","Me","Me","Me"}

            // Correct Way : You can declare an array without intializing it.
            // But you must new keyword to when you assign a new array to it.
            arr = new string[] {"saurabh", "I", "me", "myself", "rajiv"};

            // Loop to all of the array elements
            // ForEach Loop
            foreach (var item in arr)
            {
                Console.WriteLine($"Hello there {item.ToUpper()}, Welcome to Learn C#");
            }

            Console.ReadKey();
        }
    }
}
