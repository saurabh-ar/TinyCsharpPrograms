using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array declaration
            int i = 0;
            int parsedRes=0;
            string userInput;
            int[] grades = new int[5];
            while (i < grades.Length)
            {
                Console.WriteLine($"Please Enter a Value for Grade {i} :");
                
                try
                {
                    userInput  = Console.ReadLine();
                    
                    if (userInput != null)
                    {
                        parsedRes = Convert.ToInt32(userInput);
                    }
                    grades[i] = parsedRes;
                    i++;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Terminating the program.");
                    break;
                }

            }
            i = 0;
            if (grades[3] > 4)
            {
                while (i < grades.Length)
                {
                    Console.WriteLine($"grade value {i} : {grades[i]}");
                    i++;
                }
            }

        }
    }
}
