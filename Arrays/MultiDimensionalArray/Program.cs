using System;

namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2d Array
            int[,] twoDArray = new int[,] 
            { 
                { 0, 0 },  //row 1
                { 0, 1 },  //row 2
                { 1, 0 },  //row 3
                { 1, 1 }   //row 4
            };

            //3d Array
            int[,,] threeDArray = new int[,,]
            {
                { //row 1
                    {0,1,2},
                    {3,4,5}
                },
                { //row 2
                    {0,0,7},
                    {1,0,9}
                },
                { //row 3
                    {8,0,7},
                    {9,0,9}
                }
            };

           // Printing Array as a matrix form which we cant do with foreach loop

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    Console.Write(twoDArray[i,j] + " ");
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < threeDArray.GetLength(0); i++)
            {
                for (int j = 0; j < threeDArray.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDArray.GetLength(1); k++)
                    {
                        Console.Write(threeDArray[i, j, k] + " ");
                    }
                        
                }
                Console.WriteLine("");
            }
        }
    }
}
