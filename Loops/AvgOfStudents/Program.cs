using System;

namespace AvgOfStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentMarksInput;
            int parsedInput;
            int totalMarks = 0; ;
            int i = 1;
            do
            {
                Console.WriteLine("Enter the marks of your subject : " + i);
                studentMarksInput = Console.ReadLine();
                if (int.TryParse(studentMarksInput, out parsedInput)){
                    Console.WriteLine("Marks entered by student is : " + parsedInput);
                    totalMarks = totalMarks + parsedInput;
                    Console.WriteLine("total Marks until now is " + totalMarks);
                    Console.WriteLine("---------");
                }
                i++;
            } while (i < 5);

            Console.WriteLine("Final Average Marks are : " + totalMarks/5);

          Console.ReadLine();
        }
    }
}
