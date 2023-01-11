using System;

namespace JaggedArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jagged Array Declaration : An Array containing 3 more arrays inside it.
            
            int[][] jaggedArray = new int[3][];

            // Intialization
            
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            // Assigning Values

            jaggedArray[0] = new int[] { 12, 45, 63, 78, 95 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 2, 3 };

            // Printing Out Values : 1st Jagged Array's 3rd Value i.e '5'

            Console.WriteLine(jaggedArray[0][2]);

            // for-each loop to print values

            for (int i =0;i<jaggedArray.Length;i++)
            {
                foreach (var item in jaggedArray[i])
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------");
            }
        }
    }
}
